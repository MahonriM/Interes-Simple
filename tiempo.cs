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
    public partial class tiempo : Form
    {
        double c, m, i,t;
        public tiempo()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            c=double.Parse(txtcapital.Text);
            m = double.Parse(txtmonto.Text);
            i = double.Parse(txtcapital.Text)/100;
            switch (cmbtasa.Text)
            {
                case"Anual":
                   tiempo();
                 break;
                 case"Mensual":
                 tiempo();
                 break;
                  case "Bimestral":
                              tiempo();
                             break;
                            case "Semestral":
                             tiempo();

                                break;
                            case "Trimestral":
                              tiempo();

                                break;
                            case "Quincenal":
                             tiempo();

                                break;
                            case "Diario":
                               tiempo();
                                break;
                            case "Semanal":
                              


                                break;

                default:
                    break;
            }
            void tiempo()
            {
                 t = m /( c-1) / i;
                MessageBox.Show("El tiempo es "+ t);
            }


        }
    }
}
