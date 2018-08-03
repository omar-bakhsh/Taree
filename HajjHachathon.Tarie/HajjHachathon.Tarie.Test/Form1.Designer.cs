namespace HajjHachathon.Tarie.Test
{
    partial class Emergency
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
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPicturePath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtLong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtLat = new System.Windows.Forms.TextBox();
            this.IsEmergency = new System.Windows.Forms.CheckBox();
            this.IsConfirmed = new System.Windows.Forms.CheckBox();
            this.IsCaseAssigned = new System.Windows.Forms.CheckBox();
            this.BtnNew = new System.Windows.Forms.Button();
            this.WillRetrieve = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(152, 14);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(100, 20);
            this.TxtId.TabIndex = 1;
            this.TxtId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtId_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Path";
            // 
            // TxtPicturePath
            // 
            this.TxtPicturePath.Location = new System.Drawing.Point(152, 104);
            this.TxtPicturePath.Name = "TxtPicturePath";
            this.TxtPicturePath.Size = new System.Drawing.Size(100, 20);
            this.TxtPicturePath.TabIndex = 2;
            this.TxtPicturePath.Leave += new System.EventHandler(this.TxtPicturePath_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Longitude";
            // 
            // TxtLong
            // 
            this.TxtLong.Location = new System.Drawing.Point(152, 162);
            this.TxtLong.Name = "TxtLong";
            this.TxtLong.Size = new System.Drawing.Size(100, 20);
            this.TxtLong.TabIndex = 3;
            this.TxtLong.Leave += new System.EventHandler(this.TxtLong_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Latidude";
            // 
            // TxtLat
            // 
            this.TxtLat.Location = new System.Drawing.Point(152, 216);
            this.TxtLat.Name = "TxtLat";
            this.TxtLat.Size = new System.Drawing.Size(100, 20);
            this.TxtLat.TabIndex = 4;
            this.TxtLat.Leave += new System.EventHandler(this.TxtLat_Leave);
            // 
            // IsEmergency
            // 
            this.IsEmergency.AutoSize = true;
            this.IsEmergency.Location = new System.Drawing.Point(97, 57);
            this.IsEmergency.Name = "IsEmergency";
            this.IsEmergency.Size = new System.Drawing.Size(79, 17);
            this.IsEmergency.TabIndex = 0;
            this.IsEmergency.Text = "Emergency";
            this.IsEmergency.UseVisualStyleBackColor = true;
            this.IsEmergency.CheckedChanged += new System.EventHandler(this.IsEmergency_CheckedChanged);
            // 
            // IsConfirmed
            // 
            this.IsConfirmed.AutoSize = true;
            this.IsConfirmed.Location = new System.Drawing.Point(209, 57);
            this.IsConfirmed.Name = "IsConfirmed";
            this.IsConfirmed.Size = new System.Drawing.Size(75, 17);
            this.IsConfirmed.TabIndex = 1;
            this.IsConfirmed.Text = "Confirmed";
            this.IsConfirmed.UseVisualStyleBackColor = true;
            this.IsConfirmed.CheckedChanged += new System.EventHandler(this.IsConfirmed_CheckedChanged);
            // 
            // IsCaseAssigned
            // 
            this.IsCaseAssigned.AutoSize = true;
            this.IsCaseAssigned.Location = new System.Drawing.Point(152, 275);
            this.IsCaseAssigned.Name = "IsCaseAssigned";
            this.IsCaseAssigned.Size = new System.Drawing.Size(96, 17);
            this.IsCaseAssigned.TabIndex = 5;
            this.IsCaseAssigned.Text = "Case Assigned";
            this.IsCaseAssigned.UseVisualStyleBackColor = true;
            this.IsCaseAssigned.CheckedChanged += new System.EventHandler(this.IsCaseAssigned_CheckedChanged);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(12, 70);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(44, 38);
            this.BtnNew.TabIndex = 18;
            this.BtnNew.Text = "New Case";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // WillRetrieve
            // 
            this.WillRetrieve.AutoSize = true;
            this.WillRetrieve.Location = new System.Drawing.Point(117, 18);
            this.WillRetrieve.Name = "WillRetrieve";
            this.WillRetrieve.Size = new System.Drawing.Size(15, 14);
            this.WillRetrieve.TabIndex = 19;
            this.WillRetrieve.UseVisualStyleBackColor = true;
            this.WillRetrieve.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Emergency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 310);
            this.Controls.Add(this.WillRetrieve);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.IsCaseAssigned);
            this.Controls.Add(this.IsConfirmed);
            this.Controls.Add(this.IsEmergency);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtLat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtLong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtPicturePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtId);
            this.Name = "Emergency";
            this.Text = "Emergency";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPicturePath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtLong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtLat;
        private System.Windows.Forms.CheckBox IsEmergency;
        private System.Windows.Forms.CheckBox IsConfirmed;
        private System.Windows.Forms.CheckBox IsCaseAssigned;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.CheckBox WillRetrieve;
    }
}

