using System.Windows.Forms;

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
            this.button_start_simulation = new System.Windows.Forms.Button();
            this.comboBox_frozen_veg_buses = new System.Windows.Forms.ComboBox();
            this.comboBox_sodas_buses = new System.Windows.Forms.ComboBox();
            this.comboBox_bread_buses = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_frozen_veg_transp
            // 
            this.label_frozen_veg_transp.AutoSize = true;
            this.label_frozen_veg_transp.BackColor = System.Drawing.SystemColors.Highlight;
            this.label_frozen_veg_transp.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.label_frozen_veg_transp.ForeColor = System.Drawing.SystemColors.Control;
            this.label_frozen_veg_transp.Location = new System.Drawing.Point(61, 59);
            this.label_frozen_veg_transp.Name = "label_frozen_veg_transp";
            this.label_frozen_veg_transp.Size = new System.Drawing.Size(182, 21);
            this.label_frozen_veg_transp.TabIndex = 0;
            this.label_frozen_veg_transp.Text = "Frozen vegetables buses:";
            // 
            // label_sodas_transp
            // 
            this.label_sodas_transp.AutoSize = true;
            this.label_sodas_transp.BackColor = System.Drawing.SystemColors.Highlight;
            this.label_sodas_transp.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.label_sodas_transp.ForeColor = System.Drawing.SystemColors.Control;
            this.label_sodas_transp.Location = new System.Drawing.Point(61, 140);
            this.label_sodas_transp.Name = "label_sodas_transp";
            this.label_sodas_transp.Size = new System.Drawing.Size(158, 21);
            this.label_sodas_transp.TabIndex = 2;
            this.label_sodas_transp.Text = "Sodas transportation:";
            // 
            // label_bread_transp
            // 
            this.label_bread_transp.AutoSize = true;
            this.label_bread_transp.BackColor = System.Drawing.SystemColors.Highlight;
            this.label_bread_transp.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.label_bread_transp.ForeColor = System.Drawing.SystemColors.Control;
            this.label_bread_transp.Location = new System.Drawing.Point(61, 242);
            this.label_bread_transp.Name = "label_bread_transp";
            this.label_bread_transp.Size = new System.Drawing.Size(97, 21);
            this.label_bread_transp.TabIndex = 4;
            this.label_bread_transp.Text = "Bread buses:";
            // 
            // button_start_simulation
            // 
            this.button_start_simulation.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_start_simulation.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.button_start_simulation.ForeColor = System.Drawing.SystemColors.Control;
            this.button_start_simulation.Location = new System.Drawing.Point(315, 324);
            this.button_start_simulation.Name = "button_start_simulation";
            this.button_start_simulation.Size = new System.Drawing.Size(110, 50);
            this.button_start_simulation.TabIndex = 6;
            this.button_start_simulation.Text = "Start Simulation";
            this.button_start_simulation.UseVisualStyleBackColor = false;
            this.button_start_simulation.Click += new System.EventHandler(this.button_save_Click);
            // 
            // comboBox_frozen_veg_buses
            // 
            this.comboBox_frozen_veg_buses.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox_frozen_veg_buses.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboBox_frozen_veg_buses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_frozen_veg_buses.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.comboBox_frozen_veg_buses.ForeColor = System.Drawing.SystemColors.Control;
            this.comboBox_frozen_veg_buses.FormattingEnabled = true;
            this.comboBox_frozen_veg_buses.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.comboBox_frozen_veg_buses.Location = new System.Drawing.Point(315, 56);
            this.comboBox_frozen_veg_buses.Name = "comboBox_frozen_veg_buses";
            this.comboBox_frozen_veg_buses.Size = new System.Drawing.Size(121, 29);
            this.comboBox_frozen_veg_buses.TabIndex = 1;
            this.comboBox_frozen_veg_buses.Text = "0";
            // 
            // comboBox_sodas_buses
            // 
            this.comboBox_sodas_buses.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox_sodas_buses.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboBox_sodas_buses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_sodas_buses.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.comboBox_sodas_buses.ForeColor = System.Drawing.SystemColors.Control;
            this.comboBox_sodas_buses.FormattingEnabled = true;
            this.comboBox_sodas_buses.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.comboBox_sodas_buses.Location = new System.Drawing.Point(315, 137);
            this.comboBox_sodas_buses.Name = "comboBox_sodas_buses";
            this.comboBox_sodas_buses.Size = new System.Drawing.Size(121, 29);
            this.comboBox_sodas_buses.TabIndex = 3;
            this.comboBox_sodas_buses.Text = "0";
            // 
            // comboBox_bread_buses
            // 
            this.comboBox_bread_buses.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox_bread_buses.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboBox_bread_buses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_bread_buses.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.comboBox_bread_buses.ForeColor = System.Drawing.SystemColors.Control;
            this.comboBox_bread_buses.FormattingEnabled = true;
            this.comboBox_bread_buses.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.comboBox_bread_buses.Location = new System.Drawing.Point(315, 239);
            this.comboBox_bread_buses.Name = "comboBox_bread_buses";
            this.comboBox_bread_buses.Size = new System.Drawing.Size(121, 29);
            this.comboBox_bread_buses.TabIndex = 5;
            this.comboBox_bread_buses.Text = "0";
            // 
            // Transportation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(489, 418);
            this.Controls.Add(this.comboBox_bread_buses);
            this.Controls.Add(this.comboBox_sodas_buses);
            this.Controls.Add(this.comboBox_frozen_veg_buses);
            this.Controls.Add(this.button_start_simulation);
            this.Controls.Add(this.label_bread_transp);
            this.Controls.Add(this.label_sodas_transp);
            this.Controls.Add(this.label_frozen_veg_transp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Transportation";
            this.Text = "Transportation";
            this.Load += new System.EventHandler(this.Transportation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_frozen_veg_transp;
        private System.Windows.Forms.Label label_sodas_transp;
        private System.Windows.Forms.Label label_bread_transp;
        private System.Windows.Forms.Button button_start_simulation;
        private System.Windows.Forms.ComboBox comboBox_frozen_veg_buses;
        private System.Windows.Forms.ComboBox comboBox_sodas_buses;
        private System.Windows.Forms.ComboBox comboBox_bread_buses;
    }
}