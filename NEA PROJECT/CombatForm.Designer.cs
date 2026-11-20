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
            Display_Panel = new Panel();
            Floor_Label = new Label();
            EnemyName_Label = new Label();
            EnemyHP_Label = new Label();
            EnemyMP_Label = new Label();
            vScrollBar1 = new VScrollBar();
            BattleLog = new RichTextBox();
            SuspendLayout();
            // 
            // Combat_Button
            // 
            Combat_Button.Font = new Font("Papyrus", 12F);
            Combat_Button.Location = new Point(42, 388);
            Combat_Button.Name = "Combat_Button";
            Combat_Button.Size = new Size(141, 50);
            Combat_Button.TabIndex = 0;
            Combat_Button.Text = "Fight";
            Combat_Button.UseVisualStyleBackColor = true;
            Combat_Button.Click += Combat_Button_Click;
            // 
            // Magic_Button
            // 
            Magic_Button.Font = new Font("Papyrus", 12F);
            Magic_Button.Location = new Point(233, 388);
            Magic_Button.Name = "Magic_Button";
            Magic_Button.Size = new Size(141, 50);
            Magic_Button.TabIndex = 1;
            Magic_Button.Text = "Magic";
            Magic_Button.UseVisualStyleBackColor = true;
            Magic_Button.Click += Magic_Button_Click;
            // 
            // Items_Button
            // 
            Items_Button.Font = new Font("Papyrus", 12F);
            Items_Button.Location = new Point(425, 388);
            Items_Button.Name = "Items_Button";
            Items_Button.Size = new Size(141, 50);
            Items_Button.TabIndex = 2;
            Items_Button.Text = "Items";
            Items_Button.UseVisualStyleBackColor = true;
            // 
            // Act_Button
            // 
            Act_Button.Font = new Font("Papyrus", 12F);
            Act_Button.Location = new Point(634, 388);
            Act_Button.Name = "Act_Button";
            Act_Button.Size = new Size(141, 50);
            Act_Button.TabIndex = 3;
            Act_Button.Text = "Act";
            Act_Button.UseVisualStyleBackColor = true;
            // 
            // Display_Panel
            // 
            Display_Panel.Location = new Point(42, 187);
            Display_Panel.Name = "Display_Panel";
            Display_Panel.Size = new Size(346, 177);
            Display_Panel.TabIndex = 5;
            Display_Panel.Paint += Display_Panel_Paint;
            // 
            // Floor_Label
            // 
            Floor_Label.AutoSize = true;
            Floor_Label.Font = new Font("Viner Hand ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Floor_Label.Location = new Point(595, 9);
            Floor_Label.Name = "Floor_Label";
            Floor_Label.Size = new Size(166, 32);
            Floor_Label.TabIndex = 6;
            Floor_Label.Text = "Floor 1 / BOSS: X";
            // 
            // EnemyName_Label
            // 
            EnemyName_Label.AutoSize = true;
            EnemyName_Label.Font = new Font("Segoe UI", 15F);
            EnemyName_Label.Location = new Point(61, 23);
            EnemyName_Label.Name = "EnemyName_Label";
            EnemyName_Label.Size = new Size(101, 35);
            EnemyName_Label.TabIndex = 7;
            EnemyName_Label.Text = "Enemy: ";
            // 
            // EnemyHP_Label
            // 
            EnemyHP_Label.AutoSize = true;
            EnemyHP_Label.Font = new Font("Segoe UI", 12F);
            EnemyHP_Label.Location = new Point(61, 68);
            EnemyHP_Label.Name = "EnemyHP_Label";
            EnemyHP_Label.Size = new Size(122, 28);
            EnemyHP_Label.TabIndex = 8;
            EnemyHP_Label.Text = "Enemy HP  []";
            EnemyHP_Label.Click += EnemyHP_Label_Click;
            // 
            // EnemyMP_Label
            // 
            EnemyMP_Label.AutoSize = true;
            EnemyMP_Label.Font = new Font("Segoe UI", 12F);
            EnemyMP_Label.Location = new Point(61, 108);
            EnemyMP_Label.Name = "EnemyMP_Label";
            EnemyMP_Label.Size = new Size(126, 28);
            EnemyMP_Label.TabIndex = 9;
            EnemyMP_Label.Text = "Enemy MP  []";
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(765, 211);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(26, 125);
            vScrollBar1.TabIndex = 10;
            // 
            // BattleLog
            // 
            BattleLog.Location = new Point(425, 187);
            BattleLog.Name = "BattleLog";
            BattleLog.ReadOnly = true;
            BattleLog.Size = new Size(350, 177);
            BattleLog.TabIndex = 11;
            BattleLog.TabStop = false;
            BattleLog.Text = "BattleDisplay_Label";
            // 
            // CombatForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BattleLog);
            Controls.Add(Act_Button);
            Controls.Add(Items_Button);
            Controls.Add(vScrollBar1);
            Controls.Add(EnemyMP_Label);
            Controls.Add(Combat_Button);
            Controls.Add(EnemyHP_Label);
            Controls.Add(Magic_Button);
            Controls.Add(EnemyName_Label);
            Controls.Add(Floor_Label);
            Controls.Add(Display_Panel);
            Name = "CombatForm";
            Text = "CombatForm";
            Load += CombatForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Combat_Button;
        private Button Magic_Button;
        private Button Items_Button;
        private Button Act_Button;
        private Panel Display_Panel;
        private Label Floor_Label;
        private Label EnemyName_Label;
        private Label EnemyHP_Label;
        private Label EnemyMP_Label;
        private VScrollBar vScrollBar1;
        private RichTextBox BattleLog;
    }
}