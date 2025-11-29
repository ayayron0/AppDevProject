using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarCardGameProject
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string musicPath = Application.StartupPath + @"\Assets\menu_music.wav";
            MusicManager.Play(musicPath, 0.5f);
            Application.Run(new MainMenuForm());
           
        }
    }
}
