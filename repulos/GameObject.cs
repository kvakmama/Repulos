using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repulos
{
    class GameObject
    {
        public Vec2 position = new Vec2();
        public Vec2 speed = new Vec2();
        public Vec2 size = new Vec2();
        public virtual void update(int milisec)
        {
            position.x += milisec * speed.x / 1000;
            position.y += milisec * speed.y / 1000;
        }
    }
}
