using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
        }

        private void CreateTable()
        {
            string sql = @"IF OBJECT_ID (N'SinhVien', N'U') IS NULL 
                            BEGIN
	                            CREATE TABLE SinhVien(
		                            [MaSo] [int] IDENTITY(1,1) NOT NULL,
		                            [HoTen] [nvarchar](250) NULL,
		                            [NamSinh] [int] NULL,
		                            [QueQuan] [nvarchar](250) NULL,
	                             CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
	                            (
		                            [MaSo] ASC
	                            )
	                            ) ON [PRIMARY]
                            END";

            string connetionString = GetConnectionString();
            SqlConnection connection;
            SqlCommand command;
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();

                MessageBox.Show("Tạo bảng dữ liệu thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở kết nối tới cơ sở dữ liệu!");
            }
        }

        private void button_CreateTable_Click(object sender, EventArgs e)
        {
            CreateTable();
        }

        private void button_DeleteTable_Click(object sender, EventArgs e)
        {
            DeleteTable();
        }

        private void DeleteTable()
        {
            string sql = @"IF OBJECT_ID (N'SinhVien', N'U') IS NOT NULL 
                            BEGIN
                                Drop table SinhVien
                            END";

            string connetionString = GetConnectionString();
            SqlConnection connection;
            SqlCommand command;
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();

                MessageBox.Show("Xóa bảng dữ liệu thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở kết nối tới cơ sở dữ liệu!");
            }
        }

        private void LoadData()
        {
            try
            {
                string connetionString = GetConnectionString();
                SqlConnection connection = new SqlConnection(connetionString);
                string sql = "Select * from SinhVien";
                SqlDataAdapter da = new SqlDataAdapter(sql, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                da.Dispose();
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex) {
                MessageBox.Show("Xuất hiện lỗi: " + ex.Message);
            }
        }

        private void button_LoadData_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button_Insert_Click(object sender, EventArgs e)
        {
            var inputForm = new InputForm();
            var resultDialog = inputForm.ShowDialog();
            if(resultDialog == DialogResult.OK)
            {
                InputData(inputForm.FullName, inputForm.Year, inputForm.Address);

                LoadData();
            }
        }

        private void InputData(string name, int year, string address)
        {
            string sql = @"INSERT INTO [SinhVien]
                                   ([HoTen]
                                   ,[NamSinh]
                                   ,[QueQuan])
                             VALUES
                                   (@name
                                   ,@year
                                   ,@address)";

            string connetionString = GetConnectionString();
            SqlConnection connection;
            SqlCommand command;
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@year", year);
                command.Parameters.AddWithValue("@address", address);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();

                MessageBox.Show("Thêm dữ liệu thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xuất hiện lỗi: " + ex.Message);
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        private void SearchData()
        {
            string sql = @"select * from SinhVien
                            where HoTen like '{0}'";
            string name = textBox_Name.Text;
            name = "%" + name + "%";
            sql = string.Format(sql, name);
            string connetionString = GetConnectionString();
            SqlConnection connection;
            connection = new SqlConnection(connetionString);
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql,connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                da.Dispose();
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xuất hiện lỗi: " + ex.Message);
            }
        }

        private void DeleteData()
        {
            var selectedRows = dataGridView1.SelectedRows;
            if (selectedRows == null || selectedRows.Count < 1)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa!");
            }
            else
            {
                var row = selectedRows[0];
                int id = (int)row.Cells[0].Value;
                string sql = @"Delete From SinhVien Where MaSo = @maSo";

                string connetionString = GetConnectionString();
                SqlConnection connection;
                SqlCommand command;
                connection = new SqlConnection(connetionString);
                try
                {
                    connection.Open();
                    command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@maSo", id);
                    command.ExecuteNonQuery();
                    command.Dispose();
                    connection.Close();

                    MessageBox.Show("Xóa dữ liệu thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất hiện lỗi: " + ex.Message);
                }
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            DeleteData();
            LoadData();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            var selectedRows = dataGridView1.SelectedRows;
            if(selectedRows == null || selectedRows.Count < 1)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để cập nhật dữ liệu!");
            }
            else
            {
                var row = selectedRows[0];
                int id =  (int)row.Cells[0].Value;
                string name = row.Cells[1].Value.ToString();
                int year = (int)row.Cells[2].Value;
                string address = row.Cells[3].Value.ToString();

                var editForm = new EditForm(id, name, year, address);
                var resultDialog = editForm.ShowDialog();
                if(resultDialog == DialogResult.OK)
                {
                    EditData(editForm.Id, editForm.FullName, editForm.Year, editForm.Address);
                    LoadData();
                }
            }
        }

        private void EditData(int id, string name, int year, string address)
        {
            string sql = @"UPDATE SinhVien
                           SET HoTen = @name
                              ,NamSinh = @year
                              ,QueQuan = @address
                         WHERE MaSo = @id";

            string connetionString = GetConnectionString();
            SqlConnection connection;
            SqlCommand command;
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@year", year);
                command.Parameters.AddWithValue("@address", address);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();

                MessageBox.Show("Cập nhật dữ liệu thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xuất hiện lỗi: " + ex.Message);
            }
        }
    }
}
