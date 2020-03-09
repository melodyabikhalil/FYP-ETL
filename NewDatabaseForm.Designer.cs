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
            this.dbTypePanel = new System.Windows.Forms.Panel();
            this.backToSrcDest = new System.Windows.Forms.Button();
            this.dbTypesComboBox = new System.Windows.Forms.ComboBox();
            this.dbTypeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SrcDestNex = new System.Windows.Forms.Button();
            this.destRadioButton = new System.Windows.Forms.RadioButton();
            this.srcRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.mysqlPanel = new System.Windows.Forms.Panel();
            this.backToDbTypes = new System.Windows.Forms.Button();
            this.Connect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.MysqlHostTextBox = new System.Windows.Forms.TextBox();
            this.MysqlUsernameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MysqlPassTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MysqlDbNameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.srcDestPanel.SuspendLayout();
            this.dbTypePanel.SuspendLayout();
            this.mysqlPanel.SuspendLayout();
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Host";
            // 
            // MysqlHostTextBox
            // 
            this.MysqlHostTextBox.Location = new System.Drawing.Point(97, 33);
            this.MysqlHostTextBox.Name = "MysqlHostTextBox";
            this.MysqlHostTextBox.Size = new System.Drawing.Size(100, 20);
            this.MysqlHostTextBox.TabIndex = 5;
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
            // NewDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 395);
            this.Controls.Add(this.srcDestPanel);
            this.Name = "NewDatabaseForm";
            this.Text = "Add database";
            this.srcDestPanel.ResumeLayout(false);
            this.srcDestPanel.PerformLayout();
            this.dbTypePanel.ResumeLayout(false);
            this.dbTypePanel.PerformLayout();
            this.mysqlPanel.ResumeLayout(false);
            this.mysqlPanel.PerformLayout();
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
    }
}