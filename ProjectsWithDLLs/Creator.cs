using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04
{
    public  static class Creator
    {
        static private Hashtable buildings = new Hashtable();
        static private int _key;

        static public int CreateBuild()
        {
            Building building = new Building();
            _key++;
            buildings.Add(_key, building);

            return _key;
        }

        static public Building? GetBuilding(int key)
        {
            if (buildings.ContainsKey(key))
                return (Building)buildings[key];
            else return null;
        }
        static public bool DeleteBuild(int key)
        {
            if (buildings.ContainsKey(key)) { buildings.Remove(key); return true; }
            else return false;
        }

    }
}
