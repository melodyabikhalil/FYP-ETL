namespace FYP_ETL
{
    partial class NewDatabaseForm
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
            this.srcDestPanel = new System.Windows.Forms.Panel();
            this.mysqlPanel = new System.Windows.Forms.Panel();
            this.MysqlDbNameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MysqlPassTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MysqlUsernameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MysqlHostTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.backToDbTypes = new System.Windows.Forms.Button();
            this.Connect = new System.Windows.Forms.Button();
            this.dbTypePanel = new System.Windows.Forms.Panel();
            this.backToSrcDest = new System.Windows.Forms.Button();
            this.dbTypesComboBox = new System.Windows.Forms.ComboBox();
            this.dbTypeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SrcDestNex = new System.Windows.Forms.Button();
            this.destRadioButton = new System.Windows.Forms.RadioButton();
            this.srcRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.sqlServerPanel = new System.Windows.Forms.Panel();
            this.sqlServerSchemaTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.sqlServerDbNameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sqlServerPassTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sqlServerUsernameTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.sqlServerHostTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.backToDbType = new System.Windows.Forms.Button();
            this.sqlServerConnect = new System.Windows.Forms.Button();
            this.srcDestPanel.SuspendLayout();
            this.mysqlPanel.SuspendLayout();
            this.dbTypePanel.SuspendLayout();
            this.sqlServerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // srcDestPanel
            // 
            this.srcDestPanel.Controls.Add(this.mysqlPanel);
            this.srcDestPanel.Controls.Add(this.dbTypePanel);
            this.srcDestPanel.Controls.Add(this.SrcDestNex);
            this.srcDestPanel.Controls.Add(this.destRadioButton);
            this.srcDestPanel.Controls.Add(this.srcRadioButton);
            this.srcDestPanel.Controls.Add(this.label1);
            this.srcDestPanel.Location = new System.Drawing.Point(1, -2);
            this.srcDestPanel.Name = "srcDestPanel";
            this.srcDestPanel.Size = new System.Drawing.Size(573, 396);
            this.srcDestPanel.TabIndex = 0;
            // 
            // mysqlPanel
            // 
            this.mysqlPanel.Controls.Add(this.MysqlDbNameTextBox);
            this.mysqlPanel.Controls.Add(this.label6);
            this.mysqlPanel.Controls.Add(this.MysqlPassTextBox);
            this.mysqlPanel.Controls.Add(this.label5);
            this.mysqlPanel.Controls.Add(this.MysqlUsernameTextBox);
            this.mysqlPanel.Controls.Add(this.label4);
            this.mysqlPanel.Controls.Add(this.MysqlHostTextBox);
            this.mysqlPanel.Controls.Add(this.label3);
            this.mysqlPanel.Controls.Add(this.backToDbTypes);
            this.mysqlPanel.Controls.Add(this.Connect);
            this.mysqlPanel.Location = new System.Drawing.Point(0, 0);
            this.mysqlPanel.Name = "mysqlPanel";
            this.mysqlPanel.Size = new System.Drawing.Size(573, 393);
            this.mysqlPanel.TabIndex = 5;
            // 
            // MysqlDbNameTextBox
            // 
            this.MysqlDbNameTextBox.Location = new System.Drawing.Point(99, 183);
            this.MysqlDbNameTextBox.Name = "MysqlDbNameTextBox";
            this.MysqlDbNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.MysqlDbNameTextBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Database Name";
            // 
            // MysqlPassTextBox
            // 
            this.MysqlPassTextBox.Location = new System.Drawing.Point(97, 132);
            this.MysqlPassTextBox.Name = "MysqlPassTextBox";
            this.MysqlPassTextBox.PasswordChar = '*';
            this.MysqlPassTextBox.Size = new System.Drawing.Size(100, 20);
            this.MysqlPassTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password";
            // 
            // MysqlUsernameTextBox
            // 
            this.MysqlUsernameTextBox.Location = new System.Drawing.Point(97, 84);
            this.MysqlUsernameTextBox.Name = "MysqlUsernameTextBox";
            this.MysqlUsernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.MysqlUsernameTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Username";
            // 
            // MysqlHostTextBox
            // 
            this.MysqlHostTextBox.Location = new System.Drawing.Point(97, 33);
            this.MysqlHostTextBox.Name = "MysqlHostTextBox";
            this.MysqlHostTextBox.Size = new System.Drawing.Size(100, 20);
            this.MysqlHostTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Host";
            // 
            // backToDbTypes
            // 
            this.backToDbTypes.Location = new System.Drawing.Point(374, 347);
            this.backToDbTypes.Name = "backToDbTypes";
            this.backToDbTypes.Size = new System.Drawing.Size(75, 23);
            this.backToDbTypes.TabIndex = 3;
            this.backToDbTypes.Text = "Back";
            this.backToDbTypes.UseVisualStyleBackColor = true;
            this.backToDbTypes.Click += new System.EventHandler(this.backToDbTypes_Click);
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(469, 347);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(75, 23);
            this.Connect.TabIndex = 1;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // dbTypePanel
            // 
            this.dbTypePanel.Controls.Add(this.backToSrcDest);
            this.dbTypePanel.Controls.Add(this.dbTypesComboBox);
            this.dbTypePanel.Controls.Add(this.dbTypeButton);
            this.dbTypePanel.Controls.Add(this.label2);
            this.dbTypePanel.Location = new System.Drawing.Point(0, 3);
            this.dbTypePanel.Name = "dbTypePanel";
            this.dbTypePanel.Size = new System.Drawing.Size(573, 393);
            this.dbTypePanel.TabIndex = 4;
            // 
            // backToSrcDest
            // 
            this.backToSrcDest.Location = new System.Drawing.Point(374, 347);
            this.backToSrcDest.Name = "backToSrcDest";
            this.backToSrcDest.Size = new System.Drawing.Size(75, 23);
            this.backToSrcDest.TabIndex = 3;
            this.backToSrcDest.Text = "Back";
            this.backToSrcDest.UseVisualStyleBackColor = true;
            this.backToSrcDest.Click += new System.EventHandler(this.backToSrcDest_Click);
            // 
            // dbTypesComboBox
            // 
            this.dbTypesComboBox.FormattingEnabled = true;
            this.dbTypesComboBox.Items.AddRange(new object[] {
            "MySQL",
            "SQL Server",
            "PostgreSQL",
            "MS Access",
            "ODBC"});
            this.dbTypesComboBox.Location = new System.Drawing.Point(29, 59);
            this.dbTypesComboBox.Name = "dbTypesComboBox";
            this.dbTypesComboBox.Size = new System.Drawing.Size(121, 21);
            this.dbTypesComboBox.TabIndex = 2;
            // 
            // dbTypeButton
            // 
            this.dbTypeButton.Location = new System.Drawing.Point(469, 347);
            this.dbTypeButton.Name = "dbTypeButton";
            this.dbTypeButton.Size = new System.Drawing.Size(75, 23);
            this.dbTypeButton.TabIndex = 1;
            this.dbTypeButton.Text = "Next";
            this.dbTypeButton.UseVisualStyleBackColor = true;
            this.dbTypeButton.Click += new System.EventHandler(this.dbTypeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Choose the database type:";
            // 
            // SrcDestNex
            // 
            this.SrcDestNex.Location = new System.Drawing.Point(455, 341);
            this.SrcDestNex.Name = "SrcDestNex";
            this.SrcDestNex.Size = new System.Drawing.Size(75, 23);
            this.SrcDestNex.TabIndex = 3;
            this.SrcDestNex.Text = "Next";
            this.SrcDestNex.UseVisualStyleBackColor = true;
            this.SrcDestNex.Click += new System.EventHandler(this.SrcDestNex_Click);
            // 
            // destRadioButton
            // 
            this.destRadioButton.AutoSize = true;
            this.destRadioButton.Location = new System.Drawing.Point(49, 133);
            this.destRadioButton.Name = "destRadioButton";
            this.destRadioButton.Size = new System.Drawing.Size(79, 17);
            this.destRadioButton.TabIndex = 2;
            this.destRadioButton.TabStop = true;
            this.destRadioButton.Text = "Destination";
            this.destRadioButton.UseVisualStyleBackColor = true;
            // 
            // srcRadioButton
            // 
            this.srcRadioButton.AutoSize = true;
            this.srcRadioButton.Location = new System.Drawing.Point(49, 89);
            this.srcRadioButton.Name = "srcRadioButton";
            this.srcRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.srcRadioButton.Size = new System.Drawing.Size(58, 17);
            this.srcRadioButton.TabIndex = 1;
            this.srcRadioButton.TabStop = true;
            this.srcRadioButton.Text = "Source";
            this.srcRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Do you want to add a source or a destination database?";
            // 
            // sqlServerPanel
            // 
            this.sqlServerPanel.Controls.Add(this.sqlServerSchemaTextBox);
            this.sqlServerPanel.Controls.Add(this.label11);
            this.sqlServerPanel.Controls.Add(this.sqlServerDbNameTextBox);
            this.sqlServerPanel.Controls.Add(this.label7);
            this.sqlServerPanel.Controls.Add(this.sqlServerPassTextBox);
            this.sqlServerPanel.Controls.Add(this.label8);
            this.sqlServerPanel.Controls.Add(this.sqlServerUsernameTextBox);
            this.sqlServerPanel.Controls.Add(this.label9);
            this.sqlServerPanel.Controls.Add(this.sqlServerHostTextBox);
            this.sqlServerPanel.Controls.Add(this.label10);
            this.sqlServerPanel.Controls.Add(this.backToDbType);
            this.sqlServerPanel.Controls.Add(this.sqlServerConnect);
            this.sqlServerPanel.Location = new System.Drawing.Point(1, 1);
            this.sqlServerPanel.Name = "sqlServerPanel";
            this.sqlServerPanel.Size = new System.Drawing.Size(573, 393);
            this.sqlServerPanel.TabIndex = 12;
            // 
            // sqlServerSchemaTextBox
            // 
            this.sqlServerSchemaTextBox.Location = new System.Drawing.Point(99, 230);
            this.sqlServerSchemaTextBox.Name = "sqlServerSchemaTextBox";
            this.sqlServerSchemaTextBox.Size = new System.Drawing.Size(100, 20);
            this.sqlServerSchemaTextBox.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 233);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Schema";
            // 
            // sqlServerDbNameTextBox
            // 
            this.sqlServerDbNameTextBox.Location = new System.Drawing.Point(99, 183);
            this.sqlServerDbNameTextBox.Name = "sqlServerDbNameTextBox";
            this.sqlServerDbNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.sqlServerDbNameTextBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Database Name";
            // 
            // sqlServerPassTextBox
            // 
            this.sqlServerPassTextBox.Location = new System.Drawing.Point(97, 132);
            this.sqlServerPassTextBox.Name = "sqlServerPassTextBox";
            this.sqlServerPassTextBox.PasswordChar = '*';
            this.sqlServerPassTextBox.Size = new System.Drawing.Size(100, 20);
            this.sqlServerPassTextBox.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Password";
            // 
            // sqlServerUsernameTextBox
            // 
            this.sqlServerUsernameTextBox.Location = new System.Drawing.Point(97, 84);
            this.sqlServerUsernameTextBox.Name = "sqlServerUsernameTextBox";
            this.sqlServerUsernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.sqlServerUsernameTextBox.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Username";
            // 
            // sqlServerHostTextBox
            // 
            this.sqlServerHostTextBox.Location = new System.Drawing.Point(97, 33);
            this.sqlServerHostTextBox.Name = "sqlServerHostTextBox";
            this.sqlServerHostTextBox.Size = new System.Drawing.Size(100, 20);
            this.sqlServerHostTextBox.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Host";
            // 
            // backToDbType
            // 
            this.backToDbType.Location = new System.Drawing.Point(374, 347);
            this.backToDbType.Name = "backToDbType";
            this.backToDbType.Size = new System.Drawing.Size(75, 23);
            this.backToDbType.TabIndex = 3;
            this.backToDbType.Text = "Back";
            this.backToDbType.UseVisualStyleBackColor = true;
            this.backToDbType.Click += new System.EventHandler(this.backToDbType_Click);
            // 
            // sqlServerConnect
            // 
            this.sqlServerConnect.Location = new System.Drawing.Point(469, 347);
            this.sqlServerConnect.Name = "sqlServerConnect";
            this.sqlServerConnect.Size = new System.Drawing.Size(75, 23);
            this.sqlServerConnect.TabIndex = 1;
            this.sqlServerConnect.Text = "Connect";
            this.sqlServerConnect.UseVisualStyleBackColor = true;
            this.sqlServerConnect.Click += new System.EventHandler(this.sqlServerConnect_Click);
            // 
            // NewDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 395);
            this.Controls.Add(this.sqlServerPanel);
            this.Controls.Add(this.srcDestPanel);
            this.Name = "NewDatabaseForm";
            this.Text = "Add database";
            this.srcDestPanel.ResumeLayout(false);
            this.srcDestPanel.PerformLayout();
            this.mysqlPanel.ResumeLayout(false);
            this.mysqlPanel.PerformLayout();
            this.dbTypePanel.ResumeLayout(false);
            this.dbTypePanel.PerformLayout();
            this.sqlServerPanel.ResumeLayout(false);
            this.sqlServerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel srcDestPanel;
        private System.Windows.Forms.RadioButton destRadioButton;
        private System.Windows.Forms.RadioButton srcRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SrcDestNex;
        private System.Windows.Forms.Panel dbTypePanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backToSrcDest;
        private System.Windows.Forms.ComboBox dbTypesComboBox;
        private System.Windows.Forms.Button dbTypeButton;
        private System.Windows.Forms.Panel mysqlPanel;
        private System.Windows.Forms.Button backToDbTypes;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.TextBox MysqlDbNameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MysqlPassTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MysqlUsernameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MysqlHostTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel sqlServerPanel;
        private System.Windows.Forms.TextBox sqlServerSchemaTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox sqlServerDbNameTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox sqlServerPassTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox sqlServerUsernameTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox sqlServerHostTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button backToDbType;
        private System.Windows.Forms.Button sqlServerConnect;
    }
}