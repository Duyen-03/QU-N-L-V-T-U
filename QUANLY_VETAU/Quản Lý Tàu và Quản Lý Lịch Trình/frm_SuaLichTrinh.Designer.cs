namespace QUANLY_VETAU
{
    partial class frm_SuaLichTrinh
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
            this.TXT_DCGADEN = new System.Windows.Forms.TextBox();
            this.TXT_TENGADEN = new System.Windows.Forms.TextBox();
            this.TXT_DCGADI = new System.Windows.Forms.TextBox();
            this.TXT_TENGADI = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lICHTRINHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLI_VETAUDataSet = new QUANLY_VETAU.QLI_VETAUDataSet();
            this.TXT_MALICHTRINH = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lICHTRINHTableAdapter = new QUANLY_VETAU.QLI_VETAUDataSetTableAdapters.LICHTRINHTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_GIODEN = new System.Windows.Forms.DateTimePicker();
            this.TXT_GIODI = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CBO_GADEN = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CBO_GADI = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Sua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lICHTRINHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLI_VETAUDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // TXT_DCGADEN
            // 
            this.TXT_DCGADEN.Enabled = false;
            this.TXT_DCGADEN.Location = new System.Drawing.Point(663, 133);
            this.TXT_DCGADEN.Name = "TXT_DCGADEN";
            this.TXT_DCGADEN.Size = new System.Drawing.Size(208, 22);
            this.TXT_DCGADEN.TabIndex = 243;
            // 
            // TXT_TENGADEN
            // 
            this.TXT_TENGADEN.Enabled = false;
            this.TXT_TENGADEN.Location = new System.Drawing.Point(663, 98);
            this.TXT_TENGADEN.Name = "TXT_TENGADEN";
            this.TXT_TENGADEN.Size = new System.Drawing.Size(208, 22);
            this.TXT_TENGADEN.TabIndex = 242;
            // 
            // TXT_DCGADI
            // 
            this.TXT_DCGADI.Enabled = false;
            this.TXT_DCGADI.Location = new System.Drawing.Point(343, 133);
            this.TXT_DCGADI.Name = "TXT_DCGADI";
            this.TXT_DCGADI.Size = new System.Drawing.Size(208, 22);
            this.TXT_DCGADI.TabIndex = 241;
            // 
            // TXT_TENGADI
            // 
            this.TXT_TENGADI.Enabled = false;
            this.TXT_TENGADI.Location = new System.Drawing.Point(343, 98);
            this.TXT_TENGADI.Name = "TXT_TENGADI";
            this.TXT_TENGADI.Size = new System.Drawing.Size(208, 22);
            this.TXT_TENGADI.TabIndex = 240;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(593, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 16);
            this.label11.TabIndex = 220;
            this.label11.Text = "Địa Chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 221;
            this.label5.Text = "Địa Chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(593, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 222;
            this.label6.Text = "Tên ga:";
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
            // TXT_MALICHTRINH
            // 
            this.TXT_MALICHTRINH.Enabled = false;
            this.TXT_MALICHTRINH.Location = new System.Drawing.Point(61, 130);
            this.TXT_MALICHTRINH.Name = "TXT_MALICHTRINH";
            this.TXT_MALICHTRINH.Size = new System.Drawing.Size(145, 22);
            this.TXT_MALICHTRINH.TabIndex = 239;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 238;
            this.label9.Text = "Mã Lịch Trình:";
            // 
            // btn_Huy
            // 
            this.btn_Huy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.Location = new System.Drawing.Point(834, 284);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(140, 40);
            this.btn_Huy.TabIndex = 235;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 223;
            this.label3.Text = "Tên ga:";
            // 
            // lICHTRINHTableAdapter
            // 
            this.lICHTRINHTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(57, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 237;
            this.label1.Text = "Lọc theo:";
            // 
            // TXT_GIODEN
            // 
            this.TXT_GIODEN.CustomFormat = "dd/MM/yyyy HH:mm";
            this.TXT_GIODEN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TXT_GIODEN.Location = new System.Drawing.Point(559, 198);
            this.TXT_GIODEN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXT_GIODEN.Name = "TXT_GIODEN";
            this.TXT_GIODEN.Size = new System.Drawing.Size(184, 22);
            this.TXT_GIODEN.TabIndex = 234;
            // 
            // TXT_GIODI
            // 
            this.TXT_GIODI.CustomFormat = "dd/MM/yyyy HH:mm";
            this.TXT_GIODI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TXT_GIODI.Location = new System.Drawing.Point(297, 199);
            this.TXT_GIODI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXT_GIODI.Name = "TXT_GIODI";
            this.TXT_GIODI.Size = new System.Drawing.Size(184, 22);
            this.TXT_GIODI.TabIndex = 233;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(515, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 16);
            this.label7.TabIndex = 232;
            this.label7.Text = "Đến:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(265, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 16);
            this.label8.TabIndex = 231;
            this.label8.Text = "Từ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 230;
            this.label4.Text = "Lịch Trình:";
            // 
            // CBO_GADEN
            // 
            this.CBO_GADEN.FormattingEnabled = true;
            this.CBO_GADEN.Location = new System.Drawing.Point(663, 44);
            this.CBO_GADEN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBO_GADEN.Name = "CBO_GADEN";
            this.CBO_GADEN.Size = new System.Drawing.Size(208, 24);
            this.CBO_GADEN.TabIndex = 226;
            this.CBO_GADEN.SelectedIndexChanged += new System.EventHandler(this.CBO_GADEN_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(593, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 224;
            this.label2.Text = "Ga đến:";
            // 
            // CBO_GADI
            // 
            this.CBO_GADI.FormattingEnabled = true;
            this.CBO_GADI.Location = new System.Drawing.Point(343, 44);
            this.CBO_GADI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBO_GADI.Name = "CBO_GADI";
            this.CBO_GADI.Size = new System.Drawing.Size(208, 24);
            this.CBO_GADI.TabIndex = 225;
            this.CBO_GADI.SelectedIndexChanged += new System.EventHandler(this.CBO_GADI_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(283, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 16);
            this.label10.TabIndex = 219;
            this.label10.Text = "Ga đi:";
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(34, 284);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(140, 40);
            this.btn_Sua.TabIndex = 218;
            this.btn_Sua.Text = "Xác Nhận";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // frm_SuaLichTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 368);
            this.Controls.Add(this.TXT_DCGADEN);
            this.Controls.Add(this.TXT_TENGADEN);
            this.Controls.Add(this.TXT_DCGADI);
            this.Controls.Add(this.TXT_TENGADI);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TXT_MALICHTRINH);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_GIODEN);
            this.Controls.Add(this.TXT_GIODI);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CBO_GADEN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBO_GADI);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_Sua);
            this.Name = "frm_SuaLichTrinh";
            this.Text = "frm_SuaLichTrinh";
            this.Load += new System.EventHandler(this.frm_SuaLichTrinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lICHTRINHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLI_VETAUDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TXT_DCGADEN;
        private System.Windows.Forms.TextBox TXT_TENGADEN;
        private System.Windows.Forms.TextBox TXT_DCGADI;
        private System.Windows.Forms.TextBox TXT_TENGADI;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource lICHTRINHBindingSource;
        private QLI_VETAUDataSet qLI_VETAUDataSet;
        private System.Windows.Forms.TextBox TXT_MALICHTRINH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Label label3;
        private QLI_VETAUDataSetTableAdapters.LICHTRINHTableAdapter lICHTRINHTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker TXT_GIODEN;
        private System.Windows.Forms.DateTimePicker TXT_GIODI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBO_GADEN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBO_GADI;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Sua;
    }
}