﻿namespace app
{
    partial class Report
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            panel3 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            label = new Label();
            labelKhoa = new Label();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            ColStt = new DataGridViewTextBoxColumn();
            ColMssv = new DataGridViewTextBoxColumn();
            ColTen = new DataGridViewTextBoxColumn();
            ColNgaySinh = new DataGridViewTextBoxColumn();
            ColDiaChi = new DataGridViewTextBoxColumn();
            txtNgay = new Label();
            txtKhoa = new Label();
            txtLop = new Label();
            labelSl = new Label();
            txtSL = new Label();
            hocSinhBindingSource = new BindingSource(components);
            bindingSource1 = new BindingSource(components);
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hocSinhBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(10, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1091, 94);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(623, 10);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(446, 73);
            panel3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(230, 47);
            label4.Name = "label4";
            label4.Size = new Size(27, 19);
            label4.TabIndex = 2;
            label4.Text = "***";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(153, 30);
            label3.Name = "label3";
            label3.Size = new Size(194, 19);
            label3.TabIndex = 1;
            label3.Text = "Độc Lập - Tự Do - Hạnh Phúc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(111, 8);
            label2.Name = "label2";
            label2.Size = new Size(255, 19);
            label2.TabIndex = 0;
            label2.Text = "Cộng Hòa Xã Hội Chủ Nghĩa Việt Nam";
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Location = new Point(10, 10);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(228, 73);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(8, 16);
            label1.Name = "label1";
            label1.Size = new Size(204, 43);
            label1.TabIndex = 0;
            label1.Text = "Trường Đại Học Gia Định ***";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label
            // 
            label.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label.Location = new Point(442, 105);
            label.Name = "label";
            label.Size = new Size(240, 75);
            label.TabIndex = 1;
            label.Text = "Danh sách sinh viên K15DCPM02";
            label.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelKhoa
            // 
            labelKhoa.AutoSize = true;
            labelKhoa.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelKhoa.Location = new Point(10, 202);
            labelKhoa.Name = "labelKhoa";
            labelKhoa.Size = new Size(44, 19);
            labelKhoa.TabIndex = 2;
            labelKhoa.Text = "Khóa:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(10, 226);
            label5.Name = "label5";
            label5.Size = new Size(36, 19);
            label5.TabIndex = 3;
            label5.Text = "Lớp:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColStt, ColMssv, ColTen, ColNgaySinh, ColDiaChi });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(10, 256);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1069, 210);
            dataGridView1.TabIndex = 4;
            // 
            // ColStt
            // 
            ColStt.HeaderText = "STT";
            ColStt.MinimumWidth = 6;
            ColStt.Name = "ColStt";
            ColStt.ReadOnly = true;
            // 
            // ColMssv
            // 
            ColMssv.HeaderText = "MSSV";
            ColMssv.MinimumWidth = 6;
            ColMssv.Name = "ColMssv";
            ColMssv.ReadOnly = true;
            // 
            // ColTen
            // 
            ColTen.HeaderText = "Họ và tên";
            ColTen.MinimumWidth = 6;
            ColTen.Name = "ColTen";
            ColTen.ReadOnly = true;
            // 
            // ColNgaySinh
            // 
            ColNgaySinh.HeaderText = "Ngày sinh";
            ColNgaySinh.MinimumWidth = 6;
            ColNgaySinh.Name = "ColNgaySinh";
            ColNgaySinh.ReadOnly = true;
            // 
            // ColDiaChi
            // 
            ColDiaChi.HeaderText = "Địa chỉ";
            ColDiaChi.MinimumWidth = 6;
            ColDiaChi.Name = "ColDiaChi";
            ColDiaChi.ReadOnly = true;
            // 
            // txtNgay
            // 
            txtNgay.AutoSize = true;
            txtNgay.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtNgay.Location = new Point(889, 502);
            txtNgay.Name = "txtNgay";
            txtNgay.Size = new Size(181, 19);
            txtNgay.TabIndex = 5;
            txtNgay.Text = "Ngày 27 tháng 5 năm 2023";
            // 
            // txtKhoa
            // 
            txtKhoa.AutoSize = true;
            txtKhoa.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtKhoa.Location = new Point(62, 202);
            txtKhoa.Name = "txtKhoa";
            txtKhoa.Size = new Size(0, 19);
            txtKhoa.TabIndex = 6;
            // 
            // txtLop
            // 
            txtLop.AutoSize = true;
            txtLop.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtLop.Location = new Point(52, 226);
            txtLop.Name = "txtLop";
            txtLop.Size = new Size(0, 19);
            txtLop.TabIndex = 7;
            // 
            // labelSl
            // 
            labelSl.AutoSize = true;
            labelSl.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelSl.Location = new Point(868, 202);
            labelSl.Name = "labelSl";
            labelSl.Size = new Size(122, 19);
            labelSl.TabIndex = 8;
            labelSl.Text = "Tổng số sinh viên:";
            // 
            // txtSL
            // 
            txtSL.AutoSize = true;
            txtSL.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtSL.Location = new Point(1003, 202);
            txtSL.Name = "txtSL";
            txtSL.Size = new Size(0, 19);
            txtSL.TabIndex = 9;
            // 
            // hocSinhBindingSource
            // 
            hocSinhBindingSource.DataSource = typeof(HocSinh);
            // 
            // Report
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 542);
            Controls.Add(txtSL);
            Controls.Add(labelSl);
            Controls.Add(txtLop);
            Controls.Add(txtKhoa);
            Controls.Add(txtNgay);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(labelKhoa);
            Controls.Add(label);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Report";
            Text = "Report";
            TopMost = true;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)hocSinhBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label;
        private Label labelKhoa;
        private Label label5;
        private DataGridView dataGridView1;
        private Label txtNgay;
        private Label txtKhoa;
        private Label txtLop;
        private Label labelSl;
        private Label txtSL;
        private BindingSource hocSinhBindingSource;
        private DataGridViewTextBoxColumn ColStt;
        private DataGridViewTextBoxColumn ColMssv;
        private DataGridViewTextBoxColumn ColTen;
        private DataGridViewTextBoxColumn ColNgaySinh;
        private DataGridViewTextBoxColumn ColDiaChi;
        private BindingSource bindingSource1;
    }
}