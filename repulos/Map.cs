using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repulos
{
    class Map
    {
        public List<GameObject> gameobjects = new List<GameObject>();

        public void load(String mapname)
        {
            GameObject player = new GameObject();
            player.size.x = 10;
            player.size.y = 10;
            gameobjects.Add(player);
        }
    }
}
