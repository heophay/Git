﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GiaoDien.Source_Code_CSDL;
namespace GiaoDien
{
    public partial class TrangChuManager : UserControl
    {
        SE_14X db = new SE_14X();
        //SE_14 db = new SE_14();
        private string _MaTK;
        public TrangChuManager(string Matk)
        {
            MaTK = Matk;
            InitializeComponent();
            SetView(MaTK);
        }
        
        private void SetView(string matk)
        {
            TaiKhoan tk = db.TaiKhoans.Where(p => p.MaTK == matk).FirstOrDefault();
            if (tk.LoaiTK== "Manager")
            {
                bt_Nhanvien.Visible = false;
                label_Greeting.Text += " " + tk.LoaiTK;
            }
            if (tk.LoaiTK == "Admin")
            {
                label_Greeting.Text += " " + tk.LoaiTK;
                bt_TTCN.Visible = false;
            }
        }
        public string MaTK { get => _MaTK; set => _MaTK = value; }


        private void button_DanhMuc_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new DanhMucAd());
        }

        private void bt_KH_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new QLKH());
        }

        private void bt_TTCN_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new TaiKhoanUser(MaTK));
        }

        private void bt_SP_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new QL_SanPham());
        }

        private void bt_Nhanvien_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new TT_NhanVien());
        }
    }
}
