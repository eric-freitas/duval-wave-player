namespace DuvalWavePlayer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxOutputDevices = new System.Windows.Forms.ComboBox();
            this.buttonRefreshDevices = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonSaveConfig = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonMoveU = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonDeleteFromPlaylist = new System.Windows.Forms.Button();
            this.buttonAddFileToPlaylist = new System.Windows.Forms.Button();
            this.buttonOpenPlaylist = new System.Windows.Forms.Button();
            this.buttonSavePlaylistAs = new System.Windows.Forms.Button();
            this.buttonSavePlaylist = new System.Windows.Forms.Button();
            this.textBoxPlaylistName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxPlayList = new System.Windows.Forms.ListBox();
            this.openFileDialogAddtoPlaylist = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogOpenPlaylist = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogSavePlaylist = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxMidiControlForth = new System.Windows.Forms.TextBox();
            this.textBoxMidiControlBack = new System.Windows.Forms.TextBox();
            this.textBoxMidiControlPause = new System.Windows.Forms.TextBox();
            this.textBoxMidiControlStop = new System.Windows.Forms.TextBox();
            this.textBoxMidiControlPlay = new System.Windows.Forms.TextBox();
            this.buttonRewind = new System.Windows.Forms.Button();
            this.buttonForward = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.trackBarFileProgress = new System.Windows.Forms.TrackBar();
            this.timerFileProgress = new System.Windows.Forms.Timer(this.components);
            this.labelMusicName = new System.Windows.Forms.Label();
            this.labelTimespan = new System.Windows.Forms.Label();
            this.labelMaxLength = new System.Windows.Forms.Label();
            this.labelAutoPlay = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panelMidiLed = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxMidiChannel16 = new System.Windows.Forms.CheckBox();
            this.checkBoxMidiChannel15 = new System.Windows.Forms.CheckBox();
            this.checkBoxMidiChannel14 = new System.Windows.Forms.CheckBox();
            this.checkBoxMidiChannel13 = new System.Windows.Forms.CheckBox();
            this.checkBoxMidiChannel12 = new System.Windows.Forms.CheckBox();
            this.checkBoxMidiChannel11 = new System.Windows.Forms.CheckBox();
            this.checkBoxMidiChannel10 = new System.Windows.Forms.CheckBox();
            this.checkBoxMidiChannel9 = new System.Windows.Forms.CheckBox();
            this.checkBoxMidiChannel8 = new System.Windows.Forms.CheckBox();
            this.checkBoxMidiChannel7 = new System.Windows.Forms.CheckBox();
            this.checkBoxMidiChannel6 = new System.Windows.Forms.CheckBox();
            this.checkBoxMidiChannel5 = new System.Windows.Forms.CheckBox();
            this.checkBoxMidiChannel4 = new System.Windows.Forms.CheckBox();
            this.checkBoxMidiChannel3 = new System.Windows.Forms.CheckBox();
            this.checkBoxMidiChannel2 = new System.Windows.Forms.CheckBox();
            this.checkBoxMidiChannel1 = new System.Windows.Forms.CheckBox();
            this.comboBoxMidiDevices = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxAutoSave = new System.Windows.Forms.CheckBox();
            this.textBoxMidiControlVol = new System.Windows.Forms.TextBox();
            this.textBoxMidiControlTrack = new System.Windows.Forms.TextBox();
            this.textBoxMidiCommandReload = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBoxLoop = new System.Windows.Forms.CheckBox();
            this.checkBoxAutoPlay = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownAutoPlay = new System.Windows.Forms.NumericUpDown();
            this.checkBoxPlayNext = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFileProgress)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAutoPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Output Device";
            // 
            // comboBoxOutputDevices
            // 
            this.comboBoxOutputDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOutputDevices.FormattingEnabled = true;
            this.comboBoxOutputDevices.Location = new System.Drawing.Point(21, 37);
            this.comboBoxOutputDevices.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxOutputDevices.Name = "comboBoxOutputDevices";
            this.comboBoxOutputDevices.Size = new System.Drawing.Size(343, 24);
            this.comboBoxOutputDevices.TabIndex = 1;
            this.comboBoxOutputDevices.SelectedIndexChanged += new System.EventHandler(this.comboBoxOutputDevices_SelectedIndexChanged);
            // 
            // buttonRefreshDevices
            // 
            this.buttonRefreshDevices.AccessibleName = "Refresh Devices";
            this.buttonRefreshDevices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefreshDevices.ImageIndex = 0;
            this.buttonRefreshDevices.ImageList = this.imageList1;
            this.buttonRefreshDevices.Location = new System.Drawing.Point(983, 31);
            this.buttonRefreshDevices.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRefreshDevices.Name = "buttonRefreshDevices";
            this.buttonRefreshDevices.Size = new System.Drawing.Size(33, 31);
            this.buttonRefreshDevices.TabIndex = 2;
            this.buttonRefreshDevices.UseVisualStyleBackColor = true;
            this.buttonRefreshDevices.Click += new System.EventHandler(this.buttonRefreshDevices_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "refresh.png");
            this.imageList1.Images.SetKeyName(1, "save.png");
            this.imageList1.Images.SetKeyName(2, "add-file.png");
            this.imageList1.Images.SetKeyName(3, "folder_open.png");
            this.imageList1.Images.SetKeyName(4, "save-as-icon-23716.png");
            this.imageList1.Images.SetKeyName(5, "pause.png");
            this.imageList1.Images.SetKeyName(6, "play.png");
            this.imageList1.Images.SetKeyName(7, "stop.png");
            this.imageList1.Images.SetKeyName(8, "fast-forward-xxl.png");
            this.imageList1.Images.SetKeyName(9, "reqind.png");
            this.imageList1.Images.SetKeyName(10, "file_delete.png");
            this.imageList1.Images.SetKeyName(11, "down.png");
            this.imageList1.Images.SetKeyName(12, "up.png");
            // 
            // buttonSaveConfig
            // 
            this.buttonSaveConfig.AccessibleName = "Save Config";
            this.buttonSaveConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveConfig.ImageIndex = 1;
            this.buttonSaveConfig.ImageList = this.imageList1;
            this.buttonSaveConfig.Location = new System.Drawing.Point(1024, 31);
            this.buttonSaveConfig.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveConfig.Name = "buttonSaveConfig";
            this.buttonSaveConfig.Size = new System.Drawing.Size(35, 32);
            this.buttonSaveConfig.TabIndex = 3;
            this.buttonSaveConfig.UseVisualStyleBackColor = true;
            this.buttonSaveConfig.Click += new System.EventHandler(this.buttonSaveConfig_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(967, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Configuration";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonMoveU);
            this.groupBox1.Controls.Add(this.buttonDown);
            this.groupBox1.Controls.Add(this.buttonDeleteFromPlaylist);
            this.groupBox1.Controls.Add(this.buttonAddFileToPlaylist);
            this.groupBox1.Controls.Add(this.buttonOpenPlaylist);
            this.groupBox1.Controls.Add(this.buttonSavePlaylistAs);
            this.groupBox1.Controls.Add(this.buttonSavePlaylist);
            this.groupBox1.Controls.Add(this.textBoxPlaylistName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.listBoxPlayList);
            this.groupBox1.Location = new System.Drawing.Point(21, 70);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(553, 439);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Playlist";
            // 
            // buttonMoveU
            // 
            this.buttonMoveU.AccessibleName = "Move Up";
            this.buttonMoveU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMoveU.ImageIndex = 12;
            this.buttonMoveU.ImageList = this.imageList1;
            this.buttonMoveU.Location = new System.Drawing.Point(236, 16);
            this.buttonMoveU.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMoveU.Name = "buttonMoveU";
            this.buttonMoveU.Size = new System.Drawing.Size(35, 32);
            this.buttonMoveU.TabIndex = 10;
            this.buttonMoveU.UseVisualStyleBackColor = true;
            this.buttonMoveU.Click += new System.EventHandler(this.buttonMoveU_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.AccessibleName = "Move Down";
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.ImageIndex = 11;
            this.buttonDown.ImageList = this.imageList1;
            this.buttonDown.Location = new System.Drawing.Point(193, 16);
            this.buttonDown.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(35, 32);
            this.buttonDown.TabIndex = 9;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonDeleteFromPlaylist
            // 
            this.buttonDeleteFromPlaylist.AccessibleName = "Remove File to Playlist";
            this.buttonDeleteFromPlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteFromPlaylist.ImageIndex = 10;
            this.buttonDeleteFromPlaylist.ImageList = this.imageList1;
            this.buttonDeleteFromPlaylist.Location = new System.Drawing.Point(340, 16);
            this.buttonDeleteFromPlaylist.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteFromPlaylist.Name = "buttonDeleteFromPlaylist";
            this.buttonDeleteFromPlaylist.Size = new System.Drawing.Size(35, 32);
            this.buttonDeleteFromPlaylist.TabIndex = 8;
            this.buttonDeleteFromPlaylist.UseVisualStyleBackColor = true;
            this.buttonDeleteFromPlaylist.Click += new System.EventHandler(this.buttonDeleteFromPlaylist_Click);
            // 
            // buttonAddFileToPlaylist
            // 
            this.buttonAddFileToPlaylist.AccessibleName = "Add File to Playlist";
            this.buttonAddFileToPlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddFileToPlaylist.ImageIndex = 2;
            this.buttonAddFileToPlaylist.ImageList = this.imageList1;
            this.buttonAddFileToPlaylist.Location = new System.Drawing.Point(383, 16);
            this.buttonAddFileToPlaylist.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddFileToPlaylist.Name = "buttonAddFileToPlaylist";
            this.buttonAddFileToPlaylist.Size = new System.Drawing.Size(35, 32);
            this.buttonAddFileToPlaylist.TabIndex = 7;
            this.buttonAddFileToPlaylist.UseVisualStyleBackColor = true;
            this.buttonAddFileToPlaylist.Click += new System.EventHandler(this.buttonAddFileToPlaylist_Click);
            // 
            // buttonOpenPlaylist
            // 
            this.buttonOpenPlaylist.AccessibleName = "Open Playlist";
            this.buttonOpenPlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenPlaylist.ImageIndex = 3;
            this.buttonOpenPlaylist.ImageList = this.imageList1;
            this.buttonOpenPlaylist.Location = new System.Drawing.Point(425, 16);
            this.buttonOpenPlaylist.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpenPlaylist.Name = "buttonOpenPlaylist";
            this.buttonOpenPlaylist.Size = new System.Drawing.Size(35, 32);
            this.buttonOpenPlaylist.TabIndex = 6;
            this.buttonOpenPlaylist.UseVisualStyleBackColor = true;
            this.buttonOpenPlaylist.Click += new System.EventHandler(this.buttonOpenPlaylist_Click);
            // 
            // buttonSavePlaylistAs
            // 
            this.buttonSavePlaylistAs.AccessibleName = "Save Playlist As";
            this.buttonSavePlaylistAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSavePlaylistAs.ImageIndex = 4;
            this.buttonSavePlaylistAs.ImageList = this.imageList1;
            this.buttonSavePlaylistAs.Location = new System.Drawing.Point(468, 16);
            this.buttonSavePlaylistAs.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSavePlaylistAs.Name = "buttonSavePlaylistAs";
            this.buttonSavePlaylistAs.Size = new System.Drawing.Size(35, 32);
            this.buttonSavePlaylistAs.TabIndex = 5;
            this.buttonSavePlaylistAs.UseVisualStyleBackColor = true;
            this.buttonSavePlaylistAs.Click += new System.EventHandler(this.buttonSavePlaylistAs_Click);
            // 
            // buttonSavePlaylist
            // 
            this.buttonSavePlaylist.AccessibleName = "Save Playlist";
            this.buttonSavePlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSavePlaylist.ImageIndex = 1;
            this.buttonSavePlaylist.ImageList = this.imageList1;
            this.buttonSavePlaylist.Location = new System.Drawing.Point(511, 16);
            this.buttonSavePlaylist.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSavePlaylist.Name = "buttonSavePlaylist";
            this.buttonSavePlaylist.Size = new System.Drawing.Size(35, 32);
            this.buttonSavePlaylist.TabIndex = 4;
            this.buttonSavePlaylist.UseVisualStyleBackColor = true;
            this.buttonSavePlaylist.Click += new System.EventHandler(this.buttonSavePlaylist_Click);
            // 
            // textBoxPlaylistName
            // 
            this.textBoxPlaylistName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPlaylistName.Location = new System.Drawing.Point(8, 55);
            this.textBoxPlaylistName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPlaylistName.Name = "textBoxPlaylistName";
            this.textBoxPlaylistName.Size = new System.Drawing.Size(536, 22);
            this.textBoxPlaylistName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            // 
            // listBoxPlayList
            // 
            this.listBoxPlayList.AllowDrop = true;
            this.listBoxPlayList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPlayList.FormattingEnabled = true;
            this.listBoxPlayList.ItemHeight = 16;
            this.listBoxPlayList.Location = new System.Drawing.Point(8, 87);
            this.listBoxPlayList.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxPlayList.Name = "listBoxPlayList";
            this.listBoxPlayList.Size = new System.Drawing.Size(536, 324);
            this.listBoxPlayList.TabIndex = 0;
            this.listBoxPlayList.SelectedIndexChanged += new System.EventHandler(this.listBoxPlayList_SelectedIndexChanged);
            this.listBoxPlayList.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxPlayList_DragDrop);
            this.listBoxPlayList.DragOver += new System.Windows.Forms.DragEventHandler(this.listBoxPlayList_DragOver);
            this.listBoxPlayList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxPlayList_MouseDoubleClick);
            this.listBoxPlayList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxPlayList_MouseDown);
            // 
            // openFileDialogAddtoPlaylist
            // 
            this.openFileDialogAddtoPlaylist.Filter = "Wave Files|*.wav";
            this.openFileDialogAddtoPlaylist.Multiselect = true;
            this.openFileDialogAddtoPlaylist.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogAddtoPlaylist_FileOk);
            // 
            // openFileDialogOpenPlaylist
            // 
            this.openFileDialogOpenPlaylist.Filter = "Playlist Files|*.pls|Any file|*.*";
            // 
            // saveFileDialogSavePlaylist
            // 
            this.saveFileDialogSavePlaylist.Filter = "Playlist Files|*.pls|Any file|*.*";
            this.saveFileDialogSavePlaylist.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialogSavePlaylist_FileOk);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textBoxMidiControlForth);
            this.groupBox2.Controls.Add(this.textBoxMidiControlBack);
            this.groupBox2.Controls.Add(this.textBoxMidiControlPause);
            this.groupBox2.Controls.Add(this.textBoxMidiControlStop);
            this.groupBox2.Controls.Add(this.textBoxMidiControlPlay);
            this.groupBox2.Controls.Add(this.buttonRewind);
            this.groupBox2.Controls.Add(this.buttonForward);
            this.groupBox2.Controls.Add(this.buttonPause);
            this.groupBox2.Controls.Add(this.buttonStop);
            this.groupBox2.Controls.Add(this.buttonPlay);
            this.groupBox2.Location = new System.Drawing.Point(21, 517);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(553, 119);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // textBoxMidiControlForth
            // 
            this.textBoxMidiControlForth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMidiControlForth.Location = new System.Drawing.Point(479, 87);
            this.textBoxMidiControlForth.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMidiControlForth.Name = "textBoxMidiControlForth";
            this.textBoxMidiControlForth.Size = new System.Drawing.Size(63, 22);
            this.textBoxMidiControlForth.TabIndex = 14;
            this.textBoxMidiControlForth.TextChanged += new System.EventHandler(this.textBoxMidiControlForth_TextChanged);
            // 
            // textBoxMidiControlBack
            // 
            this.textBoxMidiControlBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMidiControlBack.Location = new System.Drawing.Point(407, 87);
            this.textBoxMidiControlBack.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMidiControlBack.Name = "textBoxMidiControlBack";
            this.textBoxMidiControlBack.Size = new System.Drawing.Size(63, 22);
            this.textBoxMidiControlBack.TabIndex = 13;
            this.textBoxMidiControlBack.TextChanged += new System.EventHandler(this.textBoxMidiControlBack_TextChanged);
            // 
            // textBoxMidiControlPause
            // 
            this.textBoxMidiControlPause.Location = new System.Drawing.Point(160, 87);
            this.textBoxMidiControlPause.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMidiControlPause.Name = "textBoxMidiControlPause";
            this.textBoxMidiControlPause.Size = new System.Drawing.Size(63, 22);
            this.textBoxMidiControlPause.TabIndex = 12;
            this.textBoxMidiControlPause.TextChanged += new System.EventHandler(this.textBoxMidiControlPause_TextChanged);
            // 
            // textBoxMidiControlStop
            // 
            this.textBoxMidiControlStop.Location = new System.Drawing.Point(88, 87);
            this.textBoxMidiControlStop.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMidiControlStop.Name = "textBoxMidiControlStop";
            this.textBoxMidiControlStop.Size = new System.Drawing.Size(63, 22);
            this.textBoxMidiControlStop.TabIndex = 11;
            this.textBoxMidiControlStop.TextChanged += new System.EventHandler(this.textBoxMidiControlStop_TextChanged);
            // 
            // textBoxMidiControlPlay
            // 
            this.textBoxMidiControlPlay.Location = new System.Drawing.Point(16, 87);
            this.textBoxMidiControlPlay.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMidiControlPlay.Name = "textBoxMidiControlPlay";
            this.textBoxMidiControlPlay.Size = new System.Drawing.Size(63, 22);
            this.textBoxMidiControlPlay.TabIndex = 10;
            this.textBoxMidiControlPlay.TextChanged += new System.EventHandler(this.textBoxMidiControlPlay_TextChanged);
            // 
            // buttonRewind
            // 
            this.buttonRewind.AccessibleName = "Pause";
            this.buttonRewind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRewind.ImageIndex = 9;
            this.buttonRewind.ImageList = this.imageList1;
            this.buttonRewind.Location = new System.Drawing.Point(405, 21);
            this.buttonRewind.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRewind.Name = "buttonRewind";
            this.buttonRewind.Size = new System.Drawing.Size(64, 58);
            this.buttonRewind.TabIndex = 9;
            this.buttonRewind.UseVisualStyleBackColor = true;
            this.buttonRewind.Click += new System.EventHandler(this.buttonRewind_Click);
            // 
            // buttonForward
            // 
            this.buttonForward.AccessibleName = "Pause";
            this.buttonForward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonForward.ImageIndex = 8;
            this.buttonForward.ImageList = this.imageList1;
            this.buttonForward.Location = new System.Drawing.Point(477, 21);
            this.buttonForward.Margin = new System.Windows.Forms.Padding(4);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(64, 58);
            this.buttonForward.TabIndex = 8;
            this.buttonForward.UseVisualStyleBackColor = true;
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.AccessibleName = "Pause";
            this.buttonPause.ImageIndex = 5;
            this.buttonPause.ImageList = this.imageList1;
            this.buttonPause.Location = new System.Drawing.Point(160, 21);
            this.buttonPause.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(64, 58);
            this.buttonPause.TabIndex = 7;
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.AccessibleName = "Stop";
            this.buttonStop.ImageIndex = 7;
            this.buttonStop.ImageList = this.imageList1;
            this.buttonStop.Location = new System.Drawing.Point(88, 21);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(64, 58);
            this.buttonStop.TabIndex = 6;
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.AccessibleName = "Play";
            this.buttonPlay.ImageIndex = 6;
            this.buttonPlay.ImageList = this.imageList1;
            this.buttonPlay.Location = new System.Drawing.Point(16, 21);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(64, 58);
            this.buttonPlay.TabIndex = 5;
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarVolume.Location = new System.Drawing.Point(581, 97);
            this.trackBarVolume.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarVolume.Size = new System.Drawing.Size(56, 524);
            this.trackBarVolume.TabIndex = 7;
            this.trackBarVolume.Value = 90;
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
            // 
            // trackBarFileProgress
            // 
            this.trackBarFileProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarFileProgress.Location = new System.Drawing.Point(613, 114);
            this.trackBarFileProgress.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarFileProgress.Maximum = 100;
            this.trackBarFileProgress.Name = "trackBarFileProgress";
            this.trackBarFileProgress.Size = new System.Drawing.Size(445, 56);
            this.trackBarFileProgress.TabIndex = 8;
            this.trackBarFileProgress.Scroll += new System.EventHandler(this.trackBarFileProgress_Scroll);
            // 
            // timerFileProgress
            // 
            this.timerFileProgress.Interval = 1000;
            this.timerFileProgress.Tick += new System.EventHandler(this.timerFileProgress_Tick);
            // 
            // labelMusicName
            // 
            this.labelMusicName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMusicName.AutoSize = true;
            this.labelMusicName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMusicName.ForeColor = System.Drawing.Color.Green;
            this.labelMusicName.Location = new System.Drawing.Point(620, 86);
            this.labelMusicName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMusicName.Name = "labelMusicName";
            this.labelMusicName.Size = new System.Drawing.Size(18, 25);
            this.labelMusicName.TabIndex = 9;
            this.labelMusicName.Text = " ";
            // 
            // labelTimespan
            // 
            this.labelTimespan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTimespan.AutoSize = true;
            this.labelTimespan.Location = new System.Drawing.Point(625, 172);
            this.labelTimespan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTimespan.Name = "labelTimespan";
            this.labelTimespan.Size = new System.Drawing.Size(12, 17);
            this.labelTimespan.TabIndex = 10;
            this.labelTimespan.Text = " ";
            // 
            // labelMaxLength
            // 
            this.labelMaxLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMaxLength.AutoSize = true;
            this.labelMaxLength.Location = new System.Drawing.Point(980, 172);
            this.labelMaxLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaxLength.Name = "labelMaxLength";
            this.labelMaxLength.Size = new System.Drawing.Size(12, 17);
            this.labelMaxLength.TabIndex = 11;
            this.labelMaxLength.Text = " ";
            this.labelMaxLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAutoPlay
            // 
            this.labelAutoPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAutoPlay.AutoSize = true;
            this.labelAutoPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAutoPlay.Location = new System.Drawing.Point(1030, 588);
            this.labelAutoPlay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAutoPlay.Name = "labelAutoPlay";
            this.labelAutoPlay.Size = new System.Drawing.Size(28, 29);
            this.labelAutoPlay.TabIndex = 13;
            this.labelAutoPlay.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.panelMidiLed);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Location = new System.Drawing.Point(629, 364);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(429, 220);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Midi";
            // 
            // panelMidiLed
            // 
            this.panelMidiLed.Location = new System.Drawing.Point(8, 165);
            this.panelMidiLed.Margin = new System.Windows.Forms.Padding(4);
            this.panelMidiLed.Name = "panelMidiLed";
            this.panelMidiLed.Size = new System.Drawing.Size(36, 34);
            this.panelMidiLed.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Channels";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.checkBoxMidiChannel16);
            this.panel1.Controls.Add(this.checkBoxMidiChannel15);
            this.panel1.Controls.Add(this.checkBoxMidiChannel14);
            this.panel1.Controls.Add(this.checkBoxMidiChannel13);
            this.panel1.Controls.Add(this.checkBoxMidiChannel12);
            this.panel1.Controls.Add(this.checkBoxMidiChannel11);
            this.panel1.Controls.Add(this.checkBoxMidiChannel10);
            this.panel1.Controls.Add(this.checkBoxMidiChannel9);
            this.panel1.Controls.Add(this.checkBoxMidiChannel8);
            this.panel1.Controls.Add(this.checkBoxMidiChannel7);
            this.panel1.Controls.Add(this.checkBoxMidiChannel6);
            this.panel1.Controls.Add(this.checkBoxMidiChannel5);
            this.panel1.Controls.Add(this.checkBoxMidiChannel4);
            this.panel1.Controls.Add(this.checkBoxMidiChannel3);
            this.panel1.Controls.Add(this.checkBoxMidiChannel2);
            this.panel1.Controls.Add(this.checkBoxMidiChannel1);
            this.panel1.Location = new System.Drawing.Point(8, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 118);
            this.panel1.TabIndex = 0;
            // 
            // checkBoxMidiChannel16
            // 
            this.checkBoxMidiChannel16.AutoSize = true;
            this.checkBoxMidiChannel16.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxMidiChannel16.Checked = true;
            this.checkBoxMidiChannel16.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMidiChannel16.Location = new System.Drawing.Point(344, 64);
            this.checkBoxMidiChannel16.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxMidiChannel16.Name = "checkBoxMidiChannel16";
            this.checkBoxMidiChannel16.Size = new System.Drawing.Size(28, 38);
            this.checkBoxMidiChannel16.TabIndex = 15;
            this.checkBoxMidiChannel16.Text = "16";
            this.checkBoxMidiChannel16.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxMidiChannel16.UseVisualStyleBackColor = true;
            // 
            // checkBoxMidiChannel15
            // 
            this.checkBoxMidiChannel15.AutoSize = true;
            this.checkBoxMidiChannel15.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxMidiChannel15.Checked = true;
            this.checkBoxMidiChannel15.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMidiChannel15.Location = new System.Drawing.Point(299, 64);
            this.checkBoxMidiChannel15.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxMidiChannel15.Name = "checkBoxMidiChannel15";
            this.checkBoxMidiChannel15.Size = new System.Drawing.Size(28, 38);
            this.checkBoxMidiChannel15.TabIndex = 14;
            this.checkBoxMidiChannel15.Text = "15";
            this.checkBoxMidiChannel15.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxMidiChannel15.UseVisualStyleBackColor = true;
            // 
            // checkBoxMidiChannel14
            // 
            this.checkBoxMidiChannel14.AutoSize = true;
            this.checkBoxMidiChannel14.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxMidiChannel14.Checked = true;
            this.checkBoxMidiChannel14.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMidiChannel14.Location = new System.Drawing.Point(253, 64);
            this.checkBoxMidiChannel14.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxMidiChannel14.Name = "checkBoxMidiChannel14";
            this.checkBoxMidiChannel14.Size = new System.Drawing.Size(28, 38);
            this.checkBoxMidiChannel14.TabIndex = 13;
            this.checkBoxMidiChannel14.Text = "14";
            this.checkBoxMidiChannel14.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxMidiChannel14.UseVisualStyleBackColor = true;
            // 
            // checkBoxMidiChannel13
            // 
            this.checkBoxMidiChannel13.AutoSize = true;
            this.checkBoxMidiChannel13.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxMidiChannel13.Checked = true;
            this.checkBoxMidiChannel13.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMidiChannel13.Location = new System.Drawing.Point(208, 64);
            this.checkBoxMidiChannel13.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxMidiChannel13.Name = "checkBoxMidiChannel13";
            this.checkBoxMidiChannel13.Size = new System.Drawing.Size(28, 38);
            this.checkBoxMidiChannel13.TabIndex = 12;
            this.checkBoxMidiChannel13.Text = "13";
            this.checkBoxMidiChannel13.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxMidiChannel13.UseVisualStyleBackColor = true;
            // 
            // checkBoxMidiChannel12
            // 
            this.checkBoxMidiChannel12.AutoSize = true;
            this.checkBoxMidiChannel12.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxMidiChannel12.Checked = true;
            this.checkBoxMidiChannel12.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMidiChannel12.Location = new System.Drawing.Point(163, 64);
            this.checkBoxMidiChannel12.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxMidiChannel12.Name = "checkBoxMidiChannel12";
            this.checkBoxMidiChannel12.Size = new System.Drawing.Size(28, 38);
            this.checkBoxMidiChannel12.TabIndex = 11;
            this.checkBoxMidiChannel12.Text = "12";
            this.checkBoxMidiChannel12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxMidiChannel12.UseVisualStyleBackColor = true;
            // 
            // checkBoxMidiChannel11
            // 
            this.checkBoxMidiChannel11.AutoSize = true;
            this.checkBoxMidiChannel11.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxMidiChannel11.Checked = true;
            this.checkBoxMidiChannel11.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMidiChannel11.Location = new System.Drawing.Point(117, 64);
            this.checkBoxMidiChannel11.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxMidiChannel11.Name = "checkBoxMidiChannel11";
            this.checkBoxMidiChannel11.Size = new System.Drawing.Size(28, 38);
            this.checkBoxMidiChannel11.TabIndex = 10;
            this.checkBoxMidiChannel11.Text = "11";
            this.checkBoxMidiChannel11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxMidiChannel11.UseVisualStyleBackColor = true;
            // 
            // checkBoxMidiChannel10
            // 
            this.checkBoxMidiChannel10.AutoSize = true;
            this.checkBoxMidiChannel10.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxMidiChannel10.Checked = true;
            this.checkBoxMidiChannel10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMidiChannel10.Location = new System.Drawing.Point(72, 64);
            this.checkBoxMidiChannel10.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxMidiChannel10.Name = "checkBoxMidiChannel10";
            this.checkBoxMidiChannel10.Size = new System.Drawing.Size(28, 38);
            this.checkBoxMidiChannel10.TabIndex = 9;
            this.checkBoxMidiChannel10.Text = "10";
            this.checkBoxMidiChannel10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxMidiChannel10.UseVisualStyleBackColor = true;
            // 
            // checkBoxMidiChannel9
            // 
            this.checkBoxMidiChannel9.AutoSize = true;
            this.checkBoxMidiChannel9.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxMidiChannel9.Checked = true;
            this.checkBoxMidiChannel9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMidiChannel9.Location = new System.Drawing.Point(27, 64);
            this.checkBoxMidiChannel9.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxMidiChannel9.Name = "checkBoxMidiChannel9";
            this.checkBoxMidiChannel9.Size = new System.Drawing.Size(20, 38);
            this.checkBoxMidiChannel9.TabIndex = 8;
            this.checkBoxMidiChannel9.Text = "9";
            this.checkBoxMidiChannel9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxMidiChannel9.UseVisualStyleBackColor = true;
            // 
            // checkBoxMidiChannel8
            // 
            this.checkBoxMidiChannel8.AutoSize = true;
            this.checkBoxMidiChannel8.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxMidiChannel8.Checked = true;
            this.checkBoxMidiChannel8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMidiChannel8.Location = new System.Drawing.Point(344, 18);
            this.checkBoxMidiChannel8.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxMidiChannel8.Name = "checkBoxMidiChannel8";
            this.checkBoxMidiChannel8.Size = new System.Drawing.Size(20, 38);
            this.checkBoxMidiChannel8.TabIndex = 7;
            this.checkBoxMidiChannel8.Text = "8";
            this.checkBoxMidiChannel8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxMidiChannel8.UseVisualStyleBackColor = true;
            // 
            // checkBoxMidiChannel7
            // 
            this.checkBoxMidiChannel7.AutoSize = true;
            this.checkBoxMidiChannel7.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxMidiChannel7.Checked = true;
            this.checkBoxMidiChannel7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMidiChannel7.Location = new System.Drawing.Point(299, 18);
            this.checkBoxMidiChannel7.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxMidiChannel7.Name = "checkBoxMidiChannel7";
            this.checkBoxMidiChannel7.Size = new System.Drawing.Size(20, 38);
            this.checkBoxMidiChannel7.TabIndex = 6;
            this.checkBoxMidiChannel7.Text = "7";
            this.checkBoxMidiChannel7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxMidiChannel7.UseVisualStyleBackColor = true;
            // 
            // checkBoxMidiChannel6
            // 
            this.checkBoxMidiChannel6.AutoSize = true;
            this.checkBoxMidiChannel6.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxMidiChannel6.Checked = true;
            this.checkBoxMidiChannel6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMidiChannel6.Location = new System.Drawing.Point(253, 18);
            this.checkBoxMidiChannel6.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxMidiChannel6.Name = "checkBoxMidiChannel6";
            this.checkBoxMidiChannel6.Size = new System.Drawing.Size(20, 38);
            this.checkBoxMidiChannel6.TabIndex = 5;
            this.checkBoxMidiChannel6.Text = "6";
            this.checkBoxMidiChannel6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxMidiChannel6.UseVisualStyleBackColor = true;
            // 
            // checkBoxMidiChannel5
            // 
            this.checkBoxMidiChannel5.AutoSize = true;
            this.checkBoxMidiChannel5.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxMidiChannel5.Checked = true;
            this.checkBoxMidiChannel5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMidiChannel5.Location = new System.Drawing.Point(208, 18);
            this.checkBoxMidiChannel5.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxMidiChannel5.Name = "checkBoxMidiChannel5";
            this.checkBoxMidiChannel5.Size = new System.Drawing.Size(20, 38);
            this.checkBoxMidiChannel5.TabIndex = 4;
            this.checkBoxMidiChannel5.Text = "5";
            this.checkBoxMidiChannel5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxMidiChannel5.UseVisualStyleBackColor = true;
            // 
            // checkBoxMidiChannel4
            // 
            this.checkBoxMidiChannel4.AutoSize = true;
            this.checkBoxMidiChannel4.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxMidiChannel4.Checked = true;
            this.checkBoxMidiChannel4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMidiChannel4.Location = new System.Drawing.Point(163, 18);
            this.checkBoxMidiChannel4.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxMidiChannel4.Name = "checkBoxMidiChannel4";
            this.checkBoxMidiChannel4.Size = new System.Drawing.Size(20, 38);
            this.checkBoxMidiChannel4.TabIndex = 3;
            this.checkBoxMidiChannel4.Text = "4";
            this.checkBoxMidiChannel4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxMidiChannel4.UseVisualStyleBackColor = true;
            // 
            // checkBoxMidiChannel3
            // 
            this.checkBoxMidiChannel3.AutoSize = true;
            this.checkBoxMidiChannel3.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxMidiChannel3.Checked = true;
            this.checkBoxMidiChannel3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMidiChannel3.Location = new System.Drawing.Point(117, 18);
            this.checkBoxMidiChannel3.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxMidiChannel3.Name = "checkBoxMidiChannel3";
            this.checkBoxMidiChannel3.Size = new System.Drawing.Size(20, 38);
            this.checkBoxMidiChannel3.TabIndex = 2;
            this.checkBoxMidiChannel3.Text = "3";
            this.checkBoxMidiChannel3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxMidiChannel3.UseVisualStyleBackColor = true;
            // 
            // checkBoxMidiChannel2
            // 
            this.checkBoxMidiChannel2.AutoSize = true;
            this.checkBoxMidiChannel2.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxMidiChannel2.Checked = true;
            this.checkBoxMidiChannel2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMidiChannel2.Location = new System.Drawing.Point(72, 18);
            this.checkBoxMidiChannel2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxMidiChannel2.Name = "checkBoxMidiChannel2";
            this.checkBoxMidiChannel2.Size = new System.Drawing.Size(20, 38);
            this.checkBoxMidiChannel2.TabIndex = 1;
            this.checkBoxMidiChannel2.Text = "2";
            this.checkBoxMidiChannel2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxMidiChannel2.UseVisualStyleBackColor = true;
            // 
            // checkBoxMidiChannel1
            // 
            this.checkBoxMidiChannel1.AutoSize = true;
            this.checkBoxMidiChannel1.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxMidiChannel1.Checked = true;
            this.checkBoxMidiChannel1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMidiChannel1.Location = new System.Drawing.Point(27, 18);
            this.checkBoxMidiChannel1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxMidiChannel1.Name = "checkBoxMidiChannel1";
            this.checkBoxMidiChannel1.Size = new System.Drawing.Size(20, 38);
            this.checkBoxMidiChannel1.TabIndex = 0;
            this.checkBoxMidiChannel1.Text = "1";
            this.checkBoxMidiChannel1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxMidiChannel1.UseVisualStyleBackColor = true;
            // 
            // comboBoxMidiDevices
            // 
            this.comboBoxMidiDevices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxMidiDevices.DisplayMember = "ProductName";
            this.comboBoxMidiDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMidiDevices.FormattingEnabled = true;
            this.comboBoxMidiDevices.Location = new System.Drawing.Point(373, 36);
            this.comboBoxMidiDevices.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMidiDevices.Name = "comboBoxMidiDevices";
            this.comboBoxMidiDevices.Size = new System.Drawing.Size(386, 24);
            this.comboBoxMidiDevices.TabIndex = 16;
            this.comboBoxMidiDevices.ValueMember = "ProductId";
            this.comboBoxMidiDevices.SelectedIndexChanged += new System.EventHandler(this.comboBoxMidiDevices_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Midi Device";
            // 
            // checkBoxAutoSave
            // 
            this.checkBoxAutoSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxAutoSave.AutoSize = true;
            this.checkBoxAutoSave.Location = new System.Drawing.Point(876, 66);
            this.checkBoxAutoSave.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxAutoSave.Name = "checkBoxAutoSave";
            this.checkBoxAutoSave.Size = new System.Drawing.Size(95, 21);
            this.checkBoxAutoSave.TabIndex = 17;
            this.checkBoxAutoSave.Text = "Auto Save";
            this.checkBoxAutoSave.UseVisualStyleBackColor = true;
            // 
            // textBoxMidiControlVol
            // 
            this.textBoxMidiControlVol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMidiControlVol.Location = new System.Drawing.Point(579, 70);
            this.textBoxMidiControlVol.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMidiControlVol.Name = "textBoxMidiControlVol";
            this.textBoxMidiControlVol.Size = new System.Drawing.Size(36, 22);
            this.textBoxMidiControlVol.TabIndex = 18;
            this.textBoxMidiControlVol.TextChanged += new System.EventHandler(this.textBoxMidiControlVol_TextChanged);
            // 
            // textBoxMidiControlTrack
            // 
            this.textBoxMidiControlTrack.Location = new System.Drawing.Point(799, 169);
            this.textBoxMidiControlTrack.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMidiControlTrack.Name = "textBoxMidiControlTrack";
            this.textBoxMidiControlTrack.Size = new System.Drawing.Size(55, 22);
            this.textBoxMidiControlTrack.TabIndex = 19;
            this.textBoxMidiControlTrack.TextChanged += new System.EventHandler(this.textBoxMidiControlTrack_TextChanged);
            // 
            // textBoxMidiCommandReload
            // 
            this.textBoxMidiCommandReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMidiCommandReload.Location = new System.Drawing.Point(986, 69);
            this.textBoxMidiCommandReload.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMidiCommandReload.Name = "textBoxMidiCommandReload";
            this.textBoxMidiCommandReload.Size = new System.Drawing.Size(55, 22);
            this.textBoxMidiCommandReload.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(794, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "MIDI";
            // 
            // button1
            // 
            this.button1.AccessibleName = "Start MIDI";
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.ImageIndex = 6;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(763, 32);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 32);
            this.button1.TabIndex = 23;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.AccessibleName = "Stop MIDI";
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.ImageIndex = 7;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(800, 32);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 32);
            this.button2.TabIndex = 24;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBoxLoop
            // 
            this.checkBoxLoop.AutoSize = true;
            this.checkBoxLoop.Location = new System.Drawing.Point(625, 214);
            this.checkBoxLoop.Name = "checkBoxLoop";
            this.checkBoxLoop.Size = new System.Drawing.Size(62, 21);
            this.checkBoxLoop.TabIndex = 25;
            this.checkBoxLoop.Text = "Loop";
            this.checkBoxLoop.UseVisualStyleBackColor = true;
            this.checkBoxLoop.CheckedChanged += new System.EventHandler(this.checkBoxLoop_CheckedChanged);
            // 
            // checkBoxAutoPlay
            // 
            this.checkBoxAutoPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxAutoPlay.AutoSize = true;
            this.checkBoxAutoPlay.Location = new System.Drawing.Point(632, 599);
            this.checkBoxAutoPlay.Name = "checkBoxAutoPlay";
            this.checkBoxAutoPlay.Size = new System.Drawing.Size(105, 21);
            this.checkBoxAutoPlay.TabIndex = 26;
            this.checkBoxAutoPlay.Text = "Auto Play in";
            this.checkBoxAutoPlay.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(865, 600);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "seconds";
            // 
            // numericUpDownAutoPlay
            // 
            this.numericUpDownAutoPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownAutoPlay.Location = new System.Drawing.Point(739, 599);
            this.numericUpDownAutoPlay.Name = "numericUpDownAutoPlay";
            this.numericUpDownAutoPlay.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownAutoPlay.TabIndex = 29;
            // 
            // checkBoxPlayNext
            // 
            this.checkBoxPlayNext.AutoSize = true;
            this.checkBoxPlayNext.Location = new System.Drawing.Point(625, 241);
            this.checkBoxPlayNext.Name = "checkBoxPlayNext";
            this.checkBoxPlayNext.Size = new System.Drawing.Size(119, 21);
            this.checkBoxPlayNext.TabIndex = 30;
            this.checkBoxPlayNext.Text = "Auto play next";
            this.checkBoxPlayNext.UseVisualStyleBackColor = true;
            this.checkBoxPlayNext.CheckedChanged += new System.EventHandler(this.checkBoxPlayNext_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 652);
            this.Controls.Add(this.checkBoxPlayNext);
            this.Controls.Add(this.numericUpDownAutoPlay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBoxAutoPlay);
            this.Controls.Add(this.checkBoxLoop);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxMidiCommandReload);
            this.Controls.Add(this.textBoxMidiControlTrack);
            this.Controls.Add(this.textBoxMidiControlVol);
            this.Controls.Add(this.checkBoxAutoSave);
            this.Controls.Add(this.comboBoxMidiDevices);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.labelAutoPlay);
            this.Controls.Add(this.labelMaxLength);
            this.Controls.Add(this.labelTimespan);
            this.Controls.Add(this.labelMusicName);
            this.Controls.Add(this.trackBarFileProgress);
            this.Controls.Add(this.trackBarVolume);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSaveConfig);
            this.Controls.Add(this.buttonRefreshDevices);
            this.Controls.Add(this.comboBoxOutputDevices);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Duval Wave Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFileProgress)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAutoPlay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxOutputDevices;
        private System.Windows.Forms.Button buttonRefreshDevices;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button buttonSaveConfig;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxPlaylistName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxPlayList;
        private System.Windows.Forms.Button buttonSavePlaylistAs;
        private System.Windows.Forms.Button buttonSavePlaylist;
        private System.Windows.Forms.Button buttonOpenPlaylist;
        private System.Windows.Forms.Button buttonAddFileToPlaylist;
        private System.Windows.Forms.OpenFileDialog openFileDialogAddtoPlaylist;
        private System.Windows.Forms.OpenFileDialog openFileDialogOpenPlaylist;
        private System.Windows.Forms.SaveFileDialog saveFileDialogSavePlaylist;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.TrackBar trackBarFileProgress;
        private System.Windows.Forms.Timer timerFileProgress;
        private System.Windows.Forms.Label labelMusicName;
        private System.Windows.Forms.Label labelTimespan;
        private System.Windows.Forms.Label labelMaxLength;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.Button buttonRewind;
        private System.Windows.Forms.Label labelAutoPlay;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxMidiDevices;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelMidiLed;
        private System.Windows.Forms.CheckBox checkBoxAutoSave;
        private System.Windows.Forms.Button buttonDeleteFromPlaylist;
        private System.Windows.Forms.Button buttonMoveU;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.TextBox textBoxMidiControlForth;
        private System.Windows.Forms.TextBox textBoxMidiControlBack;
        private System.Windows.Forms.TextBox textBoxMidiControlPause;
        private System.Windows.Forms.TextBox textBoxMidiControlStop;
        private System.Windows.Forms.TextBox textBoxMidiControlPlay;
        private System.Windows.Forms.TextBox textBoxMidiControlVol;
        private System.Windows.Forms.TextBox textBoxMidiControlTrack;
        private System.Windows.Forms.CheckBox checkBoxMidiChannel16;
        private System.Windows.Forms.CheckBox checkBoxMidiChannel15;
        private System.Windows.Forms.CheckBox checkBoxMidiChannel14;
        private System.Windows.Forms.CheckBox checkBoxMidiChannel13;
        private System.Windows.Forms.CheckBox checkBoxMidiChannel12;
        private System.Windows.Forms.CheckBox checkBoxMidiChannel11;
        private System.Windows.Forms.CheckBox checkBoxMidiChannel10;
        private System.Windows.Forms.CheckBox checkBoxMidiChannel9;
        private System.Windows.Forms.CheckBox checkBoxMidiChannel8;
        private System.Windows.Forms.CheckBox checkBoxMidiChannel7;
        private System.Windows.Forms.CheckBox checkBoxMidiChannel6;
        private System.Windows.Forms.CheckBox checkBoxMidiChannel5;
        private System.Windows.Forms.CheckBox checkBoxMidiChannel4;
        private System.Windows.Forms.CheckBox checkBoxMidiChannel3;
        private System.Windows.Forms.CheckBox checkBoxMidiChannel2;
        private System.Windows.Forms.CheckBox checkBoxMidiChannel1;
        private System.Windows.Forms.TextBox textBoxMidiCommandReload;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBoxLoop;
        private System.Windows.Forms.CheckBox checkBoxAutoPlay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownAutoPlay;
        private System.Windows.Forms.CheckBox checkBoxPlayNext;
    }
}

