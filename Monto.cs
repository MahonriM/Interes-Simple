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
    public partial class Monto : Form
    {
        double c, m, i,t;
        public Monto()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbtiempo.Text == "Anual")
                {
                    switch (cmbtasa.Text)
                    {
                        case "Anual":
                           c = double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text);
                           capital();
                            
                            break;
                        case "Mensual":
                            c = double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 12;
                            capital();
                            
                            break;
                        case "Bimestral":
                            c = double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 6;
                           capital();
                            
                            break;
                        case "Semestral":
                            c = double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 2;
                           capital();
                            
                            break;
                        case "Trimestral":
                            c = double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 4;
                            capital();
                            
                            break;
                        case "Quincenal":
                            c = double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 24;
                            capital();
                            
                            break;
                        case "Diario":
                           c = double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 360;
                            capital();
                            break;
                        case "Semanal":
                            c = double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 360;
                            capital();


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
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 24;
                           capital();
                            
                            break;
                        case "Mensual":
                            c = double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 2;
                            capital();
                            
                            break;
                        case "Bimestral":
                            c = double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 4;
                            capital();
                            
                            break;
                        case "Semestral":
                            c = double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 12;
                           capital();
                            
                            break;
                        case "Trimestral":
                            c = double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 6;
                            capital();
                            
                            break;
                        case "Quincenal":
                            c = double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text);
                            capital();
                            
                            break;
                        case "Diario":
                            c = double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 0.07;
                            capital();
                            break;
                        case "Semanal":
                           c = double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / .47;
                            capital();


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
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 360;
                            capital();
                            
                            break;
                        case "Mensual":
                            c= double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 30;
                            capital();
                            
                            break;
                        case "Bimestral":
                            c= double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 60;
                           capital();
                            
                            break;
                        case "Semestral":
                            c= double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 180;
                           capital();
                            
                            break;
                        case "Trimestral":
                            c= double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 90;
                            capital();
                            
                            break;
                        case "Quincenal":
                            c= double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 15;
                            capital();
                            
                            break;
                        case "Diario":
                            c= double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text);
                            capital();
                            break;
                        case "Semanal":
                            c= double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 7.5;
                            capital();


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
                            c= double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 12;
                           capital();
                            
                            break;
                        case "Mensual":
                            c= double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text);
                            capital();
                            
                            break;
                        case "Bimestral":
                            c= double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 2;
                           capital();
                            
                            break;
                        case "Semestral":
                            c= double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 6;
                           capital();
                            
                            break;
                        case "Trimestral":
                            c= double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 3;
                            capital();
                            
                            break;
                        case "Quincenal":
                            c= double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / .5;
                            capital();
                            
                            break;
                        case "Diario":
                            c= double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / .03;
                            capital();
                            break;
                        case "Semanal":
                            c= double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / .25;
                            capital();

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
                            c= double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 48;
                           capital();
                            
                            break;
                        case "Mensual":
                            c= double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 4;
                            capital();
                            
                            break;
                        case "Bimestral":
                            c= double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 8;
                           capital();
                            
                            break;
                        case "Semestral":
                            c= double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 24;
                           capital();
                            
                            break;
                        case "Trimestral":
                            c= double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 12;
                            capital();
                            
                            break;
                        case "Quincenal":
                            c= double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 2;
                            capital();
                            
                            break;
                        case "Diario":
                            c= double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / .14;
                            capital();
                            break;
                        case "Semanal":
                            c= double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 1;
                            capital();

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
                            c= double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 2;
                           capital();
                            
                            break;
                        case "Mensual":
                            c= double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / .166666;
                            capital();
                            
                            break;
                        case "Bimestral":
                            c= double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / .3333;
                           capital();
                            
                            break;
                        case "Semestral":
                            c= double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 1;
                           capital();
                            
                            break;
                        case "Trimestral":
                            c= double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / .5;
                            capital();
                            
                            break;
                        case "Quincenal":
                            c= double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / .083333;
                            capital();
                            
                            break;
                        case "Diario":
                            c= double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / .005952;
                            capital();
                            break;
                        case "Semanal":
                            c= double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / .041666;
                            capital();

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
                            c= double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 6;
                           capital();
                            
                            break;
                        case "Mensual":
                            c= double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / .5;
                            capital();
                            
                            break;
                        case "Bimestral":
                            c= double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 1;
                           capital();
                            
                            break;
                        case "Semestral":
                            c= double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 3;
                           capital();
                            
                            break;
                        case "Trimestral":
                            c = double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 1.5;
                            capital();
                            
                            break;
                        case "Quincenal":
                            c= double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / .25;
                            capital();
                            
                            break;
                        case "Diario":
                            c= double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / .07;
                            capital();
                            break;
                        case "Semanal":
                            c = double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / .125;
                            capital();

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
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 4;
                            capital();
                            MessageBox.Show("El capital es" + m);
                            break;
                        case "Mensual":
                            c = double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / .3;
                            capital();
                            
                            break;
                        case "Bimestral":
                            c = double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / .7;
                            capital();
                            
                            break;
                        case "Semestral":
                            c = double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 2;
                            capital();
                            
                            break;
                        case "Trimestral":
                            c = double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 1;
                            capital();
                            
                            break;
                        case "Quincenal":
                            c = double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / .17;
                            capital();
                            
                            break;
                        case "Diario":
                            c = double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / .01190;
                            capital();
                            break;
                        case "Semanal":
                            c = double.Parse(txtcapital.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / .0833;
                            capital();

                            break;


                        default:
                            MessageBox.Show("Ha ocurrido un error verifica datos");
                            break;
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido un error verifica los datos que haz utilizado");
            }

        }
        void capital()
        {
            m = c * (1 + i * t);
            MessageBox.Show("El monto es"+m);
        }
    }
}
