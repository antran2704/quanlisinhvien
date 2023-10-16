using MongoDB.Bson;
using MongoDB.Driver;


namespace app
{
    public partial class DangNhap : Form
    {
        private readonly IMongoDatabase database = Global.ConnectDB();

        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string userName = txtTen.Text;
            string password = txtMatKhau.Text;

            if(userName != "" && password != "")
            {
                var collection = database.GetCollection<BsonDocument>("TaiKhoans");
                var filter = Builders<BsonDocument>.Filter
                    .Eq("userName", userName) & Builders<BsonDocument>.Filter
                    .Eq("password", password);

                var document = collection.Find(filter).ToList();

                if (document.Count > 0)
                {
                    Form1 form = new Form1();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Không tồn tại tài khoản này!!!", "Thông báo");
                }
            } else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
            }
        }
    }

}
