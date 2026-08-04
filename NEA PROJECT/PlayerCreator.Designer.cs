namespace NEA_PROJECT
{
    partial class PlayerCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerCreator));
            label1 = new Label();
            Name_TextBox = new TextBox();
            Name_Label = new Label();
            Confirm_Button = new Button();
            Male_CheckBox = new CheckBox();
            Female_Checkbox = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDarkDark;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(192, 61);
            label1.Name = "label1";
            label1.Size = new Size(495, 46);
            label1.TabIndex = 0;
            label1.Text = "What is your name and gender?";
            // 
            // Name_TextBox
            // 
            Name_TextBox.BackColor = SystemColors.ControlDarkDark;
            Name_TextBox.Font = new Font("Segoe UI", 15F);
            Name_TextBox.Location = new Point(293, 190);
            Name_TextBox.Name = "Name_TextBox";
            Name_TextBox.Size = new Size(312, 41);
            Name_TextBox.TabIndex = 1;
            Name_TextBox.TextChanged += Name_TextBox_TextChanged;
            // 
            // Name_Label
            // 
            Name_Label.AutoSize = true;
            Name_Label.BackColor = SystemColors.ControlDarkDark;
            Name_Label.Font = new Font("Segoe UI", 15F);
            Name_Label.Location = new Point(192, 193);
            Name_Label.Name = "Name_Label";
            Name_Label.Size = new Size(87, 35);
            Name_Label.TabIndex = 2;
            Name_Label.Text = "Name:";
            // 
            // Confirm_Button
            // 
            Confirm_Button.BackColor = SystemColors.ControlDarkDark;
            Confirm_Button.Font = new Font("Segoe UI", 15F);
            Confirm_Button.Location = new Point(336, 391);
            Confirm_Button.Name = "Confirm_Button";
            Confirm_Button.Size = new Size(212, 89);
            Confirm_Button.TabIndex = 5;
            Confirm_Button.Text = "Confirm";
            Confirm_Button.UseVisualStyleBackColor = false;
            Confirm_Button.Click += Confirm_Button_Click;
            // 
            // Male_CheckBox
            // 
            Male_CheckBox.AutoSize = true;
            Male_CheckBox.BackColor = SystemColors.ControlDarkDark;
            Male_CheckBox.Font = new Font("Segoe UI", 12F);
            Male_CheckBox.Location = new Point(375, 283);
            Male_CheckBox.Name = "Male_CheckBox";
            Male_CheckBox.Size = new Size(77, 32);
            Male_CheckBox.TabIndex = 6;
            Male_CheckBox.Text = "Male";
            Male_CheckBox.UseVisualStyleBackColor = false;
            Male_CheckBox.CheckedChanged += Male_CheckBox_CheckedChanged;
            // 
            // Female_Checkbox
            // 
            Female_Checkbox.AutoSize = true;
            Female_Checkbox.BackColor = SystemColors.ControlDarkDark;
            Female_Checkbox.Font = new Font("Segoe UI", 12F);
            Female_Checkbox.Location = new Point(375, 322);
            Female_Checkbox.Name = "Female_Checkbox";
            Female_Checkbox.Size = new Size(96, 32);
            Female_Checkbox.TabIndex = 7;
            Female_Checkbox.Text = "Female";
            Female_Checkbox.UseVisualStyleBackColor = false;
            Female_Checkbox.CheckedChanged += Female_Checkbox_CheckedChanged;
            // 
            // PlayerCreator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(921, 505);
            Controls.Add(Female_Checkbox);
            Controls.Add(Male_CheckBox);
            Controls.Add(Confirm_Button);
            Controls.Add(Name_Label);
            Controls.Add(Name_TextBox);
            Controls.Add(label1);
            Name = "PlayerCreator";
            Text = "PlayerCreator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Name_TextBox;
        private Label Name_Label;
        private Button Confirm_Button;
        private CheckBox Male_CheckBox;
        private CheckBox Female_Checkbox;
    }
}