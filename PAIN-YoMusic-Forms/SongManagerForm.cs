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

                switch (song.category)
                {
                    case "Pop":
                        categoryChooserControl.CategoryChosen = Categories.Pop;
                        break;
                    case "Rock":
                        categoryChooserControl.CategoryChosen = Categories.Rock;
                        break;
                    case "Rap":
                        categoryChooserControl.CategoryChosen = Categories.Rap;
                        break;
                }
            }
        }

        public string[] GetData()
        {
            string[] data = { titleBox.Text, authorBox.Text, dateBox.Text, categoryBox.Text };
            return data;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
                DialogResult = DialogResult.OK;
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
                errorPrompt.SetError(titleBox, "This field can't be empty!");
            }
        }

        private void titleBox_Validated(object sender, EventArgs e)
        {
            errorPrompt.SetError(titleBox, "");
        }

        private void authorBox_Validating(object sender, CancelEventArgs e)
        {
            if (authorBox.Text.Equals(""))
            {
                e.Cancel = true;
                errorPrompt.SetError(authorBox, "This field can't be empty!");
            }
        }

        private void authorBox_Validated(object sender, EventArgs e)
        {
            errorPrompt.SetError(authorBox, "");
        }
    }
}
