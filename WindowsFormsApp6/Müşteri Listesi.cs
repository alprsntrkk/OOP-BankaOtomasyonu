﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class frmMusteriListe : Form
    {
        public frmMusteriListe()
        {
            InitializeComponent();
        }
        public Banka BankaApp { get; set; }
        
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            grdMusteriListesi.DataSource = null;
            grdMusteriListesi.DataSource = BankaApp.müsteriList;
            
        }

        private void frmMusteriListe_Load(object sender, EventArgs e)
        {

        }
    }
}
