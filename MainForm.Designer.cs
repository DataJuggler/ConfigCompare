
namespace ConfigCompare
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SourceControl = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            this.TargetControl = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            this.CompareButton = new DataJuggler.Win.Controls.Button();
            this.ResultsListBox = new System.Windows.Forms.ListBox();
            this.CopyButton = new DataJuggler.Win.Controls.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SourceControl
            // 
            this.SourceControl.BackColor = System.Drawing.Color.Transparent;
            this.SourceControl.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.File;
            this.SourceControl.ButtonColor = System.Drawing.Color.LemonChiffon;
            this.SourceControl.ButtonImage = ((System.Drawing.Image)(resources.GetObject("SourceControl.ButtonImage")));
            this.SourceControl.ButtonWidth = 48;
            this.SourceControl.DarkMode = false;
            this.SourceControl.DisabledLabelColor = System.Drawing.Color.Empty;
            this.SourceControl.Editable = true;
            this.SourceControl.EnabledLabelColor = System.Drawing.Color.Empty;
            this.SourceControl.Filter = null;
            this.SourceControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SourceControl.HideBrowseButton = false;
            this.SourceControl.LabelBottomMargin = 0;
            this.SourceControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.SourceControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SourceControl.LabelText = "Source:";
            this.SourceControl.LabelTopMargin = 0;
            this.SourceControl.LabelWidth = 80;
            this.SourceControl.Location = new System.Drawing.Point(24, 16);
            this.SourceControl.Name = "SourceControl";
            this.SourceControl.OnTextChangedListener = null;
            this.SourceControl.OpenCallback = null;
            this.SourceControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SourceControl.SelectedPath = null;
            this.SourceControl.Size = new System.Drawing.Size(746, 32);
            this.SourceControl.StartPath = null;
            this.SourceControl.TabIndex = 0;
            this.SourceControl.TextBoxBottomMargin = 0;
            this.SourceControl.TextBoxDisabledColor = System.Drawing.Color.Empty;
            this.SourceControl.TextBoxEditableColor = System.Drawing.Color.Empty;
            this.SourceControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SourceControl.TextBoxTopMargin = 0;
            this.SourceControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // TargetControl
            // 
            this.TargetControl.BackColor = System.Drawing.Color.Transparent;
            this.TargetControl.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.File;
            this.TargetControl.ButtonColor = System.Drawing.Color.LemonChiffon;
            this.TargetControl.ButtonImage = ((System.Drawing.Image)(resources.GetObject("TargetControl.ButtonImage")));
            this.TargetControl.ButtonWidth = 48;
            this.TargetControl.DarkMode = false;
            this.TargetControl.DisabledLabelColor = System.Drawing.Color.Empty;
            this.TargetControl.Editable = true;
            this.TargetControl.EnabledLabelColor = System.Drawing.Color.Empty;
            this.TargetControl.Filter = null;
            this.TargetControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TargetControl.HideBrowseButton = false;
            this.TargetControl.LabelBottomMargin = 0;
            this.TargetControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.TargetControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TargetControl.LabelText = "Target:";
            this.TargetControl.LabelTopMargin = 0;
            this.TargetControl.LabelWidth = 80;
            this.TargetControl.Location = new System.Drawing.Point(24, 80);
            this.TargetControl.Name = "TargetControl";
            this.TargetControl.OnTextChangedListener = null;
            this.TargetControl.OpenCallback = null;
            this.TargetControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TargetControl.SelectedPath = null;
            this.TargetControl.Size = new System.Drawing.Size(746, 32);
            this.TargetControl.StartPath = null;
            this.TargetControl.TabIndex = 1;
            this.TargetControl.TextBoxBottomMargin = 0;
            this.TargetControl.TextBoxDisabledColor = System.Drawing.Color.Empty;
            this.TargetControl.TextBoxEditableColor = System.Drawing.Color.Empty;
            this.TargetControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TargetControl.TextBoxTopMargin = 0;
            this.TargetControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // CompareButton
            // 
            this.CompareButton.BackColor = System.Drawing.Color.Transparent;
            this.CompareButton.ButtonText = "Compare";
            this.CompareButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CompareButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CompareButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.CompareButton.Location = new System.Drawing.Point(626, 131);
            this.CompareButton.Margin = new System.Windows.Forms.Padding(4);
            this.CompareButton.Name = "CompareButton";
            this.CompareButton.Size = new System.Drawing.Size(144, 48);
            this.CompareButton.TabIndex = 2;
            this.CompareButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            this.CompareButton.Click += new System.EventHandler(this.CompareButton_Click);
            // 
            // ResultsListBox
            // 
            this.ResultsListBox.FormattingEnabled = true;
            this.ResultsListBox.ItemHeight = 18;
            this.ResultsListBox.Location = new System.Drawing.Point(24, 211);
            this.ResultsListBox.Name = "ResultsListBox";
            this.ResultsListBox.Size = new System.Drawing.Size(746, 292);
            this.ResultsListBox.TabIndex = 3;
            // 
            // CopyButton
            // 
            this.CopyButton.BackColor = System.Drawing.Color.Transparent;
            this.CopyButton.ButtonText = "Copy";
            this.CopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CopyButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.CopyButton.Location = new System.Drawing.Point(626, 540);
            this.CopyButton.Margin = new System.Windows.Forms.Padding(4);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(144, 48);
            this.CopyButton.TabIndex = 4;
            this.CopyButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.StatusLabel.Location = new System.Drawing.Point(24, 512);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(499, 34);
            this.StatusLabel.TabIndex = 5;
            this.StatusLabel.Text = "Ready.";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::ConfigCompare.Properties.Resources.BlackImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 630);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.ResultsListBox);
            this.Controls.Add(this.CompareButton);
            this.Controls.Add(this.TargetControl);
            this.Controls.Add(this.SourceControl);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Config Compare";
            this.ResumeLayout(false);

        }

        #endregion

        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl SourceControl;
        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl TargetControl;
        private DataJuggler.Win.Controls.Button CompareButton;
        private System.Windows.Forms.ListBox ResultsListBox;
        private DataJuggler.Win.Controls.Button CopyButton;
        private System.Windows.Forms.Label StatusLabel;
    }
}

