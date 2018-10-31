using NAudio.Midi;
using NAudio.Wave;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuvalWavePlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private DummyObjectOnlyForTrackingControl thisIsWhatIsIs = new DummyObjectOnlyForTrackingControl();
        

        private bool interruptAutoPlay = false;
        private PlayList CurrentPlaylist { get; set; } = null;
        private int playerDevice = 0;
        private long currentFileMaxLength = 0;
        private WaveOut waveOutPlayer = new WaveOut();
        private String currentFilePlaying = "";
        private WaveStream currentOutputStream = null;
        private PlayListFile filePlaying = null;
        private bool userStopped = false;
        private WaveStream mainOutputStream = null;
        private int autoPlayCount = 0;
        //private List<MidiIn> midiDevs = new List<MidiIn>();
        private MidiIn midiIn = null;
        
        private WaveFileReader loopReader = null;
        private LoopStream loop = null;


        private Dictionary<String, MidiControlAction> midiControls = new Dictionary<string, MidiControlAction>();
        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxPlayList.DisplayMember = "Label";
            listBoxPlayList.ValueMember = "FileName";

            
            buttonRefreshDevices_Click(sender, e);


           
            waveOutPlayer.PlaybackStopped += WaveOutPlayer_PlaybackStopped;

            this.Top = int.TryParse(ConfigurationManager.AppSettings["FormTop"], out int top) ? top : this.Top;
            this.Left = int.TryParse(ConfigurationManager.AppSettings["FormLeft"], out int left) ? left : this.Left;

            this.Width= int.TryParse(ConfigurationManager.AppSettings["FormWidth"], out int width) ? width : this.Width;
            this.Height= int.TryParse(ConfigurationManager.AppSettings["FormHeight"], out int height) ? height: this.Height;

        }

        private void WaveOutPlayer_PlaybackStopped(object sender, StoppedEventArgs e)
        {

            /*if (checkBoxAutoPlay.Checked)
            {
                if (!userStopped)
                {
                    buttonForward_Click(null, e);

                    timerAutoPlay.Enabled = true;
                    timerAutoPlay.Start();

                }
            }
            userStopped = false;
            */

            Action a = null;

            if (!userStopped)
            {

                bool wasInLoop = checkBoxLoop.Checked; 

                a = new Action(() =>
                {
                    buttonStop_Click(null, e);
                    buttonForward_Click(null, e);
                    if (wasInLoop)
                    {
                        buttonPlay_Click(null, e);

                        if (loop != null)
                        {
                            loop.Close();
                            loop = null;

                            loopReader.Close();
                            loopReader = null;
                        }

                    }
                }
                );
            }

            if (!checkBoxLoop.Checked)
            {
                a = new Action(() =>
                {

                    timerFileProgress.Enabled = false;
                    timerFileProgress.Stop();
                    if (!userStopped)
                    {
                        buttonForward_Click(thisIsWhatIsIs, e);
                    }
                });
            }

            if (a != null)
            {
                this.Invoke(a);
            }

            userStopped = false;
        }
        private void LoadPlaylist()
        {

            if (String.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["InitialPlaylist"]))
            {
                CurrentPlaylist = new PlayList()
                {
                    Name = "New Playlist",
                    FileName = ""
                };
            }
            else
            {
                OpenPlayListFile(ConfigurationManager.AppSettings["InitialPlaylist"]);
            }

            FillPlaylist();

        }

        private void OpenPlayListFile(string filename)
        {

            if (!String.IsNullOrWhiteSpace(filename) && System.IO.File.Exists(filename))
            {
                CurrentPlaylist = new PlayList()
                {
                    Name = "Empty Playlist",
                    FileName = filename
                };

                String[] data = File.ReadAllLines(filename);

                if (data.Length >= 1)
                {
                    String name = data[0].Trim();

                    if (!String.IsNullOrWhiteSpace(name))
                    {
                        CurrentPlaylist.Name = name;
                    }


                    for (int i = 1; i < data.Length; i++)
                    {
                        String fileDataTemp = data[i].Trim();
                        if (!String.IsNullOrWhiteSpace(fileDataTemp))
                        {
                            CurrentPlaylist.FileList.Add(JsonConvert.DeserializeObject<PlayListFile>(fileDataTemp));
                        }
                    }

                }



            }
        }

        private void FillPlaylist()
        {
            if (CurrentPlaylist == null)
            {
                CurrentPlaylist = new PlayList()
                {
                    FileList = new List<PlayListFile>(),
                    FileName = "",
                    Name = "New Playlist"
                };
            }

            textBoxPlaylistName.Text = CurrentPlaylist.Name;

            listBoxPlayList.Items.Clear();

            foreach (PlayListFile file in CurrentPlaylist.FileList)
            {
                listBoxPlayList.Items.Add(file);
            }

            if (listBoxPlayList.Items.Count > 0)
            {
                buttonForward_Click(this, null);
            }
        }

        private void buttonRefreshDevices_Click(object sender, EventArgs e)
        {
            ConfigurationManager.RefreshSection("appSettings");
            if (ConfigurationManager.AppSettings["Volume"] != null && int.TryParse(ConfigurationManager.AppSettings["Volume"], out int vol))
            {
                waveOutPlayer.Volume = ((float)vol)/ 100;
            }

            int deviceCount = NAudio.Wave.WaveOut.DeviceCount;
            comboBoxOutputDevices.Items.Clear();
            comboBoxOutputDevices.DisplayMember = "Value";
            comboBoxOutputDevices.ValueMember = "Key";
            for (int i = 0; i < deviceCount; i++)
            {
                WaveOutCapabilities cap = NAudio.Wave.WaveOut.GetCapabilities(i);
                int index = comboBoxOutputDevices.Items.Add(new KeyValuePair<int, String>(i, cap.ProductName));
                if (cap.ProductName.Equals(ConfigurationManager.AppSettings["OutputDevice"]))
                {
                    comboBoxOutputDevices.SelectedIndex = index;
                    playerDevice = index;
                }
            }


            if (comboBoxOutputDevices.SelectedIndex >= 0)
            {
                comboBoxOutputDevices_SelectedIndexChanged(sender, e);
            }

            trackBarVolume.Value = (int)(waveOutPlayer.Volume * 100);
            

            //checkBoxAutoPlay.Checked = (ConfigurationManager.AppSettings["AutoPlay"] != null && bool.TryParse(ConfigurationManager.AppSettings["AutoPlay"], out bool autoplay) ? autoplay : false);

            /*foreach (MidiIn midiIn in midiDevs)
            {
                midiIn.Stop();
                midiIn.Close();
                midiIn.Dispose();
            }

            midiDevs.Clear();*/
            button2_Click(sender, e);

            comboBoxMidiDevices.Items.Clear();
            comboBoxMidiDevices.SelectedIndex = -1;
            for (int midiDev = 0; midiDev < MidiIn.NumberOfDevices; midiDev++)
            {
                MidiInCapabilities midiInDev = MidiIn.DeviceInfo(midiDev);
                comboBoxMidiDevices.Items.Add(midiInDev);
             
                
                if (midiInDev.ProductName == ConfigurationManager.AppSettings["MidiInDevice"])
                {
                    comboBoxMidiDevices.SelectedIndex = midiDev;
                }
            }

            

            checkBoxAutoSave.Checked = (ConfigurationManager.AppSettings["AutoSave"] != null && bool.TryParse(ConfigurationManager.AppSettings["AutoSave"], out bool autosave) ? autosave : false);


            textBoxMidiControlBack.Text = ConfigurationManager.AppSettings["MidiBack"];
            textBoxMidiControlForth.Text = ConfigurationManager.AppSettings["MidiForth"];
            textBoxMidiControlPause.Text = ConfigurationManager.AppSettings["MidiPause"];
            textBoxMidiControlPlay.Text = ConfigurationManager.AppSettings["MidiPlay"];
            textBoxMidiControlStop.Text = ConfigurationManager.AppSettings["MidiStop"];
            textBoxMidiControlTrack.Text = ConfigurationManager.AppSettings["MidiTrack"];
            textBoxMidiControlVol.Text = ConfigurationManager.AppSettings["MidiVol"];


            checkBoxMidiChannel1.Checked = (ConfigurationManager.AppSettings["MidiChannel1"] != null && bool.TryParse(ConfigurationManager.AppSettings["MidiChannel1"], out bool midi1) ? midi1 : false);
            checkBoxMidiChannel2.Checked = (ConfigurationManager.AppSettings["MidiChannel2"] != null && bool.TryParse(ConfigurationManager.AppSettings["MidiChannel2"], out bool midi2) ? midi2 : false);
            checkBoxMidiChannel3.Checked = (ConfigurationManager.AppSettings["MidiChannel3"] != null && bool.TryParse(ConfigurationManager.AppSettings["MidiChannel3"], out bool midi3) ? midi3 : false);
            checkBoxMidiChannel4.Checked = (ConfigurationManager.AppSettings["MidiChannel4"] != null && bool.TryParse(ConfigurationManager.AppSettings["MidiChannel4"], out bool midi4) ? midi4 : false);
            checkBoxMidiChannel5.Checked = (ConfigurationManager.AppSettings["MidiChannel5"] != null && bool.TryParse(ConfigurationManager.AppSettings["MidiChannel5"], out bool midi5) ? midi5 : false);
            checkBoxMidiChannel6.Checked = (ConfigurationManager.AppSettings["MidiChannel6"] != null && bool.TryParse(ConfigurationManager.AppSettings["MidiChannel6"], out bool midi6) ? midi6 : false);
            checkBoxMidiChannel7.Checked = (ConfigurationManager.AppSettings["MidiChannel7"] != null && bool.TryParse(ConfigurationManager.AppSettings["MidiChannel7"], out bool midi7) ? midi7 : false);
            checkBoxMidiChannel8.Checked = (ConfigurationManager.AppSettings["MidiChannel8"] != null && bool.TryParse(ConfigurationManager.AppSettings["MidiChannel8"], out bool midi8) ? midi8 : false);
            checkBoxMidiChannel9.Checked = (ConfigurationManager.AppSettings["MidiChannel9"] != null && bool.TryParse(ConfigurationManager.AppSettings["MidiChannel9"], out bool midi9) ? midi9 : false);
            checkBoxMidiChannel10.Checked = (ConfigurationManager.AppSettings["MidiChannel10"] != null && bool.TryParse(ConfigurationManager.AppSettings["MidiChannel10"], out bool midi10) ? midi10 : false);
            checkBoxMidiChannel11.Checked = (ConfigurationManager.AppSettings["MidiChannel11"] != null && bool.TryParse(ConfigurationManager.AppSettings["MidiChannel11"], out bool midi11) ? midi11 : false);
            checkBoxMidiChannel12.Checked = (ConfigurationManager.AppSettings["MidiChannel12"] != null && bool.TryParse(ConfigurationManager.AppSettings["MidiChannel12"], out bool midi12) ? midi12 : false);
            checkBoxMidiChannel13.Checked = (ConfigurationManager.AppSettings["MidiChannel13"] != null && bool.TryParse(ConfigurationManager.AppSettings["MidiChannel13"], out bool midi13) ? midi13 : false);
            checkBoxMidiChannel14.Checked = (ConfigurationManager.AppSettings["MidiChannel14"] != null && bool.TryParse(ConfigurationManager.AppSettings["MidiChannel14"], out bool midi14) ? midi14 : false);
            checkBoxMidiChannel15.Checked = (ConfigurationManager.AppSettings["MidiChannel15"] != null && bool.TryParse(ConfigurationManager.AppSettings["MidiChannel15"], out bool midi15) ? midi15 : false);
            checkBoxMidiChannel16.Checked = (ConfigurationManager.AppSettings["MidiChannel16"] != null && bool.TryParse(ConfigurationManager.AppSettings["MidiChannel16"], out bool midi16) ? midi16 : false);



            textBoxMidiCommandReload.Text = ConfigurationManager.AppSettings["MidiCommandReload"];

            textBoxMidiControlBack_TextChanged(sender, e);
            textBoxMidiControlForth_TextChanged(sender, e);
            textBoxMidiControlPause_TextChanged(sender, e);
            textBoxMidiControlPlay_TextChanged(sender, e);
            textBoxMidiControlStop_TextChanged(sender, e);
            textBoxMidiControlTrack_TextChanged(sender, e);
            textBoxMidiControlVol_TextChanged(sender, e);


            numericUpDownAutoPlay.Value = (ConfigurationManager.AppSettings["AutoPlay"] != null && int.TryParse(ConfigurationManager.AppSettings["AutoPlay"], out int _autoPlay) ? _autoPlay: 0);

            checkBoxAutoPlay.Checked = numericUpDownAutoPlay.Value > 0;


            LoadPlaylist();

            button1_Click_1(sender, e);
        }

        private void buttonSaveConfig_Click(object sender, EventArgs e)
        {
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            if (config.AppSettings.Settings["OutputDevice"] == null)
            {
                config.AppSettings.Settings.Add(new KeyValueConfigurationElement("OutputDevice", ""));
            }
            config.AppSettings.Settings["OutputDevice"].Value = comboBoxOutputDevices.SelectedItem != null ? ((KeyValuePair<int, String>)comboBoxOutputDevices.SelectedItem).Value : "";

            if (config.AppSettings.Settings["InitialPlaylist"] == null)
            {
                config.AppSettings.Settings.Add(new KeyValueConfigurationElement("InitialPlaylist", ""));
            }
            config.AppSettings.Settings["InitialPlaylist"].Value = CurrentPlaylist.FileName;

            if (config.AppSettings.Settings["Volume"] == null)
            {
                config.AppSettings.Settings.Add(new KeyValueConfigurationElement("Volume", ""));
            }
            config.AppSettings.Settings["Volume"].Value = trackBarVolume.Value.ToString() ;

            /*if (config.AppSettings.Settings["AutoPlay"] == null)
            {
                config.AppSettings.Settings.Add(new KeyValueConfigurationElement("AutoPlay", ""));
            }
            config.AppSettings.Settings["AutoPlay"].Value = checkBoxAutoPlay.Checked.ToString();*/

            if (config.AppSettings.Settings["MidiInDevice"] == null)
            {
                config.AppSettings.Settings.Add(new KeyValueConfigurationElement("MidiInDevice", ""));
            }
            config.AppSettings.Settings["MidiInDevice"].Value = comboBoxMidiDevices.SelectedItem != null ? ((MidiInCapabilities)comboBoxMidiDevices.SelectedItem).ProductName : "";

            if (config.AppSettings.Settings["AutoSave"] == null)
            {
                config.AppSettings.Settings.Add(new KeyValueConfigurationElement("AutoSave", ""));
            }
            config.AppSettings.Settings["AutoSave"].Value = checkBoxAutoSave.Checked.ToString();

            if (config.AppSettings.Settings["FormTop"] == null)
            {
                config.AppSettings.Settings.Add(new KeyValueConfigurationElement("FormTop", ""));
            }
            config.AppSettings.Settings["FormTop"].Value = this.Top.ToString();


            if (config.AppSettings.Settings["FormLeft"] == null)
            {
                config.AppSettings.Settings.Add(new KeyValueConfigurationElement("FormLeft", ""));
            }
            config.AppSettings.Settings["FormLeft"].Value = this.Left.ToString();


            if (config.AppSettings.Settings["FormWidth"] == null)
            {
                config.AppSettings.Settings.Add(new KeyValueConfigurationElement("FormWidth", ""));
            }
            config.AppSettings.Settings["FormWidth"].Value = this.Width.ToString();

            if (config.AppSettings.Settings["FormHeight"] == null)
            {
                config.AppSettings.Settings.Add(new KeyValueConfigurationElement("FormHeight", ""));
            }
            config.AppSettings.Settings["FormHeight"].Value = this.Height.ToString();




            if (config.AppSettings.Settings["MidiBack"] == null)
            {
                config.AppSettings.Settings.Add(new KeyValueConfigurationElement("MidiBack", ""));
            }
            config.AppSettings.Settings["MidiBack"].Value = this.textBoxMidiControlBack.Text;


            if (config.AppSettings.Settings["MidiForth"] == null)
            {
                config.AppSettings.Settings.Add(new KeyValueConfigurationElement("MidiForth", ""));
            }
            config.AppSettings.Settings["MidiForth"].Value = this.textBoxMidiControlForth.Text;


            if (config.AppSettings.Settings["MidiPlay"] == null)
            {
                config.AppSettings.Settings.Add(new KeyValueConfigurationElement("MidiPlay", ""));
            }
            config.AppSettings.Settings["MidiPlay"].Value = this.textBoxMidiControlPlay.Text;


            if (config.AppSettings.Settings["MidiStop"] == null)
            {
                config.AppSettings.Settings.Add(new KeyValueConfigurationElement("MidiStop", ""));
            }
            config.AppSettings.Settings["MidiStop"].Value = this.textBoxMidiControlStop.Text;


            if (config.AppSettings.Settings["MidiPause"] == null)
            {
                config.AppSettings.Settings.Add(new KeyValueConfigurationElement("MidiPause", ""));
            }
            config.AppSettings.Settings["MidiPause"].Value = this.textBoxMidiControlPause.Text;

            if (config.AppSettings.Settings["MidiVol"] == null)
            {
                config.AppSettings.Settings.Add(new KeyValueConfigurationElement("MidiVol", ""));
            }
            config.AppSettings.Settings["MidiVol"].Value = this.textBoxMidiControlVol.Text;


            if (config.AppSettings.Settings["MidiTrack"] == null)
            {
                config.AppSettings.Settings.Add(new KeyValueConfigurationElement("MidiTrack", ""));
            }
            config.AppSettings.Settings["MidiTrack"].Value = this.textBoxMidiControlTrack.Text;



            if (config.AppSettings.Settings["MidiChannel1"] == null)
            {
                config.AppSettings.Settings.Add(new KeyValueConfigurationElement("MidiChannel1", ""));
            }
            config.AppSettings.Settings["MidiChannel1"].Value = checkBoxMidiChannel1.Checked.ToString();

            if (config.AppSettings.Settings["MidiChannel16"] == null)
            {
                config.AppSettings.Settings.Add(new KeyValueConfigurationElement("MidiChannel16", ""));
            }
            config.AppSettings.Settings["MidiChannel16"].Value = checkBoxMidiChannel16.Checked.ToString();

            if (config.AppSettings.Settings["MidiChannel15"] == null)
            {
                config.AppSettings.Settings.Add(new KeyValueConfigurationElement("MidiChannel15", ""));
            }
            config.AppSettings.Settings["MidiChannel15"].Value = checkBoxMidiChannel15.Checked.ToString();

            if (config.AppSettings.Settings["MidiChannel14"] == null)
            {
                config.AppSettings.Settings.Add(new KeyValueConfigurationElement("MidiChannel14", ""));
            }
            config.AppSettings.Settings["MidiChannel14"].Value = checkBoxMidiChannel14.Checked.ToString();

            if (config.AppSettings.Settings["MidiChannel13"] == null)
            {
                config.AppSettings.Settings.Add(new KeyValueConfigurationElement("MidiChannel13", ""));
            }
            config.AppSettings.Settings["MidiChannel13"].Value = checkBoxMidiChannel13.Checked.ToString();

            if (config.AppSettings.Settings["MidiChannel12"] == null)
            {
                config.AppSettings.Settings.Add(new KeyValueConfigurationElement("MidiChannel12", ""));
            }
            config.AppSettings.Settings["MidiChannel12"].Value = checkBoxMidiChannel12.Checked.ToString();

            if (config.AppSettings.Settings["MidiChannel11"] == null)
            {
                config.AppSettings.Settings.Add(new KeyValueConfigurationElement("MidiChannel11", ""));
            }
            config.AppSettings.Settings["MidiChannel11"].Value = checkBoxMidiChannel11.Checked.ToString();

            if (config.AppSettings.Settings["MidiChannel10"] == null)
            {
                config.AppSettings.Settings.Add(new KeyValueConfigurationElement("MidiChannel10", ""));
            }
            config.AppSettings.Settings["MidiChannel10"].Value = checkBoxMidiChannel10.Checked.ToString();

            if (config.AppSettings.Settings["MidiChannel9"] == null)
            {
                config.AppSettings.Settings.Add(new KeyValueConfigurationElement("MidiChannel9", ""));
            }
            config.AppSettings.Settings["MidiChannel9"].Value = checkBoxMidiChannel9.Checked.ToString();

            if (config.AppSettings.Settings["MidiChannel8"] == null)
            {
                config.AppSettings.Settings.Add(new KeyValueConfigurationElement("MidiChannel8", ""));
            }
            config.AppSettings.Settings["MidiChannel8"].Value = checkBoxMidiChannel8.Checked.ToString();

            if (config.AppSettings.Settings["MidiChannel7"] == null)
            {
                config.AppSettings.Settings.Add(new KeyValueConfigurationElement("MidiChannel7", ""));
            }
            config.AppSettings.Settings["MidiChannel7"].Value = checkBoxMidiChannel7.Checked.ToString();

            if (config.AppSettings.Settings["MidiChannel6"] == null)
            {
                config.AppSettings.Settings.Add(new KeyValueConfigurationElement("MidiChannel6", ""));
            }
            config.AppSettings.Settings["MidiChannel6"].Value = checkBoxMidiChannel6.Checked.ToString();

            if (config.AppSettings.Settings["MidiChannel5"] == null)
            {
                config.AppSettings.Settings.Add(new KeyValueConfigurationElement("MidiChannel5", ""));
            }
            config.AppSettings.Settings["MidiChannel5"].Value = checkBoxMidiChannel5.Checked.ToString();

            if (config.AppSettings.Settings["MidiChannel4"] == null)
            {
                config.AppSettings.Settings.Add(new KeyValueConfigurationElement("MidiChannel4", ""));
            }
            config.AppSettings.Settings["MidiChannel4"].Value = checkBoxMidiChannel4.Checked.ToString();

            if (config.AppSettings.Settings["MidiChannel3"] == null)
            {
                config.AppSettings.Settings.Add(new KeyValueConfigurationElement("MidiChannel3", ""));
            }
            config.AppSettings.Settings["MidiChannel3"].Value = checkBoxMidiChannel3.Checked.ToString();

            if (config.AppSettings.Settings["MidiChannel2"] == null)
            {
                config.AppSettings.Settings.Add(new KeyValueConfigurationElement("MidiChannel2", ""));
            }
            config.AppSettings.Settings["MidiChannel2"].Value = checkBoxMidiChannel2.Checked.ToString();


            if (config.AppSettings.Settings["MidiCommandReload"] == null)
            {
                config.AppSettings.Settings.Add(new KeyValueConfigurationElement("MidiCommandReload", ""));
            }
            config.AppSettings.Settings["MidiCommandReload"].Value = textBoxMidiCommandReload.Text;


            if (config.AppSettings.Settings["AutoPlay"] == null)
            {
                config.AppSettings.Settings.Add(new KeyValueConfigurationElement("AutoPlay", ""));
            }
            config.AppSettings.Settings["AutoPlay"].Value = checkBoxAutoPlay.Checked ? numericUpDownAutoPlay.Value.ToString() : "0";

            config.Save(ConfigurationSaveMode.Modified);
        }

        private void openFileDialogAddtoPlaylist_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void buttonAddFileToPlaylist_Click(object sender, EventArgs e)
        {
            if (openFileDialogAddtoPlaylist.ShowDialog() == DialogResult.OK)
            {
                foreach (String filename in openFileDialogAddtoPlaylist.FileNames)
                {

                    if (!CurrentPlaylist.FileList.Any(_data => _data.FileName.Equals(filename, StringComparison.OrdinalIgnoreCase)))
                    {

                        PlayListFile file = new PlayListFile()
                        {
                            FileName = filename,
                            Name = System.IO.Path.GetFileNameWithoutExtension(filename)
                        };
                        file.Label = file.Name;

                        CurrentPlaylist.FileList.Add(file);
                        listBoxPlayList.Items.Add(file);
                    }
                }
            }
        }

        private void buttonOpenPlaylist_Click(object sender, EventArgs e)
        {
            if (openFileDialogOpenPlaylist.ShowDialog() == DialogResult.OK)
            {
                OpenPlayListFile(openFileDialogOpenPlaylist.FileName);
                FillPlaylist();
            }
        }

        private void buttonSavePlaylist_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(CurrentPlaylist.FileName))
            {
                buttonSavePlaylistAs_Click(sender, e);
            }
            else
            {
                SavePlayListToFile(CurrentPlaylist.FileName);
            }
        }

        private void SavePlayListToFile(string fileName)
        {
            CurrentPlaylist.Name = textBoxPlaylistName.Text;

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileName))
            {

                file.WriteLine(CurrentPlaylist.Name);

                foreach (PlayListFile playfile in CurrentPlaylist.FileList)
                {
                    file.WriteLine(JsonConvert.SerializeObject(playfile));

                }
            }
        }
    

        private void buttonSavePlaylistAs_Click(object sender, EventArgs e)
        {
            if (saveFileDialogSavePlaylist.ShowDialog() == DialogResult.OK)
            {
                SavePlayListToFile(saveFileDialogSavePlaylist.FileName);
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            /*timerAutoPlay.Stop();
            timerAutoPlay.Enabled = false;*/
            userStopped = false;


            if (loop != null)
            {
                loop.Close();
                loop = null;
            }

            if (loopReader != null)
            {
                loopReader.Close();
                loopReader = null;

                waveOutPlayer.Stop();
                waveOutPlayer.Dispose();
                waveOutPlayer = new WaveOut();

              

            }



            if (waveOutPlayer.PlaybackState == PlaybackState.Paused)
            {
                waveOutPlayer.Resume();
            }
            else if(listBoxPlayList.SelectedItem != null && playerDevice >= 0)
            {
                String fileToPlay = ((PlayListFile)listBoxPlayList.SelectedItem).FileName;
                if (!File.Exists(fileToPlay))
                {
                    MessageBox.Show("File does not exist");
                    return;
                }
                if (waveOutPlayer.PlaybackState == PlaybackState.Playing)
                {
                    if (currentFilePlaying == fileToPlay)
                    {
                        //do nothing.
                        return;
                    }
                    else
                    {
                        waveOutPlayer.Stop();

                       
                        
                    }
                }

                filePlaying = CurrentPlaylist.FileList.FirstOrDefault(_data => _data.FileName.Equals(fileToPlay, StringComparison.OrdinalIgnoreCase));

                
                waveOutPlayer.DeviceNumber = playerDevice;
                waveOutPlayer.Volume = ((float)trackBarVolume.Value) / 100;
                labelMusicName.Text = filePlaying.Label;
                currentFilePlaying = fileToPlay;

                if (checkBoxLoop.Checked)
                {
                    List<String> files = new List<string>();
                    files.Add(fileToPlay);

                    loopReader = new WaveFileReader(fileToPlay);
                    if (listBoxPlayList.Items.Count > 0)
                    {
                        PlayListFile nextPlayListFile;
                        int nextIndex = listBoxPlayList.SelectedIndex + 1;
                        while (nextIndex < listBoxPlayList.Items.Count)
                        {
                            nextPlayListFile = (PlayListFile)listBoxPlayList.Items[nextIndex];
                            files.Add(nextPlayListFile.FileName);
                            if (!nextPlayListFile.InLoop)
                            {
                                break;
                            }
                            nextIndex++;
                        }
                        
                    }


                    loop = new LoopStream(files);
                    loop.OnNextSongStarted += Loop_OnNextSongStarted;
                    waveOutPlayer.Init(loop);
                    waveOutPlayer.Play();
                }
                else
                {

                    /*mainOutputStream = new WaveFileReader(fileToPlay);
                    


                    WaveChannel32 volumeStream = new WaveChannel32(mainOutputStream);
                    volumeStream.PadWithZeroes = true;
                   
                    waveOutPlayer.Init(volumeStream);
                    //currentFileMaxLength = (long)((mainOutputStream.Length / (mainOutputStream.WaveFormat.BitsPerSample / 8 ) / mainOutputStream.WaveFormat.SampleRate) / mainOutputStream.WaveFormat.Channels);

                    //labelMaxLength.Text = TimeSpan.FromSeconds(currentFileMaxLength).ToString(@"mm\:ss");
                    currentOutputStream = mainOutputStream;*/

                    

                    MemoryStream audioData = new MemoryStream(File.ReadAllBytes(fileToPlay));
                    mainOutputStream = new WaveFileReader(audioData);
                    WaveChannel32 volumeStream = new WaveChannel32(mainOutputStream);
                    volumeStream.PadWithZeroes = true;

                    //RawSourceWaveStream waveStream = new RawSourceWaveStream(mainOutputStream, mainOutputStream.WaveFormat);
                    //mainOutputStream.Close();
                    waveOutPlayer.Init(volumeStream);
                    currentOutputStream = mainOutputStream;
                    // mainOutputStream = currentOutputStream;


                    SetTrackPosition();

                    
                    waveOutPlayer.Play();
                }

                timerFileProgress.Enabled = true;
                timerFileProgress.Start();

                
            }

        }

        private void Loop_OnNextSongStarted(object sender, EventArgs e)
        {
            Action a = new Action(() =>
            {
                buttonForward_Click(null, e);

                currentFilePlaying = ((PlayListFile)listBoxPlayList.SelectedItem).FileName;
                filePlaying = CurrentPlaylist.FileList.FirstOrDefault(_data => _data.FileName.Equals(currentFilePlaying, StringComparison.OrdinalIgnoreCase));

                labelMusicName.Text = filePlaying.Label;
                

            });

            this.Invoke(a);
        }

        private void comboBoxOutputDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            playerDevice = comboBoxOutputDevices.SelectedIndex;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            /*timerAutoPlay.Stop();
            timerAutoPlay.Enabled = false;*/
            interruptAutoPlay = true;
            userStopped = true;
            waveOutPlayer.Stop();
            trackBarFileProgress.Value = 0;


            if (loop != null)
            {
                loop.Close();
                loop = null;

                loopReader.Close();
                loopReader = null;
            }

        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            /*timerAutoPlay.Stop();
            timerAutoPlay.Enabled = false;*/
            if (waveOutPlayer.PlaybackState == PlaybackState.Playing)
            {
                waveOutPlayer.Pause();
            }
        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {

            waveOutPlayer.Volume = ((float)trackBarVolume.Value) / 100;

            if (filePlaying != null)
            {
                filePlaying.Volume = trackBarVolume.Value;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            interruptAutoPlay = true;

            if (waveOutPlayer.PlaybackState != PlaybackState.Stopped)
            {
                waveOutPlayer.Stop();
            }

            /*foreach (MidiIn midiIn in midiDevs)
            {
                if (midiIn != null)
                {
                    midiIn.Stop();
                    midiIn.Close();
                    midiIn.Dispose();
                }
            }*/

            button2_Click(sender, e);

            if (checkBoxAutoSave.Checked)
            {
                buttonSaveConfig_Click(sender, null);

                if (!String.IsNullOrWhiteSpace(CurrentPlaylist.FileName))
                {
                    SavePlayListToFile(CurrentPlaylist.FileName);
                }

            }
        }

        private void listBoxPlayList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            buttonPlay_Click(sender, e);
        }

        private void listBoxPlayList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((waveOutPlayer.PlaybackState == PlaybackState.Stopped || (loop != null && !loop.EnableLooping)) && listBoxPlayList.SelectedItem != null)
            {
                String fileToPlay = ((PlayListFile)listBoxPlayList.SelectedItem).FileName;

                mainOutputStream = new WaveFileReader(fileToPlay);
                currentFileMaxLength = (long)((mainOutputStream.Length / (mainOutputStream.WaveFormat.BitsPerSample / 8) / mainOutputStream.WaveFormat.SampleRate) / mainOutputStream.WaveFormat.Channels);
                labelMaxLength.Text = TimeSpan.FromSeconds(currentFileMaxLength).ToString(@"mm\:ss");
                filePlaying = CurrentPlaylist.FileList.FirstOrDefault(_data => _data.FileName.Equals(fileToPlay, StringComparison.OrdinalIgnoreCase));
                labelMusicName.Text = filePlaying.Label;


                if (filePlaying.Volume != null)
                {
                    trackBarVolume.Value = (int)filePlaying.Volume;
                }

                checkBoxLoop.Checked = filePlaying.InLoop;

            }
        }

        private void timerFileProgress_Tick(object sender, EventArgs e)
        {


            if (waveOutPlayer.PlaybackState == PlaybackState.Playing && (currentOutputStream != null || loop != null))
            {

                WaveStream stream = currentOutputStream;
                if (loop != null)
                {
                    stream = loop;
                }

                long pos = (long)stream.CurrentTime.TotalSeconds;
                labelTimespan.Text = stream.CurrentTime.ToString(@"mm\:ss");

                int val = (int)(((float)pos / (float)currentFileMaxLength) * 100);
                if (val < trackBarFileProgress.Maximum)
                {
                    trackBarFileProgress.Value = val;
                }
                
            }

            if (loop == null && currentOutputStream != null && currentOutputStream.Position >= currentOutputStream.Length)
            {
                waveOutPlayer.Stop();
            }

        }


        private void timerAutoPlay_Tick(object sender, EventArgs e)
        {
            autoPlayCount++;

            if (autoPlayCount == 10)
            {
                autoPlayCount = 0;
                buttonPlay_Click(sender, e);
            }

            labelAutoPlay.Text = autoPlayCount.ToString();

        }

        private void trackBarFileProgress_Scroll(object sender, EventArgs e)
        {
            if (mainOutputStream != null || loop != null)
            {
                SetTrackPosition();
            }

        }

        private void SetTrackPosition()
        {
            long desiredVal = (trackBarFileProgress.Value * currentFileMaxLength) / 100;
            if (loop != null)
            {
                loop.CurrentTime = TimeSpan.FromSeconds(desiredVal); 
            }
            else
            {
                mainOutputStream.CurrentTime = TimeSpan.FromSeconds(desiredVal);
            }
        }

        private void buttonRewind_Click(object sender, EventArgs e)
        {
            interruptAutoPlay = true;
            if (listBoxPlayList.Items.Count > 0)
            {
                if (listBoxPlayList.SelectedIndex == 0)
                {
                    listBoxPlayList.SelectedIndex = listBoxPlayList.Items.Count - 1;
                }
                else
                {
                    listBoxPlayList.SelectedIndex--;
                }
                trackBarFileProgress.Value = 0;
                
                if (waveOutPlayer.PlaybackState == PlaybackState.Playing && sender != null)
                {
                    buttonStop_Click(sender, e);
                }
                listBoxPlayList_SelectedIndexChanged(sender, e);
                /*if (checkBoxAutoPlay.Checked && !(sender is MidiIn))
                {
                    buttonStop_Click(sender, e);
                    buttonPlay_Click(sender, e);
                }*/
            }
            
            if (loop != null)
            {
                loop.EnableLooping = false;
            }

        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            interruptAutoPlay = true;
            if (checkBoxLoop.Checked && (sender != null) && waveOutPlayer != null && waveOutPlayer.PlaybackState == PlaybackState.Playing && loop != null)
            {
                loop.goToNextFile = true;
               
                
            }
            else
            {



                if (listBoxPlayList.Items.Count > 0)
                {
                    if (listBoxPlayList.SelectedIndex == listBoxPlayList.Items.Count - 1)
                    {
                        listBoxPlayList.SelectedIndex = 0;
                    }
                    else
                    {
                        listBoxPlayList.SelectedIndex++;
                    }

                    trackBarFileProgress.Value = 0;

             
                    if (waveOutPlayer.PlaybackState == PlaybackState.Playing && sender != null)
                    {
                        buttonStop_Click(sender, e);
                    }

                    listBoxPlayList_SelectedIndexChanged(sender, e);

                    if (sender is DummyObjectOnlyForTrackingControl && checkBoxAutoPlay.Checked)
                    {
                        int loops = (int)numericUpDownAutoPlay.Value;
                        labelAutoPlay.Text = "0";
                        
                        new Thread(() =>
                        {
                            int curLoop = 0;
                            interruptAutoPlay = false;
                            while (curLoop < loops)
                            {
                                if (interruptAutoPlay)
                                {
                                    return;
                                }
                                this.Invoke(new Action(() =>
                                {
                                    labelAutoPlay.Text = curLoop.ToString();
                                }));
                                curLoop++;
                                Thread.Sleep(1000);
                            }

                            this.Invoke(new Action(() =>
                            {
                                labelAutoPlay.Text = "0";
                                buttonPlay_Click(null, null);
                            }));

                        }).Start();
                    }

                    /*if (sender != null && checkBoxAutoPlay.Checked && !(sender is MidiIn))
                    {
                        buttonStop_Click(sender, e);
                        buttonPlay_Click(sender, e);
                    }*/
                }
            }
           
        }

        private void comboBoxMidiDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void MidiIn_MessageReceived(object sender, MidiInMessageEventArgs e)
        {
            if (e.MidiEvent == null)
            {
                return;
            }



            if (e.MidiEvent.CommandCode == MidiCommandCode.AutoSensing)
            {
                return;
            }


            if (e.MidiEvent is NAudio.Midi.ControlChangeEvent midiEvent &&
                e.MidiEvent.CommandCode == MidiCommandCode.ControlChange)
            {

                switch (e.MidiEvent.Channel)
                {
                    case 1:
                        if (!checkBoxMidiChannel1.Checked)
                        {
                            return;
                        }
                        break;

                    case 2:
                        if (!checkBoxMidiChannel2.Checked)
                        {
                            return;
                        }
                        break;

                    case 3:
                        if (!checkBoxMidiChannel3.Checked)
                        {
                            return;
                        }
                        break;

                    case 4:
                        if (!checkBoxMidiChannel4.Checked)
                        {
                            return;
                        }
                        break;

                    case 5:
                        if (!checkBoxMidiChannel5.Checked)
                        {
                            return;
                        }
                        break;

                    case 6:
                        if (!checkBoxMidiChannel6.Checked)
                        {
                            return;
                        }
                        break;

                    case 7:
                        if (!checkBoxMidiChannel7.Checked)
                        {
                            return;
                        }
                        break;

                    case 8:
                        if (!checkBoxMidiChannel8.Checked)
                        {
                            return;
                        }
                        break;

                    case 9:
                        if (!checkBoxMidiChannel9.Checked)
                        {
                            return;
                        }
                        break;

                    case 10:
                        if (!checkBoxMidiChannel10.Checked)
                        {
                            return;
                        }
                        break;

                    case 11:
                        if (!checkBoxMidiChannel11.Checked)
                        {
                            return;
                        }
                        break;

                    case 12:
                        if (!checkBoxMidiChannel12.Checked)
                        {
                            return;
                        }
                        break;

                    case 13:
                        if (!checkBoxMidiChannel13.Checked)
                        {
                            return;
                        }
                        break;

                    case 14:
                        if (!checkBoxMidiChannel14.Checked)
                        {
                            return;
                        }
                        break;

                    case 15:
                        if (!checkBoxMidiChannel15.Checked)
                        {
                            return;
                        }
                        break;

                    case 16:
                        if (!checkBoxMidiChannel16.Checked)
                        {
                            return;
                        }
                        break;

                }

                /*Action timer = new Action(() =>
                {
                    panelMidiLed.BackColor = Color.Green;
                    timerMidiLed.Start();
                    timerMidiLed.Enabled = true;
                });
                this.Invoke(timer);*/

                Action a = null;
                String midiEventController = midiEvent.Controller.ToString();

                if (midiControls.TryGetValue(midiEventController, out MidiControlAction actionToPerform) && actionToPerform != null)
                {
                   
                    a = new Action(() =>  actionToPerform.action(sender, midiEvent.ControllerValue));
                
                }

                if (a != null)
                {
                    this.Invoke(a);    
                }
            }

              

        }

        private void timerMidiLed_Tick(object sender, EventArgs e)
        {
            /*timerMidiLed.Stop();
            timerMidiLed.Enabled = false;

            panelMidiLed.BackColor = Color.Gray;*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MidiIn_MessageReceived(null, new MidiInMessageEventArgs(1, 1));
        }

        private void listBoxPlayList_MouseDown(object sender, MouseEventArgs e)
        {
            /*if (listBoxPlayList.SelectedItem == null) return;
            listBoxPlayList.DoDragDrop(listBoxPlayList.SelectedItem, DragDropEffects.Move);*/
        }

        private void listBoxPlayList_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listBoxPlayList_DragDrop(object sender, DragEventArgs e)
        {
            Point point = listBoxPlayList.PointToClient(new Point(e.X, e.Y));
            int index = this.listBoxPlayList.IndexFromPoint(point);
            if (index < 0) index = this.listBoxPlayList.Items.Count - 1;
            PlayListFile data = (PlayListFile)e.Data.GetData(typeof(PlayListFile));
            this.listBoxPlayList.Items.Remove(data);
            this.listBoxPlayList.Items.Insert(index, data);

            CurrentPlaylist.FileList.Remove(data);
            CurrentPlaylist.FileList.Insert(index, data);

        }

        private void buttonDeleteFromPlaylist_Click(object sender, EventArgs e)
        {
            if (listBoxPlayList.SelectedItem != null)
            {
                PlayListFile item = (PlayListFile)listBoxPlayList.SelectedItem;
                CurrentPlaylist.FileList.Remove(item);
                listBoxPlayList.Items.Remove(item);
            }
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            if (listBoxPlayList.SelectedItem != null)
            {
                PlayListFile item = (PlayListFile)listBoxPlayList.SelectedItem;
                int itemIndex = listBoxPlayList.SelectedIndex;
                if (itemIndex < listBoxPlayList.Items.Count - 1)
                {
                    itemIndex++;
                    CurrentPlaylist.FileList.Remove(item);
                    listBoxPlayList.Items.Remove(item);

                    CurrentPlaylist.FileList.Insert(itemIndex, item);
                    listBoxPlayList.Items.Insert(itemIndex, item);

                    listBoxPlayList.SelectedIndex = itemIndex;
                }
            }

        }

        private void buttonMoveU_Click(object sender, EventArgs e)
        {
            if (listBoxPlayList.SelectedItem != null)
            {
                PlayListFile item = (PlayListFile)listBoxPlayList.SelectedItem;
                int itemIndex = listBoxPlayList.SelectedIndex;
                if (itemIndex > 0)
                {
                    itemIndex--;
                    CurrentPlaylist.FileList.Remove(item);
                    listBoxPlayList.Items.Remove(item);

                    CurrentPlaylist.FileList.Insert(itemIndex, item);
                    listBoxPlayList.Items.Insert(itemIndex, item);

                    listBoxPlayList.SelectedIndex = itemIndex;
                }
            }

        }

        private void SetMidiControl(MidiControlAction midiControl)
        {
            MidiControlAction curControl = midiControls.Values.FirstOrDefault(_data => _data.type == midiControl.type);
            if (curControl != null)
            {
                midiControls.Remove(curControl.command);
            }
            try
            {
                midiControls.Add(midiControl.command, midiControl);
            }
            catch
            {

            }

        }

        private void textBoxMidiControlPlay_TextChanged(object sender, EventArgs e)
        {
            SetMidiControl(new MidiControlAction()
            {
                action = new Action<object, int>((se, d) => buttonPlay_Click(se, null)),
                command = textBoxMidiControlPlay.Text.Trim(),
                type = ActionType.Play
            });
        }

        private void textBoxMidiControlStop_TextChanged(object sender, EventArgs e)
        {
            SetMidiControl(new MidiControlAction()
            {
                action = new Action<object, int>((se, d) => buttonStop_Click(se, null)),
                command = textBoxMidiControlStop.Text.Trim(),
                type = ActionType.Stop
            });
        }

        private void textBoxMidiControlPause_TextChanged(object sender, EventArgs e)
        {
            SetMidiControl(new MidiControlAction()
            {
                action = new Action<object, int>((se, d) => buttonPause_Click(se, null)),
                command = textBoxMidiControlPause.Text.Trim(),
                type = ActionType.Pause
            });
        }

        private void textBoxMidiControlBack_TextChanged(object sender, EventArgs e)
        {
            SetMidiControl(new MidiControlAction()
            {
                action = new Action<object, int>((se, d) => buttonRewind_Click(se, null)),
                command = textBoxMidiControlBack.Text.Trim(),
                type = ActionType.Back
            });
        }

        private void textBoxMidiControlForth_TextChanged(object sender, EventArgs e)
        {
            SetMidiControl(new MidiControlAction()
            {
                action = new Action<object, int>((se, d) => buttonForward_Click(se, null)),
                command = textBoxMidiControlForth.Text.Trim(),
                type = ActionType.Forth
            });
        }

        private void textBoxMidiControlVol_TextChanged(object sender, EventArgs e)
        {
            SetMidiControl(new MidiControlAction()
            {
                action = new Action<object, int>((se, val) =>
                {
                    val = (int)(((float)val / (float)127) * 100);

                    trackBarVolume.Value = val;
                    trackBarVolume_Scroll(sender, null);
                }),
                command = textBoxMidiControlVol.Text.Trim(),
                type = ActionType.Volume
            });
        }

        private void textBoxMidiControlTrack_TextChanged(object sender, EventArgs e)
        {
            SetMidiControl(new MidiControlAction()
            {
                action = new Action<object, int>((se, val) =>
                {
                    val = (int)(((float)val / (float)127) * 100);

                    trackBarFileProgress.Value = val;
                    trackBarFileProgress_Scroll(sender, null);
                }),
                command = textBoxMidiControlTrack.Text.Trim(),
                type = ActionType.Track
            });
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button2_Click(sender, e);
            if (comboBoxMidiDevices.SelectedIndex >= 0)
            {
                midiIn = new MidiIn(comboBoxMidiDevices.SelectedIndex);
                midiIn.MessageReceived += MidiIn_MessageReceived;
                midiIn.Start();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (midiIn != null)
            {
                midiIn.Stop();
                midiIn.Dispose();
                midiIn.Close();
                midiIn = null;
            }
        }

        private void saveFileDialogSavePlaylist_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void checkBoxLoop_CheckedChanged(object sender, EventArgs e)
        {

            if (filePlaying != null)
            {
                filePlaying.InLoop = checkBoxLoop.Checked;
            }
        }
    }

    public class LoopStream : WaveStream
    {
        WaveStream sourceStream;

        /// <summary>
        /// Creates a new Loop stream
        /// </summary>
        /// <param name="sourceStream">The stream to read from. Note: the Read method of this stream should return 0 when it reaches the end
        /// or else we will not loop to the start again.</param>
        /* public LoopStream(WaveStream sourceStream, WaveFileReader nextFile)
         {
             this.sourceStream = sourceStream;
             this.EnableLooping = true;
             this.nextFile = nextFile;
         }*/

        public LoopStream(List<String> files)
        {
            //this.sourceStream = sourceStream;
            if (files.Count == 0)
            {
                return;
            }
            this.EnableLooping = true;
            //this.nextFile = nextFile;

            foreach (String file in files)
            {
                fileList.Add(new WaveFileReader(file));
            }

            sourceStream = fileList[curFileIndex];
        }

        private List<WaveFileReader> fileList = new List<WaveFileReader>();
        private int curFileIndex = 0;

        public bool goToNextFile = false;

        /// <summary>
        /// Use this to turn looping on or off
        /// </summary>
        public bool EnableLooping { get; set; }

        /// <summary>
        /// Return source stream's wave format
        /// </summary>
        public override WaveFormat WaveFormat
        {
            get { return sourceStream.WaveFormat; }
        }


        public override TimeSpan CurrentTime
        {
            get { return sourceStream.CurrentTime; }
            set { sourceStream.CurrentTime = value; }
        }

        /// <summary>
        /// LoopStream simply returns
        /// </summary>
        public override long Length
        {
            get { return sourceStream.Length; }
        }

        /// <summary>
        /// LoopStream simply passes on positioning to source stream
        /// </summary>
        public override long Position
        {
            get { return sourceStream.Position; }
            set { sourceStream.Position = value; }
        }

        public event EventHandler OnNextSongStarted;

        public override int Read(byte[] buffer, int offset, int count)
        {
            int totalBytesRead = 0;
            bool changeAtNextLoop = false;

            while (totalBytesRead < count)
            {
                if (changeAtNextLoop)
                {
                    curFileIndex++;
                    goToNextFile = false;
                    if (curFileIndex >= fileList.Count)
                    {
                        break;
                    }
                    EnableLooping = curFileIndex < fileList.Count - 1;
                    sourceStream = fileList[curFileIndex];
                    if (OnNextSongStarted != null)
                    {
                        ThreadPool.QueueUserWorkItem(RaiseNextSongStarted, null);
                    }
                }

                int bytesRead = sourceStream.Read(buffer, offset + totalBytesRead, count - totalBytesRead);

                if (bytesRead == 0)
                {

                   
                    if (sourceStream.Position == 0 || !EnableLooping)
                    {
                        // something wrong with the source stream
                        break;
                    }

                    // loop
                    sourceStream.Position = 0;
                }

                if ((sourceStream.Position + buffer.Length >= sourceStream.Length && goToNextFile))
                {
                    changeAtNextLoop = true;
                }

                totalBytesRead += bytesRead;
            }

            return totalBytesRead;
        }



       

        private void RaiseNextSongStarted(object state)
        {
            OnNextSongStarted(this, null);
        }
    }


    public class DummyObjectOnlyForTrackingControl
    {

    }


}
