using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objektWinFormsZaidimas
{
    public abstract class Entity:IEntity
    {
        public string name;
        public int strength;
        public int health;
        public int intelligence;
        public int stamina;
        public int mana;
        public bool IsAlive = true;
        public static int attackCount = 0;
        protected int maxHealth = 150;
        protected int maxMana = 50;

        public void TakeDamage(int dmgAmount)
        {
            health -= dmgAmount;
            if (health <= 0)
            {
                health = 0;
                IsAlive = false;

            }

        }

    }

}
