using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradingApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void neworderbutton_Click(object sender, EventArgs e)
        {
            neworderbutton.Enabled = false;
            printorderbutton.Enabled = true;
            printpreviewbutton.Enabled = true;
            cancelbutton.Enabled = true;
            itemsgroupBox.Enabled = true;
            clientnametextBox.Focus();
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            neworderbutton.Enabled = true;
            printorderbutton.Enabled = false;
            printpreviewbutton.Enabled = false;
            cancelbutton.Enabled = false;
            itemsgroupBox.Enabled = false;

            clientnametextBox.Clear();
            itemsnamecomboBox.SelectedIndex = -1;
            quantitytextBox.Clear();
            unitpricetextBox.Clear();
        }
    }
}
