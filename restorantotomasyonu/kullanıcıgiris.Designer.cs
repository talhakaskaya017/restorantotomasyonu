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
            panel1 = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Bookman Old Style", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(24, 249);
            label1.Name = "label1";
            label1.Size = new Size(117, 18);
            label1.TabIndex = 0;
            label1.Text = "KULLANICI ADI";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(24, 322);
            label2.Name = "label2";
            label2.Size = new Size(55, 19);
            label2.TabIndex = 0;
            label2.Text = "ŞİFRE";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(24, 344);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 28);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.HighlightText;
            comboBox1.Cursor = Cursors.IBeam;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(24, 270);
            comboBox1.Name = "comboBox1";
            comboBox1.RightToLeft = RightToLeft.No;
            comboBox1.Size = new Size(238, 28);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cikisbtn
            // 
            cikisbtn.BackColor = Color.IndianRed;
            cikisbtn.BackgroundImageLayout = ImageLayout.Zoom;
            cikisbtn.Cursor = Cursors.Hand;
            cikisbtn.FlatStyle = FlatStyle.Popup;
            cikisbtn.Location = new Point(24, 412);
            cikisbtn.Name = "cikisbtn";
            cikisbtn.Size = new Size(90, 46);
            cikisbtn.TabIndex = 3;
            cikisbtn.Text = "ÇIKIŞ";
            cikisbtn.UseVisualStyleBackColor = false;
            cikisbtn.Click += button1_Click;
            // 
            // grsbtn
            // 
            grsbtn.BackColor = Color.Red;
            grsbtn.BackgroundImageLayout = ImageLayout.Zoom;
            grsbtn.Cursor = Cursors.Hand;
            grsbtn.FlatStyle = FlatStyle.Popup;
            grsbtn.Location = new Point(178, 412);
            grsbtn.Name = "grsbtn";
            grsbtn.Size = new Size(84, 46);
            grsbtn.TabIndex = 4;
            grsbtn.Text = "GİRİŞ";
            grsbtn.UseVisualStyleBackColor = false;
            grsbtn.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 55, 89);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(289, 227);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(0, 207);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.icons8_restaurant_67;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(24, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(238, 189);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // kullanıcıgiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(289, 505);
            Controls.Add(panel1);
            Controls.Add(grsbtn);
            Controls.Add(cikisbtn);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "kullanıcıgiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Giriş";
            Load += kullanıcıgiris_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label3;
    }
}