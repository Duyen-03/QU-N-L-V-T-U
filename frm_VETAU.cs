using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTN_QLIVETAU
{
    public partial class frm_VETAU : Form
    {
        public frm_VETAU()
        {
            InitializeComponent();
        }

        private void cbbDep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        KETNOI_DULIEU kn = new KETNOI_DULIEU();


        public void GaDi()
        {
            DataTable dta = new DataTable();
            // Lấy tất cả các tên ga từ bảng GATAU
            dta = kn.Lay_DuLieuBang("SELECT TenGa FROM GATAU");
            cbbDep.DataSource = dta;
            cbbDep.DisplayMember = "TenGa";  // Hiển thị tên Ga đi
        }

        // Sửa lại để lấy tên Ga đến từ bảng GATAU
        public void GaDen()
        {
            DataTable dta = new DataTable();
            // Lấy tất cả các tên ga từ bảng GATAU
            dta = kn.Lay_DuLieuBang("SELECT TenGa FROM GATAU");
            cbbDes.DataSource = dta;
            cbbDes.DisplayMember = "TenGa";  // Hiển thị tên Ga đến
        }



        private void frm_VETAU_Load(object sender, EventArgs e)
        {
            GaDi();
            GaDen();
            HIENTHI_DULIEU();
        }

        public void HIENTHI_DULIEU()
        {

        }

        private void btn_TIMKIEM_Click(object sender, EventArgs e)
        {
            string sql_tk = "SELECT * FROM V_VETAUCHITIET WHERE 1=1";

            // Lọc theo Ga đi nếu được chọn
            if (!string.IsNullOrEmpty(cbbDep.Text))
            {
                sql_tk += " AND GaDi = N'" + cbbDep.Text + "'";  // Đổi thành GaDi_Ten
            }

            // Lọc theo Ga đến nếu được chọn
            if (!string.IsNullOrEmpty(cbbDes.Text))
            {
                sql_tk += " AND GaDen = N'" + cbbDes.Text + "'";  // Đổi thành GaDen_Ten
            }

            // Nếu checkbox được tick, lọc theo thời gian
            if (checkBox1.Checked)
            {
                // Đảm bảo format ngày tháng đúng, không có lỗi trong định dạng
                string gioDi = time_Di.Value.ToString("yyyy-MM-dd HH:mm:ss");
                string gioDen = time_Den.Value.ToString("yyyy-MM-dd HH:mm:ss");

                sql_tk += " AND GioDi BETWEEN '" + gioDi + "' AND '" + gioDen + "'";
            }

            // Kiểm tra câu lệnh SQL để đảm bảo nó đúng
            Console.WriteLine("Câu lệnh SQL: " + sql_tk);

            // Thực hiện truy vấn
            DataTable dt = kn.Lay_DuLieuBang(sql_tk);

            // Kiểm tra xem dữ liệu có được trả về hay không
            if (dt != null && dt.Rows.Count > 0)
            {
                dtaGd_TAU.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không có dữ liệu thỏa mãn điều kiện tìm kiếm.");
            }
        }
        }
    }
