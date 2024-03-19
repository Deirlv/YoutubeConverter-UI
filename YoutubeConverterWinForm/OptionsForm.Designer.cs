namespace YoutubeConverterWinForm
{
    partial class OptionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonSave = new Button();
            label1 = new Label();
            comboBoxThumbnails = new ComboBox();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(356, 246);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(130, 23);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Save the options";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 27);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 1;
            label1.Text = "Load the thumbnails:";
            // 
            // comboBoxThumbnails
            // 
            comboBoxThumbnails.FormattingEnabled = true;
            comboBoxThumbnails.Items.AddRange(new object[] { "Yes", "No" });
            comboBoxThumbnails.Location = new Point(148, 24);
            comboBoxThumbnails.Name = "comboBoxThumbnails";
            comboBoxThumbnails.Size = new Size(102, 23);
            comboBoxThumbnails.TabIndex = 2;
            // 
            // OptionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 281);
            Controls.Add(comboBoxThumbnails);
            Controls.Add(label1);
            Controls.Add(buttonSave);
            Name = "OptionsForm";
            Text = "OptionsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private Label label1;
        private ComboBox comboBoxThumbnails;
    }
}