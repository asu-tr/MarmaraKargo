namespace MarmaraKargo
{
    partial class FormDashboard
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
            this.buttonShipmentUpdate = new System.Windows.Forms.Button();
            this.buttonNewShipment = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonShipmentUpdate
            // 
            this.buttonShipmentUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            this.buttonShipmentUpdate.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShipmentUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.buttonShipmentUpdate.Location = new System.Drawing.Point(125, 237);
            this.buttonShipmentUpdate.Name = "buttonShipmentUpdate";
            this.buttonShipmentUpdate.Size = new System.Drawing.Size(250, 100);
            this.buttonShipmentUpdate.TabIndex = 1;
            this.buttonShipmentUpdate.Text = "Kargo Güncelle";
            this.buttonShipmentUpdate.UseVisualStyleBackColor = false;
            // 
            // buttonNewShipment
            // 
            this.buttonNewShipment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            this.buttonNewShipment.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewShipment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.buttonNewShipment.Location = new System.Drawing.Point(125, 93);
            this.buttonNewShipment.Name = "buttonNewShipment";
            this.buttonNewShipment.Size = new System.Drawing.Size(250, 100);
            this.buttonNewShipment.TabIndex = 2;
            this.buttonNewShipment.Text = "Yeni Kargo";
            this.buttonNewShipment.UseVisualStyleBackColor = false;
            this.buttonNewShipment.Click += new System.EventHandler(this.buttonNewShipment_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.labelName.Location = new System.Drawing.Point(12, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(41, 17);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "label1";
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            this.buttonLogOut.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.buttonLogOut.Location = new System.Drawing.Point(349, 12);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(123, 28);
            this.buttonLogOut.TabIndex = 4;
            this.buttonLogOut.Text = "OTURUMU KAPAT";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonNewShipment);
            this.Controls.Add(this.buttonShipmentUpdate);
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDashboard";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShipmentUpdate;
        private System.Windows.Forms.Button buttonNewShipment;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonLogOut;
    }
}