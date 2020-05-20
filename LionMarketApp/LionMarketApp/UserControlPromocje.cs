using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LionMarketApp
{
    public partial class UserControlPromocje : UserControl
    {
        public FormMenu fMenu;

        public UserControlPromocje()
        {
            InitializeComponent();
        }

        private void btnOwoceProm_Click(object sender, EventArgs e)
        {
            fMenu.btnOwoce_Click(sender,e);
        }

        private void btnWarzywaProm_Click(object sender, EventArgs e)
        {
            fMenu.btnWarzywa_Click(sender, e);
        }

        private void btnNapojeProm_Click(object sender, EventArgs e)
        {
            fMenu.btnNapoje_Click(sender, e);
        }

        private void btnSlodyczeProm_Click(object sender, EventArgs e)
        {
            fMenu.btnSlodycze_Click(sender, e);
        }
    }
}
