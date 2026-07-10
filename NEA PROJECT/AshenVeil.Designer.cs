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
            label1 = new Label();
            StartButton = new Button();
            ExitButton = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Papyrus", 48F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(467, 35);
            label1.Name = "label1";
            label1.Size = new Size(428, 126);
            label1.TabIndex = 0;
            label1.Text = "AshenVeil";
            label1.Click += label1_Click;
            // 
            // StartButton
            // 
            StartButton.BackColor = SystemColors.AppWorkspace;
            StartButton.Font = new Font("Tempus Sans ITC", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StartButton.Location = new Point(591, 256);
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
            ExitButton.Location = new Point(591, 365);
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
            label2.Location = new Point(516, 161);
            label2.Name = "label2";
            label2.Size = new Size(307, 20);
            label2.TabIndex = 3;
            label2.Text = "A Roguelike game created by Ahmed Osman";
            // 
            // AshenVeil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1306, 757);
            Controls.Add(label2);
            Controls.Add(ExitButton);
            Controls.Add(StartButton);
            Controls.Add(label1);
            Name = "AshenVeil";
            Text = "Title";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button StartButton;
        private Button ExitButton;
        private Label label2;
    }
}
