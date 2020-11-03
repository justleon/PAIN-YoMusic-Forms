using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAIN_YoMusic_Forms
{
    [ToolboxBitmap(typeof(PictureBox))]
    public partial class CategoryChooserControl : PictureBox
    {
        public Image[] imageArray = { Properties.Resources.pop, Properties.Resources.rock, Properties.Resources.rap };

        public enum Categories { Pop = 0, Rock = 1, Rap = 2 };
        
        private Categories categoryChosen;

        [Category("Category")]
        [BrowsableAttribute(true)]
        [Editor(typeof(CategoryChooserEditor), typeof(UITypeEditor))]
        public Categories CategoryChosen
        {
            get { return categoryChosen; }
            set {
                categoryChosen = value;
                Image = imageArray[(int)value];
            }
        }

        public CategoryChooserControl()
        {
            InitializeComponent();
            categoryChosen = Categories.Pop;
            Image = imageArray[(int)categoryChosen];
            Click += CategoryChooserControl_Click;
        }

        public override string ToString()
        {
            return categoryChosen.ToString();
        }

        public void CategoryChooserControl_Click(object sender, EventArgs e)
        {
            categoryChosen++;
            categoryChosen = (Categories)((int)categoryChosen % 3);
            this.Image = imageArray[(int)categoryChosen];
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
