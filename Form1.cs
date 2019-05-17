using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncapital_Click(object sender, EventArgs e)
        {
            Capitalsimple cp = new Capitalsimple();
            cp.Show();
        }

        private void btnmonto_Click(object sender, EventArgs e)
        {
            Monto mn = new Monto();
            mn.Show();
        }

        private void btninteres_Click(object sender, EventArgs e)
        {
            Interes I = new Interes();
            I.Show();
        }

        private void btntiempo_Click(object sender, EventArgs e)
        {
            tiempo t = new tiempo();
            t.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tasa ta = new tasa();
            ta.Show();
        }
    }
}
