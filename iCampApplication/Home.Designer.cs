namespace iCampApplication
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.welcome_btn = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.header = new System.Windows.Forms.Panel();
            this.close_btn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.studentActivity_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.register_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.home_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.export_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.details_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.activityRegister_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.signup_up = new Bunifu.Framework.UI.BunifuFlatButton();
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
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(539, 308);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(316, 28);
            this.bunifuCustomLabel2.TabIndex = 21;
            this.bunifuCustomLabel2.Text = "Register/Select/Create new Session";
            this.bunifuCustomLabel2.Visible = false;
            // 
            // welcome_btn
            // 
            this.welcome_btn.AutoSize = true;
            this.welcome_btn.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.welcome_btn.Location = new System.Drawing.Point(549, 189);
            this.welcome_btn.Name = "welcome_btn";
            this.welcome_btn.Size = new System.Drawing.Size(294, 45);
            this.welcome_btn.TabIndex = 20;
            this.welcome_btn.Text = "Welcome to iCamp";
            this.welcome_btn.Visible = false;
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
            this.header.TabIndex = 23;
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
            this.panel1.Controls.Add(this.export_btn);
            this.panel1.Controls.Add(this.details_btn);
            this.panel1.Controls.Add(this.activityRegister_btn);
            this.panel1.Controls.Add(this.signup_up);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 661);
            this.panel1.TabIndex = 27;
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
            this.home_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
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
            this.home_btn.selected = true;
            this.home_btn.Size = new System.Drawing.Size(354, 59);
            this.home_btn.TabIndex = 7;
            this.home_btn.Text = "          Home";
            this.home_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_btn.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.home_btn.TextFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // export_btn
            // 
            this.export_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.export_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.export_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.export_btn.BorderRadius = 0;
            this.export_btn.ButtonText = "          Export";
            this.export_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.export_btn.DisabledColor = System.Drawing.Color.Gray;
            this.export_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.export_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("export_btn.Iconimage")));
            this.export_btn.Iconimage_right = null;
            this.export_btn.Iconimage_right_Selected = null;
            this.export_btn.Iconimage_Selected = null;
            this.export_btn.IconMarginLeft = 0;
            this.export_btn.IconMarginRight = 0;
            this.export_btn.IconRightVisible = true;
            this.export_btn.IconRightZoom = 0D;
            this.export_btn.IconVisible = true;
            this.export_btn.IconZoom = 65D;
            this.export_btn.IsTab = true;
            this.export_btn.Location = new System.Drawing.Point(-1, 587);
            this.export_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.export_btn.Name = "export_btn";
            this.export_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.export_btn.OnHovercolor = System.Drawing.Color.Empty;
            this.export_btn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.export_btn.selected = false;
            this.export_btn.Size = new System.Drawing.Size(354, 59);
            this.export_btn.TabIndex = 6;
            this.export_btn.Text = "          Export";
            this.export_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.export_btn.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.export_btn.TextFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.export_btn.Click += new System.EventHandler(this.export_btn_Click);
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
            // signup_up
            // 
            this.signup_up.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.signup_up.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.signup_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.signup_up.BorderRadius = 0;
            this.signup_up.ButtonText = "          Signup Sheet";
            this.signup_up.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_up.DisabledColor = System.Drawing.Color.Gray;
            this.signup_up.Iconcolor = System.Drawing.Color.Transparent;
            this.signup_up.Iconimage = ((System.Drawing.Image)(resources.GetObject("signup_up.Iconimage")));
            this.signup_up.Iconimage_right = null;
            this.signup_up.Iconimage_right_Selected = null;
            this.signup_up.Iconimage_Selected = null;
            this.signup_up.IconMarginLeft = 0;
            this.signup_up.IconMarginRight = 0;
            this.signup_up.IconRightVisible = true;
            this.signup_up.IconRightZoom = 0D;
            this.signup_up.IconVisible = true;
            this.signup_up.IconZoom = 65D;
            this.signup_up.IsTab = true;
            this.signup_up.Location = new System.Drawing.Point(-1, 286);
            this.signup_up.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.signup_up.Name = "signup_up";
            this.signup_up.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.signup_up.OnHovercolor = System.Drawing.Color.Empty;
            this.signup_up.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.signup_up.selected = false;
            this.signup_up.Size = new System.Drawing.Size(354, 59);
            this.signup_up.TabIndex = 3;
            this.signup_up.Text = "          Signup Sheet";
            this.signup_up.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signup_up.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.signup_up.TextFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_up.Click += new System.EventHandler(this.signup_btn_Click);
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
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1045, 713);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.welcome_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel welcome_btn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuImageButton close_btn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton studentActivity_btn;
        private Bunifu.Framework.UI.BunifuFlatButton register_btn;
        private Bunifu.Framework.UI.BunifuFlatButton home_btn;
        private Bunifu.Framework.UI.BunifuFlatButton export_btn;
        private Bunifu.Framework.UI.BunifuFlatButton details_btn;
        private Bunifu.Framework.UI.BunifuFlatButton activityRegister_btn;
        private Bunifu.Framework.UI.BunifuFlatButton signup_up;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

