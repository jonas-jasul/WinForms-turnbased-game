using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objektWinFormsZaidimas
{
    class RichTextBoxAppend
    {
        //originally static
        public void AddNewText(string message, combatScreenWarrior f1)
        {
            f1.warCombatLog.AppendText(message);
        }

        public void AddNewText(string message, combatScreenMage f2)
        {
            f2.mageCombatLog.AppendText(message);
        }

        public void AddNewText(string message, combatScreenWarrior f1, combatScreenMage f2)
        {
            f1.warCombatLog.AppendText(message);
            f2.mageCombatLog.AppendText(message);
        }
    }
}
