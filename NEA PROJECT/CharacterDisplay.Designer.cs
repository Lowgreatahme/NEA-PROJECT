namespace NEA_PROJECT
{
    partial class CharacterDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterDisplay));
            Display_Panel = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // Display_Panel
            // 
            Display_Panel.AutoSize = true;
            Display_Panel.BackColor = SystemColors.ControlDarkDark;
            Display_Panel.Font = new Font("Papyrus", 10F);
            Display_Panel.Location = new Point(153, 58);
            Display_Panel.MinimumSize = new Size(500, 200);
            Display_Panel.Name = "Display_Panel";
            Display_Panel.Size = new Size(500, 200);
            Display_Panel.TabIndex = 0;
            Display_Panel.Click += Display_Panel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDarkDark;
            label1.Font = new Font("Papyrus", 14F);
            label1.Location = new Point(263, 311);
            label1.MinimumSize = new Size(50, 30);
            label1.Name = "label1";
            label1.Size = new Size(271, 38);
            label1.TabIndex = 1;
            label1.Text = "Are you sure about this?";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.Font = new Font("Papyrus", 14F);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(433, 377);
            button1.Name = "button1";
            button1.Size = new Size(139, 61);
            button1.TabIndex = 2;
            button1.Text = "Go Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDarkDark;
            button2.Font = new Font("Papyrus", 14F);
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(216, 377);
            button2.Name = "button2";
            button2.Size = new Size(139, 61);
            button2.TabIndex = 3;
            button2.Text = "Confirm";
            button2.UseVisualStyleBackColor = false;
            // 
            // CharacterDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(Display_Panel);
            Name = "CharacterDisplay";
            Text = "CharacterDisplay";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Display_Panel;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}