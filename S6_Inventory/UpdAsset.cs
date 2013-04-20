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
    public partial class UpdAsset : Form
    {
        private string strConnection;

        private string[] Type = { "Computer", "Printer", "Fax", "Scanner", "Copier", "VOIP", "Radio", "Misc" };
        private string[] Network = { "NIPR", "SIPR", "CENTRIX", "N/A" };

        private string[] Rank = { "PVT", "PV2", "PFC", "SPC", "SGT", "SSG", "SFC", "FS", "SGM", "CSM", "SMA", "WO1", "WO2", "WO3", "WO4", "WO5", "2LT", "1LT", "CPT", "MAJ", "LTC", "COL", "BG", "MG", "LG", "GEN" };
        private string[] Comp = { "HHC", "ALPHA", "BRAVO", "CHARLIE", "DELTA", "ECHO" };

        private ArrayList RankList = new ArrayList();
        private ArrayList CompanyList = new ArrayList();
        private ArrayList TypeList = new ArrayList();
        private ArrayList NetList = new ArrayList();

        private DataTable dt_Assets = new DataTable();
        private DataTable dt_Users = new DataTable();
        private string AssetID;
        private string MACPattern = "^[0-9A-F]{12}$";

        private bool compSelect = false;
        private string CompVal;
        private bool rankSelect = false;
        private string RankVal;

        MSDASC.DataLinks mydlg = new MSDASC.DataLinks();
        OleDbConnection OleCon = new OleDbConnection();
        ADODB._Connection ADOCon;

        public UpdAsset(string ConString, string Asset)
        {
            InitializeComponent();
            strConnection = ConString;

            OleDbConnection Conn = new OleDbConnection(strConnection);
            string lookup = "Select * from Assets where AssetID = " + Asset + "";
            OleDbDataAdapter da = new OleDbDataAdapter(lookup, Conn);
            da.Fill(dt_Assets);

            if (dt_Assets.Rows.Count != 0)
            {
                string SerialNum;
                SerialNum = dt_Assets.Rows[0]["SerialNum"].ToString();
                AssetID = Asset;
                lbl_AssetID.Text = "Serial Number = " + SerialNum + "";
            }
            else
                this.Close();
        }

        private void UpdAsset_Load(object sender, EventArgs e)
        {
            cmb_Type.Items.AddRange(Type);
            cmb_Network.Items.AddRange(Network);
            for (int i = 0; i < Type.Length; i++)
            { TypeList.Add(Type[i]); }
            for (int i = 0; i < Network.Length; i++)
            { NetList.Add(Network[i]); }
            cmb_Company.Items.AddRange(Comp);
            cmb_Rank.Items.AddRange(Rank);
            for (int i = 0; i < Rank.Length; i++)
            { RankList.Add(Rank[i]); }
            for (int i = 0; i < Comp.Length; i++)
            { CompanyList.Add(Comp[i]); }

            //populate user grid
            OleDbConnection Conn = new OleDbConnection(strConnection);
            Conn.Open();
            string getUsers = "Select * from Users";
            OleDbDataAdapter da = new OleDbDataAdapter(getUsers, Conn);
            da.Fill(dt_Users);
            dg_Users.DataSource = dt_Users;
            Conn.Close();
            //Select proper User based on Asset
            for (int i = 0; i < dt_Users.Rows.Count; i++)
            {
                if (dt_Users.Rows[i]["UserID"].ToString() == dt_Assets.Rows[0]["UserID"].ToString())
                {
                    dg_Users.Rows[i].Selected = true;
                    break;
                }
            }
            cmb_Type.Text = dt_Assets.Rows[0]["Type"].ToString().Trim();
            txt_HandReceipt.Text = dt_Assets.Rows[0]["HandReceiptID"].ToString().Trim();
            txt_Make.Text = dt_Assets.Rows[0]["Make"].ToString().Trim();
            txt_Model.Text = dt_Assets.Rows[0]["Model"].ToString().Trim();
            txt_Name.Text = dt_Assets.Rows[0]["Name"].ToString().Trim();
            txt_MAC.Text = dt_Assets.Rows[0]["MAC"].ToString().Trim().ToUpper();
            if (dt_Assets.Rows[0]["IP"].ToString().Trim() != "" && dt_Assets.Rows[0]["IP"].ToString().Trim().Length == 15)
            {
                txt_IP1.Text = dt_Assets.Rows[0]["IP"].ToString().Trim().Substring(0, 3);
                txt_IP2.Text = dt_Assets.Rows[0]["IP"].ToString().Trim().Substring(4, 3);
                txt_IP3.Text = dt_Assets.Rows[0]["IP"].ToString().Trim().Substring(8, 3);
                txt_IP4.Text = dt_Assets.Rows[0]["IP"].ToString().Trim().Substring(12, 3);
            }
            txt_OS.Text = dt_Assets.Rows[0]["OS"].ToString().Trim();
            txt_PhoneNum.Text = dt_Assets.Rows[0]["PhoneNum"].ToString().Trim();
            txt_Port.Text = dt_Assets.Rows[0]["Port"].ToString().Trim();
            txt_Location.Text = dt_Assets.Rows[0]["Location"].ToString().Trim();
            cmb_Network.Text = dt_Assets.Rows[0]["Network"].ToString().Trim();
            txt_Switch.Text = dt_Assets.Rows[0]["Switch"].ToString().Trim();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string strType = cmb_Type.Text.ToString().Trim();
            string HandReceipt = txt_HandReceipt.Text.ToString().Trim().Replace("'", "''").ToUpper();
            string Make = txt_Make.Text.ToString().Trim().Replace("'", "''").ToUpper();
            string Model = txt_Model.Text.ToString().Trim().Replace("'", "''").ToUpper();
            string Name = txt_Name.Text.ToString().Trim().Replace("'", "''").ToUpper();
            string Mac = txt_MAC.Text.ToString().Trim().ToUpper();
            string IP = txt_IP1.Text.ToString().Trim().Replace("'", "''") + "." + txt_IP2.Text.ToString().Trim().Replace("'", "''") + "." + txt_IP3.Text.ToString().Trim().Replace("'", "''") + "." + txt_IP4.Text.ToString().Trim().Replace("'", "''");
            if (IP == "...")
                IP = "";
            string OS = txt_OS.Text.ToString().Trim().Replace("'", "''");
            string PhoneNum = txt_PhoneNum.Text.ToString().Trim().Replace("'", "''");
            string Port = txt_Port.Text.ToString().Trim().Replace("'", "''");
            string Location = txt_Location.Text.ToString().Trim().Replace("'", "''");
            string strNetwork = cmb_Network.Text.ToString().Trim();
            if(strNetwork == "")
                strNetwork = "N/A";
            string Switch = txt_Switch.Text.ToString().Trim().Replace("'", "''").ToUpper();

            if (dg_Users.SelectedRows.Count == 0)
                MessageBox.Show("Error: Please Select A User!");
            else if (HandReceipt == "" || Make == "" || Model == "")
            { MessageBox.Show("Please fill in all Required fields!"); }
            else if (!TypeList.Contains(strType))
            { MessageBox.Show("Please Select a Valid Type!"); }
            else if (!NetList.Contains(strNetwork))
            { MessageBox.Show("Please Select a Valid Network!"); }
            else if ((Mac != "" && Mac.Length < 12) || (Mac != "" && !System.Text.RegularExpressions.Regex.IsMatch(Mac, MACPattern)))
            { MessageBox.Show("Invalid MAC Address!"); }
            else
            {
                DialogResult result;
                result = MessageBox.Show("Are You Sure You Want To Commit These Changes?", "Update Asset", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string UserID = dg_Users.SelectedRows[0].Cells[0].Value.ToString().Trim();
                    try
                    {
                        OleDbConnection Conn = new OleDbConnection(strConnection);
                        Conn.Open();

                        string strUpd = "Update Assets set UserID = '" + UserID + "',HandReceiptID = '" + HandReceipt + "',Type = '" + strType + "',Make = '" + Make + "',Model = '" + Model + "',Name = '" + Name + "',MAC = '" + Mac + "',IP = '" + IP + "',OS = '" + OS + "',PhoneNum = '" + PhoneNum + "',Location = '" + Location + "',Port = '" + Port + "',Network = '" + strNetwork + "',Switch = '" + Switch + "' where AssetID = " + AssetID + "";
                        OleDbCommand cmdUpd = new OleDbCommand(strUpd, Conn);
                        cmdUpd.ExecuteNonQuery();

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

        private void txt_IP1_TextChanged(object sender, EventArgs e)
        {
            bool check = CheckIPFormat(txt_IP1.Text.ToString());
            if (!check)
                txt_IP1.Text = "";
        }

        private void txt_IP2_TextChanged(object sender, EventArgs e)
        {
            bool check = CheckIPFormat(txt_IP2.Text.ToString());
            if (!check)
                txt_IP2.Text = "";
        }

        private void txt_IP3_TextChanged(object sender, EventArgs e)
        {
            bool check = CheckIPFormat(txt_IP3.Text.ToString());
            if (!check)
                txt_IP3.Text = "";
        }

        private void txt_IP4_TextChanged(object sender, EventArgs e)
        {
            bool check = CheckIPFormat(txt_IP4.Text.ToString());
            if (!check)
                txt_IP4.Text = "";
        }

        private bool CheckIPFormat(string p)
        {
            if (p == "")
                return true;

            int tmp;
            if (int.TryParse(p, out tmp))
            {
                if (tmp > 255 || tmp < 0)
                    return false;
            }
            else
                return false;

            return true;
        }

        private void cmb_Company_SelectionChangeCommitted(object sender, EventArgs e)
        {
            compSelect = true;
            CompVal = cmb_Company.SelectedItem.ToString();
            dt_Users.Clear();

            OleDbConnection Conn = new OleDbConnection(strConnection);
            Conn.Open();

            if (rankSelect)
            {
                string upd = "Select * from Users where Company = '" + CompVal + "' AND Rank = '" + RankVal + "'";
                OleDbDataAdapter da = new OleDbDataAdapter(upd, Conn);
                da.Fill(dt_Users);
            }
            else
            {
                string upd = "Select * from Users where Company ='" + CompVal + "'";
                OleDbDataAdapter da = new OleDbDataAdapter(upd, Conn);
                da.Fill(dt_Users);
            }
            dg_Users.DataSource = dt_Users;
            Conn.Close();
        }

        private void cmb_Rank_SelectionChangeCommitted(object sender, EventArgs e)
        {
            rankSelect = true;
            RankVal = cmb_Rank.SelectedItem.ToString();
            dt_Users.Clear();

            OleDbConnection Conn = new OleDbConnection(strConnection);
            Conn.Open();

            if (compSelect)
            {
                string upd = "Select * from Users where Company = '" + CompVal + "' AND Rank = '" + RankVal + "'";
                OleDbDataAdapter da = new OleDbDataAdapter(upd, Conn);
                da.Fill(dt_Users);
            }
            else
            {
                string upd = "Select * from Users where Company ='" + CompVal + "'";
                OleDbDataAdapter da = new OleDbDataAdapter(upd, Conn);
                da.Fill(dt_Users);
            }
            dg_Users.DataSource = dt_Users;
            Conn.Close();
        }

    }
}
