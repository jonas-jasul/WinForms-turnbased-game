
namespace objektWinFormsZaidimas
{
    partial class charCreation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.enterPlayerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.selectClass = new System.Windows.Forms.ComboBox();
            this.beginGame = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.statPointsLeft = new System.Windows.Forms.TextBox();
            this.selectSTR = new System.Windows.Forms.TextBox();
            this.selectINT = new System.Windows.Forms.TextBox();
            this.increaseSTR = new System.Windows.Forms.Button();
            this.decreaseSTR = new System.Windows.Forms.Button();
            this.increaseINT = new System.Windows.Forms.Button();
            this.decreaseINT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create your character!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player name:";
            // 
            // enterPlayerName
            // 
            this.enterPlayerName.Location = new System.Drawing.Point(103, 131);
            this.enterPlayerName.Name = "enterPlayerName";
            this.enterPlayerName.Size = new System.Drawing.Size(227, 27);
            this.enterPlayerName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Choose player class:";
            // 
            // selectClass
            // 
            this.selectClass.FormattingEnabled = true;
            this.selectClass.Items.AddRange(new object[] {
            "Warrior",
            "Mage"});
            this.selectClass.Location = new System.Drawing.Point(103, 216);
            this.selectClass.Name = "selectClass";
            this.selectClass.Size = new System.Drawing.Size(108, 28);
            this.selectClass.TabIndex = 4;
            this.selectClass.SelectedIndexChanged += new System.EventHandler(this.selectClass_SelectedIndexChanged);
            // 
            // beginGame
            // 
            this.beginGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.beginGame.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.beginGame.Location = new System.Drawing.Point(354, 358);
            this.beginGame.Name = "beginGame";
            this.beginGame.Size = new System.Drawing.Size(104, 47);
            this.beginGame.TabIndex = 5;
            this.beginGame.Text = "Begin!";
            this.beginGame.UseVisualStyleBackColor = false;
            this.beginGame.Click += new System.EventHandler(this.beginGame_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(522, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Select your stats:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(522, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "STR:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(522, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "INT:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(510, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Stat points left:";
            // 
            // statPointsLeft
            // 
            this.statPointsLeft.Location = new System.Drawing.Point(625, 217);
            this.statPointsLeft.Name = "statPointsLeft";
            this.statPointsLeft.ReadOnly = true;
            this.statPointsLeft.Size = new System.Drawing.Size(65, 27);
            this.statPointsLeft.TabIndex = 12;
            this.statPointsLeft.TextChanged += new System.EventHandler(this.statPointsLeft_TextChanged);
            // 
            // selectSTR
            // 
            this.selectSTR.Location = new System.Drawing.Point(579, 135);
            this.selectSTR.Name = "selectSTR";
            this.selectSTR.ReadOnly = true;
            this.selectSTR.Size = new System.Drawing.Size(62, 27);
            this.selectSTR.TabIndex = 13;
            this.selectSTR.TextChanged += new System.EventHandler(this.selectSTR_TextChanged);
            // 
            // selectINT
            // 
            this.selectINT.Location = new System.Drawing.Point(579, 176);
            this.selectINT.Name = "selectINT";
            this.selectINT.ReadOnly = true;
            this.selectINT.Size = new System.Drawing.Size(62, 27);
            this.selectINT.TabIndex = 14;
            this.selectINT.TextChanged += new System.EventHandler(this.selectINT_TextChanged);
            // 
            // increaseSTR
            // 
            this.increaseSTR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.increaseSTR.Location = new System.Drawing.Point(659, 135);
            this.increaseSTR.Name = "increaseSTR";
            this.increaseSTR.Size = new System.Drawing.Size(31, 29);
            this.increaseSTR.TabIndex = 15;
            this.increaseSTR.Text = "+";
            this.increaseSTR.UseVisualStyleBackColor = false;
            this.increaseSTR.Click += new System.EventHandler(this.increaseSTR_Click);
            // 
            // decreaseSTR
            // 
            this.decreaseSTR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.decreaseSTR.Location = new System.Drawing.Point(708, 135);
            this.decreaseSTR.Name = "decreaseSTR";
            this.decreaseSTR.Size = new System.Drawing.Size(31, 29);
            this.decreaseSTR.TabIndex = 16;
            this.decreaseSTR.Text = "-";
            this.decreaseSTR.UseVisualStyleBackColor = false;
            this.decreaseSTR.Click += new System.EventHandler(this.decreaseSTR_Click);
            // 
            // increaseINT
            // 
            this.increaseINT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.increaseINT.Location = new System.Drawing.Point(659, 176);
            this.increaseINT.Name = "increaseINT";
            this.increaseINT.Size = new System.Drawing.Size(31, 29);
            this.increaseINT.TabIndex = 17;
            this.increaseINT.Text = "+";
            this.increaseINT.UseVisualStyleBackColor = false;
            this.increaseINT.Click += new System.EventHandler(this.increaseINT_Click);
            // 
            // decreaseINT
            // 
            this.decreaseINT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.decreaseINT.Location = new System.Drawing.Point(708, 174);
            this.decreaseINT.Name = "decreaseINT";
            this.decreaseINT.Size = new System.Drawing.Size(31, 29);
            this.decreaseINT.TabIndex = 18;
            this.decreaseINT.Text = "-";
            this.decreaseINT.UseVisualStyleBackColor = false;
            this.decreaseINT.Click += new System.EventHandler(this.decreaseINT_Click);
            // 
            // charCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.decreaseINT);
            this.Controls.Add(this.increaseINT);
            this.Controls.Add(this.decreaseSTR);
            this.Controls.Add(this.increaseSTR);
            this.Controls.Add(this.selectINT);
            this.Controls.Add(this.selectSTR);
            this.Controls.Add(this.statPointsLeft);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.beginGame);
            this.Controls.Add(this.selectClass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.enterPlayerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "charCreation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Character creation";
            this.Load += new System.EventHandler(this.charCreation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox selectClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox statPointsLeft;
        private System.Windows.Forms.TextBox selectSTR;
        private System.Windows.Forms.TextBox selectINT;
        private System.Windows.Forms.Button increaseSTR;
        private System.Windows.Forms.Button decreaseSTR;
        private System.Windows.Forms.Button increaseINT;
        private System.Windows.Forms.Button decreaseINT;
        public System.Windows.Forms.TextBox enterPlayerName;
        public System.Windows.Forms.Button beginGame;
    }
}