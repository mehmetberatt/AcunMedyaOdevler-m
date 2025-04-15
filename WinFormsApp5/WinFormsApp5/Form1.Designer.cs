namespace WinFormsApp5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMarka = new Label();
            lblModel = new Label();
            lblRenk = new Label();
            lblKapi = new Label();
            lblPencere = new Label();
            lblYakit = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            btnGoster = new Button();
            SuspendLayout();
            // 
            // lblMarka
            // 
            lblMarka.AutoSize = true;
            lblMarka.Location = new Point(931, 130);
            lblMarka.Name = "lblMarka";
            lblMarka.Size = new Size(65, 25);
            lblMarka.TabIndex = 0;
            lblMarka.Text = "Marka:";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(931, 217);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(67, 25);
            lblModel.TabIndex = 1;
            lblModel.Text = "Model:";
            // 
            // lblRenk
            // 
            lblRenk.AutoSize = true;
            lblRenk.Location = new Point(931, 289);
            lblRenk.Name = "lblRenk";
            lblRenk.Size = new Size(54, 25);
            lblRenk.TabIndex = 2;
            lblRenk.Text = "Renk:";
            // 
            // lblKapi
            // 
            lblKapi.AutoSize = true;
            lblKapi.Location = new Point(931, 357);
            lblKapi.Name = "lblKapi";
            lblKapi.Size = new Size(99, 25);
            lblKapi.TabIndex = 3;
            lblKapi.Text = "Kapi Sayisi:";
            // 
            // lblPencere
            // 
            lblPencere.AutoSize = true;
            lblPencere.Location = new Point(931, 446);
            lblPencere.Name = "lblPencere";
            lblPencere.Size = new Size(125, 25);
            lblPencere.TabIndex = 4;
            lblPencere.Text = "Pencere Sayisi:";
            // 
            // lblYakit
            // 
            lblYakit.AutoSize = true;
            lblYakit.Location = new Point(931, 531);
            lblYakit.Name = "lblYakit";
            lblYakit.Size = new Size(164, 25);
            lblYakit.TabIndex = 5;
            lblYakit.Text = "100 km’de Yakıt (L):";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1109, 531);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(223, 31);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1109, 130);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(223, 31);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1109, 446);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(223, 31);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(1109, 357);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(223, 31);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(1109, 289);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(223, 31);
            textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(1109, 217);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(223, 31);
            textBox6.TabIndex = 11;
            // 
            // btnGoster
            // 
            btnGoster.Location = new Point(931, 620);
            btnGoster.Name = "btnGoster";
            btnGoster.Size = new Size(401, 98);
            btnGoster.TabIndex = 12;
            btnGoster.Text = "Bilgileri Goster";
            btnGoster.UseVisualStyleBackColor = true;
            btnGoster.Click += btnGoster_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2009, 798);
            Controls.Add(btnGoster);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblYakit);
            Controls.Add(lblPencere);
            Controls.Add(lblKapi);
            Controls.Add(lblRenk);
            Controls.Add(lblModel);
            Controls.Add(lblMarka);
            Name = "Form1";
            Text = "Araba Bilgi Formu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMarka;
        private Label lblModel;
        private Label lblRenk;
        private Label lblKapi;
        private Label lblPencere;
        private Label lblYakit;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button btnGoster;
    }
}
