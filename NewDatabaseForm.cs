using FYP_ETL.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYP_ETL
{
    public partial class NewDatabaseForm : Form
    {
        public NewDatabaseForm()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            string activeTab = DatabaseTab.SelectedTab.Text;
            string mysqlTab = MysqlTabPage.Text;
            string postgresTab = postgresTabPage.Text;
            string sqlserverTab = sqlServerTabPage.Text;
            string accessTab = accessTabPage.Text;
            string odbcTab = odbcTabPage.Text;

            Database database;

            if (activeTab == mysqlTab)
            {
                database = this.CreateMysqlDatabase();
            }
            else if (activeTab == postgresTab)
            {
                database = this.CreatePostgresDatabase();
            }
            else if (activeTab == sqlserverTab)
            {
                database = this.CreateSQLServerDatabase();
            }
            else if (activeTab == accessTab)
            {
                database = this.CreateAccessDatabase();
            }
            else
            {
                //this.CreateODBCDatabase();
                database = this.CreateMysqlDatabase(); //to be removed once odbc is implemented
            }

            
            bool connected = database.Connect();
            if (connected)
            {
                database.tablesNames = database.GetTablesNames();
                database.CreateTablesList(database.tablesNames);

                bool isSource = sourceRadioButton.Checked;
                if (isSource)
                {
                    bool databaseExistsAlready = this.DatabaseExistsAlready(database, Global.DatabasesSource);
                    if (databaseExistsAlready)
                    {
                        this.ShowErrorDialogAndClose();
                        return;
                    }
                    else
                    {
                        Global.DatabasesSource.Add(database);
                    }
                }
                else
                {
                    bool databaseExistsAlready = this.DatabaseExistsAlready(database, Global.DatabasesDestination);
                    if (databaseExistsAlready)
                    {
                        this.ShowErrorDialogAndClose();
                        return;
                    }
                    else
                    {
                        Global.DatabasesDestination.Add(database);
                    }
                }
                var pressed = MessageBox.Show("Successfully connected to database", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (pressed == DialogResult.OK)
                {
                    this.AddNodesToTreeView(isSource, database);
                    ETLParent.ShowMainContainer();
                    this.Close();
                }
            }
            else
            {
                var pressed = MessageBox.Show("Could not connect to database", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (pressed == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
        }

        private MySQLDatabase CreateMysqlDatabase()
        {
            string databaseName = mysqlDatabaseNameTextbox.Text;
            string username = mysqlUsernameTextbox.Text;
            string password = mysqlPasswordTextbox.Text;
            string serverName = mysqlHostTextbox.Text;
            MySQLDatabase mySQLDatabase = new MySQLDatabase(serverName, username, password, databaseName);
            return mySQLDatabase;
        }

        private PostgreSQLDatabase CreatePostgresDatabase()
        {
            string databaseName = postgresDatabaseNameTextbox.Text;
            string username = postgresUsernameTextbox.Text;
            string password = postgresPasswordTextbox.Text;
            string serverName = postgresHostTextbox.Text;
            string schema = postgresSchemaTextbox.Text;
            string port = postgresPortTextbox.Text;
            PostgreSQLDatabase postgreSQLDatabase = new PostgreSQLDatabase(serverName, username, password, databaseName, port, schema);
            return postgreSQLDatabase;
        }

        private SQLServerDatabase CreateSQLServerDatabase()
        {
            string databaseName = sqlserverDatabaseNameTextbox.Text;
            string username = sqlserverUsernameTextbox.Text;
            string password = sqlserverPasswordTextbox.Text;
            string serverName = sqlserverHostTextbox.Text;
            string schema = sqlserverSchemaTextbox.Text;
            SQLServerDatabase sqlServerDatabase = new SQLServerDatabase(serverName, username, password, databaseName, schema);
            return sqlServerDatabase;
        }

        private AccessDatabase CreateAccessDatabase()
        {
            string path = accessPathTextbox.Text;
            AccessDatabase accessDatabase = new AccessDatabase(path);
            return accessDatabase;
        }

        //private Database CreateODBCDatabase()
        //{

        //}

        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private bool DatabaseExistsAlready(Database database, List<Database> databases)
        {
            foreach (Database existingDatabase in databases)
            {
                if (database.Equals(existingDatabase))
                {
                    return true;
                }
            }
            return false;
        }

        private void ShowErrorDialogAndClose()
        {
            var okPressed = MessageBox.Show("Already connected to this database", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (okPressed == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void AddNodesToTreeView(bool isSource, Database database)
        {
            TreeView treeview = ETLParent.GetDestinationTreeView();
            if (isSource)
            {
                treeview = ETLParent.GetSourceTreeView();
            }
            TreeNode node = ETLParent.AddBranch(database.databaseName, treeview);
            ETLParent.AddChildrenNodes(database.tablesNames, node.Index, treeview);
        }
    }
}
