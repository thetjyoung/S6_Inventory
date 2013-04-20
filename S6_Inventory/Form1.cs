using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
using System.Data.OleDb;
using System.Collections;
using Excel = Microsoft.Office.Interop.Excel;


namespace S6_Inventory
{
    public partial class Form1 : Form
    {
        //Change connection string for network deployment
        private string strConnection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB.accdb;";
        DataTable dt_Users = new DataTable();
        DataTable dt_Assets = new DataTable();


        private string[] Options = {"FirstName","LastName","Rank","Company","Type","Make","Model","Name","SerialNum","MAC","PhoneNum"};

        private bool semaphore = true;

        MSDASC.DataLinks mydlg = new MSDASC.DataLinks();
        OleDbConnection OleCon = new OleDbConnection();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            cmb_Options.Items.AddRange(Options);

            DisplayAll();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SearchIt();
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            AddUser add = new AddUser(strConnection);
            add.ShowDialog();
            SearchIt();
        }

        private void btn_UpdUser_Click(object sender, EventArgs e)
        {
            if (dtg_Users.SelectedRows.Count != 0)
            {
                UpdUser upd = new UpdUser(strConnection, dtg_Users.SelectedRows[0].Cells[0].Value.ToString());
                upd.ShowDialog();
                SearchIt();
            }
        }

        private void btn_DelUser_Click(object sender, EventArgs e)
        {

            if (dtg_Users.SelectedRows.Count != 0)
            {
                DialogResult result;
                result = MessageBox.Show("Are you sure you want to delete user?\nUsername: " + dtg_Users.SelectedRows[0].Cells[0].Value.ToString() + "", "Delete User", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string UserID = dtg_Users.SelectedRows[0].Cells[0].Value.ToString();
                    OleDbConnection Conn = new OleDbConnection(strConnection);
                    Conn.Open();

                    string strorph = "Select * from Assets where UserID = '" + UserID + "'";
                    OleDbCommand cmdorph = new OleDbCommand(strorph, Conn);
                    if (cmdorph.ExecuteScalar() != null)
                        MessageBox.Show("Cannot Delete User: One or more assets belong to this user!");
                    else
                    {
                        string strDel = "Delete from Users where UserID = '" + UserID + "'";
                        OleDbCommand cmdDel = new OleDbCommand(strDel, Conn);
                        cmdDel.ExecuteNonQuery();
                        SearchIt();
                    }
                }
            }
        }

        private void SearchIt()
        {
            semaphore = false;
            string SearchCriteria = txt_Search.Text.ToString().Trim().Replace("'", "''");
            string Opt = cmb_Options.Text.ToString().Trim();
            dt_Users.Clear();
            dt_Assets.Clear();

            if (SearchCriteria == "" || Opt == "")
            {
                DisplayAll();
            }
            else if (Opt == "FirstName" || Opt == "LastName" || Opt == "Rank" || Opt == "Company")
            {
                OleDbConnection Conn = new OleDbConnection(strConnection);
                Conn.Open();
                string search = "Select * from Users where " + Opt + " like '" + SearchCriteria + "%'";
                OleDbDataAdapter da = new OleDbDataAdapter(search, Conn);
                da.Fill(dt_Users);

                for (int i = 0; i < dt_Users.Rows.Count; i++)
                {
                    string Asset = "Select * from Assets where UserID = '" + dt_Users.Rows[i]["UserID"].ToString() + "'";
                    OleDbDataAdapter da2 = new OleDbDataAdapter(Asset, Conn);
                    da2.Fill(dt_Assets);
                }

                dtg_Users.DataSource = dt_Users;
                dtg_Assets.DataSource = dt_Assets;

                if (dt_Assets.Rows.Count > 0)
                    dtg_Assets.Rows[0].Selected = false;
                if (dt_Users.Rows.Count > 0)
                    dtg_Users.Rows[0].Selected = false;

                dtg_Assets.Columns[0].Visible = false;
            }
            else if (Opt == "Type" || Opt == "Make" || Opt == "Model" || Opt == "Name" || Opt == "SerialNum" || Opt == "MAC" || Opt == "PhoneNum")
            {
                OleDbConnection Conn = new OleDbConnection(strConnection);
                Conn.Open();
                string search = "Select * from Assets where " + Opt + " = '" + SearchCriteria + "'";
                OleDbDataAdapter da = new OleDbDataAdapter(search, Conn);
                da.Fill(dt_Assets);

                ArrayList checksum = new ArrayList();
                for (int i = 0; i < dt_Assets.Rows.Count; i++)
                {
                    string userid = dt_Assets.Rows[i]["UserID"].ToString().Trim();
                    if (!checksum.Contains(userid))
                    {
                        checksum.Add(userid);
                        string User = "Select * from Users where UserID = '" + userid + "'";
                        OleDbDataAdapter da2 = new OleDbDataAdapter(User, Conn);
                        da2.Fill(dt_Users);
                    }
                }

                dtg_Users.DataSource = dt_Users;
                dtg_Assets.DataSource = dt_Assets;

                if (dt_Assets.Rows.Count > 0)
                    dtg_Assets.Rows[0].Selected = false;
                if (dt_Users.Rows.Count > 0)
                    dtg_Users.Rows[0].Selected = false;

                dtg_Assets.Columns[0].Visible = false;
            }
            ColorIn();

            semaphore = true;
        }

