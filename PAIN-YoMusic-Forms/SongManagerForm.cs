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
                dateBox.Value = song.dateTime;

                switch (song.category)
                {
                    case Categories.Pop:
                        categoryChooserControl.CategoryChosen = Categories.Pop;
                        categoryBox.Text = "Pop";
                        break;
                    case Categories.Rock:
                        categoryChooserControl.CategoryChosen = Categories.Rock;
                        categoryBox.Text = "Rock";
                        break;
                    case Categories.Rap:
                        categoryChooserControl.CategoryChosen = Categories.Rap;
                        categoryBox.Text = "Rap";
                        break;
                }
            }
        }

        public string GetAuthor()
        {
            return authorBox.Text;
        }

        public string GetTitle()
        {
            return titleBox.Text;
        }

        public DateTime GetDate()
        {
            return dateBox.Value.Date;
        }

        public Categories GetCategory()
        {
            return categoryChooserControl.CategoryChosen;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
                DialogResult = DialogResult.OK;
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void categoryChooserControl_Click(object sender, EventArgs e)
        {
            categoryBox.Text = categoryChooserControl.ToString();
        }

        private void titleBox_Validating(object sender, CancelEventArgs e)
        {
            if (titleBox.Text.Equals("") && buttonCancel.Focused == false)
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
            if (authorBox.Text.Equals("") && buttonCancel.Focused == false)
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
