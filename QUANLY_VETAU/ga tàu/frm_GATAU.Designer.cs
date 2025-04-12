namespace BTN_QLIVETAU
{
    partial class frm_GATAU
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
            this.qLI_VETAUDataSet = new BTN_QLIVETAU.QLI_VETAUDataSet();
            this.gATAUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gATAUTableAdapter = new BTN_QLIVETAU.QLI_VETAUDataSetTableAdapters.GATAUTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_THEM = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLI_VETAUDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gATAUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // qLI_VETAUDataSet
            // 
            this.qLI_VETAUDataSet.DataSetName = "QLI_VETAUDataSet";
            this.qLI_VETAUDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gATAUBindingSource
            // 
            this.gATAUBindingSource.DataMember = "GATAU";
            this.gATAUBindingSource.DataSource = this.qLI_VETAUDataSet;
            // 
            // gATAUTableAdapter
            // 
            this.gATAUTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(228, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(830, 349);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            // 
            // btn_THEM
            // 
            this.btn_THEM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_THEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_THEM.Location = new System.Drawing.Point(915, 540);
            this.btn_THEM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_THEM.Name = "btn_THEM";
            this.btn_THEM.Size = new System.Drawing.Size(143, 44);
            this.btn_THEM.TabIndex = 259;
            this.btn_THEM.Text = "Thêm ga";
            this.btn_THEM.UseVisualStyleBackColor = false;
            this.btn_THEM.Click += new System.EventHandler(this.btn_THEM_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(477, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 36);
            this.label1.TabIndex = 260;
            this.label1.Text = "THÔNG TIN GA TÀU";
            // 
            // frm_GATAU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 667);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_THEM);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_GATAU";
            this.Text = "frm_GATAU";
            this.Load += new System.EventHandler(this.frm_GATAU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLI_VETAUDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gATAUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private QLI_VETAUDataSet qLI_VETAUDataSet;
        private System.Windows.Forms.BindingSource gATAUBindingSource;
        private QLI_VETAUDataSetTableAdapters.GATAUTableAdapter gATAUTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_THEM;
        private System.Windows.Forms.Label label1;
    }
}