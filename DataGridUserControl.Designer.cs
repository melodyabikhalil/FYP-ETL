﻿namespace FYP_ETL
{
    partial class DataGridUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataGridUserControl));
            this.ColumnsDataGridView = new System.Windows.Forms.DataGridView();
            this.tableNameLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ColumnsDataGridView
            // 
            this.ColumnsDataGridView.AllowDrop = true;
            this.ColumnsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ColumnsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ColumnsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColumnsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ColumnsDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ColumnsDataGridView.Name = "ColumnsDataGridView";
            this.ColumnsDataGridView.RowHeadersWidth = 51;
            this.ColumnsDataGridView.Size = new System.Drawing.Size(193, 249);
            this.ColumnsDataGridView.TabIndex = 0;
            this.ColumnsDataGridView.DragDrop += new System.Windows.Forms.DragEventHandler(this.ColumnsDataGridView_DragDrop);
            this.ColumnsDataGridView.DragEnter += new System.Windows.Forms.DragEventHandler(this.ColumnsDataGridView_DragEnter);
            this.ColumnsDataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ColumnsDataGridView_MouseDown);
            // 
            // tableNameLabel
            // 
            this.tableNameLabel.AutoSize = true;
            this.tableNameLabel.Location = new System.Drawing.Point(4, 7);
            this.tableNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tableNameLabel.Name = "tableNameLabel";
            this.tableNameLabel.Size = new System.Drawing.Size(46, 17);
            this.tableNameLabel.TabIndex = 1;
            this.tableNameLabel.Text = "label1";
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.Control;
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.closeButton.Location = new System.Drawing.Point(163, 4);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(28, 25);
            this.closeButton.TabIndex = 2;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.closeButton);
            this.splitContainer1.Panel1.Controls.Add(this.tableNameLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ColumnsDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(193, 284);
            this.splitContainer1.SplitterDistance = 30;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 3;
            // 
            // DataGridUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DataGridUserControl";
            this.Size = new System.Drawing.Size(193, 284);
            ((System.ComponentModel.ISupportInitialize)(this.ColumnsDataGridView)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ColumnsDataGridView;
        private System.Windows.Forms.Label tableNameLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}
