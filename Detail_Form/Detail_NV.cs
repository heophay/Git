﻿using System;
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
    public partial class Detail_NV : Form
    {
        public Detail_NV()
        {
            InitializeComponent();
            Date_ngaysinh.Value = Convert.ToDateTime("2020/09/09");
        }
    }
}