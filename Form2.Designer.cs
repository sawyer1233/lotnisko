
namespace bazyddanych
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
            this.bagaze = new System.Windows.Forms.Button();
            this.Loty = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Pasazerowie = new System.Windows.Forms.Button();
            this.Samoloty = new System.Windows.Forms.Button();
            this.Inner_join = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bagaze
            // 
            this.bagaze.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bagaze.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.bagaze.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bagaze.Location = new System.Drawing.Point(380, 185);
            this.bagaze.Name = "bagaze";
            this.bagaze.Size = new System.Drawing.Size(189, 68);
            this.bagaze.TabIndex = 0;
            this.bagaze.Text = "Bagaże";
            this.bagaze.UseVisualStyleBackColor = false;
            this.bagaze.Click += new System.EventHandler(this.bagaze_Click);
            // 
            // Loty
            // 
            this.Loty.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Loty.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.Loty.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Loty.Location = new System.Drawing.Point(95, 112);
            this.Loty.Name = "Loty";
            this.Loty.Size = new System.Drawing.Size(189, 67);
            this.Loty.TabIndex = 1;
            this.Loty.Text = "Loty";
            this.Loty.UseVisualStyleBackColor = false;
            this.Loty.Click += new System.EventHandler(this.Loty_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(95, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 67);
            this.button1.TabIndex = 3;
            this.button1.Text = "Przewoźnik";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pasazerowie
            // 
            this.Pasazerowie.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Pasazerowie.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.Pasazerowie.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Pasazerowie.Location = new System.Drawing.Point(95, 185);
            this.Pasazerowie.Name = "Pasazerowie";
            this.Pasazerowie.Size = new System.Drawing.Size(189, 68);
            this.Pasazerowie.TabIndex = 2;
            this.Pasazerowie.Text = "Pasazerowie";
            this.Pasazerowie.UseVisualStyleBackColor = false;
            this.Pasazerowie.Click += new System.EventHandler(this.Pasazerowie_Click);
            // 
            // Samoloty
            // 
            this.Samoloty.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Samoloty.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.Samoloty.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Samoloty.Location = new System.Drawing.Point(380, 259);
            this.Samoloty.Name = "Samoloty";
            this.Samoloty.Size = new System.Drawing.Size(189, 68);
            this.Samoloty.TabIndex = 4;
            this.Samoloty.Text = "Samoloty";
            this.Samoloty.UseVisualStyleBackColor = false;
            this.Samoloty.Click += new System.EventHandler(this.Samoloty_Click);
            // 
            // Inner_join
            // 
            this.Inner_join.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Inner_join.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.Inner_join.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Inner_join.Location = new System.Drawing.Point(380, 111);
            this.Inner_join.Name = "Inner_join";
            this.Inner_join.Size = new System.Drawing.Size(189, 68);
            this.Inner_join.TabIndex = 6;
            this.Inner_join.Text = "Inner join";
            this.Inner_join.UseVisualStyleBackColor = false;
            this.Inner_join.Click += new System.EventHandler(this.Inner_join_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(555, 23);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(91, 46);
            this.exit.TabIndex = 7;
            this.exit.Text = "exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(665, 370);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Inner_join);
            this.Controls.Add(this.Samoloty);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Pasazerowie);
            this.Controls.Add(this.Loty);
            this.Controls.Add(this.bagaze);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bagaze;
        private System.Windows.Forms.Button Loty;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Pasazerowie;
        private System.Windows.Forms.Button Samoloty;
        private System.Windows.Forms.Button Inner_join;
        private System.Windows.Forms.Button exit;
    }
}