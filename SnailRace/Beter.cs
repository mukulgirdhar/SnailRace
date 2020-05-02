using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnailRace
{
    abstract class Beter
    {
        public int CurrentBalance { get; set; }
        public int[] CurrentBet { get; set; } = {0, 0};//{ammount:,on snail:}
        public bool IsOut { get; set; } = false;
        public string Name { get; set; }
        public Label Lbl { get; set; }
        public RadioButton Radio { get; set; }

        /// <summary>
        /// Checks the Beter has a balance above 0
        /// </summary>
        public void CheckOut()
        {
            if (CurrentBalance <= 0)
            {
                Lbl.Visible = false;
                Radio.Enabled = false;
                MessageBox.Show(Name + " has run out of money!");
                IsOut = true;
            }
        }
    }
}
