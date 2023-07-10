
namespace bazyddanych
{
    partial class Form1
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
            this.Haslo = new System.Windows.Forms.Label();
            this.txt_uzytkownik = new System.Windows.Forms.TextBox();
            this.txt_haslo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logowanie = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.zamknij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Haslo
            // 
            this.Haslo.AutoSize = true;
            this.Haslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Haslo.Location = new System.Drawing.Point(203, 181);
            this.Haslo.Name = "Haslo";
            this.Haslo.Size = new System.Drawing.Size(53, 20);
            this.Haslo.TabIndex = 2;
            this.Haslo.Text = "Haslo";
            // 
            // txt_uzytkownik
            // 
            this.txt_uzytkownik.Location = new System.Drawing.Point(269, 139);
            this.txt_uzytkownik.Name = "txt_uzytkownik";
            this.txt_uzytkownik.Size = new System.Drawing.Size(150, 22);
            this.txt_uzytkownik.TabIndex = 3;
            // 
            // txt_haslo
            // 
            this.txt_haslo.Location = new System.Drawing.Point(269, 181);
            this.txt_haslo.Name = "txt_haslo";
            this.txt_haslo.Size = new System.Drawing.Size(150, 22);
            this.txt_haslo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(113, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 57);
            this.label1.TabIndex = 5;
            this.label1.Text = "Port Lotniczy AirPoland";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // logowanie
            // 
            this.logowanie.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.logowanie.ForeColor = System.Drawing.SystemColors.ControlText;
            this.logowanie.Location = new System.Drawing.Point(331, 236);
            this.logowanie.Name = "logowanie";
            this.logowanie.Size = new System.Drawing.Size(201, 54);
            this.logowanie.TabIndex = 6;
            this.logowanie.Text = "Zaloguj";
            this.logowanie.UseVisualStyleBackColor = false;
            this.logowanie.Click += new System.EventHandler(this.logowanie_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(203, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nazwa";
            // 
            // zamknij
            // 
            this.zamknij.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.zamknij.ForeColor = System.Drawing.SystemColors.ControlText;
            this.zamknij.Location = new System.Drawing.Point(111, 236);
            this.zamknij.Name = "zamknij";
            this.zamknij.Size = new System.Drawing.Size(201, 54);
            this.zamknij.TabIndex = 8;
            this.zamknij.Text = "Zamknij";
            this.zamknij.UseVisualStyleBackColor = false;
            this.zamknij.Click += new System.EventHandler(this.zamknij_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(665, 370);
            this.Controls.Add(this.zamknij);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logowanie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_haslo);
            this.Controls.Add(this.txt_uzytkownik);
            this.Controls.Add(this.Haslo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Haslo;
        private System.Windows.Forms.TextBox txt_uzytkownik;
        private System.Windows.Forms.TextBox txt_haslo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logowanie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button zamknij;
    }
}

