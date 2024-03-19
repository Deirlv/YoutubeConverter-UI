using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using VideoLibrary;
using static System.Windows.Forms.LinkLabel;

namespace YoutubeConverterWinForm
{
    public partial class Form1 : Form
    {
        private readonly YouTube _client;

        private Video _video;

        private bool isThumbnailShouldLoad = true;

        private string filePath = Directory.GetCurrentDirectory();

        private string _link;

        public Form1()
        {
            _client = YouTube.Default;
            InitializeComponent();
            pictureBoxVideo.Image = Properties.Resources.Youtube_logo;
        }

        private async void buttonFind_Click(object sender, EventArgs e)
        {
            if (textBoxLink.Text.Length == 0)
            {
                MessageBox.Show("The link field is empty! Please enter the data before trying to find the video.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            await FillLinkForm(textBoxLink.Text);
        }

        /// <summary>
        /// Fills the main form of the chosen video after clicking the "Find" button
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        private async Task FillLinkForm(string link)
        {
            try
            {
                _link = link;

                _video = await _client.GetVideoAsync(link);
                var videoData = await _client.GetAllVideosAsync(link);
                var resolutions = videoData.Where(r => r.AdaptiveKind == AdaptiveKind.Video && r.Format == VideoFormat.Mp4)
                                           .Select(r => r.Resolution);

                comboBoxFormats.DataSource = resolutions.ToList();

                comboBoxFormats.SelectedIndex = 0;

                labelName.Text = _video.Info.Title;
                labelDuration.Text = $"{_video.Info.LengthSeconds.ToString()} seconds";
                pictureBoxVideo.SizeMode = PictureBoxSizeMode.StretchImage;

                if (isThumbnailShouldLoad)
                {
                    pictureBoxVideo.Image = await DownloadImage(await GetThumbnailUrl(link));
                }

                groupBoxStart.Enabled = false;
                groupBoxStart.Visible = false;

                groupBoxMain.Enabled = true;
                groupBoxMain.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Adds downloading task to the thread and creates UI to analyze the downloading list
        /// </summary>
        /// <returns></returns>
        private async Task AddDownloadingToQuery()
        {
            Label templateLabelStatus = new Label();

            templateLabelStatus.AutoSize = true;
            templateLabelStatus.Location = new Point(563, 46);
            templateLabelStatus.Size = new Size(87, 15);
            templateLabelStatus.Text = "Downloading...";

            Label templateLabelDuration = new Label();

            templateLabelDuration.AutoSize = true;
            templateLabelDuration.Location = new Point(150, 62);
            templateLabelDuration.Size = new Size(53, 15);
            templateLabelDuration.Text = $"{_video.Info.LengthSeconds.ToString()} seconds";

            Label templateLabelName = new Label();

            templateLabelName.AutoSize = true;
            templateLabelName.Location = new Point(150, 34);
            templateLabelName.Size = new Size(39, 15);
            templateLabelName.Text = _video.Info.Title;

            PictureBox templatePictureBox = new PictureBox();

            templatePictureBox.Location = new Point(6, 18);
            templatePictureBox.Size = new Size(138, 72);
            templatePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            templatePictureBox.TabStop = false;

            if (isThumbnailShouldLoad)
            {
                templatePictureBox.Image = await DownloadImage(await GetThumbnailUrl(_link));
            }
            else
            {
                templatePictureBox.Image = Properties.Resources.Youtube_logo;
            }

            GroupBox templateGroupBox = new GroupBox();

            templateGroupBox.Enabled = true;
            templateGroupBox.Location = new Point(3, 3);
            templateGroupBox.Size = new Size(763, 100);
            templateGroupBox.TabStop = false;
            templateGroupBox.Visible = true;

            templateGroupBox.Controls.Add(templateLabelStatus);
            templateGroupBox.Controls.Add(templateLabelDuration);
            templateGroupBox.Controls.Add(templateLabelName);
            templateGroupBox.Controls.Add(templatePictureBox);

            flowLayoutPanel1.Controls.Add(templateGroupBox);

            tabControlMain.SelectedIndex = 1;

            try
            {
                int selectedQuality = Convert.ToInt32(comboBoxFormats.SelectedItem);
                var video = await _client.GetAllVideosAsync(_link);
                var streamInfo = video.Where(s => s.Resolution == selectedQuality && s.Format == VideoFormat.Mp4).FirstOrDefault();

                if (streamInfo != null)
                {
                    byte[] bytes = streamInfo.GetBytes();

                    await File.WriteAllBytesAsync(filePath, bytes);

                    templateLabelStatus.Text = "Done";
                }
                else
                {
                    MessageBox.Show("Selected quality not available for download.");

                    templateLabelStatus.Text = "Cancelled";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }


        /// <summary>
        /// Gets the thumbnail of the given video url
        /// </summary>
        /// <param name="videoUrl"></param>
        /// <returns></returns>
        private async Task<string> GetThumbnailUrl(string videoUrl)
        {
            try
            {
                using (var webClient = new WebClient())
                {
                    string html = await webClient.DownloadStringTaskAsync(videoUrl);

                    var match = Regex.Match(html, @"<meta property=""og:image"" content=""(.*?)""");
                    if (match.Success)
                    {
                        return match.Groups[1].Value;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving thumbnail URL: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        /// <summary>
        /// Downloads the image by the give image url
        /// </summary>
        /// <param name="imageUrl"></param>
        /// <returns></returns>
        private async Task<Image> DownloadImage(string imageUrl)
        {
            try
            {
                using (var webClient = new WebClient())
                {
                    var imageData = await webClient.DownloadDataTaskAsync(imageUrl);
                    using (var memoryStream = new MemoryStream(imageData))
                    {
                        return Image.FromStream(memoryStream);
                    }
                }
            }
            catch (Exception)
            {
                return Properties.Resources.Youtube_logo;
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OptionsForm form = new OptionsForm(isThumbnailShouldLoad);
            form.ShowDialog();
            isThumbnailShouldLoad = form.isThumbnailLoaded;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            groupBoxMain.Enabled = false;
            groupBoxMain.Visible = false;

            labelName.Text = "Name";
            labelDuration.Text = "Duration";
            comboBoxFormats.SelectedIndex = -1;
            pictureBoxVideo.Image = Properties.Resources.Youtube_logo;

            textBoxPath.Text = string.Empty;

            groupBoxStart.Enabled = true;
            groupBoxStart.Visible = true;
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            try
            {
                var saveFileDialog = new SaveFileDialog
                {
                    FileName = $"{_video.Title}.mp4",
                    Filter = "Video Files|*.mp4",
                    Title = "Save File"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveFileDialog.FileName;
                    textBoxPath.Text = filePath;

                    groupBoxStart.Enabled = true;
                    groupBoxStart.Visible = true;

                    groupBoxMain.Enabled = false;
                    groupBoxMain.Visible = false;

                    AddDownloadingToQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
