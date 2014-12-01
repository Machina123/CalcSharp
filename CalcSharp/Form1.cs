using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalcSharp
{
    public partial class Form1 : Form
    {

        public enum Actions
        {
            ADD = 1,
            SUB = 2,
            MULT = 3,
            DIV = 4,
            S_INV = 5,
            N_INV = 6,
            PRCT = 7,
            SQRT = 8,
            EQU = 9
        }

        public double sum = 0.0d;
        public double arg = 0.0d;
        public Actions action;
        public bool isAction = false;


        public void ClearScreen()
        {
            TxtInput.Text = "0";
            isAction = false;
        }

        public void ClearLastArgument()
        {
            arg = 0.0d;
            ClearScreen();
        }

        public void DoBackspace()
        {
            string OldString;
            string NewString;

            OldString = TxtInput.Text;
            NewString = OldString.Substring(0, OldString.Length - 1);

            TxtInput.Text = NewString;
        }

        public void AddDigit(string Digit)
        {
            if (Digit == "." && TxtInput.Text.Contains(Digit))
            {
                return;
            }


            if (!isAction)
            {
                if (TxtInput.Text == "0" && Digit != ".")
                {
                    TxtInput.Text = Digit;
                }
                else
                {
                    TxtInput.AppendText(Digit);
                }
            }
            else
            {
                ClearScreen();
                AddDigit(Digit);
            }
        }

        public void DoAction(Actions a)
        {

            try
            {
                arg = double.Parse(TxtInput.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }


            switch (a)
            {
                case Actions.ADD:
                    sum += arg;
                    break;

                case Actions.SUB:
                    sum -= arg;
                    break;

                case Actions.MULT:
                    sum *= arg;
                    break;

                case Actions.DIV:
                    sum /= arg;
                    break;

                case Actions.S_INV:
                    arg *= -1;
                    break;

                case Actions.N_INV:
                    arg = 1 / arg;
                    break;

                case Actions.PRCT:
                    arg = sum * (arg / 100);
                    break;

                case Actions.SQRT:
                    arg = Math.Sqrt(arg);

                    break;

                case Actions.EQU:
                    if (sum == 0.0d && arg != 0.0d)
                    {
                        TxtInput.Text = Convert.ToString(arg);
                    }
                    else
                    {
                        TxtInput.Text = Convert.ToString(sum);
                    }
                    break;

                default:
                    System.Windows.Forms.MessageBox.Show("Błędnie działanie!");
                    break;
            }
            isAction = true;
        }

        public Form1()
        {
            InitializeComponent();
            BtnEquals.Focus();
        }

        private void BtnD0_Click(object sender, EventArgs e)
        {
            AddDigit("0");
        }

        private void BtnD1_Click(object sender, EventArgs e)
        {
            AddDigit("1");
        }

        private void BtnD2_Click(object sender, EventArgs e)
        {
            AddDigit("2");
        }

        private void BtnComma_Click(object sender, EventArgs e)
        {
            AddDigit(".");
        }

        private void BtnD3_Click(object sender, EventArgs e)
        {
            AddDigit("3");
        }

        private void BtnD4_Click(object sender, EventArgs e)
        {
            AddDigit("4");
        }

        private void BtnD5_Click(object sender, EventArgs e)
        {
            AddDigit("5");
        }

        private void BtnD6_Click(object sender, EventArgs e)
        {
            AddDigit("6");
        }

        private void BtnD7_Click(object sender, EventArgs e)
        {
            AddDigit("7");
        }

        private void BtnD8_Click(object sender, EventArgs e)
        {
            AddDigit("8");
        }

        private void BtnD9_Click(object sender, EventArgs e)
        {
            AddDigit("9");
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            DoAction(Actions.ADD);
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            DoAction(Actions.SUB);
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            DoAction(Actions.MULT);
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            DoAction(Actions.DIV);
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            DoAction(Actions.EQU);
        }

        private void BtnInvertNumber_Click(object sender, EventArgs e)
        {
            DoAction(Actions.N_INV);
        }

        private void BtnPercent_Click(object sender, EventArgs e)
        {
            DoAction(Actions.PRCT);
        }

        private void BtnInvertSign_Click(object sender, EventArgs e)
        {
            DoAction(Actions.S_INV);
        }

        private void BtnSqrt_Click(object sender, EventArgs e)
        {
            DoAction(Actions.SQRT);
        }

        private void BtnBksp_Click(object sender, EventArgs e)
        {
            DoBackspace();
        }



    }
}
