using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace BTN_QLIVETAU
{
    public partial class frm_UPDATEVTAU : Form
    {

        string _maVe = "";
        public frm_UPDATEVTAU()
        {
            InitializeComponent();
        }
        public frm_UPDATEVTAU(string maVe)  // Sửa
        {
            InitializeComponent();
            _maVe = maVe;
        }


        KETNOI_DULIEU kn = new KETNOI_DULIEU();

        

        public void SOTOA()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieuBang("Select * from TAU");
            cbo_SOTOA.DataSource = dta;
            cbo_SOTOA.DisplayMember = "SoToa";
        }

        public void GADI()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieuBang("Select * from GATAU");
            cboGADI.DataSource = dta;
            cboGADI.DisplayMember = "TenGa";
        }

        public void GADEN()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieuBang("Select * from GATAU");
            cboGADEN.DataSource = dta;
            cboGADEN.DisplayMember = "TenGa";
        }

        private void frm_UPDATEVTAU_Load(object sender, EventArgs e)
        {
            SOTOA();
            GADI();
            GADEN();

            if (!string.IsNullOrEmpty(_maVe))
            {
                string sql = "SELECT * FROM V_TTVETAU WHERE MaVe = '" + _maVe + "'";
                DataTable dta = kn.Lay_DuLieuBang(sql);

                if (dta.Rows.Count > 0)
                {
                    txt_TENTAU.Text = dta.Rows[0]["TenTau"].ToString();
                    txt_GIAVE.Text = dta.Rows[0]["GiaVe"].ToString();
                    cboGADI.Text = dta.Rows[0]["GaDi"].ToString();
                    cboGADEN.Text = dta.Rows[0]["GaDen"].ToString();
                    time_Di.Text = dta.Rows[0]["GioDi"].ToString();
                    time_Den.Text = dta.Rows[0]["GioDen"].ToString();
                    cbo_SOTOA.Text = dta.Rows[0]["SoToa"].ToString();
                }
            }
            //HIENTHI_DULIEU();
        }

        //public void HIENTHI_DULIEU()
        //{
        //    txt_TENTAU.DataBindings.Clear();
        //    txt_TENTAU.DataBindings.Add("Text", dataGd_VE.DataSource, "TenTau");
        //    txt_GIAVE.DataBindings.Clear();
        //    txt_GIAVE.DataBindings.Add("Text", dataGd_VE.DataSource, "GiaVe");
        //    cboGADI.DataBindings.Clear();
        //    cboGADI.DataBindings.Add("Text", dataGd_VE.DataSource, "GaDi");
        //    cboGADEN.DataBindings.Clear();
        //    cboGADEN.DataBindings.Add("Text", dataGd_VE.DataSource, "GaDen");
        //    time_Di.DataBindings.Clear();
        //    time_Di.DataBindings.Add("Text", dataGd_VE.DataSource, "GioDi");
        //    time_Den.DataBindings.Clear();
        //    time_Den.DataBindings.Add("Text", dataGd_VE.DataSource, "GioDen");
        //    cbo_SOTOA.DataBindings.Clear();
        //    cbo_SOTOA.DataBindings.Add("Text", dataGd_VE.DataSource, "SoToa");
        //}

        private void btn_THEM_Click(object sender, EventArgs e)
        {
            cboGADI.Text = "";
            cboGADEN.Text = "";
            txt_TENTAU.Text = "";
            time_Di.Text = "";
            time_Den.Text = "";
            cbo_SOTOA.Text = "";
            MessageBox.Show("Thêm vé tàu thành công!", "Thông báo");
        }

        private void btn_SUA_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    // Lấy mã tàu
            //    string sql_MaTau = "SELECT MaTau FROM TAU WHERE TenTau = N'" + txt_TENTAU.Text + "'";
            //    string maTau = kn.LayGiaTri(sql_MaTau);

            //    // Lấy mã lịch trình (đảm bảo định dạng giờ đúng)
            //    string gioDi = time_Di.Value.ToString("yyyy-MM-dd HH:mm:ss");
            //    string sql_MaLichTrinh = "SELECT MaLichTrinh FROM LICHTRINH WHERE GaDi = N'" + cboGADI.Text + "' AND GioDi = '" + gioDi + "'";
            //    string maLichTrinh = kn.LayGiaTri(sql_MaLichTrinh);

            //    // Lấy mã chuyến đi
            //    string sql_MaChuyenDi = "SELECT MaChuyenDi FROM CHUYENDI WHERE MaTau = '" + maTau + "' AND MaLichTrinh = '" + maLichTrinh + "'";
            //    string maChuyenDi = kn.LayGiaTri(sql_MaChuyenDi);

            //    // Kiểm tra giá trị rỗng
            //    if (string.IsNullOrEmpty(maTau) || string.IsNullOrEmpty(maLichTrinh) || string.IsNullOrEmpty(maChuyenDi))
            //    {
            //        MessageBox.Show("Không tìm thấy thông tin phù hợp để sửa. Vui lòng kiểm tra lại dữ liệu nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }

            //    // Kiểm tra giá vé
            //    if (!decimal.TryParse(txt_GIAVE.Text, out decimal giaVe))
            //    {
            //        MessageBox.Show("Giá vé không hợp lệ. Vui lòng nhập đúng số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }

            //    // UPDATE VETAU
            //    string sql_sua_VETAU = "UPDATE VETAU SET GiaVe = " + giaVe + " WHERE MaChuyenDi = '" + maChuyenDi + "';";

            //    // UPDATE TAU
            //    string sql_sua_TAU = "UPDATE TAU SET SoToa = " + cbo_SOTOA.Text + " WHERE MaTau = '" + maTau + "';";

            //    // UPDATE LICHTRINH
            //    string gioDen = time_Den.Value.ToString("yyyy-MM-dd HH:mm:ss");
            //    string sql_sua_LICHTRINH = "UPDATE LICHTRINH SET GaDen = N'" + cboGADEN.Text + "', GioDen = '" + gioDen + "' WHERE MaLichTrinh = '" + maLichTrinh + "';";

            //    // Gộp và thực thi
            //    string sql_sua = sql_sua_VETAU + sql_sua_TAU + sql_sua_LICHTRINH;
            //    kn.ThucThi(sql_sua);

            //    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    BANGVETAU();
            //    HIENTHI_DULIEU();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Đã xảy ra lỗi khi cập nhật dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btn_LUU_Click(object sender, EventArgs e)
        {
            // Lấy thông tin
            string tenTau = txt_TENTAU.Text;
            string gaDi = cboGADI.Text;
            string gaDen = cboGADEN.Text;
            string gioDi = time_Di.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string gioDen = time_Den.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string soToa = cbo_SOTOA.Text;
            string giaVe = txt_GIAVE.Text;

            // Lấy MaTau
            string sql_MaTau = "SELECT MaTau FROM TAU WHERE TenTau = N'" + tenTau + "'";
            string maTau = kn.LayGiaTri(sql_MaTau);

            // Lấy MaGa
            string sql_GaDi = "SELECT MaGa FROM GATAU WHERE TenGa = N'" + gaDi + "'";
            string maGaDi = kn.LayGiaTri(sql_GaDi);
            string sql_GaDen = "SELECT MaGa FROM GATAU WHERE TenGa = N'" + gaDen + "'";
            string maGaDen = kn.LayGiaTri(sql_GaDen);

            // Kiểm tra hoặc thêm LichTrinh
            string sql_LichTrinh = "SELECT MaLichTrinh FROM LICHTRINH WHERE GaDi = '" + maGaDi + "' AND GaDen = '" + maGaDen + "' AND GioDi = '" + gioDi + "'";
            string maLichTrinh = kn.LayGiaTri(sql_LichTrinh);

            if (string.IsNullOrEmpty(maLichTrinh))
            {
                // Chưa có thì thêm mới
                string sqlInsertLT = "INSERT INTO LICHTRINH (GaDi, GaDen, GioDi, GioDen) VALUES ('" + maGaDi + "', '" + maGaDen + "', '" + gioDi + "', '" + gioDen + "')";
                kn.ThucThi(sqlInsertLT);
                maLichTrinh = kn.LayGiaTri("SELECT MAX(MaLichTrinh) FROM LICHTRINH");
            }

            // Kiểm tra hoặc thêm ChuyenDi
            string sql_ChuyenDi = "SELECT MaChuyenDi FROM CHUYENDI WHERE MaTau = '" + maTau + "' AND MaLichTrinh = '" + maLichTrinh + "'";
            string maChuyenDi = kn.LayGiaTri(sql_ChuyenDi);

            if (string.IsNullOrEmpty(maChuyenDi))
            {
                string sqlInsertCD = "INSERT INTO CHUYENDI (MaLichTrinh, MaTau, GiaCoBan) VALUES ('" + maLichTrinh + "', '" + maTau + "', " + giaVe + ")";
                kn.ThucThi(sqlInsertCD);
                maChuyenDi = kn.LayGiaTri("SELECT MAX(MaChuyenDi) FROM CHUYENDI");
            }

            if (string.IsNullOrEmpty(_maVe))  // THÊM
            {
                string sqlInsertVe = "INSERT INTO VETAU (MaChuyenDi, SoGhe, GiaVe, DaDat, KhachHang) VALUES ('" + maChuyenDi + "', 'A1', " + giaVe + ", 0, 'customer1')";
                kn.ThucThi(sqlInsertVe);
                MessageBox.Show("Đã thêm vé thành công!");
            }
            else  // SỬA
            {
                string sqlUpdate = "UPDATE VETAU SET MaChuyenDi = '" + maChuyenDi + "', GiaVe = " + giaVe + " WHERE MaVe = '" + _maVe + "'";
                kn.ThucThi(sqlUpdate);
                MessageBox.Show("Đã cập nhật vé thành công!");
            }

            this.Close(); // Đóng form sau khi lưu
        }

    }
}

