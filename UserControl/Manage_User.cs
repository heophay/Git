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
    public partial class Manage_User : UserControl
    {
        Detail_KH d;
        SE_14 db = new SE_14();
        public Manage_User()
        {
            InitializeComponent();
            ShowDGV();
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
             d= new Detail_KH();
             d.ShowDialog();
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            d = new Detail_KH();
            d.ShowDialog();
        }
        public void ShowDGV()
        {
            DGV_KH.DataSource = db.ThongTinCaNhans.Select(p => new { p.MaTK, p.TenKH, p.NgaySinh, p.SoDT, p.Gender, p.DiaChi }).ToList();
        }
    }
}