        private void btn_AddAsset_Click(object sender, EventArgs e)
        {
            FnAddAsset();
        }

        private void FnAddAsset()
        {
            if (dtg_Users.SelectedRows.Count == 0)
                MessageBox.Show("Please Select A User To Add Asset For!");
            else
            {
                string u = dtg_Users.SelectedRows[0].Cells["UserID"].Value.ToString().Trim();
                AddAsset add = new AddAsset(strConnection, u);
                add.ShowDialog();
                SearchIt();
            }
        }

        private void btn_DelAsset_Click(object sender, EventArgs e)
        {
            if (dtg_Assets.SelectedRows.Count != 0)
            {
                DialogResult result;
                result = MessageBox.Show("Are you sure you want to delete asset?\nSN: " + dtg_Assets.SelectedRows[0].Cells["SerialNum"].Value.ToString() + "", "Delete Asset", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string AssetID = dtg_Assets.SelectedRows[0].Cells[0].Value.ToString();
                    OleDbConnection Conn = new OleDbConnection(strConnection);
                    Conn.Open();

                    string strDel = "Delete from Assets where AssetID = " + AssetID + "";
                    OleDbCommand cmdDel = new OleDbCommand(strDel, Conn);
                    cmdDel.ExecuteNonQuery();
                    SearchIt();
                }
            }
        }

