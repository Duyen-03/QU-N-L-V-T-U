namespace QUANLY_VETAU
{
    partial class frm_QuanLyLichTrinh
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
            this.btn_SuaLichTrinh = new System.Windows.Forms.Button();
            this.TXT_GIODEN = new System.Windows.Forms.DateTimePicker();
            this.TXT_GIODI = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ThemTau = new System.Windows.Forms.Button();
            this.CBO_GADEN = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.CBO_GADI = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Xemtatca = new System.Windows.Forms.Button();
            this.dgv_LichTrinh = new System.Windows.Forms.DataGridView();
            this.maLichTrinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gaDiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gaDenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioDiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioDenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lICHTRINHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLI_VETAUDataSet = new QUANLY_VETAU.QLI_VETAUDataSet();
            this.btn_ThemLichTrinh = new System.Windows.Forms.Button();
            this.btn_XoaLichTrinh = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.TXT_MALICHTRINH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TXT_TENGADI = new System.Windows.Forms.TextBox();
            this.TXT_DCGADI = new System.Windows.Forms.TextBox();
            this.TXT_TENGADEN = new System.Windows.Forms.TextBox();
            this.TXT_DCGADEN = new System.Windows.Forms.TextBox();
            this.bttn_LamMoi = new System.Windows.Forms.Button();
            this.lICHTRINHTableAdapter = new QUANLY_VETAU.QLI_VETAUDataSetTableAdapters.LICHTRINHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LichTrinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lICHTRINHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLI_VETAUDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(34, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 213;
            this.label1.Text = "Lọc theo:";
            // 
            // btn_SuaLichTrinh
            // 
            this.btn_SuaLichTrinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_SuaLichTrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaLichTrinh.Location = new System.Drawing.Point(643, 539);
            this.btn_SuaLichTrinh.Name = "btn_SuaLichTrinh";
            this.btn_SuaLichTrinh.Size = new System.Drawing.Size(140, 40);
            this.btn_SuaLichTrinh.TabIndex = 212;
            this.btn_SuaLichTrinh.Text = "Sửa lịch trình";
            this.btn_SuaLichTrinh.UseVisualStyleBackColor = false;
            this.btn_SuaLichTrinh.Click += new System.EventHandler(this.btn_SuaLichTrinh_Click);
            // 
            // TXT_GIODEN
            // 
            this.TXT_GIODEN.CustomFormat = "dd/MM/yyyy HH:mm";
            this.TXT_GIODEN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TXT_GIODEN.Location = new System.Drawing.Point(536, 170);
            this.TXT_GIODEN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXT_GIODEN.Name = "TXT_GIODEN";
            this.TXT_GIODEN.Size = new System.Drawing.Size(184, 22);
            this.TXT_GIODEN.TabIndex = 210;
            this.TXT_GIODEN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_TimKiem_Keydown);
            // 
            // TXT_GIODI
            // 
            this.TXT_GIODI.CustomFormat = "dd/MM/yyyy HH:mm";
            this.TXT_GIODI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TXT_GIODI.Location = new System.Drawing.Point(274, 171);
            this.TXT_GIODI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXT_GIODI.Name = "TXT_GIODI";
            this.TXT_GIODI.Size = new System.Drawing.Size(184, 22);
            this.TXT_GIODI.TabIndex = 208;
            this.TXT_GIODI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_TimKiem_Keydown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(492, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 16);
            this.label7.TabIndex = 206;
            this.label7.Text = "Đến:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(242, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 16);
            this.label8.TabIndex = 205;
            this.label8.Text = "Từ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 202;
            this.label4.Text = "Lịch Trình:";
            // 
            // btn_ThemTau
            // 
            this.btn_ThemTau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_ThemTau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemTau.Location = new System.Drawing.Point(243, 539);
            this.btn_ThemTau.Name = "btn_ThemTau";
            this.btn_ThemTau.Size = new System.Drawing.Size(140, 40);
            this.btn_ThemTau.TabIndex = 200;
            this.btn_ThemTau.Text = "Thêm chuyến tàu";
            this.btn_ThemTau.UseVisualStyleBackColor = false;
            this.btn_ThemTau.Click += new System.EventHandler(this.btn_ThemTau_Click);
            // 
            // CBO_GADEN
            // 
            this.CBO_GADEN.FormattingEnabled = true;
            this.CBO_GADEN.Location = new System.Drawing.Point(640, 16);
            this.CBO_GADEN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBO_GADEN.Name = "CBO_GADEN";
            this.CBO_GADEN.Size = new System.Drawing.Size(208, 24);
            this.CBO_GADEN.TabIndex = 198;
            this.CBO_GADEN.SelectedIndexChanged += new System.EventHandler(this.CBO_GADEN_SelectedIndexChanged);
            this.CBO_GADEN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_TimKiem_Keydown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(570, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 196;
            this.label2.Text = "Ga đến:";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_TimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TimKiem.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Location = new System.Drawing.Point(878, 159);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(103, 34);
            this.btn_TimKiem.TabIndex = 199;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // CBO_GADI
            // 
            this.CBO_GADI.FormattingEnabled = true;
            this.CBO_GADI.Location = new System.Drawing.Point(320, 16);
            this.CBO_GADI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBO_GADI.Name = "CBO_GADI";
            this.CBO_GADI.Size = new System.Drawing.Size(208, 24);
            this.CBO_GADI.TabIndex = 197;
            this.CBO_GADI.SelectedIndexChanged += new System.EventHandler(this.CBO_GADI_SelectedIndexChanged);
            this.CBO_GADI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_TimKiem_Keydown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(260, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 16);
            this.label10.TabIndex = 195;
            this.label10.Text = "Ga đi:";
            // 
            // btn_Xemtatca
            // 
            this.btn_Xemtatca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Xemtatca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xemtatca.Location = new System.Drawing.Point(43, 539);
            this.btn_Xemtatca.Name = "btn_Xemtatca";
            this.btn_Xemtatca.Size = new System.Drawing.Size(140, 40);
            this.btn_Xemtatca.TabIndex = 194;
            this.btn_Xemtatca.Text = "Xem tất cả";
            this.btn_Xemtatca.UseVisualStyleBackColor = false;
            this.btn_Xemtatca.Click += new System.EventHandler(this.btn_Xemtatca_Click);
            // 
            // dgv_LichTrinh
            // 
            this.dgv_LichTrinh.AutoGenerateColumns = false;
            this.dgv_LichTrinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_LichTrinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LichTrinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLichTrinhDataGridViewTextBoxColumn,
            this.gaDiDataGridViewTextBoxColumn,
            this.gaDenDataGridViewTextBoxColumn,
            this.gioDiDataGridViewTextBoxColumn,
            this.gioDenDataGridViewTextBoxColumn});
            this.dgv_LichTrinh.DataSource = this.lICHTRINHBindingSource;
            this.dgv_LichTrinh.Location = new System.Drawing.Point(38, 212);
            this.dgv_LichTrinh.Name = "dgv_LichTrinh";
            this.dgv_LichTrinh.ReadOnly = true;
            this.dgv_LichTrinh.RowHeadersWidth = 51;
            this.dgv_LichTrinh.RowTemplate.Height = 24;
            this.dgv_LichTrinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_LichTrinh.Size = new System.Drawing.Size(943, 302);
            this.dgv_LichTrinh.TabIndex = 193;
            this.dgv_LichTrinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LichTrinh_CellClick);
            // 
            // maLichTrinhDataGridViewTextBoxColumn
            // 
            this.maLichTrinhDataGridViewTextBoxColumn.DataPropertyName = "MaLichTrinh";
            this.maLichTrinhDataGridViewTextBoxColumn.HeaderText = "MaLichTrinh";
            this.maLichTrinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maLichTrinhDataGridViewTextBoxColumn.Name = "maLichTrinhDataGridViewTextBoxColumn";
            this.maLichTrinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gaDiDataGridViewTextBoxColumn
            // 
            this.gaDiDataGridViewTextBoxColumn.DataPropertyName = "GaDi";
            this.gaDiDataGridViewTextBoxColumn.HeaderText = "GaDi";
            this.gaDiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gaDiDataGridViewTextBoxColumn.Name = "gaDiDataGridViewTextBoxColumn";
            this.gaDiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gaDenDataGridViewTextBoxColumn
            // 
            this.gaDenDataGridViewTextBoxColumn.DataPropertyName = "GaDen";
            this.gaDenDataGridViewTextBoxColumn.HeaderText = "GaDen";
            this.gaDenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gaDenDataGridViewTextBoxColumn.Name = "gaDenDataGridViewTextBoxColumn";
            this.gaDenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gioDiDataGridViewTextBoxColumn
            // 
            this.gioDiDataGridViewTextBoxColumn.DataPropertyName = "GioDi";
            this.gioDiDataGridViewTextBoxColumn.HeaderText = "GioDi";
            this.gioDiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gioDiDataGridViewTextBoxColumn.Name = "gioDiDataGridViewTextBoxColumn";
            this.gioDiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gioDenDataGridViewTextBoxColumn
            // 
            this.gioDenDataGridViewTextBoxColumn.DataPropertyName = "GioDen";
            this.gioDenDataGridViewTextBoxColumn.HeaderText = "GioDen";
            this.gioDenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gioDenDataGridViewTextBoxColumn.Name = "gioDenDataGridViewTextBoxColumn";
            this.gioDenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lICHTRINHBindingSource
            // 
            this.lICHTRINHBindingSource.DataMember = "LICHTRINH";
            this.lICHTRINHBindingSource.DataSource = this.qLI_VETAUDataSet;
            // 
            // qLI_VETAUDataSet
            // 
            this.qLI_VETAUDataSet.DataSetName = "QLI_VETAUDataSet";
            this.qLI_VETAUDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_ThemLichTrinh
            // 
            this.btn_ThemLichTrinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_ThemLichTrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemLichTrinh.Location = new System.Drawing.Point(443, 539);
            this.btn_ThemLichTrinh.Name = "btn_ThemLichTrinh";
            this.btn_ThemLichTrinh.Size = new System.Drawing.Size(140, 40);
            this.btn_ThemLichTrinh.TabIndex = 192;
            this.btn_ThemLichTrinh.Text = "Thêm lịch trình";
            this.btn_ThemLichTrinh.UseVisualStyleBackColor = false;
            this.btn_ThemLichTrinh.Click += new System.EventHandler(this.btn_ThemLichTrinh_Click);
            // 
            // btn_XoaLichTrinh
            // 
            this.btn_XoaLichTrinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_XoaLichTrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaLichTrinh.Location = new System.Drawing.Point(843, 539);
            this.btn_XoaLichTrinh.Name = "btn_XoaLichTrinh";
            this.btn_XoaLichTrinh.Size = new System.Drawing.Size(140, 40);
            this.btn_XoaLichTrinh.TabIndex = 212;
            this.btn_XoaLichTrinh.Text = "Xoá lịch trình";
            this.btn_XoaLichTrinh.UseVisualStyleBackColor = false;
            this.btn_XoaLichTrinh.Click += new System.EventHandler(this.btn_XoaLichTrinh_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 214;
            this.label9.Text = "Mã Lịch Trình:";
            // 
            // TXT_MALICHTRINH
            // 
            this.TXT_MALICHTRINH.Location = new System.Drawing.Point(38, 102);
            this.TXT_MALICHTRINH.Name = "TXT_MALICHTRINH";
            this.TXT_MALICHTRINH.Size = new System.Drawing.Size(145, 22);
            this.TXT_MALICHTRINH.TabIndex = 215;
            this.TXT_MALICHTRINH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_TimKiem_Keydown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 195;
            this.label3.Text = "Tên ga:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 195;
            this.label5.Text = "Địa Chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(570, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 195;
            this.label6.Text = "Tên ga:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(570, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 16);
            this.label11.TabIndex = 195;
            this.label11.Text = "Địa Chỉ:";
            // 
            // TXT_TENGADI
            // 
            this.TXT_TENGADI.Enabled = false;
            this.TXT_TENGADI.Location = new System.Drawing.Point(320, 70);
            this.TXT_TENGADI.Name = "TXT_TENGADI";
            this.TXT_TENGADI.Size = new System.Drawing.Size(208, 22);
            this.TXT_TENGADI.TabIndex = 215;
            // 
            // TXT_DCGADI
            // 
            this.TXT_DCGADI.Enabled = false;
            this.TXT_DCGADI.Location = new System.Drawing.Point(320, 105);
            this.TXT_DCGADI.Name = "TXT_DCGADI";
            this.TXT_DCGADI.Size = new System.Drawing.Size(208, 22);
            this.TXT_DCGADI.TabIndex = 215;
            // 
            // TXT_TENGADEN
            // 
            this.TXT_TENGADEN.Enabled = false;
            this.TXT_TENGADEN.Location = new System.Drawing.Point(640, 70);
            this.TXT_TENGADEN.Name = "TXT_TENGADEN";
            this.TXT_TENGADEN.Size = new System.Drawing.Size(208, 22);
            this.TXT_TENGADEN.TabIndex = 215;
            // 
            // TXT_DCGADEN
            // 
            this.TXT_DCGADEN.Enabled = false;
            this.TXT_DCGADEN.Location = new System.Drawing.Point(640, 105);
            this.TXT_DCGADEN.Name = "TXT_DCGADEN";
            this.TXT_DCGADEN.Size = new System.Drawing.Size(208, 22);
            this.TXT_DCGADEN.TabIndex = 215;
            // 
            // bttn_LamMoi
            // 
            this.bttn_LamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bttn_LamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttn_LamMoi.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_LamMoi.Location = new System.Drawing.Point(878, 45);
            this.bttn_LamMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttn_LamMoi.Name = "bttn_LamMoi";
            this.bttn_LamMoi.Size = new System.Drawing.Size(103, 34);
            this.bttn_LamMoi.TabIndex = 199;
            this.bttn_LamMoi.Text = "Làm mới";
            this.bttn_LamMoi.UseVisualStyleBackColor = false;
            this.bttn_LamMoi.Click += new System.EventHandler(this.bttn_LamMoi_Click);
            // 
            // lICHTRINHTableAdapter
            // 
            this.lICHTRINHTableAdapter.ClearBeforeFill = true;
            // 
            // frm_QuanLyLichTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 596);
            this.Controls.Add(this.TXT_DCGADEN);
            this.Controls.Add(this.TXT_TENGADEN);
            this.Controls.Add(this.TXT_DCGADI);
            this.Controls.Add(this.TXT_TENGADI);
            this.Controls.Add(this.TXT_MALICHTRINH);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_XoaLichTrinh);
            this.Controls.Add(this.btn_SuaLichTrinh);
            this.Controls.Add(this.TXT_GIODEN);
            this.Controls.Add(this.TXT_GIODI);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_ThemTau);
            this.Controls.Add(this.CBO_GADEN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttn_LamMoi);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.CBO_GADI);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_Xemtatca);
            this.Controls.Add(this.dgv_LichTrinh);
            this.Controls.Add(this.btn_ThemLichTrinh);
            this.Name = "frm_QuanLyLichTrinh";
            this.Text = "Form Quản Lý Lịch Trình";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_QuanLyLichTrinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LichTrinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lICHTRINHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLI_VETAUDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_SuaLichTrinh;
        private System.Windows.Forms.DateTimePicker TXT_GIODEN;
        private System.Windows.Forms.DateTimePicker TXT_GIODI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ThemTau;
        private System.Windows.Forms.ComboBox CBO_GADEN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.ComboBox CBO_GADI;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Xemtatca;
        private System.Windows.Forms.DataGridView dgv_LichTrinh;
        private System.Windows.Forms.Button btn_ThemLichTrinh;
        private System.Windows.Forms.Button btn_XoaLichTrinh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TXT_MALICHTRINH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TXT_TENGADI;
        private System.Windows.Forms.TextBox TXT_DCGADI;
        private System.Windows.Forms.TextBox TXT_TENGADEN;
        private System.Windows.Forms.TextBox TXT_DCGADEN;
        private System.Windows.Forms.Button bttn_LamMoi;
        private QLI_VETAUDataSet qLI_VETAUDataSet;
        private System.Windows.Forms.BindingSource lICHTRINHBindingSource;
        private QLI_VETAUDataSetTableAdapters.LICHTRINHTableAdapter lICHTRINHTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLichTrinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gaDiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gaDenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioDiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioDenDataGridViewTextBoxColumn;
    }
}