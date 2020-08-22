namespace GenerateTemp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tempIst = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tempAnk = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tempKay = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tempIzm = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tempAnt = new System.Windows.Forms.Label();
            this.btnGetValue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şehirler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sıcaklık";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "İstanbul";
            // 
            // tempIst
            // 
            this.tempIst.AutoSize = true;
            this.tempIst.Location = new System.Drawing.Point(165, 117);
            this.tempIst.Name = "tempIst";
            this.tempIst.Size = new System.Drawing.Size(16, 13);
            this.tempIst.TabIndex = 3;
            this.tempIst.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ankara";
            // 
            // tempAnk
            // 
            this.tempAnk.AutoSize = true;
            this.tempAnk.Location = new System.Drawing.Point(292, 117);
            this.tempAnk.Name = "tempAnk";
            this.tempAnk.Size = new System.Drawing.Size(16, 13);
            this.tempAnk.TabIndex = 5;
            this.tempAnk.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(441, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kayseri";
            // 
            // tempKay
            // 
            this.tempKay.AutoSize = true;
            this.tempKay.Location = new System.Drawing.Point(441, 117);
            this.tempKay.Name = "tempKay";
            this.tempKay.Size = new System.Drawing.Size(16, 13);
            this.tempKay.TabIndex = 7;
            this.tempKay.Text = "...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(589, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "İzmir";
            // 
            // tempIzm
            // 
            this.tempIzm.AutoSize = true;
            this.tempIzm.Location = new System.Drawing.Point(583, 117);
            this.tempIzm.Name = "tempIzm";
            this.tempIzm.Size = new System.Drawing.Size(16, 13);
            this.tempIzm.TabIndex = 9;
            this.tempIzm.Text = "...";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(746, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Antalya";
            // 
            // tempAnt
            // 
            this.tempAnt.AutoSize = true;
            this.tempAnt.Location = new System.Drawing.Point(746, 117);
            this.tempAnt.Name = "tempAnt";
            this.tempAnt.Size = new System.Drawing.Size(16, 13);
            this.tempAnt.TabIndex = 11;
            this.tempAnt.Text = "...";
            // 
            // btnGetValue
            // 
            this.btnGetValue.Location = new System.Drawing.Point(41, 182);
            this.btnGetValue.Name = "btnGetValue";
            this.btnGetValue.Size = new System.Drawing.Size(131, 23);
            this.btnGetValue.TabIndex = 12;
            this.btnGetValue.Text = "Değerleri Gelir";
            this.btnGetValue.UseVisualStyleBackColor = true;
            this.btnGetValue.Click += new System.EventHandler(this.btnGetValue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 247);
            this.Controls.Add(this.btnGetValue);
            this.Controls.Add(this.tempAnt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tempIzm);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tempKay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tempAnk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tempIst);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tempIst;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tempAnk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label tempKay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label tempIzm;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label tempAnt;
        private System.Windows.Forms.Button btnGetValue;
    }
}

