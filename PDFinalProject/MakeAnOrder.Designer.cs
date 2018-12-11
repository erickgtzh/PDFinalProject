namespace PDFinalProject
{
    partial class MakeAnOrder
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
            this.lbl_frozen_veg = new System.Windows.Forms.Label();
            this.lbl_sodas = new System.Windows.Forms.Label();
            this.lbl_bread = new System.Windows.Forms.Label();
            this.textBox_frozen_veg = new System.Windows.Forms.TextBox();
            this.textBox_sodas = new System.Windows.Forms.TextBox();
            this.textBox_bread = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_frozen_veg
            // 
            this.lbl_frozen_veg.AutoSize = true;
            this.lbl_frozen_veg.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_frozen_veg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_frozen_veg.Location = new System.Drawing.Point(46, 54);
            this.lbl_frozen_veg.Name = "lbl_frozen_veg";
            this.lbl_frozen_veg.Size = new System.Drawing.Size(138, 21);
            this.lbl_frozen_veg.TabIndex = 0;
            this.lbl_frozen_veg.Text = "Frozen vegetables:";
            // 
            // lbl_sodas
            // 
            this.lbl_sodas.AutoSize = true;
            this.lbl_sodas.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sodas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_sodas.Location = new System.Drawing.Point(46, 128);
            this.lbl_sodas.Name = "lbl_sodas";
            this.lbl_sodas.Size = new System.Drawing.Size(55, 21);
            this.lbl_sodas.TabIndex = 2;
            this.lbl_sodas.Text = "Sodas:";
            // 
            // lbl_bread
            // 
            this.lbl_bread.AutoSize = true;
            this.lbl_bread.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bread.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_bread.Location = new System.Drawing.Point(46, 205);
            this.lbl_bread.Name = "lbl_bread";
            this.lbl_bread.Size = new System.Drawing.Size(53, 21);
            this.lbl_bread.TabIndex = 4;
            this.lbl_bread.Text = "Bread:";
            // 
            // textBox_frozen_veg
            // 
            this.textBox_frozen_veg.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_frozen_veg.Location = new System.Drawing.Point(233, 51);
            this.textBox_frozen_veg.Name = "textBox_frozen_veg";
            this.textBox_frozen_veg.Size = new System.Drawing.Size(100, 28);
            this.textBox_frozen_veg.TabIndex = 1;
            // 
            // textBox_sodas
            // 
            this.textBox_sodas.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sodas.Location = new System.Drawing.Point(233, 125);
            this.textBox_sodas.Name = "textBox_sodas";
            this.textBox_sodas.Size = new System.Drawing.Size(100, 28);
            this.textBox_sodas.TabIndex = 3;
            // 
            // textBox_bread
            // 
            this.textBox_bread.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_bread.Location = new System.Drawing.Point(233, 202);
            this.textBox_bread.Name = "textBox_bread";
            this.textBox_bread.Size = new System.Drawing.Size(100, 28);
            this.textBox_bread.TabIndex = 5;
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_save.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_save.Location = new System.Drawing.Point(244, 275);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(89, 47);
            this.button_save.TabIndex = 6;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // MakeAnOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(390, 359);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.textBox_bread);
            this.Controls.Add(this.textBox_sodas);
            this.Controls.Add(this.textBox_frozen_veg);
            this.Controls.Add(this.lbl_bread);
            this.Controls.Add(this.lbl_sodas);
            this.Controls.Add(this.lbl_frozen_veg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MakeAnOrder";
            this.Text = "MakeAnOrder";
            this.Load += new System.EventHandler(this.MakeAnOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_frozen_veg;
        private System.Windows.Forms.Label lbl_sodas;
        private System.Windows.Forms.Label lbl_bread;
        private System.Windows.Forms.TextBox textBox_frozen_veg;
        private System.Windows.Forms.TextBox textBox_sodas;
        private System.Windows.Forms.TextBox textBox_bread;
        private System.Windows.Forms.Button button_save;
    }
}