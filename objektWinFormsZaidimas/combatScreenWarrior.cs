using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using objektWinFormsZaidimas.Characters;

namespace objektWinFormsZaidimas
{
    public partial class combatScreenWarrior : Form
    {
        string _plName;
        int _STR;
        int _INT;
        Player warPlayer = new Player();
        Enemy newEnemy = new Enemy();
        public combatScreenWarrior()
        {
            InitializeComponent();

        }
        public combatScreenWarrior(string name, int STR, int INT, string enemyName)
        {
            InitializeComponent();
            _plName = name;
            _STR = STR;
            _INT = INT;
            playerNameInCombat.Text = _plName;
            warPlayer.name = _plName;
            warPlayer.PlayerClass = "Warrior";
            warPlayer.strength = _STR;
            warPlayer.intelligence = _INT;
            warDisplaySTR.Text = _STR.ToString();
            warDisplayINT.Text = _INT.ToString();

            newEnemy.EnemyName = enemyName;
            enemyNameInCombat.Text = newEnemy.EnemyName;

            warHPpotionsLeft.Text = warPlayer.healthPotion.ToString();
            main = this;
        }
        internal static combatScreenWarrior main;
        internal string Status
        {
            get { return warCombatLog.Text.ToString(); }
            set { warCombatLog.AppendText(value); }
        }


        private void playerNameInCombat_TextChanged(object sender, EventArgs e)
        {

        }

        private void combatScreenWarrior_Load(object sender, EventArgs e)
        {
            warCombatLog.AppendText("You will be fighting: ");
            warCombatLog.AppendText(newEnemy.EnemyName);
            warCombatLog.AppendText("\nEnemy has: " + newEnemy.health + " HP\n");
        }

