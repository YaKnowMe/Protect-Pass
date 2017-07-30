namespace Protect_Pass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.browsebtn = new System.Windows.Forms.Button();
            this.directorytofilesform = new System.Windows.Forms.RichTextBox();
            this.prtcBTN = new System.Windows.Forms.Button();
            this.exitBTN = new System.Windows.Forms.PictureBox();
            this.minimalizebtnpic = new System.Windows.Forms.PictureBox();
            this.MessageOut = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mailtobtn = new System.Windows.Forms.Button();
            this.rPassForm = new RichPassword();
            ((System.ComponentModel.ISupportInitialize)(this.exitBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimalizebtnpic)).BeginInit();
            this.SuspendLayout();
            // 
            // browsebtn
            // 
            this.browsebtn.BackColor = System.Drawing.Color.SeaGreen;
            this.browsebtn.FlatAppearance.BorderSize = 0;
            this.browsebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browsebtn.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browsebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.browsebtn.Location = new System.Drawing.Point(306, 205);
            this.browsebtn.Name = "browsebtn";
            this.browsebtn.Size = new System.Drawing.Size(271, 48);
            this.browsebtn.TabIndex = 1;
            this.browsebtn.Text = "BROWSE";
            this.browsebtn.UseVisualStyleBackColor = false;
            this.browsebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // directorytofilesform
            // 
            this.directorytofilesform.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.directorytofilesform.Font = new System.Drawing.Font("Segoe UI Light", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directorytofilesform.ForeColor = System.Drawing.Color.Gray;
            this.directorytofilesform.Location = new System.Drawing.Point(38, 114);
            this.directorytofilesform.Name = "directorytofilesform";
            this.directorytofilesform.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.directorytofilesform.Size = new System.Drawing.Size(828, 68);
            this.directorytofilesform.TabIndex = 3;
            this.directorytofilesform.Text = "";
            this.directorytofilesform.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // prtcBTN
            // 
            this.prtcBTN.BackColor = System.Drawing.Color.SeaGreen;
            this.prtcBTN.FlatAppearance.BorderSize = 0;
            this.prtcBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prtcBTN.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prtcBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.prtcBTN.Location = new System.Drawing.Point(306, 437);
            this.prtcBTN.Name = "prtcBTN";
            this.prtcBTN.Size = new System.Drawing.Size(271, 48);
            this.prtcBTN.TabIndex = 4;
            this.prtcBTN.Text = "PROTECT";
            this.prtcBTN.UseVisualStyleBackColor = false;
            this.prtcBTN.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // exitBTN
            // 
            this.exitBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBTN.BackColor = System.Drawing.Color.Transparent;
            this.exitBTN.Image = ((System.Drawing.Image)(resources.GetObject("exitBTN.Image")));
            this.exitBTN.Location = new System.Drawing.Point(854, 12);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(38, 37);
            this.exitBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitBTN.TabIndex = 5;
            this.exitBTN.TabStop = false;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            this.exitBTN.MouseLeave += new System.EventHandler(this.exitBTN_MouseLeave);
            this.exitBTN.MouseHover += new System.EventHandler(this.exitBTN_MouseHover);
            // 
            // minimalizebtnpic
            // 
            this.minimalizebtnpic.BackColor = System.Drawing.Color.Transparent;
            this.minimalizebtnpic.Image = ((System.Drawing.Image)(resources.GetObject("minimalizebtnpic.Image")));
            this.minimalizebtnpic.Location = new System.Drawing.Point(786, 26);
            this.minimalizebtnpic.Name = "minimalizebtnpic";
            this.minimalizebtnpic.Size = new System.Drawing.Size(48, 10);
            this.minimalizebtnpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.minimalizebtnpic.TabIndex = 6;
            this.minimalizebtnpic.TabStop = false;
            this.minimalizebtnpic.Click += new System.EventHandler(this.pictureBox1_Click);
            this.minimalizebtnpic.MouseLeave += new System.EventHandler(this.minimalizebtnpic_MouseLeave);
            this.minimalizebtnpic.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // MessageOut
            // 
            this.MessageOut.AutoSize = true;
            this.MessageOut.BackColor = System.Drawing.Color.Transparent;
            this.MessageOut.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MessageOut.Location = new System.Drawing.Point(203, 273);
            this.MessageOut.Name = "MessageOut";
            this.MessageOut.Size = new System.Drawing.Size(490, 72);
            this.MessageOut.TabIndex = 8;
            this.MessageOut.Text = "PASSWORD BASE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(277, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 72);
            this.label1.TabIndex = 9;
            this.label1.Text = "DIRECTORY:";
            // 
            // mailtobtn
            // 
            this.mailtobtn.BackColor = System.Drawing.Color.SeaGreen;
            this.mailtobtn.FlatAppearance.BorderSize = 0;
            this.mailtobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mailtobtn.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailtobtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mailtobtn.Location = new System.Drawing.Point(-2, 224);
            this.mailtobtn.Name = "mailtobtn";
            this.mailtobtn.Size = new System.Drawing.Size(35, 48);
            this.mailtobtn.TabIndex = 10;
            this.mailtobtn.Text = "@";
            this.mailtobtn.UseVisualStyleBackColor = false;
            this.mailtobtn.Click += new System.EventHandler(this.mailtobtn_Click);
            // 
            // rPassForm
            // 
            this.rPassForm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rPassForm.Font = new System.Drawing.Font("Segoe UI Light", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rPassForm.ForeColor = System.Drawing.Color.Gray;
            this.rPassForm.Location = new System.Drawing.Point(38, 348);
            this.rPassForm.Name = "rPassForm";
            this.rPassForm.Size = new System.Drawing.Size(828, 68);
            this.rPassForm.TabIndex = 11;
            this.rPassForm.Text = "";
            this.rPassForm.TextChanged += new System.EventHandler(this.rPassForm_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(904, 567);
            this.Controls.Add(this.rPassForm);
            this.Controls.Add(this.mailtobtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MessageOut);
            this.Controls.Add(this.minimalizebtnpic);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.prtcBTN);
            this.Controls.Add(this.directorytofilesform);
            this.Controls.Add(this.browsebtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Protect Pass v0.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exitBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimalizebtnpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button browsebtn;
        private System.Windows.Forms.RichTextBox directorytofilesform;
        private System.Windows.Forms.Button prtcBTN;
        private System.Windows.Forms.PictureBox exitBTN;
        private System.Windows.Forms.PictureBox minimalizebtnpic;
        private System.Windows.Forms.Label MessageOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mailtobtn;
        private RichPassword rPassForm;
    }
}

