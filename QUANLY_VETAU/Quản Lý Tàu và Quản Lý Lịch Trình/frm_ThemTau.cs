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
    public partial class frm_ThemTau : Form
    {
        public frm_ThemTau()
        {
            InitializeComponent();
        }

        KETNOI_DULIEU kn = new KETNOI_DULIEU();

        private void frm_ThemTau_Load(object sender, EventArgs e)
        {

        }


        private void btn_Xacnhan_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TXT_TENTAU.Text))
            {
                MessageBox.Show("Tên tàu không được để trống.");
                return;
            }

            if (!int.TryParse(TXT_SOTOA.Text.Trim(), out int soToa))
            {
                MessageBox.Show("Số toa phải là số nguyên.");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn thêm tàu này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = $"INSERT INTO TAU (TenTau, SoToa) VALUES (N'{TXT_TENTAU.Text.Trim()}', {TXT_SOTOA.Text.Trim()})";
                kn.ThucThi(sql);
                MessageBox.Show("Thêm thành công!");
                this.Close();
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
