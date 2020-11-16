using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static PAIN_YoMusic_Forms.CategoryChooserControl;

namespace PAIN_YoMusic_Forms
{

    public class Song
    {
        public string title;
        public string author;
        public DateTime dateTime;
        public Categories category;

        public Song(string title, string author, DateTime dateTime, Categories category)
        {
            this.title = title;
            this.author = author;
            this.dateTime = dateTime;
            this.category = category;
        }
    }
}
