namespace MarmaraKargo
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonContact = new System.Windows.Forms.Button();
            this.buttonTrack = new System.Windows.Forms.Button();
            this.buttonBranchLogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonContact
            // 
            this.buttonContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            this.buttonContact.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.buttonContact.Location = new System.Drawing.Point(117, 279);
            this.buttonContact.Name = "buttonContact";
            this.buttonContact.Size = new System.Drawing.Size(250, 100);
            this.buttonContact.TabIndex = 2;
            this.buttonContact.Text = "İLETİŞİM";
            this.buttonContact.UseVisualStyleBackColor = false;
            this.buttonContact.Click += new System.EventHandler(this.buttonContact_Click);
            // 
            // buttonTrack
            // 
            this.buttonTrack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            this.buttonTrack.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTrack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.buttonTrack.Location = new System.Drawing.Point(117, 173);
            this.buttonTrack.Name = "buttonTrack";
            this.buttonTrack.Size = new System.Drawing.Size(250, 100);
            this.buttonTrack.TabIndex = 1;
            this.buttonTrack.Text = "KARGO TAKİP";
            this.buttonTrack.UseVisualStyleBackColor = false;
            this.buttonTrack.Click += new System.EventHandler(this.buttonTrack_Click);
            // 
            // buttonBranchLogIn
            // 
            this.buttonBranchLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            this.buttonBranchLogIn.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBranchLogIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.buttonBranchLogIn.Location = new System.Drawing.Point(117, 67);
            this.buttonBranchLogIn.Name = "buttonBranchLogIn";
            this.buttonBranchLogIn.Size = new System.Drawing.Size(250, 100);
            this.buttonBranchLogIn.TabIndex = 0;
            this.buttonBranchLogIn.Text = "ŞUBE GİRİŞ";
            this.buttonBranchLogIn.UseVisualStyleBackColor = false;
            this.buttonBranchLogIn.Click += new System.EventHandler(this.buttonBranchLogIn_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.buttonBranchLogIn);
            this.Controls.Add(this.buttonContact);
            this.Controls.Add(this.buttonTrack);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MARMARA KARGO";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonContact;
        private System.Windows.Forms.Button buttonTrack;
        private System.Windows.Forms.Button buttonBranchLogIn;
    }
}

