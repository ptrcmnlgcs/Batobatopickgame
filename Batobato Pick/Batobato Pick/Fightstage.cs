using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Batobato_Pick
{
    public partial class Fightstage : Form
    {
        public Fightstage()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Winner form3 = new Winner();
            form3.Show();
           
        }
    }
}
