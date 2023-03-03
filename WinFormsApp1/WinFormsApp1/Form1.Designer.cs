namespace Kalkulator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.l1 = new System.Windows.Forms.Button();
            this.l3 = new System.Windows.Forms.Button();
            this.l2 = new System.Windows.Forms.Button();
            this.l4 = new System.Windows.Forms.Button();
            this.l5 = new System.Windows.Forms.Button();
            this.l6 = new System.Windows.Forms.Button();
            this.l7 = new System.Windows.Forms.Button();
            this.l8 = new System.Windows.Forms.Button();
            this.l9 = new System.Windows.Forms.Button();
            this.l0 = new System.Windows.Forms.Button();
            this.BtnMul = new System.Windows.Forms.Button();
            this.BtnDiv = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnMin = new System.Windows.Forms.Button();
            this.BtnEqual = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            
            this.SuspendLayout();
            // 
            // textBox_Result
            // 
            this.textBox_Result.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Result.Location = new System.Drawing.Point(31, 47);
            this.textBox_Result.Multiline = true;
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.ReadOnly = true;
            this.textBox_Result.Size = new System.Drawing.Size(349, 57);
            this.textBox_Result.TabIndex = 0;
            this.textBox_Result.Text = "0";
            this.textBox_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_Result.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // l1
            // 
            this.l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l1.Location = new System.Drawing.Point(31, 128);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(65, 50);
            this.l1.TabIndex = 1;
            this.l1.Text = "1";
            this.l1.UseVisualStyleBackColor = true;
            this.l1.Click += new System.EventHandler(this.l1_Click);
            // 
            // l3
            // 
            this.l3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l3.Location = new System.Drawing.Point(173, 128);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(65, 50);
            this.l3.TabIndex = 2;
            this.l3.Text = "3";
            this.l3.UseVisualStyleBackColor = true;
            this.l3.Click += new System.EventHandler(this.l3_Click);
            // 
            // l2
            // 
            this.l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l2.Location = new System.Drawing.Point(102, 128);
            this.l2.Name = "l2";
            this.l2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.l2.Size = new System.Drawing.Size(65, 50);
            this.l2.TabIndex = 3;
            this.l2.Text = "2";
            this.l2.UseVisualStyleBackColor = true;
            this.l2.Click += new System.EventHandler(this.l2_Click);
            // 
            // l4
            // 
            this.l4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l4.Location = new System.Drawing.Point(31, 184);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(65, 50);
            this.l4.TabIndex = 4;
            this.l4.Text = "4";
            this.l4.UseVisualStyleBackColor = true;
            this.l4.Click += new System.EventHandler(this.l4_Click);
            // 
            // l5
            // 
            this.l5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l5.Location = new System.Drawing.Point(102, 184);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(65, 50);
            this.l5.TabIndex = 5;
            this.l5.Text = "5";
            this.l5.UseVisualStyleBackColor = true;
            this.l5.Click += new System.EventHandler(this.l5_Click);
            // 
            // l6
            // 
            this.l6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l6.Location = new System.Drawing.Point(173, 184);
            this.l6.Name = "l6";
            this.l6.Size = new System.Drawing.Size(65, 50);
            this.l6.TabIndex = 6;
            this.l6.Text = "6";
            this.l6.UseVisualStyleBackColor = true;
            this.l6.Click += new System.EventHandler(this.l6_Click);
            // 
            // l7
            // 
            this.l7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l7.Location = new System.Drawing.Point(31, 240);
            this.l7.Name = "l7";
            this.l7.Size = new System.Drawing.Size(65, 50);
            this.l7.TabIndex = 7;
            this.l7.Text = "7";
            this.l7.UseVisualStyleBackColor = true;
            this.l7.Click += new System.EventHandler(this.l7_Click);
            // 
            // l8
            // 
            this.l8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l8.Location = new System.Drawing.Point(102, 240);
            this.l8.Name = "l8";
            this.l8.Size = new System.Drawing.Size(65, 50);
            this.l8.TabIndex = 8;
            this.l8.Text = "8";
            this.l8.UseVisualStyleBackColor = true;
            this.l8.Click += new System.EventHandler(this.l8_Click);
            // 
            // l9
            // 
            this.l9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l9.Location = new System.Drawing.Point(173, 240);
            this.l9.Name = "l9";
            this.l9.Size = new System.Drawing.Size(65, 50);
            this.l9.TabIndex = 9;
            this.l9.Text = "9";
            this.l9.UseVisualStyleBackColor = true;
            this.l9.Click += new System.EventHandler(this.l9_Click);
            // 
            // l0
            // 
            this.l0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l0.Location = new System.Drawing.Point(31, 296);
            this.l0.Name = "l0";
            this.l0.Size = new System.Drawing.Size(207, 50);
            this.l0.TabIndex = 10;
            this.l0.Text = "0";
            this.l0.UseVisualStyleBackColor = true;
            this.l0.Click += new System.EventHandler(this.l0_Click);
            // 
            // BtnMul
            // 
            this.BtnMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnMul.Location = new System.Drawing.Point(244, 184);
            this.BtnMul.Name = "BtnMul";
            this.BtnMul.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnMul.Size = new System.Drawing.Size(65, 50);
            this.BtnMul.TabIndex = 11;
            this.BtnMul.Text = "×";
            this.BtnMul.UseVisualStyleBackColor = true;
            this.BtnMul.Click += new System.EventHandler(this.BtnMul_Click);
            // 
            // BtnDiv
            // 
            this.BtnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnDiv.Location = new System.Drawing.Point(244, 128);
            this.BtnDiv.Name = "BtnDiv";
            this.BtnDiv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnDiv.Size = new System.Drawing.Size(65, 50);
            this.BtnDiv.TabIndex = 12;
            this.BtnDiv.Text = "/";
            this.BtnDiv.UseVisualStyleBackColor = true;
            this.BtnDiv.Click += new System.EventHandler(this.BtnDiv_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnAdd.Location = new System.Drawing.Point(315, 128);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnAdd.Size = new System.Drawing.Size(65, 50);
            this.BtnAdd.TabIndex = 13;
            this.BtnAdd.Text = "+";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnMin
            // 
            this.BtnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnMin.Location = new System.Drawing.Point(244, 240);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnMin.Size = new System.Drawing.Size(65, 50);
            this.BtnMin.TabIndex = 14;
            this.BtnMin.Text = "-";
            this.BtnMin.UseVisualStyleBackColor = true;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // BtnEqual
            // 
            this.BtnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnEqual.Location = new System.Drawing.Point(315, 240);
            this.BtnEqual.Name = "BtnEqual";
            this.BtnEqual.Size = new System.Drawing.Size(65, 106);
            this.BtnEqual.TabIndex = 15;
            this.BtnEqual.Text = "=";
            this.BtnEqual.UseVisualStyleBackColor = true;
            this.BtnEqual.Click += new System.EventHandler(this.BtnEqual_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnClear.Location = new System.Drawing.Point(315, 184);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(65, 50);
            this.BtnClear.TabIndex = 16;
            this.BtnClear.Text = "C";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 398);
            
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnEqual);
            this.Controls.Add(this.BtnMin);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnDiv);
            this.Controls.Add(this.BtnMul);
            this.Controls.Add(this.l0);
            this.Controls.Add(this.l9);
            this.Controls.Add(this.l8);
            this.Controls.Add(this.l7);
            this.Controls.Add(this.l6);
            this.Controls.Add(this.l5);
            this.Controls.Add(this.l4);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.textBox_Result);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Button l1;
        private System.Windows.Forms.Button l3;
        private System.Windows.Forms.Button l2;
        private System.Windows.Forms.Button l4;
        private System.Windows.Forms.Button l5;
        private System.Windows.Forms.Button l6;
        private System.Windows.Forms.Button l7;
        private System.Windows.Forms.Button l8;
        private System.Windows.Forms.Button l9;
        private System.Windows.Forms.Button l0;
        private System.Windows.Forms.Button BtnMul;
        private System.Windows.Forms.Button BtnDiv;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnMin;
        private System.Windows.Forms.Button BtnEqual;
        private System.Windows.Forms.Button BtnClear;
    }
}

