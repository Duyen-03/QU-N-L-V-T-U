using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTN_QLIVETAU;

namespace QUANLY_VETAU
{
    public partial class frm_QuanLyTau : Form
    {
        public frm_QuanLyTau()
        {
            InitializeComponent();
        }

        KETNOI_DULIEU kn = new KETNOI_DULIEU();

        private bool isBindingCleared = false;

        private void frm_QuanLyTau_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLI_VETAUDataSet.TAU' table. You can move, or remove it, as needed.
            this.tAUTableAdapter.Fill(this.qLI_VETAUDataSet.TAU);
            Hienthi();
        }

        private void TXT_TimKiem_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string maTau = TXT_MATAU.Text.Trim();
                string tenTau = TXT_TENTAU.Text.Trim();
                string soToa = TXT_SOTOA.Text.Trim();

                string filter = "SELECT * FROM TAU WHERE 1=1";

                if (!string.IsNullOrEmpty(maTau))
                    filter += $" AND MaTau LIKE '%{maTau}%'";

                if (!string.IsNullOrEmpty(tenTau))
                    filter += $" AND TenTau LIKE '%{tenTau}%'";

                if (!string.IsNullOrEmpty(soToa))
                {
                    // Loại bỏ khoảng trắng để xử lý dễ hơn
                    string cleaned = soToa.Replace(" ", "");

                    try
                    {
                        // Trường hợp khoảng giá trị: dạng 1<x<3
                        if (Regex.IsMatch(cleaned, @"^\d+(<=|<)x(<=|<)\d+$"))
                        {
                            Match match = Regex.Match(cleaned, @"^(?<left>\d+)(?<op1><=|<)x(?<op2><=|<)(?<right>\d+)$");
                            int left = int.Parse(match.Groups["left"].Value);
                            int right = int.Parse(match.Groups["right"].Value);
                            string op1 = match.Groups["op1"].Value;
                            string op2 = match.Groups["op2"].Value;

                            filter += $" AND SoToa {GetReverseOperator(op1)} {left} AND SoToa {op2} {right}";
                        }
                        // Trường hợp đơn: >5, <=10, =7, !=3
                        else if (Regex.IsMatch(cleaned, @"^(>=|<=|!=|=|>|<)\d+$"))
                        {
                            Match match = Regex.Match(cleaned, @"^(>=|<=|!=|=|>|<)(\d+)$");
                            string op = match.Groups[1].Value;
                            int value = int.Parse(match.Groups[2].Value);

                            filter += $" AND SoToa {op} {value}";
                        }
                        // Trường hợp là số bình thường
                        else if (int.TryParse(cleaned, out int soToaInt))
                        {
                            filter += $" AND SoToa = {soToaInt}";
                        }
                        else
                        {
                            MessageBox.Show("Định dạng số toa không hợp lệ.\nVí dụ: >5, <=10, 1<x<3");
                            return;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi phân tích điều kiện số toa.");
                        return;
                    }
                }

                DataTable dta = kn.Lay_DuLieuBang(filter);
                dgvTau.DataSource = dta;

                if (dgvTau.Rows.Count > 0)
                {
                    dgvTau.Rows[0].Selected = true;
                    Hienthi();
                }
            }
        }

        private void btn_Timkiem_Click(object sender, EventArgs e)
        {
            string maTau = TXT_MATAU.Text.Trim();
            string tenTau = TXT_TENTAU.Text.Trim();
            string soToa = TXT_SOTOA.Text.Trim();

            string filter = "SELECT * FROM TAU WHERE 1=1";

            if (!string.IsNullOrEmpty(maTau))
                filter += $" AND MaTau LIKE '%{maTau}%'";

            if (!string.IsNullOrEmpty(tenTau))
                filter += $" AND TenTau LIKE '%{tenTau}%'";

            if (!string.IsNullOrEmpty(soToa))
            {
                string cleaned = soToa.Replace(" ", "");

                try
                {
                    // Trường hợp khoảng giá trị: dạng 1<x<3, 2<=x<=10
                    if (Regex.IsMatch(cleaned, @"^\d+(<=|<)x(<=|<)\d+$"))
                    {
                        Match match = Regex.Match(cleaned, @"^(?<left>\d+)(?<op1><=|<)x(?<op2><=|<)(?<right>\d+)$");
                        int left = int.Parse(match.Groups["left"].Value);
                        int right = int.Parse(match.Groups["right"].Value);
                        string op1 = match.Groups["op1"].Value;
                        string op2 = match.Groups["op2"].Value;

                        filter += $" AND SoToa {GetReverseOperator(op1)} {left} AND SoToa {op2} {right}";
                    }
                    // Trường hợp đơn: >5, <=10, =7, !=3
                    else if (Regex.IsMatch(cleaned, @"^(>=|<=|!=|=|>|<)\d+$"))
                    {
                        Match match = Regex.Match(cleaned, @"^(>=|<=|!=|=|>|<)(\d+)$");
                        string op = match.Groups[1].Value;
                        int value = int.Parse(match.Groups[2].Value);

                        filter += $" AND SoToa {op} {value}";
                    }
                    // Trường hợp là số bình thường
                    else if (int.TryParse(cleaned, out int soToaInt))
                    {
                        filter += $" AND SoToa = {soToaInt}";
                    }
                    else
                    {
                        MessageBox.Show("Định dạng số toa không hợp lệ.\nVí dụ: >5, <=10, 1<x<3");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi phân tích điều kiện số toa.");
                    return;
                }
            }

            DataTable dta = kn.Lay_DuLieuBang(filter);
            dgvTau.DataSource = dta;

            if (dgvTau.Rows.Count > 0)
            {
                dgvTau.Rows[0].Selected = true;
                Hienthi();
            }
        }

        private string GetReverseOperator(string op)
        {
            switch (op)
            {
                case "<": return ">";
                case "<=": return ">=";
                default:
                    throw new ArgumentException("Toán tử không hợp lệ trong khoảng: " + op, nameof(op));
            }
        }

        private void Hienthi()
        {
            if (dgvTau.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvTau.SelectedRows[0];

                TXT_MATAU.Text = row.Cells["maTauDataGridViewTextBoxColumn"].Value?.ToString();
                TXT_TENTAU.Text = row.Cells["tenTauDataGridViewTextBoxColumn"].Value?.ToString();
                TXT_SOTOA.Text = row.Cells["soToaDataGridViewTextBoxColumn"].Value?.ToString();
            }

            isBindingCleared = false;
        }


        private void btn_Lammoi_Click(object sender, EventArgs e)
        {
            TXT_MATAU.Text = string.Empty;
            TXT_TENTAU.Text = string.Empty;
            TXT_SOTOA.Text = string.Empty;
            TXT_MATAU.Focus();
        }

        private void TextBox_Modified(object sender, EventArgs e)
        {
            if (!isBindingCleared)
            {
                isBindingCleared = true;
                dgvTau.ClearSelection();
            }
        }


        private void dgvTau_SelectionChanged(object sender, EventArgs e)
        {
            if (!isBindingCleared)
            {
                Hienthi();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dgvTau.SelectedRows.Count > 0)
            {
                string maTau = dgvTau.SelectedRows[0].Cells["maTauDataGridViewTextBoxColumn"].Value.ToString();

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tàu có mã '" + maTau + "' không?",
                                                      "Xác nhận xóa",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string sql_xoa = $"DELETE FROM TAU WHERE MaTau = '{maTau}'";
                        kn.ThucThi(sql_xoa);
                        this.tAUTableAdapter.Fill(this.qLI_VETAUDataSet.TAU);

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
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            frm_ThemTau themForm = new frm_ThemTau();
            themForm.ShowDialog();
            Hienthi();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (dgvTau.SelectedRows.Count > 0)
            {
                string maTau = dgvTau.SelectedRows[0].Cells[0].Value.ToString();
                string tenTau = dgvTau.SelectedRows[0].Cells[1].Value.ToString();
                string soToa = dgvTau.SelectedRows[0].Cells[2].Value.ToString();

                Frm_SuaTau suaForm = new Frm_SuaTau(maTau, tenTau, soToa);
                suaForm.ShowDialog();
                Hienthi();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tàu để sửa!");
            }
        }
    }
}