        private void btn_UpdAsset_Click(object sender, EventArgs e)
        {
            if (dtg_Assets.SelectedRows.Count != 0)
            {
                UpdAsset upd = new UpdAsset(strConnection, dtg_Assets.SelectedRows[0].Cells[0].Value.ToString());
                upd.ShowDialog();
                SearchIt();
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            if (dt_Assets.Rows.Count == 0 && dt_Users.Rows.Count == 0)
                MessageBox.Show("Nothing To Print!");
            else
            {
                //SaveDialog.ShowDialog();
                Excel.Application exapp = new Excel.Application();
                exapp.Visible = true;
                exapp.Workbooks.Add(1);

                // Add column headings...
                int iCol = 0;
                foreach (DataColumn c in dt_Users.Columns)
                {
                    iCol++;
                    exapp.Cells[1, iCol] = c.ColumnName;
                }
                // for each row of data...
                int iRow = 0;
                foreach (DataRow r in dt_Users.Rows)
                {
                    iRow++;
                    // add each row's cell data...
                    iCol = 0;
                    foreach (DataColumn c in dt_Users.Columns)
                    {
                        iCol++;
                        exapp.Cells[iRow + 1, iCol] = r[c.ColumnName];
                    }
                }

                //print assets
                iCol = 0;
                foreach (DataColumn c in dt_Assets.Columns)
                {
                    iCol++;
                    exapp.Cells[dt_Users.Rows.Count + 4, iCol] = c.ColumnName;
                }
                // for each row of data...
                iRow = dt_Users.Rows.Count + 3;
                foreach (DataRow r in dt_Assets.Rows)
                {
                    iRow++;
                    // add each row's cell data...
                    iCol = 0;
                    foreach (DataColumn c in dt_Assets.Columns)
                    {
                        iCol++;
                        exapp.Cells[iRow + 1, iCol] = r[c.ColumnName];
                    }
                }

            }
        }

        private void DisplayAll()
        {
            semaphore = false;

            dt_Users.Clear();
            dt_Assets.Clear();

            OleDbConnection Conn = new OleDbConnection(strConnection);
            Conn.Open();
            string AllUser = "Select * from Users order by LastName";
            string AllAsset = "Select * from Assets order by SerialNum";
            OleDbDataAdapter daUser = new OleDbDataAdapter(AllUser, Conn);
            OleDbDataAdapter daAsset = new OleDbDataAdapter(AllAsset, Conn);

            daUser.Fill(dt_Users);
            daAsset.Fill(dt_Assets);

            dtg_Assets.DataSource = dt_Assets;
            dtg_Users.DataSource = dt_Users;

            if (dt_Assets.Rows.Count > 0)
                dtg_Assets.Rows[0].Selected = false;
            if (dt_Users.Rows.Count > 0)
                dtg_Users.Rows[0].Selected = false;

            dtg_Assets.Columns[0].Visible = false;
            
            ColorIn();
            Conn.Close();

            semaphore = true;
        }

        private void ColorIn()
        {
            if (dtg_Assets.Rows.Count > 0)
            {
                for (int i = 0; i < dtg_Assets.Rows.Count; i++)
                {
                    if (dtg_Assets.Rows[i].Cells["Type"].Value.ToString() == "Computer" || dtg_Assets.Rows[i].Cells["Type"].Value.ToString() == "VOIP" || dtg_Assets.Rows[i].Cells["Type"].Value.ToString() == "Scanner" || dtg_Assets.Rows[i].Cells["Type"].Value.ToString() == "Copier" || dtg_Assets.Rows[i].Cells["Type"].Value.ToString() == "Printer")
                    { 
                        if(dtg_Assets.Rows[i].Cells["Network"].Value.ToString() == "NIPR")
                            dtg_Assets.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                        else if (dtg_Assets.Rows[i].Cells["Network"].Value.ToString() == "SIPR")
                            dtg_Assets.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        else if (dtg_Assets.Rows[i].Cells["Network"].Value.ToString() == "CENTRIX")
                            dtg_Assets.Rows[i].DefaultCellStyle.BackColor = Color.Blue;
                    }
                }
            }
        }


        private void dtg_Users_SelectionChanged(object sender, EventArgs e)
        {
            if (dtg_Users.SelectedRows.Count > 0 && semaphore)
            {
                string UserID = dtg_Users.SelectedRows[0].Cells["UserID"].Value.ToString();
                dt_Assets.Clear();

                OleDbConnection Conn = new OleDbConnection(strConnection);
                Conn.Open();

                string getAssets = "Select * from Assets where UserID = '" + UserID + "'";
                OleDbDataAdapter da = new OleDbDataAdapter(getAssets, Conn);

                da.Fill(dt_Assets);
                dtg_Assets.DataSource = dt_Assets;
                if(dt_Assets.Rows.Count > 0)
                    dtg_Assets.Rows[0].Selected = false;

                ColorIn();
                Conn.Close();
            }
        }

        private void dtg_Users_DoubleClick(object sender, EventArgs e)
        {
            FnAddAsset();
        }

        private void dtg_Assets_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ColorIn();
        }
    }
}
