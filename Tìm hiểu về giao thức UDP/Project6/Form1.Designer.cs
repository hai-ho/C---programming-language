
namespace Project6
{
    partial class Form1
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
            this.button_CreateTable = new System.Windows.Forms.Button();
            this.button_DeleteTable = new System.Windows.Forms.Button();
            this.button_LoadData = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Insert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_CreateTable
            // 
            this.button_CreateTable.Location = new System.Drawing.Point(12, 21);
            this.button_CreateTable.Name = "button_CreateTable";
            this.button_CreateTable.Size = new System.Drawing.Size(118, 31);
            this.button_CreateTable.TabIndex = 0;
            this.button_CreateTable.Text = "Tạo bảng Sinh Viên";
            this.button_CreateTable.UseVisualStyleBackColor = true;
            this.button_CreateTable.Click += new System.EventHandler(this.button_CreateTable_Click);
            // 
            // button_DeleteTable
            // 
            this.button_DeleteTable.Location = new System.Drawing.Point(136, 21);
            this.button_DeleteTable.Name = "button_DeleteTable";
            this.button_DeleteTable.Size = new System.Drawing.Size(118, 31);
            this.button_DeleteTable.TabIndex = 0;
            this.button_DeleteTable.Text = "Xóa bảng Sinh Viên";
            this.button_DeleteTable.UseVisualStyleBackColor = true;
            this.button_DeleteTable.Click += new System.EventHandler(this.button_DeleteTable_Click);
            // 
            // button_LoadData
            // 
            this.button_LoadData.Location = new System.Drawing.Point(260, 21);
            this.button_LoadData.Name = "button_LoadData";
            this.button_LoadData.Size = new System.Drawing.Size(86, 31);
            this.button_LoadData.TabIndex = 0;
            this.button_LoadData.Text = "Load dữ liệu";
            this.button_LoadData.UseVisualStyleBackColor = true;
            this.button_LoadData.Click += new System.EventHandler(this.button_LoadData_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 100);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(611, 457);
            this.dataGridView1.TabIndex = 1;
            // 
            // button_Insert
            // 
            this.button_Insert.Location = new System.Drawing.Point(352, 21);
            this.button_Insert.Name = "button_Insert";
            this.button_Insert.Size = new System.Drawing.Size(98, 31);
            this.button_Insert.TabIndex = 0;
            this.button_Insert.Text = "Thêm dữ liệu";
            this.button_Insert.UseVisualStyleBackColor = true;
            this.button_Insert.Click += new System.EventHandler(this.button_Insert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập tên cần tìm";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(108, 69);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(260, 20);
            this.textBox_Name.TabIndex = 3;
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(374, 63);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(76, 31);
            this.button_Search.TabIndex = 0;
            this.button_Search.Text = "Tìm kiếm";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(552, 21);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(76, 31);
            this.button_Delete.TabIndex = 0;
            this.button_Delete.Text = "Xóa";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(456, 21);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(90, 31);
            this.button_Update.TabIndex = 0;
            this.button_Update.Text = "Sửa dữ liệu";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 569);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Insert);
            this.Controls.Add(this.button_LoadData);
            this.Controls.Add(this.button_DeleteTable);
            this.Controls.Add(this.button_CreateTable);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project 6";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_CreateTable;
        private System.Windows.Forms.Button button_DeleteTable;
        private System.Windows.Forms.Button button_LoadData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Insert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Update;
    }
}

