using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using Mathos.Parser;
using System.Windows.Forms;

namespace PocketCalculator
{
    public partial class Form1 : Form
    {
        public string Display { get; set; }
        public bool Error { get; set; }
        public MathParser Parser { get; set; }

    public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            ResultDisplay.Text = "";
            this.Error = false;
            this.Parser = new MathParser();

        }

     
        private void handleUserInput(string source)
        {
            Console.WriteLine(source);
            char input = source.ToCharArray()[0];
            StringBuilder result = new StringBuilder(ResultDisplay.Text);

            switch (input)
            {
                case '0':
                    {
                        if (ResultDisplay.Text != "0") ResultDisplay.Text += input;
                        break;
                    }
                case '.':
                    {
                        if (result.Length > 0 && result[result.Length - 1] == '.')
                        {
                            break;
                        }
                        else ResultDisplay.Text += input;
                        break;
                    }
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    {
                        if (result.ToString() == "0") ResultDisplay.Text = input.ToString();
                        else  ResultDisplay.Text += input;
                        break;
                    }

                case '*':
                case '/':
                case '+':
                case '-':
                    {

                        if (result.Length > 0 && (result[result.Length - 1].ToString()).IndexOfAny(new char[] { '+', '-', '/', '*' }) != -1)
                        {
                            result[result.Length - 1] = input;
                        }
                        else if (result.Length != 0) result.Append(input);
                        ResultDisplay.Text = result.ToString();

                        break;
                    }
                case '=':
                    {
                        if (!this.Error)
                        {
                            try
                            {
                                double computation = Parser.Parse(ResultDisplay.Text);
                                if (Double.IsNaN(computation)) ResultDisplay.Text = "0";
                                else ResultDisplay.Text = computation.ToString();

                            }
                            catch (Exception exception)
                            {
                                Console.WriteLine(exception.Message);
                            }
                        }
                        break;
                    }
                default: { break; }
            }

            try
            {
                double computation = Parser.Parse(ResultDisplay.Text);
                if (Double.IsNaN(computation)) throw new Exception("NaN");
                Status.Text = "status: ok";
                Status.ForeColor = System.Drawing.Color.AliceBlue;

            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
                Status.Text = "status: incomplete";
                Status.ForeColor = System.Drawing.Color.Orange;
            }

          
        }

        private void handleUserReturn()
        {
            StringBuilder result = new StringBuilder(ResultDisplay.Text);
            if (result.Length > 0) result.Remove(result.Length - 1, 1);
            ResultDisplay.Text = result.ToString();
        }

        private void handleUserClear()
        {
            ResultDisplay.Text = "";
            Status.Text = "status: ok";
            Status.ForeColor = System.Drawing.Color.AliceBlue;
            this.Error = false;

        }
        
        private void digit_Click(object sender, EventArgs e)
        {

            handleUserInput(((Button) sender).Text);
                
        }

        private void clear_Click(object sender, EventArgs e)
        {
            handleUserClear();

        }
        private void operation_Click(object sender, EventArgs e)
        {
            
            handleUserInput(((Button)sender).Text);

        }


        private void label_Click(object sender, EventArgs e)
        {

        }

        private void return_Click(object sender, EventArgs e)
        {
            handleUserReturn();

        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.D1:
                    {
                        handleUserInput("1");
                        break;
                    }
                case Keys.D2:
                    {
                        handleUserInput("2");
                        break;
                    }
                case Keys.D3:
                    {
                        handleUserInput("3");
                        break;
                    }
                case Keys.D4:
                    {
                        handleUserInput("4");
                        break;
                    }
                case Keys.D5:
                    {
                        handleUserInput("5");
                        break;
                    }
                case Keys.D6:
                    {
                        handleUserInput("6");
                        break;
                    }
                case Keys.D7:
                    {
                        handleUserInput("7");
                        break;
                    }
                case Keys.D8:
                    {
                        handleUserInput("8");
                        break;
                    }
                case Keys.D9:
                    {
                        handleUserInput("9");
                        break;
                    }
                case Keys.D0:
                    {
                        handleUserInput("0");
                        break;
                    }
                case Keys.Add:
                    {
                        handleUserInput("+");
                        break;
                    }
                case Keys.Subtract:
                    {
                        handleUserInput("-");
                        break;
                    }
                case Keys.Divide:
                    {
                        handleUserInput("/");
                        break;
                    }
                case Keys.Multiply:
                    {
                        handleUserInput("*");
                        break;
                    }
                case Keys.Back:
                    {
                        {
                            handleUserReturn();
                            break;
                        }
                    }

                case Keys.Enter:
                    {
                        {
                            handleUserInput("=");
                            break;
                        }
                    }

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
