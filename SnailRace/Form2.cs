using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnailRace
{
    public partial class Form2 : Form
    {
        //SETUP


        public Form2()
        {
            InitializeComponent();
        }

        //removing the minimize and maximize buttons from the form, and disabling resizability, while keeping the exit button.
        //https://msdn.microsoft.com/en-us/library/ms632600.aspx has the references for the actual values to change
        private const long WS_MAXIMIZEBOX = 0x00010000L;
        private const long WS_MINIMIZEBOX = 0x00020000L;
        private const long WS_SIZEBOX = 0x00040000L;//changes whether the form can be resized
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style &= ~(int)WS_MAXIMIZEBOX;//bitwise operations to toggle the settings
                cp.Style &= ~(int)WS_MINIMIZEBOX;
                cp.Style &= ~(int)WS_SIZEBOX;
                return cp;
            }
        }

        //EVENTS

        private void bntStart_Click(object sender, EventArgs e)
        {
            if (cbxSnails.SelectedItem is int && cbxBetters.SelectedItem is int)//checks both aren't null and are both the correct type
            {
                Hide();//next form must be shown before this form can actually be closed
                Form1 myForm = new Form1((int)cbxSnails.SelectedItem, (int)cbxBetters.SelectedItem);
                myForm.ShowDialog();
                Close();
            }
        }
    }
}
