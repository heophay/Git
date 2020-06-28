
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class QLSP : Form
    {
        SE_14 db = new SE_14();
        private string _MaSP;
        public string MaSP { get => _MaSP; set => _MaSP = value; }
        public ShowDTGV_QLSP show { get => _show; set => _show = value; }

        public delegate void ShowDTGV_QLSP();
        private ShowDTGV_QLSP _show;
        public QLSP(string masp)
        {
            MaSP = masp;
            InitializeComponent();
            openFileDialog1.Title = "Select Picture";
            openFileDialog1.Filter = "Windows Bitmap|*.bmp|JPEG Image|*.jpg|All Files|*.*";
            SetView();
            cbb_BNT.SelectedIndex = 0;
            cbb_hangsx.SelectedIndex = 0;
            cbb_ram.SelectedIndex = 0;
            cbb_sim.SelectedIndex = 0;
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_openfile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            //Kiểm tra xem người dùng đã chọn file chưa
            if (result == DialogResult.OK)
            {
                // Lấy hình ảnh
                openFileDialog1.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 1;
                Image img = Image.FromFile(openFileDialog1.FileName);
                // Gán ảnh
                pictureBox1.Image = img;
            }
        }
        private void SetView()
        {
            if(MaSP!="")
            {
                txt_masp.Enabled = false;
                ChiTiet_SP sp = db.ChiTiet_SP.Where(p => p.MaSP == MaSP).FirstOrDefault();
                txt_masp.Text = sp.MaSP;
                txt_baohanh.Text = sp.BaoHanh;
                txt_HDH.Text = sp.HeDieuHanh;
                txt_namedt.Text = sp.TenSP;
                txt_manhinh.Text = sp.ManHinh;
                txt_xuatxu.Text = sp.NoiXuatXu;
                txt_pin.Text = sp.Pin;
                cbb_BNT.SelectedItem = sp.BoNhoTrong;
                cbb_BNT.SelectedIndex = Fill_CBB(cbb_BNT, sp.BoNhoTrong);
                cbb_hangsx.SelectedIndex = Fill_CBB(cbb_hangsx, sp.HangSX);
                cbb_ram.SelectedIndex = Fill_CBB(cbb_ram, sp.Ram);
                cbb_sim.SelectedIndex = Fill_CBB(cbb_sim, sp.SoSim.ToString());
            }
        }
        private int Fill_CBB(ComboBox cbb, string type)
        {
            foreach (string i in cbb.Items)
            {
                if (i == type)
                {
                    return cbb.Items.IndexOf(i);
                }
            }
            return 0;
        }
        private void Run()
        {
            if (show != null)
            {
                show();
                this.Close();
            }
        }
        private bool Oke()
        {
            try
            {
                ChiTiet_SP sp = db.ChiTiet_SP.Where(p => p.MaSP == MaSP).FirstOrDefault();
                if(sp==null)
                {
                    if (txt_baohanh.Text != "" && txt_HDH.Text != "" && txt_manhinh.Text != "" && txt_namedt.Text != "" && txt_pin.Text != "" && txt_xuatxu.Text != "")
                    {
                        db.ChiTiet_SP.Add(new ChiTiet_SP
                        {
                            MaSP = txt_masp.Text,
                            BaoHanh = txt_baohanh.Text,
                            HeDieuHanh = txt_HDH.Text,
                            TenSP = txt_namedt.Text,
                            ManHinh = txt_manhinh.Text,
                            NoiXuatXu = txt_xuatxu.Text,
                            Pin = txt_pin.Text,
                            HangSX = cbb_hangsx.SelectedItem.ToString(),
                            Ram = cbb_ram.SelectedItem.ToString(),
                            BoNhoTrong = cbb_BNT.SelectedItem.ToString(),
                            SoSim = Convert.ToInt32(cbb_sim.SelectedItem.ToString())
                        });
                        db.KT_Gia_NhapXuat.Add(new KT_Gia_NhapXuat
                        {
                            MaSP = txt_masp.Text,
                            GiaNhap = Convert.ToInt32(txt_gianhap.Text.ToString()),
                            GiaBan = Convert.ToInt32(txt_giaban.Text.ToString()),
                            NgayApDung = ngayapdung.Value

                        }) ;
                        db.SaveChanges();
                        Run();
                    }
                    else
                    {
                        MessageBox.Show("Nhập đã đủ thông tin đâu mà đòi Add trời!");
                    }
                }
                else
                {
                    if(Check_MaSP())
                    { 
                        
                    }
                }
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
        private bool Check_MaSP()
        {
            try
            {
                ChiTiet_SP sp = db.ChiTiet_SP.Where(p => p.MaSP == MaSP).FirstOrDefault();
                if (txt_masp.Enabled == true && txt_masp.Text.Equals(sp.MaSP))
                {
                    MessageBox.Show("MSSV trùng rồi, nhập lại cái khác đi");
                    return false;
                }
                else
                {
                    if (txt_baohanh.Text == "" || txt_HDH.Text == "" || txt_manhinh.Text == "" || txt_namedt.Text == "" || txt_pin.Text == "" || txt_xuatxu.Text == "")
                    {
                        MessageBox.Show("Không được để trống");
                    }
                    sp.BaoHanh = txt_baohanh.Text;
                    sp.HeDieuHanh = txt_HDH.Text;
                    sp.TenSP = txt_namedt.Text;
                    sp.ManHinh = txt_manhinh.Text;
                    sp.NoiXuatXu = txt_xuatxu.Text;
                    sp.Pin = txt_pin.Text;
                    sp.HangSX = cbb_hangsx.SelectedItem.ToString();
                    sp.Ram = cbb_ram.SelectedItem.ToString();
                    sp.BoNhoTrong = cbb_BNT.SelectedItem.ToString();
                    sp.SoSim = Convert.ToInt32(cbb_sim.SelectedItem.ToString());
                    db.SaveChanges();
                    Run();
                }
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
        private void bt_luu_Click(object sender, EventArgs e)
        {
            if(!Oke())
            {
                MessageBox.Show("Error");
            }
        }
    }
}
