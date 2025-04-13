using System;
using System.Data;
using System.Windows.Forms;

namespace BTN_QLIVETAU
{
    public partial class frm_UPDATEGA : Form
    {
        string _maGa;  // Mã ga để sửa
        bool _isEditing;  // Kiểm tra là sửa hay thêm
        KETNOI_DULIEU kn = new KETNOI_DULIEU();

        // Constructor khi sửa
        public frm_UPDATEGA(string maGa)
        {
            InitializeComponent();
            _maGa = maGa;
            _isEditing = true;  // Đang sửa
        }

        // Constructor khi thêm mới
        public frm_UPDATEGA()
        {
            InitializeComponent();
            _isEditing = false;  // Đang thêm
        }

        private void frm_UPDATEGA_Load_1(object sender, EventArgs e)
        {
            if (_isEditing)  // Nếu đang sửa, load dữ liệu
            {
                string sql = "SELECT * FROM GATAU WHERE MaGa = '" + _maGa + "'";
                DataTable dta = kn.Lay_DuLieuBang(sql);
                if (dta.Rows.Count > 0)
                {
                    txt_TENGA.Text = dta.Rows[0]["TenGa"].ToString();
                    txt_DIACHI.Text = dta.Rows[0]["DiaChi"].ToString();
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txt_TENGA.Text.Trim() == "" || txt_DIACHI.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Nếu là sửa
            if (_isEditing)
            {
                string sql = "UPDATE GATAU SET TenGa = N'" + txt_TENGA.Text.Trim() +
                             "', DiaChi = N'" + txt_DIACHI.Text.Trim() +
                             "' WHERE MaGa = '" + _maGa + "'";
                kn.ThucThi(sql);
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Nếu là thêm mới
            else
            {
                string sql = "INSERT INTO GATAU (TenGa, DiaChi) VALUES (N'" + txt_TENGA.Text.Trim() +
                             "', N'" + txt_DIACHI.Text.Trim() + "')";
                kn.ThucThi(sql);
                MessageBox.Show("Thêm ga thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();  // Đóng form sau khi lưu
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?",
                                          "Xác nhận thoát",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Close the form if user confirms
                this.Close();
            }
        }
    }
}