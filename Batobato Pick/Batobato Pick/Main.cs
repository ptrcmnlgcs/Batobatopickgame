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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btntaptoplay_Click(object sender, EventArgs e)
        {
            Fightstage form2 = new Fightstage();
            form2.Show();
            
            
        }
    }
}
