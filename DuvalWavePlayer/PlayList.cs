using NAudio.Midi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuvalWavePlayer
{
    public class PlayListFile
    {
        public String FileName { get; set; } = "";
        public String Name { get; set; } = "";
        public String Label { get; set; } = "";

        public int? Volume { get; set; } = null;

        public bool InLoop { get; set; } = false;
        public bool AutoPlayNext { get; set; } = false;
        
    }


    public enum ActionType
    {
        None,
        Forth,
        Back,
        Play,
        Pause,
        Stop,
        Volume,
        Track
    }

    public class MidiControlAction
    {
        public String command = "";
        public ActionType type = ActionType.None;
        public Action<object, int> action = null;

    }

    public class PlayList
    {
        public String Name { get; set; } = "";
        public String FileName { get; set; } = "";

        public List<PlayListFile> FileList { get; set; } = new List<PlayListFile>();

    }
}
