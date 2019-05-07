using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApCalculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtVisor.Text = "";
            txtResultado.Text = "";
            lbSequencias.Text = "Pósfixa";
        }
    }
}
