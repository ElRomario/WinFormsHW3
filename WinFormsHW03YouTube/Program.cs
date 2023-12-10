namespace WinFormsHW03YouTube
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            List<VideoPanel> panels = new();

            foreach (VideoPanel panel in panels) 
            {
                panels.Add(new VideoPanel("OMG ITS HAPPENING", "random path"));
                panels.Add(new VideoPanel("OMG ITS HAPPENING", "random path"));
                panels.Add(new VideoPanel("OMG ITS HAPPENING", "random path"));
                panels.Add(new VideoPanel("OMG ITS HAPPENING", "random path"));
                panels.Add(new VideoPanel("OMG ITS HAPPENING", "random path"));
                panels.Add(new VideoPanel("OMG ITS HAPPENING", "random path"));
                panels.Add(new VideoPanel("OMG ITS HAPPENING", "random path"));
                panels.Add(new VideoPanel("OMG ITS HAPPENING", "random path"));
            }
        }
    }
}