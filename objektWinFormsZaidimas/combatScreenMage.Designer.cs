
namespace objektWinFormsZaidimas
{
    partial class combatScreenMage
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
            this.mageHPpotionsLeft = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.magePlayerManaBar = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.enemyBar = new System.Windows.Forms.ProgressBar();
            this.magePlayerBar = new System.Windows.Forms.ProgressBar();
            this.mageDisplayINT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mageDisplaySTR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.enemyNameInCombat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.playerNameInCombat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mageEscape = new System.Windows.Forms.Button();
            this.mageUseItem = new System.Windows.Forms.Button();
            this.mageDefend = new System.Windows.Forms.Button();
            this.mageUseHpPot = new System.Windows.Forms.Button();
            this.mageBasicAttack = new System.Windows.Forms.Button();
            this.mageLightnStorm = new System.Windows.Forms.Button();
            this.mageCombatLog = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mageManaPotLeft = new System.Windows.Forms.TextBox();
            this.mageUseManaPot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mageHPpotionsLeft
            // 
            this.mageHPpotionsLeft.Location = new System.Drawing.Point(374, 389);
            this.mageHPpotionsLeft.Name = "mageHPpotionsLeft";
            this.mageHPpotionsLeft.ReadOnly = true;
            this.mageHPpotionsLeft.Size = new System.Drawing.Size(30, 27);
            this.mageHPpotionsLeft.TabIndex = 47;
            this.mageHPpotionsLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(409, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 20);
            this.label9.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(257, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 45;
            this.label8.Text = "HP potions left:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 446);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 44;
            this.label7.Text = "Mana:";
            // 
            // magePlayerManaBar
            // 
            this.magePlayerManaBar.Location = new System.Drawing.Point(76, 437);
            this.magePlayerManaBar.Maximum = 50;
            this.magePlayerManaBar.Name = "magePlayerManaBar";
            this.magePlayerManaBar.Size = new System.Drawing.Size(125, 29);
            this.magePlayerManaBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.magePlayerManaBar.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(660, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "HP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "HP:";
            // 
            // enemyBar
            // 
            this.enemyBar.ForeColor = System.Drawing.Color.Lime;
            this.enemyBar.Location = new System.Drawing.Point(697, 405);
            this.enemyBar.Name = "enemyBar";
            this.enemyBar.Size = new System.Drawing.Size(125, 29);
            this.enemyBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.enemyBar.TabIndex = 40;
            // 
            // magePlayerBar
            // 
            this.magePlayerBar.ForeColor = System.Drawing.Color.Lime;
            this.magePlayerBar.Location = new System.Drawing.Point(76, 387);
            this.magePlayerBar.Maximum = 60;
            this.magePlayerBar.Name = "magePlayerBar";
            this.magePlayerBar.Size = new System.Drawing.Size(125, 29);
            this.magePlayerBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.magePlayerBar.TabIndex = 39;
            // 
            // mageDisplayINT
            // 
            this.mageDisplayINT.Location = new System.Drawing.Point(239, 348);
            this.mageDisplayINT.Name = "mageDisplayINT";
            this.mageDisplayINT.ReadOnly = true;
            this.mageDisplayINT.Size = new System.Drawing.Size(30, 27);
            this.mageDisplayINT.TabIndex = 38;
            this.mageDisplayINT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "INT:";
            // 
            // mageDisplaySTR
            // 
            this.mageDisplaySTR.Location = new System.Drawing.Point(239, 310);
            this.mageDisplaySTR.Name = "mageDisplaySTR";
            this.mageDisplaySTR.ReadOnly = true;
            this.mageDisplaySTR.Size = new System.Drawing.Size(30, 27);
            this.mageDisplaySTR.TabIndex = 36;
            this.mageDisplaySTR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "STR:";
            // 
            // enemyNameInCombat
            // 
            this.enemyNameInCombat.Location = new System.Drawing.Point(697, 321);
            this.enemyNameInCombat.Name = "enemyNameInCombat";
            this.enemyNameInCombat.ReadOnly = true;
            this.enemyNameInCombat.Size = new System.Drawing.Size(125, 27);
            this.enemyNameInCombat.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(697, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Enemy:";
            // 
            // playerNameInCombat
            // 
            this.playerNameInCombat.Location = new System.Drawing.Point(59, 325);
            this.playerNameInCombat.Name = "playerNameInCombat";
            this.playerNameInCombat.ReadOnly = true;
            this.playerNameInCombat.Size = new System.Drawing.Size(125, 27);
            this.playerNameInCombat.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Player:";
            // 
            // mageEscape
            // 
            this.mageEscape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mageEscape.Location = new System.Drawing.Point(646, 599);
            this.mageEscape.Name = "mageEscape";
            this.mageEscape.Size = new System.Drawing.Size(150, 47);
            this.mageEscape.TabIndex = 30;
            this.mageEscape.Text = "Escape";
            this.mageEscape.UseVisualStyleBackColor = false;
            this.mageEscape.Click += new System.EventHandler(this.mageEscape_Click);
            // 
            // mageUseItem
            // 
            this.mageUseItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.mageUseItem.Location = new System.Drawing.Point(646, 525);
            this.mageUseItem.Name = "mageUseItem";
            this.mageUseItem.Size = new System.Drawing.Size(150, 54);
            this.mageUseItem.TabIndex = 29;
            this.mageUseItem.Text = "Use an item";
            this.mageUseItem.UseVisualStyleBackColor = false;
            this.mageUseItem.Click += new System.EventHandler(this.mageUseItem_Click);
            // 
            // mageDefend
            // 
            this.mageDefend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.mageDefend.Location = new System.Drawing.Point(354, 599);
            this.mageDefend.Name = "mageDefend";
            this.mageDefend.Size = new System.Drawing.Size(163, 47);
            this.mageDefend.TabIndex = 28;
            this.mageDefend.Text = "Defend";
            this.mageDefend.UseVisualStyleBackColor = false;
            this.mageDefend.Click += new System.EventHandler(this.mageDefend_Click);
            // 
            // mageUseHpPot
            // 
            this.mageUseHpPot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.mageUseHpPot.Location = new System.Drawing.Point(340, 525);
            this.mageUseHpPot.Name = "mageUseHpPot";
            this.mageUseHpPot.Size = new System.Drawing.Size(95, 54);
            this.mageUseHpPot.TabIndex = 27;
            this.mageUseHpPot.Text = "Use a HP potion";
            this.mageUseHpPot.UseVisualStyleBackColor = false;
            this.mageUseHpPot.Click += new System.EventHandler(this.mageUseHpPot_Click);
            // 
            // mageBasicAttack
            // 
            this.mageBasicAttack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mageBasicAttack.Location = new System.Drawing.Point(67, 599);
            this.mageBasicAttack.Name = "mageBasicAttack";
            this.mageBasicAttack.Size = new System.Drawing.Size(174, 47);
            this.mageBasicAttack.TabIndex = 26;
            this.mageBasicAttack.Text = "Basic Attack";
            this.mageBasicAttack.UseVisualStyleBackColor = false;
            this.mageBasicAttack.Click += new System.EventHandler(this.mageBasicAttack_Click);
            // 
            // mageLightnStorm
            // 
            this.mageLightnStorm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.mageLightnStorm.Location = new System.Drawing.Point(67, 525);
            this.mageLightnStorm.Name = "mageLightnStorm";
            this.mageLightnStorm.Size = new System.Drawing.Size(174, 54);
            this.mageLightnStorm.TabIndex = 25;
            this.mageLightnStorm.Text = "Lightning Storm";
            this.mageLightnStorm.UseVisualStyleBackColor = false;
            this.mageLightnStorm.Click += new System.EventHandler(this.mageLightnStorm_Click);
            // 
            // mageCombatLog
            // 
            this.mageCombatLog.Location = new System.Drawing.Point(62, 12);
            this.mageCombatLog.Name = "mageCombatLog";
            this.mageCombatLog.ReadOnly = true;
            this.mageCombatLog.Size = new System.Drawing.Size(760, 279);
            this.mageCombatLog.TabIndex = 24;
            this.mageCombatLog.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(239, 437);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 20);
            this.label10.TabIndex = 48;
            this.label10.Text = "Mana potions left:";
            // 
            // mageManaPotLeft
            // 
            this.mageManaPotLeft.Location = new System.Drawing.Point(374, 430);
            this.mageManaPotLeft.Name = "mageManaPotLeft";
            this.mageManaPotLeft.ReadOnly = true;
            this.mageManaPotLeft.Size = new System.Drawing.Size(30, 27);
            this.mageManaPotLeft.TabIndex = 49;
            this.mageManaPotLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mageUseManaPot
            // 
            this.mageUseManaPot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mageUseManaPot.Location = new System.Drawing.Point(441, 525);
            this.mageUseManaPot.Name = "mageUseManaPot";
            this.mageUseManaPot.Size = new System.Drawing.Size(96, 54);
            this.mageUseManaPot.TabIndex = 50;
            this.mageUseManaPot.Text = "Use a Mana potion";
            this.mageUseManaPot.UseVisualStyleBackColor = false;
            this.mageUseManaPot.Click += new System.EventHandler(this.mageUseManaPot_Click);
            // 
            // combatScreenMage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 664);
            this.Controls.Add(this.mageUseManaPot);
            this.Controls.Add(this.mageManaPotLeft);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.mageHPpotionsLeft);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.magePlayerManaBar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.enemyBar);
            this.Controls.Add(this.magePlayerBar);
            this.Controls.Add(this.mageDisplayINT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mageDisplaySTR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.enemyNameInCombat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.playerNameInCombat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mageEscape);
            this.Controls.Add(this.mageUseItem);
            this.Controls.Add(this.mageDefend);
            this.Controls.Add(this.mageUseHpPot);
            this.Controls.Add(this.mageBasicAttack);
            this.Controls.Add(this.mageLightnStorm);
            this.Controls.Add(this.mageCombatLog);
            this.Name = "combatScreenMage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Combat screen (Mage)";
            this.Load += new System.EventHandler(this.combatScreenMage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox mageHPpotionsLeft;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar magePlayerManaBar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar enemyBar;
        private System.Windows.Forms.ProgressBar magePlayerBar;
        public System.Windows.Forms.TextBox mageDisplayINT;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox mageDisplaySTR;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox enemyNameInCombat;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox playerNameInCombat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mageEscape;
        private System.Windows.Forms.Button mageUseItem;
        private System.Windows.Forms.Button mageDefend;
        private System.Windows.Forms.Button mageUseHpPot;
        private System.Windows.Forms.Button mageBasicAttack;
        private System.Windows.Forms.Button mageLightnStorm;
        public System.Windows.Forms.RichTextBox mageCombatLog;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox mageManaPotLeft;
        private System.Windows.Forms.Button mageUseManaPot;
    }
}