
namespace STY_WebBrowser
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.browserpanel = new System.Windows.Forms.Panel();
            this.seclist = new System.Windows.Forms.ImageList(this.components);
            this.aboutbtn = new Bunifu.UI.WinForms.BunifuImageButton();
            this.stopbtn = new Bunifu.UI.WinForms.BunifuImageButton();
            this.homebtn = new Bunifu.UI.WinForms.BunifuImageButton();
            this.refreshbtn = new Bunifu.UI.WinForms.BunifuImageButton();
            this.forbtn = new Bunifu.UI.WinForms.BunifuImageButton();
            this.backbtn = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.loadingimg = new System.Windows.Forms.PictureBox();
            this.secimg = new System.Windows.Forms.PictureBox();
            this.urlbox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.panel1.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secimg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.aboutbtn);
            this.panel1.Controls.Add(this.stopbtn);
            this.panel1.Controls.Add(this.homebtn);
            this.panel1.Controls.Add(this.refreshbtn);
            this.panel1.Controls.Add(this.forbtn);
            this.panel1.Controls.Add(this.backbtn);
            this.panel1.Controls.Add(this.bunifuPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1231, 29);
            this.panel1.TabIndex = 0;
            // 
            // browserpanel
            // 
            this.browserpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.browserpanel.Location = new System.Drawing.Point(0, 29);
            this.browserpanel.Name = "browserpanel";
            this.browserpanel.Size = new System.Drawing.Size(1231, 631);
            this.browserpanel.TabIndex = 1;
            // 
            // seclist
            // 
            this.seclist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("seclist.ImageStream")));
            this.seclist.TransparentColor = System.Drawing.Color.Transparent;
            this.seclist.Images.SetKeyName(0, "icons8_check_lock_64.png");
            this.seclist.Images.SetKeyName(1, "icons8_delete_lock_64.png");
            // 
            // aboutbtn
            // 
            this.aboutbtn.ActiveImage = null;
            this.aboutbtn.AllowAnimations = true;
            this.aboutbtn.AllowBuffering = false;
            this.aboutbtn.AllowToggling = false;
            this.aboutbtn.AllowZooming = true;
            this.aboutbtn.AllowZoomingOnFocus = false;
            this.aboutbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutbtn.BackColor = System.Drawing.Color.Transparent;
            this.aboutbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.aboutbtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("aboutbtn.ErrorImage")));
            this.aboutbtn.FadeWhenInactive = false;
            this.aboutbtn.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.aboutbtn.Image = global::STY_WebBrowser.Properties.Resources.icons8_info_64;
            this.aboutbtn.ImageActive = null;
            this.aboutbtn.ImageLocation = null;
            this.aboutbtn.ImageMargin = 0;
            this.aboutbtn.ImageSize = new System.Drawing.Size(22, 22);
            this.aboutbtn.ImageZoomSize = new System.Drawing.Size(23, 23);
            this.aboutbtn.InitialImage = ((System.Drawing.Image)(resources.GetObject("aboutbtn.InitialImage")));
            this.aboutbtn.Location = new System.Drawing.Point(1203, 3);
            this.aboutbtn.Name = "aboutbtn";
            this.aboutbtn.Rotation = 0;
            this.aboutbtn.ShowActiveImage = true;
            this.aboutbtn.ShowCursorChanges = true;
            this.aboutbtn.ShowImageBorders = true;
            this.aboutbtn.ShowSizeMarkers = false;
            this.aboutbtn.Size = new System.Drawing.Size(23, 23);
            this.aboutbtn.TabIndex = 7;
            this.aboutbtn.ToolTipText = "Forward";
            this.aboutbtn.WaitOnLoad = false;
            this.aboutbtn.Zoom = 0;
            this.aboutbtn.ZoomSpeed = 10;
            this.aboutbtn.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // stopbtn
            // 
            this.stopbtn.ActiveImage = null;
            this.stopbtn.AllowAnimations = true;
            this.stopbtn.AllowBuffering = false;
            this.stopbtn.AllowToggling = false;
            this.stopbtn.AllowZooming = true;
            this.stopbtn.AllowZoomingOnFocus = false;
            this.stopbtn.BackColor = System.Drawing.Color.Transparent;
            this.stopbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.stopbtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("stopbtn.ErrorImage")));
            this.stopbtn.FadeWhenInactive = false;
            this.stopbtn.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.stopbtn.Image = global::STY_WebBrowser.Properties.Resources.icons8_Close_64;
            this.stopbtn.ImageActive = null;
            this.stopbtn.ImageLocation = null;
            this.stopbtn.ImageMargin = 0;
            this.stopbtn.ImageSize = new System.Drawing.Size(22, 22);
            this.stopbtn.ImageZoomSize = new System.Drawing.Size(23, 23);
            this.stopbtn.InitialImage = ((System.Drawing.Image)(resources.GetObject("stopbtn.InitialImage")));
            this.stopbtn.Location = new System.Drawing.Point(42, 4);
            this.stopbtn.Name = "stopbtn";
            this.stopbtn.Rotation = 0;
            this.stopbtn.ShowActiveImage = true;
            this.stopbtn.ShowCursorChanges = true;
            this.stopbtn.ShowImageBorders = true;
            this.stopbtn.ShowSizeMarkers = false;
            this.stopbtn.Size = new System.Drawing.Size(23, 23);
            this.stopbtn.TabIndex = 6;
            this.stopbtn.ToolTipText = "Stop";
            this.stopbtn.Visible = false;
            this.stopbtn.WaitOnLoad = false;
            this.stopbtn.Zoom = 0;
            this.stopbtn.ZoomSpeed = 10;
            this.stopbtn.Click += new System.EventHandler(this.stopbtn_Click);
            // 
            // homebtn
            // 
            this.homebtn.ActiveImage = null;
            this.homebtn.AllowAnimations = true;
            this.homebtn.AllowBuffering = false;
            this.homebtn.AllowToggling = false;
            this.homebtn.AllowZooming = true;
            this.homebtn.AllowZoomingOnFocus = false;
            this.homebtn.BackColor = System.Drawing.Color.Transparent;
            this.homebtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.homebtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("homebtn.ErrorImage")));
            this.homebtn.FadeWhenInactive = false;
            this.homebtn.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.homebtn.Image = global::STY_WebBrowser.Properties.Resources.icons8_home_screen_64;
            this.homebtn.ImageActive = null;
            this.homebtn.ImageLocation = null;
            this.homebtn.ImageMargin = 0;
            this.homebtn.ImageSize = new System.Drawing.Size(24, 24);
            this.homebtn.ImageZoomSize = new System.Drawing.Size(25, 25);
            this.homebtn.InitialImage = ((System.Drawing.Image)(resources.GetObject("homebtn.InitialImage")));
            this.homebtn.Location = new System.Drawing.Point(69, 3);
            this.homebtn.Name = "homebtn";
            this.homebtn.Rotation = 0;
            this.homebtn.ShowActiveImage = true;
            this.homebtn.ShowCursorChanges = true;
            this.homebtn.ShowImageBorders = true;
            this.homebtn.ShowSizeMarkers = false;
            this.homebtn.Size = new System.Drawing.Size(25, 25);
            this.homebtn.TabIndex = 5;
            this.homebtn.ToolTipText = "Home";
            this.homebtn.WaitOnLoad = false;
            this.homebtn.Zoom = 0;
            this.homebtn.ZoomSpeed = 10;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // refreshbtn
            // 
            this.refreshbtn.ActiveImage = null;
            this.refreshbtn.AllowAnimations = true;
            this.refreshbtn.AllowBuffering = false;
            this.refreshbtn.AllowToggling = false;
            this.refreshbtn.AllowZooming = true;
            this.refreshbtn.AllowZoomingOnFocus = false;
            this.refreshbtn.BackColor = System.Drawing.Color.Transparent;
            this.refreshbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.refreshbtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("refreshbtn.ErrorImage")));
            this.refreshbtn.FadeWhenInactive = false;
            this.refreshbtn.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.refreshbtn.Image = global::STY_WebBrowser.Properties.Resources.icons8_refresh_64;
            this.refreshbtn.ImageActive = null;
            this.refreshbtn.ImageLocation = null;
            this.refreshbtn.ImageMargin = 0;
            this.refreshbtn.ImageSize = new System.Drawing.Size(24, 24);
            this.refreshbtn.ImageZoomSize = new System.Drawing.Size(25, 25);
            this.refreshbtn.InitialImage = ((System.Drawing.Image)(resources.GetObject("refreshbtn.InitialImage")));
            this.refreshbtn.Location = new System.Drawing.Point(40, 3);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Rotation = 0;
            this.refreshbtn.ShowActiveImage = true;
            this.refreshbtn.ShowCursorChanges = true;
            this.refreshbtn.ShowImageBorders = true;
            this.refreshbtn.ShowSizeMarkers = false;
            this.refreshbtn.Size = new System.Drawing.Size(25, 25);
            this.refreshbtn.TabIndex = 4;
            this.refreshbtn.ToolTipText = "Refresh";
            this.refreshbtn.WaitOnLoad = false;
            this.refreshbtn.Zoom = 0;
            this.refreshbtn.ZoomSpeed = 10;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // forbtn
            // 
            this.forbtn.ActiveImage = null;
            this.forbtn.AllowAnimations = true;
            this.forbtn.AllowBuffering = false;
            this.forbtn.AllowToggling = false;
            this.forbtn.AllowZooming = true;
            this.forbtn.AllowZoomingOnFocus = false;
            this.forbtn.BackColor = System.Drawing.Color.Transparent;
            this.forbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.forbtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("forbtn.ErrorImage")));
            this.forbtn.FadeWhenInactive = false;
            this.forbtn.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.forbtn.Image = global::STY_WebBrowser.Properties.Resources.icons8_forward_64;
            this.forbtn.ImageActive = null;
            this.forbtn.ImageLocation = null;
            this.forbtn.ImageMargin = 0;
            this.forbtn.ImageSize = new System.Drawing.Size(22, 22);
            this.forbtn.ImageZoomSize = new System.Drawing.Size(23, 23);
            this.forbtn.InitialImage = ((System.Drawing.Image)(resources.GetObject("forbtn.InitialImage")));
            this.forbtn.Location = new System.Drawing.Point(98, 3);
            this.forbtn.Name = "forbtn";
            this.forbtn.Rotation = 0;
            this.forbtn.ShowActiveImage = true;
            this.forbtn.ShowCursorChanges = true;
            this.forbtn.ShowImageBorders = true;
            this.forbtn.ShowSizeMarkers = false;
            this.forbtn.Size = new System.Drawing.Size(23, 23);
            this.forbtn.TabIndex = 3;
            this.forbtn.ToolTipText = "Forward";
            this.forbtn.WaitOnLoad = false;
            this.forbtn.Zoom = 0;
            this.forbtn.ZoomSpeed = 10;
            this.forbtn.Click += new System.EventHandler(this.forbtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.ActiveImage = null;
            this.backbtn.AllowAnimations = true;
            this.backbtn.AllowBuffering = false;
            this.backbtn.AllowToggling = false;
            this.backbtn.AllowZooming = true;
            this.backbtn.AllowZoomingOnFocus = false;
            this.backbtn.BackColor = System.Drawing.Color.Transparent;
            this.backbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.backbtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("backbtn.ErrorImage")));
            this.backbtn.FadeWhenInactive = false;
            this.backbtn.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.backbtn.Image = global::STY_WebBrowser.Properties.Resources.icons8_back_64;
            this.backbtn.ImageActive = null;
            this.backbtn.ImageLocation = null;
            this.backbtn.ImageMargin = 0;
            this.backbtn.ImageSize = new System.Drawing.Size(22, 22);
            this.backbtn.ImageZoomSize = new System.Drawing.Size(23, 23);
            this.backbtn.InitialImage = ((System.Drawing.Image)(resources.GetObject("backbtn.InitialImage")));
            this.backbtn.Location = new System.Drawing.Point(12, 3);
            this.backbtn.Name = "backbtn";
            this.backbtn.Rotation = 0;
            this.backbtn.ShowActiveImage = true;
            this.backbtn.ShowCursorChanges = true;
            this.backbtn.ShowImageBorders = true;
            this.backbtn.ShowSizeMarkers = false;
            this.backbtn.Size = new System.Drawing.Size(23, 23);
            this.backbtn.TabIndex = 2;
            this.backbtn.ToolTipText = "Back";
            this.backbtn.WaitOnLoad = false;
            this.backbtn.Zoom = 0;
            this.backbtn.ZoomSpeed = 10;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Silver;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 15;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.loadingimg);
            this.bunifuPanel1.Controls.Add(this.secimg);
            this.bunifuPanel1.Controls.Add(this.urlbox);
            this.bunifuPanel1.Location = new System.Drawing.Point(127, 2);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(988, 25);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // loadingimg
            // 
            this.loadingimg.BackColor = System.Drawing.Color.Transparent;
            this.loadingimg.Image = global::STY_WebBrowser.Properties.Resources._805;
            this.loadingimg.Location = new System.Drawing.Point(7, 3);
            this.loadingimg.Name = "loadingimg";
            this.loadingimg.Size = new System.Drawing.Size(20, 20);
            this.loadingimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadingimg.TabIndex = 0;
            this.loadingimg.TabStop = false;
            this.loadingimg.Visible = false;
            // 
            // secimg
            // 
            this.secimg.BackColor = System.Drawing.Color.Transparent;
            this.secimg.Location = new System.Drawing.Point(7, 3);
            this.secimg.Name = "secimg";
            this.secimg.Size = new System.Drawing.Size(19, 19);
            this.secimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.secimg.TabIndex = 0;
            this.secimg.TabStop = false;
            // 
            // urlbox
            // 
            this.urlbox.AcceptsReturn = false;
            this.urlbox.AcceptsTab = false;
            this.urlbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlbox.AnimationSpeed = 200;
            this.urlbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.urlbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.urlbox.BackColor = System.Drawing.Color.Transparent;
            this.urlbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("urlbox.BackgroundImage")));
            this.urlbox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.urlbox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.urlbox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.urlbox.BorderColorIdle = System.Drawing.Color.Silver;
            this.urlbox.BorderRadius = 10;
            this.urlbox.BorderThickness = -1;
            this.urlbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.urlbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.urlbox.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.urlbox.DefaultText = "";
            this.urlbox.FillColor = System.Drawing.Color.White;
            this.urlbox.HideSelection = true;
            this.urlbox.IconLeft = null;
            this.urlbox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.urlbox.IconPadding = 10;
            this.urlbox.IconRight = null;
            this.urlbox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.urlbox.Lines = new string[0];
            this.urlbox.Location = new System.Drawing.Point(31, 5);
            this.urlbox.MaxLength = 32767;
            this.urlbox.MinimumSize = new System.Drawing.Size(1, 1);
            this.urlbox.Modified = false;
            this.urlbox.Multiline = false;
            this.urlbox.Name = "urlbox";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.urlbox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.urlbox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.urlbox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.urlbox.OnIdleState = stateProperties4;
            this.urlbox.Padding = new System.Windows.Forms.Padding(3);
            this.urlbox.PasswordChar = '\0';
            this.urlbox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.urlbox.PlaceholderText = "Enter text";
            this.urlbox.ReadOnly = false;
            this.urlbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.urlbox.SelectedText = "";
            this.urlbox.SelectionLength = 0;
            this.urlbox.SelectionStart = 0;
            this.urlbox.ShortcutsEnabled = true;
            this.urlbox.Size = new System.Drawing.Size(952, 15);
            this.urlbox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.urlbox.TabIndex = 0;
            this.urlbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.urlbox.TextMarginBottom = 0;
            this.urlbox.TextMarginLeft = 3;
            this.urlbox.TextMarginTop = 0;
            this.urlbox.TextPlaceholder = "Enter text";
            this.urlbox.UseSystemPasswordChar = false;
            this.urlbox.WordWrap = true;
            this.urlbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.urlbox_KeyUp);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 659);
            this.Controls.Add(this.browserpanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loadingimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secimg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuTextBox urlbox;
        private Bunifu.UI.WinForms.BunifuImageButton backbtn;
        private Bunifu.UI.WinForms.BunifuImageButton forbtn;
        private Bunifu.UI.WinForms.BunifuImageButton refreshbtn;
        private System.Windows.Forms.Panel browserpanel;
        private System.Windows.Forms.PictureBox loadingimg;
        private Bunifu.UI.WinForms.BunifuImageButton homebtn;
        private Bunifu.UI.WinForms.BunifuImageButton stopbtn;
        private System.Windows.Forms.PictureBox secimg;
        private System.Windows.Forms.ImageList seclist;
        private Bunifu.UI.WinForms.BunifuImageButton aboutbtn;
    }
}

