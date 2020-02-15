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
        }

        private void MysqlConnectButton_Click(object sender, EventArgs e)
        {
            string databaseName = mysqlDatabaseNameTextbox.Text;
            string username = mysqlUsernameTextbox.Text;
            string password = mysqlPasswordTextbox.Text;
            string serverName = mysqlHostTextbox.Text;
            MySQLDatabase mySQLDatabase = new MySQLDatabase(serverName, username, password, databaseName);
            bool connected = mySQLDatabase.Connect();
            if (connected)
            {
                
            }
            else
            {
                this.Close();
                MessageBox.Show("Could not connect to database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
