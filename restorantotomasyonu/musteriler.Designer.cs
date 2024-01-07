namespace restorantotomasyonu
{
    partial class musteriler
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
            ccik = new Button();
            bgeri = new Button();
            SuspendLayout();
            // 
            // ccik
            // 
            ccik.BackgroundImage = Properties.Resources._6035_exit_icon;
            ccik.BackgroundImageLayout = ImageLayout.Zoom;
            ccik.Location = new Point(88, 375);
            ccik.Name = "ccik";
            ccik.Size = new Size(45, 45);
            ccik.TabIndex = 4;
            ccik.UseVisualStyleBackColor = true;
            ccik.Click += ccik_Click;
            // 
            // bgeri
            // 
            bgeri.BackColor = Color.FromArgb(192, 0, 0);
            bgeri.BackgroundImage = Properties.Resources._9004860_arrow_direction_left_back_icon;
            bgeri.BackgroundImageLayout = ImageLayout.Zoom;
            bgeri.Location = new Point(29, 375);
            bgeri.Name = "bgeri";
            bgeri.Size = new Size(53, 45);
            bgeri.TabIndex = 3;
            bgeri.UseVisualStyleBackColor = false;
            // 
            // musteriler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ccik);
            Controls.Add(bgeri);
            Name = "musteriler";
            Text = "musteriler";
            ResumeLayout(false);
        }

        #endregion

        private Button ccik;
        private Button bgeri;
    }
}