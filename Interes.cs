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
    public partial class Interes : Form
    {
        double I, M, C, i, t;

        private void Interes_Load(object sender, EventArgs e)
        {
            txttiempo.Enabled = false;
            txtmonto.Enabled = false;
            txttasainteres.Enabled = false;
            txttiempo.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                txtmonto.Enabled = false;
                txttasainteres.Enabled = true;
                txttiempo.Enabled = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked == true)
                {
                    M = double.Parse(txtmonto.Text);
                    C= double.Parse(txtcapital.Text);
                    if (M<=0 || C<=0)
                    {
                        MessageBox.Show("La operacion no se puede realizar");
                    }
                    else
                    {
                        MessageBox.Show("El interes es" + Convert.ToString((M - C)));
                    }
                   

                }
                if(radioButton2.Checked==true)
                {
                    if (cmbtiempo.Text == "Anual")
                    {
                        switch (cmbtasa.Text)
                        {
                            case "Anual":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text);
                                capital();

                                break;
                            case "Mensual":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / 12;
                                capital();

                                break;
                            case "Bimestral":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / 6;
                                capital();

                                break;
                            case "Semestral":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / 2;
                                capital();

                                break;
                            case "Trimestral":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / 4;
                                capital();

                                break;
                            case "Quincenal":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / 24;
                                capital();

                                break;
                            case "Diario":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / 360;
                                capital();
                                break;
                            case "Semanal":
                               C=double.Parse(txtcapital.Text);
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
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / 24;
                                capital();

                                break;
                            case "Mensual":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / 2;
                                capital();

                                break;
                            case "Bimestral":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / 4;
                                capital();

                                break;
                            case "Semestral":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / 12;
                                capital();

                                break;
                            case "Trimestral":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / 6;
                                capital();

                                break;
                            case "Quincenal":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text);
                                capital();

                                break;
                            case "Diario":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / 0.07;
                                capital();
                                break;
                            case "Semanal":
                               C=double.Parse(txtcapital.Text);
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
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / 360;
                                capital();

                                break;
                            case "Mensual":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / 30;
                                capital();

                                break;
                            case "Bimestral":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / 60;
                                capital();

                                break;
                            case "Semestral":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / 180;
                                capital();

                                break;
                            case "Trimestral":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / 90;
                                capital();

                                break;
                            case "Quincenal":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / 15;
                                capital();

                                break;
                            case "Diario":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text);
                                capital();
                                break;
                            case "Semanal":
                               C=double.Parse(txtcapital.Text);
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
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / 12;
                                capital();

                                break;
                            case "Mensual":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text);
                                capital();

                                break;
                            case "Bimestral":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / 2;
                                capital();

                                break;
                            case "Semestral":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / 6;
                                capital();

                                break;
                            case "Trimestral":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / 3;
                                capital();

                                break;
                            case "Quincenal":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / .5;
                                capital();

                                break;
                            case "Diario":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / .03;
                                capital();
                                break;
                            case "Semanal":
                               C=double.Parse(txtcapital.Text);
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
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / 48;
                                capital();

                                break;
                            case "Mensual":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / 4;
                                capital();

                                break;
                            case "Bimestral":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / 8;
                                capital();

                                break;
                            case "Semestral":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / 24;
                                capital();

                                break;
                            case "Trimestral":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / 12;
                                capital();

                                break;
                            case "Quincenal":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / 2;
                                capital();

                                break;
                            case "Diario":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / .14;
                                capital();
                                break;
                            case "Semanal":
                               C=double.Parse(txtcapital.Text);
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
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / 2;
                                capital();

                                break;
                            case "Mensual":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / .166666;
                                capital();

                                break;
                            case "Bimestral":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / .3333;
                                capital();

                                break;
                            case "Semestral":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / 1;
                                capital();

                                break;
                            case "Trimestral":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / .5;
                                capital();

                                break;
                            case "Quincenal":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / .083333;
                                capital();

                                break;
                            case "Diario":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / .005952;
                                capital();
                                break;
                            case "Semanal":
                               C=double.Parse(txtcapital.Text);
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
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / 6;
                                capital();

                                break;
                            case "Mensual":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / .5;
                                capital();

                                break;
                            case "Bimestral":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / 1;
                                capital();

                                break;
                            case "Semestral":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / 3;
                                capital();

                                break;
                            case "Trimestral":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / 1.5;
                                capital();

                                break;
                            case "Quincenal":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / .25;
                                capital();

                                break;
                            case "Diario":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / .07;
                                capital();
                                break;
                            case "Semanal":
                                C = double.Parse(txtcapital.Text);
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
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / 4;
                                capital();
                               
                                break;
                            case "Mensual":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / .3;
                                capital();

                                break;
                            case "Bimestral":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / .7;
                                capital();

                                break;
                            case "Semestral":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / 2;
                                capital();

                                break;
                            case "Trimestral":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / 1;
                                capital();

                                break;
                            case "Quincenal":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / .17;
                                capital();

                                break;
                            case "Diario":
                               C=double.Parse(txtcapital.Text);
                                i = double.Parse(txttasainteres.Text) / 100;
                                t = double.Parse(txttiempo.Text) / .01190;
                                capital();
                                break;
                            case "Semanal":
                               C=double.Parse(txtcapital.Text);
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

            }
            catch (Exception)
            {

                MessageBox.Show("Verificar los datos");
            }
        }
        void capital()
        {
            I = C * i * t;
            MessageBox.Show("El interes es"+I);
        }

            public Interes()
            {
                InitializeComponent();
            }

            private void radioButton1_CheckedChanged(object sender, EventArgs e)
            {
                if (radioButton1.Checked == true)
                {
                    txttasainteres.Enabled = false;
                    txttiempo.Enabled = false;
                    txtmonto.Enabled = true;



                }
            }
        }
    }
