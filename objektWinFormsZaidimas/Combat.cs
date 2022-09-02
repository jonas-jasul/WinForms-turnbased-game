using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objektWinFormsZaidimas
{
    //Siuo metu si klase siam projektui nenaudojama
    class Combat
    {
        public void PrintWarriorOptions(int remainingHealth, int remainingStamina, int HealthPotAmount)
        {
            PrintRemainingHealth(remainingHealth);
            Console.WriteLine("You have: " + remainingStamina + " stamina left");
            Console.WriteLine("You have: " + HealthPotAmount + " health potions");
            Console.WriteLine("__________________________________________________");
            Console.WriteLine("You have six options: \n(1) Sword Bash - Special Attack " +
                "\n(2) Basic Attack " +
                "\n(3) Use a HP potion " +
                "\n(4) Defend " +
                "\n(5) Use an item(ranged) " +
                "\n(6) Escape" +
                "\n\nEnter the according number to execute the desired action.");
            Console.WriteLine("__________________________________________________");
        }

        public void PrintMageOptions(int remainingHealth, int remainingMana, int HealthPotAmount, int ManaPotAmount)
        {
            PrintRemainingHealth(remainingHealth);
            Console.WriteLine("You have: " + remainingMana + " MP left");
            Console.WriteLine("You have: " + HealthPotAmount + " health potions");
            Console.WriteLine("You have: " + ManaPotAmount + " mana potions");
            Console.WriteLine("__________________________________________________");
            Console.WriteLine("\nYou have seven options: \n(1) Lightning Storm - Special Attack " +
                "\n(2) Basic Attack " +
                "\n(3) Use a HP potion " +
                "\n(4) Use a mana potion " +
                "\n(5) Defend " +
                "\n(6) Use an item(ranged) " +
                "\n(7) Escape" +
                "\n\nEnter the according number to execute the desired action.");
            Console.WriteLine("__________________________________________________");

        }

        public void PrintRemainingHealth(int remainingHealth)
        {
            Console.WriteLine("*****************************************");
            Console.WriteLine("You have: " + remainingHealth + " HP left");

        }

        public void PrintEnemyRemainingHealth(int remainingEnemyHealth)
        {
            Console.WriteLine("*****************************************");
            Console.WriteLine("Enemy has: " + remainingEnemyHealth + " HP left");
        }
    }
}
