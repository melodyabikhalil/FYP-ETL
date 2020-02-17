using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FYP_ETL.Base;

namespace FYP_ETL
{
    public partial class DataGridUserControl : UserControl
    {
        public bool isSource { get; set; }
        public string TableNameLabel
        {
            get { return this.tableNameLabel.Text; }
            set { this.tableNameLabel.Text = value; }
        }

        public DataTable GridViewSource
        {
            get { return (DataTable) this.ColumnsDataGridView.DataSource; }
            set
            {
                this.ColumnsDataGridView.DataSource = value;
                ColumnsDataGridView.ClearSelection();
            }
        }

        public DataGridView DataGridViewColumns
        {
            get { return this.ColumnsDataGridView; }
            set { this.ColumnsDataGridView = value; }
        }

        public DataGridUserControl()
        {
            InitializeComponent();
            ColumnsDataGridView.AllowUserToAddRows = false;
            ColumnsDataGridView.RowHeadersVisible = false;
            ColumnsDataGridView.ColumnHeadersVisible = false;
            ColumnsDataGridView.AllowUserToResizeRows = false;
            closeButton.ForeColor = Color.Red;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Global.RemoveTable(this.isSource, this.tableNameLabel.Text);
            this.Parent.Controls.Remove(this);
            ETLParent.ReloadGridUserControls(this.tableNameLabel.Text, this.GridViewSource, this.isSource);
        }
    }
}
