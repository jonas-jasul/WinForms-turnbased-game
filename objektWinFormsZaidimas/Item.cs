using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objektWinFormsZaidimas
{
    namespace Items
    {
        abstract class Item
        {
            public int amountLeft = 5;
            public RichTextBoxAppend append = new RichTextBoxAppend();
        }


        class MagicWand : Item, IMagic
        {

            public void Cast(combatScreenMage form1)
            {
                append.AddNewText("\n*****************************************\n", form1);
                append.AddNewText("You use the magic wand!\n", form1);
                amountLeft--;
            }
        }

        class Rock : Item, IThrowable
        {
            public void Throw(combatScreenWarrior form2)
            {
                append.AddNewText("\n*****************************************\n", form2);
                append.AddNewText("You throw a rock!\n", form2);
                amountLeft--;
            }
            public void Throw(combatScreenMage form1)
            {
                append.AddNewText("\n*****************************************\n", form1);
                append.AddNewText("You throw a rock!\n", form1);
                amountLeft--;
            }
        }

        class Hammer : Item, IMelee, IThrowable
        {
            public virtual void Swing(combatScreenWarrior form2)
            {
                append.AddNewText("\n*****************************************\n", form2);
                append.AddNewText("You use the hammer!\n", form2);
                amountLeft--;
            }

            public void Throw(combatScreenWarrior form2)
            {
                append.AddNewText("\n*****************************************\n", form2);
                append.AddNewText("You throw a hammer!\n", form2);
                amountLeft--;
            }
           /* public void Throw(combatScreenMage form1)
            {
                append.AddNewText("*****************************************\n", form1);
                append.AddNewText("You throw a hammer!\n", form1);
                amountLeft--;
            }*/


        }

        class LargeHammer : Hammer
        {
            public override void Swing(combatScreenWarrior form2)
            {
                base.Swing(form2);
                append.AddNewText("The weight of your large hammer crushes the opponent!\n", form2);
            }
        }
    }
}