using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using objektWinFormsZaidimas.Items;
using objektWinFormsZaidimas.Characters;

namespace objektWinFormsZaidimas
{
    public partial class ItemWindow : Form
    {
        string _playerClass;

        //Hammer hammer = new Hammer();
        LargeHammer hammer = new LargeHammer();
        MagicWand wand = new MagicWand();
        Rock rock = new Rock();

        private combatScreenWarrior war;
        private combatScreenMage mag;
        private Enemy enem;
        private Player player;
        Random rnd = new Random();

        public ItemWindow()
        {
            InitializeComponent();

        }

        ~ItemWindow()
        {
            war.warCombatLog.AppendText("Item window was closed!");
        }

        public ItemWindow(string playerClass, combatScreenWarrior formWar, Enemy newEnemy, Player newPlayer)
        {

            InitializeComponent();
            _playerClass = playerClass;
            war = formWar;
            enem = newEnemy;
            player = newPlayer;

            if (!enem.IsAlive)
            {
                itemUseHammer.Enabled = false;
            }
            if (_playerClass == "Warrior")
            {
                itemUseWand.Enabled = false;
            }

        }

        public ItemWindow(string playerClass, combatScreenMage formMag, Enemy newEnemy, Player newPlayer)
        {

            InitializeComponent();
            _playerClass = playerClass;
            mag = formMag;
            enem = newEnemy;
            player = newPlayer;

            if (_playerClass == "Mage")
            {
                itemUseHammer.Enabled = false;
                itemThrowHammer.Enabled = false;
            }
        }

        private void itemUseWand_Click(object sender, EventArgs e)
        {
            int dmgWand = rnd.Next(4, 16);
            wand.Cast(mag);
            mag.mageCombatLog.ScrollToCaret();
            enem.TakeDamage(dmgWand);
            mag.mageCombatLog.AppendText("You deal: " + dmgWand + " damage!");
            mag.takeAction("4");
            mag.setMaxBar();
            this.Close();
        }

        private void itemUseHammer_Click(object sender, EventArgs e)
        {
            int dmgHammer = rnd.Next(3, 18);
            hammer.Swing(war);
            war.warCombatLog.ScrollToCaret();
            enem.TakeDamage(dmgHammer);
            war.warCombatLog.AppendText("You deal: " + dmgHammer + " damage!");
            war.takeAction("4");
            war.setMaxHpBar();
            this.Close();

        }

        private void ItemWindow_Load(object sender, EventArgs e)
        {

        }

        private void itemThrowHammer_Click(object sender, EventArgs e)
        {

            int dmgHammer2 = rnd.Next(3, 18);
            hammer.Throw(war);
            war.warCombatLog.ScrollToCaret();
            enem.TakeDamage(dmgHammer2);
            war.warCombatLog.AppendText("You deal: " + dmgHammer2 + " damage!");
            war.takeAction("4");
            war.setMaxHpBar();
            this.Close();


            /*else if(player.PlayerClass=="Mage")
            {
                int dmgHammer2 = rnd.Next(3, 18);
                hammer.Throw(mag);
                mag.mageCombatLog.ScrollToCaret();
                enem.TakeDamage(dmgHammer2);
                mag.mageCombatLog.AppendText("You deal: " + dmgHammer2 + " damage!");
                mag.takeAction("4");
                mag.setMaxBar();
                this.Close();
            }*/
        }

        private void itemUseRock_Click(object sender, EventArgs e)
        {
            if (_playerClass == "Warrior")
            {
                int dmgRock = rnd.Next(1, 10);
                rock.Throw(war);
                war.warCombatLog.ScrollToCaret();
                enem.TakeDamage(dmgRock);
                war.warCombatLog.AppendText("You deal: " + dmgRock + " damage!");
                war.takeAction("4");
                war.setMaxHpBar();
                this.Close();
            }

            else if (_playerClass == "Mage")
            {
                int dmgRock = rnd.Next(1, 10);
                rock.Throw(mag);
                mag.mageCombatLog.ScrollToCaret();
                enem.TakeDamage(dmgRock);
                mag.mageCombatLog.AppendText("You deal: " + dmgRock + " damage!");
                mag.takeAction("4");
                mag.setMaxBar();
                this.Close();
            }
        }
    }
}
