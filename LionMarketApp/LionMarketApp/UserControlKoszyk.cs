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
    public partial class UserControlKoszyk : UserControl
    {
        public UserControlKoszyk()
        {
            InitializeComponent();

        }

        public List<ListViewItem> produktyKoszyk = new List<ListViewItem>();

        public double suma_koszyk = 0;

    }
}
