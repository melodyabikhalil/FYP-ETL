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
        public string databaseName { get; set; }

        public string TableNameLabel
        {
            get { return this.tableNameLabel.Text; }
            set { this.tableNameLabel.Text = value; }
        }

        public DataTable GridViewSource
        {
            get { return (DataTable)this.ColumnsDataGridView.DataSource; }
            set
            {
                this.ColumnsDataGridView.DataSource = value;
                ColumnsDataGridView.ClearSelection();
                ColumnsDataGridView.Update();
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
            ColumnsDataGridView.ReadOnly = true;
            closeButton.ForeColor = Color.Red;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Global.RemoveTable(this.isSource, this.tableNameLabel.Text);
            this.Parent.Controls.Remove(this);
            ETLParent.ReloadGridUserControls(this.tableNameLabel.Text, this.GridViewSource, this.isSource);
        }

        private void ColumnsDataGridView_DragDrop(object sender, DragEventArgs e)
        {
            Console.WriteLine("drag drop sender: " + sender.ToString());
            Console.WriteLine("drag drop: " + e.X.ToString() + ", " + e.Y.ToString());
            if (sender.Equals(this))
            {
                Console.WriteLine("drag drop: sender== this");
            }
            if (e.Data.GetDataPresent("data"))
            {
                KeyValuePair<Point, Dictionary<string, string>> data1 = (KeyValuePair<Point, Dictionary<string, string>>) e.Data.GetData("data");
                //Point point = new Point(this.Right, (int)(this.Top + 30 + this.DataGridViewColumns.RowTemplate.Height * this.DataGridViewColumns.CurrentCell.RowIndex));

                Point currentPoint = new Point(Cursor.Position.X, Cursor.Position.Y);
                Point cursorPos = DataGridViewColumns.PointToClient(currentPoint);
                if (this.isInsideCurrentUserControl(cursorPos) && this.isInsideCurrentUserControl(data1.Key))
                {
                    Console.WriteLine("same user control");
                    return;
                }

                Point point = new Point(this.Right, e.Y);
                DataGridViewCell clickedCell;
                DataGridView.HitTestInfo hit = DataGridViewColumns.HitTest(cursorPos.X, cursorPos.Y);
                if (hit.Type == DataGridViewHitTestType.Cell)
                {
                    clickedCell = DataGridViewColumns.Rows[hit.RowIndex].Cells[hit.ColumnIndex];
                    Dictionary<string, string> tableAndColumn = new Dictionary<string, string>();
                    tableAndColumn.Add("table", this.tableNameLabel.Text);
                    tableAndColumn.Add("column", clickedCell.Value.ToString());

                    KeyValuePair<Point, Dictionary<string, string>> data2 = new KeyValuePair<Point, Dictionary<string, string>>();
                    data2 = new KeyValuePair<Point, Dictionary<string, string>>(point, tableAndColumn);
                    ETLParent.SetJoinedColumns(data1, data2);
                }
            }
        }

        private void ColumnsDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine("mouse down sender: " + sender.ToString());
            if (sender.Equals(this))
            {
                Console.WriteLine("mouse down: sender== this");
            }
            if (e.Button == MouseButtons.Left)
            {
                DataGridView.HitTestInfo info = DataGridViewColumns.HitTest(e.X, e.Y);
                if (info.RowIndex >= 0)
                {
                    if (info.RowIndex >= 0 && info.ColumnIndex >= 0)
                    {
                        string column = (String)DataGridViewColumns.Rows[info.RowIndex].Cells[info.ColumnIndex].Value;
                        if (column != null)
                        {
                            Point point = new Point(this.Right, e.Y);
                            Dictionary<string, string> tableAndColumn = new Dictionary<string, string>();
                            tableAndColumn.Add("table", this.tableNameLabel.Text);
                            tableAndColumn.Add("column", column);

                            KeyValuePair<Point, Dictionary<string, string>> data = new KeyValuePair<Point, Dictionary<string, string>>();
                            data = new KeyValuePair<Point, Dictionary<string, string>>(point, tableAndColumn);

                            Console.WriteLine("Mouse down: " + e.X.ToString() + ", " + e.Y.ToString());
                            DataObject dragData = new DataObject("data", data);
                            ColumnsDataGridView.DoDragDrop(dragData, DragDropEffects.Copy);
                        }
                    }
                }       
            }
        }

        private void ColumnsDataGridView_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private bool isInsideCurrentUserControl(Point point)
        {
            bool isInside = point.X > this.Left && point.X < this.Right && point.Y > this.Top && point.Y < this.Bottom;
            return isInside;
        }
    }
}
