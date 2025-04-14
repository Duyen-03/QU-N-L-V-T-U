namespace QUANLY_VETAU
{
    partial class frm_QuanLyTau
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Timkiem = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.dgvTau = new System.Windows.Forms.DataGridView();
            this.maTauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soToaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLI_VETAUDataSet = new QUANLY_VETAU.QLI_VETAUDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TXT_SOTOA = new System.Windows.Forms.TextBox();
            this.TXT_TENTAU = new System.Windows.Forms.TextBox();
            this.TXT_MATAU = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Lammoi = new System.Windows.Forms.Button();
            this.tAUTableAdapter = new QUANLY_VETAU.QLI_VETAUDataSetTableAdapters.TAUTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLI_VETAUDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(61, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 19);
            this.label1.TabIndex = 250;
            this.label1.Text = "Danh sách Tàu:";
            // 
            // btn_Timkiem
            // 
            this.btn_Timkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Timkiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Timkiem.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Timkiem.Location = new System.Drawing.Point(802, 137);
            this.btn_Timkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Timkiem.Name = "btn_Timkiem";
            this.btn_Timkiem.Size = new System.Drawing.Size(103, 35);
            this.btn_Timkiem.TabIndex = 238;
            this.btn_Timkiem.Text = "Tìm kiếm";
            this.btn_Timkiem.UseVisualStyleBackColor = false;
            this.btn_Timkiem.Click += new System.EventHandler(this.btn_Timkiem_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(380, 500);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(160, 33);
            this.btn_Sua.TabIndex = 174;
            this.btn_Sua.Text = "Sửa chuyến tàu";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(130, 500);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(160, 33);
            this.btn_Them.TabIndex = 168;
            this.btn_Them.Text = "Thêm Chuyến Tàu";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(630, 500);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(160, 33);
            this.btn_Xoa.TabIndex = 167;
            this.btn_Xoa.Text = "Xoá chuyến tàu";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // dgvTau
            // 
            this.dgvTau.AutoGenerateColumns = false;
            this.dgvTau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maTauDataGridViewTextBoxColumn,
            this.tenTauDataGridViewTextBoxColumn,
            this.soToaDataGridViewTextBoxColumn});
            this.dgvTau.DataSource = this.tAUBindingSource;
            this.dgvTau.Location = new System.Drawing.Point(63, 196);
            this.dgvTau.Name = "dgvTau";
            this.dgvTau.ReadOnly = true;
            this.dgvTau.RowHeadersWidth = 51;
            this.dgvTau.RowTemplate.Height = 24;
            this.dgvTau.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTau.Size = new System.Drawing.Size(842, 287);
            this.dgvTau.TabIndex = 166;
            this.dgvTau.SelectionChanged += new System.EventHandler(this.dgvTau_SelectionChanged);
            // 
            // maTauDataGridViewTextBoxColumn
            // 
            this.maTauDataGridViewTextBoxColumn.DataPropertyName = "MaTau";
            this.maTauDataGridViewTextBoxColumn.HeaderText = "MaTau";
            this.maTauDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maTauDataGridViewTextBoxColumn.Name = "maTauDataGridViewTextBoxColumn";
            this.maTauDataGridViewTextBoxColumn.ReadOnly = true;
            this.maTauDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenTauDataGridViewTextBoxColumn
            // 
            this.tenTauDataGridViewTextBoxColumn.DataPropertyName = "TenTau";
            this.tenTauDataGridViewTextBoxColumn.HeaderText = "TenTau";
            this.tenTauDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenTauDataGridViewTextBoxColumn.Name = "tenTauDataGridViewTextBoxColumn";
            this.tenTauDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenTauDataGridViewTextBoxColumn.Width = 125;
            // 
            // soToaDataGridViewTextBoxColumn
            // 
            this.soToaDataGridViewTextBoxColumn.DataPropertyName = "SoToa";
            this.soToaDataGridViewTextBoxColumn.HeaderText = "SoToa";
            this.soToaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soToaDataGridViewTextBoxColumn.Name = "soToaDataGridViewTextBoxColumn";
            this.soToaDataGridViewTextBoxColumn.ReadOnly = true;
            this.soToaDataGridViewTextBoxColumn.Width = 125;
            // 
            // tAUBindingSource
            // 
            this.tAUBindingSource.DataMember = "TAU";
            this.tAUBindingSource.DataSource = this.qLI_VETAUDataSet;
            // 
            // qLI_VETAUDataSet
            // 
            this.qLI_VETAUDataSet.DataSetName = "QLI_VETAUDataSet";
            this.qLI_VETAUDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.TXT_SOTOA);
            this.panel1.Controls.Add(this.TXT_TENTAU);
            this.panel1.Controls.Add(this.TXT_MATAU);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Lammoi);
            this.panel1.Controls.Add(this.btn_Timkiem);
            this.panel1.Controls.Add(this.btn_Sua);
            this.panel1.Controls.Add(this.btn_Them);
            this.panel1.Controls.Add(this.btn_Xoa);
            this.panel1.Controls.Add(this.dgvTau);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 571);
            this.panel1.TabIndex = 1;
            // 
            // TXT_SOTOA
            // 
            this.TXT_SOTOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_SOTOA.Location = new System.Drawing.Point(200, 150);
            this.TXT_SOTOA.Name = "TXT_SOTOA";
            this.TXT_SOTOA.Size = new System.Drawing.Size(452, 24);
            this.TXT_SOTOA.TabIndex = 252;
            this.TXT_SOTOA.TextChanged += new System.EventHandler(this.TextBox_Modified);
            this.TXT_SOTOA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_TimKiem_Keydown);
            // 
            // TXT_TENTAU
            // 
            this.TXT_TENTAU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_TENTAU.Location = new System.Drawing.Point(200, 110);
            this.TXT_TENTAU.Name = "TXT_TENTAU";
            this.TXT_TENTAU.Size = new System.Drawing.Size(452, 24);
            this.TXT_TENTAU.TabIndex = 252;
            this.TXT_TENTAU.TextChanged += new System.EventHandler(this.TextBox_Modified);
            this.TXT_TENTAU.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_TimKiem_Keydown);
            // 
            // TXT_MATAU
            // 
            this.TXT_MATAU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_MATAU.Location = new System.Drawing.Point(200, 70);
            this.TXT_MATAU.Name = "TXT_MATAU";
            this.TXT_MATAU.Size = new System.Drawing.Size(452, 24);
            this.TXT_MATAU.TabIndex = 252;
            this.TXT_MATAU.TextChanged += new System.EventHandler(this.TextBox_Modified);
            this.TXT_MATAU.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_TimKiem_Keydown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 251;
            this.label3.Text = "Mã tàu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(136, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 251;
            this.label4.Text = "Số toa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 251;
            this.label2.Text = "Tên tàu:";
            // 
            // btn_Lammoi
            // 
            this.btn_Lammoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Lammoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Lammoi.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Lammoi.Location = new System.Drawing.Point(802, 63);
            this.btn_Lammoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Lammoi.Name = "btn_Lammoi";
            this.btn_Lammoi.Size = new System.Drawing.Size(103, 35);
            this.btn_Lammoi.TabIndex = 238;
            this.btn_Lammoi.Text = "Làm mới";
            this.btn_Lammoi.UseVisualStyleBackColor = false;
            this.btn_Lammoi.Click += new System.EventHandler(this.btn_Lammoi_Click);
            // 
            // tAUTableAdapter
            // 
            this.tAUTableAdapter.ClearBeforeFill = true;
            // 
            // frm_QuanLyTau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 571);
            this.Controls.Add(this.panel1);
            this.Name = "frm_QuanLyTau";
            this.Text = "Form Quản Lý Tàu";
            this.Load += new System.EventHandler(this.frm_QuanLyTau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLI_VETAUDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Timkiem;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.DataGridView dgvTau;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_MATAU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private QLI_VETAUDataSet qLI_VETAUDataSet;
        private System.Windows.Forms.BindingSource tAUBindingSource;
        private QLI_VETAUDataSetTableAdapters.TAUTableAdapter tAUTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soToaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox TXT_SOTOA;
        private System.Windows.Forms.TextBox TXT_TENTAU;
        private System.Windows.Forms.Button btn_Lammoi;
    }
}