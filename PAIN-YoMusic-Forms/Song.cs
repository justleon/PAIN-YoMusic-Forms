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
        private string title;
        private string author;
        private DateTime dateTime;
        private string category;

        public Song(string t, string a, DateTime d, string c)
        {
            this.title = t;
            this.author = a;
            this.dateTime = d;
            this.category = c;
        }
    }
}
