namespace S6_Inventory
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.cmb_Options = new System.Windows.Forms.ComboBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dtg_Users = new System.Windows.Forms.DataGridView();
            this.dtg_Assets = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_AddAsset = new System.Windows.Forms.Button();
            this.btn_UpdAsset = new System.Windows.Forms.Button();
            this.btn_DelAsset = new System.Windows.Forms.Button();
            this.btn_DelUser = new System.Windows.Forms.Button();
            this.btn_UpdUser = new System.Windows.Forms.Button();
            this.btn_AddUser = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Assets)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(464, 12);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(353, 20);
            this.txt_Search.TabIndex = 0;
            // 
            // cmb_Options
            // 
            this.cmb_Options.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmb_Options.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Options.FormattingEnabled = true;
            this.cmb_Options.Location = new System.Drawing.Point(823, 12);
            this.cmb_Options.Name = "cmb_Options";
            this.cmb_Options.Size = new System.Drawing.Size(121, 21);
            this.cmb_Options.TabIndex = 1;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(950, 10);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dtg_Users
            // 
            this.dtg_Users.AllowUserToAddRows = false;
            this.dtg_Users.AllowUserToDeleteRows = false;
            this.dtg_Users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Users.Location = new System.Drawing.Point(12, 79);
            this.dtg_Users.MultiSelect = false;
            this.dtg_Users.Name = "dtg_Users";
            this.dtg_Users.ReadOnly = true;
            this.dtg_Users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_Users.Size = new System.Drawing.Size(1550, 133);
            this.dtg_Users.TabIndex = 3;
            this.dtg_Users.SelectionChanged += new System.EventHandler(this.dtg_Users_SelectionChanged);
            this.dtg_Users.DoubleClick += new System.EventHandler(this.dtg_Users_DoubleClick);
            // 
            // dtg_Assets
            // 
            this.dtg_Assets.AllowUserToAddRows = false;
            this.dtg_Assets.AllowUserToDeleteRows = false;
            this.dtg_Assets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Assets.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_Assets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Assets.Location = new System.Drawing.Point(12, 261);
            this.dtg_Assets.MultiSelect = false;
            this.dtg_Assets.Name = "dtg_Assets";
            this.dtg_Assets.ReadOnly = true;
            this.dtg_Assets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_Assets.Size = new System.Drawing.Size(1550, 571);
            this.dtg_Assets.TabIndex = 4;
            this.dtg_Assets.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtg_Assets_ColumnHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Asset";
            // 
            // btn_AddAsset
            // 
            this.btn_AddAsset.Location = new System.Drawing.Point(1370, 218);
            this.btn_AddAsset.Name = "btn_AddAsset";
            this.btn_AddAsset.Size = new System.Drawing.Size(60, 23);
            this.btn_AddAsset.TabIndex = 7;
            this.btn_AddAsset.Text = "Add";
            this.btn_AddAsset.UseVisualStyleBackColor = true;
            this.btn_AddAsset.Click += new System.EventHandler(this.btn_AddAsset_Click);
            // 
            // btn_UpdAsset
            // 
            this.btn_UpdAsset.Location = new System.Drawing.Point(1436, 218);
            this.btn_UpdAsset.Name = "btn_UpdAsset";
            this.btn_UpdAsset.Size = new System.Drawing.Size(60, 23);
            this.btn_UpdAsset.TabIndex = 8;
            this.btn_UpdAsset.Text = "Edit";
            this.btn_UpdAsset.UseVisualStyleBackColor = true;
            this.btn_UpdAsset.Click += new System.EventHandler(this.btn_UpdAsset_Click);
            // 
            // btn_DelAsset
            // 
            this.btn_DelAsset.Location = new System.Drawing.Point(1502, 218);
            this.btn_DelAsset.Name = "btn_DelAsset";
            this.btn_DelAsset.Size = new System.Drawing.Size(60, 23);
            this.btn_DelAsset.TabIndex = 9;
            this.btn_DelAsset.Text = "Delete";
            this.btn_DelAsset.UseVisualStyleBackColor = true;
            this.btn_DelAsset.Click += new System.EventHandler(this.btn_DelAsset_Click);
            // 
            // btn_DelUser
            // 
            this.btn_DelUser.Location = new System.Drawing.Point(1502, 50);
            this.btn_DelUser.Name = "btn_DelUser";
            this.btn_DelUser.Size = new System.Drawing.Size(60, 23);
            this.btn_DelUser.TabIndex = 12;
            this.btn_DelUser.Text = "Delete";
            this.btn_DelUser.UseVisualStyleBackColor = true;
            this.btn_DelUser.Click += new System.EventHandler(this.btn_DelUser_Click);
            // 
            // btn_UpdUser
            // 
            this.btn_UpdUser.Location = new System.Drawing.Point(1436, 50);
            this.btn_UpdUser.Name = "btn_UpdUser";
            this.btn_UpdUser.Size = new System.Drawing.Size(60, 23);
            this.btn_UpdUser.TabIndex = 11;
            this.btn_UpdUser.Text = "Edit";
            this.btn_UpdUser.UseVisualStyleBackColor = true;
            this.btn_UpdUser.Click += new System.EventHandler(this.btn_UpdUser_Click);
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.Location = new System.Drawing.Point(1370, 50);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(60, 23);
            this.btn_AddUser.TabIndex = 10;
            this.btn_AddUser.Text = "Add";
            this.btn_AddUser.UseVisualStyleBackColor = true;
            this.btn_AddUser.Click += new System.EventHandler(this.btn_AddUser_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(1476, 850);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(86, 23);
            this.btn_Print.TabIndex = 14;
            this.btn_Print.Text = "Print To File";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 885);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_DelUser);
            this.Controls.Add(this.btn_UpdUser);
            this.Controls.Add(this.btn_AddUser);
            this.Controls.Add(this.btn_DelAsset);
            this.Controls.Add(this.btn_UpdAsset);
            this.Controls.Add(this.btn_AddAsset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtg_Assets);
            this.Controls.Add(this.dtg_Users);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.cmb_Options);
            this.Controls.Add(this.txt_Search);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Assets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.ComboBox cmb_Options;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView dtg_Users;
        private System.Windows.Forms.DataGridView dtg_Assets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_AddAsset;
        private System.Windows.Forms.Button btn_UpdAsset;
        private System.Windows.Forms.Button btn_DelAsset;
        private System.Windows.Forms.Button btn_DelUser;
        private System.Windows.Forms.Button btn_UpdUser;
        private System.Windows.Forms.Button btn_AddUser;
        private System.Windows.Forms.Button btn_Print;
    }
}

