﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GiaoDien
{
    public delegate void Get_ListMaSP(ItemsGH Masp);
    public partial class User : UserControl
    {
        private List<ItemsGH> ListMaSP = new List<ItemsGH>();
        private string _matk;

        public string Matk { get => _matk; set => _matk = value; }
        SE_14X db = new SE_14X();
        public User(string Matk)
        {
            this.Matk = Matk;
            InitializeComponent();
            panel1.Controls.Clear();
            TrangChuUser l = new TrangChuUser();
            panel1.Controls.Add(l);
            if(Matk!="")  SetView();
        }
        public void DoProcessing(IProgress<int> progress)
        {
            for (int i = 0; i != 100; ++i)
            {
                Thread.Sleep(100);
                if (progress != null)
                    progress.Report(i);
            }
        }
        private void button_TrangChu_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            TrangChuUser l = new TrangChuUser(Get_Listmasp);
            panel1.Controls.Add(l);
        }
        private void button_TaiKhoan_Click(object sender, EventArgs e)
        {
            if(this.Matk!="")
            {
                panel1.Controls.Clear();
                TaiKhoanUser l = new TaiKhoanUser(Matk);
                panel1.Controls.Add(l);
            }
            else
            {
                if(MessageBox.Show("Bạn có muốn đăng nhập để tiếp tục chức năng này?", "Xác Nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    MessageBox.Show("Mời Bạn nhấn đăng nhập ở góc phải màn hình");
                }
            }
        }

        private void button_GioHang_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            GioHangUser l = new GioHangUser(this.ListMaSP,Matk,Reset_ListSP);
            panel1.Controls.Add(l);
        }

        private void button_DonHang_Click(object sender, EventArgs e)
        {
            if(this.Matk!="")
            {
                panel1.Controls.Clear();
                DonHangCus l = new DonHangCus(this.Matk);
                panel1.Controls.Add(l);
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn đăng nhập để tiếp tục chức năng này?", "Xác Nhận",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Mời Bạn nhấn đăng nhập ở góc phải màn hình");
                }              
            }
        }

        private void User_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            TrangChuUser l = new TrangChuUser(Get_Listmasp);
            panel1.Controls.Add(l);
        }
        public void SetView()
        {
            label_Greeting.Text +=" "+ db.ThongTinCaNhans.Where(p => p.MaTK == Matk).FirstOrDefault().TenKH;
        }
        public void Get_Listmasp(ItemsGH Masp)
        {

            bool kt = true;
            int index = -1;
            foreach (ItemsGH i in ListMaSP)
            {
                if (i.MaSP.Equals(Masp.MaSP))
                {
                    kt = false;
                    index = ListMaSP.IndexOf(i);
                }

            }
            if (kt == true) this.ListMaSP.Add(Masp);
            else
            {
                ListMaSP[index].Soluong += Masp.Soluong;
                ListMaSP[index].ThanhTien = ListMaSP[index].Soluong * ListMaSP[index].Gia;
            }
        }
        public void Reset_ListSP()
        {
            this.ListMaSP = new List<ItemsGH>();
            panel1.Controls.Clear();
            GioHangUser l = new GioHangUser(this.ListMaSP, Matk, Reset_ListSP);
            panel1.Controls.Add(l);
        }
    }
}
