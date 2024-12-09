using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace B23_Ex05_SharonOlshanetsky_DenisKharenko
{
    public class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GameSettingsForm());
        }
    }
}
