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
        SongManagerForm manageSongForm;
        List<Song> songList;

        public SongListForm(MainForm mainForm, List<Song> songList)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.songList = songList.ConvertAll(song => new Song(song.title, song.author, song.dateTime, song.category)); //creates deep copy of the main song list
        }

        private void check_form_closure(object sender, FormClosingEventArgs e)
        {
            if (mainForm.viewList.Count <= 1 && e.CloseReason != CloseReason.MdiFormClosing)
                e.Cancel = true;
            else
                mainForm.viewList.Remove(sender as SongListForm);
        }

        private void SongListForm_Activated(object sender, EventArgs e)
        {
            this.menuStripList.AllowMerge = true;
            mainForm.toolStripStatusLabel.Text = "Elements: " + songList.Count.ToString();
        }

        private void SongListForm_Deactivate(object sender, EventArgs e)
        {
            this.menuStripList.AllowMerge = false;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manageSongForm = new SongManagerForm(null);
            if(manageSongForm.ShowDialog() == DialogResult.OK)
            {
                Song newSong = new Song(manageSongForm.GetData());
                this.songList.Add(newSong);

                string[] row = { newSong.title, newSong.author, newSong.dateTime, newSong.category };
                ListViewItem viewItem = new ListViewItem(row);
                viewItem.Tag = newSong;
                listView.Items.Add(viewItem);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
