namespace Enigma_Learning_prototype
{
    partial class Moodlet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Moodlet));
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Diary = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_DayRate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Back.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(86, 879);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(103, 49);
            this.btn_Back.TabIndex = 10;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Diary
            // 
            this.btn_Diary.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Diary.ForeColor = System.Drawing.Color.Black;
            this.btn_Diary.Location = new System.Drawing.Point(114, 540);
            this.btn_Diary.Name = "btn_Diary";
            this.btn_Diary.Size = new System.Drawing.Size(225, 62);
            this.btn_Diary.TabIndex = 14;
            this.btn_Diary.Text = "Your Diary";
            this.btn_Diary.UseVisualStyleBackColor = true;
            this.btn_Diary.Click += new System.EventHandler(this.btn_Diary_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Kristen ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(107, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1452, 234);
            this.label4.TabIndex = 12;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Handwriting", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(366, 63);
            this.label3.TabIndex = 11;
            this.label3.Text = "The Moodlet";
            // 
            // btn_DayRate
            // 
            this.btn_DayRate.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DayRate.ForeColor = System.Drawing.Color.Black;
            this.btn_DayRate.Location = new System.Drawing.Point(114, 625);
            this.btn_DayRate.Name = "btn_DayRate";
            this.btn_DayRate.Size = new System.Drawing.Size(225, 62);
            this.btn_DayRate.TabIndex = 15;
            this.btn_DayRate.Text = "Mood Tracker";
            this.btn_DayRate.UseVisualStyleBackColor = true;
            this.btn_DayRate.Click += new System.EventHandler(this.btn_DayRate_Click);
            // 
            // Moodlet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Enigma_Learning.Properties.Resources.moodlet_image;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.btn_DayRate);
            this.Controls.Add(this.btn_Diary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Moodlet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Moodlet";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Diary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_DayRate;
    }
}