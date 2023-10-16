﻿using MongoDB.Bson;
using MongoDB.Driver;

namespace app
{
    public partial class SuaThongTin : Form
    {
        private readonly IMongoDatabase database = Global.ConnectDB();
        private HocSinh initInforHS;

        public SuaThongTin(HocSinh data)
        {
            InitializeComponent();
            HandleGetKhoa();
            handleGetLop(data.lop);

            initInforHS = data;
            txtSubTitle.Text = data.ten;
            BoxKhoa.Text = data.khoa;
            BoxLop.Text = data.lop;
            txtTen.Text = data.ten;
            txtDiaChi.Text = data.diachi;
            txtMssv.Text = data.mssv;
            txtNgaySinh.Value = DateTime.Parse(data.ngaysinh);
        }

        public void HandleGetKhoa()
        {
            var collection = database.GetCollection<BsonDocument>("Khoas");
            var documents = collection.AsQueryable().ToList();

            if (documents.Count > 0)
            {
                foreach (BsonDocument document in documents)
                {
                    BoxKhoa.Items.Add(document["ten"]);
                }
            }
            else
            {
                BoxKhoa.Items.Clear();
            }
        }

        public void handleGetLop(string Khoa)
        {
            var collection = database.GetCollection<BsonDocument>("Lops");
            var filter = Builders<BsonDocument>.Filter
                .Eq("khoa", Khoa);
            var documents = collection.Find(filter).ToList();

            if (documents.Count > 0)
            {
                foreach (BsonDocument document in documents)
                {
                    BoxLop.Items.Add(document["ten"]);
                }
            }
            else
            {
                BoxLop.Text = "";
                BoxLop.Items.Clear();
            }
        }

        private void BoxKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            string khoa = cb.SelectedItem.ToString();
            handleGetLop(khoa);
        }

        private void BoxLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public bool HandleCheckMSSV(string mssv)
        {
            var collection = database.GetCollection<BsonDocument>("HocSinhs");
            var filter = Builders<BsonDocument>.Filter
                .Eq("mssv", mssv);
            var document = collection.Find(filter).FirstOrDefault();

            if (document != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private async void btnLuu_Click(object sender, EventArgs e)
        {
            string mssv = txtMssv.Text;
            string ten = txtTen.Text;
            string diachi = txtDiaChi.Text;
            string khoa = BoxKhoa.SelectedItem.ToString();
            string lop = BoxLop.SelectedItem.ToString();
            string ngaysinh = txtNgaySinh.Value.ToString();
            bool isExit;

            if (mssv != initInforHS.mssv)
            {
                isExit = HandleCheckMSSV(mssv);

                if (!isExit)
                {
                    var collection = database.GetCollection<BsonDocument>("HocSinhs");
                    var filter = Builders<BsonDocument>.Filter
                    .Eq("mssv", initInforHS.mssv);
                    var update = Builders<BsonDocument>.Update.
                        Set("ten", ten).
                        Set("mssv", mssv).
                        Set("diachi", diachi).
                        Set("ngaysinh", ngaysinh).
                        Set("lop", lop).
                        Set("khoa", khoa);
                    collection.UpdateOne(filter, update);
                    MessageBox.Show("Thay đổi thành công", "Thông báo");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mã số sinh viên đã tồn tại", "Thông báo");
                }
            }
            else
            {
                var collection = database.GetCollection<BsonDocument>("HocSinhs");
                var filter = Builders<BsonDocument>.Filter
                .Eq("mssv", mssv);
                var update = Builders<BsonDocument>.Update.
                        Set("ten", ten).
                        Set("mssv", mssv).
                        Set("diachi", diachi).
                        Set("ngaysinh", ngaysinh).
                        Set("lop", lop).
                        Set("khoa", khoa);
                collection.UpdateOne(filter, update);
                MessageBox.Show("Thay đổi thành công", "Thông báo");
                this.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa sinh viên " + initInforHS.ten,
                         "Thông báo",
                         MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string mssv = initInforHS.mssv;
                var collection = database.GetCollection<BsonDocument>("HocSinhs");
                var filter = Builders<BsonDocument>.Filter.Eq("mssv", mssv);
                collection.DeleteOne(filter);
                MessageBox.Show("Xóa thành công", "Thông báo");
                this.Close();
            }
        }
    }
}
