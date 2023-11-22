namespace Enigma_Learning_prototype
{
    partial class Enigma_Startup
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enigma_Startup));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_StartEnigma = new System.Windows.Forms.Button();
            this.btn_GoToMoodlet = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(394, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(185, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(672, 76);
            this.label2.TabIndex = 1;
            this.label2.Text = "ENIGMA LEARNING";
            // 
            // btn_StartEnigma
            // 
            this.btn_StartEnigma.Font = new System.Drawing.Font("Lucida Handwriting", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StartEnigma.Location = new System.Drawing.Point(401, 351);
            this.btn_StartEnigma.Name = "btn_StartEnigma";
            this.btn_StartEnigma.Size = new System.Drawing.Size(240, 44);
            this.btn_StartEnigma.TabIndex = 2;
            this.btn_StartEnigma.Text = "Start Revision";
            this.btn_StartEnigma.UseVisualStyleBackColor = true;
            this.btn_StartEnigma.Click += new System.EventHandler(this.btn_StartEnigma_Click);
            this.btn_StartEnigma.MouseHover += new System.EventHandler(this.btn_StartEnigma_MouseHover);
            // 
            // btn_GoToMoodlet
            // 
            this.btn_GoToMoodlet.Font = new System.Drawing.Font("Lucida Handwriting", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GoToMoodlet.Location = new System.Drawing.Point(401, 421);
            this.btn_GoToMoodlet.Name = "btn_GoToMoodlet";
            this.btn_GoToMoodlet.Size = new System.Drawing.Size(240, 44);
            this.btn_GoToMoodlet.TabIndex = 3;
            this.btn_GoToMoodlet.Text = "Go To Moodlet";
            this.btn_GoToMoodlet.UseVisualStyleBackColor = true;
            this.btn_GoToMoodlet.Click += new System.EventHandler(this.btn_GoToMoodlet_Click);
            this.btn_GoToMoodlet.MouseHover += new System.EventHandler(this.btn_GoToMoodlet_MouseHover);
            // 
            // Enigma_Startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Enigma_Learning.Properties.Resources.start_dialog_image;
            this.ClientSize = new System.Drawing.Size(1042, 591);
            this.Controls.Add(this.btn_GoToMoodlet);
            this.Controls.Add(this.btn_StartEnigma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Enigma_Startup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Enigma Learning!";
            this.Load += new System.EventHandler(this.Enigma_Startup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_StartEnigma;
        private System.Windows.Forms.Button btn_GoToMoodlet;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}

