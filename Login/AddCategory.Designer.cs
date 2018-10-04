namespace Login
{
    partial class AddCategory
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
            this.lbladdnewcategory = new System.Windows.Forms.Label();
            this.lblcategoryname = new System.Windows.Forms.Label();
            this.txtcategoryname = new System.Windows.Forms.TextBox();
            this.txtcategorydescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnaddcategory = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.lbladdnewcategory);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 75);
            this.panel1.TabIndex = 1;
            // 
            // lbladdnewcategory
            // 
            this.lbladdnewcategory.AutoSize = true;
            this.lbladdnewcategory.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdnewcategory.Location = new System.Drawing.Point(85, 23);
            this.lbladdnewcategory.Name = "lbladdnewcategory";
            this.lbladdnewcategory.Size = new System.Drawing.Size(241, 32);
            this.lbladdnewcategory.TabIndex = 0;
            this.lbladdnewcategory.Text = "Add New Category";
            // 
            // lblcategoryname
            // 
            this.lblcategoryname.AutoSize = true;
            this.lblcategoryname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategoryname.Location = new System.Drawing.Point(12, 148);
            this.lblcategoryname.Name = "lblcategoryname";
            this.lblcategoryname.Size = new System.Drawing.Size(143, 23);
            this.lblcategoryname.TabIndex = 2;
            this.lblcategoryname.Text = "Category Name";
            // 
            // txtcategoryname
            // 
            this.txtcategoryname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcategoryname.Location = new System.Drawing.Point(195, 145);
            this.txtcategoryname.Name = "txtcategoryname";
            this.txtcategoryname.Size = new System.Drawing.Size(194, 30);
            this.txtcategoryname.TabIndex = 8;
            // 
            // txtcategorydescription
            // 
            this.txtcategorydescription.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcategorydescription.Location = new System.Drawing.Point(195, 219);
            this.txtcategorydescription.Multiline = true;
            this.txtcategorydescription.Name = "txtcategorydescription";
            this.txtcategorydescription.Size = new System.Drawing.Size(194, 93);
            this.txtcategorydescription.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Category Description";
            // 
            // btnaddcategory
            // 
            this.btnaddcategory.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddcategory.Location = new System.Drawing.Point(277, 334);
            this.btnaddcategory.Name = "btnaddcategory";
            this.btnaddcategory.Size = new System.Drawing.Size(112, 41);
            this.btnaddcategory.TabIndex = 11;
            this.btnaddcategory.Text = "Add Category";
            this.btnaddcategory.UseVisualStyleBackColor = true;
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(159, 334);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(112, 41);
            this.btnback.TabIndex = 12;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 428);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnaddcategory);
            this.Controls.Add(this.txtcategorydescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcategoryname);
            this.Controls.Add(this.lblcategoryname);
            this.Controls.Add(this.panel1);
            this.Name = "AddCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCategory";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbladdnewcategory;
        private System.Windows.Forms.Label lblcategoryname;
        private System.Windows.Forms.TextBox txtcategoryname;
        private System.Windows.Forms.TextBox txtcategorydescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnaddcategory;
        private System.Windows.Forms.Button btnback;
    }
}