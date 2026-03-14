using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcu
{
    public partial class Form1 : Form
    {
        private double _firstNumber = 0;
        private string _operation= "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;

        }

        private void Operation_Click(object sender, EventArgs e)
        {

            if (_operation != "")
                return;
            Button btn = (Button)sender;
            if (double.TryParse(textBox1.Text, out  _firstNumber))
            {
                
            _operation= btn.Text;
                textBox1.Text = "";
            }

        }

        private void Equal_Click(object sender, EventArgs e)
        {
            double secondNumber = 0;
            if (!double.TryParse(textBox1.Text, out secondNumber))
            {
                MessageBox.Show("Enter a valid number");
                textBox1.Text = "";
                return;
            }
            double result = 0;
               
                    switch (_operation) {

                        case "+":
                            {
                                result = _firstNumber + secondNumber;
                                break;
                            }
                        case "-":
                            {
                                result = _firstNumber - secondNumber;
                                break;

                            }
                        case "/":
                            {
                                if (secondNumber == 0)
                                {
                                    MessageBox.Show("Can Not divide  by 0");
                                    return;
                                }
                                result = _firstNumber / secondNumber;
                                break;
                            }
                        case "*":
                            {
                                
                                result = _firstNumber * secondNumber;
                                break;
                            }
                    default:
                        MessageBox.Show("Invalid operation");
                        return;


                }


                    textBox1.Text = result.ToString();
                    _operation = "";

                    return;
                }
            
        

        private void Delete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }       }

      

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            _firstNumber = 0;
            _operation = "";
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox1.ReadOnly = true;
            textBox1.Cursor = Cursors.Arrow;
            textBox1.BackColor= Color.White;
        }

        private void lock_Calculator(object sender, EventArgs e)
        {
            foreach (var control in this.Controls)
            {
                if (control is Button btn && btn.Name != "Btn_Unlock")
                {
                    btn.Enabled = !btn.Enabled;
                }
            }

        }
    }
}
