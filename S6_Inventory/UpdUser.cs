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

namespace S6_Inventory
{
    public partial class UpdUser : Form
    {
        private string strConnection;

        private string[] Rank = { "PVT", "PV2", "PFC", "SPC", "SGT", "SSG", "SFC", "FS", "SGM", "CSM", "SMA", "WO1", "WO2", "WO3", "WO4", "WO5", "2LT", "1LT", "CPT", "MAJ", "LTC", "COL", "BG", "MG", "LG", "GEN" };
        private string[] Comp = { "HHC", "ALPHA", "BRAVO", "CHARLIE", "DELTA", "ECHO" };
        private string Username;
        private DataTable dt = new DataTable();
        private ArrayList RankList = new ArrayList();
        private ArrayList CompanyList = new ArrayList();

        MSDASC.DataLinks mydlg = new MSDASC.DataLinks();
        OleDbConnection OleCon = new OleDbConnection();
        
        public UpdUser(string ConString, string Usr)
        {
            InitializeComponent();
            strConnection = ConString;

            Username = Usr;
            lbl_User.Text = Username;

            OleDbConnection Conn = new OleDbConnection(strConnection);
            Conn.Open();
            string lookup = "Select * from Users where UserID = '" + Usr + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(lookup, Conn);
            da.Fill(dt);
            Conn.Close();

            if (dt.Rows.Count == 0)
                this.Close();   
        }

        private void UpdUser_Load(object sender, EventArgs e)
        {
            cmb_Company.Items.AddRange(Comp);
            cmb_Rank.Items.AddRange(Rank);
            for (int i = 0; i < Rank.Length; i++)
            { RankList.Add(Rank[i]); }
            for (int i = 0; i < Comp.Length; i++)
            { CompanyList.Add(Comp[i]); }

            txt_FirstName.Text = dt.Rows[0]["FirstName"].ToString().Trim();
            txt_LastName.Text = dt.Rows[0]["LastName"].ToString().Trim();
            txt_Location.Text = dt.Rows[0]["Location"].ToString().Trim();
            txt_Position.Text = dt.Rows[0]["Position"].ToString().Trim();
            cmb_Rank.Text = dt.Rows[0]["Rank"].ToString().Trim();
            cmb_Company.Text = dt.Rows[0]["Company"].ToString().Trim();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string FirstName = txt_FirstName.Text.ToString().Trim().Replace("'", "''");
            string LastName = txt_LastName.Text.ToString().Trim().Replace("'", "''");
            string strRank = cmb_Rank.Text.ToString().Trim().Replace("'", "''");
            string Company = cmb_Company.Text.ToString().Trim().Replace("'", "''");
            string Position = txt_Position.Text.ToString().Trim().Replace("'", "''");
            string Location = txt_Location.Text.ToString().Trim().Replace("'", "''");

            if (FirstName == "" || LastName == "")
            { MessageBox.Show("Please fill in all Required fields!"); }
            else if (!RankList.Contains(strRank))
            { MessageBox.Show("Please Select a Valid Rank!"); }
            else if (!CompanyList.Contains(Company))
            { MessageBox.Show("Please Select a Valid Company!"); }
            else
            {
                DialogResult result;
                result = MessageBox.Show("Are You Sure You Want To Commit These Changes?", "Update User", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        OleDbConnection Conn = new OleDbConnection(strConnection);
                        Conn.Open();


                        string strUpdate = "Update Users set FirstName = '" + FirstName + "',LastName = '" + LastName + "',Rank = '" + strRank + "',Company = '" + Company + "',[Position] = '" + Position + "',Location = '" + Location + "' where UserID = '" + Username + "'";
                        OleDbCommand cmdUpdate = new OleDbCommand(strUpdate, Conn);
                        cmdUpdate.ExecuteNonQuery();

                        this.Close();

                        Conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
