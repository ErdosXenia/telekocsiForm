namespace telekocsiForm
{
    partial class frmFo
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
            this.btnBeolvasas = new System.Windows.Forms.Button();
            this.lbKimenet = new System.Windows.Forms.ListBox();
            this.btnSecond = new System.Windows.Forms.Button();
            this.btnThird = new System.Windows.Forms.Button();
            this.btnFourth = new System.Windows.Forms.Button();
            this.btnFifth = new System.Windows.Forms.Button();
            this.btnSixth = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBeolvasas
            // 
            this.btnBeolvasas.Location = new System.Drawing.Point(14, 10);
            this.btnBeolvasas.Name = "btnBeolvasas";
            this.btnBeolvasas.Size = new System.Drawing.Size(125, 35);
            this.btnBeolvasas.TabIndex = 0;
            this.btnBeolvasas.Text = "beolvasás";
            this.btnBeolvasas.UseVisualStyleBackColor = true;
            this.btnBeolvasas.Click += new System.EventHandler(this.btnBeolvasas_Click);
            // 
            // lbKimenet
            // 
            this.lbKimenet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbKimenet.FormattingEnabled = true;
            this.lbKimenet.Location = new System.Drawing.Point(181, 62);
            this.lbKimenet.Name = "lbKimenet";
            this.lbKimenet.Size = new System.Drawing.Size(380, 238);
            this.lbKimenet.TabIndex = 1;
            // 
            // btnSecond
            // 
            this.btnSecond.Enabled = false;
            this.btnSecond.Location = new System.Drawing.Point(14, 51);
            this.btnSecond.Name = "btnSecond";
            this.btnSecond.Size = new System.Drawing.Size(125, 35);
            this.btnSecond.TabIndex = 2;
            this.btnSecond.Text = "2. feladat";
            this.btnSecond.UseVisualStyleBackColor = true;
            this.btnSecond.Click += new System.EventHandler(this.btnSecond_Click);
            // 
            // btnThird
            // 
            this.btnThird.Enabled = false;
            this.btnThird.Location = new System.Drawing.Point(14, 92);
            this.btnThird.Name = "btnThird";
            this.btnThird.Size = new System.Drawing.Size(125, 35);
            this.btnThird.TabIndex = 3;
            this.btnThird.Text = "3. feladat";
            this.btnThird.UseVisualStyleBackColor = true;
            this.btnThird.Click += new System.EventHandler(this.btnThird_Click);
            // 
            // btnFourth
            // 
            this.btnFourth.Enabled = false;
            this.btnFourth.Location = new System.Drawing.Point(14, 133);
            this.btnFourth.Name = "btnFourth";
            this.btnFourth.Size = new System.Drawing.Size(125, 35);
            this.btnFourth.TabIndex = 4;
            this.btnFourth.Text = "4. feladat";
            this.btnFourth.UseVisualStyleBackColor = true;
            this.btnFourth.Click += new System.EventHandler(this.btnFourth_Click);
            // 
            // btnFifth
            // 
            this.btnFifth.Enabled = false;
            this.btnFifth.Location = new System.Drawing.Point(14, 174);
            this.btnFifth.Name = "btnFifth";
            this.btnFifth.Size = new System.Drawing.Size(125, 35);
            this.btnFifth.TabIndex = 5;
            this.btnFifth.Text = "5. feladat";
            this.btnFifth.UseVisualStyleBackColor = true;
            this.btnFifth.Click += new System.EventHandler(this.btnFifth_Click);
            // 
            // btnSixth
            // 
            this.btnSixth.Enabled = false;
            this.btnSixth.Location = new System.Drawing.Point(14, 215);
            this.btnSixth.Name = "btnSixth";
            this.btnSixth.Size = new System.Drawing.Size(125, 35);
            this.btnSixth.TabIndex = 6;
            this.btnSixth.Text = "6. feladat";
            this.btnSixth.UseVisualStyleBackColor = true;
            this.btnSixth.Click += new System.EventHandler(this.btnSixth_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 314);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 35);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Kilépés";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Feladatok kimenete:";
            // 
            // frmFo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSixth);
            this.Controls.Add(this.btnFifth);
            this.Controls.Add(this.btnFourth);
            this.Controls.Add(this.btnThird);
            this.Controls.Add(this.btnSecond);
            this.Controls.Add(this.lbKimenet);
            this.Controls.Add(this.btnBeolvasas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmFo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telekocsi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBeolvasas;
        private System.Windows.Forms.ListBox lbKimenet;
        private System.Windows.Forms.Button btnSecond;
        private System.Windows.Forms.Button btnThird;
        private System.Windows.Forms.Button btnFourth;
        private System.Windows.Forms.Button btnFifth;
        private System.Windows.Forms.Button btnSixth;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}