        public void takeAction(string action)
        {
            bool isDef = false;
            bool isEsc = false;
            Random rnd = new Random();
            switch (action)
            {
                case "1":
                    if (warPlayer.stamina - 20 < 0)
                    {
                        warCombatLog.AppendText("Not enough stamina!");
                        goto case "2";
                    }
                    else
                    {
                        int dmg = rnd.Next(2, 20 * (1 + (warPlayer.strength) / 100));
                        warPlayer.SwordBash(dmg, this);
                        newEnemy.TakeDamage(dmg);
                        warCombatLog.AppendText("\nEnemy has: " + newEnemy.health + " HP left");
                        warCombatLog.ScrollToCaret();
                    }
                    break;

                case "2":
                    int dmgBas = rnd.Next(2, 12 * (1 + (warPlayer.strength) / 100));
                    warPlayer.BasicAttack(dmgBas);
                    newEnemy.TakeDamage(dmgBas);
                    break;

                case "3":
                    if (warPlayer.healthPotion > 0)
                    {
                        warPlayer.UseHealthPotion(this);
                        if(warPlayer.healthPotion==0)
                        {
                            warUseHpPot.Enabled = false;
                            warCombatLog.AppendText("\nYou are out of health potions!");
                        }
                    }
                   
                    break;

                case "4":

                    break;

                case "5":
                    warCombatLog.AppendText("\nYou are defending!\n");
                    isDef = true;
                    break;

                case "6":
                    int escRnd = rnd.Next(0, 5);
                    if(escRnd>3)
                    {
                        warCombatLog.AppendText("\nYou have successfully escaped the enemy!");
                        gameOver();
                        isEsc = true;
                        break;
                    }
                    else
                    {
                        warCombatLog.AppendText("\nEscape was unsuccessful!");

                    }
                    break;
            }
            if (warPlayer.stamina < 60)
            {
                warPlayer.stamina += 5;
            }

            if (newEnemy.IsAlive && newEnemy.EnemyName == "Dragon" && isEsc==false)
            {
                if (isDef == true)
                {
                    int dmgDef = rnd.Next(2, 15) / 2;
                    newEnemy.DragonAttack(dmgDef);
                    warPlayer.TakeDamage(dmgDef);
                    warCombatLog.ScrollToCaret();
                }
                else
                {
                    int atkRandom = rnd.Next(0, 2);
                    switch (atkRandom)
                    {
                        case 0:
                            warCombatLog.AppendText("\n*****************************************\n");
                            int dmgDragon1 = rnd.Next(2, 15);
                            newEnemy.DragonAttack(dmgDragon1);
                            warPlayer.TakeDamage(dmgDragon1);
                            warCombatLog.AppendText("Player has: " + warPlayer.health + " HP left!");
                            warCombatLog.ScrollToCaret();
                            break;

                        case 1:
                            warCombatLog.AppendText("\n*****************************************\n");
                            int dmgDragon2 = rnd.Next(4, 20);
                            newEnemy.DragonSpecialAttack(dmgDragon2);
                            warPlayer.TakeDamage(dmgDragon2);
                            warCombatLog.AppendText("Player has: " + warPlayer.health + " HP left!");
                            warCombatLog.ScrollToCaret();
                            break;

                    }
                }

            }
            else if (newEnemy.IsAlive && newEnemy.EnemyName == "Orc" &&isEsc==false)
            {
                if (isDef == true)
                {
                    warCombatLog.AppendText("\n*****************************************\n");
                    int dmgDef = rnd.Next(2, 12) / 2;
                    warPlayer.TakeDamage(dmgDef);
                    /*warCombatLog.AppendText("The enemy attacks!\n");*/
                    newEnemy.OrcAttack(dmgDef, this);
                    warCombatLog.AppendText("Player has: " + warPlayer.health + " HP left!");
                    warCombatLog.ScrollToCaret();
                }
                else
                {
                    warCombatLog.AppendText("\n*****************************************\n");
                    int dmgOrc = rnd.Next(2, 12);
                    warPlayer.TakeDamage(dmgOrc);
                    /* warCombatLog.AppendText("The enemy attacks!\n");*/
                    newEnemy.OrcAttack(dmgOrc, this);
                    warCombatLog.AppendText("Player has: " + warPlayer.health + " HP left!");
                    warCombatLog.ScrollToCaret();
                }
            }
            if (!warPlayer.IsAlive)
            {
                warCombatLog.AppendText("\n*****************************************\n");
                warCombatLog.AppendText("You have died!");
                warCombatLog.AppendText("\nTotal attack count: " + Entity.attackCount + "");
                gameOver();
                warCombatLog.ScrollToCaret();
                setMaxHpBar();
                MessageBox.Show("You have been defeated!", "Defeat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (!newEnemy.IsAlive)
            {
                warCombatLog.AppendText("\n*****************************************\n");
                warCombatLog.AppendText("Enemy has been defeated!");
                warCombatLog.AppendText("\nTotal attack count: " + Entity.attackCount + "");
                gameOver();
                warCombatLog.ScrollToCaret();
                setMaxHpBar();
                MessageBox.Show("You have won!", "Victory", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gameOver()
        {
            warSwordBash.Enabled = false;
            warBasicAttack.Enabled = false;
            warDefend.Enabled = false;
            warUseHpPot.Enabled = false;
            warEscape.Enabled = false;
            warUseItem.Enabled = false;
        }
        public void setMaxHpBar()
        {
            if (newEnemy.EnemyName == "Dragon")
            {
                enemyBar.Maximum = 120;
                enemyBar.Value = newEnemy.health;
            }

            else if (newEnemy.EnemyName == "Orc")
            {
                enemyBar.Maximum = 80;
                enemyBar.Value = newEnemy.health;
            }
            warPlayerBar.Value = warPlayer.health;
            warPlayerStaminaBar.Value = warPlayer.stamina;
        }
        private void warSwordBash_Click(object sender, EventArgs e)
        {
            takeAction("1");
            setMaxHpBar();
        }

        private void warBasicAttack_Click(object sender, EventArgs e)
        {
            takeAction("2");
            setMaxHpBar();
        }

        private void warUseHpPot_Click(object sender, EventArgs e)
        {
            takeAction("3");
            setMaxHpBar();
            warHPpotionsLeft.Text = warPlayer.healthPotion.ToString();
        }

        private void warUseItem_Click(object sender, EventArgs e)
        {
            ItemWindow itemWindow = new ItemWindow("Warrior", this, newEnemy, warPlayer);
            itemWindow.Show();

        }

        private void warDefend_Click(object sender, EventArgs e)
        {
            takeAction("5");
            setMaxHpBar();
        }

        private void warEscape_Click(object sender, EventArgs e)
        {
            takeAction("6");
            setMaxHpBar();
        }
    }
}
