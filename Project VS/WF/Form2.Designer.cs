namespace WF
{
    partial class Form2
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
            this.VictoryX = new System.Windows.Forms.Label();
            this.VictoryO = new System.Windows.Forms.Label();
            this.Draw = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Статистика";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Побед X: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Побед O:  ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ничьих:   ";
            // 
            // VictoryX
            // 
            this.VictoryX.AutoSize = true;
            this.VictoryX.Location = new System.Drawing.Point(75, 47);
            this.VictoryX.Name = "VictoryX";
            this.VictoryX.Size = new System.Drawing.Size(13, 13);
            this.VictoryX.TabIndex = 4;
            this.VictoryX.Text = "0";
            // 
            // VictoryO
            // 
            this.VictoryO.AutoSize = true;
            this.VictoryO.Location = new System.Drawing.Point(75, 78);
            this.VictoryO.Name = "VictoryO";
            this.VictoryO.Size = new System.Drawing.Size(13, 13);
            this.VictoryO.TabIndex = 5;
            this.VictoryO.Text = "0";
            // 
            // Draw
            // 
            this.Draw.AutoSize = true;
            this.Draw.Location = new System.Drawing.Point(75, 108);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(13, 13);
            this.Draw.TabIndex = 6;
            this.Draw.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 168);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Draw);
            this.Controls.Add(this.VictoryO);
            this.Controls.Add(this.VictoryX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label VictoryX;
        private System.Windows.Forms.Label VictoryO;
        private System.Windows.Forms.Label Draw;
        private System.Windows.Forms.Button button1;
    }
}