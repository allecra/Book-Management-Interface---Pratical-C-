namespace BaiOnTap2
{
    partial class FormQLSach
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerNgayHen = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.textBoxTenSach = new System.Windows.Forms.TextBox();
            this.textBoxSoPhieu = new System.Windows.Forms.TextBox();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkBoxDaTraSach = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxDaTraSach);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePickerNgayHen);
            this.panel1.Controls.Add(this.dateTimePickerNgayMuon);
            this.panel1.Controls.Add(this.textBoxTenSach);
            this.panel1.Controls.Add(this.textBoxSoPhieu);
            this.panel1.Controls.Add(this.buttonSua);
            this.panel1.Controls.Add(this.buttonXoa);
            this.panel1.Controls.Add(this.buttonThem);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(-8, -30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 619);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Độc giả trả sách đúng hạn",
            "Độc giả trả sách quá hạn"});
            this.comboBox1.Location = new System.Drawing.Point(30, 87);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 24);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.Text = "Danh sách";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(568, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ngày Hẹn Trả Sách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(568, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ngày Mượn Sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tên Sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Số Phiếu Mượn ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // dateTimePickerNgayHen
            // 
            this.dateTimePickerNgayHen.Location = new System.Drawing.Point(715, 89);
            this.dateTimePickerNgayHen.Name = "dateTimePickerNgayHen";
            this.dateTimePickerNgayHen.Size = new System.Drawing.Size(169, 22);
            this.dateTimePickerNgayHen.TabIndex = 8;
            // 
            // dateTimePickerNgayMuon
            // 
            this.dateTimePickerNgayMuon.Location = new System.Drawing.Point(715, 52);
            this.dateTimePickerNgayMuon.Name = "dateTimePickerNgayMuon";
            this.dateTimePickerNgayMuon.Size = new System.Drawing.Size(169, 22);
            this.dateTimePickerNgayMuon.TabIndex = 7;
            // 
            // textBoxTenSach
            // 
            this.textBoxTenSach.Location = new System.Drawing.Point(378, 89);
            this.textBoxTenSach.Name = "textBoxTenSach";
            this.textBoxTenSach.Size = new System.Drawing.Size(136, 22);
            this.textBoxTenSach.TabIndex = 6;
            // 
            // textBoxSoPhieu
            // 
            this.textBoxSoPhieu.Location = new System.Drawing.Point(266, 91);
            this.textBoxSoPhieu.Name = "textBoxSoPhieu";
            this.textBoxSoPhieu.Size = new System.Drawing.Size(52, 22);
            this.textBoxSoPhieu.TabIndex = 5;
            // 
            // buttonSua
            // 
            this.buttonSua.Location = new System.Drawing.Point(30, 492);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(128, 33);
            this.buttonSua.TabIndex = 3;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(30, 554);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(128, 32);
            this.buttonXoa.TabIndex = 2;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(30, 429);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(128, 35);
            this.buttonThem.TabIndex = 1;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(191, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(730, 463);
            this.dataGridView1.TabIndex = 0;
            // 
            // checkBoxDaTraSach
            // 
            this.checkBoxDaTraSach.AutoSize = true;
            this.checkBoxDaTraSach.Location = new System.Drawing.Point(30, 164);
            this.checkBoxDaTraSach.Name = "checkBoxDaTraSach";
            this.checkBoxDaTraSach.Size = new System.Drawing.Size(104, 20);
            this.checkBoxDaTraSach.TabIndex = 16;
            this.checkBoxDaTraSach.Text = "Đã Trả Sách";
            this.checkBoxDaTraSach.UseVisualStyleBackColor = true;
            this.checkBoxDaTraSach.CheckedChanged += new System.EventHandler(this.checkBoxDaTraSach_CheckedChanged);
            // 
            // FormQLSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 586);
            this.Controls.Add(this.panel1);
            this.Name = "FormQLSach";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sách";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxTenSach;
        private System.Windows.Forms.TextBox textBoxSoPhieu;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayHen;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayMuon;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBoxDaTraSach;
    }
}