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
            SuspendLayout();
            // 
            // Combat_Button
            // 
            Combat_Button.Font = new Font("Papyrus", 12F);
            Combat_Button.Location = new Point(423, 235);
            Combat_Button.Name = "Combat_Button";
            Combat_Button.Size = new Size(141, 80);
            Combat_Button.TabIndex = 0;
            Combat_Button.Text = "Fight";
            Combat_Button.UseVisualStyleBackColor = true;
            // 
            // Magic_Button
            // 
            Magic_Button.Font = new Font("Papyrus", 12F);
            Magic_Button.Location = new Point(585, 235);
            Magic_Button.Name = "Magic_Button";
            Magic_Button.Size = new Size(141, 80);
            Magic_Button.TabIndex = 1;
            Magic_Button.Text = "Magic";
            Magic_Button.UseVisualStyleBackColor = true;
            // 
            // Items_Button
            // 
            Items_Button.Font = new Font("Papyrus", 12F);
            Items_Button.Location = new Point(423, 338);
            Items_Button.Name = "Items_Button";
            Items_Button.Size = new Size(141, 80);
            Items_Button.TabIndex = 2;
            Items_Button.Text = "Items";
            Items_Button.UseVisualStyleBackColor = true;
            // 
            // Act_Button
            // 
            Act_Button.Font = new Font("Papyrus", 12F);
            Act_Button.Location = new Point(585, 338);
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
            // CombatForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BattleDisplay_Label);
            Controls.Add(Act_Button);
            Controls.Add(Items_Button);
            Controls.Add(Magic_Button);
            Controls.Add(Combat_Button);
            Name = "CombatForm";
            Text = "CombatForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Combat_Button;
        private Button Magic_Button;
        private Button Items_Button;
        private Button Act_Button;
        private Label BattleDisplay_Label;
    }
}