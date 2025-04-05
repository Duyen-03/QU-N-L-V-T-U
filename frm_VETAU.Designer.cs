namespace BTN_QLIVETAU
{
    partial class frm_VETAU
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
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.time_Den = new System.Windows.Forms.DateTimePicker();
            this.time_Di = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbbDes = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_TIMKIEM = new System.Windows.Forms.Button();
            this.cbbDep = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.butmua = new System.Windows.Forms.Button();
            this.dtaGd_TAU = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGd_TAU)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(171, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 24);
            this.label5.TabIndex = 253;
            this.label5.Text = "Lọc theo:";
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(173, 149);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(134, 61);
            this.checkBox1.TabIndex = 252;
            this.checkBox1.Text = "Tìm kiếm theo thời gian";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // time_Den
            // 
            this.time_Den.CustomFormat = "dd/MM/yyyy HH:mm";
            this.time_Den.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.time_Den.Location = new System.Drawing.Point(791, 172);
            this.time_Den.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.time_Den.Name = "time_Den";
            this.time_Den.Size = new System.Drawing.Size(206, 26);
            this.time_Den.TabIndex = 250;
            // 
            // time_Di
            // 
            this.time_Di.CustomFormat = "dd/MM/yyyy HH:mm";
            this.time_Di.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.time_Di.Location = new System.Drawing.Point(461, 172);
            this.time_Di.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.time_Di.Name = "time_Di";
            this.time_Di.Size = new System.Drawing.Size(206, 26);
            this.time_Di.TabIndex = 248;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(706, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 20);
            this.label12.TabIndex = 245;
            this.label12.Text = "Giờ đến:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(424, 172);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 20);
            this.label13.TabIndex = 244;
            this.label13.Text = "Từ:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(332, 172);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 20);
            this.label15.TabIndex = 242;
            this.label15.Text = "Giờ đi:";
            // 
            // cbbDes
            // 
            this.cbbDes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDes.FormattingEnabled = true;
            this.cbbDes.Location = new System.Drawing.Point(583, 84);
            this.cbbDes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbDes.Name = "cbbDes";
            this.cbbDes.Size = new System.Drawing.Size(234, 28);
            this.cbbDes.TabIndex = 240;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(511, 88);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 20);
            this.label16.TabIndex = 238;
            this.label16.Text = "Ga đến:";
            // 
            // btn_TIMKIEM
            // 
            this.btn_TIMKIEM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_TIMKIEM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TIMKIEM.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TIMKIEM.Location = new System.Drawing.Point(1028, 166);
            this.btn_TIMKIEM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TIMKIEM.Name = "btn_TIMKIEM";
            this.btn_TIMKIEM.Size = new System.Drawing.Size(116, 43);
            this.btn_TIMKIEM.TabIndex = 241;
            this.btn_TIMKIEM.Text = "Tìm kiếm";
            this.btn_TIMKIEM.UseVisualStyleBackColor = false;
            this.btn_TIMKIEM.Click += new System.EventHandler(this.btn_TIMKIEM_Click);
            // 
            // cbbDep
            // 
            this.cbbDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDep.FormattingEnabled = true;
            this.cbbDep.Location = new System.Drawing.Point(229, 84);
            this.cbbDep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbDep.Name = "cbbDep";
            this.cbbDep.Size = new System.Drawing.Size(234, 28);
            this.cbbDep.TabIndex = 239;
            this.cbbDep.SelectedIndexChanged += new System.EventHandler(this.cbbDep_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(172, 87);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 20);
            this.label17.TabIndex = 237;
            this.label17.Text = "Ga đi:";
            // 
            // butmua
            // 
            this.butmua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.butmua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butmua.Location = new System.Drawing.Point(1001, 690);
            this.butmua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butmua.Name = "butmua";
            this.butmua.Size = new System.Drawing.Size(143, 44);
            this.butmua.TabIndex = 236;
            this.butmua.Text = "Thêm vé";
            this.butmua.UseVisualStyleBackColor = false;
            // 
            // dtaGd_TAU
            // 
            this.dtaGd_TAU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGd_TAU.Location = new System.Drawing.Point(176, 218);
            this.dtaGd_TAU.Name = "dtaGd_TAU";
            this.dtaGd_TAU.RowHeadersWidth = 62;
            this.dtaGd_TAU.RowTemplate.Height = 28;
            this.dtaGd_TAU.Size = new System.Drawing.Size(968, 452);
            this.dtaGd_TAU.TabIndex = 254;
            // 
            // frm_VETAU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 761);
            this.Controls.Add(this.dtaGd_TAU);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.time_Den);
            this.Controls.Add(this.time_Di);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cbbDes);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btn_TIMKIEM);
            this.Controls.Add(this.cbbDep);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.butmua);
            this.Name = "frm_VETAU";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_VETAU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtaGd_TAU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker time_Den;
        private System.Windows.Forms.DateTimePicker time_Di;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbbDes;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_TIMKIEM;
        private System.Windows.Forms.ComboBox cbbDep;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button butmua;
        private System.Windows.Forms.DataGridView dtaGd_TAU;
    }
}

