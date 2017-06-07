using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoItNow
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtDiasPrioridade1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int qDiasP1 = Convert.ToInt16(txtDiasPrioridade1.Text);
            switch (qDiasP1)
            {
                 case 1:
                    txtDiasPrioridade1.Text = "1";
                    break;
                case 2:
                    txtDiasPrioridade1.Text = "1";
                    break;
                case 3:
                    txtDiasPrioridade1.Text = "2";
                    break;
                case 4:
                    txtDiasPrioridade1.Text = "2";
                    break;
                case 5:
                    txtDiasPrioridade1.Text = "3";
                    break;
                case 6:
                    txtDiasPrioridade1.Text = "4";
                    break;
                case 7:
                    txtDiasPrioridade1.Text = "4";
                    break;
                case 8:
                    txtDiasPrioridade1.Text = "5";
                    break;
                case 9:
                    txtDiasPrioridade1.Text = "6";
                    break;
                case 10:
                    txtDiasPrioridade1.Text = "6";
                    break;
                default:
                    MessageBox.Show("Valor acima do limite máximo permitido (10 dias)");
                    break;
            }

            int qDiasP2 = Convert.ToInt16(txtDiasPrioridade2.Text);
            switch (qDiasP2)
            {
                  case 1:
                    txtDiasPrioridade2.Text = "1";
                    break;
                case 2:
                    txtDiasPrioridade2.Text = "1";
                    break;
                case 3:
                    txtDiasPrioridade2.Text = "2";
                    break;
                case 4:
                    txtDiasPrioridade2.Text = "2";
                    break;
                case 5:
                    txtDiasPrioridade2.Text = "3";
                    break;
                case 6:
                    txtDiasPrioridade2.Text = "4";
                    break;
                case 7:
                    txtDiasPrioridade2.Text = "4";
                    break;
                case 8:
                    txtDiasPrioridade2.Text = "5";
                    break;
                case 9:
                    txtDiasPrioridade2.Text = "6";
                    break;
                case 10:
                    txtDiasPrioridade2.Text = "6";
                    break;
                default:
                    MessageBox.Show("Valor acima do limite máximo permitido (10 dias)");
                    break;
            }

            int qDiasP3 = Convert.ToInt16(txtDiasPrioridade3.Text);
            switch (qDiasP3)
            {
                case 0:
                    txtDiasPrioridade3.Text = "";
                    break;
                case 1:
                    txtDiasPrioridade3.Text = "1";
                    break;
                case 2:
                    txtDiasPrioridade3.Text = "1";
                    break;
                case 3:
                    txtDiasPrioridade3.Text = "2";
                    break;
                case 4:
                    txtDiasPrioridade3.Text = "2";
                    break;
                case 5:
                    txtDiasPrioridade3.Text = "3";
                    break;
                case 6:
                    txtDiasPrioridade3.Text = "4";
                    break;
                case 7:
                    txtDiasPrioridade3.Text = "4";
                    break;
                case 8:
                    txtDiasPrioridade3.Text = "5";
                    break;
                case 9:
                    txtDiasPrioridade3.Text = "6";
                    break;
                case 10:
                    txtDiasPrioridade3.Text = "6";
                    break;
                default:
                    MessageBox.Show("Valor acima do limite máximo permitido (10 dias)");
                    break;
            }

            int qDiasP4 = Convert.ToInt16(txtDiasPrioridade4.Text);
            switch (qDiasP4)
            {
                case 1:
                    txtDiasPrioridade4.Text = "1";
                    break;
                case 2:
                    txtDiasPrioridade4.Text = "1";
                    break;
                case 3:
                    txtDiasPrioridade4.Text = "2";
                    break;
                case 4:
                    txtDiasPrioridade4.Text = "2";
                    break;
                case 5:
                    txtDiasPrioridade4.Text = "3";
                    break;
                case 6:
                    txtDiasPrioridade4.Text = "4";
                    break;
                case 7:
                    txtDiasPrioridade4.Text = "4";
                    break;
                case 8:
                    txtDiasPrioridade4.Text = "5";
                    break;
                case 9:
                    txtDiasPrioridade4.Text = "6";
                    break;
                case 10:
                    txtDiasPrioridade4.Text = "6";
                    break;
                default:
                    MessageBox.Show("Valor acima do limite máximo permitido (10 dias)");
                    break;
            }

            int qDiasT1 = Convert.ToInt16(txtDiasTarefa1.Text);
                switch (qDiasT1)
                {
                    case 1:
                        txtDiasTarefa1.Text = "1";
                        break;
                    case 2:
                        txtDiasTarefa1.Text = "1";
                        break;
                    case 3:
                        txtDiasTarefa1.Text = "2";
                        break;
                    case 4:
                        txtDiasTarefa1.Text = "2";
                        break;
                    case 5:
                        txtDiasTarefa1.Text = "3";
                        break;
                    case 6:
                        txtDiasTarefa1.Text = "4";
                        break;
                    case 7:
                        txtDiasTarefa1.Text = "4";
                        break;
                    case 8:
                        txtDiasTarefa1.Text = "5";
                        break;
                    case 9:
                        txtDiasTarefa1.Text = "6";
                        break;
                    case 10:
                        txtDiasTarefa1.Text = "6";
                        break;
                    default:
                        MessageBox.Show("Valor acima do limite máximo permitido (10 dias)");
                        break;
                } 

                int qDiasT2 = Convert.ToInt16(txtDiasTarefa2.Text);
                switch (qDiasT2)
                {
                    case 1:
                        txtDiasTarefa2.Text = "1";
                        break;
                    case 2:
                        txtDiasTarefa2.Text = "1";
                        break;
                    case 3:
                        txtDiasTarefa2.Text = "2";
                        break;
                    case 4:
                        txtDiasTarefa2.Text = "2";
                        break;
                    case 5:
                        txtDiasTarefa2.Text = "3";
                        break;
                    case 6:
                        txtDiasTarefa2.Text = "4";
                        break;
                    case 7:
                        txtDiasTarefa2.Text = "4";
                        break;
                    case 8:
                        txtDiasTarefa2.Text = "5";
                        break;
                    case 9:
                        txtDiasTarefa2.Text = "6";
                        break;
                    case 10:
                        txtDiasTarefa2.Text = "6";
                        break;
                    default:
                        MessageBox.Show("Valor acima do limite máximo permitido (10 dias)");
                        break;
                }

                int qDiasT3 = Convert.ToInt16(txtDiasTarefa3.Text);
                switch (qDiasT3)
                {

                    case 1:
                        txtDiasTarefa3.Text = "1";
                        break;
                    case 2:
                        txtDiasTarefa3.Text = "1";
                        break;
                    case 3:
                        txtDiasTarefa3.Text = "2";
                        break;
                    case 4:
                        txtDiasTarefa3.Text = "2";
                        break;
                    case 5:
                        txtDiasTarefa3.Text = "3";
                        break;
                    case 6:
                        txtDiasTarefa3.Text = "4";
                        break;
                    case 7:
                        txtDiasTarefa3.Text = "4";
                        break;
                    case 8:
                        txtDiasTarefa3.Text = "5";
                        break;
                    case 9:
                        txtDiasTarefa3.Text = "6";
                        break;
                    case 10:
                        txtDiasTarefa3.Text = "6";
                        break;
                    default:
                        MessageBox.Show("Valor acima do limite máximo permitido (10 dias)");
                        break;
                }


                int qDiasT4 = Convert.ToInt16(txtDiasTarefa4.Text);
                switch (qDiasT4)
                {
                    case 1:
                        txtDiasTarefa4.Text = "1";
                        break;
                    case 2:
                        txtDiasTarefa4.Text = "1";
                        break;
                    case 3:
                        txtDiasTarefa4.Text = "2";
                        break;
                    case 4:
                        txtDiasTarefa4.Text = "2";
                        break;
                    case 5:
                        txtDiasTarefa4.Text = "3";
                        break;
                    case 6:
                        txtDiasTarefa4.Text = "4";
                        break;
                    case 7:
                        txtDiasTarefa4.Text = "4";
                        break;
                    case 8:
                        txtDiasTarefa4.Text = "5";
                        break;
                    case 9:
                        txtDiasTarefa4.Text = "6";
                        break;
                    case 10:
                        txtDiasTarefa4.Text = "6";
                        break;
                    default:
                        MessageBox.Show("Valor acima do limite máximo permitido (10 dias)");
                        break;
                }

                int qDiasT5 = Convert.ToInt16(txtDiasTarefa5.Text);
                switch (qDiasT5)
                {
                    case 1:
                        txtDiasTarefa5.Text = "1";
                        break;
                    case 2:
                        txtDiasTarefa5.Text = "1";
                        break;
                    case 3:
                        txtDiasTarefa5.Text = "2";
                        break;
                    case 4:
                        txtDiasTarefa5.Text = "2";
                        break;
                    case 5:
                        txtDiasTarefa5.Text = "3";
                        break;
                    case 6:
                        txtDiasTarefa5.Text = "4";
                        break;
                    case 7:
                        txtDiasTarefa5.Text = "4";
                        break;
                    case 8:
                        txtDiasTarefa5.Text = "5";
                        break;
                    case 9:
                        txtDiasTarefa5.Text = "6";
                        break;
                    case 10:
                        txtDiasTarefa5.Text = "6";
                        break;
                    default:
                        MessageBox.Show("Valor acima do limite máximo permitido (10 dias)");
                        break;
                }

                int qDiasT6 = Convert.ToInt16(txtDiasTarefa6.Text);
                switch (qDiasT6)
                {
                    case 1:
                        txtDiasTarefa6.Text = "1";
                        break;
                    case 2:
                        txtDiasTarefa6.Text = "1";
                        break;
                    case 3:
                        txtDiasTarefa6.Text = "2";
                        break;
                    case 4:
                        txtDiasTarefa6.Text = "2";
                        break;
                    case 5:
                        txtDiasTarefa6.Text = "3";
                        break;
                    case 6:
                        txtDiasTarefa6.Text = "4";
                        break;
                    case 7:
                        txtDiasTarefa6.Text = "4";
                        break;
                    case 8:
                        txtDiasTarefa6.Text = "5";
                        break;
                    case 9:
                        txtDiasTarefa6.Text = "6";
                        break;
                    case 10:
                        txtDiasTarefa6.Text = "6";
                        break;
                    default:
                        MessageBox.Show("Valor acima do limite máximo permitido (10 dias)");
                        break;
                }
            }
        }
    }

