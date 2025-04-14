using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTN_QLIVETAU;

namespace QUANLY_VETAU
{
    public partial class frm_SuaLichTrinh : Form
    {
        public frm_SuaLichTrinh()
        {
            InitializeComponent();
        }

        KETNOI_DULIEU kn = new KETNOI_DULIEU();

        public string MaLichTrinh { get; set; }

        private void frm_SuaLichTrinh_Load(object sender, EventArgs e)
        {
            LoadLichTrinh();
            LoadGaToComboBox();
        }

        private void LoadGaToComboBox()
        {
            DataTable gaTable = kn.Lay_DuLieuBang("SELECT MaGa FROM GATAU");

            CBO_GADI.Items.Clear();
            CBO_GADEN.Items.Clear();

            foreach (DataRow row in gaTable.Rows)
            {
                string maGa = row["MaGa"].ToString();
                CBO_GADI.Items.Add(maGa);
                CBO_GADEN.Items.Add(maGa);
            }
        }

        private void LoadLichTrinh()
        {
            DataTable dt = kn.Lay_DuLieuBang($"SELECT * FROM LICHTRINH WHERE MaLichTrinh = '{MaLichTrinh}'");

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                TXT_MALICHTRINH.Text = row["MaLichTrinh"].ToString();
                CBO_GADI.Text = row["GaDi"].ToString();
                CBO_GADEN.Text = row["GaDen"].ToString();
                TXT_GIODI.Value = Convert.ToDateTime(row["GioDi"]);
                TXT_GIODEN.Value = Convert.ToDateTime(row["GioDen"]);

                string gaDi = CBO_GADI.Text;
                string gaDen = CBO_GADEN.Text;

                DataTable gaDiInfo = kn.Lay_DuLieuBang($"SELECT * FROM GATAU WHERE MaGa = '{gaDi}'");
                if (gaDiInfo.Rows.Count > 0)
                {
                    TXT_TENGADI.Text = gaDiInfo.Rows[0]["TenGa"].ToString();
                    TXT_DCGADI.Text = gaDiInfo.Rows[0]["DiaChi"].ToString();
                }

                DataTable gaDenInfo = kn.Lay_DuLieuBang($"SELECT * FROM GATAU WHERE MaGa = '{gaDen}'");
                if (gaDenInfo.Rows.Count > 0)
                {
                    TXT_TENGADEN.Text = gaDenInfo.Rows[0]["TenGa"].ToString();
                    TXT_DCGADEN.Text = gaDenInfo.Rows[0]["DiaChi"].ToString();
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CBO_GADI.Text) || string.IsNullOrEmpty(CBO_GADEN.Text) ||
                TXT_GIODI.Value == null || TXT_GIODEN.Value == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maLichTrinh = TXT_MALICHTRINH.Text.Trim();
            string gaDi = CBO_GADI.Text.Trim();
            string gaDen = CBO_GADEN.Text.Trim();
            DateTime gioDi = TXT_GIODI.Value;
            DateTime gioDen = TXT_GIODEN.Value;

            string sql_update = $"UPDATE LICHTRINH SET GaDi = '{gaDi}', GaDen = '{gaDen}', GioDi = '{gioDi:yyyy-MM-dd HH:mm:ss}', GioDen = '{gioDen:yyyy-MM-dd HH:mm:ss}' WHERE MaLichTrinh = '{maLichTrinh}'";

            try
            {
                kn.ThucThi(sql_update);

                MessageBox.Show("Cập nhật lịch trình thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CBO_GADI_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maGa = CBO_GADI.Text;
            DataTable gaInfo = kn.Lay_DuLieuBang($"SELECT * FROM GATAU WHERE MaGa = '{maGa}'");
            if (gaInfo.Rows.Count > 0)
            {
                TXT_TENGADI.Text = gaInfo.Rows[0]["TenGa"].ToString();
                TXT_DCGADI.Text = gaInfo.Rows[0]["DiaChi"].ToString();
            }
        }

        private void CBO_GADEN_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maGa = CBO_GADEN.Text;
            DataTable gaInfo = kn.Lay_DuLieuBang($"SELECT * FROM GATAU WHERE MaGa = '{maGa}'");
            if (gaInfo.Rows.Count > 0)
            {
                TXT_TENGADEN.Text = gaInfo.Rows[0]["TenGa"].ToString();
                TXT_DCGADEN.Text = gaInfo.Rows[0]["DiaChi"].ToString();
            }
        }
    }
}
