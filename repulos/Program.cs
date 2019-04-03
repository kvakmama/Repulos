using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace repulos
{
    static class Program
    {
        private static System.Timers.Timer aTimer;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            aTimer = new System.Timers.Timer(10);
            aTimer.Enabled = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            TimeElapsed elapsed;
            Form1 form = new Form1();
            Map map = new Map();
            map.load("level1");
            form.renderer = new Renderer();
            form.renderer.map = map;
            elapsed = map.update;
            aTimer.Elapsed += (Object source, System.Timers.ElapsedEventArgs e)=>{ elapsed(10);form.Invalidate();};
            Application.Run(form);
            map.update(2);
            
        }
        public delegate void TimeElapsed(int milisec); 

    }
}
