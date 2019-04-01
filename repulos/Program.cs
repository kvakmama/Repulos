using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace repulos
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            TimeElapsed elapsed;
            Form1 form = new Form1();
            Map map = new Map();
            map.load("level1");
            form.renderer = new Renderer();
            form.renderer.map = map;
            Application.Run(form);
            map.update(2);
            
        }
        public delegate void TimeElapsed(int milisec); 

    }
}
