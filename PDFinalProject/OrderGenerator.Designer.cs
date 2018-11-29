namespace PDFinalProject
{
    partial class OrderGenerator
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridView_binnacle = new System.Windows.Forms.DataGridView();
            this.button_simulation = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.File = new System.Windows.Forms.Button();
            this.DataGrid = new System.Windows.Forms.Button();
            this.Textbox = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_binnacle)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 35;
            this.dataGridView.Size = new System.Drawing.Size(609, 503);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // dataGridView_binnacle
            // 
            this.dataGridView_binnacle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_binnacle.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView_binnacle.Location = new System.Drawing.Point(895, 0);
            this.dataGridView_binnacle.Name = "dataGridView_binnacle";
            this.dataGridView_binnacle.Size = new System.Drawing.Size(133, 503);
            this.dataGridView_binnacle.TabIndex = 1;
            // 
            // button_simulation
            // 
            this.button_simulation.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.button_simulation.Location = new System.Drawing.Point(634, 316);
            this.button_simulation.Name = "button_simulation";
            this.button_simulation.Size = new System.Drawing.Size(104, 55);
            this.button_simulation.TabIndex = 2;
            this.button_simulation.Text = "Simulation";
            this.button_simulation.UseVisualStyleBackColor = true;
            this.button_simulation.Click += new System.EventHandler(this.button_simulation_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(759, -2);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 417);
            this.textBox1.TabIndex = 3;
            // 
            // File
            // 
            this.File.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.File.Location = new System.Drawing.Point(634, 40);
            this.File.Margin = new System.Windows.Forms.Padding(2);
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(104, 66);
            this.File.TabIndex = 4;
            this.File.Text = "File";
            this.File.UseVisualStyleBackColor = true;
            this.File.Click += new System.EventHandler(this.File_Click);
            // 
            // DataGrid
            // 
            this.DataGrid.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.DataGrid.Location = new System.Drawing.Point(634, 120);
            this.DataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(104, 64);
            this.DataGrid.TabIndex = 5;
            this.DataGrid.Text = "DataGrid";
            this.DataGrid.UseVisualStyleBackColor = true;
            this.DataGrid.Click += new System.EventHandler(this.DataGrid_Click);
            // 
            // Textbox
            // 
            this.Textbox.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.Textbox.Location = new System.Drawing.Point(634, 200);
            this.Textbox.Margin = new System.Windows.Forms.Padding(2);
            this.Textbox.Name = "Textbox";
            this.Textbox.Size = new System.Drawing.Size(104, 66);
            this.Textbox.TabIndex = 6;
            this.Textbox.Text = "TextBox";
            this.Textbox.UseVisualStyleBackColor = true;
            this.Textbox.Click += new System.EventHandler(this.Textbox_Click);
            // 
            // button_update
            // 
            this.button_update.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.button_update.Location = new System.Drawing.Point(777, 439);
            this.button_update.Margin = new System.Windows.Forms.Padding(2);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(101, 49);
            this.button_update.TabIndex = 7;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.actualizar_Click);
            // 
            // OrderGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 503);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.Textbox);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.File);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_simulation);
            this.Controls.Add(this.dataGridView_binnacle);
            this.Controls.Add(this.dataGridView);
            this.Name = "OrderGenerator";
            this.Text = "Order generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_binnacle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridView dataGridView_binnacle;
        private System.Windows.Forms.Button button_simulation;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button File;
        private System.Windows.Forms.Button DataGrid;
        private System.Windows.Forms.Button Textbox;
        private System.Windows.Forms.Button button_update;
    }
}

