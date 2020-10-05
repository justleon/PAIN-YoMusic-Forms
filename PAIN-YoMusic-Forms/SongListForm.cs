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
    public partial class SongListForm : Form
    {
        MainForm mainForm;
        List<Song> songList;

        public SongListForm(MainForm mainForm, List<Song> songList)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.songList = songList;
        }

        private void check_form_closure(object sender, FormClosingEventArgs e)
        {
            if (mainForm.viewList.Count <= 1 && e.CloseReason != CloseReason.MdiFormClosing)
                e.Cancel = true;
            else
                mainForm.viewList.Remove(sender as SongListForm);
        }
    }
}
