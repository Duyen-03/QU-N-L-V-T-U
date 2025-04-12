using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BTN_QLIVETAU
{
    public partial class frm_GATAU : Form
    {
        public frm_GATAU()
        {
            InitializeComponent();
        }

        KETNOI_DULIEU kn = new KETNOI_DULIEU();
        public void Load_GaTau()
        {
            DataTable dta = kn.Lay_DuLieuBang("SELECT * FROM GATAU");
            dataGridView1.DataSource = dta;
        }

        private void frm_GATAU_Load(object sender, EventArgs e)

        {
            Load_GaTau();
            // TODO: This line of code loads data into the 'qLI_VETAUDataSet.GATAU' table. You can move, or remove it, as needed.
            this.gATAUTableAdapter.Fill(this.qLI_VETAUDataSet.GATAU);
            if (!dataGridView1.Columns.Contains("btn_Hanhdong"))
            {
                DataGridViewTextBoxColumn hanhDongCol = new DataGridViewTextBoxColumn();
                hanhDongCol.Name = "btn_Hanhdong";
                hanhDongCol.HeaderText = "Hành động";
                hanhDongCol.Width = 120;
                dataGridView1.Columns.Add(hanhDongCol);
            }
            
            dataGridView1.CellPainting += dataGridView1_CellPainting;
            dataGridView1.CellClick += dataGridView1_CellClick;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "btn_Hanhdong")
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                int width = (e.CellBounds.Width - 10) / 2;

                Rectangle rectEdit = new Rectangle(e.CellBounds.X + 5, e.CellBounds.Y + 5, width - 5, e.CellBounds.Height - 10);
                Rectangle rectDelete = new Rectangle(e.CellBounds.X + width + 10, e.CellBounds.Y + 5, width - 5, e.CellBounds.Height - 10);

                ButtonRenderer.DrawButton(e.Graphics, rectEdit, "Sửa", this.Font, false, PushButtonState.Default);
                ButtonRenderer.DrawButton(e.Graphics, rectDelete, "Xóa", this.Font, false, PushButtonState.Default);

                e.Handled = true;
            }
        }
        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "btn_Hanhdong")
            {
                Rectangle cellRect = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                Point clickPoint = dataGridView1.PointToClient(Cursor.Position);
                int relativeX = clickPoint.X - cellRect.X;
                int buttonWidth = (cellRect.Width - 10) / 2;

                string maGa = dataGridView1.Rows[e.RowIndex].Cells["MaGa"].Value.ToString();

                // Kiểm tra xem nhấn vào "Sửa" hay "Xóa"
                if (relativeX <= buttonWidth)  // Nút "Sửa"
                {
                    frm_UPDATEGA frm = new frm_UPDATEGA(maGa);
                    frm.ShowDialog();
                    Load_GaTau();
                    return;
                }
                else if (relativeX > buttonWidth)
                {
                    // Check if Ga is being used in LICHTRINH
                    string sqlCheck = "SELECT COUNT(*) FROM LICHTRINH WHERE GaDi = '" + maGa + "' OR GaDen = '" + maGa + "'";
                    int count = Convert.ToInt32(kn.LayGiaTri(sqlCheck));  // Assuming `kn.LayGiaTri` gets the scalar value

                    if (count > 0)
                    {
                        // If there are references in LICHTRINH, show a message and prevent deletion
                        MessageBox.Show("Ga này đang được sử dụng trong lịch trình tàu. Không thể xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        // If no references, proceed with delete
                        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa ga này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            string sqlXoa = "DELETE FROM GATAU WHERE MaGa = '" + maGa + "'";
                            kn.ThucThi(sqlXoa);
                            MessageBox.Show("Đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Load_GaTau();  // Reload data after deletion
                        }
                    }
                }
            }
        }

        private void btn_THEM_Click(object sender, EventArgs e)
        {
            frm_UPDATEGA frm = new frm_UPDATEGA();  // Không cần truyền maGa
            frm.ShowDialog();
            Load_GaTau();
        }
    }
}
