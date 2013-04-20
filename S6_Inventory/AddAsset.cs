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
    public partial class AddAsset : Form
    {
        private string strConnection;

        private string[] Type = { "Computer", "Printer","Fax", "Scanner", "Copier", "VOIP", "Radio", "Misc" };
        private string[] Network = { "NIPR", "SIPR", "CENTRIX", "N/A" };

        private ArrayList TypeList = new ArrayList();
        private ArrayList NetList = new ArrayList();
        private string UserID;

        private string MACPattern = "^[0-9A-F]{12}$";

        MSDASC.DataLinks mydlg = new MSDASC.DataLinks();
        OleDbConnection OleCon = new OleDbConnection();
        ADODB._Connection ADOCon;

        public AddAsset(string strCon, string U)
        {
            InitializeComponent();
            strConnection = strCon;
            UserID = U;
            lbl_UserID.Text = "User ID: " + UserID;
        }

        private void AddAsset_Load(object sender, EventArgs e)
        {
            cmb_Type.Items.AddRange(Type);
            cmb_Type.SelectedIndex = 0;
            cmb_Network.Items.AddRange(Network);
            cmb_Network.SelectedIndex = 0;
            for (int i = 0; i < Type.Length; i++)
            { TypeList.Add(Type[i]); }
            for (int i = 0; i < Network.Length; i++)
            { NetList.Add(Network[i]); }

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
            string Serial = txt_Serial.Text.ToString().Trim().Replace("'", "''").ToUpper();
            string Name = txt_Name.Text.ToString().Trim().Replace("'", "''").ToUpper();
            string Mac = txt_MAC.Text.ToString().Trim().Replace("'", "''").Replace(":", "").Replace("-", "").ToUpper();
            string IP = txt_IP1.Text.ToString().Trim().Replace("'", "''") + "." + txt_IP2.Text.ToString().Trim().Replace("'", "''") + "." + txt_IP3.Text.ToString().Trim().Replace("'", "''") + "." + txt_IP4.Text.ToString().Trim().Replace("'", "''");
            if (IP == "...")
                IP = "";
            string OS = txt_OS.Text.ToString().Trim().Replace("'", "''");
            string PhoneNum = txt_PhoneNum.Text.ToString().Trim().Replace("'", "''");
            string Port = txt_Port.Text.ToString().Trim().Replace("'", "''");
            string Location = txt_Location.Text.ToString().Trim().Replace("'", "''");
            string strNetwork = cmb_Network.Text.ToString().Trim();
            if (strNetwork == "")
                strNetwork = "N/A";
            string Switch = txt_Switch.Text.ToString().Trim().Replace("'", "''").ToUpper();

            if (HandReceipt == "" || Make == "" || Model == "" || Serial == "")
            { MessageBox.Show("Please fill in all Required fields!"); }
            else if (!TypeList.Contains(strType))
            { MessageBox.Show("Please Select a Valid Type!"); }
            else if (!NetList.Contains(strNetwork))
            { MessageBox.Show("Please Select a Valid Network!"); }
            else if ((Mac != "" && Mac.Length < 12) || (Mac != "" && !System.Text.RegularExpressions.Regex.IsMatch(Mac, MACPattern)))
            { MessageBox.Show("Invalid MAC Address!"); }
            else
            {
                try
                {
                    OleDbConnection Conn = new OleDbConnection(strConnection);
                    Conn.Open();

                    string dup = "Select * from Assets where SerialNum = '" + Serial + "'";
                    OleDbCommand cmddup = new OleDbCommand(dup, Conn);

                    if (cmddup.ExecuteScalar() != null)
                    { MessageBox.Show("Duplicate Record Found, New Record Not Created!"); }
                    else
                    {
                        string strID = "Select Max(AssetID) from Assets";
                        OleDbCommand cmdID = new OleDbCommand(strID, Conn);
                        int AssetID = 0;
                        int.TryParse(cmdID.ExecuteScalar().ToString(), out AssetID);
                        AssetID += 1;

                        string strInsert = "Insert into Assets(AssetID,UserID,HandReceiptID,Type,Make,Model,Name,SerialNum,MAC,IP,OS,PhoneNum,Location,Port,Network,Switch) "
                            + "Values('" + AssetID + "','" + UserID + "','" + HandReceipt + "','" + strType + "','" + Make + "','" + Model + "','" + Name + "','" + Serial + "','" + Mac + "','" + IP + "','" + OS + "','" + PhoneNum + "','" + Location + "','" + Port + "','" + strNetwork + "','" + Switch + "')";
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

    }
}
