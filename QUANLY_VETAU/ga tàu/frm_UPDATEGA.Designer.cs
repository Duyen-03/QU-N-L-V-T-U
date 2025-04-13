namespace BTN_QLIVETAU
{
    partial class frm_UPDATEGA
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
            this.txt_TENGA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_DIACHI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_TENGA
            // 
            this.txt_TENGA.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txt_TENGA.Location = new System.Drawing.Point(542, 182);
            this.txt_TENGA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TENGA.Name = "txt_TENGA";
            this.txt_TENGA.Size = new System.Drawing.Size(224, 26);
            this.txt_TENGA.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(415, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tên ga";
            // 
            // txt_DIACHI
            // 
            this.txt_DIACHI.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txt_DIACHI.Location = new System.Drawing.Point(542, 255);
            this.txt_DIACHI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_DIACHI.Name = "txt_DIACHI";
            this.txt_DIACHI.Size = new System.Drawing.Size(224, 26);
            this.txt_DIACHI.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(415, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Địa chỉ";
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(419, 349);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(143, 44);
            this.btn_Sua.TabIndex = 260;
            this.btn_Sua.Text = "Lưu";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(623, 349);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(143, 44);
            this.btnThoat.TabIndex = 261;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frm_UPDATEGA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 683);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.txt_DIACHI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_TENGA);
            this.Controls.Add(this.label7);
            this.Name = "frm_UPDATEGA";
            this.Text = "frm_UPDATEGA";
            this.Load += new System.EventHandler(this.frm_UPDATEGA_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_TENGA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_DIACHI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btnThoat;
    }
}