
namespace objektWinFormsZaidimas
{
    partial class ItemWindow
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
            this.label3 = new System.Windows.Forms.Label();
            this.itemUseWand = new System.Windows.Forms.Button();
            this.itemUseRock = new System.Windows.Forms.Button();
            this.itemUseHammer = new System.Windows.Forms.Button();
            this.itemThrowHammer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Magic Wand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hammer";
            // 
            // itemUseWand
            // 
            this.itemUseWand.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.itemUseWand.Location = new System.Drawing.Point(170, 43);
            this.itemUseWand.Name = "itemUseWand";
            this.itemUseWand.Size = new System.Drawing.Size(94, 29);
            this.itemUseWand.TabIndex = 3;
            this.itemUseWand.Text = "USE";
            this.itemUseWand.UseVisualStyleBackColor = false;
            this.itemUseWand.Click += new System.EventHandler(this.itemUseWand_Click);
            // 
            // itemUseRock
            // 
            this.itemUseRock.BackColor = System.Drawing.Color.DodgerBlue;
            this.itemUseRock.Location = new System.Drawing.Point(170, 87);
            this.itemUseRock.Name = "itemUseRock";
            this.itemUseRock.Size = new System.Drawing.Size(94, 29);
            this.itemUseRock.TabIndex = 4;
            this.itemUseRock.Text = "THROW";
            this.itemUseRock.UseVisualStyleBackColor = false;
            this.itemUseRock.Click += new System.EventHandler(this.itemUseRock_Click);
            // 
            // itemUseHammer
            // 
            this.itemUseHammer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.itemUseHammer.Location = new System.Drawing.Point(170, 134);
            this.itemUseHammer.Name = "itemUseHammer";
            this.itemUseHammer.Size = new System.Drawing.Size(94, 29);
            this.itemUseHammer.TabIndex = 5;
            this.itemUseHammer.Text = "USE";
            this.itemUseHammer.UseVisualStyleBackColor = false;
            this.itemUseHammer.Click += new System.EventHandler(this.itemUseHammer_Click);
            // 
            // itemThrowHammer
            // 
            this.itemThrowHammer.BackColor = System.Drawing.Color.DodgerBlue;
            this.itemThrowHammer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.itemThrowHammer.Location = new System.Drawing.Point(281, 134);
            this.itemThrowHammer.Name = "itemThrowHammer";
            this.itemThrowHammer.Size = new System.Drawing.Size(94, 29);
            this.itemThrowHammer.TabIndex = 6;
            this.itemThrowHammer.Text = "THROW";
            this.itemThrowHammer.UseVisualStyleBackColor = false;
            this.itemThrowHammer.Click += new System.EventHandler(this.itemThrowHammer_Click);
            // 
            // ItemWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 259);
            this.Controls.Add(this.itemThrowHammer);
            this.Controls.Add(this.itemUseHammer);
            this.Controls.Add(this.itemUseRock);
            this.Controls.Add(this.itemUseWand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ItemWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item window";
            this.Load += new System.EventHandler(this.ItemWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button itemUseWand;
        private System.Windows.Forms.Button itemUseRock;
        private System.Windows.Forms.Button itemThrowHammer;
        public System.Windows.Forms.Button itemUseHammer;
    }
}