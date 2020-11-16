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
        public event Action<Song> ModifySongOnList;
        public event Action<Song> DeleteSongFromList;

        public void AddSong(Song song)
        {
            songList.Add(song);

            AddSongToList?.Invoke(song);
        }

        public void DeleteSong(Song song)
        {
            songList.Remove(song);

            DeleteSongFromList?.Invoke(song);
        }
        
        public void UpdateSong(Song modifiedItem)
        {
            foreach (Song song in songList)
            {
                if (song == modifiedItem)
                {
                    song.title = modifiedItem.title;
                    song.author = modifiedItem.author;
                    song.dateTime = modifiedItem.dateTime;
                    song.category = modifiedItem.category;
                    break;
                }
            }

            ModifySongOnList?.Invoke(modifiedItem);
        }

        public List<Song> GetSongList() { return songList; }
    }
}
