namespace YoutubeConverterWinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlMain = new TabControl();
            tabPageDownload = new TabPage();
            groupBoxMain = new GroupBox();
            buttonFile = new Button();
            textBoxPath = new TextBox();
            buttonClose = new Button();
            labelDuration = new Label();
            labelName = new Label();
            pictureBoxVideo = new PictureBox();
            label2 = new Label();
            comboBoxFormats = new ComboBox();
            groupBoxStart = new GroupBox();
            youtubeLogo = new PictureBox();
            buttonFind = new Button();
            label1 = new Label();
            textBoxLink = new TextBox();
            tabPageQuery = new TabPage();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBoxTemplate = new GroupBox();
            labelStatusTemplate = new Label();
            labelDurationTemplate = new Label();
            labelNameTemplate = new Label();
            pictureBoxTemplate = new PictureBox();
            menuStrip1 = new MenuStrip();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            tabControlMain.SuspendLayout();
            tabPageDownload.SuspendLayout();
            groupBoxMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVideo).BeginInit();
            groupBoxStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)youtubeLogo).BeginInit();
            tabPageQuery.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBoxTemplate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTemplate).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPageDownload);
            tabControlMain.Controls.Add(tabPageQuery);
            tabControlMain.Location = new Point(12, 26);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(783, 427);
            tabControlMain.TabIndex = 0;
            // 
            // tabPageDownload
            // 
            tabPageDownload.Controls.Add(groupBoxMain);
            tabPageDownload.Controls.Add(groupBoxStart);
            tabPageDownload.Location = new Point(4, 24);
            tabPageDownload.Name = "tabPageDownload";
            tabPageDownload.Padding = new Padding(3);
            tabPageDownload.Size = new Size(775, 399);
            tabPageDownload.TabIndex = 0;
            tabPageDownload.Text = "Download";
            tabPageDownload.UseVisualStyleBackColor = true;
            // 
            // groupBoxMain
            // 
            groupBoxMain.Controls.Add(buttonFile);
            groupBoxMain.Controls.Add(textBoxPath);
            groupBoxMain.Controls.Add(buttonClose);
            groupBoxMain.Controls.Add(labelDuration);
            groupBoxMain.Controls.Add(labelName);
            groupBoxMain.Controls.Add(pictureBoxVideo);
            groupBoxMain.Controls.Add(label2);
            groupBoxMain.Controls.Add(comboBoxFormats);
            groupBoxMain.Enabled = false;
            groupBoxMain.Location = new Point(2, -1);
            groupBoxMain.Name = "groupBoxMain";
            groupBoxMain.Size = new Size(767, 409);
            groupBoxMain.TabIndex = 6;
            groupBoxMain.TabStop = false;
            groupBoxMain.Visible = false;
            // 
            // buttonFile
            // 
            buttonFile.Location = new Point(439, 116);
            buttonFile.Name = "buttonFile";
            buttonFile.Size = new Size(75, 23);
            buttonFile.TabIndex = 8;
            buttonFile.Text = "Choose file directory";
            buttonFile.UseVisualStyleBackColor = true;
            buttonFile.Click += buttonFile_Click;
            // 
            // textBoxPath
            // 
            textBoxPath.Location = new Point(439, 73);
            textBoxPath.Name = "textBoxPath";
            textBoxPath.ReadOnly = true;
            textBoxPath.Size = new Size(250, 23);
            textBoxPath.TabIndex = 7;
            // 
            // buttonClose
            // 
            buttonClose.Image = Properties.Resources.close_FILL0_wght400_GRAD0_opsz24;
            buttonClose.Location = new Point(727, 13);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(34, 31);
            buttonClose.TabIndex = 6;
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // labelDuration
            // 
            labelDuration.AutoSize = true;
            labelDuration.Location = new Point(93, 213);
            labelDuration.Name = "labelDuration";
            labelDuration.Size = new Size(53, 15);
            labelDuration.TabIndex = 5;
            labelDuration.Text = "Duration";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(93, 191);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 15);
            labelName.TabIndex = 3;
            labelName.Text = "Name";
            // 
            // pictureBoxVideo
            // 
            pictureBoxVideo.Location = new Point(93, 22);
            pictureBoxVideo.Name = "pictureBoxVideo";
            pictureBoxVideo.Size = new Size(281, 166);
            pictureBoxVideo.TabIndex = 2;
            pictureBoxVideo.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 270);
            label2.Name = "label2";
            label2.Size = new Size(155, 15);
            label2.TabIndex = 1;
            label2.Text = "Choose the right extension: ";
            // 
            // comboBoxFormats
            // 
            comboBoxFormats.FormattingEnabled = true;
            comboBoxFormats.Location = new Point(164, 304);
            comboBoxFormats.Name = "comboBoxFormats";
            comboBoxFormats.Size = new Size(125, 23);
            comboBoxFormats.TabIndex = 0;
            // 
            // groupBoxStart
            // 
            groupBoxStart.Controls.Add(youtubeLogo);
            groupBoxStart.Controls.Add(buttonFind);
            groupBoxStart.Controls.Add(label1);
            groupBoxStart.Controls.Add(textBoxLink);
            groupBoxStart.Location = new Point(3, -2);
            groupBoxStart.Name = "groupBoxStart";
            groupBoxStart.Size = new Size(767, 409);
            groupBoxStart.TabIndex = 4;
            groupBoxStart.TabStop = false;
            // 
            // youtubeLogo
            // 
            youtubeLogo.Image = Properties.Resources.Youtube_logo;
            youtubeLogo.InitialImage = Properties.Resources.Youtube_logo;
            youtubeLogo.Location = new Point(328, 107);
            youtubeLogo.Name = "youtubeLogo";
            youtubeLogo.Size = new Size(117, 72);
            youtubeLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            youtubeLogo.TabIndex = 7;
            youtubeLogo.TabStop = false;
            // 
            // buttonFind
            // 
            buttonFind.Location = new Point(347, 283);
            buttonFind.Name = "buttonFind";
            buttonFind.Size = new Size(75, 23);
            buttonFind.TabIndex = 6;
            buttonFind.Text = "Find";
            buttonFind.UseVisualStyleBackColor = true;
            buttonFind.Click += buttonFind_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(368, 205);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 5;
            label1.Text = "Link:";
            // 
            // textBoxLink
            // 
            textBoxLink.Location = new Point(188, 232);
            textBoxLink.Name = "textBoxLink";
            textBoxLink.PlaceholderText = "Paste your video link here";
            textBoxLink.Size = new Size(398, 23);
            textBoxLink.TabIndex = 4;
            // 
            // tabPageQuery
            // 
            tabPageQuery.Controls.Add(flowLayoutPanel1);
            tabPageQuery.Location = new Point(4, 24);
            tabPageQuery.Name = "tabPageQuery";
            tabPageQuery.Padding = new Padding(3);
            tabPageQuery.Size = new Size(775, 399);
            tabPageQuery.TabIndex = 1;
            tabPageQuery.Text = "Query";
            tabPageQuery.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(groupBoxTemplate);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(769, 393);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBoxTemplate
            // 
            groupBoxTemplate.Controls.Add(labelStatusTemplate);
            groupBoxTemplate.Controls.Add(labelDurationTemplate);
            groupBoxTemplate.Controls.Add(labelNameTemplate);
            groupBoxTemplate.Controls.Add(pictureBoxTemplate);
            groupBoxTemplate.Enabled = false;
            groupBoxTemplate.Location = new Point(3, 3);
            groupBoxTemplate.Name = "groupBoxTemplate";
            groupBoxTemplate.Size = new Size(763, 100);
            groupBoxTemplate.TabIndex = 2;
            groupBoxTemplate.TabStop = false;
            groupBoxTemplate.Visible = false;
            // 
            // labelStatusTemplate
            // 
            labelStatusTemplate.AutoSize = true;
            labelStatusTemplate.Location = new Point(563, 46);
            labelStatusTemplate.Name = "labelStatusTemplate";
            labelStatusTemplate.Size = new Size(87, 15);
            labelStatusTemplate.TabIndex = 3;
            labelStatusTemplate.Text = "Downloading...";
            // 
            // labelDurationTemplate
            // 
            labelDurationTemplate.AutoSize = true;
            labelDurationTemplate.Location = new Point(150, 62);
            labelDurationTemplate.Name = "labelDurationTemplate";
            labelDurationTemplate.Size = new Size(53, 15);
            labelDurationTemplate.TabIndex = 2;
            labelDurationTemplate.Text = "Duration";
            // 
            // labelNameTemplate
            // 
            labelNameTemplate.AutoSize = true;
            labelNameTemplate.Location = new Point(150, 34);
            labelNameTemplate.Name = "labelNameTemplate";
            labelNameTemplate.Size = new Size(39, 15);
            labelNameTemplate.TabIndex = 1;
            labelNameTemplate.Text = "Name";
            // 
            // pictureBoxTemplate
            // 
            pictureBoxTemplate.Location = new Point(6, 18);
            pictureBoxTemplate.Name = "pictureBoxTemplate";
            pictureBoxTemplate.Size = new Size(138, 72);
            pictureBoxTemplate.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTemplate.TabIndex = 0;
            pictureBoxTemplate.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { settingsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(807, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { optionsToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(61, 20);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            optionsToolStripMenuItem.Size = new Size(159, 22);
            optionsToolStripMenuItem.Text = "Options";
            optionsToolStripMenuItem.Click += optionsToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 465);
            Controls.Add(tabControlMain);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Youtube Converter";
            tabControlMain.ResumeLayout(false);
            tabPageDownload.ResumeLayout(false);
            groupBoxMain.ResumeLayout(false);
            groupBoxMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVideo).EndInit();
            groupBoxStart.ResumeLayout(false);
            groupBoxStart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)youtubeLogo).EndInit();
            tabPageQuery.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            groupBoxTemplate.ResumeLayout(false);
            groupBoxTemplate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTemplate).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabPageDownload;
        private TabPage tabPageQuery;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBoxStart;
        private PictureBox youtubeLogo;
        private Button buttonFind;
        private Label label1;
        private TextBox textBoxLink;
        private GroupBox groupBoxMain;
        private Label labelName;
        private PictureBox pictureBoxVideo;
        private Label label2;
        private ComboBox comboBoxFormats;
        private Label labelDuration;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private Button buttonClose;
        private TextBox textBoxPath;
        private Button buttonFile;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBoxTemplate;
        private PictureBox pictureBoxTemplate;
        private Label labelStatusTemplate;
        private Label labelDurationTemplate;
        private Label labelNameTemplate;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private GroupBox groupBox7;
        private GroupBox groupBox10;
        private GroupBox groupBox8;
        private GroupBox groupBox9;
        private GroupBox groupBox11;
        private GroupBox groupBox12;
        private GroupBox groupBox13;
    }
}
