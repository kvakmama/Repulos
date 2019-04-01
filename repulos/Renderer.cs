using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repulos
{
    class Renderer
    {
        public void paint(System.Drawing.Graphics formGraphics)
        {
            if (map == null)
            {
                return;
            }

            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            foreach (GameObject obj in map.gameobjects)
            {
                formGraphics.FillRectangle(myBrush, new Rectangle(Convert.ToInt32(obj.position.x), Convert.ToInt32(obj.position.y), Convert.ToInt32(obj.size.x), Convert.ToInt32(obj.size.y)));
            }
            myBrush.Dispose();
        }
        public Map map;
    }
}
