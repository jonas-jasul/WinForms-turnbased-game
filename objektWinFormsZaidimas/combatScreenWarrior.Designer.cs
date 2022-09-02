
namespace objektWinFormsZaidimas
{
    partial class combatScreenWarrior
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.warCombatLog = new System.Windows.Forms.RichTextBox();
            this.warSwordBash = new System.Windows.Forms.Button();
            this.warBasicAttack = new System.Windows.Forms.Button();
            this.warUseHpPot = new System.Windows.Forms.Button();
            this.warDefend = new System.Windows.Forms.Button();
            this.warUseItem = new System.Windows.Forms.Button();
            this.warEscape = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.playerNameInCombat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.enemyNameInCombat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.warDisplaySTR = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.warDisplayINT = new System.Windows.Forms.TextBox();
            this.warPlayerBar = new System.Windows.Forms.ProgressBar();
            this.enemyBar = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.warPlayerStaminaBar = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.warHPpotionsLeft = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // warCombatLog
            // 
            this.warCombatLog.Location = new System.Drawing.Point(75, 12);
            this.warCombatLog.Name = "warCombatLog";
            this.warCombatLog.ReadOnly = true;
            this.warCombatLog.Size = new System.Drawing.Size(760, 279);
            this.warCombatLog.TabIndex = 0;
            this.warCombatLog.Text = "";
            // 
            // warSwordBash
            // 
            this.warSwordBash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.warSwordBash.Location = new System.Drawing.Point(80, 525);
            this.warSwordBash.Name = "warSwordBash";
            this.warSwordBash.Size = new System.Drawing.Size(174, 54);
            this.warSwordBash.TabIndex = 1;
            this.warSwordBash.Text = "Sword Bash";
            this.warSwordBash.UseVisualStyleBackColor = false;
            this.warSwordBash.Click += new System.EventHandler(this.warSwordBash_Click);
            // 
            // warBasicAttack
            // 
            this.warBasicAttack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.warBasicAttack.Location = new System.Drawing.Point(80, 599);
            this.warBasicAttack.Name = "warBasicAttack";
            this.warBasicAttack.Size = new System.Drawing.Size(174, 47);
            this.warBasicAttack.TabIndex = 2;
            this.warBasicAttack.Text = "Basic Attack";
            this.warBasicAttack.UseVisualStyleBackColor = false;
            this.warBasicAttack.Click += new System.EventHandler(this.warBasicAttack_Click);
            // 
            // warUseHpPot
            // 
            this.warUseHpPot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.warUseHpPot.Location = new System.Drawing.Point(367, 525);
            this.warUseHpPot.Name = "warUseHpPot";
            this.warUseHpPot.Size = new System.Drawing.Size(150, 54);
            this.warUseHpPot.TabIndex = 3;
            this.warUseHpPot.Text = "Use a HP potion";
            this.warUseHpPot.UseVisualStyleBackColor = false;
            this.warUseHpPot.Click += new System.EventHandler(this.warUseHpPot_Click);
            // 
            // warDefend
            // 
            this.warDefend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.warDefend.Location = new System.Drawing.Point(367, 599);
            this.warDefend.Name = "warDefend";
            this.warDefend.Size = new System.Drawing.Size(150, 47);
            this.warDefend.TabIndex = 4;
            this.warDefend.Text = "Defend";
            this.warDefend.UseVisualStyleBackColor = false;
            this.warDefend.Click += new System.EventHandler(this.warDefend_Click);
            // 
            // warUseItem
            // 
            this.warUseItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.warUseItem.Location = new System.Drawing.Point(659, 525);
            this.warUseItem.Name = "warUseItem";
            this.warUseItem.Size = new System.Drawing.Size(150, 54);
            this.warUseItem.TabIndex = 5;
            this.warUseItem.Text = "Use an item";
            this.warUseItem.UseVisualStyleBackColor = false;
            this.warUseItem.Click += new System.EventHandler(this.warUseItem_Click);
            // 
            // warEscape
            // 
            this.warEscape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.warEscape.Location = new System.Drawing.Point(659, 599);
            this.warEscape.Name = "warEscape";
            this.warEscape.Size = new System.Drawing.Size(150, 47);
            this.warEscape.TabIndex = 6;
            this.warEscape.Text = "Escape";
            this.warEscape.UseVisualStyleBackColor = false;
            this.warEscape.Click += new System.EventHandler(this.warEscape_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Player:";
            // 
            // playerNameInCombat
            // 
            this.playerNameInCombat.Location = new System.Drawing.Point(72, 325);
            this.playerNameInCombat.Name = "playerNameInCombat";
            this.playerNameInCombat.ReadOnly = true;
            this.playerNameInCombat.Size = new System.Drawing.Size(125, 27);
            this.playerNameInCombat.TabIndex = 8;
            this.playerNameInCombat.TextChanged += new System.EventHandler(this.playerNameInCombat_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(710, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enemy:";
            // 
            // enemyNameInCombat
            // 
            this.enemyNameInCombat.Location = new System.Drawing.Point(710, 321);
            this.enemyNameInCombat.Name = "enemyNameInCombat";
            this.enemyNameInCombat.ReadOnly = true;
            this.enemyNameInCombat.Size = new System.Drawing.Size(125, 27);
            this.enemyNameInCombat.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "STR:";
            // 
            // warDisplaySTR
            // 
            this.warDisplaySTR.Location = new System.Drawing.Point(252, 310);
            this.warDisplaySTR.Name = "warDisplaySTR";
            this.warDisplaySTR.ReadOnly = true;
            this.warDisplaySTR.Size = new System.Drawing.Size(30, 27);
            this.warDisplaySTR.TabIndex = 12;
            this.warDisplaySTR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "INT:";
            // 
            // warDisplayINT
            // 
            this.warDisplayINT.Location = new System.Drawing.Point(252, 348);
            this.warDisplayINT.Name = "warDisplayINT";
            this.warDisplayINT.ReadOnly = true;
            this.warDisplayINT.Size = new System.Drawing.Size(30, 27);
            this.warDisplayINT.TabIndex = 14;
            this.warDisplayINT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // warPlayerBar
            // 
            this.warPlayerBar.ForeColor = System.Drawing.Color.Lime;
            this.warPlayerBar.Location = new System.Drawing.Point(89, 387);
            this.warPlayerBar.Name = "warPlayerBar";
            this.warPlayerBar.Size = new System.Drawing.Size(125, 29);
            this.warPlayerBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.warPlayerBar.TabIndex = 15;
            // 
            // enemyBar
            // 
            this.enemyBar.ForeColor = System.Drawing.Color.Lime;
            this.enemyBar.Location = new System.Drawing.Point(710, 405);
            this.enemyBar.Name = "enemyBar";
            this.enemyBar.Size = new System.Drawing.Size(125, 29);
            this.enemyBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.enemyBar.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "HP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(673, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "HP:";
            // 
            // warPlayerStaminaBar
            // 
            this.warPlayerStaminaBar.ForeColor = System.Drawing.Color.Yellow;
            this.warPlayerStaminaBar.Location = new System.Drawing.Point(89, 437);
            this.warPlayerStaminaBar.Maximum = 60;
            this.warPlayerStaminaBar.Name = "warPlayerStaminaBar";
            this.warPlayerStaminaBar.Size = new System.Drawing.Size(125, 29);
            this.warPlayerStaminaBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.warPlayerStaminaBar.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 446);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Stamina:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "HP potions left:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(422, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 20);
            this.label9.TabIndex = 22;
            // 
            // warHPpotionsLeft
            // 
            this.warHPpotionsLeft.Location = new System.Drawing.Point(369, 393);
            this.warHPpotionsLeft.Name = "warHPpotionsLeft";
            this.warHPpotionsLeft.ReadOnly = true;
            this.warHPpotionsLeft.Size = new System.Drawing.Size(30, 27);
            this.warHPpotionsLeft.TabIndex = 23;
            this.warHPpotionsLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // combatScreenWarrior
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 687);
            this.Controls.Add(this.warHPpotionsLeft);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.warPlayerStaminaBar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.enemyBar);
            this.Controls.Add(this.warPlayerBar);
            this.Controls.Add(this.warDisplayINT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.warDisplaySTR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.enemyNameInCombat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.playerNameInCombat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.warEscape);
            this.Controls.Add(this.warUseItem);
            this.Controls.Add(this.warDefend);
            this.Controls.Add(this.warUseHpPot);
            this.Controls.Add(this.warBasicAttack);
            this.Controls.Add(this.warSwordBash);
            this.Controls.Add(this.warCombatLog);
            this.Name = "combatScreenWarrior";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Combat screen (Warrior)";
            this.Load += new System.EventHandler(this.combatScreenWarrior_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button warSwordBash;
        private System.Windows.Forms.Button warBasicAttack;
        private System.Windows.Forms.Button warUseHpPot;
        private System.Windows.Forms.Button warDefend;
        private System.Windows.Forms.Button warUseItem;
        private System.Windows.Forms.Button warEscape;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox playerNameInCombat;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox enemyNameInCombat;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox warDisplaySTR;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox warDisplayINT;
        public System.Windows.Forms.RichTextBox warCombatLog;
        private System.Windows.Forms.ProgressBar warPlayerBar;
        private System.Windows.Forms.ProgressBar enemyBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar warPlayerStaminaBar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox warHPpotionsLeft;
    }
}