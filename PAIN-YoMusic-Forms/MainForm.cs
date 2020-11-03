using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAIN_YoMusic_Forms
{
    public partial class MainForm : Form
    {
        private Document document = new Document();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SongListForm initView = new SongListForm(document);
            initView.FormClosing += SongListForm_FormClosing;
            initView.MdiParent = this;
            initView.Show();
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void optionNew_Click(object sender, EventArgs e)
        {
            SongListForm newMdiWindow = new SongListForm(document);
            newMdiWindow.FormClosing += SongListForm_FormClosing;
            newMdiWindow.MdiParent = this;
            newMdiWindow.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit the program?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void optionTileHorizontally_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void optionTileVertically_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void SongListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MdiChildren.Length <= 1 && e.CloseReason != CloseReason.MdiFormClosing)
                e.Cancel = true;
        }
    }
}