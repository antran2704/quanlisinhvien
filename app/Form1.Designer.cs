namespace app
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FTitle = new Label();
            panelDefault = new Panel();
            BoxLop = new ComboBox();
            BoxKhoa = new ComboBox();
            BtnSearch = new Button();
            BtnClear = new Button();
            TxtLop = new Label();
            TxtKhoa = new Label();
            Title = new Label();
            listView1 = new ListView();
            ColMSSV = new ColumnHeader();
            ColHoTen = new ColumnHeader();
            ColNgaySinh = new ColumnHeader();
            ColDiaChi = new ColumnHeader();
            currentLop = new Label();
            btnAdd = new Button();
            BtnReport = new Button();
            btnDangXuat = new Button();
            btnMssv = new Button();
            panelMssv = new Panel();
            txtMssv = new TextBox();
            btnTimMssv = new Button();
            btnXoaMssv = new Button();
            label4 = new Label();
            panelDefault.SuspendLayout();
            panelMssv.SuspendLayout();
            SuspendLayout();
            // 
            // FTitle
            // 
            FTitle.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            FTitle.Location = new Point(10, 7);
            FTitle.Name = "FTitle";
            FTitle.Size = new Size(158, 48);
            FTitle.TabIndex = 0;
            FTitle.Text = "Trường đại học Gia Định";
            FTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelDefault
            // 
            panelDefault.BorderStyle = BorderStyle.FixedSingle;
            panelDefault.Controls.Add(BoxLop);
            panelDefault.Controls.Add(BoxKhoa);
            panelDefault.Controls.Add(BtnSearch);
            panelDefault.Controls.Add(BtnClear);
            panelDefault.Controls.Add(TxtLop);
            panelDefault.Controls.Add(TxtKhoa);
            panelDefault.Location = new Point(10, 79);
            panelDefault.Margin = new Padding(3, 2, 3, 2);
            panelDefault.Name = "panelDefault";
            panelDefault.Size = new Size(311, 148);
            panelDefault.TabIndex = 1;
            // 
            // BoxLop
            // 
            BoxLop.DropDownStyle = ComboBoxStyle.DropDownList;
            BoxLop.FormattingEnabled = true;
            BoxLop.Location = new Point(67, 70);
            BoxLop.Margin = new Padding(3, 2, 3, 2);
            BoxLop.Name = "BoxLop";
            BoxLop.Size = new Size(218, 23);
            BoxLop.TabIndex = 7;
            BoxLop.SelectedIndexChanged += BoxLop_SelectedIndexChanged;
            // 
            // BoxKhoa
            // 
            BoxKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            BoxKhoa.FormattingEnabled = true;
            BoxKhoa.Location = new Point(67, 22);
            BoxKhoa.Margin = new Padding(3, 2, 3, 2);
            BoxKhoa.Name = "BoxKhoa";
            BoxKhoa.Size = new Size(218, 23);
            BoxKhoa.TabIndex = 6;
            BoxKhoa.SelectedIndexChanged += BoxKhoa_SelectedIndexChanged;
            // 
            // BtnSearch
            // 
            BtnSearch.Enabled = false;
            BtnSearch.FlatStyle = FlatStyle.Popup;
            BtnSearch.Location = new Point(203, 107);
            BtnSearch.Margin = new Padding(3, 2, 3, 2);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(82, 22);
            BtnSearch.TabIndex = 5;
            BtnSearch.Text = "Tìm";
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // BtnClear
            // 
            BtnClear.BackColor = Color.Red;
            BtnClear.FlatStyle = FlatStyle.Flat;
            BtnClear.ForeColor = SystemColors.Control;
            BtnClear.Location = new Point(18, 107);
            BtnClear.Margin = new Padding(3, 2, 3, 2);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(82, 22);
            BtnClear.TabIndex = 4;
            BtnClear.Text = "Xóa";
            BtnClear.UseVisualStyleBackColor = false;
            BtnClear.Click += BtnClear_Click;
            // 
            // TxtLop
            // 
            TxtLop.AutoSize = true;
            TxtLop.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtLop.Location = new Point(18, 66);
            TxtLop.Name = "TxtLop";
            TxtLop.Size = new Size(37, 21);
            TxtLop.TabIndex = 2;
            TxtLop.Text = "Lớp";
            // 
            // TxtKhoa
            // 
            TxtKhoa.AutoSize = true;
            TxtKhoa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtKhoa.Location = new Point(18, 19);
            TxtKhoa.Name = "TxtKhoa";
            TxtKhoa.Size = new Size(45, 21);
            TxtKhoa.TabIndex = 0;
            TxtKhoa.Text = "Khóa";
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Title.Location = new Point(661, 7);
            Title.Name = "Title";
            Title.Size = new Size(210, 30);
            Title.TabIndex = 3;
            Title.Text = "Danh sách học sinh";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            listView1.BorderStyle = BorderStyle.FixedSingle;
            listView1.Columns.AddRange(new ColumnHeader[] { ColMSSV, ColHoTen, ColNgaySinh, ColDiaChi });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(419, 79);
            listView1.Margin = new Padding(3, 2, 3, 2);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(676, 288);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // ColMSSV
            // 
            ColMSSV.Text = "MSSV";
            // 
            // ColHoTen
            // 
            ColHoTen.Text = "Họ và tên";
            // 
            // ColNgaySinh
            // 
            ColNgaySinh.Text = "Ngày sinh";
            ColNgaySinh.Width = 100;
            // 
            // ColDiaChi
            // 
            ColDiaChi.Text = "Địa chỉ";
            // 
            // currentLop
            // 
            currentLop.AutoSize = true;
            currentLop.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            currentLop.Location = new Point(741, 50);
            currentLop.Name = "currentLop";
            currentLop.Size = new Size(0, 21);
            currentLop.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LimeGreen;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = SystemColors.ButtonFace;
            btnAdd.Location = new Point(1005, 44);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(89, 26);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "+ Thêm ";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // BtnReport
            // 
            BtnReport.BackColor = Color.DeepSkyBlue;
            BtnReport.Enabled = false;
            BtnReport.FlatStyle = FlatStyle.Flat;
            BtnReport.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnReport.ForeColor = SystemColors.ButtonHighlight;
            BtnReport.Location = new Point(972, 380);
            BtnReport.Margin = new Padding(3, 2, 3, 2);
            BtnReport.Name = "BtnReport";
            BtnReport.Size = new Size(122, 35);
            BtnReport.TabIndex = 7;
            BtnReport.Text = "Xuất danh sách";
            BtnReport.UseVisualStyleBackColor = false;
            BtnReport.Click += btnReport_Click;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = SystemColors.ActiveCaption;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangXuat.ForeColor = SystemColors.ButtonFace;
            btnDangXuat.Location = new Point(10, 386);
            btnDangXuat.Margin = new Padding(3, 2, 3, 2);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(102, 28);
            btnDangXuat.TabIndex = 8;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnMssv
            // 
            btnMssv.AutoSize = true;
            btnMssv.BackColor = Color.DarkOrchid;
            btnMssv.FlatStyle = FlatStyle.Flat;
            btnMssv.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnMssv.ForeColor = SystemColors.ButtonHighlight;
            btnMssv.Location = new Point(770, 380);
            btnMssv.Margin = new Padding(3, 2, 3, 2);
            btnMssv.Name = "btnMssv";
            btnMssv.Size = new Size(126, 35);
            btnMssv.TabIndex = 9;
            btnMssv.Text = "Tìm bằng MSSV";
            btnMssv.UseVisualStyleBackColor = false;
            btnMssv.Click += btnMssv_Click;
            // 
            // panelMssv
            // 
            panelMssv.BorderStyle = BorderStyle.FixedSingle;
            panelMssv.Controls.Add(txtMssv);
            panelMssv.Controls.Add(btnTimMssv);
            panelMssv.Controls.Add(btnXoaMssv);
            panelMssv.Controls.Add(label4);
            panelMssv.Location = new Point(10, 79);
            panelMssv.Margin = new Padding(3, 2, 3, 2);
            panelMssv.Name = "panelMssv";
            panelMssv.Size = new Size(311, 126);
            panelMssv.TabIndex = 10;
            panelMssv.Visible = false;
            // 
            // txtMssv
            // 
            txtMssv.Location = new Point(80, 21);
            txtMssv.Margin = new Padding(3, 2, 3, 2);
            txtMssv.Name = "txtMssv";
            txtMssv.Size = new Size(206, 23);
            txtMssv.TabIndex = 8;
            // 
            // btnTimMssv
            // 
            btnTimMssv.FlatStyle = FlatStyle.Popup;
            btnTimMssv.Location = new Point(203, 87);
            btnTimMssv.Margin = new Padding(3, 2, 3, 2);
            btnTimMssv.Name = "btnTimMssv";
            btnTimMssv.Size = new Size(82, 22);
            btnTimMssv.TabIndex = 5;
            btnTimMssv.Text = "Tìm";
            btnTimMssv.UseVisualStyleBackColor = true;
            btnTimMssv.Click += btnTimMssv_Click;
            // 
            // btnXoaMssv
            // 
            btnXoaMssv.BackColor = Color.Red;
            btnXoaMssv.FlatStyle = FlatStyle.Flat;
            btnXoaMssv.ForeColor = SystemColors.Control;
            btnXoaMssv.Location = new Point(18, 87);
            btnXoaMssv.Margin = new Padding(3, 2, 3, 2);
            btnXoaMssv.Name = "btnXoaMssv";
            btnXoaMssv.Size = new Size(82, 22);
            btnXoaMssv.TabIndex = 4;
            btnXoaMssv.Text = "Xóa";
            btnXoaMssv.UseVisualStyleBackColor = false;
            btnXoaMssv.Click += btnXoaMssv_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(18, 19);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 0;
            label4.Text = "MSSV";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 424);
            Controls.Add(panelMssv);
            Controls.Add(btnMssv);
            Controls.Add(btnDangXuat);
            Controls.Add(BtnReport);
            Controls.Add(btnAdd);
            Controls.Add(currentLop);
            Controls.Add(listView1);
            Controls.Add(Title);
            Controls.Add(panelDefault);
            Controls.Add(FTitle);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Đăng xuất";
            Load += Form1_Load;
            panelDefault.ResumeLayout(false);
            panelDefault.PerformLayout();
            panelMssv.ResumeLayout(false);
            panelMssv.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FTitle;
        private Panel panelDefault;
        private Label TxtLop;
        private Label TxtKhoa;
        private Button BtnSearch;
        private Button BtnClear;
        private Label Title;
        private ListView listView1;
        private ColumnHeader ColMSSV;
        private ColumnHeader ColHoTen;
        private ColumnHeader ColNgaySinh;
        private ColumnHeader ColDiaChi;
        private ComboBox BoxLop;
        private ComboBox BoxKhoa;
        private Label currentLop;
        private Button btnAdd;
        private Button BtnReport;
        private Button btnDangXuat;
        private Button btnMssv;
        private Panel panelMssv;
        private Button btnTimMssv;
        private Button btnXoaMssv;
        private Label label4;
        private TextBox txtMssv;
    }
}