namespace PAIN_YoMusic_Forms
{
    partial class SongListForm
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
            this.menuStripList = new System.Windows.Forms.MenuStrip();
            this.songListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripAddButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripDeleteButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripModifyButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripFilter = new System.Windows.Forms.ToolStripComboBox();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStripList.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripList
            // 
            this.menuStripList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.songListToolStripMenuItem});
            this.menuStripList.Location = new System.Drawing.Point(0, 0);
            this.menuStripList.Name = "menuStripList";
            this.menuStripList.Size = new System.Drawing.Size(622, 24);
            this.menuStripList.TabIndex = 1;
            this.menuStripList.Text = "menuStrip1";
            this.menuStripList.Visible = false;
            // 
            // songListToolStripMenuItem
            // 
            this.songListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.modifyToolStripMenuItem});
            this.songListToolStripMenuItem.Name = "songListToolStripMenuItem";
            this.songListToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.songListToolStripMenuItem.Text = "Song List Document";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Enabled = false;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.Enabled = false;
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.modifyToolStripMenuItem.Text = "Modify";
            this.modifyToolStripMenuItem.Click += new System.EventHandler(this.ModifyToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 0);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(622, 25);
            this.statusStrip.TabIndex = 4;
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(67, 20);
            this.toolStripStatusLabel.Text = "Elements: 0";
            // 
            // toolStrip
            // 
            this.toolStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAddButton,
            this.toolStripDeleteButton,
            this.toolStripModifyButton,
            this.toolStripFilter});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(622, 25);
            this.toolStrip.TabIndex = 5;
            this.toolStrip.Text = "Tools";
            this.toolStrip.Visible = false;
            // 
            // toolStripAddButton
            // 
            this.toolStripAddButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripAddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAddButton.Name = "toolStripAddButton";
            this.toolStripAddButton.Size = new System.Drawing.Size(33, 22);
            this.toolStripAddButton.Text = "Add";
            this.toolStripAddButton.ToolTipText = "Add";
            this.toolStripAddButton.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // toolStripDeleteButton
            // 
            this.toolStripDeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDeleteButton.Enabled = false;
            this.toolStripDeleteButton.Name = "toolStripDeleteButton";
            this.toolStripDeleteButton.Size = new System.Drawing.Size(54, 22);
            this.toolStripDeleteButton.Text = "Remove";
            this.toolStripDeleteButton.ToolTipText = "Remove";
            this.toolStripDeleteButton.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // toolStripModifyButton
            // 
            this.toolStripModifyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripModifyButton.Enabled = false;
            this.toolStripModifyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripModifyButton.Name = "toolStripModifyButton";
            this.toolStripModifyButton.Size = new System.Drawing.Size(49, 22);
            this.toolStripModifyButton.Text = "Modify";
            this.toolStripModifyButton.Click += new System.EventHandler(this.ModifyToolStripMenuItem_Click);
            // 
            // toolStripFilter
            // 
            this.toolStripFilter.Items.AddRange(new object[] {
            "All",
            "After 2000",
            "Before 2000"});
            this.toolStripFilter.Name = "toolStripFilter";
            this.toolStripFilter.Size = new System.Drawing.Size(121, 25);
            this.toolStripFilter.Text = "All";
            this.toolStripFilter.SelectedIndexChanged += new System.EventHandler(this.ToolStripFilter_SelectedIndexChanged);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(444, 225);
            // 
            // listView
            // 
            this.listView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(622, 386);
            this.listView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.ListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Title";
            this.columnHeader1.Width = 220;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Author";
            this.columnHeader2.Width = 146;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date of release";
            this.columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Genre";
            this.columnHeader4.Width = 112;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.statusStrip);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 386);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 25);
            this.panel1.TabIndex = 6;
            // 
            // SongListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 411);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStripList);
            this.MainMenuStrip = this.menuStripList;
            this.Name = "SongListForm";
            this.Text = "List View";
            this.Activated += new System.EventHandler(this.SongListForm_Activated);
            this.Deactivate += new System.EventHandler(this.SongListForm_Deactivate);
            this.Load += new System.EventHandler(this.SongListForm_Load);
            this.menuStripList.ResumeLayout(false);
            this.menuStripList.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStripList;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripAddButton;
        private System.Windows.Forms.ToolStripButton toolStripDeleteButton;
        private System.Windows.Forms.ToolStripButton toolStripModifyButton;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripComboBox toolStripFilter;
        private System.Windows.Forms.ToolStripMenuItem songListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
    }
}