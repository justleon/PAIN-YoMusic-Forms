using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PAIN_YoMusic_Forms.CategoryChooserControl;

namespace PAIN_YoMusic_Forms
{
    public partial class SongManagerForm : Form
    {
        Song song;

        public SongManagerForm(Song song)
        {
            InitializeComponent();
            this.song = song;
        }

        private void SongManagerForm_Load(object sender, EventArgs e)
        {
            if(song != null)
            {
                titleBox.Text = song.title;
                authorBox.Text = song.author;
                dateBox.Text = song.dateTime;
                categoryBox.Text = song.category;

                switch ((int)categoryChooserControl.CategoryChosen)
                {
                    case 0:
                        categoryChooserControl.Image = categoryChooserControl.imageArray[(int)Categories.Pop];
                        break;
                    case 1:
                        categoryChooserControl.Image = categoryChooserControl.imageArray[(int)Categories.Rock];
                        break;
                    case 2:
                        categoryChooserControl.Image = categoryChooserControl.imageArray[(int)Categories.Rap];
                        break;
                }
                    
            }
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
                DialogResult = DialogResult.OK;
        }

        public string GetTitle()
        {
            return titleBox.Text;
        }

        public string GetAuthor()
        {
            return authorBox.Text;
        }

        public string GetDate()
        {
            return dateBox.Text;
        }

        public string GetCategory()
        {
            return categoryBox.Text;
        }

        public string[] GetData()
        {
            string[] data = { titleBox.Text, authorBox.Text, dateBox.Text, categoryBox.Text };
            return data;
        }

        private void categoryChooserControl_Click(object sender, EventArgs e)
        {
            categoryBox.Text = categoryChooserControl.ToString();
        }

        private void titleBox_Validating(object sender, CancelEventArgs e)
        {
            if (titleBox.Text.Equals(""))
            {
                e.Cancel = true;
                this.errorTitleBox.SetError(titleBox, "This field can't be empty!");
            }
        }

        private void titleBox_Validated(object sender, EventArgs e)
        {
            this.errorTitleBox.SetError(titleBox, "");
        }

        private void authorBox_Validating(object sender, CancelEventArgs e)
        {
            if (authorBox.Text.Equals(""))
            {
                e.Cancel = true;
                this.errorAuthorBox.SetError(authorBox, "This field can't be empty!");
            }
        }

        private void authorBox_Validated(object sender, EventArgs e)
        {
            this.errorAuthorBox.SetError(authorBox, "");
        }
    }
}
