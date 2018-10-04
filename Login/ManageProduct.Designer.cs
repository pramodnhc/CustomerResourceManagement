namespace Login
{
    partial class ManageProduct
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnnewproduct = new System.Windows.Forms.Button();
            this.btnremovebutton = new System.Windows.Forms.Button();
            this.btnupdateproduct = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnmainpage = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 73);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(374, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Product";
            // 
            // btnnewproduct
            // 
            this.btnnewproduct.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnnewproduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnnewproduct.Location = new System.Drawing.Point(37, 146);
            this.btnnewproduct.Name = "btnnewproduct";
            this.btnnewproduct.Size = new System.Drawing.Size(130, 37);
            this.btnnewproduct.TabIndex = 1;
            this.btnnewproduct.Text = "New Product";
            this.btnnewproduct.UseVisualStyleBackColor = false;
            // 
            // btnremovebutton
            // 
            this.btnremovebutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnremovebutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnremovebutton.Location = new System.Drawing.Point(37, 209);
            this.btnremovebutton.Name = "btnremovebutton";
            this.btnremovebutton.Size = new System.Drawing.Size(130, 34);
            this.btnremovebutton.TabIndex = 2;
            this.btnremovebutton.Text = "Remove Product";
            this.btnremovebutton.UseVisualStyleBackColor = false;
            // 
            // btnupdateproduct
            // 
            this.btnupdateproduct.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnupdateproduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnupdateproduct.Location = new System.Drawing.Point(37, 273);
            this.btnupdateproduct.Name = "btnupdateproduct";
            this.btnupdateproduct.Size = new System.Drawing.Size(130, 34);
            this.btnupdateproduct.TabIndex = 3;
            this.btnupdateproduct.Text = "Update Product";
            this.btnupdateproduct.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(194, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(793, 370);
            this.dataGridView1.TabIndex = 4;
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(610, 107);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(229, 24);
            this.txtsearch.TabIndex = 5;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsearch.Location = new System.Drawing.Point(859, 96);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(104, 35);
            this.btnsearch.TabIndex = 6;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            // 
            // btnmainpage
            // 
            this.btnmainpage.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnmainpage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnmainpage.Location = new System.Drawing.Point(37, 334);
            this.btnmainpage.Name = "btnmainpage";
            this.btnmainpage.Size = new System.Drawing.Size(130, 34);
            this.btnmainpage.TabIndex = 7;
            this.btnmainpage.Text = "Main Page";
            this.btnmainpage.UseVisualStyleBackColor = false;
            this.btnmainpage.Click += new System.EventHandler(this.btnmainpage_Click);
            // 
            // ManageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 532);
            this.ControlBox = false;
            this.Controls.Add(this.btnmainpage);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnupdateproduct);
            this.Controls.Add(this.btnremovebutton);
            this.Controls.Add(this.btnnewproduct);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageProduct";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnnewproduct;
        private System.Windows.Forms.Button btnremovebutton;
        private System.Windows.Forms.Button btnupdateproduct;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnmainpage;
    }
}