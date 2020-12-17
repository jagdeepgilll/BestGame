namespace BestGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Shoot = new System.Windows.Forms.PictureBox();
            this.Relaod = new System.Windows.Forms.PictureBox();
            this.Spin = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Away = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Shoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Relaod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Away)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(235, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Shooting Game";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(577, 200);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Reload";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(24, 276);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Spin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(533, 263);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Shoot";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(19, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Away";
            // 
            // Shoot
            // 
            this.Shoot.Image = global::BestGame.Properties.Resources.Shoo;
            this.Shoot.Location = new System.Drawing.Point(514, 278);
            this.Shoot.Margin = new System.Windows.Forms.Padding(2);
            this.Shoot.Name = "Shoot";
            this.Shoot.Size = new System.Drawing.Size(104, 57);
            this.Shoot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Shoot.TabIndex = 14;
            this.Shoot.TabStop = false;
            this.Shoot.Click += new System.EventHandler(this.Shoot_Click_1);
            // 
            // Relaod
            // 
            this.Relaod.Image = global::BestGame.Properties.Resources.Reloo;
            this.Relaod.Location = new System.Drawing.Point(563, 215);
            this.Relaod.Margin = new System.Windows.Forms.Padding(2);
            this.Relaod.Name = "Relaod";
            this.Relaod.Size = new System.Drawing.Size(67, 44);
            this.Relaod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Relaod.TabIndex = 13;
            this.Relaod.TabStop = false;
            this.Relaod.Click += new System.EventHandler(this.Relaod_Click_1);
            // 
            // Spin
            // 
            this.Spin.Image = global::BestGame.Properties.Resources.spii;
            this.Spin.Location = new System.Drawing.Point(11, 291);
            this.Spin.Margin = new System.Windows.Forms.Padding(2);
            this.Spin.Name = "Spin";
            this.Spin.Size = new System.Drawing.Size(67, 44);
            this.Spin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Spin.TabIndex = 11;
            this.Spin.TabStop = false;
            this.Spin.Click += new System.EventHandler(this.Spin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BestGame.Properties.Resources.Backlook;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(638, 343);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Away
            // 
            this.Away.Image = global::BestGame.Properties.Resources.awoo;
            this.Away.Location = new System.Drawing.Point(11, 215);
            this.Away.Margin = new System.Windows.Forms.Padding(2);
            this.Away.Name = "Away";
            this.Away.Size = new System.Drawing.Size(67, 59);
            this.Away.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Away.TabIndex = 19;
            this.Away.TabStop = false;
            this.Away.Click += new System.EventHandler(this.Away_Click_2);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BestGame.Properties.Resources.exii;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(101, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 346);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Away);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Shoot);
            this.Controls.Add(this.Relaod);
            this.Controls.Add(this.Spin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Shoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Relaod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Away)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Shoot;
        private System.Windows.Forms.PictureBox Relaod;
        private System.Windows.Forms.PictureBox Spin;
        private System.Windows.Forms.PictureBox Away;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

