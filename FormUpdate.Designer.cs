namespace MarmaraKargo
{
    partial class FormUpdate
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
            this.labelShipment = new System.Windows.Forms.Label();
            this.comboBoxShipment = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelStatusInfo = new System.Windows.Forms.Label();
            this.labelLast = new System.Windows.Forms.Label();
            this.comboBoxLast = new System.Windows.Forms.ComboBox();
            this.labelRec = new System.Windows.Forms.Label();
            this.comboBoxRec = new System.Windows.Forms.ComboBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxExtra = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelShipment
            // 
            this.labelShipment.AutoSize = true;
            this.labelShipment.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShipment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.labelShipment.Location = new System.Drawing.Point(61, 39);
            this.labelShipment.Name = "labelShipment";
            this.labelShipment.Size = new System.Drawing.Size(135, 25);
            this.labelShipment.TabIndex = 3;
            this.labelShipment.Text = "Kargo Seçiniz :";
            this.labelShipment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxShipment
            // 
            this.comboBoxShipment.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxShipment.FormattingEnabled = true;
            this.comboBoxShipment.Location = new System.Drawing.Point(230, 36);
            this.comboBoxShipment.Name = "comboBoxShipment";
            this.comboBoxShipment.Size = new System.Drawing.Size(188, 33);
            this.comboBoxShipment.TabIndex = 4;
            this.comboBoxShipment.SelectedIndexChanged += new System.EventHandler(this.comboBoxShipment_SelectedIndexChanged);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.labelStatus.Location = new System.Drawing.Point(51, 101);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(145, 25);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "Kargo Durumu :";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStatusInfo
            // 
            this.labelStatusInfo.AutoSize = true;
            this.labelStatusInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.labelStatusInfo.Location = new System.Drawing.Point(225, 101);
            this.labelStatusInfo.Name = "labelStatusInfo";
            this.labelStatusInfo.Size = new System.Drawing.Size(20, 25);
            this.labelStatusInfo.TabIndex = 6;
            this.labelStatusInfo.Text = "-";
            this.labelStatusInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLast
            // 
            this.labelLast.AutoSize = true;
            this.labelLast.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.labelLast.Location = new System.Drawing.Point(80, 165);
            this.labelLast.Name = "labelLast";
            this.labelLast.Size = new System.Drawing.Size(116, 25);
            this.labelLast.TabIndex = 7;
            this.labelLast.Text = "Son Durum :";
            this.labelLast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxLast
            // 
            this.comboBoxLast.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLast.FormattingEnabled = true;
            this.comboBoxLast.Location = new System.Drawing.Point(230, 162);
            this.comboBoxLast.Name = "comboBoxLast";
            this.comboBoxLast.Size = new System.Drawing.Size(188, 33);
            this.comboBoxLast.TabIndex = 8;
            // 
            // labelRec
            // 
            this.labelRec.AutoSize = true;
            this.labelRec.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.labelRec.Location = new System.Drawing.Point(90, 228);
            this.labelRec.Name = "labelRec";
            this.labelRec.Size = new System.Drawing.Size(106, 25);
            this.labelRec.TabIndex = 9;
            this.labelRec.Text = "İlgili Birim :";
            this.labelRec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxRec
            // 
            this.comboBoxRec.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRec.FormattingEnabled = true;
            this.comboBoxRec.Location = new System.Drawing.Point(230, 220);
            this.comboBoxRec.Name = "comboBoxRec";
            this.comboBoxRec.Size = new System.Drawing.Size(188, 33);
            this.comboBoxRec.TabIndex = 10;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.buttonBack.Location = new System.Drawing.Point(390, 420);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(80, 30);
            this.buttonBack.TabIndex = 11;
            this.buttonBack.Text = "Geri Dön";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.label1.Location = new System.Drawing.Point(90, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Eksta Bilgi :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxExtra
            // 
            this.textBoxExtra.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExtra.Location = new System.Drawing.Point(230, 274);
            this.textBoxExtra.Name = "textBoxExtra";
            this.textBoxExtra.Size = new System.Drawing.Size(188, 33);
            this.textBoxExtra.TabIndex = 13;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            this.buttonSubmit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.buttonSubmit.Location = new System.Drawing.Point(123, 349);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(233, 61);
            this.buttonSubmit.TabIndex = 14;
            this.buttonSubmit.Text = "ONAYLA";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // FormUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxExtra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.comboBoxRec);
            this.Controls.Add(this.labelRec);
            this.Controls.Add(this.comboBoxLast);
            this.Controls.Add(this.labelLast);
            this.Controls.Add(this.labelStatusInfo);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.comboBoxShipment);
            this.Controls.Add(this.labelShipment);
            this.Name = "FormUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BİLGİ GÜNCELLEME";
            this.Load += new System.EventHandler(this.FormUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelShipment;
        private System.Windows.Forms.ComboBox comboBoxShipment;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelStatusInfo;
        private System.Windows.Forms.Label labelLast;
        private System.Windows.Forms.ComboBox comboBoxLast;
        private System.Windows.Forms.Label labelRec;
        private System.Windows.Forms.ComboBox comboBoxRec;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxExtra;
        private System.Windows.Forms.Button buttonSubmit;
    }
}