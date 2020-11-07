using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopFacebookUI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            //Application.Run(new FormLogin());
            AppManager appManager = new AppManager();
            //appManager.run();
            
        }
    }
}
