﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class NhapXuatAdMa : UserControl
    {
        SE_14F db = new SE_14F();
        public NhapXuatAdMa()
        {
            InitializeComponent();
            SetView();
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            Detail_Gia d = new Detail_Gia();
            d.ShowDialog();
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            Detail_Gia d = new Detail_Gia();
            d.ShowDialog();
        }
        public void SetView()
        {
            DGV_Gia.DataSource = db.KT_Gia_NhapXuats.Select(p => new { p.ID_Gia, p.ChiTiet_SP.MaSP, p.GiaBan, p.GiaNhap, p.NgayApDung }).ToList();
        }
    }
}
