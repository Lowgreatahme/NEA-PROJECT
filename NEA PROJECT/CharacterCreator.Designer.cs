namespace NEA_PROJECT
{
    partial class CharacterCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterCreator));
            label1 = new Label();
            BackButton = new Button();
            Penitent_Select = new Button();
            GraveKeeper_Select = new Button();
            Hunter_Select = new Button();
            Arcanist_Select = new Button();
            Shade_Select = new Button();
            Confirm_Select = new Button();
            Display_Label = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.WindowText;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Papyrus", 25F);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(398, 25);
            label1.Name = "label1";
            label1.Size = new Size(494, 69);
            label1.TabIndex = 0;
            label1.Text = "Choose your Ashenborn";
            // 
            // BackButton
            // 
            BackButton.Location = new Point(24, 506);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(94, 29);
            BackButton.TabIndex = 1;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // Penitent_Select
            // 
            Penitent_Select.BackColor = SystemColors.WindowText;
            Penitent_Select.ForeColor = Color.Cornsilk;
            Penitent_Select.ImageAlign = ContentAlignment.BottomLeft;
            Penitent_Select.Location = new Point(398, 139);
            Penitent_Select.Name = "Penitent_Select";
            Penitent_Select.Size = new Size(140, 67);
            Penitent_Select.TabIndex = 5;
            Penitent_Select.Text = "Penitent";
            Penitent_Select.UseVisualStyleBackColor = false;
            Penitent_Select.Click += Penitent_Select_Click;
            // 
            // GraveKeeper_Select
            // 
            GraveKeeper_Select.BackColor = SystemColors.WindowText;
            GraveKeeper_Select.ForeColor = Color.Cornsilk;
            GraveKeeper_Select.ImageAlign = ContentAlignment.BottomLeft;
            GraveKeeper_Select.Location = new Point(228, 139);
            GraveKeeper_Select.Name = "GraveKeeper_Select";
            GraveKeeper_Select.Size = new Size(140, 67);
            GraveKeeper_Select.TabIndex = 4;
            GraveKeeper_Select.Text = "GraveKeeper";
            GraveKeeper_Select.UseVisualStyleBackColor = false;
            GraveKeeper_Select.Click += GraveKeeper_Select_Click;
            // 
            // Hunter_Select
            // 
            Hunter_Select.BackColor = SystemColors.WindowText;
            Hunter_Select.ForeColor = Color.Cornsilk;
            Hunter_Select.ImageAlign = ContentAlignment.BottomLeft;
            Hunter_Select.Location = new Point(398, 313);
            Hunter_Select.Name = "Hunter_Select";
            Hunter_Select.Size = new Size(140, 67);
            Hunter_Select.TabIndex = 7;
            Hunter_Select.Text = "Hunter";
            Hunter_Select.UseVisualStyleBackColor = false;
            Hunter_Select.Click += Hunter_Select_Click;
            // 
            // Arcanist_Select
            // 
            Arcanist_Select.BackColor = SystemColors.WindowText;
            Arcanist_Select.ForeColor = Color.Cornsilk;
            Arcanist_Select.ImageAlign = ContentAlignment.BottomLeft;
            Arcanist_Select.Location = new Point(228, 313);
            Arcanist_Select.Name = "Arcanist_Select";
            Arcanist_Select.Size = new Size(140, 67);
            Arcanist_Select.TabIndex = 6;
            Arcanist_Select.Text = "Arcanist";
            Arcanist_Select.UseVisualStyleBackColor = false;
            Arcanist_Select.Click += Arcanist_Select_Click;
            // 
            // Shade_Select
            // 
            Shade_Select.BackColor = SystemColors.WindowText;
            Shade_Select.ForeColor = Color.Cornsilk;
            Shade_Select.ImageAlign = ContentAlignment.BottomLeft;
            Shade_Select.Location = new Point(314, 226);
            Shade_Select.Name = "Shade_Select";
            Shade_Select.Size = new Size(140, 61);
            Shade_Select.TabIndex = 9;
            Shade_Select.Text = "Shade";
            Shade_Select.UseVisualStyleBackColor = false;
            Shade_Select.Click += Shade_Select_Click;
            // 
            // Confirm_Select
            // 
            Confirm_Select.BackColor = SystemColors.WindowText;
            Confirm_Select.ForeColor = Color.Cornsilk;
            Confirm_Select.ImageAlign = ContentAlignment.BottomLeft;
            Confirm_Select.Location = new Point(290, 426);
            Confirm_Select.Name = "Confirm_Select";
            Confirm_Select.Size = new Size(164, 70);
            Confirm_Select.TabIndex = 11;
            Confirm_Select.Text = "Confirm";
            Confirm_Select.UseVisualStyleBackColor = false;
            Confirm_Select.Click += Confirm_Select_Click_1;
            // 
            // Display_Label
            // 
            Display_Label.AutoEllipsis = true;
            Display_Label.AutoSize = true;
            Display_Label.BackColor = SystemColors.ActiveCaptionText;
            Display_Label.BorderStyle = BorderStyle.Fixed3D;
            Display_Label.ForeColor = Color.Cornsilk;
            Display_Label.Location = new Point(718, 122);
            Display_Label.MaximumSize = new Size(400, 400);
            Display_Label.MinimumSize = new Size(400, 400);
            Display_Label.Name = "Display_Label";
            Display_Label.Size = new Size(400, 400);
            Display_Label.TabIndex = 12;
            Display_Label.Click += Display_Label_Click;
            // 
            // CharacterCreator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1237, 587);
            Controls.Add(Display_Label);
            Controls.Add(Confirm_Select);
            Controls.Add(Shade_Select);
            Controls.Add(Hunter_Select);
            Controls.Add(Arcanist_Select);
            Controls.Add(Penitent_Select);
            Controls.Add(GraveKeeper_Select);
            Controls.Add(BackButton);
            Controls.Add(label1);
            Name = "CharacterCreator";
            Text = "CharacterCreator";
            Load += CharacterCreator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BackButton;
        private Button Penitent_Select;
        private Button GraveKeeper_Select;
        private Button Hunter_Select;
        private Button Arcanist_Select;
        private Button Shade_Select;
        private Button Confirm_Select;
        private Label Display_Label;
    }
}