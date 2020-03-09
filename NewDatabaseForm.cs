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
            this.srcDestPanel.Show();
            this.dbTypePanel.Hide();
            this.sqlServerPanel.Hide();
            this.mysqlPanel.Hide();
            this.CenterToParent();
        }

        private void connectToDb(int dbType, bool isSource)
        {
            Database database;
            switch (dbType)
            {
                case 0:
                    database = this.CreateMysqlDatabase();
                    break;
                case 1:
                    database = this.CreateSQLServerDatabase();
                    break;
                default:
                    database = this.CreateMysqlDatabase();
                    break;
            }
            bool connected = database.Connect();
            if (connected)
            {
                database.tablesNames = database.GetTablesNames();
                database.CreateTablesList(database.tablesNames);
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
                this.AddNodesToTreeView(isSource, database);
                ETLParent.ShowMainContainer();
                this.Close();
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

        private void ConnectButton_Click(object sender, EventArgs e)
        {
           
        }

        private MySQLDatabase CreateMysqlDatabase()
        {
            string databaseName = MysqlDbNameTextBox.Text;
            string username = MysqlUsernameTextBox.Text;
            string password = MysqlPassTextBox.Text;
            string serverName = MysqlHostTextBox.Text;
            MySQLDatabase mySQLDatabase = new MySQLDatabase(serverName, username, password, databaseName);
            return mySQLDatabase;
        }

        private PostgreSQLDatabase CreatePostgresDatabase()
        {
            //string databaseName = postgresDatabaseNameTextbox.Text;
            //string username = postgresUsernameTextbox.Text;
            //string password = postgresPasswordTextbox.Text;
            //string serverName = postgresHostTextbox.Text;
            //string schema = postgresSchemaTextbox.Text;
            //string port = postgresPortTextbox.Text;
            //PostgreSQLDatabase postgreSQLDatabase = new PostgreSQLDatabase(serverName, username, password, databaseName, port, schema);
            //return postgreSQLDatabase;
            return null;
        }

        private SQLServerDatabase CreateSQLServerDatabase()
        {
            string databaseName = sqlServerDbNameTextBox.Text;
            string username = sqlServerUsernameTextBox.Text;
            string password = sqlServerPassTextBox.Text;
            string serverName = sqlServerHostTextBox.Text;
            string schema = sqlServerSchemaTextBox.Text;
            SQLServerDatabase sqlServerDatabase = new SQLServerDatabase(serverName, username, password, databaseName, schema);
            return sqlServerDatabase;
        }

        private AccessDatabase CreateAccessDatabase()
        {
            //string path = accessPathTextbox.Text;
            //AccessDatabase accessDatabase = new AccessDatabase(path);
            //return accessDatabase;
            return null;
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

        private void SrcDestNex_Click(object sender, EventArgs e)
        {
            
            this.dbTypePanel.Show();
            var checkedButton = srcDestPanel.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            if(checkedButton.Name == "srcRadioButton")
            {
                this.Text = "Add Source Database";
            }
            if (checkedButton.Name == "destRadioButton")
            {
                this.Text = "Add Destination Database";
            }
        }

        private void backToSrcDest_Click(object sender, EventArgs e)
        {
            this.dbTypePanel.Hide();
            this.srcDestPanel.Show();
        }

        private void dbTypeButton_Click(object sender, EventArgs e)
        {
            this.dbTypePanel.Hide();
            switch (this.dbTypesComboBox.SelectedIndex)
            {

                case 0:
                    this.mysqlPanel.Show();
                    break;
                case 1:
                    this.sqlServerPanel.Show();
                    break;
            }
           
            
            
        }

        private void backToDbTypes_Click(object sender, EventArgs e)
        {
            this.mysqlPanel.Hide();
            this.dbTypePanel.Show();
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            var checkedButton = srcDestPanel.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            bool isSource = checkedButton.Name == "srcRadioButton";
            this.connectToDb(dbTypesComboBox.SelectedIndex, isSource);
        }

        private void sqlServerConnect_Click(object sender, EventArgs e)
        {
            var checkedButton = srcDestPanel.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            bool isSource = checkedButton.Name == "srcRadioButton";
            this.connectToDb(dbTypesComboBox.SelectedIndex, isSource);
        }

        private void backToDbType_Click(object sender, EventArgs e)
        {
            this.sqlServerPanel.Hide();
            this.mysqlPanel.Hide();
            this.dbTypePanel.Show();
        }
    }
}
