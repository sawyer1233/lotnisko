
namespace bazyddanych
{
    partial class Inner_join
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
            this.bagaze_loty = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Bag_Pas = new System.Windows.Forms.Button();
            this.bagaze_pr = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bagaze_loty
            // 
            this.bagaze_loty.Location = new System.Drawing.Point(12, 27);
            this.bagaze_loty.Name = "bagaze_loty";
            this.bagaze_loty.Size = new System.Drawing.Size(177, 49);
            this.bagaze_loty.TabIndex = 0;
            this.bagaze_loty.Text = "Bagaże+Loty";
            this.bagaze_loty.UseVisualStyleBackColor = true;
            this.bagaze_loty.Click += new System.EventHandler(this.bagaze_loty_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(749, 195);
            this.dataGridView1.TabIndex = 1;
            // 
            // Bag_Pas
            // 
            this.Bag_Pas.Location = new System.Drawing.Point(611, 137);
            this.Bag_Pas.Name = "Bag_Pas";
            this.Bag_Pas.Size = new System.Drawing.Size(177, 49);
            this.Bag_Pas.TabIndex = 2;
            this.Bag_Pas.Text = "Bagaże+Pasażerowie";
            this.Bag_Pas.UseVisualStyleBackColor = true;
            this.Bag_Pas.Click += new System.EventHandler(this.Bag_Pas_Click);
            // 
            // bagaze_pr
            // 
            this.bagaze_pr.Location = new System.Drawing.Point(12, 82);
            this.bagaze_pr.Name = "bagaze_pr";
            this.bagaze_pr.Size = new System.Drawing.Size(177, 49);
            this.bagaze_pr.TabIndex = 3;
            this.bagaze_pr.Text = "Bagaże+Przewoźnik";
            this.bagaze_pr.UseVisualStyleBackColor = true;
            this.bagaze_pr.Click += new System.EventHandler(this.bagaze_pr_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "Bagaże+Samoloty";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(703, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(85, 34);
            this.exit.TabIndex = 5;
            this.exit.Text = "exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(416, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 49);
            this.button2.TabIndex = 9;
            this.button2.Text = "Pasazerowie+Przewoźnik";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(212, 137);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 49);
            this.button3.TabIndex = 8;
            this.button3.Text = "Loty+Samoloty";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(212, 82);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 49);
            this.button4.TabIndex = 7;
            this.button4.Text = "Loty+Przewoźnik";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(212, 27);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(180, 49);
            this.button5.TabIndex = 6;
            this.button5.Text = "Loty+Pasażerowie";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(416, 27);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(180, 49);
            this.button6.TabIndex = 10;
            this.button6.Text = "Pasazerowie+Samoloty";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(416, 82);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(180, 49);
            this.button7.TabIndex = 11;
            this.button7.Text = "Przewoźnik+Samoloty";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Inner_join
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bagaze_pr);
            this.Controls.Add(this.Bag_Pas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bagaze_loty);
            this.Name = "Inner_join";
            this.Text = "Inner_join";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bagaze_loty;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Bag_Pas;
        private System.Windows.Forms.Button bagaze_pr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}