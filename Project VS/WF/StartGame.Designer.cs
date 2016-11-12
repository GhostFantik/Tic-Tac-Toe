namespace WF
{
    partial class StartGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.CloseApp = new System.Windows.Forms.Button();
            this.ModeGame = new System.Windows.Forms.Panel();
            this.checkAI = new System.Windows.Forms.RadioButton();
            this.checkTP = new System.Windows.Forms.RadioButton();
            this.Complexity = new System.Windows.Forms.Panel();
            this.LevelC_Norm = new System.Windows.Forms.RadioButton();
            this.LevelC_IZI = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.ModeGame.SuspendLayout();
            this.Complexity.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Игра: Крестики Нолики";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "by GhostFantik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Вк: vk.com/ghost_fantik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Режим игры:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Уровень сложности: ";
            // 
            // buttonStart
            // 
            this.buttonStart.Enabled = false;
            this.buttonStart.Location = new System.Drawing.Point(60, 185);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 9;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // CloseApp
            // 
            this.CloseApp.Location = new System.Drawing.Point(151, 185);
            this.CloseApp.Name = "CloseApp";
            this.CloseApp.Size = new System.Drawing.Size(65, 23);
            this.CloseApp.TabIndex = 10;
            this.CloseApp.Text = "Выход";
            this.CloseApp.UseVisualStyleBackColor = true;
            this.CloseApp.Click += new System.EventHandler(this.CloseApp_Click);
            // 
            // ModeGame
            // 
            this.ModeGame.Controls.Add(this.checkAI);
            this.ModeGame.Controls.Add(this.checkTP);
            this.ModeGame.Location = new System.Drawing.Point(15, 66);
            this.ModeGame.Name = "ModeGame";
            this.ModeGame.Size = new System.Drawing.Size(103, 41);
            this.ModeGame.TabIndex = 11;
            // 
            // checkAI
            // 
            this.checkAI.AutoSize = true;
            this.checkAI.Location = new System.Drawing.Point(15, 21);
            this.checkAI.Name = "checkAI";
            this.checkAI.Size = new System.Drawing.Size(41, 17);
            this.checkAI.TabIndex = 1;
            this.checkAI.TabStop = true;
            this.checkAI.Text = "ИИ";
            this.checkAI.UseVisualStyleBackColor = true;
            this.checkAI.CheckedChanged += new System.EventHandler(this.checkAI_CheckedChanged);
            // 
            // checkTP
            // 
            this.checkTP.AutoSize = true;
            this.checkTP.Location = new System.Drawing.Point(15, 3);
            this.checkTP.Name = "checkTP";
            this.checkTP.Size = new System.Drawing.Size(84, 17);
            this.checkTP.TabIndex = 0;
            this.checkTP.TabStop = true;
            this.checkTP.Text = "Два игрока";
            this.checkTP.UseVisualStyleBackColor = true;
            this.checkTP.CheckedChanged += new System.EventHandler(this.checkTP_CheckedChanged);
            // 
            // Complexity
            // 
            this.Complexity.Controls.Add(this.LevelC_Norm);
            this.Complexity.Controls.Add(this.LevelC_IZI);
            this.Complexity.Enabled = false;
            this.Complexity.Location = new System.Drawing.Point(16, 126);
            this.Complexity.Name = "Complexity";
            this.Complexity.Size = new System.Drawing.Size(119, 53);
            this.Complexity.TabIndex = 12;
            // 
            // LevelC_Norm
            // 
            this.LevelC_Norm.AutoSize = true;
            this.LevelC_Norm.Location = new System.Drawing.Point(14, 25);
            this.LevelC_Norm.Name = "LevelC_Norm";
            this.LevelC_Norm.Size = new System.Drawing.Size(64, 17);
            this.LevelC_Norm.TabIndex = 1;
            this.LevelC_Norm.TabStop = true;
            this.LevelC_Norm.Text = "Сложно";
            this.LevelC_Norm.UseVisualStyleBackColor = true;
            this.LevelC_Norm.CheckedChanged += new System.EventHandler(this.LevelC_Norm_CheckedChanged);
            // 
            // LevelC_IZI
            // 
            this.LevelC_IZI.AutoSize = true;
            this.LevelC_IZI.Location = new System.Drawing.Point(14, 1);
            this.LevelC_IZI.Name = "LevelC_IZI";
            this.LevelC_IZI.Size = new System.Drawing.Size(56, 17);
            this.LevelC_IZI.TabIndex = 0;
            this.LevelC_IZI.TabStop = true;
            this.LevelC_IZI.Text = "Легко";
            this.LevelC_IZI.UseVisualStyleBackColor = true;
            this.LevelC_IZI.CheckedChanged += new System.EventHandler(this.LevelC_IZI_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Wyskill Enterprise";
            // 
            // StartGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Complexity);
            this.Controls.Add(this.ModeGame);
            this.Controls.Add(this.CloseApp);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartGame";
            this.Text = "Меню";
            this.ModeGame.ResumeLayout(false);
            this.ModeGame.PerformLayout();
            this.Complexity.ResumeLayout(false);
            this.Complexity.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button CloseApp;
        private System.Windows.Forms.Panel ModeGame;
        private System.Windows.Forms.RadioButton checkAI;
        private System.Windows.Forms.RadioButton checkTP;
        private System.Windows.Forms.Panel Complexity;
        private System.Windows.Forms.RadioButton LevelC_Norm;
        private System.Windows.Forms.RadioButton LevelC_IZI;
        private System.Windows.Forms.Label label6;
    }
}