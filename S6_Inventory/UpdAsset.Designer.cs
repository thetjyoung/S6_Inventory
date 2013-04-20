namespace S6_Inventory
{
    partial class UpdAsset
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdAsset));
            this.label15 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.dg_Users = new System.Windows.Forms.DataGridView();
            this.txt_IP4 = new System.Windows.Forms.TextBox();
            this.txt_IP3 = new System.Windows.Forms.TextBox();
            this.txt_IP2 = new System.Windows.Forms.TextBox();
            this.cmb_Network = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_Location = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_PhoneNum = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_OS = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_IP1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_MAC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Model = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Make = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_HandReceipt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_AssetID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_Rank = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_Company = new System.Windows.Forms.ComboBox();
            this.txt_Switch = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Users)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(208, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 13);
            this.label15.TabIndex = 67;
            this.label15.Text = "-No Dash or Colon";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(294, 493);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 22;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(194, 493);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 21;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 290);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(170, 20);
            this.label14.TabIndex = 64;
            this.label14.Text = "User Signed For Asset";
            // 
            // dg_Users
            // 
            this.dg_Users.AllowUserToAddRows = false;
            this.dg_Users.AllowUserToDeleteRows = false;
            this.dg_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Users.Location = new System.Drawing.Point(12, 313);
            this.dg_Users.MultiSelect = false;
            this.dg_Users.Name = "dg_Users";
            this.dg_Users.ReadOnly = true;
            this.dg_Users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_Users.Size = new System.Drawing.Size(516, 174);
            this.dg_Users.TabIndex = 63;
            // 
            // txt_IP4
            // 
            this.txt_IP4.Location = new System.Drawing.Point(504, 113);
            this.txt_IP4.MaxLength = 3;
            this.txt_IP4.Name = "txt_IP4";
            this.txt_IP4.Size = new System.Drawing.Size(30, 20);
            this.txt_IP4.TabIndex = 11;
            this.txt_IP4.TextChanged += new System.EventHandler(this.txt_IP4_TextChanged);
            // 
            // txt_IP3
            // 
            this.txt_IP3.Location = new System.Drawing.Point(468, 113);
            this.txt_IP3.MaxLength = 3;
            this.txt_IP3.Name = "txt_IP3";
            this.txt_IP3.Size = new System.Drawing.Size(30, 20);
            this.txt_IP3.TabIndex = 10;
            this.txt_IP3.TextChanged += new System.EventHandler(this.txt_IP3_TextChanged);
            // 
            // txt_IP2
            // 
            this.txt_IP2.Location = new System.Drawing.Point(432, 113);
            this.txt_IP2.MaxLength = 3;
            this.txt_IP2.Name = "txt_IP2";
            this.txt_IP2.Size = new System.Drawing.Size(30, 20);
            this.txt_IP2.TabIndex = 9;
            this.txt_IP2.TextChanged += new System.EventHandler(this.txt_IP2_TextChanged);
            // 
            // cmb_Network
            // 
            this.cmb_Network.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmb_Network.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Network.FormattingEnabled = true;
            this.cmb_Network.Location = new System.Drawing.Point(102, 165);
            this.cmb_Network.Name = "cmb_Network";
            this.cmb_Network.Size = new System.Drawing.Size(121, 21);
            this.cmb_Network.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(49, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 62;
            this.label13.Text = "Network";
            // 
            // txt_Location
            // 
            this.txt_Location.Location = new System.Drawing.Point(102, 192);
            this.txt_Location.MaxLength = 50;
            this.txt_Location.Name = "txt_Location";
            this.txt_Location.Size = new System.Drawing.Size(100, 20);
            this.txt_Location.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(48, 195);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 61;
            this.label12.Text = "Location";
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(102, 139);
            this.txt_Port.MaxLength = 10;
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(100, 20);
            this.txt_Port.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(70, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 60;
            this.label11.Text = "Port";
            // 
            // txt_PhoneNum
            // 
            this.txt_PhoneNum.Location = new System.Drawing.Point(396, 139);
            this.txt_PhoneNum.MaxLength = 20;
            this.txt_PhoneNum.Name = "txt_PhoneNum";
            this.txt_PhoneNum.Size = new System.Drawing.Size(100, 20);
            this.txt_PhoneNum.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(312, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 59;
            this.label10.Text = "Phone Number";
            // 
            // txt_OS
            // 
            this.txt_OS.Location = new System.Drawing.Point(102, 113);
            this.txt_OS.MaxLength = 50;
            this.txt_OS.Name = "txt_OS";
            this.txt_OS.Size = new System.Drawing.Size(100, 20);
            this.txt_OS.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 58;
            this.label9.Text = "Operating System";
            // 
            // txt_IP1
            // 
            this.txt_IP1.Location = new System.Drawing.Point(396, 113);
            this.txt_IP1.MaxLength = 3;
            this.txt_IP1.Name = "txt_IP1";
            this.txt_IP1.Size = new System.Drawing.Size(30, 20);
            this.txt_IP1.TabIndex = 8;
            this.txt_IP1.TextChanged += new System.EventHandler(this.txt_IP1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(373, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "IP";
            // 
            // txt_MAC
            // 
            this.txt_MAC.Location = new System.Drawing.Point(102, 87);
            this.txt_MAC.MaxLength = 12;
            this.txt_MAC.Name = "txt_MAC";
            this.txt_MAC.Size = new System.Drawing.Size(100, 20);
            this.txt_MAC.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "MAC";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(396, 87);
            this.txt_Name.MaxLength = 50;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(133, 20);
            this.txt_Name.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Name";
            // 
            // txt_Model
            // 
            this.txt_Model.Location = new System.Drawing.Point(396, 61);
            this.txt_Model.MaxLength = 50;
            this.txt_Model.Name = "txt_Model";
            this.txt_Model.Size = new System.Drawing.Size(133, 20);
            this.txt_Model.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "* Model";
            // 
            // txt_Make
            // 
            this.txt_Make.Location = new System.Drawing.Point(102, 61);
            this.txt_Make.MaxLength = 50;
            this.txt_Make.Name = "txt_Make";
            this.txt_Make.Size = new System.Drawing.Size(121, 20);
            this.txt_Make.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "* Make";
            // 
            // txt_HandReceipt
            // 
            this.txt_HandReceipt.Location = new System.Drawing.Point(396, 34);
            this.txt_HandReceipt.MaxLength = 50;
            this.txt_HandReceipt.Name = "txt_HandReceipt";
            this.txt_HandReceipt.Size = new System.Drawing.Size(133, 20);
            this.txt_HandReceipt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "* Hand Receipt ID";
            // 
            // cmb_Type
            // 
            this.cmb_Type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmb_Type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Type.FormattingEnabled = true;
            this.cmb_Type.Location = new System.Drawing.Point(102, 34);
            this.cmb_Type.Name = "cmb_Type";
            this.cmb_Type.Size = new System.Drawing.Size(121, 21);
            this.cmb_Type.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "* Type";
            // 
            // lbl_AssetID
            // 
            this.lbl_AssetID.AutoSize = true;
            this.lbl_AssetID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AssetID.Location = new System.Drawing.Point(49, 9);
            this.lbl_AssetID.Name = "lbl_AssetID";
            this.lbl_AssetID.Size = new System.Drawing.Size(0, 15);
            this.lbl_AssetID.TabIndex = 68;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_Rank);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmb_Company);
            this.groupBox1.Location = new System.Drawing.Point(9, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 53);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter Users By:";
            // 
            // cmb_Rank
            // 
            this.cmb_Rank.FormattingEnabled = true;
            this.cmb_Rank.Location = new System.Drawing.Point(266, 24);
            this.cmb_Rank.Name = "cmb_Rank";
            this.cmb_Rank.Size = new System.Drawing.Size(121, 21);
            this.cmb_Rank.TabIndex = 20;
            this.cmb_Rank.SelectionChangeCommitted += new System.EventHandler(this.cmb_Rank_SelectionChangeCommitted);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(227, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Rank";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Company";
            // 
            // cmb_Company
            // 
            this.cmb_Company.FormattingEnabled = true;
            this.cmb_Company.Location = new System.Drawing.Point(63, 24);
            this.cmb_Company.Name = "cmb_Company";
            this.cmb_Company.Size = new System.Drawing.Size(121, 21);
            this.cmb_Company.TabIndex = 19;
            this.cmb_Company.SelectionChangeCommitted += new System.EventHandler(this.cmb_Company_SelectionChangeCommitted);
            // 
            // txt_Switch
            // 
            this.txt_Switch.Location = new System.Drawing.Point(396, 165);
            this.txt_Switch.MaxLength = 50;
            this.txt_Switch.Name = "txt_Switch";
            this.txt_Switch.Size = new System.Drawing.Size(100, 20);
            this.txt_Switch.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(342, 168);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 13);
            this.label17.TabIndex = 71;
            this.label17.Text = "Switch";
            // 
            // UpdAsset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 523);
            this.Controls.Add(this.txt_Switch);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_AssetID);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dg_Users);
            this.Controls.Add(this.txt_IP4);
            this.Controls.Add(this.txt_IP3);
            this.Controls.Add(this.txt_IP2);
            this.Controls.Add(this.cmb_Network);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_Location);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_Port);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_PhoneNum);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_OS);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_IP1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_MAC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Model);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Make);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_HandReceipt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_Type);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UpdAsset";
            this.Text = "UpdAsset";
            this.Load += new System.EventHandler(this.UpdAsset_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Users)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dg_Users;
        private System.Windows.Forms.TextBox txt_IP4;
        private System.Windows.Forms.TextBox txt_IP3;
        private System.Windows.Forms.TextBox txt_IP2;
        private System.Windows.Forms.ComboBox cmb_Network;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_Location;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_PhoneNum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_OS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_IP1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_MAC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Model;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Make;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_HandReceipt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_AssetID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_Rank;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_Company;
        private System.Windows.Forms.TextBox txt_Switch;
        private System.Windows.Forms.Label label17;
    }
}