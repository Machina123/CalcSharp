namespace CalcSharp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtInput = new System.Windows.Forms.TextBox();
            this.BtnMC = new System.Windows.Forms.Button();
            this.BtnBksp = new System.Windows.Forms.Button();
            this.BtnCE = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.BtnInvertSign = new System.Windows.Forms.Button();
            this.BtnSqrt = new System.Windows.Forms.Button();
            this.BtnD7 = new System.Windows.Forms.Button();
            this.BtnD8 = new System.Windows.Forms.Button();
            this.BtnD9 = new System.Windows.Forms.Button();
            this.BtnD2 = new System.Windows.Forms.Button();
            this.BtnD1 = new System.Windows.Forms.Button();
            this.BtnD3 = new System.Windows.Forms.Button();
            this.BtnD0 = new System.Windows.Forms.Button();
            this.BtnComma = new System.Windows.Forms.Button();
            this.BtnDivide = new System.Windows.Forms.Button();
            this.BtnSubtract = new System.Windows.Forms.Button();
            this.BtnMultiply = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnPercent = new System.Windows.Forms.Button();
            this.BtnInvertNumber = new System.Windows.Forms.Button();
            this.BtnEquals = new System.Windows.Forms.Button();
            this.BtnMR = new System.Windows.Forms.Button();
            this.BtnMS = new System.Windows.Forms.Button();
            this.BtnMP = new System.Windows.Forms.Button();
            this.BtnMM = new System.Windows.Forms.Button();
            this.BtnD4 = new System.Windows.Forms.Button();
            this.BtnD5 = new System.Windows.Forms.Button();
            this.BtnD6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtInput
            // 
            this.TxtInput.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtInput.Location = new System.Drawing.Point(13, 13);
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.ReadOnly = true;
            this.TxtInput.Size = new System.Drawing.Size(263, 26);
            this.TxtInput.TabIndex = 0;
            this.TxtInput.Text = "0";
            this.TxtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnMC
            // 
            this.BtnMC.Location = new System.Drawing.Point(13, 46);
            this.BtnMC.Name = "BtnMC";
            this.BtnMC.Size = new System.Drawing.Size(48, 23);
            this.BtnMC.TabIndex = 1;
            this.BtnMC.Text = "MC";
            this.BtnMC.UseVisualStyleBackColor = true;
            // 
            // BtnBksp
            // 
            this.BtnBksp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnBksp.Location = new System.Drawing.Point(13, 75);
            this.BtnBksp.Name = "BtnBksp";
            this.BtnBksp.Size = new System.Drawing.Size(48, 36);
            this.BtnBksp.TabIndex = 2;
            this.BtnBksp.Text = "<-";
            this.BtnBksp.UseVisualStyleBackColor = true;
            this.BtnBksp.Click += new System.EventHandler(this.BtnBksp_Click);
            // 
            // BtnCE
            // 
            this.BtnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnCE.Location = new System.Drawing.Point(67, 75);
            this.BtnCE.Name = "BtnCE";
            this.BtnCE.Size = new System.Drawing.Size(48, 36);
            this.BtnCE.TabIndex = 3;
            this.BtnCE.Text = "CE";
            this.BtnCE.UseVisualStyleBackColor = true;
            // 
            // BtnC
            // 
            this.BtnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnC.Location = new System.Drawing.Point(121, 75);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(48, 36);
            this.BtnC.TabIndex = 4;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = true;
            // 
            // BtnInvertSign
            // 
            this.BtnInvertSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnInvertSign.Location = new System.Drawing.Point(174, 75);
            this.BtnInvertSign.Name = "BtnInvertSign";
            this.BtnInvertSign.Size = new System.Drawing.Size(48, 36);
            this.BtnInvertSign.TabIndex = 5;
            this.BtnInvertSign.Text = "±";
            this.BtnInvertSign.UseVisualStyleBackColor = true;
            this.BtnInvertSign.Click += new System.EventHandler(this.BtnInvertSign_Click);
            // 
            // BtnSqrt
            // 
            this.BtnSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnSqrt.Location = new System.Drawing.Point(228, 75);
            this.BtnSqrt.Name = "BtnSqrt";
            this.BtnSqrt.Size = new System.Drawing.Size(48, 36);
            this.BtnSqrt.TabIndex = 6;
            this.BtnSqrt.Text = "√";
            this.BtnSqrt.UseVisualStyleBackColor = true;
            this.BtnSqrt.Click += new System.EventHandler(this.BtnSqrt_Click);
            // 
            // BtnD7
            // 
            this.BtnD7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnD7.Location = new System.Drawing.Point(13, 117);
            this.BtnD7.Name = "BtnD7";
            this.BtnD7.Size = new System.Drawing.Size(48, 36);
            this.BtnD7.TabIndex = 7;
            this.BtnD7.Text = "7";
            this.BtnD7.UseVisualStyleBackColor = true;
            this.BtnD7.Click += new System.EventHandler(this.BtnD7_Click);
            // 
            // BtnD8
            // 
            this.BtnD8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnD8.Location = new System.Drawing.Point(67, 117);
            this.BtnD8.Name = "BtnD8";
            this.BtnD8.Size = new System.Drawing.Size(48, 36);
            this.BtnD8.TabIndex = 8;
            this.BtnD8.Text = "8";
            this.BtnD8.UseVisualStyleBackColor = true;
            this.BtnD8.Click += new System.EventHandler(this.BtnD8_Click);
            // 
            // BtnD9
            // 
            this.BtnD9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnD9.Location = new System.Drawing.Point(121, 117);
            this.BtnD9.Name = "BtnD9";
            this.BtnD9.Size = new System.Drawing.Size(48, 36);
            this.BtnD9.TabIndex = 9;
            this.BtnD9.Text = "9";
            this.BtnD9.UseVisualStyleBackColor = true;
            this.BtnD9.Click += new System.EventHandler(this.BtnD9_Click);
            // 
            // BtnD2
            // 
            this.BtnD2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnD2.Location = new System.Drawing.Point(67, 201);
            this.BtnD2.Name = "BtnD2";
            this.BtnD2.Size = new System.Drawing.Size(48, 36);
            this.BtnD2.TabIndex = 10;
            this.BtnD2.Text = "2";
            this.BtnD2.UseVisualStyleBackColor = true;
            this.BtnD2.Click += new System.EventHandler(this.BtnD2_Click);
            // 
            // BtnD1
            // 
            this.BtnD1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnD1.Location = new System.Drawing.Point(13, 201);
            this.BtnD1.Name = "BtnD1";
            this.BtnD1.Size = new System.Drawing.Size(48, 36);
            this.BtnD1.TabIndex = 11;
            this.BtnD1.Text = "1";
            this.BtnD1.UseVisualStyleBackColor = true;
            this.BtnD1.Click += new System.EventHandler(this.BtnD1_Click);
            // 
            // BtnD3
            // 
            this.BtnD3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnD3.Location = new System.Drawing.Point(121, 201);
            this.BtnD3.Name = "BtnD3";
            this.BtnD3.Size = new System.Drawing.Size(48, 36);
            this.BtnD3.TabIndex = 12;
            this.BtnD3.Text = "3";
            this.BtnD3.UseVisualStyleBackColor = true;
            this.BtnD3.Click += new System.EventHandler(this.BtnD3_Click);
            // 
            // BtnD0
            // 
            this.BtnD0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnD0.Location = new System.Drawing.Point(13, 243);
            this.BtnD0.Name = "BtnD0";
            this.BtnD0.Size = new System.Drawing.Size(102, 36);
            this.BtnD0.TabIndex = 13;
            this.BtnD0.Text = "0";
            this.BtnD0.UseVisualStyleBackColor = true;
            this.BtnD0.Click += new System.EventHandler(this.BtnD0_Click);
            // 
            // BtnComma
            // 
            this.BtnComma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnComma.Location = new System.Drawing.Point(121, 243);
            this.BtnComma.Name = "BtnComma";
            this.BtnComma.Size = new System.Drawing.Size(48, 36);
            this.BtnComma.TabIndex = 14;
            this.BtnComma.Text = ",";
            this.BtnComma.UseVisualStyleBackColor = true;
            this.BtnComma.Click += new System.EventHandler(this.BtnComma_Click);
            // 
            // BtnDivide
            // 
            this.BtnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnDivide.Location = new System.Drawing.Point(174, 117);
            this.BtnDivide.Name = "BtnDivide";
            this.BtnDivide.Size = new System.Drawing.Size(48, 36);
            this.BtnDivide.TabIndex = 15;
            this.BtnDivide.Text = "/";
            this.BtnDivide.UseVisualStyleBackColor = true;
            this.BtnDivide.Click += new System.EventHandler(this.BtnDivide_Click);
            // 
            // BtnSubtract
            // 
            this.BtnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnSubtract.Location = new System.Drawing.Point(175, 201);
            this.BtnSubtract.Name = "BtnSubtract";
            this.BtnSubtract.Size = new System.Drawing.Size(48, 36);
            this.BtnSubtract.TabIndex = 16;
            this.BtnSubtract.Text = "-";
            this.BtnSubtract.UseVisualStyleBackColor = true;
            this.BtnSubtract.Click += new System.EventHandler(this.BtnSubtract_Click);
            // 
            // BtnMultiply
            // 
            this.BtnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnMultiply.Location = new System.Drawing.Point(174, 159);
            this.BtnMultiply.Name = "BtnMultiply";
            this.BtnMultiply.Size = new System.Drawing.Size(48, 36);
            this.BtnMultiply.TabIndex = 17;
            this.BtnMultiply.Text = "*";
            this.BtnMultiply.UseVisualStyleBackColor = true;
            this.BtnMultiply.Click += new System.EventHandler(this.BtnMultiply_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnAdd.Location = new System.Drawing.Point(175, 243);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(48, 36);
            this.BtnAdd.TabIndex = 18;
            this.BtnAdd.Text = "+";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnPercent
            // 
            this.BtnPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnPercent.Location = new System.Drawing.Point(228, 117);
            this.BtnPercent.Name = "BtnPercent";
            this.BtnPercent.Size = new System.Drawing.Size(48, 36);
            this.BtnPercent.TabIndex = 19;
            this.BtnPercent.Text = "%";
            this.BtnPercent.UseVisualStyleBackColor = true;
            this.BtnPercent.Click += new System.EventHandler(this.BtnPercent_Click);
            // 
            // BtnInvertNumber
            // 
            this.BtnInvertNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnInvertNumber.Location = new System.Drawing.Point(228, 159);
            this.BtnInvertNumber.Name = "BtnInvertNumber";
            this.BtnInvertNumber.Size = new System.Drawing.Size(48, 36);
            this.BtnInvertNumber.TabIndex = 20;
            this.BtnInvertNumber.Text = "1/x";
            this.BtnInvertNumber.UseVisualStyleBackColor = true;
            this.BtnInvertNumber.Click += new System.EventHandler(this.BtnInvertNumber_Click);
            // 
            // BtnEquals
            // 
            this.BtnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnEquals.Location = new System.Drawing.Point(228, 201);
            this.BtnEquals.Name = "BtnEquals";
            this.BtnEquals.Size = new System.Drawing.Size(48, 78);
            this.BtnEquals.TabIndex = 21;
            this.BtnEquals.Text = "=";
            this.BtnEquals.UseVisualStyleBackColor = true;
            this.BtnEquals.Click += new System.EventHandler(this.BtnEquals_Click);
            // 
            // BtnMR
            // 
            this.BtnMR.Location = new System.Drawing.Point(67, 46);
            this.BtnMR.Name = "BtnMR";
            this.BtnMR.Size = new System.Drawing.Size(48, 23);
            this.BtnMR.TabIndex = 22;
            this.BtnMR.Text = "MR";
            this.BtnMR.UseVisualStyleBackColor = true;
            // 
            // BtnMS
            // 
            this.BtnMS.Location = new System.Drawing.Point(120, 46);
            this.BtnMS.Name = "BtnMS";
            this.BtnMS.Size = new System.Drawing.Size(48, 23);
            this.BtnMS.TabIndex = 23;
            this.BtnMS.Text = "MS";
            this.BtnMS.UseVisualStyleBackColor = true;
            // 
            // BtnMP
            // 
            this.BtnMP.Location = new System.Drawing.Point(174, 46);
            this.BtnMP.Name = "BtnMP";
            this.BtnMP.Size = new System.Drawing.Size(48, 23);
            this.BtnMP.TabIndex = 24;
            this.BtnMP.Text = "M+";
            this.BtnMP.UseVisualStyleBackColor = true;
            // 
            // BtnMM
            // 
            this.BtnMM.Location = new System.Drawing.Point(228, 46);
            this.BtnMM.Name = "BtnMM";
            this.BtnMM.Size = new System.Drawing.Size(48, 23);
            this.BtnMM.TabIndex = 25;
            this.BtnMM.Text = "M-";
            this.BtnMM.UseVisualStyleBackColor = true;
            // 
            // BtnD4
            // 
            this.BtnD4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnD4.Location = new System.Drawing.Point(13, 159);
            this.BtnD4.Name = "BtnD4";
            this.BtnD4.Size = new System.Drawing.Size(48, 36);
            this.BtnD4.TabIndex = 26;
            this.BtnD4.Text = "4";
            this.BtnD4.UseVisualStyleBackColor = true;
            this.BtnD4.Click += new System.EventHandler(this.BtnD4_Click);
            // 
            // BtnD5
            // 
            this.BtnD5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnD5.Location = new System.Drawing.Point(67, 159);
            this.BtnD5.Name = "BtnD5";
            this.BtnD5.Size = new System.Drawing.Size(48, 36);
            this.BtnD5.TabIndex = 27;
            this.BtnD5.Text = "5";
            this.BtnD5.UseVisualStyleBackColor = true;
            this.BtnD5.Click += new System.EventHandler(this.BtnD5_Click);
            // 
            // BtnD6
            // 
            this.BtnD6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnD6.Location = new System.Drawing.Point(121, 159);
            this.BtnD6.Name = "BtnD6";
            this.BtnD6.Size = new System.Drawing.Size(48, 36);
            this.BtnD6.TabIndex = 28;
            this.BtnD6.Text = "6";
            this.BtnD6.UseVisualStyleBackColor = true;
            this.BtnD6.Click += new System.EventHandler(this.BtnD6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "©2014 Machina";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 301);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnD6);
            this.Controls.Add(this.BtnD5);
            this.Controls.Add(this.BtnD4);
            this.Controls.Add(this.BtnMM);
            this.Controls.Add(this.BtnMP);
            this.Controls.Add(this.BtnMS);
            this.Controls.Add(this.BtnMR);
            this.Controls.Add(this.BtnEquals);
            this.Controls.Add(this.BtnInvertNumber);
            this.Controls.Add(this.BtnPercent);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnMultiply);
            this.Controls.Add(this.BtnSubtract);
            this.Controls.Add(this.BtnDivide);
            this.Controls.Add(this.BtnComma);
            this.Controls.Add(this.BtnD0);
            this.Controls.Add(this.BtnD3);
            this.Controls.Add(this.BtnD1);
            this.Controls.Add(this.BtnD2);
            this.Controls.Add(this.BtnD9);
            this.Controls.Add(this.BtnD8);
            this.Controls.Add(this.BtnD7);
            this.Controls.Add(this.BtnSqrt);
            this.Controls.Add(this.BtnInvertSign);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.BtnCE);
            this.Controls.Add(this.BtnBksp);
            this.Controls.Add(this.BtnMC);
            this.Controls.Add(this.TxtInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "CalcSharp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnMC;
        private System.Windows.Forms.Button BtnBksp;
        private System.Windows.Forms.Button BtnCE;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button BtnInvertSign;
        private System.Windows.Forms.Button BtnSqrt;
        private System.Windows.Forms.Button BtnD7;
        private System.Windows.Forms.Button BtnD8;
        private System.Windows.Forms.Button BtnD9;
        private System.Windows.Forms.Button BtnD2;
        private System.Windows.Forms.Button BtnD1;
        private System.Windows.Forms.Button BtnD3;
        private System.Windows.Forms.Button BtnD0;
        private System.Windows.Forms.Button BtnComma;
        private System.Windows.Forms.Button BtnDivide;
        private System.Windows.Forms.Button BtnSubtract;
        private System.Windows.Forms.Button BtnMultiply;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnPercent;
        private System.Windows.Forms.Button BtnInvertNumber;
        private System.Windows.Forms.Button BtnEquals;
        private System.Windows.Forms.Button BtnMR;
        private System.Windows.Forms.Button BtnMS;
        private System.Windows.Forms.Button BtnMP;
        private System.Windows.Forms.Button BtnMM;
        private System.Windows.Forms.Button BtnD4;
        private System.Windows.Forms.Button BtnD5;
        private System.Windows.Forms.Button BtnD6;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TxtInput;
    }
}

