namespace PDFinalProject
{
    partial class Transportation
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
            this.label_frozen_veg_transp = new System.Windows.Forms.Label();
            this.label_sodas_transp = new System.Windows.Forms.Label();
            this.label_bread_transp = new System.Windows.Forms.Label();
            this.textBox_frozen_veg_transp = new System.Windows.Forms.TextBox();
            this.textBox_sodas_transp = new System.Windows.Forms.TextBox();
            this.textBox_bread_transp = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_frozen_veg_transp
            // 
            this.label_frozen_veg_transp.AutoSize = true;
            this.label_frozen_veg_transp.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.label_frozen_veg_transp.Location = new System.Drawing.Point(61, 59);
            this.label_frozen_veg_transp.Name = "label_frozen_veg_transp";
            this.label_frozen_veg_transp.Size = new System.Drawing.Size(182, 21);
            this.label_frozen_veg_transp.TabIndex = 0;
            this.label_frozen_veg_transp.Text = "Frozen vegetables buses:";
            // 
            // label_sodas_transp
            // 
            this.label_sodas_transp.AutoSize = true;
            this.label_sodas_transp.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.label_sodas_transp.Location = new System.Drawing.Point(61, 140);
            this.label_sodas_transp.Name = "label_sodas_transp";
            this.label_sodas_transp.Size = new System.Drawing.Size(158, 21);
            this.label_sodas_transp.TabIndex = 2;
            this.label_sodas_transp.Text = "Sodas transportation:";
            // 
            // label_bread_transp
            // 
            this.label_bread_transp.AutoSize = true;
            this.label_bread_transp.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.label_bread_transp.Location = new System.Drawing.Point(61, 242);
            this.label_bread_transp.Name = "label_bread_transp";
            this.label_bread_transp.Size = new System.Drawing.Size(97, 21);
            this.label_bread_transp.TabIndex = 4;
            this.label_bread_transp.Text = "Bread buses:";
            // 
            // textBox_frozen_veg_transp
            // 
            this.textBox_frozen_veg_transp.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.textBox_frozen_veg_transp.Location = new System.Drawing.Point(315, 56);
            this.textBox_frozen_veg_transp.Name = "textBox_frozen_veg_transp";
            this.textBox_frozen_veg_transp.Size = new System.Drawing.Size(100, 28);
            this.textBox_frozen_veg_transp.TabIndex = 1;
            // 
            // textBox_sodas_transp
            // 
            this.textBox_sodas_transp.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.textBox_sodas_transp.Location = new System.Drawing.Point(315, 137);
            this.textBox_sodas_transp.Name = "textBox_sodas_transp";
            this.textBox_sodas_transp.Size = new System.Drawing.Size(100, 28);
            this.textBox_sodas_transp.TabIndex = 3;
            // 
            // textBox_bread_transp
            // 
            this.textBox_bread_transp.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.textBox_bread_transp.Location = new System.Drawing.Point(315, 239);
            this.textBox_bread_transp.Name = "textBox_bread_transp";
            this.textBox_bread_transp.Size = new System.Drawing.Size(100, 28);
            this.textBox_bread_transp.TabIndex = 5;
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.button_save.Location = new System.Drawing.Point(326, 319);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(89, 44);
            this.button_save.TabIndex = 6;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            // 
            // Transportation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 418);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.textBox_bread_transp);
            this.Controls.Add(this.textBox_sodas_transp);
            this.Controls.Add(this.textBox_frozen_veg_transp);
            this.Controls.Add(this.label_bread_transp);
            this.Controls.Add(this.label_sodas_transp);
            this.Controls.Add(this.label_frozen_veg_transp);
            this.Name = "Transportation";
            this.Text = "Transportation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_frozen_veg_transp;
        private System.Windows.Forms.Label label_sodas_transp;
        private System.Windows.Forms.Label label_bread_transp;
        private System.Windows.Forms.TextBox textBox_frozen_veg_transp;
        private System.Windows.Forms.TextBox textBox_sodas_transp;
        private System.Windows.Forms.TextBox textBox_bread_transp;
        private System.Windows.Forms.Button button_save;
    }
}