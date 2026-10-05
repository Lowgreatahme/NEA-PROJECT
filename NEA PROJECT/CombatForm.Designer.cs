namespace NEA_PROJECT
{
    partial class CombatForm
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
            Combat_Button = new Button();
            Magic_Button = new Button();
            Items_Button = new Button();
            Act_Button = new Button();
            BattleDisplay_Label = new Label();
            Display_Panel = new Panel();
            Display_Panel.SuspendLayout();
            SuspendLayout();
            // 
            // Combat_Button
            // 
            Combat_Button.Font = new Font("Papyrus", 12F);
            Combat_Button.Location = new Point(46, 24);
            Combat_Button.Name = "Combat_Button";
            Combat_Button.Size = new Size(141, 80);
            Combat_Button.TabIndex = 0;
            Combat_Button.Text = "Fight";
            Combat_Button.UseVisualStyleBackColor = true;
            Combat_Button.Click += Combat_Button_Click;
            // 
            // Magic_Button
            // 
            Magic_Button.Font = new Font("Papyrus", 12F);
            Magic_Button.Location = new Point(193, 24);
            Magic_Button.Name = "Magic_Button";
            Magic_Button.Size = new Size(141, 80);
            Magic_Button.TabIndex = 1;
            Magic_Button.Text = "Magic";
            Magic_Button.UseVisualStyleBackColor = true;
            Magic_Button.Click += Magic_Button_Click;
            // 
            // Items_Button
            // 
            Items_Button.Font = new Font("Papyrus", 12F);
            Items_Button.Location = new Point(46, 108);
            Items_Button.Name = "Items_Button";
            Items_Button.Size = new Size(141, 80);
            Items_Button.TabIndex = 2;
            Items_Button.Text = "Items";
            Items_Button.UseVisualStyleBackColor = true;
            // 
            // Act_Button
            // 
            Act_Button.Font = new Font("Papyrus", 12F);
            Act_Button.Location = new Point(193, 108);
            Act_Button.Name = "Act_Button";
            Act_Button.Size = new Size(141, 80);
            Act_Button.TabIndex = 3;
            Act_Button.Text = "Act";
            Act_Button.UseVisualStyleBackColor = true;
            // 
            // BattleDisplay_Label
            // 
            BattleDisplay_Label.AutoSize = true;
            BattleDisplay_Label.BorderStyle = BorderStyle.Fixed3D;
            BattleDisplay_Label.Font = new Font("Papyrus", 10F);
            BattleDisplay_Label.Location = new Point(60, 235);
            BattleDisplay_Label.MaximumSize = new Size(300, 185);
            BattleDisplay_Label.MinimumSize = new Size(300, 185);
            BattleDisplay_Label.Name = "BattleDisplay_Label";
            BattleDisplay_Label.Size = new Size(300, 185);
            BattleDisplay_Label.TabIndex = 4;
            BattleDisplay_Label.Text = "label1";
            // 
            // Display_Panel
            // 
            Display_Panel.Controls.Add(Items_Button);
            Display_Panel.Controls.Add(Act_Button);
            Display_Panel.Controls.Add(Combat_Button);
            Display_Panel.Controls.Add(Magic_Button);
            Display_Panel.Location = new Point(412, 235);
            Display_Panel.Name = "Display_Panel";
            Display_Panel.Size = new Size(376, 203);
            Display_Panel.TabIndex = 5;
            Display_Panel.Paint += Display_Panel_Paint;
            // 
            // CombatForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BattleDisplay_Label);
            Controls.Add(Display_Panel);
            Name = "CombatForm";
            Text = "CombatForm";
            Display_Panel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Combat_Button;
        private Button Magic_Button;
        private Button Items_Button;
        private Button Act_Button;
        private Label BattleDisplay_Label;
        private Panel Display_Panel;
    }
}