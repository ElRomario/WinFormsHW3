using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsHW03YouTube
{
    internal class VideoPanel
    {
        public string Text_ { get; }
        public string Path_ { get; }

        public VideoPanel(string text, string path)
        {
            Text_ = text;   
            Path_ = path;   
        }



    }
}
