using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class Weapon : Item
    {
        public Weapon(int id, string name, string namePlural) : base(id, name, namePlural)
        {

        }

        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }
    }
}
