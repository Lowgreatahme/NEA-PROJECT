namespace NEA_PROJECT
{
    partial class AshenVeil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AshenVeil));
            label1 = new Label();
            StartButton = new Button();
            ExitButton = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DimGray;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Papyrus", 48F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(325, 35);
            label1.Name = "label1";
            label1.Size = new Size(430, 128);
            label1.TabIndex = 0;
            label1.Text = "AshenVeil";
            label1.Click += label1_Click;
            // 
            // StartButton
            // 
            StartButton.BackColor = SystemColors.AppWorkspace;
            StartButton.Font = new Font("Tempus Sans ITC", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StartButton.Location = new Point(426, 240);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(206, 75);
            StartButton.TabIndex = 1;
            StartButton.Text = "Pierce The Veil";
            StartButton.UseVisualStyleBackColor = false;
            StartButton.Click += button1_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = SystemColors.ControlDark;
            ExitButton.Font = new Font("Tempus Sans ITC", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExitButton.Location = new Point(426, 361);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(206, 75);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "Fade to Ash";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(379, 161);
            label2.Name = "label2";
            label2.Size = new Size(307, 20);
            label2.TabIndex = 3;
            label2.Text = "A Roguelike game created by Ahmed Osman";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-8, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1072, 555);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // AshenVeil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1063, 553);
            Controls.Add(label1);
            Controls.Add(StartButton);
            Controls.Add(ExitButton);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Name = "AshenVeil";
            Text = "Title";
            Load += AshenVeil_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button StartButton;
        private Button ExitButton;
        private Label label2;
        private PictureBox pictureBox1;
    }
}
