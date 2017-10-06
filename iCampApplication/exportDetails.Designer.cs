namespace iCampApplication
{
    partial class exportDetails
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(exportDetails));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.close_btn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.studentActivity_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.register_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.home_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.exportDetail = new Bunifu.Framework.UI.BunifuFlatButton();
            this.details_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.activityRegister_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.signup_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.header.Controls.Add(this.close_btn);
            this.header.Controls.Add(this.bunifuCustomLabel1);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1045, 52);
            this.header.TabIndex = 31;
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.close_btn.Image = ((System.Drawing.Image)(resources.GetObject("close_btn.Image")));
            this.close_btn.ImageActive = null;
            this.close_btn.Location = new System.Drawing.Point(995, 9);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(38, 38);
            this.close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_btn.TabIndex = 3;
            this.close_btn.TabStop = false;
            this.close_btn.Zoom = 20;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(26, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(95, 30);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "iCamp";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.studentActivity_btn);
            this.panel1.Controls.Add(this.register_btn);
            this.panel1.Controls.Add(this.home_btn);
            this.panel1.Controls.Add(this.exportDetail);
            this.panel1.Controls.Add(this.details_btn);
            this.panel1.Controls.Add(this.activityRegister_btn);
            this.panel1.Controls.Add(this.signup_btn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 663);
            this.panel1.TabIndex = 32;
            // 
            // studentActivity_btn
            // 
            this.studentActivity_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.studentActivity_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.studentActivity_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.studentActivity_btn.BorderRadius = 0;
            this.studentActivity_btn.ButtonText = "          Student Activity";
            this.studentActivity_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.studentActivity_btn.DisabledColor = System.Drawing.Color.Gray;
            this.studentActivity_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.studentActivity_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("studentActivity_btn.Iconimage")));
            this.studentActivity_btn.Iconimage_right = null;
            this.studentActivity_btn.Iconimage_right_Selected = null;
            this.studentActivity_btn.Iconimage_Selected = null;
            this.studentActivity_btn.IconMarginLeft = 0;
            this.studentActivity_btn.IconMarginRight = 0;
            this.studentActivity_btn.IconRightVisible = true;
            this.studentActivity_btn.IconRightZoom = 0D;
            this.studentActivity_btn.IconVisible = true;
            this.studentActivity_btn.IconZoom = 65D;
            this.studentActivity_btn.IsTab = true;
            this.studentActivity_btn.Location = new System.Drawing.Point(0, 434);
            this.studentActivity_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.studentActivity_btn.Name = "studentActivity_btn";
            this.studentActivity_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.studentActivity_btn.OnHovercolor = System.Drawing.Color.Empty;
            this.studentActivity_btn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.studentActivity_btn.selected = false;
            this.studentActivity_btn.Size = new System.Drawing.Size(354, 59);
            this.studentActivity_btn.TabIndex = 9;
            this.studentActivity_btn.Text = "          Student Activity";
            this.studentActivity_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.studentActivity_btn.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.studentActivity_btn.TextFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentActivity_btn.Click += new System.EventHandler(this.studentActivity_btn_Click);
            // 
            // register_btn
            // 
            this.register_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.register_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.register_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.register_btn.BorderRadius = 0;
            this.register_btn.ButtonText = "          Register/Edit";
            this.register_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register_btn.DisabledColor = System.Drawing.Color.Gray;
            this.register_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.register_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("register_btn.Iconimage")));
            this.register_btn.Iconimage_right = null;
            this.register_btn.Iconimage_right_Selected = null;
            this.register_btn.Iconimage_Selected = null;
            this.register_btn.IconMarginLeft = 0;
            this.register_btn.IconMarginRight = 0;
            this.register_btn.IconRightVisible = true;
            this.register_btn.IconRightZoom = 0D;
            this.register_btn.IconVisible = true;
            this.register_btn.IconZoom = 65D;
            this.register_btn.IsTab = true;
            this.register_btn.Location = new System.Drawing.Point(0, 217);
            this.register_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.register_btn.Name = "register_btn";
            this.register_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.register_btn.OnHovercolor = System.Drawing.Color.Empty;
            this.register_btn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.register_btn.selected = false;
            this.register_btn.Size = new System.Drawing.Size(354, 59);
            this.register_btn.TabIndex = 8;
            this.register_btn.Text = "          Register/Edit";
            this.register_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.register_btn.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.register_btn.TextFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // home_btn
            // 
            this.home_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.home_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.home_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.home_btn.BorderRadius = 0;
            this.home_btn.ButtonText = "          Home";
            this.home_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home_btn.DisabledColor = System.Drawing.Color.Gray;
            this.home_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.home_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("home_btn.Iconimage")));
            this.home_btn.Iconimage_right = null;
            this.home_btn.Iconimage_right_Selected = null;
            this.home_btn.Iconimage_Selected = null;
            this.home_btn.IconMarginLeft = 0;
            this.home_btn.IconMarginRight = 0;
            this.home_btn.IconRightVisible = true;
            this.home_btn.IconRightZoom = 0D;
            this.home_btn.IconVisible = true;
            this.home_btn.IconZoom = 65D;
            this.home_btn.IsTab = true;
            this.home_btn.Location = new System.Drawing.Point(0, 147);
            this.home_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.home_btn.Name = "home_btn";
            this.home_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.home_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.home_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.home_btn.selected = false;
            this.home_btn.Size = new System.Drawing.Size(354, 59);
            this.home_btn.TabIndex = 7;
            this.home_btn.Text = "          Home";
            this.home_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_btn.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.home_btn.TextFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // exportDetail
            // 
            this.exportDetail.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.exportDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.exportDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exportDetail.BorderRadius = 0;
            this.exportDetail.ButtonText = "          Export";
            this.exportDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportDetail.DisabledColor = System.Drawing.Color.Gray;
            this.exportDetail.Iconcolor = System.Drawing.Color.Transparent;
            this.exportDetail.Iconimage = ((System.Drawing.Image)(resources.GetObject("exportDetail.Iconimage")));
            this.exportDetail.Iconimage_right = null;
            this.exportDetail.Iconimage_right_Selected = null;
            this.exportDetail.Iconimage_Selected = null;
            this.exportDetail.IconMarginLeft = 0;
            this.exportDetail.IconMarginRight = 0;
            this.exportDetail.IconRightVisible = true;
            this.exportDetail.IconRightZoom = 0D;
            this.exportDetail.IconVisible = true;
            this.exportDetail.IconZoom = 65D;
            this.exportDetail.IsTab = true;
            this.exportDetail.Location = new System.Drawing.Point(-1, 587);
            this.exportDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exportDetail.Name = "exportDetail";
            this.exportDetail.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.exportDetail.OnHovercolor = System.Drawing.Color.Empty;
            this.exportDetail.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.exportDetail.selected = true;
            this.exportDetail.Size = new System.Drawing.Size(354, 59);
            this.exportDetail.TabIndex = 6;
            this.exportDetail.Text = "          Export";
            this.exportDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exportDetail.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.exportDetail.TextFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportDetail.Click += new System.EventHandler(this.exportDetails_Click);
            // 
            // details_btn
            // 
            this.details_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.details_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.details_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.details_btn.BorderRadius = 0;
            this.details_btn.ButtonText = "          Details";
            this.details_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.details_btn.DisabledColor = System.Drawing.Color.Gray;
            this.details_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.details_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("details_btn.Iconimage")));
            this.details_btn.Iconimage_right = null;
            this.details_btn.Iconimage_right_Selected = null;
            this.details_btn.Iconimage_Selected = null;
            this.details_btn.IconMarginLeft = 0;
            this.details_btn.IconMarginRight = 0;
            this.details_btn.IconRightVisible = true;
            this.details_btn.IconRightZoom = 0D;
            this.details_btn.IconVisible = true;
            this.details_btn.IconZoom = 65D;
            this.details_btn.IsTab = true;
            this.details_btn.Location = new System.Drawing.Point(-1, 509);
            this.details_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.details_btn.Name = "details_btn";
            this.details_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.details_btn.OnHovercolor = System.Drawing.Color.Empty;
            this.details_btn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.details_btn.selected = false;
            this.details_btn.Size = new System.Drawing.Size(354, 59);
            this.details_btn.TabIndex = 5;
            this.details_btn.Text = "          Details";
            this.details_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.details_btn.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.details_btn.TextFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.details_btn.Click += new System.EventHandler(this.details_btn_Click);
            // 
            // activityRegister_btn
            // 
            this.activityRegister_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.activityRegister_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.activityRegister_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.activityRegister_btn.BorderRadius = 0;
            this.activityRegister_btn.ButtonText = "          Register Activity";
            this.activityRegister_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.activityRegister_btn.DisabledColor = System.Drawing.Color.Gray;
            this.activityRegister_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.activityRegister_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("activityRegister_btn.Iconimage")));
            this.activityRegister_btn.Iconimage_right = null;
            this.activityRegister_btn.Iconimage_right_Selected = null;
            this.activityRegister_btn.Iconimage_Selected = null;
            this.activityRegister_btn.IconMarginLeft = 0;
            this.activityRegister_btn.IconMarginRight = 0;
            this.activityRegister_btn.IconRightVisible = true;
            this.activityRegister_btn.IconRightZoom = 0D;
            this.activityRegister_btn.IconVisible = true;
            this.activityRegister_btn.IconZoom = 65D;
            this.activityRegister_btn.IsTab = true;
            this.activityRegister_btn.Location = new System.Drawing.Point(-1, 363);
            this.activityRegister_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activityRegister_btn.Name = "activityRegister_btn";
            this.activityRegister_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.activityRegister_btn.OnHovercolor = System.Drawing.Color.Empty;
            this.activityRegister_btn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.activityRegister_btn.selected = false;
            this.activityRegister_btn.Size = new System.Drawing.Size(354, 59);
            this.activityRegister_btn.TabIndex = 4;
            this.activityRegister_btn.Text = "          Register Activity";
            this.activityRegister_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.activityRegister_btn.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.activityRegister_btn.TextFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityRegister_btn.Click += new System.EventHandler(this.activityRegister_btn_Click);
            // 
            // signup_btn
            // 
            this.signup_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.signup_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.signup_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.signup_btn.BorderRadius = 0;
            this.signup_btn.ButtonText = "          Signup Sheet";
            this.signup_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_btn.DisabledColor = System.Drawing.Color.Gray;
            this.signup_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.signup_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("signup_btn.Iconimage")));
            this.signup_btn.Iconimage_right = null;
            this.signup_btn.Iconimage_right_Selected = null;
            this.signup_btn.Iconimage_Selected = null;
            this.signup_btn.IconMarginLeft = 0;
            this.signup_btn.IconMarginRight = 0;
            this.signup_btn.IconRightVisible = true;
            this.signup_btn.IconRightZoom = 0D;
            this.signup_btn.IconVisible = true;
            this.signup_btn.IconZoom = 65D;
            this.signup_btn.IsTab = true;
            this.signup_btn.Location = new System.Drawing.Point(-1, 286);
            this.signup_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.signup_btn.OnHovercolor = System.Drawing.Color.Empty;
            this.signup_btn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.signup_btn.selected = false;
            this.signup_btn.Size = new System.Drawing.Size(354, 59);
            this.signup_btn.TabIndex = 3;
            this.signup_btn.Text = "          Signup Sheet";
            this.signup_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signup_btn.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.signup_btn.TextFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // exportDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1045, 715);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "exportDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "exportDetails";
            this.Click += new System.EventHandler(this.exportDetails_Click);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuImageButton close_btn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton studentActivity_btn;
        private Bunifu.Framework.UI.BunifuFlatButton register_btn;
        private Bunifu.Framework.UI.BunifuFlatButton home_btn;
        private Bunifu.Framework.UI.BunifuFlatButton exportDetail;
        private Bunifu.Framework.UI.BunifuFlatButton details_btn;
        private Bunifu.Framework.UI.BunifuFlatButton activityRegister_btn;
        private Bunifu.Framework.UI.BunifuFlatButton signup_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}