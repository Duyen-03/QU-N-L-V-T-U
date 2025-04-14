namespace QUANLY_VETAU
{
    partial class Frm_SuaTau
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Xacnhan = new System.Windows.Forms.Button();
            this.TXT_TENTAU = new System.Windows.Forms.TextBox();
            this.TXT_SOTOA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_MATAU = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btn_Thoat);
            this.groupBox1.Controls.Add(this.btn_Xacnhan);
            this.groupBox1.Controls.Add(this.TXT_TENTAU);
            this.groupBox1.Controls.Add(this.TXT_MATAU);
            this.groupBox1.Controls.Add(this.TXT_SOTOA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 450);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sửa chuyến tàu";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Thoat.Location = new System.Drawing.Point(365, 309);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(88, 33);
            this.btn_Thoat.TabIndex = 9;
            this.btn_Thoat.Text = "Hủy";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Xacnhan
            // 
            this.btn_Xacnhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Xacnhan.Location = new System.Drawing.Point(63, 309);
            this.btn_Xacnhan.Name = "btn_Xacnhan";
            this.btn_Xacnhan.Size = new System.Drawing.Size(98, 33);
            this.btn_Xacnhan.TabIndex = 8;
            this.btn_Xacnhan.Text = "Xác nhận";
            this.btn_Xacnhan.UseVisualStyleBackColor = false;
            this.btn_Xacnhan.Click += new System.EventHandler(this.btn_Xacnhan_Click);
            // 
            // TXT_TENTAU
            // 
            this.TXT_TENTAU.Location = new System.Drawing.Point(138, 140);
            this.TXT_TENTAU.Name = "TXT_TENTAU";
            this.TXT_TENTAU.Size = new System.Drawing.Size(315, 22);
            this.TXT_TENTAU.TabIndex = 56;
            // 
            // TXT_SOTOA
            // 
            this.TXT_SOTOA.Location = new System.Drawing.Point(138, 200);
            this.TXT_SOTOA.Name = "TXT_SOTOA";
            this.TXT_SOTOA.Size = new System.Drawing.Size(315, 22);
            this.TXT_SOTOA.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 50;
            this.label5.Text = "Tên tàu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 49;
            this.label6.Text = "Số toa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 50;
            this.label2.Text = "Mã Tàu:";
            // 
            // TXT_MATAU
            // 
            this.TXT_MATAU.Enabled = false;
            this.TXT_MATAU.Location = new System.Drawing.Point(138, 80);
            this.TXT_MATAU.Name = "TXT_MATAU";
            this.TXT_MATAU.Size = new System.Drawing.Size(315, 22);
            this.TXT_MATAU.TabIndex = 56;
            // 
            // Frm_SuaTau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_SuaTau";
            this.Text = "Frm_SuaTau";
            this.Load += new System.EventHandler(this.Frm_SuaTau_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Xacnhan;
        private System.Windows.Forms.TextBox TXT_TENTAU;
        private System.Windows.Forms.TextBox TXT_SOTOA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXT_MATAU;
        private System.Windows.Forms.Label label2;
    }
}