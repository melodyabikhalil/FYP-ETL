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
    public partial class ETLParent : Form
    {
        private int childFormNumber = 0;
        private static ETLParent _instance;
        private List<DataGridUserControl> dataGridUserControlsSource = new List<DataGridUserControl>();
        private DataGridUserControl dataGridUserControlDestination = new DataGridUserControl();
        private List<Tuple<Point, Point>> points = new List<Tuple<Point, Point>>();
        private List<Tuple<Dictionary<string, string>, Dictionary<string, string>>> tablesAndColumnsToJoinOn = new List<Tuple<Dictionary<string, string>, Dictionary<string, string>>>();


        public ETLParent()
        {
            InitializeComponent();
            _instance = this;
            this.HideMainContainer();
            this.joinButton.Visible = false;
            this.clearButton.Visible = false;
        }

        private void ETLParent_Activated(object sender, System.EventArgs e)
        {
            MessageBox.Show("activated:");
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void ETLParent_Load(object sender, EventArgs e)
        {
        }

        private void Add_Click(object sender, EventArgs e)
        {
            NewDatabaseForm newDatabaseForm = new NewDatabaseForm();
            newDatabaseForm.Show();
        }

        private void SourceTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level == 0)
            {
                return;
            }
            string tableName = e.Node.Text;
            string databaseName = e.Node.Parent.Text;
            Database database = Global.GetSourceDatabaseByName(databaseName);
            Table table = database.GetTable(tableName);
            if (Global.TableSourceAlreadyExpanded(table))
            {
                return;
            }
            database.Close();
            database.Connect();
            bool gotTableSchema = database.SetDatatableSchema(tableName);
            database.Close();
            if (!gotTableSchema)
            {
                return;
            }
            List<string> columns = table.GetColumnsNames();
            DataTable dataTable = Helper.ConvertListToDataTable(columns);
            Global.TablesSourceExpanded.Add(table);

            int tableIndex = Global.GetTableSourceExpandedIndex(table);
            if (tableIndex == -1)
            {
                return;
            }
            DataGridUserControl dataGridUserControl = new DataGridUserControl();
            dataGridUserControl.TableNameLabel = tableName;
            dataGridUserControl.GridViewSource = dataTable;
            dataGridUserControl.isSource = true;
            dataGridUserControl.Top = tableIndex * 200 + 10;
            dataGridUserControl.Left = 50;
            dataGridUserControl.Width = 140;
            dataGridUserControl.Height = 180;
            dataGridUserControl.Show();
            dataGridUserControl.Point = new Point(50, tableIndex * 200 + 10);
            splitContainerMiddle.Panel1.Controls.Add(dataGridUserControl);
            this.dataGridUserControlsSource.Add(dataGridUserControl);
            this.joinButton.Visible = true;
            this.clearButton.Visible = true;
        }

        private void HideMainContainer()
        {
            splitContainerMain.Visible = false;
        }

        public static void ShowMainContainer()
        {
            _instance.splitContainerMain.Visible = true;
        }

        public static TreeView GetSourceTreeView()
        {
            return _instance.sourceTreeView;
        }

        public static TreeView GetDestinationTreeView()
        {
            return _instance.destinationTreeView;
        }

        public static TreeNode AddBranch(string nodeName, TreeView treeView)
        {
            treeView.BeginUpdate();
            TreeNode treeNodeCreated = treeView.Nodes.Add(nodeName);
            treeView.EndUpdate();
            return treeNodeCreated;
        }

        public static void AddChildrenNodes(List<string> childrenNames, int parentIndex, TreeView treeView)
        {
            foreach (string childName in childrenNames)
            {
                treeView.Nodes[parentIndex].Nodes.Add(childName);
            }
        }

        //private void SourceTreeView_MouseDoubleClick(object sender, TreeViewEventArgs e)
        //{
        //    MessageBox.Show(e.Node.Level.ToString(), e.Node.Parent.Text.ToString());
        //}

        public static void ReloadGridUserControls(string tableName, DataTable dataTable, bool isSource)
        {
            if (isSource)
            {
                foreach (DataGridUserControl dataGridUserControl in _instance.dataGridUserControlsSource)
                {
                    if (dataGridUserControl.TableNameLabel == tableName && dataGridUserControl.GridViewSource == dataTable)
                    {
                        _instance.dataGridUserControlsSource.Remove(dataGridUserControl);
                        break;
                    }
                }
                if (_instance.dataGridUserControlsSource.Count == 0)
                {
                    _instance.joinButton.Visible = false;
                    _instance.clearButton.Visible = false;
                    return;
                }
                for (int i = 0; i < _instance.dataGridUserControlsSource.Count; ++i)
                {
                    _instance.dataGridUserControlsSource[i].Top = i * 200 + 10;
                    _instance.dataGridUserControlsSource[i].Point = new Point(50, i * 200 + 10);
                }
            }
            else
            {
                _instance.dataGridUserControlDestination = new DataGridUserControl();
            }
        }

        private void DestinationTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level == 0)
            {
                return;
            }
            string tableName = e.Node.Text;
            string databaseName = e.Node.Parent.Text;
            Database database = Global.GetDestinationDatabaseByName(databaseName);
            Table table = database.GetTable(tableName);
            if (this.dataGridUserControlDestination.TableNameLabel != "label1")
            {
                MessageBox.Show("Only 1 table destination can be expanded", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                database.Close();
                database.Connect();
                bool gotTableSchema = database.SetDatatableSchema(tableName);
                database.Close();
                if (!gotTableSchema)
                {
                    return;
                }
                List<string> columns = table.GetColumnsNames();
                DataTable dataTable = Helper.ConvertListToDataTable(columns);
                Global.TableDestinationExpanded = table;

                DataGridUserControl dataGridUserControl = new DataGridUserControl();
                dataGridUserControl.TableNameLabel = tableName;
                dataGridUserControl.GridViewSource = dataTable;
                dataGridUserControl.databaseName = e.Node.Text;
                dataGridUserControl.isSource = false;
                dataGridUserControl.Top = 10;
                dataGridUserControl.Left = 450; //to be fixed
                dataGridUserControl.Width = 140;
                dataGridUserControl.Height = 280;
                dataGridUserControl.Show();
                dataGridUserControl.Point = new Point(450, 10);
                splitContainerMiddle.Panel1.Controls.Add(dataGridUserControl);
                this.dataGridUserControlDestination = dataGridUserControl;
            }
        }

        private void JoinButton_Click(object sender, EventArgs e)
        {
            string query = Global.GetJoinQuery(this.tablesAndColumnsToJoinOn);
        }

        private void SplitContainerMiddle_Panel1_Paint(object sender, PaintEventArgs e)
        {
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; ++i)
                {
                    Random random = new Random();
                    int randomMargin = random.Next(15, 50);
                    Point cornerOne = new Point(points[i].Item1.X + randomMargin, points[i].Item1.Y);
                    Point cornertwo = new Point(points[i].Item2.X + randomMargin, points[i].Item2.Y);
                    e.Graphics.DrawLine(Pens.Black, points[i].Item1, cornerOne);
                    e.Graphics.DrawLine(Pens.Black, points[i].Item2, cornertwo);
                    e.Graphics.DrawLine(Pens.Black, cornerOne, cornertwo);
                }
            }
        }

        public static void SetJoinedColumns(KeyValuePair<Point, Dictionary<string, string>> data1, KeyValuePair<Point, Dictionary<string, string>> data2)
        {
            Point point1 = data1.Key;
            Point point2 = data2.Key;

            _instance.points.Add(new Tuple<Point, Point>(point1, point2));
            _instance.tablesAndColumnsToJoinOn.Add(new Tuple<Dictionary<string, string>, Dictionary<string, string>>(data1.Value, data2.Value));

            _instance.splitContainerMiddle.Panel1.Invalidate();
            _instance.splitContainerMiddle.Panel1.Update();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.points = new List<Tuple<Point, Point>>();
            this.tablesAndColumnsToJoinOn = new List<Tuple<Dictionary<string, string>, Dictionary<string, string>>>();
            this.splitContainerMiddle.Panel1.Invalidate();
            this.splitContainerMiddle.Panel1.Update();
        }
    }
}
