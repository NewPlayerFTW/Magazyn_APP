﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazyn1._0
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'magazynDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.magazynDataSet.Table);
        }

        private void moreBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.productDataGrid.SelectedRows)
            {
                try
                {
                    string id = row.Cells[0].Value.ToString();
                    ShowMoreDialog moreDialog = new ShowMoreDialog(id);
                    moreDialog.ShowDialog();
                }
                catch (Exception)
                {
                    MessageBox.Show("Nie wybrano pozycji!");
                }

            }
        }

    }
}