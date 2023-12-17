namespace restorantotomasyonu
{
    partial class kullanıcıgiris
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            cikisbtn = new Button();
            grsbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 202);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 0;
            label1.Text = "KULLANICI ADI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 253);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 0;
            label2.Text = "ŞİFRE";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(241, 246);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(241, 194);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cikisbtn
            // 
            cikisbtn.Location = new Point(298, 353);
            cikisbtn.Name = "cikisbtn";
            cikisbtn.Size = new Size(94, 29);
            cikisbtn.TabIndex = 3;
            cikisbtn.Text = "ÇIKIŞ";
            cikisbtn.UseVisualStyleBackColor = true;
            cikisbtn.Click += button1_Click;
            // 
            // grsbtn
            // 
            grsbtn.Location = new Point(121, 353);
            grsbtn.Name = "grsbtn";
            grsbtn.Size = new Size(94, 29);
            grsbtn.TabIndex = 3;
            grsbtn.Text = "GİRİŞ";
            grsbtn.UseVisualStyleBackColor = true;
            grsbtn.Click += button2_Click;
            // 
            // kullanıcıgiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 496);
            Controls.Add(grsbtn);
            Controls.Add(cikisbtn);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "kullanıcıgiris";
            Text = "Kullanıcı Giriş";
            Load += kullanıcıgiris_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button cikisbtn;
        private Button grsbtn;
    }
}