using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objektWinFormsZaidimas
{
    interface IEntity
    {
        void TakeDamage(int damage);
    }

    interface IThrowable
    {
        void Throw(combatScreenWarrior war);
        /*void Throw(combatScreenMage mage);*/
    }

    interface IMagic
    {
        void Cast(combatScreenMage mage);
    }

    interface IMelee
    {
        void Swing(combatScreenWarrior war);
    }
}
