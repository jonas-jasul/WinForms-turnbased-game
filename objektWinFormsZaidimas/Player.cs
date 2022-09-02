using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objektWinFormsZaidimas
{
    namespace Characters
    {
        public class Player : Entity
        {

            public Player()
            {

            }
            RichTextBoxAppend append = new RichTextBoxAppend();

            /* ~Player()
             {            
                 Console.WriteLine("*****************************************");
                 Console.WriteLine("\nPlayer " + name + " was reset!\n");

             }*/


            private string playerClass;
            public int healthPotion = 5;
            public int manaPotion = 4;


            public void SwordBash(int dmg, combatScreenWarrior form)
            {

                /*combatScreenWarrior.main.Status = "\n*****************************************\n";
                combatScreenWarrior.main.Status = ("(Special Attack) You use your sword to bash the enemy!");
                combatScreenWarrior.main.Status = ("\nYou deal: " + dmg + " damage!");*/
                append.AddNewText("\n*****************************************\n", form);
                append.AddNewText("(Special Attack) You use your sword to bash the enemy!", form);
                append.AddNewText("\nYou deal: " + dmg + " damage!", form);
                stamina -= 20;
                attackCount++;
            }
            public void BasicAttack(int dmg)
            {
                combatScreenWarrior.main.Status = "\n*****************************************\n";
                combatScreenWarrior.main.Status = "You use a basic attack on the enemy!";
                combatScreenWarrior.main.Status = "\nYou deal: " + dmg + " damage!";
                attackCount++;
            }

            public void BasicAttack(int dmg, combatScreenMage form)
            {
                append.AddNewText("\n*****************************************\n", form);
                append.AddNewText("You use a basic attack on the enemy!", form);
                append.AddNewText("\nYou deal: " + dmg + " damage!", form);
                attackCount++;
            }
            /*public void EscapeSuccess()
            {
                Console.WriteLine("\n*****************************************");
                Console.WriteLine("You successfully escape from the enemy!");
            }

            public void EscapeFail()
            {
                Console.WriteLine("\n*****************************************");
                Console.WriteLine("You fail to escape the enemy!");
            }
            public void Defend()
            {
                Console.WriteLine("\n*****************************************");
                Console.WriteLine("\nYou prepare to defend yourself! " +
                    "All damage dealt to you will be halved!");
            }*/

            public void LightningStorm(int dmg, combatScreenMage form)
            {

                if (mana > 0)
                {
                    append.AddNewText("\n*****************************************\n", form);
                    append.AddNewText("(Special attack) " +
                    "You summon a massive lightning storm to damage your enemy! You use 10 mana", form);
                    append.AddNewText("\nYou deal: " + dmg + " damage!", form);
                    mana -= 10;
                    attackCount++;
                }
                else
                {
                    append.AddNewText("\nYou are out of mana!", form);

                }
            }

            public void UseHealthPotion(combatScreenWarrior form)
            {
                if (health + 15 < maxHealth)
                {
                    append.AddNewText("\nYou use a health potion to heal yourself! " +
                        "You gain 15 health points!", form);
                    health += 15;
                    healthPotion--;
                }
                else
                {
                    append.AddNewText("\nYou use a health potion to heal yourself! ", form);
                    health = maxHealth;
                    healthPotion--;
                }
            }

            public void UseHealthPotion(combatScreenMage form)
            {
                if (health + 15 < maxHealth)
                {
                    append.AddNewText("\nYou use a health potion to heal yourself! " +
                        "You gain 15 health points!", form);
                    health += 15;
                    healthPotion--;
                }
                else
                {
                    append.AddNewText("\nYou use a health potion to heal yourself! ", form);
                    health = maxHealth;
                    healthPotion--;
                }

            }

            public void UseManaPotion(combatScreenMage form)
            {
                if (mana + 10 < maxMana)
                {
                    append.AddNewText("\nYou use a mana potion to restore your mana! " +
                        "You gain 10 mana points!", form);
                    mana += 10;
                    manaPotion--;

                }
                else
                {
                    mana = maxMana;
                    manaPotion--;
                }

            }
            public string PlayerClass
            {
                get
                {
                    return playerClass;
                }

                set
                {
                    if (value == "Warrior")
                    {
                        this.health = 100;
                        maxHealth = 100;
                        this.stamina = 60;
                        this.manaPotion = 0;
                    }
                    else if (value == "Mage")
                    {
                        this.health = 60;
                        maxHealth = 60;
                        this.mana = 50;
                        this.manaPotion = 4;
                    }
                    playerClass = value;
                }
            }
        }
    }
}