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
    public partial class combatScreenMage : Form
    {
        public combatScreenMage()
        {
            InitializeComponent();

        }
        string _plName;
        int _STR;
        int _INT;
        Player magePlayer = new Player();
        Enemy newEnemy = new Enemy();
        public combatScreenMage(string name, int STR, int INT, string enemyName)
        {
            InitializeComponent();
            _plName = name;
            _STR = STR;
            _INT = INT;
            playerNameInCombat.Text = _plName;
            magePlayer.name = _plName;
            magePlayer.PlayerClass = "Mage";
            magePlayer.strength = _STR;
            magePlayer.intelligence = _INT;
            mageDisplaySTR.Text = _STR.ToString();
            mageDisplayINT.Text = _INT.ToString();

            newEnemy.EnemyName = enemyName;
            enemyNameInCombat.Text = newEnemy.EnemyName;

            mageHPpotionsLeft.Text = magePlayer.healthPotion.ToString();
            mageManaPotLeft.Text = magePlayer.manaPotion.ToString();

        }



        private void combatScreenMage_Load(object sender, EventArgs e)
        {
            mageCombatLog.AppendText("You will be fighting: ");
            mageCombatLog.AppendText(newEnemy.EnemyName);
            mageCombatLog.AppendText("\nEnemy has: " + newEnemy.health + " HP");
        }
        public void takeAction(string action)
        {
            Random rnd = new Random();
            bool isEsc = false;
            bool isDef = false;

            switch (action)
            {
                case "1":
                    if (magePlayer.mana - 10 < 0)
                    {
                        mageCombatLog.AppendText("\nNot enough mana!");
                        /*mageLightnStorm.Enabled = false;*/
                        goto case "2";
                    }
                    else
                    {
                        int dmg = rnd.Next(3, 25 * (1 + (magePlayer.intelligence) / 100));
                        magePlayer.LightningStorm(dmg, this);
                        newEnemy.TakeDamage(dmg);
                        mageCombatLog.AppendText("\nEnemy has: " + newEnemy.health + " HP left");
                        mageCombatLog.ScrollToCaret();
                        break;
                    }

                case "2":
                    int dmgBas = rnd.Next(2, 15 * (1 + (magePlayer.strength) / 100));
                    magePlayer.BasicAttack(dmgBas, this);
                    newEnemy.TakeDamage(dmgBas);
                    mageCombatLog.AppendText("\nEnemy has: " + newEnemy.health + " HP left");
                    mageCombatLog.ScrollToCaret();
                    break;

                case "3":
                    if(magePlayer.healthPotion>0)
                    {
                        magePlayer.UseHealthPotion(this);
                        if(magePlayer.healthPotion==0)
                        {
                            mageUseHpPot.Enabled = false;
                            mageCombatLog.AppendText("\nYou are out of health potions!");
                        }
                    }
                    break;

                case "4":
                    break;

                case "5":
                    if(magePlayer.manaPotion>0)
                    {
                        magePlayer.UseManaPotion(this);
                        if(magePlayer.manaPotion==0)
                        {
                            mageUseManaPot.Enabled = false;
                            mageCombatLog.AppendText("\nYou are out of mana potions!");
                        }
                    }                    
                    break;

                case "6":
                    mageCombatLog.AppendText("\nYou are defending!\n");
                    isDef = true;
                    break;

                case "7":
                    int escRnd = rnd.Next(0, 5);
                    if (escRnd > 3)
                    {
                        mageCombatLog.AppendText("\nYou have successfully escaped the enemy!");
                        gameOver();
                        isEsc = true;
                        break;
                    }
                    else
                    {
                        mageCombatLog.AppendText("\nEscape was unsuccessful!");
                    }
                    break;
            }

            if (newEnemy.IsAlive && newEnemy.EnemyName == "Dragon" && isEsc == false)
            {
                if (isDef == true)
                {
                    int dmgDef = rnd.Next(2, 15) / 2;
                    newEnemy.DragonAttack(dmgDef, this);
                    magePlayer.TakeDamage(dmgDef);
                    mageCombatLog.ScrollToCaret();
                }
                else
                {
                    int atkRandom = rnd.Next(0, 2);
                    switch (atkRandom)
                    {
                        case 0:
                            mageCombatLog.AppendText("\n*****************************************\n");
                            int dmgDragon1 = rnd.Next(2, 15);
                            newEnemy.DragonAttack(dmgDragon1, this);
                            magePlayer.TakeDamage(dmgDragon1);
                            mageCombatLog.AppendText("Player has: " + magePlayer.health + " HP left!");
                            mageCombatLog.ScrollToCaret();
                            break;

                        case 1:
                            mageCombatLog.AppendText("\n*****************************************\n");
                            int dmgDragon2 = rnd.Next(4, 20);
                            newEnemy.DragonSpecialAttack(dmgDragon2, this);
                            magePlayer.TakeDamage(dmgDragon2);
                            mageCombatLog.AppendText("Player has: " + magePlayer.health + " HP left!");
                            mageCombatLog.ScrollToCaret();
                            break;

                    }
                }

            }

            else if (newEnemy.IsAlive && newEnemy.EnemyName == "Orc" && isEsc == false)
            {
                if (isDef == true)
                {
                    mageCombatLog.AppendText("\n*****************************************\n");
                    int dmgDef = rnd.Next(2, 12) / 2;
                    magePlayer.TakeDamage(dmgDef);
                    /*mageCombatLog.AppendText("The enemy attacks!\n");*/
                    newEnemy.OrcAttack(dmgDef, this);
                    mageCombatLog.AppendText("Player has: " + magePlayer.health + " HP left!");
                    mageCombatLog.ScrollToCaret();
                }
                else
                {
                    mageCombatLog.AppendText("\n*****************************************\n");
                    int dmgOrc = rnd.Next(2, 12);
                    magePlayer.TakeDamage(dmgOrc);
                    /*mageCombatLog.AppendText("The enemy attacks!\n");*/
                    newEnemy.OrcAttack(dmgOrc, this);
                    mageCombatLog.AppendText("Player has: " + magePlayer.health + " HP left!");
                    mageCombatLog.ScrollToCaret();
                }
            }

            if (!magePlayer.IsAlive)
            {
                mageCombatLog.AppendText("\n*****************************************\n");
                mageCombatLog.AppendText("You have died!");
                mageCombatLog.AppendText("\nTotal attack count: " + Entity.attackCount + "");
                gameOver();
                mageCombatLog.ScrollToCaret();
                setMaxBar();
                MessageBox.Show("You have been defeated!", "Defeat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                               
            }

            else if (!newEnemy.IsAlive)
            {
                mageCombatLog.AppendText("\n*****************************************\n");
                mageCombatLog.AppendText("Enemy has been defeated!");
                mageCombatLog.AppendText("\nTotal attack count: " + Entity.attackCount + "");
                gameOver();
                mageCombatLog.ScrollToCaret();
                setMaxBar();
                MessageBox.Show("You have won!", "Victory", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void gameOver()
        {
            mageBasicAttack.Enabled = false;
            mageDefend.Enabled = false;
            mageLightnStorm.Enabled = false;
            mageUseHpPot.Enabled = false;
            mageEscape.Enabled = false;
            mageUseManaPot.Enabled = false;
            mageUseItem.Enabled = false;            
        }
        public void setMaxBar()
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

            magePlayerBar.Value = magePlayer.health;
            magePlayerManaBar.Value = magePlayer.mana;
        }
        private void mageLightnStorm_Click(object sender, EventArgs e)
        {
            takeAction("1");
            setMaxBar();
        }

        private void mageBasicAttack_Click(object sender, EventArgs e)
        {
            takeAction("2");
            setMaxBar();
        }

        private void mageUseHpPot_Click(object sender, EventArgs e)
        {
            takeAction("3");
            setMaxBar();
            mageHPpotionsLeft.Text = magePlayer.healthPotion.ToString();
        }

        private void mageUseManaPot_Click(object sender, EventArgs e)
        {
            takeAction("5");
            setMaxBar();
            mageManaPotLeft.Text = magePlayer.manaPotion.ToString();
        }

        private void mageDefend_Click(object sender, EventArgs e)
        {
            takeAction("6");
            setMaxBar();
        }

        private void mageUseItem_Click(object sender, EventArgs e)
        {
            ItemWindow itemWindow = new ItemWindow("Mage", this, newEnemy, magePlayer);
            itemWindow.Show();
        }

        private void mageEscape_Click(object sender, EventArgs e)
        {
            takeAction("7");
            setMaxBar();
        }
    }
}
