
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GiaoDien.Source_Code_CSDL;
using DACNPM.dll;
namespace GiaoDien
{
    public partial class QLSP : Form
    {
        SE_14X db = new SE_14X();
        //SE_14 db = new SE_14();
        private string _Picture;
        private string _MaSP;
        public string MaSP { get => _MaSP; set => _MaSP = value; }
        public ShowDTGV_QLSP show { get => _show; set => _show = value; }
        public string Picture { get => _Picture; set => _Picture = value; }

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
            //Kiểm tra xem người dùng đã chọn file chưa
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Lấy hình ảnh
                openFileDialog1.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 0;
                Image img = Image.FromFile(openFileDialog1.FileName);
                // Gán ảnh
                pic_dt.Image = img;
                Picture = openFileDialog1.FileName;
            }
        }
        private void SetView()
        {
            if(MaSP!="")
            {
                txt_masp.Enabled = false;
                KT_Gia_NhapXuat kt = db.KT_Gia_NhapXuats.Where(p => p.MaSP == MaSP).FirstOrDefault();
                ChiTiet_SP sp = db.ChiTiet_SPs.Where(p => p.MaSP == MaSP).FirstOrDefault();
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
                pic_dt.Image = NVQL.Instance.ByteToImg(sp.HinhAnh);
                Picture= sp.HinhAnh;
                txt_gianhap.Text = kt.GiaNhap.ToString();
                txt_giaban.Text = kt.GiaBan.ToString();
                txt_soluong.Text = kt.Soluong.ToString();
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
                ChiTiet_SP sp = db.ChiTiet_SPs.Where(p => p.MaSP == txt_masp.Text).FirstOrDefault();
                if(sp==null)
                {
                    if (txt_baohanh.Text != "" && txt_HDH.Text != "" && txt_manhinh.Text != "" && txt_namedt.Text != "" && txt_pin.Text != "" && txt_xuatxu.Text != "")
                    {
                        db.ChiTiet_SPs.Add(new ChiTiet_SP
                        {
                            MaSP = txt_masp.Text,
                            BaoHanh = txt_baohanh.Text,
                            HeDieuHanh = txt_HDH.Text,
                            TenSP = txt_namedt.Text,
                            ManHinh = txt_manhinh.Text,
                            NoiXuatXu = txt_xuatxu.Text,
                            Pin = txt_pin.Text,
                            HinhAnh= Convert.ToBase64String(NVQL.Instance.converImgToByte(Picture)),
                            HangSX = cbb_hangsx.SelectedItem.ToString(),
                            Ram = cbb_ram.SelectedItem.ToString(),
                            BoNhoTrong = cbb_BNT.SelectedItem.ToString(),
                            SoSim = Convert.ToInt32(cbb_sim.SelectedItem.ToString()),
                            
                        });
                        db.KT_Gia_NhapXuats.Add(new KT_Gia_NhapXuat
                        {
                            MaSP = txt_masp.Text,
                            GiaNhap = Convert.ToInt32(txt_gianhap.Text.ToString()),
                            GiaBan = Convert.ToInt32(txt_giaban.Text.ToString()),
                            NgayApDung = ngayapdung.Value,
                            Soluong=Convert.ToInt32(txt_soluong.Text)
                        }) ;
                        MessageBox.Show("Add thành công");
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
                    Check_MaSP();

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

                ChiTiet_SP sp = db.ChiTiet_SPs.Where(p => p.MaSP == MaSP).FirstOrDefault();
                KT_Gia_NhapXuat kt = db.KT_Gia_NhapXuats.Where(p => p.MaSP == MaSP).FirstOrDefault();
                if (txt_masp.Enabled == true)
                {
                    MessageBox.Show("MSSV trùng rồi, nhập lại cái khác đi");
                    return false;
                }
                else
                {
                    
                    if (txt_baohanh.Text == "" || txt_HDH.Text == "" ||txt_soluong.Text==""
                        || txt_manhinh.Text == "" || txt_namedt.Text == "" 
                        || txt_pin.Text == "" || txt_xuatxu.Text == ""||txt_gianhap.Text==""||txt_giaban.Text=="")
                    {
                        MessageBox.Show("Không được để trống");
                    }
                    else
                    {
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
                        sp.HinhAnh = Picture;
                        kt.GiaNhap = Convert.ToInt32(txt_gianhap.Text);
                        kt.GiaBan = Convert.ToInt32(txt_giaban.Text);
                        kt.NgayApDung = ngayapdung.Value;
                        kt.Soluong = Convert.ToInt32(txt_soluong.Text);
                        db.SaveChanges();
                        MessageBox.Show("Edit thành công");
                        Run();
                    }
                                   
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
