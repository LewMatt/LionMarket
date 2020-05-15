using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LionMarketApp
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            userControlPromocje1.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnKoszyk_Click(object sender, EventArgs e)
        {
            userControlKoszyk1.BringToFront();
        }

        private void btnPromocje_Click(object sender, EventArgs e)
        {
            userControlPromocje1.BringToFront();
        }
    }
}
