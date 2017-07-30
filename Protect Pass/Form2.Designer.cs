namespace Protect_Pass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.exitclick = new System.Windows.Forms.PictureBox();
            this.miniclick = new System.Windows.Forms.PictureBox();
            this.browsebtn = new System.Windows.Forms.Button();
            this.MessageOut = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.exitclick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniclick)).BeginInit();
            this.SuspendLayout();
            // 
            // exitclick
            // 
            this.exitclick.BackColor = System.Drawing.Color.Transparent;
            this.exitclick.Image = ((System.Drawing.Image)(resources.GetObject("exitclick.Image")));
            this.exitclick.Location = new System.Drawing.Point(575, 12);
            this.exitclick.Name = "exitclick";
            this.exitclick.Size = new System.Drawing.Size(31, 31);
            this.exitclick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitclick.TabIndex = 0;
            this.exitclick.TabStop = false;
            this.exitclick.Click += new System.EventHandler(this.exitclick_Click);
            this.exitclick.MouseLeave += new System.EventHandler(this.exitclick_MouseLeave);
            this.exitclick.MouseHover += new System.EventHandler(this.exitclick_MouseHover);
            // 
            // miniclick
            // 
            this.miniclick.BackColor = System.Drawing.Color.Transparent;
            this.miniclick.Image = ((System.Drawing.Image)(resources.GetObject("miniclick.Image")));
            this.miniclick.Location = new System.Drawing.Point(528, 22);
            this.miniclick.Name = "miniclick";
            this.miniclick.Size = new System.Drawing.Size(41, 10);
            this.miniclick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.miniclick.TabIndex = 1;
            this.miniclick.TabStop = false;
            this.miniclick.Click += new System.EventHandler(this.miniclick_Click);
            this.miniclick.MouseLeave += new System.EventHandler(this.miniclick_MouseLeave);
            this.miniclick.MouseHover += new System.EventHandler(this.miniclick_MouseHover);
            // 
            // browsebtn
            // 
            this.browsebtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.browsebtn.FlatAppearance.BorderSize = 0;
            this.browsebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browsebtn.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browsebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.browsebtn.Location = new System.Drawing.Point(241, 302);
            this.browsebtn.Name = "browsebtn";
            this.browsebtn.Size = new System.Drawing.Size(107, 48);
            this.browsebtn.TabIndex = 2;
            this.browsebtn.Text = "OK";
            this.browsebtn.UseVisualStyleBackColor = false;
            this.browsebtn.Click += new System.EventHandler(this.browsebtn_Click);
            // 
            // MessageOut
            // 
            this.MessageOut.AutoSize = true;
            this.MessageOut.BackColor = System.Drawing.Color.Teal;
            this.MessageOut.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MessageOut.Location = new System.Drawing.Point(207, 96);
            this.MessageOut.Name = "MessageOut";
            this.MessageOut.Size = new System.Drawing.Size(183, 72);
            this.MessageOut.TabIndex = 3;
            this.MessageOut.Text = "DONE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(75, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Remember to fix passwords location in \'info.csv\'";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(618, 378);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MessageOut);
            this.Controls.Add(this.browsebtn);
            this.Controls.Add(this.miniclick);
            this.Controls.Add(this.exitclick);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.exitclick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniclick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox exitclick;
        private System.Windows.Forms.PictureBox miniclick;
        private System.Windows.Forms.Button browsebtn;
        private System.Windows.Forms.Label MessageOut;
        private System.Windows.Forms.Label label1;
    }
}