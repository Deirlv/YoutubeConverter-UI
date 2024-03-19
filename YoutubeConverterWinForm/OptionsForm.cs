using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoutubeConverterWinForm
{
    public partial class OptionsForm : Form
    {
        public bool isThumbnailLoaded { get; set; }

        public OptionsForm(bool isThumbnailLoad)
        {
            isThumbnailLoaded = isThumbnailLoad;
            InitializeComponent();

            comboBoxThumbnails.SelectedIndex = isThumbnailLoad ? 0 : 1;
        }
        public OptionsForm()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            isThumbnailLoaded = comboBoxThumbnails.SelectedIndex == 0 ? true : false;
            Close();
        }
    }
}
