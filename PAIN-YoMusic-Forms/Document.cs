using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAIN_YoMusic_Forms
{
    public class Document
    {
        private List<Song> songList = new List<Song>();

        public event Action<Song> AddSongToList;
        public event Action<ListViewItem> ModifySongOnList;
        public event Action<ListViewItem> DeleteSongFromList;

        public void AddSong(Song song)
        {
            songList.Add(song);

            AddSongToList?.Invoke(song);
        }

        public void DeleteSong(ListViewItem song)
        {
            songList.Remove((Song)song.Tag);

            DeleteSongFromList?.Invoke(song);
        }
        
        public void UpdateSong(ListViewItem modifiedItem)
        {
            foreach (Song song in songList)
            {
                if (song == modifiedItem.Tag)
                {
                    song.title = modifiedItem.SubItems[0].Text;
                    song.author = modifiedItem.SubItems[1].Text;
                    song.dateTime = modifiedItem.SubItems[2].Text;
                    song.category = modifiedItem.SubItems[3].Text;
                    break;
                }
            }

            ModifySongOnList?.Invoke(modifiedItem);
        }

        public List<Song> GetSongList() { return songList; }
    }
}
