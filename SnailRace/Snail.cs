using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnailRace
{
    class Snail
    {
        public PictureBox Picture { get; set; }//to be linked to control on form
        public Point STARTING_LOCATION { get; set; }//to store the value of the control's original location, SHOULD NOT BE CHANGED ONCE SET
    }
}
