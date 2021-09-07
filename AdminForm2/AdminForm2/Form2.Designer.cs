namespace QLSV1
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btOke = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbfe = new System.Windows.Forms.RadioButton();
            this.rbm = new System.Windows.Forms.RadioButton();
            this.dtNS = new System.Windows.Forms.DateTimePicker();
            this.cbbLopSH2 = new System.Windows.Forms.ComboBox();
            this.txbNameSV = new System.Windows.Forms.TextBox();
            this.txbMSSV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btCancel);
            this.groupBox1.Controls.Add(this.btOke);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dtNS);
            this.groupBox1.Controls.Add(this.cbbLopSH2);
            this.groupBox1.Controls.Add(this.txbNameSV);
            this.groupBox1.Controls.Add(this.txbMSSV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 321);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detail Box";
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(438, 239);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btOke
            // 
            this.btOke.Location = new System.Drawing.Point(156, 239);
            this.btOke.Name = "btOke";
            this.btOke.Size = new System.Drawing.Size(75, 23);
            this.btOke.TabIndex = 5;
            this.btOke.Text = "OK";
            this.btOke.UseVisualStyleBackColor = true;
            this.btOke.Click += new System.EventHandler(this.butOK_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbfe);
            this.groupBox2.Controls.Add(this.rbm);
            this.groupBox2.Location = new System.Drawing.Point(358, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 120);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gender";
            // 
            // rbfe
            // 
            this.rbfe.AutoSize = true;
            this.rbfe.Location = new System.Drawing.Point(135, 47);
            this.rbfe.Name = "rbfe";
            this.rbfe.Size = new System.Drawing.Size(75, 21);
            this.rbfe.TabIndex = 0;
            this.rbfe.TabStop = true;
            this.rbfe.Text = "Female";
            this.rbfe.UseVisualStyleBackColor = true;
            // 
            // rbm
            // 
            this.rbm.AutoSize = true;
            this.rbm.Location = new System.Drawing.Point(19, 47);
            this.rbm.Name = "rbm";
            this.rbm.Size = new System.Drawing.Size(59, 21);
            this.rbm.TabIndex = 0;
            this.rbm.TabStop = true;
            this.rbm.Text = "Male";
            this.rbm.UseVisualStyleBackColor = true;
            // 
            // dtNS
            // 
            this.dtNS.Location = new System.Drawing.Point(358, 44);
            this.dtNS.Name = "dtNS";
            this.dtNS.Size = new System.Drawing.Size(274, 22);
            this.dtNS.TabIndex = 3;
            // 
            // cbbLopSH2
            // 
            this.cbbLopSH2.FormattingEnabled = true;
            this.cbbLopSH2.Location = new System.Drawing.Point(99, 181);
            this.cbbLopSH2.Name = "cbbLopSH2";
            this.cbbLopSH2.Size = new System.Drawing.Size(177, 24);
            this.cbbLopSH2.TabIndex = 3;
            // 
            // txbNameSV
            // 
            this.txbNameSV.Location = new System.Drawing.Point(99, 113);
            this.txbNameSV.Name = "txbNameSV";
            this.txbNameSV.Size = new System.Drawing.Size(177, 22);
            this.txbNameSV.TabIndex = 2;
            // 
            // txbMSSV
            // 
            this.txbMSSV.ForeColor = System.Drawing.Color.Black;
            this.txbMSSV.Location = new System.Drawing.Point(99, 44);
            this.txbMSSV.Name = "txbMSSV";
            this.txbMSSV.Size = new System.Drawing.Size(177, 22);
            this.txbMSSV.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "LopSH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSSV";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 392);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOke;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbfe;
        private System.Windows.Forms.RadioButton rbm;
        private System.Windows.Forms.DateTimePicker dtNS;
        private System.Windows.Forms.ComboBox cbbLopSH2;
        private System.Windows.Forms.TextBox txbNameSV;
        private System.Windows.Forms.TextBox txbMSSV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}