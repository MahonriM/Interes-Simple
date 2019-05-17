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
    public partial class Capitalsimple : Form
    {
        double c, m, i, I,t;


        private void btncalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbtiempo.Text == "Anual")
                {
                    switch (cmbtasa.Text)
                    {
                        case "Anual":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text);
                            c = m / (1 + i * t);
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Mensual":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 12;
                            capital();
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Bimestral":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 6;
                            c = m / (1 + i * t);
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Semestral":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 2;
                            c = m / (1 + i * t);
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Trimestral":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 4;
                            capital();
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Quincenal":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 24;
                            capital();
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Diario":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 360;
                            capital();
                            break;
                        case "Semanal":
                            m = double.Parse(txtmonto.Text);
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
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 24;
                            c = m / (1 + i * t);
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Mensual":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 2;
                            capital();
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Bimestral":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 4;
                            c = m / (1 + i * t);
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Semestral":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 12;
                            c = m / (1 + i * t);
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Trimestral":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 6;
                            capital();
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Quincenal":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text);
                            capital();
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Diario":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 0.07;
                            capital();
                            break;
                        case "Semanal":
                            m = double.Parse(txtmonto.Text);
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
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 360;
                            c = m / (1 + i * t);
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Mensual":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 30;
                            capital();
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Bimestral":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 60;
                            c = m / (1 + i * t);
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Semestral":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 180;
                            c = m / (1 + i * t);
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Trimestral":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 90;
                            capital();
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Quincenal":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 15;
                            capital();
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Diario":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text);
                            capital();
                            break;
                        case "Semanal":
                            m = double.Parse(txtmonto.Text);
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
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 12;
                            c = m / (1 + i * t);
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Mensual":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text);
                            capital();
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Bimestral":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 2;
                            c = m / (1 + i * t);
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Semestral":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 6;
                            c = m / (1 + i * t);
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Trimestral":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 3;
                            capital();
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Quincenal":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / .5;
                            capital();
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Diario":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / .03;
                            capital();
                            break;
                        case "Semanal":
                            m = double.Parse(txtmonto.Text);
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
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 48;
                            c = m / (1 + i * t);
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Mensual":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text)/4;
                            capital();
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Bimestral":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 8;
                            c = m / (1 + i * t);
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Semestral":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 24;
                            c = m / (1 + i * t);
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Trimestral":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 12;
                            capital();
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Quincenal":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 2;
                            capital();
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Diario":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / .14;
                            capital();
                            break;
                        case "Semanal":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 1;
                            capital();

                            break;


                        default:
                            MessageBox.Show("Ha ocurrido un error verifica datos");
                            break;
                    }
                }
                if (cmbtiempo.Text=="Semestral")
                {
                    switch (cmbtasa.Text)
                    {
                        case "Anual":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 2;
                            c = m / (1 + i * t);
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Mensual":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) /.166666;
                            capital();
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Bimestral":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / .3333;
                            c = m / (1 + i * t);
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Semestral":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 1;
                            c = m / (1 + i * t);
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Trimestral":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / .5;
                            capital();
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Quincenal":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / .083333;
                            capital();
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Diario":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / .005952;
                            capital();
                            break;
                        case "Semanal":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / .041666;
                            capital();

                            break;


                        default:
                            MessageBox.Show("Ha ocurrido un error verifica datos");
                            break;
                    }

                }
                if (cmbtiempo.Text=="Bimestral")
                {
                    switch (cmbtasa.Text)
                    {
                        case "Anual":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 6;
                            c = m / (1 + i * t);
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Mensual":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / .5;
                            capital();
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Bimestral":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 1;
                            c = m / (1 + i * t);
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Semestral":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 3;
                            c = m / (1 + i * t);
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Trimestral":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 1.5;
                            capital();
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Quincenal":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / .25;
                            capital();
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Diario":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / .07;
                            capital();
                            break;
                        case "Semanal":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / .125;
                            capital();

                            break;


                        default:
                            MessageBox.Show("Ha ocurrido un error verifica datos");
                            break;
                    }

                }
                if (cmbtiempo.Text=="Trimestral")
                {
                    switch (cmbtasa.Text)
                    {
                        case "Anual":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 4;
                            c = m / (1 + i * t);
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Mensual":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / .3;
                            capital();
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Bimestral":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / .7;
                            c = m / (1 + i * t);
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Semestral":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 2;
                            c = m / (1 + i * t);
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Trimestral":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / 1;
                            capital();
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Quincenal":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / .17;
                            capital();
                            MessageBox.Show("El capital es" + c);
                            break;
                        case "Diario":
                            m = double.Parse(txtmonto.Text);
                            i = double.Parse(txttasainteres.Text) / 100;
                            t = double.Parse(txttiempo.Text) / .01190;
                            capital();
                            break;
                        case "Semanal":
                            m = double.Parse(txtmonto.Text);
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
             
            c = m / (1 + i * t);

        }

        public Capitalsimple()
        {
            InitializeComponent();
        }

        private void cmbtasa_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
        }
    }
}
