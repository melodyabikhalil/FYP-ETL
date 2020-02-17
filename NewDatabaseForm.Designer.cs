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
            this.DatabaseTab = new System.Windows.Forms.TabControl();
            this.MysqlTabPage = new System.Windows.Forms.TabPage();
            this.mysqlHostTextbox = new System.Windows.Forms.TextBox();
            this.mysqlUsernameTextbox = new System.Windows.Forms.TextBox();
            this.mysqlPasswordTextbox = new System.Windows.Forms.TextBox();
            this.mysqlDatabaseNameTextbox = new System.Windows.Forms.TextBox();
            this.mysqlDatabaseNameLabel = new System.Windows.Forms.Label();
            this.mysqlPasswordLabel = new System.Windows.Forms.Label();
            this.mysqlUsernameLabel = new System.Windows.Forms.Label();
            this.mysqlHostLabel = new System.Windows.Forms.Label();
            this.postgresTabPage = new System.Windows.Forms.TabPage();
            this.postgresPortTextbox = new System.Windows.Forms.TextBox();
            this.postgresSchemaTextbox = new System.Windows.Forms.TextBox();
            this.postgresSchemaLabel = new System.Windows.Forms.Label();
            this.postgresPortLabel = new System.Windows.Forms.Label();
            this.postgresHostTextbox = new System.Windows.Forms.TextBox();
            this.postgresUsernameTextbox = new System.Windows.Forms.TextBox();
            this.postgresPasswordTextbox = new System.Windows.Forms.TextBox();
            this.postgresDatabaseNameTextbox = new System.Windows.Forms.TextBox();
            this.databaseNameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sqlServerTabPage = new System.Windows.Forms.TabPage();
            this.sqlserverSchemaTextbox = new System.Windows.Forms.TextBox();
            this.sqlserverSchemaLabel = new System.Windows.Forms.Label();
            this.sqlserverHostTextbox = new System.Windows.Forms.TextBox();
            this.sqlserverUsernameTextbox = new System.Windows.Forms.TextBox();
            this.sqlserverPasswordTextbox = new System.Windows.Forms.TextBox();
            this.sqlserverDatabaseNameTextbox = new System.Windows.Forms.TextBox();
            this.sqlserverDatabaseNameLabel = new System.Windows.Forms.Label();
            this.sqlserverPasswordLabel = new System.Windows.Forms.Label();
            this.sqlserverUsernameLabel = new System.Windows.Forms.Label();
            this.sqlserverHostLabel = new System.Windows.Forms.Label();
            this.accessTabPage = new System.Windows.Forms.TabPage();
            this.accessPathTextbox = new System.Windows.Forms.TextBox();
            this.accessPathLabel = new System.Windows.Forms.Label();
            this.odbcTabPage = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.sourceRadioButton = new System.Windows.Forms.RadioButton();
            this.destinationRadioButton = new System.Windows.Forms.RadioButton();
            this.sourceDestinationGroupbox = new System.Windows.Forms.GroupBox();
            this.DatabaseTab.SuspendLayout();
            this.MysqlTabPage.SuspendLayout();
            this.postgresTabPage.SuspendLayout();
            this.sqlServerTabPage.SuspendLayout();
            this.accessTabPage.SuspendLayout();
            this.odbcTabPage.SuspendLayout();
            this.sourceDestinationGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DatabaseTab
            // 
            this.DatabaseTab.Controls.Add(this.MysqlTabPage);
            this.DatabaseTab.Controls.Add(this.postgresTabPage);
            this.DatabaseTab.Controls.Add(this.sqlServerTabPage);
            this.DatabaseTab.Controls.Add(this.accessTabPage);
            this.DatabaseTab.Controls.Add(this.odbcTabPage);
            this.DatabaseTab.Location = new System.Drawing.Point(2, 1);
            this.DatabaseTab.Name = "DatabaseTab";
            this.DatabaseTab.SelectedIndex = 0;
            this.DatabaseTab.Size = new System.Drawing.Size(576, 332);
            this.DatabaseTab.TabIndex = 9;
            // 
            // MysqlTabPage
            // 
            this.MysqlTabPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MysqlTabPage.Controls.Add(this.mysqlHostTextbox);
            this.MysqlTabPage.Controls.Add(this.mysqlUsernameTextbox);
            this.MysqlTabPage.Controls.Add(this.mysqlPasswordTextbox);
            this.MysqlTabPage.Controls.Add(this.mysqlDatabaseNameTextbox);
            this.MysqlTabPage.Controls.Add(this.mysqlDatabaseNameLabel);
            this.MysqlTabPage.Controls.Add(this.mysqlPasswordLabel);
            this.MysqlTabPage.Controls.Add(this.mysqlUsernameLabel);
            this.MysqlTabPage.Controls.Add(this.mysqlHostLabel);
            this.MysqlTabPage.Location = new System.Drawing.Point(4, 22);
            this.MysqlTabPage.Name = "MysqlTabPage";
            this.MysqlTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MysqlTabPage.Size = new System.Drawing.Size(568, 306);
            this.MysqlTabPage.TabIndex = 0;
            this.MysqlTabPage.Text = "MySQL";
            // 
            // mysqlHostTextbox
            // 
            this.mysqlHostTextbox.Location = new System.Drawing.Point(176, 34);
            this.mysqlHostTextbox.Name = "mysqlHostTextbox";
            this.mysqlHostTextbox.Size = new System.Drawing.Size(309, 20);
            this.mysqlHostTextbox.TabIndex = 1;
            this.mysqlHostTextbox.Text = " ";
            // 
            // mysqlUsernameTextbox
            // 
            this.mysqlUsernameTextbox.Location = new System.Drawing.Point(176, 74);
            this.mysqlUsernameTextbox.Name = "mysqlUsernameTextbox";
            this.mysqlUsernameTextbox.Size = new System.Drawing.Size(309, 20);
            this.mysqlUsernameTextbox.TabIndex = 2;
            // 
            // mysqlPasswordTextbox
            // 
            this.mysqlPasswordTextbox.Location = new System.Drawing.Point(176, 116);
            this.mysqlPasswordTextbox.Name = "mysqlPasswordTextbox";
            this.mysqlPasswordTextbox.PasswordChar = '*';
            this.mysqlPasswordTextbox.Size = new System.Drawing.Size(309, 20);
            this.mysqlPasswordTextbox.TabIndex = 3;
            // 
            // mysqlDatabaseNameTextbox
            // 
            this.mysqlDatabaseNameTextbox.Location = new System.Drawing.Point(176, 159);
            this.mysqlDatabaseNameTextbox.Name = "mysqlDatabaseNameTextbox";
            this.mysqlDatabaseNameTextbox.Size = new System.Drawing.Size(309, 20);
            this.mysqlDatabaseNameTextbox.TabIndex = 4;
            // 
            // mysqlDatabaseNameLabel
            // 
            this.mysqlDatabaseNameLabel.AutoSize = true;
            this.mysqlDatabaseNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mysqlDatabaseNameLabel.Location = new System.Drawing.Point(52, 164);
            this.mysqlDatabaseNameLabel.Name = "mysqlDatabaseNameLabel";
            this.mysqlDatabaseNameLabel.Size = new System.Drawing.Size(95, 15);
            this.mysqlDatabaseNameLabel.TabIndex = 12;
            this.mysqlDatabaseNameLabel.Text = "Database name";
            // 
            // mysqlPasswordLabel
            // 
            this.mysqlPasswordLabel.AutoSize = true;
            this.mysqlPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mysqlPasswordLabel.Location = new System.Drawing.Point(52, 121);
            this.mysqlPasswordLabel.Name = "mysqlPasswordLabel";
            this.mysqlPasswordLabel.Size = new System.Drawing.Size(61, 15);
            this.mysqlPasswordLabel.TabIndex = 11;
            this.mysqlPasswordLabel.Text = "Password";
            // 
            // mysqlUsernameLabel
            // 
            this.mysqlUsernameLabel.AutoSize = true;
            this.mysqlUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mysqlUsernameLabel.Location = new System.Drawing.Point(52, 79);
            this.mysqlUsernameLabel.Name = "mysqlUsernameLabel";
            this.mysqlUsernameLabel.Size = new System.Drawing.Size(65, 15);
            this.mysqlUsernameLabel.TabIndex = 10;
            this.mysqlUsernameLabel.Text = "Username";
            // 
            // mysqlHostLabel
            // 
            this.mysqlHostLabel.AutoSize = true;
            this.mysqlHostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mysqlHostLabel.Location = new System.Drawing.Point(52, 39);
            this.mysqlHostLabel.Name = "mysqlHostLabel";
            this.mysqlHostLabel.Size = new System.Drawing.Size(32, 15);
            this.mysqlHostLabel.TabIndex = 0;
            this.mysqlHostLabel.Text = "Host";
            // 
            // postgresTabPage
            // 
            this.postgresTabPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.postgresTabPage.Controls.Add(this.postgresPortTextbox);
            this.postgresTabPage.Controls.Add(this.postgresSchemaTextbox);
            this.postgresTabPage.Controls.Add(this.postgresSchemaLabel);
            this.postgresTabPage.Controls.Add(this.postgresPortLabel);
            this.postgresTabPage.Controls.Add(this.postgresHostTextbox);
            this.postgresTabPage.Controls.Add(this.postgresUsernameTextbox);
            this.postgresTabPage.Controls.Add(this.postgresPasswordTextbox);
            this.postgresTabPage.Controls.Add(this.postgresDatabaseNameTextbox);
            this.postgresTabPage.Controls.Add(this.databaseNameLabel);
            this.postgresTabPage.Controls.Add(this.passwordLabel);
            this.postgresTabPage.Controls.Add(this.usernameLabel);
            this.postgresTabPage.Controls.Add(this.label1);
            this.postgresTabPage.Location = new System.Drawing.Point(4, 22);
            this.postgresTabPage.Name = "postgresTabPage";
            this.postgresTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.postgresTabPage.Size = new System.Drawing.Size(568, 306);
            this.postgresTabPage.TabIndex = 1;
            this.postgresTabPage.Text = "PostgreSQL";
            // 
            // postgresPortTextbox
            // 
            this.postgresPortTextbox.Location = new System.Drawing.Point(179, 204);
            this.postgresPortTextbox.Name = "postgresPortTextbox";
            this.postgresPortTextbox.Size = new System.Drawing.Size(309, 20);
            this.postgresPortTextbox.TabIndex = 5;
            // 
            // postgresSchemaTextbox
            // 
            this.postgresSchemaTextbox.Location = new System.Drawing.Point(179, 247);
            this.postgresSchemaTextbox.Name = "postgresSchemaTextbox";
            this.postgresSchemaTextbox.Size = new System.Drawing.Size(309, 20);
            this.postgresSchemaTextbox.TabIndex = 6;
            // 
            // postgresSchemaLabel
            // 
            this.postgresSchemaLabel.AutoSize = true;
            this.postgresSchemaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postgresSchemaLabel.Location = new System.Drawing.Point(55, 252);
            this.postgresSchemaLabel.Name = "postgresSchemaLabel";
            this.postgresSchemaLabel.Size = new System.Drawing.Size(53, 15);
            this.postgresSchemaLabel.TabIndex = 27;
            this.postgresSchemaLabel.Text = "Schema";
            // 
            // postgresPortLabel
            // 
            this.postgresPortLabel.AutoSize = true;
            this.postgresPortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postgresPortLabel.Location = new System.Drawing.Point(55, 209);
            this.postgresPortLabel.Name = "postgresPortLabel";
            this.postgresPortLabel.Size = new System.Drawing.Size(29, 15);
            this.postgresPortLabel.TabIndex = 26;
            this.postgresPortLabel.Text = "Port";
            // 
            // postgresHostTextbox
            // 
            this.postgresHostTextbox.Location = new System.Drawing.Point(179, 37);
            this.postgresHostTextbox.Name = "postgresHostTextbox";
            this.postgresHostTextbox.Size = new System.Drawing.Size(309, 20);
            this.postgresHostTextbox.TabIndex = 1;
            // 
            // postgresUsernameTextbox
            // 
            this.postgresUsernameTextbox.Location = new System.Drawing.Point(179, 77);
            this.postgresUsernameTextbox.Name = "postgresUsernameTextbox";
            this.postgresUsernameTextbox.Size = new System.Drawing.Size(309, 20);
            this.postgresUsernameTextbox.TabIndex = 2;
            // 
            // postgresPasswordTextbox
            // 
            this.postgresPasswordTextbox.Location = new System.Drawing.Point(179, 119);
            this.postgresPasswordTextbox.Name = "postgresPasswordTextbox";
            this.postgresPasswordTextbox.PasswordChar = '*';
            this.postgresPasswordTextbox.Size = new System.Drawing.Size(309, 20);
            this.postgresPasswordTextbox.TabIndex = 3;
            // 
            // postgresDatabaseNameTextbox
            // 
            this.postgresDatabaseNameTextbox.Location = new System.Drawing.Point(179, 162);
            this.postgresDatabaseNameTextbox.Name = "postgresDatabaseNameTextbox";
            this.postgresDatabaseNameTextbox.Size = new System.Drawing.Size(309, 20);
            this.postgresDatabaseNameTextbox.TabIndex = 4;
            // 
            // databaseNameLabel
            // 
            this.databaseNameLabel.AutoSize = true;
            this.databaseNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databaseNameLabel.Location = new System.Drawing.Point(55, 167);
            this.databaseNameLabel.Name = "databaseNameLabel";
            this.databaseNameLabel.Size = new System.Drawing.Size(95, 15);
            this.databaseNameLabel.TabIndex = 21;
            this.databaseNameLabel.Text = "Database name";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(55, 124);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(61, 15);
            this.passwordLabel.TabIndex = 20;
            this.passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(55, 82);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(65, 15);
            this.usernameLabel.TabIndex = 19;
            this.usernameLabel.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Host";
            // 
            // sqlServerTabPage
            // 
            this.sqlServerTabPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sqlServerTabPage.Controls.Add(this.sqlserverSchemaTextbox);
            this.sqlServerTabPage.Controls.Add(this.sqlserverSchemaLabel);
            this.sqlServerTabPage.Controls.Add(this.sqlserverHostTextbox);
            this.sqlServerTabPage.Controls.Add(this.sqlserverUsernameTextbox);
            this.sqlServerTabPage.Controls.Add(this.sqlserverPasswordTextbox);
            this.sqlServerTabPage.Controls.Add(this.sqlserverDatabaseNameTextbox);
            this.sqlServerTabPage.Controls.Add(this.sqlserverDatabaseNameLabel);
            this.sqlServerTabPage.Controls.Add(this.sqlserverPasswordLabel);
            this.sqlServerTabPage.Controls.Add(this.sqlserverUsernameLabel);
            this.sqlServerTabPage.Controls.Add(this.sqlserverHostLabel);
            this.sqlServerTabPage.Location = new System.Drawing.Point(4, 22);
            this.sqlServerTabPage.Name = "sqlServerTabPage";
            this.sqlServerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.sqlServerTabPage.Size = new System.Drawing.Size(568, 306);
            this.sqlServerTabPage.TabIndex = 2;
            this.sqlServerTabPage.Text = "SQL Server";
            // 
            // sqlserverSchemaTextbox
            // 
            this.sqlserverSchemaTextbox.Location = new System.Drawing.Point(192, 208);
            this.sqlserverSchemaTextbox.Name = "sqlserverSchemaTextbox";
            this.sqlserverSchemaTextbox.Size = new System.Drawing.Size(309, 20);
            this.sqlserverSchemaTextbox.TabIndex = 5;
            // 
            // sqlserverSchemaLabel
            // 
            this.sqlserverSchemaLabel.AutoSize = true;
            this.sqlserverSchemaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlserverSchemaLabel.Location = new System.Drawing.Point(68, 213);
            this.sqlserverSchemaLabel.Name = "sqlserverSchemaLabel";
            this.sqlserverSchemaLabel.Size = new System.Drawing.Size(53, 15);
            this.sqlserverSchemaLabel.TabIndex = 39;
            this.sqlserverSchemaLabel.Text = "Schema";
            // 
            // sqlserverHostTextbox
            // 
            this.sqlserverHostTextbox.Location = new System.Drawing.Point(192, 41);
            this.sqlserverHostTextbox.Name = "sqlserverHostTextbox";
            this.sqlserverHostTextbox.Size = new System.Drawing.Size(309, 20);
            this.sqlserverHostTextbox.TabIndex = 1;
            // 
            // sqlserverUsernameTextbox
            // 
            this.sqlserverUsernameTextbox.Location = new System.Drawing.Point(192, 81);
            this.sqlserverUsernameTextbox.Name = "sqlserverUsernameTextbox";
            this.sqlserverUsernameTextbox.Size = new System.Drawing.Size(309, 20);
            this.sqlserverUsernameTextbox.TabIndex = 2;
            // 
            // sqlserverPasswordTextbox
            // 
            this.sqlserverPasswordTextbox.Location = new System.Drawing.Point(192, 123);
            this.sqlserverPasswordTextbox.Name = "sqlserverPasswordTextbox";
            this.sqlserverPasswordTextbox.PasswordChar = '*';
            this.sqlserverPasswordTextbox.Size = new System.Drawing.Size(309, 20);
            this.sqlserverPasswordTextbox.TabIndex = 3;
            // 
            // sqlserverDatabaseNameTextbox
            // 
            this.sqlserverDatabaseNameTextbox.Location = new System.Drawing.Point(192, 166);
            this.sqlserverDatabaseNameTextbox.Name = "sqlserverDatabaseNameTextbox";
            this.sqlserverDatabaseNameTextbox.Size = new System.Drawing.Size(309, 20);
            this.sqlserverDatabaseNameTextbox.TabIndex = 4;
            // 
            // sqlserverDatabaseNameLabel
            // 
            this.sqlserverDatabaseNameLabel.AutoSize = true;
            this.sqlserverDatabaseNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlserverDatabaseNameLabel.Location = new System.Drawing.Point(68, 171);
            this.sqlserverDatabaseNameLabel.Name = "sqlserverDatabaseNameLabel";
            this.sqlserverDatabaseNameLabel.Size = new System.Drawing.Size(95, 15);
            this.sqlserverDatabaseNameLabel.TabIndex = 34;
            this.sqlserverDatabaseNameLabel.Text = "Database name";
            // 
            // sqlserverPasswordLabel
            // 
            this.sqlserverPasswordLabel.AutoSize = true;
            this.sqlserverPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlserverPasswordLabel.Location = new System.Drawing.Point(68, 128);
            this.sqlserverPasswordLabel.Name = "sqlserverPasswordLabel";
            this.sqlserverPasswordLabel.Size = new System.Drawing.Size(61, 15);
            this.sqlserverPasswordLabel.TabIndex = 33;
            this.sqlserverPasswordLabel.Text = "Password";
            // 
            // sqlserverUsernameLabel
            // 
            this.sqlserverUsernameLabel.AutoSize = true;
            this.sqlserverUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlserverUsernameLabel.Location = new System.Drawing.Point(68, 86);
            this.sqlserverUsernameLabel.Name = "sqlserverUsernameLabel";
            this.sqlserverUsernameLabel.Size = new System.Drawing.Size(65, 15);
            this.sqlserverUsernameLabel.TabIndex = 32;
            this.sqlserverUsernameLabel.Text = "Username";
            // 
            // sqlserverHostLabel
            // 
            this.sqlserverHostLabel.AutoSize = true;
            this.sqlserverHostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlserverHostLabel.Location = new System.Drawing.Point(68, 46);
            this.sqlserverHostLabel.Name = "sqlserverHostLabel";
            this.sqlserverHostLabel.Size = new System.Drawing.Size(32, 15);
            this.sqlserverHostLabel.TabIndex = 31;
            this.sqlserverHostLabel.Text = "Host";
            // 
            // accessTabPage
            // 
            this.accessTabPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.accessTabPage.Controls.Add(this.accessPathTextbox);
            this.accessTabPage.Controls.Add(this.accessPathLabel);
            this.accessTabPage.Location = new System.Drawing.Point(4, 22);
            this.accessTabPage.Name = "accessTabPage";
            this.accessTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.accessTabPage.Size = new System.Drawing.Size(568, 306);
            this.accessTabPage.TabIndex = 3;
            this.accessTabPage.Text = "MS Access";
            // 
            // accessPathTextbox
            // 
            this.accessPathTextbox.Location = new System.Drawing.Point(192, 123);
            this.accessPathTextbox.Name = "accessPathTextbox";
            this.accessPathTextbox.Size = new System.Drawing.Size(309, 20);
            this.accessPathTextbox.TabIndex = 1;
            // 
            // accessPathLabel
            // 
            this.accessPathLabel.AutoSize = true;
            this.accessPathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accessPathLabel.Location = new System.Drawing.Point(68, 128);
            this.accessPathLabel.Name = "accessPathLabel";
            this.accessPathLabel.Size = new System.Drawing.Size(32, 15);
            this.accessPathLabel.TabIndex = 46;
            this.accessPathLabel.Text = "Path";
            // 
            // odbcTabPage
            // 
            this.odbcTabPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.odbcTabPage.Controls.Add(this.textBox1);
            this.odbcTabPage.Controls.Add(this.label2);
            this.odbcTabPage.Controls.Add(this.textBox2);
            this.odbcTabPage.Controls.Add(this.textBox3);
            this.odbcTabPage.Controls.Add(this.textBox4);
            this.odbcTabPage.Controls.Add(this.textBox5);
            this.odbcTabPage.Controls.Add(this.label3);
            this.odbcTabPage.Controls.Add(this.label4);
            this.odbcTabPage.Controls.Add(this.label5);
            this.odbcTabPage.Controls.Add(this.label6);
            this.odbcTabPage.Location = new System.Drawing.Point(4, 22);
            this.odbcTabPage.Name = "odbcTabPage";
            this.odbcTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.odbcTabPage.Size = new System.Drawing.Size(568, 306);
            this.odbcTabPage.TabIndex = 4;
            this.odbcTabPage.Text = "ODBC";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(192, 208);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(309, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 52;
            this.label2.Text = "Schema";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(192, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(309, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(192, 81);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(309, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(192, 123);
            this.textBox4.Name = "textBox4";
            this.textBox4.PasswordChar = '*';
            this.textBox4.Size = new System.Drawing.Size(309, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(192, 166);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(309, 20);
            this.textBox5.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 47;
            this.label3.Text = "Database name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 46;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 45;
            this.label5.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 44;
            this.label6.Text = "Host";
            // 
            // connectButton
            // 
            this.connectButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.connectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectButton.Location = new System.Drawing.Point(401, 356);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(93, 27);
            this.connectButton.TabIndex = 10;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // sourceRadioButton
            // 
            this.sourceRadioButton.AutoSize = true;
            this.sourceRadioButton.Checked = true;
            this.sourceRadioButton.Location = new System.Drawing.Point(20, 21);
            this.sourceRadioButton.Name = "sourceRadioButton";
            this.sourceRadioButton.Size = new System.Drawing.Size(59, 17);
            this.sourceRadioButton.TabIndex = 11;
            this.sourceRadioButton.TabStop = true;
            this.sourceRadioButton.Text = "Source";
            this.sourceRadioButton.UseVisualStyleBackColor = true;
            // 
            // destinationRadioButton
            // 
            this.destinationRadioButton.AutoSize = true;
            this.destinationRadioButton.Location = new System.Drawing.Point(100, 21);
            this.destinationRadioButton.Name = "destinationRadioButton";
            this.destinationRadioButton.Size = new System.Drawing.Size(78, 17);
            this.destinationRadioButton.TabIndex = 12;
            this.destinationRadioButton.Text = "Destination";
            this.destinationRadioButton.UseVisualStyleBackColor = true;
            // 
            // sourceDestinationGroupbox
            // 
            this.sourceDestinationGroupbox.Controls.Add(this.destinationRadioButton);
            this.sourceDestinationGroupbox.Controls.Add(this.sourceRadioButton);
            this.sourceDestinationGroupbox.Location = new System.Drawing.Point(173, 339);
            this.sourceDestinationGroupbox.Name = "sourceDestinationGroupbox";
            this.sourceDestinationGroupbox.Size = new System.Drawing.Size(199, 48);
            this.sourceDestinationGroupbox.TabIndex = 13;
            this.sourceDestinationGroupbox.TabStop = false;
            // 
            // NewDatabaseForm
            // 
            this.AcceptButton = this.connectButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 395);
            this.Controls.Add(this.sourceDestinationGroupbox);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.DatabaseTab);
            this.Name = "NewDatabaseForm";
            this.Text = "Add database";
            this.DatabaseTab.ResumeLayout(false);
            this.MysqlTabPage.ResumeLayout(false);
            this.MysqlTabPage.PerformLayout();
            this.postgresTabPage.ResumeLayout(false);
            this.postgresTabPage.PerformLayout();
            this.sqlServerTabPage.ResumeLayout(false);
            this.sqlServerTabPage.PerformLayout();
            this.accessTabPage.ResumeLayout(false);
            this.accessTabPage.PerformLayout();
            this.odbcTabPage.ResumeLayout(false);
            this.odbcTabPage.PerformLayout();
            this.sourceDestinationGroupbox.ResumeLayout(false);
            this.sourceDestinationGroupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl DatabaseTab;
        private System.Windows.Forms.TabPage MysqlTabPage;
        private System.Windows.Forms.TabPage postgresTabPage;
        private System.Windows.Forms.TextBox mysqlHostTextbox;
        private System.Windows.Forms.TextBox mysqlUsernameTextbox;
        private System.Windows.Forms.TextBox mysqlPasswordTextbox;
        private System.Windows.Forms.TextBox mysqlDatabaseNameTextbox;
        private System.Windows.Forms.Label mysqlDatabaseNameLabel;
        private System.Windows.Forms.Label mysqlPasswordLabel;
        private System.Windows.Forms.Label mysqlUsernameLabel;
        private System.Windows.Forms.Label mysqlHostLabel;
        private System.Windows.Forms.TextBox postgresPortTextbox;
        private System.Windows.Forms.TextBox postgresSchemaTextbox;
        private System.Windows.Forms.Label postgresSchemaLabel;
        private System.Windows.Forms.Label postgresPortLabel;
        private System.Windows.Forms.TextBox postgresHostTextbox;
        private System.Windows.Forms.TextBox postgresUsernameTextbox;
        private System.Windows.Forms.TextBox postgresPasswordTextbox;
        private System.Windows.Forms.TextBox postgresDatabaseNameTextbox;
        private System.Windows.Forms.Label databaseNameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage sqlServerTabPage;
        private System.Windows.Forms.TextBox sqlserverSchemaTextbox;
        private System.Windows.Forms.Label sqlserverSchemaLabel;
        private System.Windows.Forms.TextBox sqlserverHostTextbox;
        private System.Windows.Forms.TextBox sqlserverUsernameTextbox;
        private System.Windows.Forms.TextBox sqlserverPasswordTextbox;
        private System.Windows.Forms.TextBox sqlserverDatabaseNameTextbox;
        private System.Windows.Forms.Label sqlserverDatabaseNameLabel;
        private System.Windows.Forms.Label sqlserverPasswordLabel;
        private System.Windows.Forms.Label sqlserverUsernameLabel;
        private System.Windows.Forms.Label sqlserverHostLabel;
        private System.Windows.Forms.TabPage accessTabPage;
        private System.Windows.Forms.TextBox accessPathTextbox;
        private System.Windows.Forms.Label accessPathLabel;
        private System.Windows.Forms.TabPage odbcTabPage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.RadioButton sourceRadioButton;
        private System.Windows.Forms.RadioButton destinationRadioButton;
        private System.Windows.Forms.GroupBox sourceDestinationGroupbox;
    }
}