using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PAIN_YoMusic_Forms
{
    public class Song
    {
        public string title;
        public string author;
        public string dateTime;
        public string category;

        public Song(string t, string a, string d, string c)
        {
            this.title = t;
            this.author = a;
            this.dateTime = d;
            this.category = c;
        }

        public Song(string[] data)
        {
            this.title = data[0];
            this.author = data[1];
            this.dateTime = data[2];
            this.category = data[3];
        }
    }
}
