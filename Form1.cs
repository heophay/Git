using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GiaoDien.Source_Code_CSDL;

namespace GiaoDien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Show1();
        }
        SE_14X db = new SE_14X();
        //SE_14 db = new SE_14();
        public void Show1()
        {
            dataGridView1.DataSource = db.TaiKhoans.Select(p => p).ToList();
            TaiKhoan tk = new TaiKhoan();
            tk = db.TaiKhoans.Where(p => p.TenTK == "Customer1").FirstOrDefault();
            MessageBox.Show(tk.PassTK);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFile.FileName;
            }
        }
        private byte[] converImgToByte()
        {
            FileStream fs;
            fs = new FileStream(textBox1.Text, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
        }
        private Image ByteToImg(string byteString)
        {
            byte[] imgBytes = Convert.FromBase64String(byteString);
            MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
            ms.Write(imgBytes, 0, imgBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Convert.ToBase64String(converImgToByte());
            ChiTiet_SP c = db.ChiTiet_SPs.Where(p => p.MaSP == "1").FirstOrDefault();
            pictureBox1.Image = ByteToImg(c.HinhAnh);
            //cover chuỗi trên trở lại byte hình ảnh thì dùng
            //Convert.FromBase64String(Đoạn_String_đã_cover);
            MD5 mh = MD5.Create();
            //Chuyển kiểu chuổi thành kiểu byte
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes("123456");
            //mã hóa chuỗi đã chuyển
            byte[] hash = mh.ComputeHash(inputBytes);
            //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x"));
            }
            //MessageBox.Show(sb.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ChiTiet_SP c = db.ChiTiet_SPs.Where(p => p.MaSP == "1").FirstOrDefault();
            //imageList1.Images.Add(ByteToImg(c.HinhAnh));
            //imageList1.ImageSize = new Size(132, 132);
            //this.listView1.View = View.LargeIcon;
            //for (int counter = 0; counter < imageList1.Images.Count; counter++)
            //{
            //    ListViewItem item = new ListViewItem();
            //    item.ImageIndex = counter;
            //    this.listView1.Items.Add(item);
            //}
            //this.listView1.LargeImageList = imageList1;
            ChiTiet_SP c = db.ChiTiet_SPs.Where(p => p.MaSP == "1").FirstOrDefault();
            pictureBox1.Image = Image.FromFile(c.HinhAnh);
        }
    }
}
