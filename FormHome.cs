using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BaiOnTap2
{
    public partial class FormQLSach : Form
    {
        private SqlConnection cnn = new SqlConnection(@"Data Source=Laptop_of_Carat\SQLEXPRESS;Initial Catalog=thuvien_c#;Integrated Security=True");

        public FormQLSach()
        {
            InitializeComponent();
        }

        // Hàm kết nối cơ sở dữ liệu và lấy dữ liệu
        private void ketnoicsdl()
        {
            string sql = "SELECT * FROM QLSach";
            DataTable dt = ExecuteQuery(sql);
            if (dt != null)
            {
                dataGridView1.DataSource = dt; // Đổ dữ liệu vào DataGridView
            }
        }

        // Hàm thực thi câu lệnh SQL và trả về DataTable
        private DataTable ExecuteQuery(string query)
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                return null;
            }
            finally
            {
                cnn.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ các điều khiển người dùng
                string tenSach = textBoxTenSach.Text.Trim();
                DateTime ngayMuon = dateTimePickerNgayMuon.Value;
                DateTime ngayTra = dateTimePickerNgayHen.Value;
               // bool traDungHen = checkBoxTraDungHen.Checked; // Lấy trạng thái checkbox

                if (string.IsNullOrWhiteSpace(tenSach))
                {
                    MessageBox.Show("Tên sách không được để trống");
                    return;
                }
                if (ngayTra < ngayMuon)
                {
                    MessageBox.Show("Ngày hẹn trả phải sau ngày mượn");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(@"Data Source=Laptop_of_Carat\SQLEXPRESS;Initial Catalog=thuvien_c#;Integrated Security=True"))
                {
                    connection.Open();
                    // Thêm dữ liệu với TraDungHen mặc định là "F"
                    string query = "INSERT INTO QLSach(TenSach, NgayMuon, NgayHenTra, TraDungHen) VALUES (@TenSach, @NgayMuon, @NgayHenTra, 'F')";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@TenSach", tenSach);
                    cmd.Parameters.AddWithValue("@NgayMuon", ngayMuon);
                    cmd.Parameters.AddWithValue("@NgayHenTra", ngayTra);
                   // cmd.Parameters.AddWithValue("@TraDungHen", traDungHen ? "T" : "F"); // Cập nhật cột TraDungHen
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm thông tin mượn sách mới thành công!");
                }

                ketnoicsdl(); // Refresh the data grid view
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBoxSoPhieu.Text);
                string tenSach = textBoxTenSach.Text.Trim();
                DateTime ngayMuon = dateTimePickerNgayMuon.Value;
                DateTime ngayTra = dateTimePickerNgayHen.Value;
               // bool traDungHen = checkBoxTraDungHen.Checked; // Lấy trạng thái checkbox

                if (string.IsNullOrWhiteSpace(tenSach))
                {
                    MessageBox.Show("Tên sách không được để trống");
                    return;
                }
                if (ngayTra < ngayMuon)
                {
                    MessageBox.Show("Ngày hẹn trả phải sau ngày mượn");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(@"Data Source=Laptop_of_Carat\SQLEXPRESS;Initial Catalog=thuvien_c#;Integrated Security=True"))
                {
                    connection.Open();
                    string query = "UPDATE QLSach SET TenSach = @TenSach, NgayMuon = @NgayMuon, NgayHenTra = @NgayHenTra, TraDungHen = @TraDungHen WHERE SoPhieuMuonSach = @SoPhieuMuonSach";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@SoPhieuMuonSach", id);
                    cmd.Parameters.AddWithValue("@TenSach", tenSach);
                    cmd.Parameters.AddWithValue("@NgayMuon", ngayMuon);
                    cmd.Parameters.AddWithValue("@NgayHenTra", ngayTra);
                   // cmd.Parameters.AddWithValue("@TraDungHen", traDungHen ? "T" : "F"); // Cập nhật cột TraDungHen
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật phiếu mượn thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy phiếu mượn với mã số này.");
                    }
                }

                ketnoicsdl(); // Refresh the data grid view
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maHDText = textBoxSoPhieu.Text.Trim();

                if (string.IsNullOrEmpty(maHDText))
                {
                    MessageBox.Show("Vui lòng nhập mã số phiếu mượn.");
                    return;
                }

                if (!int.TryParse(maHDText, out int maHD))
                {
                    MessageBox.Show("Mã số phiếu mượn phải là số nguyên.");
                    return;
                }

                if (MessageBox.Show("Bạn có thật sự muốn xóa phiếu mượn này không?", "Xác nhận xóa", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    using (SqlConnection connection = new SqlConnection(@"Data Source=Laptop_of_Carat\SQLEXPRESS;Initial Catalog=thuvien_c#;Integrated Security=True"))
                    {
                        connection.Open();
                        string query = "DELETE FROM QLSach WHERE SoPhieuMuonSach = @SoPhieuMuonSach";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@SoPhieuMuonSach", maHD);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy phiếu mượn với mã số này.");
                        }
                    }

                    ketnoicsdl(); // Refresh the data grid view
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = string.Empty;

            if (comboBox1.SelectedItem.ToString() == "Độc giả trả sách đúng hạn")
            {
                query = "SELECT * FROM QLSach WHERE NgayHenTra < GETDATE()";
            }
            else if (comboBox1.SelectedItem.ToString() == "Độc giả trả sách quá hạn")
            {
                query = "SELECT * FROM QLSach WHERE NgayHenTra >= GETDATE()";
            }

            DataTable dt = ExecuteQuery(query);
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void checkBoxDaTraSach_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                // Đảm bảo rằng có một dòng được chọn
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một phiếu mượn sách để cập nhật.");
                    return;
                }

                // Lấy ID của bản ghi được chọn từ DataGridView (giả sử ID nằm ở cột đầu tiên)
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                int soPhieuMuonSach = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells[0].Value);

                // Xác định giá trị mới cho TraDungHen dựa trên trạng thái của CheckBox
                string traDungHenValue = checkBoxDaTraSach.Checked ? "T" : "F";

                // Cập nhật cơ sở dữ liệu với giá trị mới
                using (SqlConnection connection = new SqlConnection(@"Data Source=Laptop_of_Carat\SQLEXPRESS;Initial Catalog=thuvien_c#;Integrated Security=True"))
                {
                    connection.Open();
                    string query = "UPDATE QLSach SET TraDungHen = @TraDungHen WHERE SoPhieuMuonSach = @SoPhieuMuonSach";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@TraDungHen", traDungHenValue);
                    cmd.Parameters.AddWithValue("@SoPhieuMuonSach", soPhieuMuonSach);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cập nhật thông tin trả sách thành công!");
                }

                // Làm mới DataGridView để hiển thị dữ liệu cập nhật
                ketnoicsdl();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

    }
}
