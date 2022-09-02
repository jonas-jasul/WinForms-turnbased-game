using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace objektWinFormsZaidimas
{
    public partial class startScreen : Form
    {
        public startScreen()
        {
            InitializeComponent();
        }
        
        private void startScreen_Load(object sender, EventArgs e)
        {

        }

        private void startGame_Click(object sender, EventArgs e)
        {
            
            charCreation charCreation = new charCreation();
            charCreation.ShowDialog();
            this.Close();
        }
    }
}
