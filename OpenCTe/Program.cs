using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCTe.Classes;
using OpenCTe.View;

namespace OpenCTe {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Connection tc = new Connection();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if(tc.tryConn() == "---"){
                Application.Run(new Error());
            }else{
                Application.Run(new Form1());
            }
        }
    }
}
