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
            player.size.x = 100;
            player.size.y = 100;
            player.speed.x = 20;
            gameobjects.Add(player);

            for (int i = 0; i < 5; i++)
            {
                GameObject obj = new GameObject();
                obj.size.x = 55;
                obj.size.y = 55;
                obj.position.x = (i + 1) * 100;
                obj.position.y = (i + 1) * 100;
                gameobjects.Add(obj);
            }               
        }

        public void update(int milisec)
        {
            foreach (GameObject obj in gameobjects)
            {
                obj.update(milisec);
            }
        }
    }
}
