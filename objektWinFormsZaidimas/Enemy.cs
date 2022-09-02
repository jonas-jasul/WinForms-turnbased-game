using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objektWinFormsZaidimas
{
    namespace Characters
    {
        public class Enemy : Entity
        {
            private string enemyName;
            public Enemy()
            {

            }
            RichTextBoxAppend append = new RichTextBoxAppend();

            public void EnemyAttack()
            {
                combatScreenWarrior.main.Status = ("The enemy attacks");
            }

            public void EnemyAttack(combatScreenMage form)
            {
                append.AddNewText("The enemy attacks", form);
            }
            public void DragonAttack(int dmg)
            {
                EnemyAttack();
                combatScreenWarrior.main.Status = ("\nThe dragon spits his fire breath at you!");
                combatScreenWarrior.main.Status = ("\nThe dragon does: " + dmg + " damage!\n");
                attackCount++;
            }

            public void DragonAttack(int dmg, combatScreenMage form)
            {
                EnemyAttack(form);
                append.AddNewText("\nThe dragon spits his fire breath at you!", form);
                append.AddNewText("\nThe dragon does: " + dmg + " damage!\n", form);
                attackCount++;
            }

            public void DragonSpecialAttack(int dmg)
            {
                EnemyAttack();
                combatScreenWarrior.main.Status = ("\nThe dragon summons a mighty fire meteor and rains down fiery rain upon you!");
                combatScreenWarrior.main.Status = ("\nThe dragon does: " + dmg + " damage!\n");
                attackCount++;
            }

            public void DragonSpecialAttack(int dmg, combatScreenMage form)
            {
                EnemyAttack(form);
                append.AddNewText("\nThe dragon summons a mighty fire meteor and rains down fiery rain upon you!", form);
                append.AddNewText("\nThe dragon does: " + dmg + " damage!\n", form);
                attackCount++;
            }

            public void OrcAttack(int dmg, combatScreenMage form)
            {
                EnemyAttack(form);
                append.AddNewText("\nThe orc lunges at you with a wooden club!", form);
                append.AddNewText("\nThe orc does: " + dmg + " damage!\n", form);
                attackCount++;
            }
            public void OrcAttack(int dmg, combatScreenWarrior form2)
            {
                EnemyAttack();
                append.AddNewText("\nThe orc lunges at you with a wooden club!", form2);
                append.AddNewText("\nThe orc does: " + dmg + " damage!\n", form2);
                attackCount++;
            }
            public string EnemyName
            {
                get
                {
                    return enemyName;
                }

                set
                {
                    if (value == "Dragon")
                    {
                        health = 120;
                    }
                    else if (value == "Orc")
                    {
                        health = 80;
                    }
                    enemyName = value;
                }
            }

        }
    }
}
