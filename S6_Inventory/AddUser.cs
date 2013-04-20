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
    public partial class AddUser : Form
    {
        private string strConnection;

        private string[] Rank = { "PVT", "PV2", "PFC", "SPC", "SGT", "SSG", "SFC", "FS", "SGM", "CSM", "SMA","WO1","WO2","WO3","WO4","WO5","2LT","1LT","CPT","MAJ","LTC","COL","BG","MG","LG","GEN"};
        private string[] Comp = { "HHC","ALPHA","BRAVO","CHARLIE","DELTA","ECHO"};

        private ArrayList RankList = new ArrayList();
        private ArrayList CompanyList = new ArrayList();

        MSDASC.DataLinks mydlg = new MSDASC.DataLinks();
        OleDbConnection OleCon = new OleDbConnection();


        public AddUser(string ConString)
        {
            InitializeComponent();

            strConnection = ConString;
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            cmb_Company.Items.AddRange(Comp);
            cmb_Rank.Items.AddRange(Rank);
            for (int i = 0; i < Rank.Length; i++)
            { RankList.Add(Rank[i]); }
            for (int i = 0; i < Comp.Length; i++)
            { CompanyList.Add(Comp[i]); }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string FirstName = txt_FirstName.Text.ToString().Trim().Replace("'", "''");
            string LastName = txt_LastName.Text.ToString().Trim().Replace("'", "''");
            string Username = txt_Username.Text.ToString().Trim().Replace("'", "''").ToLower();
            string strRank = cmb_Rank.Text.ToString().Trim().Replace("'", "''");
            string Company = cmb_Company.Text.ToString().Trim().Replace("'", "''");
            string Position = txt_Position.Text.ToString().Trim().Replace("'", "''");
            string Location = txt_Location.Text.ToString().Trim().Replace("'", "''");

            if(FirstName == "" || LastName == "" || Username == "")
            { MessageBox.Show("Please fill in all Required fields!"); }
            else if (!RankList.Contains(strRank))
            { MessageBox.Show("Please Select a Valid Rank!"); }
            else if (!CompanyList.Contains(Company))
            { MessageBox.Show("Please Select a Valid Company!"); }
            else
            {
                try
                {
                    OleDbConnection Conn = new OleDbConnection(strConnection);
                    Conn.Open();

                    string dup = "Select * from Users where UserID = '" + Username + "'";
                    string dup2 = "Select * from Users where FirstName = '" + FirstName + "' And LastName = '" + LastName + "' And Rank = '" + strRank + "'";
                    OleDbCommand cmddup = new OleDbCommand(dup, Conn);
                    OleDbCommand cmddup2 = new OleDbCommand(dup2, Conn);

                    if (cmddup.ExecuteScalar() != null)
                    { MessageBox.Show("Duplicate Record Found, New Record Not Created!"); }
                    else if (cmddup2.ExecuteScalar() != null)
                    { MessageBox.Show("Duplicate Record Found, New Record Not Created!"); }
                    else
                    {
                        string strInsert = "Insert into Users(UserID,FirstName,LastName,Rank,Company,[Position],Location) Values('" + Username + "','" + FirstName + "','" + LastName + "','" + strRank + "','" + Company + "','" + Position + "','" + Location + "')";
                        OleDbCommand cmdInsert = new OleDbCommand(strInsert, Conn);
                        cmdInsert.ExecuteNonQuery();

                        this.Close();
                    }

                    Conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
