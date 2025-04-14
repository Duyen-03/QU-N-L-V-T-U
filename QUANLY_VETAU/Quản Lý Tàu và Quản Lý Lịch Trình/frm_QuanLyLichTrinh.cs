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
    public partial class frm_QuanLyLichTrinh : Form
    {
        public frm_QuanLyLichTrinh()
        {
            InitializeComponent();
        }

        KETNOI_DULIEU kn = new KETNOI_DULIEU();
        private bool isBindingCleared = false;

        private void frm_QuanLyLichTrinh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLI_VETAUDataSet.LICHTRINH' table. You can move, or remove it, as needed.
            this.lICHTRINHTableAdapter.Fill(this.qLI_VETAUDataSet.LICHTRINH);
            HienThiDuLieu();
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

        private void HienThiDuLieu()
        {
            DataTable dta = kn.Lay_DuLieuBang("SELECT * FROM LICHTRINH");
            dgv_LichTrinh.DataSource = dta;
            dgv_LichTrinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgv_LichTrinh.Rows.Count > 0)
            {
                dgv_LichTrinh.Rows[0].Selected = true;
                HienThiChiTiet();
            }
        }

        private void HienThiChiTiet()
        {
            if (dgv_LichTrinh.CurrentRow != null)
            {
                DataGridViewRow row = dgv_LichTrinh.CurrentRow;

                TXT_MALICHTRINH.Text = row.Cells["maLichTrinhDataGridViewTextBoxColumn"].Value?.ToString();
                CBO_GADI.Text = row.Cells["gaDiDataGridViewTextBoxColumn"].Value?.ToString();
                CBO_GADEN.Text = row.Cells["gaDenDataGridViewTextBoxColumn"].Value?.ToString();

                if (row.Cells["gioDiDataGridViewTextBoxColumn"].Value != DBNull.Value)
                    TXT_GIODI.Value = Convert.ToDateTime(row.Cells["gioDiDataGridViewTextBoxColumn"].Value);

                if (row.Cells["gioDenDataGridViewTextBoxColumn"].Value != DBNull.Value)
                    TXT_GIODEN.Value = Convert.ToDateTime(row.Cells["gioDenDataGridViewTextBoxColumn"].Value);

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



        private void btn_ThemTau_Click(object sender, EventArgs e)
        {
            frm_ThemTau themForm = new frm_ThemTau();
            themForm.ShowDialog();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string maLT = TXT_MALICHTRINH.Text.Trim();
            string gaDi = CBO_GADI.Text.Trim();
            string gaDen = CBO_GADEN.Text.Trim();
            DateTime gioDi = TXT_GIODI.Value;
            DateTime gioDen = TXT_GIODEN.Value;

            string filter = "SELECT * FROM LICHTRINH WHERE 1=1";

            if (!string.IsNullOrEmpty(maLT))
                filter += $" AND MaLichTrinh LIKE '%{maLT}%'";

            if (!string.IsNullOrEmpty(gaDi))
                filter += $" AND GaDi LIKE '%{gaDi}%'";

            if (!string.IsNullOrEmpty(gaDen))
                filter += $" AND GaDen LIKE '%{gaDen}%'";

            filter += $" AND GioDi = '{gioDi:yyyy-MM-dd HH:mm:ss}'";
            filter += $" AND GioDen = '{gioDen:yyyy-MM-dd HH:mm:ss}'";

            DataTable dta = kn.Lay_DuLieuBang(filter);
            dgv_LichTrinh.DataSource = dta;

            if (dgv_LichTrinh.Rows.Count > 0)
            {
                dgv_LichTrinh.Rows[0].Selected = true;
                HienThiChiTiet();
            }
        }



        private void bttn_LamMoi_Click(object sender, EventArgs e)
        {
            TXT_MALICHTRINH.Text = string.Empty;
            TXT_TENGADI.Text = string.Empty;
            TXT_TENGADEN.Text = string.Empty;
            TXT_DCGADI.Text = string.Empty;
            TXT_DCGADEN.Text = string.Empty;
            CBO_GADI.Text = string.Empty;
            CBO_GADEN.Text = string.Empty;
            TXT_GIODI.Value = DateTime.Now;
            TXT_GIODEN.Value = DateTime.Now;
            HienThiDuLieu();
        }

        private void TXT_TimKiem_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string maLT = TXT_MALICHTRINH.Text.Trim();
                string gaDi = CBO_GADI.Text.Trim();
                string gaDen = CBO_GADEN.Text.Trim();
                DateTime gioDi = TXT_GIODI.Value;
                DateTime gioDen = TXT_GIODEN.Value;

                string filter = "SELECT * FROM LICHTRINH WHERE 1=1";

                if (!string.IsNullOrEmpty(maLT))
                    filter += $" AND MaLichTrinh LIKE '%{maLT}%'";

                if (!string.IsNullOrEmpty(gaDi))
                    filter += $" AND GaDi LIKE '%{gaDi}%'";

                if (!string.IsNullOrEmpty(gaDen))
                    filter += $" AND GaDen LIKE '%{gaDen}%'";

                filter += $" AND GioDi = '{gioDi:yyyy-MM-dd HH:mm:ss}'";
                filter += $" AND GioDen = '{gioDen:yyyy-MM-dd HH:mm:ss}'";

                DataTable dta = kn.Lay_DuLieuBang(filter);
                dgv_LichTrinh.DataSource = dta;

                if (dgv_LichTrinh.Rows.Count > 0)
                {
                    dgv_LichTrinh.Rows[0].Selected = true;
                    HienThiChiTiet();
                }
            }
        }

        private void btn_Xemtatca_Click(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }

        private void btn_XoaLichTrinh_Click(object sender, EventArgs e)
        {
            if (dgv_LichTrinh.SelectedRows.Count > 0)
            {
                string maLichTrinh = dgv_LichTrinh.SelectedRows[0].Cells["maLichTrinhDataGridViewTextBoxColumn"].Value.ToString();

                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa lịch trình có mã '{maLichTrinh}' không?",
                                                      "Xác nhận xóa",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string sql_xoa = $"DELETE FROM LICHTRINH WHERE MaLichTrinh = '{maLichTrinh}'";
                        kn.ThucThi(sql_xoa);
                        this.lICHTRINHTableAdapter.Fill(this.qLI_VETAUDataSet.LICHTRINH);

                        MessageBox.Show("Đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            HienThiDuLieu();
        }

        private void dgv_LichTrinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgv_LichTrinh.CurrentCell = dgv_LichTrinh.Rows[e.RowIndex].Cells[0];
                HienThiChiTiet();
            }
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

        private void btn_SuaLichTrinh_Click(object sender, EventArgs e)
        {
            if (dgv_LichTrinh.SelectedRows.Count > 0)
            {
                string maLichTrinh = dgv_LichTrinh.SelectedRows[0].Cells["maLichTrinhDataGridViewTextBoxColumn"].Value.ToString();

                frm_SuaLichTrinh frmSua = new frm_SuaLichTrinh();
                frmSua.MaLichTrinh = maLichTrinh;
                frmSua.ShowDialog();

                HienThiDuLieu();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btn_ThemLichTrinh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CBO_GADI.Text) || string.IsNullOrEmpty(CBO_GADEN.Text) ||
                string.IsNullOrEmpty(TXT_GIODI.Text) || string.IsNullOrEmpty(TXT_GIODEN.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string gaDi = CBO_GADI.Text.Trim();
            string gaDen = CBO_GADEN.Text.Trim();
            DateTime gioDi = TXT_GIODI.Value;
            DateTime gioDen = TXT_GIODEN.Value;
            string sql_insert = $"INSERT INTO LICHTRINH (GaDi, GaDen, GioDi, GioDen) VALUES ('{gaDi}', '{gaDen}', '{gioDi:yyyy-MM-dd HH:mm:ss}', '{gioDen:yyyy-MM-dd HH:mm:ss}')";

            try
            {
                kn.ThucThi(sql_insert);

                TXT_MALICHTRINH.Clear();
                CBO_GADI.SelectedIndex = -1;
                CBO_GADEN.SelectedIndex = -1;
                TXT_GIODI.Value = DateTime.Now;
                TXT_GIODEN.Value = DateTime.Now;

                this.lICHTRINHTableAdapter.Fill(this.qLI_VETAUDataSet.LICHTRINH);
                MessageBox.Show("Thêm lịch trình thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            HienThiDuLieu();
        }

    }
}
