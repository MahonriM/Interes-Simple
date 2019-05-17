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
    public partial class tasa : Form
    {
        double I, i, t,c;
        public tasa()
        {
            InitializeComponent();
        }
        void interes()
        {
            i=I/(c*t);
            MessageBox.Show("La tasa de interes es"+ i);
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            if (cmbtiempo.Text == "Anual")
            {
                switch (cmbtasa.Text)
                {
                    case "Anual":
                        c = double.Parse(txtcapital.Text);
                      I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text);
                        interes();
                        
                        break;
                    case "Mensual":
                        c = double.Parse(txtcapital.Text);
                       
                        t = double.Parse(txttiempo.Text) / 12;
                       interes();
                        
                        break;
                    case "Bimestral":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / 6;
                        interes();
                        
                        break;
                    case "Semestral":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / 2;
                        interes();
                        
                        break;
                    case "Trimestral":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / 4;
                       interes();
                        
                        break;
                    case "Quincenal":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / 24;
                       interes();
                        
                        break;
                    case "Diario":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / 360;
                       interes();
                        break;
                    case "Semanal":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / 360;
                       interes();


                        break;


                    default:
                        MessageBox.Show("Ha OCCU");
                        break;
                }

            }
            if (cmbtiempo.Text == "Quincenal")
            {
                switch (cmbtasa.Text)
                {
                    case "Anual":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / 24;
                        interes();
                        
                        break;
                    case "Mensual":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / 2;
                       interes();
                        
                        break;
                    case "Bimestral":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / 4;
                        interes();
                        
                        break;
                    case "Semestral":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / 12;
                        interes();
                        
                        break;
                    case "Trimestral":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / 6;
                       interes();
                        
                        break;
                    case "Quincenal":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text);
                       interes();
                        
                        break;
                    case "Diario":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / 0.07;
                       interes();
                        break;
                    case "Semanal":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / .47;
                       interes();


                        break;


                    default:
                        MessageBox.Show("Ha ocurrido un error verifica datos");
                        break;

                }

            }
            if (cmbtiempo.Text == "Diario")
            {
                switch (cmbtasa.Text)
                {
                    case "Anual":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / 360;
                        interes();
                        
                        break;
                    case "Mensual":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / 30;
                       interes();
                        
                        break;
                    case "Bimestral":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / 60;
                        interes();
                        
                        break;
                    case "Semestral":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / 180;
                        interes();
                        
                        break;
                    case "Trimestral":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / 90;
                       interes();
                        
                        break;
                    case "Quincenal":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / 15;
                       interes();
                        
                        break;
                    case "Diario":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text);
                       interes();
                        break;
                    case "Semanal":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / 7.5;
                       interes();


                        break;


                    default:
                        MessageBox.Show("Ha ocurrido un error verifica datos");
                        break;

                }

            }
            if (cmbtiempo.Text == "Mensual")
            {
                switch (cmbtasa.Text)
                {
                    case "Anual":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / 12;
                        interes();
                        
                        break;
                    case "Mensual":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text);
                       interes();
                        
                        break;
                    case "Bimestral":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / 2;
                        interes();
                        
                        break;
                    case "Semestral":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / 6;
                        interes();
                        
                        break;
                    case "Trimestral":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / 3;
                       interes();
                        
                        break;
                    case "Quincenal":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / .5;
                       interes();
                        
                        break;
                    case "Diario":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / .03;
                       interes();
                        break;
                    case "Semanal":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / .25;
                       interes();

                        break;


                    default:
                        MessageBox.Show("Ha ocurrido un error verifica datos");
                        break;



                }
            }
            if (cmbtiempo.Text == "Semanal")
            {
                switch (cmbtasa.Text)
                {
                    case "Anual":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / 48;
                        interes();
                        
                        break;
                    case "Mensual":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / 4;
                       interes();
                        
                        break;
                    case "Bimestral":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / 8;
                        interes();
                        
                        break;
                    case "Semestral":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / 24;
                        interes();
                        
                        break;
                    case "Trimestral":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / 12;
                       interes();
                        
                        break;
                    case "Quincenal":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / 2;
                       interes();
                        
                        break;
                    case "Diario":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / .14;
                       interes();
                        break;
                    case "Semanal":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / 1;
                       interes();

                        break;


                    default:
                        MessageBox.Show("Ha ocurrido un error verifica datos");
                        break;
                }
            }
            if (cmbtiempo.Text == "Semestral")
            {
                switch (cmbtasa.Text)
                {
                    case "Anual":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / 2;
                        interes();
                        
                        break;
                    case "Mensual":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / .166666;
                       interes();
                        
                        break;
                    case "Bimestral":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / .3333;
                        interes();
                        
                        break;
                    case "Semestral":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / 1;
                        interes();
                        
                        break;
                    case "Trimestral":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / .5;
                       interes();
                        
                        break;
                    case "Quincenal":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / .083333;
                       interes();
                        
                        break;
                    case "Diario":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / .005952;
                       interes();
                        break;
                    case "Semanal":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / .041666;
                       interes();

                        break;


                    default:
                        MessageBox.Show("Ha ocurrido un error verifica datos");
                        break;
                }

            }
            if (cmbtiempo.Text == "Bimestral")
            {
                switch (cmbtasa.Text)
                {
                    case "Anual":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / 6;
                        interes();
                        
                        break;
                    case "Mensual":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / .5;
                       interes();
                        
                        break;
                    case "Bimestral":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / 1;
                        interes();
                        
                        break;
                    case "Semestral":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / 3;
                        interes();
                        
                        break;
                    case "Trimestral":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / 1.5;
                       interes();
                        
                        break;
                    case "Quincenal":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / .25;
                       interes();
                        
                        break;
                    case "Diario":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / .07;
                       interes();
                        break;
                    case "Semanal":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / .125;
                       interes();

                        break;


                    default:
                        MessageBox.Show("Ha ocurrido un error verifica datos");
                        break;
                }

            }
            if (cmbtiempo.Text == "Trimestral")
            {
                switch (cmbtasa.Text)
                {
                    case "Anual":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / 4;
                        interes();
                        
                        break;
                    case "Mensual":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / .3;
                       interes();
                        
                        break;
                    case "Bimestral":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / .7;
                        interes();
                        
                        break;
                    case "Semestral":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / 2;
                        interes();
                        
                        break;
                    case "Trimestral":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / 1;
                       interes();
                        
                        break;
                    case "Quincenal":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / .17;
                       interes();
                        
                        break;
                    case "Diario":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / .01190;
                       interes();
                        break;
                    case "Semanal":
                        c = double.Parse(txtcapital.Text);
                       I=double.Parse(txtinteres.Text);
                        t = double.Parse(txttiempo.Text) / .0833;
                       interes();

                        break;


                    default:
                        MessageBox.Show("Ha ocurrido un error verifica datos");
                        break;
                }

            }
        }
    }
}
