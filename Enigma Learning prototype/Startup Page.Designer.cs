namespace Enigma_Learning_prototype
{
    partial class Startup_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Startup_Page));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Biology = new System.Windows.Forms.Label();
            this.btn_Chemistry = new System.Windows.Forms.Label();
            this.btn_Physics = new System.Windows.Forms.Label();
            this.btn_GoToMoodlet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Nova", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(109, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(646, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "What subject will you like to revise today?";
            // 
            // btn_Biology
            // 
            this.btn_Biology.AutoSize = true;
            this.btn_Biology.BackColor = System.Drawing.Color.Transparent;
            this.btn_Biology.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Biology.Font = new System.Drawing.Font("Lucida Sans", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Biology.ForeColor = System.Drawing.Color.White;
            this.btn_Biology.Location = new System.Drawing.Point(190, 207);
            this.btn_Biology.Name = "btn_Biology";
            this.btn_Biology.Size = new System.Drawing.Size(179, 32);
            this.btn_Biology.TabIndex = 2;
            this.btn_Biology.Text = "•    Biology";
            this.btn_Biology.Click += new System.EventHandler(this.btn_Biology_Click);
            // 
            // btn_Chemistry
            // 
            this.btn_Chemistry.AutoSize = true;
            this.btn_Chemistry.BackColor = System.Drawing.Color.Transparent;
            this.btn_Chemistry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Chemistry.Font = new System.Drawing.Font("Lucida Sans", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Chemistry.ForeColor = System.Drawing.Color.White;
            this.btn_Chemistry.Location = new System.Drawing.Point(190, 303);
            this.btn_Chemistry.Name = "btn_Chemistry";
            this.btn_Chemistry.Size = new System.Drawing.Size(223, 32);
            this.btn_Chemistry.TabIndex = 3;
            this.btn_Chemistry.Text = "•    Chemistry";
            this.btn_Chemistry.Click += new System.EventHandler(this.btn_Chemistry_Click);
            // 
            // btn_Physics
            // 
            this.btn_Physics.AutoSize = true;
            this.btn_Physics.BackColor = System.Drawing.Color.Transparent;
            this.btn_Physics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Physics.Font = new System.Drawing.Font("Lucida Sans", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Physics.ForeColor = System.Drawing.Color.White;
            this.btn_Physics.Location = new System.Drawing.Point(190, 399);
            this.btn_Physics.Name = "btn_Physics";
            this.btn_Physics.Size = new System.Drawing.Size(180, 32);
            this.btn_Physics.TabIndex = 4;
            this.btn_Physics.Text = "•    Physics";
            this.btn_Physics.Click += new System.EventHandler(this.btn_Physics_Click);
            // 
            // btn_GoToMoodlet
            // 
            this.btn_GoToMoodlet.Font = new System.Drawing.Font("Lucida Handwriting", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GoToMoodlet.Location = new System.Drawing.Point(807, 504);
            this.btn_GoToMoodlet.Name = "btn_GoToMoodlet";
            this.btn_GoToMoodlet.Size = new System.Drawing.Size(157, 44);
            this.btn_GoToMoodlet.TabIndex = 5;
            this.btn_GoToMoodlet.Text = "Moodlet";
            this.btn_GoToMoodlet.UseVisualStyleBackColor = true;
            this.btn_GoToMoodlet.Click += new System.EventHandler(this.btn_GoToMoodlet_Click);
            // 
            // Startup_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Enigma_Learning.Properties.Resources.home_page_image;
            this.ClientSize = new System.Drawing.Size(1038, 587);
            this.Controls.Add(this.btn_GoToMoodlet);
            this.Controls.Add(this.btn_Physics);
            this.Controls.Add(this.btn_Chemistry);
            this.Controls.Add(this.btn_Biology);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Startup_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enigma Learning";
            this.Load += new System.EventHandler(this.Startup_Page_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btn_Biology;
        private System.Windows.Forms.Label btn_Chemistry;
        private System.Windows.Forms.Label btn_Physics;
        private System.Windows.Forms.Button btn_GoToMoodlet;
    }
}