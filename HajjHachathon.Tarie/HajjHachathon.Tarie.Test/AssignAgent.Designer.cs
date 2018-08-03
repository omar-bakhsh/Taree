namespace HajjHachathon.Tarie.Test
{
    partial class AssignAgent
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtAssigned = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dat = new System.Windows.Forms.DateTimePicker();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labAssigned = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Assign Agent";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAssigned
            // 
            this.txtAssigned.Enabled = false;
            this.txtAssigned.Location = new System.Drawing.Point(110, 191);
            this.txtAssigned.Name = "txtAssigned";
            this.txtAssigned.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAssigned.Size = new System.Drawing.Size(260, 20);
            this.txtAssigned.TabIndex = 1;
            this.txtAssigned.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(53, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id";
            // 
            // dat
            // 
            this.dat.Location = new System.Drawing.Point(261, 13);
            this.dat.Name = "dat";
            this.dat.Size = new System.Drawing.Size(200, 20);
            this.dat.TabIndex = 4;
            // 
            // txtLong
            // 
            this.txtLong.Location = new System.Drawing.Point(104, 80);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(121, 20);
            this.txtLong.TabIndex = 5;
            // 
            // txtLat
            // 
            this.txtLat.Location = new System.Drawing.Point(306, 80);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(121, 20);
            this.txtLat.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Longitude";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Latidude";
            // 
            // labAssigned
            // 
            this.labAssigned.AutoSize = true;
            this.labAssigned.Location = new System.Drawing.Point(12, 194);
            this.labAssigned.Name = "labAssigned";
            this.labAssigned.Size = new System.Drawing.Size(92, 13);
            this.labAssigned.TabIndex = 9;
            this.labAssigned.Text = "Case Assigned To";
            // 
            // AssignAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 261);
            this.Controls.Add(this.labAssigned);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLat);
            this.Controls.Add(this.txtLong);
            this.Controls.Add(this.dat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtAssigned);
            this.Controls.Add(this.button1);
            this.Name = "AssignAgent";
            this.Text = "AssignAgent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAssigned;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dat;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labAssigned;
    }
}