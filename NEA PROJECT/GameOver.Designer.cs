namespace NEA_PROJECT
{
    partial class GameOver
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
            label1 = new Label();
            Death_Display_Panel = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(270, 43);
            label1.Name = "label1";
            label1.Size = new Size(255, 57);
            label1.TabIndex = 0;
            label1.Text = "GAME OVER";
            // 
            // Death_Display_Panel
            // 
            Death_Display_Panel.Location = new Point(130, 129);
            Death_Display_Panel.Name = "Death_Display_Panel";
            Death_Display_Panel.Size = new Size(542, 231);
            Death_Display_Panel.TabIndex = 1;
            // 
            // GameOver
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Death_Display_Panel);
            Controls.Add(label1);
            Name = "GameOver";
            Text = "GameOver";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel Death_Display_Panel;
    }
}