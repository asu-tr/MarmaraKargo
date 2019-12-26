namespace MarmaraKargo
{
    partial class FormTrack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrack));
            this.labelTrackNo = new System.Windows.Forms.Label();
            this.textBoxTrack = new System.Windows.Forms.TextBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.dataGridViewTrack = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTrackNo
            // 
            this.labelTrackNo.AutoSize = true;
            this.labelTrackNo.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrackNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.labelTrackNo.Location = new System.Drawing.Point(31, 31);
            this.labelTrackNo.Name = "labelTrackNo";
            this.labelTrackNo.Size = new System.Drawing.Size(165, 30);
            this.labelTrackNo.TabIndex = 0;
            this.labelTrackNo.Text = "Takip Numarası:";
            // 
            // textBoxTrack
            // 
            this.textBoxTrack.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTrack.Location = new System.Drawing.Point(237, 28);
            this.textBoxTrack.Name = "textBoxTrack";
            this.textBoxTrack.Size = new System.Drawing.Size(197, 35);
            this.textBoxTrack.TabIndex = 1;
            // 
            // buttonCheck
            // 
            this.buttonCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            this.buttonCheck.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.buttonCheck.Location = new System.Drawing.Point(309, 88);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(125, 38);
            this.buttonCheck.TabIndex = 2;
            this.buttonCheck.Text = "SORGULA";
            this.buttonCheck.UseVisualStyleBackColor = false;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.buttonBack.Location = new System.Drawing.Point(390, 420);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(80, 30);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "Geri Dön";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // dataGridViewTrack
            // 
            this.dataGridViewTrack.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewTrack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrack.Location = new System.Drawing.Point(36, 151);
            this.dataGridViewTrack.Name = "dataGridViewTrack";
            this.dataGridViewTrack.Size = new System.Drawing.Size(398, 243);
            this.dataGridViewTrack.TabIndex = 7;
            // 
            // FormTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.dataGridViewTrack);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.textBoxTrack);
            this.Controls.Add(this.labelTrackNo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTrack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KARGO TAKİP";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTrackNo;
        private System.Windows.Forms.TextBox textBoxTrack;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DataGridView dataGridViewTrack;
    }
}