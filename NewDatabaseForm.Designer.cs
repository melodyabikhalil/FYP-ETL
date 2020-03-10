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
            this.dbConnectPanel = new System.Windows.Forms.Panel();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.schemaTextBox = new System.Windows.Forms.TextBox();
            this.schemaLabel = new System.Windows.Forms.Label();
            this.dbNameTextBox = new System.Windows.Forms.TextBox();
            this.dbNameLabel = new System.Windows.Forms.Label();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.hostTextBox = new System.Windows.Forms.TextBox();
            this.hostLabel = new System.Windows.Forms.Label();
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
            this.srcDestPanel.SuspendLayout();
            this.dbConnectPanel.SuspendLayout();
            this.dbTypePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // srcDestPanel
            // 
            this.srcDestPanel.Controls.Add(this.dbConnectPanel);
            this.srcDestPanel.Controls.Add(this.dbTypePanel);
            this.srcDestPanel.Controls.Add(this.SrcDestNex);
            this.srcDestPanel.Controls.Add(this.destRadioButton);
            this.srcDestPanel.Controls.Add(this.srcRadioButton);
            this.srcDestPanel.Controls.Add(this.label1);
            this.srcDestPanel.Location = new System.Drawing.Point(1, -2);
            this.srcDestPanel.Margin = new System.Windows.Forms.Padding(4);
            this.srcDestPanel.Name = "srcDestPanel";
            this.srcDestPanel.Size = new System.Drawing.Size(764, 487);
            this.srcDestPanel.TabIndex = 0;
            // 
            // dbConnectPanel
            // 
            this.dbConnectPanel.Controls.Add(this.portTextBox);
            this.dbConnectPanel.Controls.Add(this.portLabel);
            this.dbConnectPanel.Controls.Add(this.schemaTextBox);
            this.dbConnectPanel.Controls.Add(this.schemaLabel);
            this.dbConnectPanel.Controls.Add(this.dbNameTextBox);
            this.dbConnectPanel.Controls.Add(this.dbNameLabel);
            this.dbConnectPanel.Controls.Add(this.passTextBox);
            this.dbConnectPanel.Controls.Add(this.passwordLabel);
            this.dbConnectPanel.Controls.Add(this.usernameTextBox);
            this.dbConnectPanel.Controls.Add(this.usernameLabel);
            this.dbConnectPanel.Controls.Add(this.hostTextBox);
            this.dbConnectPanel.Controls.Add(this.hostLabel);
            this.dbConnectPanel.Controls.Add(this.backToDbTypes);
            this.dbConnectPanel.Controls.Add(this.Connect);
            this.dbConnectPanel.Location = new System.Drawing.Point(4, 4);
            this.dbConnectPanel.Margin = new System.Windows.Forms.Padding(4);
            this.dbConnectPanel.Name = "dbConnectPanel";
            this.dbConnectPanel.Size = new System.Drawing.Size(787, 502);
            this.dbConnectPanel.TabIndex = 5;
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(190, 261);
            this.portTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(298, 22);
            this.portTextBox.TabIndex = 15;
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(75, 264);
            this.portLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(34, 17);
            this.portLabel.TabIndex = 14;
            this.portLabel.Text = "Port";
            // 
            // schemaTextBox
            // 
            this.schemaTextBox.Location = new System.Drawing.Point(190, 218);
            this.schemaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.schemaTextBox.Name = "schemaTextBox";
            this.schemaTextBox.Size = new System.Drawing.Size(298, 22);
            this.schemaTextBox.TabIndex = 13;
            // 
            // schemaLabel
            // 
            this.schemaLabel.AutoSize = true;
            this.schemaLabel.Location = new System.Drawing.Point(72, 221);
            this.schemaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.schemaLabel.Name = "schemaLabel";
            this.schemaLabel.Size = new System.Drawing.Size(59, 17);
            this.schemaLabel.TabIndex = 12;
            this.schemaLabel.Text = "Schema";
            // 
            // dbNameTextBox
            // 
            this.dbNameTextBox.Location = new System.Drawing.Point(190, 176);
            this.dbNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.dbNameTextBox.Name = "dbNameTextBox";
            this.dbNameTextBox.Size = new System.Drawing.Size(298, 22);
            this.dbNameTextBox.TabIndex = 11;
            // 
            // dbNameLabel
            // 
            this.dbNameLabel.AutoSize = true;
            this.dbNameLabel.Location = new System.Drawing.Point(72, 179);
            this.dbNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dbNameLabel.Name = "dbNameLabel";
            this.dbNameLabel.Size = new System.Drawing.Size(110, 17);
            this.dbNameLabel.TabIndex = 10;
            this.dbNameLabel.Text = "Database Name";
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(190, 136);
            this.passTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '*';
            this.passTextBox.Size = new System.Drawing.Size(298, 22);
            this.passTextBox.TabIndex = 9;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(72, 139);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(69, 17);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "Password";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(190, 93);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(298, 22);
            this.usernameTextBox.TabIndex = 7;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(72, 96);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(73, 17);
            this.usernameLabel.TabIndex = 6;
            this.usernameLabel.Text = "Username";
            // 
            // hostTextBox
            // 
            this.hostTextBox.Location = new System.Drawing.Point(190, 55);
            this.hostTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.hostTextBox.Name = "hostTextBox";
            this.hostTextBox.Size = new System.Drawing.Size(298, 22);
            this.hostTextBox.TabIndex = 5;
            // 
            // hostLabel
            // 
            this.hostLabel.AutoSize = true;
            this.hostLabel.Location = new System.Drawing.Point(72, 58);
            this.hostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hostLabel.Name = "hostLabel";
            this.hostLabel.Size = new System.Drawing.Size(37, 17);
            this.hostLabel.TabIndex = 4;
            this.hostLabel.Text = "Host";
            // 
            // backToDbTypes
            // 
            this.backToDbTypes.Location = new System.Drawing.Point(363, 347);
            this.backToDbTypes.Margin = new System.Windows.Forms.Padding(4);
            this.backToDbTypes.Name = "backToDbTypes";
            this.backToDbTypes.Size = new System.Drawing.Size(100, 28);
            this.backToDbTypes.TabIndex = 3;
            this.backToDbTypes.Text = "Back";
            this.backToDbTypes.UseVisualStyleBackColor = true;
            this.backToDbTypes.Click += new System.EventHandler(this.backToDbTypes_Click);
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(489, 347);
            this.Connect.Margin = new System.Windows.Forms.Padding(4);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(100, 28);
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
            this.dbTypePanel.Location = new System.Drawing.Point(12, 4);
            this.dbTypePanel.Margin = new System.Windows.Forms.Padding(4);
            this.dbTypePanel.Name = "dbTypePanel";
            this.dbTypePanel.Size = new System.Drawing.Size(586, 392);
            this.dbTypePanel.TabIndex = 4;
            // 
            // backToSrcDest
            // 
            this.backToSrcDest.Location = new System.Drawing.Point(301, 311);
            this.backToSrcDest.Margin = new System.Windows.Forms.Padding(4);
            this.backToSrcDest.Name = "backToSrcDest";
            this.backToSrcDest.Size = new System.Drawing.Size(100, 28);
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
            this.dbTypesComboBox.Location = new System.Drawing.Point(109, 131);
            this.dbTypesComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.dbTypesComboBox.Name = "dbTypesComboBox";
            this.dbTypesComboBox.Size = new System.Drawing.Size(160, 24);
            this.dbTypesComboBox.TabIndex = 2;
            // 
            // dbTypeButton
            // 
            this.dbTypeButton.Location = new System.Drawing.Point(427, 311);
            this.dbTypeButton.Margin = new System.Windows.Forms.Padding(4);
            this.dbTypeButton.Name = "dbTypeButton";
            this.dbTypeButton.Size = new System.Drawing.Size(100, 28);
            this.dbTypeButton.TabIndex = 1;
            this.dbTypeButton.Text = "Next";
            this.dbTypeButton.UseVisualStyleBackColor = true;
            this.dbTypeButton.Click += new System.EventHandler(this.dbTypeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Choose the database type:";
            // 
            // SrcDestNex
            // 
            this.SrcDestNex.Location = new System.Drawing.Point(444, 318);
            this.SrcDestNex.Margin = new System.Windows.Forms.Padding(4);
            this.SrcDestNex.Name = "SrcDestNex";
            this.SrcDestNex.Size = new System.Drawing.Size(100, 28);
            this.SrcDestNex.TabIndex = 3;
            this.SrcDestNex.Text = "Next";
            this.SrcDestNex.UseVisualStyleBackColor = true;
            this.SrcDestNex.Click += new System.EventHandler(this.SrcDestNex_Click);
            // 
            // destRadioButton
            // 
            this.destRadioButton.AutoSize = true;
            this.destRadioButton.Location = new System.Drawing.Point(119, 189);
            this.destRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.destRadioButton.Name = "destRadioButton";
            this.destRadioButton.Size = new System.Drawing.Size(100, 21);
            this.destRadioButton.TabIndex = 2;
            this.destRadioButton.TabStop = true;
            this.destRadioButton.Text = "Destination";
            this.destRadioButton.UseVisualStyleBackColor = true;
            // 
            // srcRadioButton
            // 
            this.srcRadioButton.AutoSize = true;
            this.srcRadioButton.Location = new System.Drawing.Point(119, 151);
            this.srcRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.srcRadioButton.Name = "srcRadioButton";
            this.srcRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.srcRadioButton.Size = new System.Drawing.Size(74, 21);
            this.srcRadioButton.TabIndex = 1;
            this.srcRadioButton.TabStop = true;
            this.srcRadioButton.Text = "Source";
            this.srcRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Do you want to add a source or a destination database?";
            // 
            // NewDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 429);
            this.Controls.Add(this.srcDestPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewDatabaseForm";
            this.Text = "Add database";
            this.srcDestPanel.ResumeLayout(false);
            this.srcDestPanel.PerformLayout();
            this.dbConnectPanel.ResumeLayout(false);
            this.dbConnectPanel.PerformLayout();
            this.dbTypePanel.ResumeLayout(false);
            this.dbTypePanel.PerformLayout();
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
        private System.Windows.Forms.Panel dbConnectPanel;
        private System.Windows.Forms.Button backToDbTypes;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.TextBox dbNameTextBox;
        private System.Windows.Forms.Label dbNameLabel;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox hostTextBox;
        private System.Windows.Forms.Label hostLabel;
        private System.Windows.Forms.TextBox schemaTextBox;
        private System.Windows.Forms.Label schemaLabel;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label portLabel;
    }
}