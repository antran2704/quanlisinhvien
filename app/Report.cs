using MongoDB.Bson;
using MongoDB.Driver;

namespace app
{
    public partial class Report : Form
    {
        private readonly IMongoDatabase database = Global.ConnectDB();
        int stt = 1;

        public Report(string khoa, string lop, string ngaythangnam)
        {
            InitializeComponent();
            handleGetHocSinh(lop);

            txtKhoa.Text = khoa;
            txtLop.Text = lop;
            txtNgay.Text = ngaythangnam;
            label.Text = "Danh sách sinh viên " + lop;
        }

        public void handleGetHocSinh(string Lop)
        {
            var collection = database.GetCollection<BsonDocument>("HocSinhs");
            var filter = Builders<BsonDocument>.Filter
                .Eq("lop", Lop);
            var documents = collection.Find(filter).ToList();

            txtSL.Text = documents.Count.ToString();

            foreach (BsonDocument document in documents)
            {
                var index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = stt;
                dataGridView1.Rows[index].Cells[1].Value = document["mssv"];
                dataGridView1.Rows[index].Cells[2].Value = document["ten"];
                dataGridView1.Rows[index].Cells[3].Value = DateTime.Parse(document["ngaysinh"].ToString()).ToShortDateString();
                dataGridView1.Rows[index].Cells[4].Value = document["diachi"];

                stt++;
            }
        }
    }
}
