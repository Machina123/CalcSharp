﻿using System;
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
            /// <summary>
            /// Dodawanie
            /// </summary>
            ADD = 1,

            /// <summary>
            /// Odejmowanie
            /// </summary>
            SUB = 2,

            /// <summary>
            /// Mnożenie
            /// </summary>
            MULT = 3,

            /// <summary>
            /// Dzielenie
            /// </summary>
            DIV = 4,

            /// <summary>
            /// Odwracanie znaku
            /// </summary>
            S_INV = 5,

            /// <summary>
            /// Odwracanie liczby
            /// </summary>
            N_INV = 6,

            /// <summary>
            /// Procent
            /// </summary>
            PRCT = 7,

            /// <summary>
            /// Pierwiastek kwadratowy
            /// </summary>
            SQRT = 8,

            /// <summary>
            /// Równość
            /// </summary>
            EQU = 9
        }
        
        public double argPrev = 0.0d;
        public double argPres = 0.0d;
        public int action = 0;
        

        public void AddDigit(string Digit)
        {
            if (Digit == "." && TxtInput.Text.Contains(Digit)) 
            {
                return;
            }


            if (TxtInput.Text == "0" && Digit != ".")
            {
                TxtInput.Text = Digit;
            }
            else
            {
                TxtInput.AppendText(Digit);
            }
        }

        public void DoAction(Actions a)
        {
            switch (a)
            {
                case Actions.ADD:
                    break;

                case Actions.SUB:
                    break;

                case Actions.MULT:
                    break;

                case Actions.DIV:
                    break;

                case Actions.S_INV:
                    break;

                case Actions.N_INV:
                    break;

                case Actions.PRCT:
                    break;

                case Actions.SQRT:
                    break;

                case Actions.EQU:
                    break;

                default: 
                    System.Windows.Forms.MessageBox.Show("Błędnie działanie!");
                    break;
            }
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



    }
}