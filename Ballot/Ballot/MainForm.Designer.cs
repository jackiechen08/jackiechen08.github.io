namespace Ballot
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listBoxMessage = new System.Windows.Forms.ListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.listViewResult = new System.Windows.Forms.ListView();
            this.columnNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnYoung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnOld = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFamily = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.pictureBoxAnimation1 = new System.Windows.Forms.PictureBox();
            this.imageListpic1 = new System.Windows.Forms.ImageList(this.components);
            this.timerpic1 = new System.Windows.Forms.Timer(this.components);
            this.timerpic2 = new System.Windows.Forms.Timer(this.components);
            this.imageListpic2 = new System.Windows.Forms.ImageList(this.components);
            this.timerpic3 = new System.Windows.Forms.Timer(this.components);
            this.imageListpic3 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBoxAnimation3 = new System.Windows.Forms.PictureBox();
            this.timerpic4 = new System.Windows.Forms.Timer(this.components);
            this.imageListpic4 = new System.Windows.Forms.ImageList(this.components);
            this.timerpic5 = new System.Windows.Forms.Timer(this.components);
            this.imageListpic5 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBoxAnimation5 = new System.Windows.Forms.PictureBox();
            this.imageListpic6 = new System.Windows.Forms.ImageList(this.components);
            this.timerpic6 = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxAnimation7 = new System.Windows.Forms.PictureBox();
            this.timerpic7 = new System.Windows.Forms.Timer(this.components);
            this.imageListpic7 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBoxAnimation6 = new System.Windows.Forms.PictureBox();
            this.pictureBoxAnimation4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxYoung = new System.Windows.Forms.PictureBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.timerShowpic = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxAnimation2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxResult = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnimation1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnimation3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnimation5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnimation7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnimation6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnimation4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYoung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnimation2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxMessage
            // 
            this.listBoxMessage.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.listBoxMessage.FormattingEnabled = true;
            this.listBoxMessage.ItemHeight = 12;
            this.listBoxMessage.Location = new System.Drawing.Point(847, 0);
            this.listBoxMessage.Name = "listBoxMessage";
            this.listBoxMessage.Size = new System.Drawing.Size(105, 136);
            this.listBoxMessage.TabIndex = 0;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "文字檔|*.txt*|C#文件|*.cs|所有檔|*.*";
            // 
            // listViewResult
            // 
            this.listViewResult.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listViewResult.BackgroundImage")));
            this.listViewResult.BackgroundImageTiled = true;
            this.listViewResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNumber,
            this.columnYoung,
            this.columnOld,
            this.columnFamily});
            this.listViewResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listViewResult.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listViewResult.FullRowSelect = true;
            this.listViewResult.Location = new System.Drawing.Point(954, 467);
            this.listViewResult.Name = "listViewResult";
            this.listViewResult.Size = new System.Drawing.Size(371, 221);
            this.listViewResult.TabIndex = 7;
            this.listViewResult.UseCompatibleStateImageBehavior = false;
            this.listViewResult.View = System.Windows.Forms.View.Details;
            this.listViewResult.DoubleClick += new System.EventHandler(this.listViewResult_DoubleClick);
            // 
            // columnNumber
            // 
            this.columnNumber.Text = "序號";
            this.columnNumber.Width = 50;
            // 
            // columnYoung
            // 
            this.columnYoung.Text = "學弟\\妹";
            this.columnYoung.Width = 100;
            // 
            // columnOld
            // 
            this.columnOld.Text = "學長\\姊";
            this.columnOld.Width = 100;
            // 
            // columnFamily
            // 
            this.columnFamily.Text = "家族";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(648, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 43);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(673, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 48);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(785, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 189);
            this.button3.TabIndex = 11;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(648, 215);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 102);
            this.button4.TabIndex = 12;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(496, 150);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 157);
            this.button5.TabIndex = 13;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(602, 323);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(167, 179);
            this.button6.TabIndex = 14;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(547, 526);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(274, 162);
            this.button7.TabIndex = 15;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // pictureBoxAnimation1
            // 
            this.pictureBoxAnimation1.Location = new System.Drawing.Point(1155, 267);
            this.pictureBoxAnimation1.Name = "pictureBoxAnimation1";
            this.pictureBoxAnimation1.Size = new System.Drawing.Size(198, 188);
            this.pictureBoxAnimation1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAnimation1.TabIndex = 16;
            this.pictureBoxAnimation1.TabStop = false;
            // 
            // imageListpic1
            // 
            this.imageListpic1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListpic1.ImageStream")));
            this.imageListpic1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListpic1.Images.SetKeyName(0, "1.png");
            this.imageListpic1.Images.SetKeyName(1, "2.png");
            this.imageListpic1.Images.SetKeyName(2, "3.png");
            this.imageListpic1.Images.SetKeyName(3, "4.png");
            this.imageListpic1.Images.SetKeyName(4, "5.png");
            this.imageListpic1.Images.SetKeyName(5, "6.png");
            this.imageListpic1.Images.SetKeyName(6, "7.png");
            this.imageListpic1.Images.SetKeyName(7, "8.png");
            this.imageListpic1.Images.SetKeyName(8, "9.png");
            this.imageListpic1.Images.SetKeyName(9, "10.png");
            this.imageListpic1.Images.SetKeyName(10, "11.png");
            this.imageListpic1.Images.SetKeyName(11, "12.png");
            this.imageListpic1.Images.SetKeyName(12, "13.png");
            this.imageListpic1.Images.SetKeyName(13, "14.png");
            this.imageListpic1.Images.SetKeyName(14, "15.png");
            this.imageListpic1.Images.SetKeyName(15, "16.png");
            this.imageListpic1.Images.SetKeyName(16, "17.png");
            this.imageListpic1.Images.SetKeyName(17, "18.png");
            this.imageListpic1.Images.SetKeyName(18, "19.png");
            this.imageListpic1.Images.SetKeyName(19, "20.png");
            this.imageListpic1.Images.SetKeyName(20, "21.png");
            this.imageListpic1.Images.SetKeyName(21, "22.png");
            this.imageListpic1.Images.SetKeyName(22, "23.png");
            this.imageListpic1.Images.SetKeyName(23, "24.png");
            this.imageListpic1.Images.SetKeyName(24, "25.png");
            this.imageListpic1.Images.SetKeyName(25, "26.png");
            this.imageListpic1.Images.SetKeyName(26, "27.png");
            this.imageListpic1.Images.SetKeyName(27, "28.png");
            this.imageListpic1.Images.SetKeyName(28, "29.png");
            this.imageListpic1.Images.SetKeyName(29, "30.png");
            this.imageListpic1.Images.SetKeyName(30, "31.png");
            this.imageListpic1.Images.SetKeyName(31, "32.png");
            this.imageListpic1.Images.SetKeyName(32, "33.png");
            this.imageListpic1.Images.SetKeyName(33, "34.png");
            this.imageListpic1.Images.SetKeyName(34, "35.png");
            this.imageListpic1.Images.SetKeyName(35, "36.png");
            this.imageListpic1.Images.SetKeyName(36, "37.png");
            this.imageListpic1.Images.SetKeyName(37, "38.png");
            this.imageListpic1.Images.SetKeyName(38, "39.png");
            this.imageListpic1.Images.SetKeyName(39, "40.png");
            this.imageListpic1.Images.SetKeyName(40, "41.png");
            this.imageListpic1.Images.SetKeyName(41, "42.png");
            this.imageListpic1.Images.SetKeyName(42, "43.png");
            this.imageListpic1.Images.SetKeyName(43, "44.png");
            this.imageListpic1.Images.SetKeyName(44, "45.png");
            this.imageListpic1.Images.SetKeyName(45, "46.png");
            this.imageListpic1.Images.SetKeyName(46, "47.png");
            this.imageListpic1.Images.SetKeyName(47, "48.png");
            this.imageListpic1.Images.SetKeyName(48, "49.png");
            this.imageListpic1.Images.SetKeyName(49, "50.png");
            this.imageListpic1.Images.SetKeyName(50, "51.png");
            this.imageListpic1.Images.SetKeyName(51, "52.png");
            this.imageListpic1.Images.SetKeyName(52, "53.png");
            this.imageListpic1.Images.SetKeyName(53, "54.png");
            this.imageListpic1.Images.SetKeyName(54, "55.png");
            this.imageListpic1.Images.SetKeyName(55, "56.png");
            this.imageListpic1.Images.SetKeyName(56, "57.png");
            this.imageListpic1.Images.SetKeyName(57, "60.jpg");
            this.imageListpic1.Images.SetKeyName(58, "60.jpg");
            this.imageListpic1.Images.SetKeyName(59, "60.jpg");
            this.imageListpic1.Images.SetKeyName(60, "60.jpg");
            // 
            // timerpic1
            // 
            this.timerpic1.Interval = 60;
            this.timerpic1.Tick += new System.EventHandler(this.timerpic1_Tick);
            // 
            // timerpic2
            // 
            this.timerpic2.Interval = 60;
            this.timerpic2.Tick += new System.EventHandler(this.timerpic2_Tick);
            // 
            // imageListpic2
            // 
            this.imageListpic2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListpic2.ImageStream")));
            this.imageListpic2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListpic2.Images.SetKeyName(0, "1.png");
            this.imageListpic2.Images.SetKeyName(1, "2.png");
            this.imageListpic2.Images.SetKeyName(2, "2.png");
            this.imageListpic2.Images.SetKeyName(3, "3.png");
            this.imageListpic2.Images.SetKeyName(4, "4.png");
            this.imageListpic2.Images.SetKeyName(5, "5.png");
            this.imageListpic2.Images.SetKeyName(6, "6.png");
            this.imageListpic2.Images.SetKeyName(7, "7.png");
            this.imageListpic2.Images.SetKeyName(8, "8.png");
            this.imageListpic2.Images.SetKeyName(9, "9.png");
            this.imageListpic2.Images.SetKeyName(10, "10.png");
            this.imageListpic2.Images.SetKeyName(11, "11.png");
            this.imageListpic2.Images.SetKeyName(12, "12.png");
            this.imageListpic2.Images.SetKeyName(13, "13.png");
            this.imageListpic2.Images.SetKeyName(14, "14.png");
            this.imageListpic2.Images.SetKeyName(15, "15.png");
            this.imageListpic2.Images.SetKeyName(16, "16.png");
            this.imageListpic2.Images.SetKeyName(17, "17.png");
            this.imageListpic2.Images.SetKeyName(18, "18.png");
            this.imageListpic2.Images.SetKeyName(19, "19.png");
            this.imageListpic2.Images.SetKeyName(20, "20.png");
            this.imageListpic2.Images.SetKeyName(21, "21.png");
            this.imageListpic2.Images.SetKeyName(22, "22.png");
            this.imageListpic2.Images.SetKeyName(23, "23.png");
            this.imageListpic2.Images.SetKeyName(24, "24.png");
            this.imageListpic2.Images.SetKeyName(25, "25.png");
            this.imageListpic2.Images.SetKeyName(26, "26.png");
            this.imageListpic2.Images.SetKeyName(27, "27.png");
            this.imageListpic2.Images.SetKeyName(28, "28.png");
            this.imageListpic2.Images.SetKeyName(29, "29.png");
            this.imageListpic2.Images.SetKeyName(30, "30.png");
            this.imageListpic2.Images.SetKeyName(31, "31.png");
            this.imageListpic2.Images.SetKeyName(32, "32.png");
            this.imageListpic2.Images.SetKeyName(33, "33.png");
            this.imageListpic2.Images.SetKeyName(34, "33.png");
            this.imageListpic2.Images.SetKeyName(35, "33.png");
            this.imageListpic2.Images.SetKeyName(36, "33.png");
            this.imageListpic2.Images.SetKeyName(37, "33.png");
            this.imageListpic2.Images.SetKeyName(38, "34.png");
            this.imageListpic2.Images.SetKeyName(39, "34.png");
            this.imageListpic2.Images.SetKeyName(40, "34.png");
            this.imageListpic2.Images.SetKeyName(41, "35.png");
            this.imageListpic2.Images.SetKeyName(42, "35.png");
            this.imageListpic2.Images.SetKeyName(43, "35.png");
            this.imageListpic2.Images.SetKeyName(44, "36.png");
            this.imageListpic2.Images.SetKeyName(45, "36.png");
            this.imageListpic2.Images.SetKeyName(46, "36.png");
            this.imageListpic2.Images.SetKeyName(47, "37.png");
            this.imageListpic2.Images.SetKeyName(48, "37.png");
            this.imageListpic2.Images.SetKeyName(49, "37.png");
            // 
            // timerpic3
            // 
            this.timerpic3.Interval = 60;
            this.timerpic3.Tick += new System.EventHandler(this.timerpic3_Tick);
            // 
            // imageListpic3
            // 
            this.imageListpic3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListpic3.ImageStream")));
            this.imageListpic3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListpic3.Images.SetKeyName(0, "1.png");
            this.imageListpic3.Images.SetKeyName(1, "2.png");
            this.imageListpic3.Images.SetKeyName(2, "3.png");
            this.imageListpic3.Images.SetKeyName(3, "4.png");
            this.imageListpic3.Images.SetKeyName(4, "5.png");
            this.imageListpic3.Images.SetKeyName(5, "5.png");
            this.imageListpic3.Images.SetKeyName(6, "6.png");
            this.imageListpic3.Images.SetKeyName(7, "7.png");
            this.imageListpic3.Images.SetKeyName(8, "8.png");
            this.imageListpic3.Images.SetKeyName(9, "9.png");
            this.imageListpic3.Images.SetKeyName(10, "10.png");
            this.imageListpic3.Images.SetKeyName(11, "11.png");
            this.imageListpic3.Images.SetKeyName(12, "12.png");
            this.imageListpic3.Images.SetKeyName(13, "13.png");
            this.imageListpic3.Images.SetKeyName(14, "14.png");
            this.imageListpic3.Images.SetKeyName(15, "15.png");
            this.imageListpic3.Images.SetKeyName(16, "16.png");
            this.imageListpic3.Images.SetKeyName(17, "17.png");
            this.imageListpic3.Images.SetKeyName(18, "18.png");
            this.imageListpic3.Images.SetKeyName(19, "19.png");
            this.imageListpic3.Images.SetKeyName(20, "20.png");
            this.imageListpic3.Images.SetKeyName(21, "21.png");
            this.imageListpic3.Images.SetKeyName(22, "22.png");
            this.imageListpic3.Images.SetKeyName(23, "23.png");
            this.imageListpic3.Images.SetKeyName(24, "24.png");
            this.imageListpic3.Images.SetKeyName(25, "25.png");
            this.imageListpic3.Images.SetKeyName(26, "26.png");
            this.imageListpic3.Images.SetKeyName(27, "27.png");
            this.imageListpic3.Images.SetKeyName(28, "28.png");
            this.imageListpic3.Images.SetKeyName(29, "29.png");
            this.imageListpic3.Images.SetKeyName(30, "30.png");
            this.imageListpic3.Images.SetKeyName(31, "31.png");
            this.imageListpic3.Images.SetKeyName(32, "32.png");
            this.imageListpic3.Images.SetKeyName(33, "33.png");
            this.imageListpic3.Images.SetKeyName(34, "34.png");
            this.imageListpic3.Images.SetKeyName(35, "35.png");
            this.imageListpic3.Images.SetKeyName(36, "36.png");
            this.imageListpic3.Images.SetKeyName(37, "37.png");
            this.imageListpic3.Images.SetKeyName(38, "38.png");
            this.imageListpic3.Images.SetKeyName(39, "39.png");
            this.imageListpic3.Images.SetKeyName(40, "40.png");
            this.imageListpic3.Images.SetKeyName(41, "41.png");
            this.imageListpic3.Images.SetKeyName(42, "42.png");
            this.imageListpic3.Images.SetKeyName(43, "43.png");
            this.imageListpic3.Images.SetKeyName(44, "44.png");
            this.imageListpic3.Images.SetKeyName(45, "45.png");
            this.imageListpic3.Images.SetKeyName(46, "46.png");
            this.imageListpic3.Images.SetKeyName(47, "47.png");
            this.imageListpic3.Images.SetKeyName(48, "48.png");
            this.imageListpic3.Images.SetKeyName(49, "49.png");
            this.imageListpic3.Images.SetKeyName(50, "50.png");
            this.imageListpic3.Images.SetKeyName(51, "51.png");
            this.imageListpic3.Images.SetKeyName(52, "52.png");
            this.imageListpic3.Images.SetKeyName(53, "53.png");
            this.imageListpic3.Images.SetKeyName(54, "54.png");
            this.imageListpic3.Images.SetKeyName(55, "55.png");
            this.imageListpic3.Images.SetKeyName(56, "56.png");
            this.imageListpic3.Images.SetKeyName(57, "57.png");
            this.imageListpic3.Images.SetKeyName(58, "58.png");
            this.imageListpic3.Images.SetKeyName(59, "59.png");
            this.imageListpic3.Images.SetKeyName(60, "60.png");
            this.imageListpic3.Images.SetKeyName(61, "61.png");
            this.imageListpic3.Images.SetKeyName(62, "62.png");
            this.imageListpic3.Images.SetKeyName(63, "63.png");
            this.imageListpic3.Images.SetKeyName(64, "64.png");
            this.imageListpic3.Images.SetKeyName(65, "65.png");
            this.imageListpic3.Images.SetKeyName(66, "66.png");
            this.imageListpic3.Images.SetKeyName(67, "67.png");
            this.imageListpic3.Images.SetKeyName(68, "68.png");
            this.imageListpic3.Images.SetKeyName(69, "69.png");
            this.imageListpic3.Images.SetKeyName(70, "70.png");
            this.imageListpic3.Images.SetKeyName(71, "71.png");
            this.imageListpic3.Images.SetKeyName(72, "72.png");
            this.imageListpic3.Images.SetKeyName(73, "73.png");
            this.imageListpic3.Images.SetKeyName(74, "74.png");
            this.imageListpic3.Images.SetKeyName(75, "75.png");
            this.imageListpic3.Images.SetKeyName(76, "76.png");
            this.imageListpic3.Images.SetKeyName(77, "77.png");
            this.imageListpic3.Images.SetKeyName(78, "78.png");
            this.imageListpic3.Images.SetKeyName(79, "79.png");
            this.imageListpic3.Images.SetKeyName(80, "80.png");
            this.imageListpic3.Images.SetKeyName(81, "81.png");
            this.imageListpic3.Images.SetKeyName(82, "82.png");
            this.imageListpic3.Images.SetKeyName(83, "82.png");
            this.imageListpic3.Images.SetKeyName(84, "82.png");
            this.imageListpic3.Images.SetKeyName(85, "82.png");
            // 
            // pictureBoxAnimation3
            // 
            this.pictureBoxAnimation3.Location = new System.Drawing.Point(1144, 12);
            this.pictureBoxAnimation3.Name = "pictureBoxAnimation3";
            this.pictureBoxAnimation3.Size = new System.Drawing.Size(209, 200);
            this.pictureBoxAnimation3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAnimation3.TabIndex = 18;
            this.pictureBoxAnimation3.TabStop = false;
            // 
            // timerpic4
            // 
            this.timerpic4.Interval = 60;
            this.timerpic4.Tick += new System.EventHandler(this.timerpic4_Tick);
            // 
            // imageListpic4
            // 
            this.imageListpic4.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListpic4.ImageStream")));
            this.imageListpic4.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListpic4.Images.SetKeyName(0, "1.png");
            this.imageListpic4.Images.SetKeyName(1, "2.png");
            this.imageListpic4.Images.SetKeyName(2, "3.png");
            this.imageListpic4.Images.SetKeyName(3, "1.png");
            this.imageListpic4.Images.SetKeyName(4, "2.png");
            this.imageListpic4.Images.SetKeyName(5, "3.png");
            this.imageListpic4.Images.SetKeyName(6, "4.png");
            this.imageListpic4.Images.SetKeyName(7, "5.png");
            this.imageListpic4.Images.SetKeyName(8, "6.png");
            this.imageListpic4.Images.SetKeyName(9, "7.png");
            this.imageListpic4.Images.SetKeyName(10, "8.png");
            this.imageListpic4.Images.SetKeyName(11, "9.png");
            this.imageListpic4.Images.SetKeyName(12, "10.png");
            this.imageListpic4.Images.SetKeyName(13, "11.png");
            this.imageListpic4.Images.SetKeyName(14, "12.png");
            this.imageListpic4.Images.SetKeyName(15, "13.png");
            this.imageListpic4.Images.SetKeyName(16, "14.png");
            this.imageListpic4.Images.SetKeyName(17, "15.png");
            this.imageListpic4.Images.SetKeyName(18, "16.png");
            this.imageListpic4.Images.SetKeyName(19, "17.png");
            this.imageListpic4.Images.SetKeyName(20, "18.png");
            this.imageListpic4.Images.SetKeyName(21, "19.png");
            this.imageListpic4.Images.SetKeyName(22, "20.png");
            this.imageListpic4.Images.SetKeyName(23, "21.png");
            this.imageListpic4.Images.SetKeyName(24, "22.png");
            this.imageListpic4.Images.SetKeyName(25, "23.png");
            this.imageListpic4.Images.SetKeyName(26, "24.png");
            this.imageListpic4.Images.SetKeyName(27, "25.png");
            this.imageListpic4.Images.SetKeyName(28, "26.png");
            this.imageListpic4.Images.SetKeyName(29, "27.png");
            this.imageListpic4.Images.SetKeyName(30, "28.png");
            this.imageListpic4.Images.SetKeyName(31, "29.png");
            this.imageListpic4.Images.SetKeyName(32, "30.png");
            this.imageListpic4.Images.SetKeyName(33, "31.png");
            this.imageListpic4.Images.SetKeyName(34, "32.png");
            this.imageListpic4.Images.SetKeyName(35, "33.png");
            this.imageListpic4.Images.SetKeyName(36, "34.png");
            this.imageListpic4.Images.SetKeyName(37, "35.png");
            this.imageListpic4.Images.SetKeyName(38, "36.png");
            this.imageListpic4.Images.SetKeyName(39, "37.png");
            this.imageListpic4.Images.SetKeyName(40, "38.png");
            this.imageListpic4.Images.SetKeyName(41, "39.png");
            this.imageListpic4.Images.SetKeyName(42, "40.png");
            this.imageListpic4.Images.SetKeyName(43, "41.png");
            this.imageListpic4.Images.SetKeyName(44, "42.png");
            this.imageListpic4.Images.SetKeyName(45, "43.png");
            this.imageListpic4.Images.SetKeyName(46, "44.png");
            this.imageListpic4.Images.SetKeyName(47, "45.png");
            this.imageListpic4.Images.SetKeyName(48, "46.png");
            this.imageListpic4.Images.SetKeyName(49, "47.png");
            this.imageListpic4.Images.SetKeyName(50, "49.png");
            this.imageListpic4.Images.SetKeyName(51, "49.png");
            this.imageListpic4.Images.SetKeyName(52, "49.png");
            this.imageListpic4.Images.SetKeyName(53, "49.png");
            // 
            // timerpic5
            // 
            this.timerpic5.Interval = 60;
            this.timerpic5.Tick += new System.EventHandler(this.timerpic5_Tick);
            // 
            // imageListpic5
            // 
            this.imageListpic5.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListpic5.ImageStream")));
            this.imageListpic5.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListpic5.Images.SetKeyName(0, "0.png");
            this.imageListpic5.Images.SetKeyName(1, "1.png");
            this.imageListpic5.Images.SetKeyName(2, "2.png");
            this.imageListpic5.Images.SetKeyName(3, "3.png");
            this.imageListpic5.Images.SetKeyName(4, "4.png");
            this.imageListpic5.Images.SetKeyName(5, "5.png");
            this.imageListpic5.Images.SetKeyName(6, "6.png");
            this.imageListpic5.Images.SetKeyName(7, "7.png");
            this.imageListpic5.Images.SetKeyName(8, "8.png");
            this.imageListpic5.Images.SetKeyName(9, "9.png");
            this.imageListpic5.Images.SetKeyName(10, "10.png");
            this.imageListpic5.Images.SetKeyName(11, "11.png");
            this.imageListpic5.Images.SetKeyName(12, "12.png");
            this.imageListpic5.Images.SetKeyName(13, "13.png");
            this.imageListpic5.Images.SetKeyName(14, "14.png");
            this.imageListpic5.Images.SetKeyName(15, "15.png");
            this.imageListpic5.Images.SetKeyName(16, "16.png");
            this.imageListpic5.Images.SetKeyName(17, "17.png");
            this.imageListpic5.Images.SetKeyName(18, "17.png");
            this.imageListpic5.Images.SetKeyName(19, "17.png");
            this.imageListpic5.Images.SetKeyName(20, "17.png");
            this.imageListpic5.Images.SetKeyName(21, "18.png");
            this.imageListpic5.Images.SetKeyName(22, "18.png");
            this.imageListpic5.Images.SetKeyName(23, "19.png");
            this.imageListpic5.Images.SetKeyName(24, "20.png");
            this.imageListpic5.Images.SetKeyName(25, "21.png");
            this.imageListpic5.Images.SetKeyName(26, "22.png");
            this.imageListpic5.Images.SetKeyName(27, "23.png");
            this.imageListpic5.Images.SetKeyName(28, "24.png");
            this.imageListpic5.Images.SetKeyName(29, "25.png");
            this.imageListpic5.Images.SetKeyName(30, "26.png");
            this.imageListpic5.Images.SetKeyName(31, "27.png");
            this.imageListpic5.Images.SetKeyName(32, "27.png");
            this.imageListpic5.Images.SetKeyName(33, "27.png");
            this.imageListpic5.Images.SetKeyName(34, "27.png");
            this.imageListpic5.Images.SetKeyName(35, "28.png");
            this.imageListpic5.Images.SetKeyName(36, "29.png");
            this.imageListpic5.Images.SetKeyName(37, "28.png");
            this.imageListpic5.Images.SetKeyName(38, "29.png");
            this.imageListpic5.Images.SetKeyName(39, "28.png");
            this.imageListpic5.Images.SetKeyName(40, "29.png");
            this.imageListpic5.Images.SetKeyName(41, "30.png");
            this.imageListpic5.Images.SetKeyName(42, "31.png");
            this.imageListpic5.Images.SetKeyName(43, "32.png");
            this.imageListpic5.Images.SetKeyName(44, "33.png");
            this.imageListpic5.Images.SetKeyName(45, "30.png");
            this.imageListpic5.Images.SetKeyName(46, "31.png");
            this.imageListpic5.Images.SetKeyName(47, "32.png");
            this.imageListpic5.Images.SetKeyName(48, "33.png");
            this.imageListpic5.Images.SetKeyName(49, "34.png");
            this.imageListpic5.Images.SetKeyName(50, "34.png");
            this.imageListpic5.Images.SetKeyName(51, "34.png");
            this.imageListpic5.Images.SetKeyName(52, "34.png");
            // 
            // pictureBoxAnimation5
            // 
            this.pictureBoxAnimation5.Location = new System.Drawing.Point(25, 514);
            this.pictureBoxAnimation5.Name = "pictureBoxAnimation5";
            this.pictureBoxAnimation5.Size = new System.Drawing.Size(213, 212);
            this.pictureBoxAnimation5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAnimation5.TabIndex = 20;
            this.pictureBoxAnimation5.TabStop = false;
            // 
            // imageListpic6
            // 
            this.imageListpic6.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListpic6.ImageStream")));
            this.imageListpic6.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListpic6.Images.SetKeyName(0, "1.png");
            this.imageListpic6.Images.SetKeyName(1, "2.png");
            this.imageListpic6.Images.SetKeyName(2, "3.png");
            this.imageListpic6.Images.SetKeyName(3, "4.png");
            this.imageListpic6.Images.SetKeyName(4, "5.png");
            this.imageListpic6.Images.SetKeyName(5, "6.png");
            this.imageListpic6.Images.SetKeyName(6, "7.png");
            this.imageListpic6.Images.SetKeyName(7, "8.png");
            this.imageListpic6.Images.SetKeyName(8, "9.png");
            this.imageListpic6.Images.SetKeyName(9, "10.png");
            this.imageListpic6.Images.SetKeyName(10, "11.png");
            this.imageListpic6.Images.SetKeyName(11, "12.png");
            this.imageListpic6.Images.SetKeyName(12, "13.png");
            this.imageListpic6.Images.SetKeyName(13, "14.png");
            this.imageListpic6.Images.SetKeyName(14, "15.png");
            this.imageListpic6.Images.SetKeyName(15, "16.png");
            this.imageListpic6.Images.SetKeyName(16, "17.png");
            this.imageListpic6.Images.SetKeyName(17, "18.png");
            this.imageListpic6.Images.SetKeyName(18, "19.png");
            this.imageListpic6.Images.SetKeyName(19, "20.png");
            this.imageListpic6.Images.SetKeyName(20, "21.png");
            this.imageListpic6.Images.SetKeyName(21, "22.png");
            this.imageListpic6.Images.SetKeyName(22, "23.png");
            this.imageListpic6.Images.SetKeyName(23, "24.png");
            this.imageListpic6.Images.SetKeyName(24, "25.png");
            this.imageListpic6.Images.SetKeyName(25, "26.png");
            this.imageListpic6.Images.SetKeyName(26, "27.png");
            this.imageListpic6.Images.SetKeyName(27, "28.png");
            this.imageListpic6.Images.SetKeyName(28, "29.png");
            this.imageListpic6.Images.SetKeyName(29, "30.png");
            this.imageListpic6.Images.SetKeyName(30, "31.png");
            this.imageListpic6.Images.SetKeyName(31, "32.png");
            this.imageListpic6.Images.SetKeyName(32, "32.png");
            this.imageListpic6.Images.SetKeyName(33, "32.png");
            this.imageListpic6.Images.SetKeyName(34, "32.png");
            this.imageListpic6.Images.SetKeyName(35, "33.png");
            this.imageListpic6.Images.SetKeyName(36, "34.png");
            this.imageListpic6.Images.SetKeyName(37, "35.png");
            this.imageListpic6.Images.SetKeyName(38, "36.png");
            this.imageListpic6.Images.SetKeyName(39, "37.png");
            this.imageListpic6.Images.SetKeyName(40, "38.png");
            this.imageListpic6.Images.SetKeyName(41, "39.png");
            this.imageListpic6.Images.SetKeyName(42, "40.png");
            this.imageListpic6.Images.SetKeyName(43, "41.png");
            this.imageListpic6.Images.SetKeyName(44, "42.png");
            this.imageListpic6.Images.SetKeyName(45, "40.png");
            this.imageListpic6.Images.SetKeyName(46, "41.png");
            this.imageListpic6.Images.SetKeyName(47, "42.png");
            this.imageListpic6.Images.SetKeyName(48, "40.png");
            this.imageListpic6.Images.SetKeyName(49, "41.png");
            this.imageListpic6.Images.SetKeyName(50, "42.png");
            this.imageListpic6.Images.SetKeyName(51, "43.png");
            this.imageListpic6.Images.SetKeyName(52, "43.png");
            this.imageListpic6.Images.SetKeyName(53, "44.png");
            this.imageListpic6.Images.SetKeyName(54, "45.png");
            this.imageListpic6.Images.SetKeyName(55, "44.png");
            this.imageListpic6.Images.SetKeyName(56, "45.png");
            this.imageListpic6.Images.SetKeyName(57, "44.png");
            this.imageListpic6.Images.SetKeyName(58, "45.png");
            this.imageListpic6.Images.SetKeyName(59, "45.png");
            this.imageListpic6.Images.SetKeyName(60, "45.png");
            this.imageListpic6.Images.SetKeyName(61, "45.png");
            this.imageListpic6.Images.SetKeyName(62, "45.png");
            this.imageListpic6.Images.SetKeyName(63, "45.png");
            // 
            // timerpic6
            // 
            this.timerpic6.Interval = 60;
            this.timerpic6.Tick += new System.EventHandler(this.timerpic6_Tick);
            // 
            // pictureBoxAnimation7
            // 
            this.pictureBoxAnimation7.Location = new System.Drawing.Point(311, 358);
            this.pictureBoxAnimation7.Name = "pictureBoxAnimation7";
            this.pictureBoxAnimation7.Size = new System.Drawing.Size(213, 184);
            this.pictureBoxAnimation7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAnimation7.TabIndex = 22;
            this.pictureBoxAnimation7.TabStop = false;
            // 
            // timerpic7
            // 
            this.timerpic7.Interval = 60;
            this.timerpic7.Tick += new System.EventHandler(this.timerpic7_Tick);
            // 
            // imageListpic7
            // 
            this.imageListpic7.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListpic7.ImageStream")));
            this.imageListpic7.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListpic7.Images.SetKeyName(0, "1.png");
            this.imageListpic7.Images.SetKeyName(1, "2.png");
            this.imageListpic7.Images.SetKeyName(2, "3.png");
            this.imageListpic7.Images.SetKeyName(3, "4.png");
            this.imageListpic7.Images.SetKeyName(4, "5.png");
            this.imageListpic7.Images.SetKeyName(5, "6.png");
            this.imageListpic7.Images.SetKeyName(6, "7.png");
            this.imageListpic7.Images.SetKeyName(7, "8.png");
            this.imageListpic7.Images.SetKeyName(8, "9.png");
            this.imageListpic7.Images.SetKeyName(9, "10.png");
            this.imageListpic7.Images.SetKeyName(10, "12.png");
            this.imageListpic7.Images.SetKeyName(11, "13.png");
            this.imageListpic7.Images.SetKeyName(12, "14.png");
            this.imageListpic7.Images.SetKeyName(13, "15.png");
            this.imageListpic7.Images.SetKeyName(14, "16.png");
            this.imageListpic7.Images.SetKeyName(15, "17.png");
            this.imageListpic7.Images.SetKeyName(16, "18.png");
            this.imageListpic7.Images.SetKeyName(17, "19.png");
            this.imageListpic7.Images.SetKeyName(18, "20.png");
            this.imageListpic7.Images.SetKeyName(19, "21.png");
            this.imageListpic7.Images.SetKeyName(20, "22.png");
            this.imageListpic7.Images.SetKeyName(21, "23.png");
            this.imageListpic7.Images.SetKeyName(22, "24.png");
            this.imageListpic7.Images.SetKeyName(23, "25.png");
            this.imageListpic7.Images.SetKeyName(24, "26.png");
            this.imageListpic7.Images.SetKeyName(25, "27.png");
            this.imageListpic7.Images.SetKeyName(26, "28.png");
            this.imageListpic7.Images.SetKeyName(27, "29.png");
            this.imageListpic7.Images.SetKeyName(28, "30.png");
            this.imageListpic7.Images.SetKeyName(29, "31.png");
            this.imageListpic7.Images.SetKeyName(30, "32.png");
            this.imageListpic7.Images.SetKeyName(31, "33.png");
            this.imageListpic7.Images.SetKeyName(32, "34.png");
            this.imageListpic7.Images.SetKeyName(33, "35.png");
            this.imageListpic7.Images.SetKeyName(34, "36.png");
            this.imageListpic7.Images.SetKeyName(35, "37.png");
            this.imageListpic7.Images.SetKeyName(36, "38.png");
            this.imageListpic7.Images.SetKeyName(37, "39.png");
            this.imageListpic7.Images.SetKeyName(38, "40.png");
            this.imageListpic7.Images.SetKeyName(39, "41.png");
            this.imageListpic7.Images.SetKeyName(40, "42.png");
            this.imageListpic7.Images.SetKeyName(41, "43.png");
            this.imageListpic7.Images.SetKeyName(42, "44.png");
            this.imageListpic7.Images.SetKeyName(43, "45.png");
            this.imageListpic7.Images.SetKeyName(44, "46.png");
            this.imageListpic7.Images.SetKeyName(45, "47.png");
            this.imageListpic7.Images.SetKeyName(46, "48.png");
            this.imageListpic7.Images.SetKeyName(47, "49.png");
            this.imageListpic7.Images.SetKeyName(48, "50.png");
            this.imageListpic7.Images.SetKeyName(49, "51.png");
            this.imageListpic7.Images.SetKeyName(50, "52.png");
            this.imageListpic7.Images.SetKeyName(51, "53.png");
            this.imageListpic7.Images.SetKeyName(52, "54.png");
            this.imageListpic7.Images.SetKeyName(53, "55.png");
            this.imageListpic7.Images.SetKeyName(54, "56.png");
            this.imageListpic7.Images.SetKeyName(55, "57.png");
            this.imageListpic7.Images.SetKeyName(56, "57.png");
            this.imageListpic7.Images.SetKeyName(57, "57.png");
            this.imageListpic7.Images.SetKeyName(58, "57.png");
            this.imageListpic7.Images.SetKeyName(59, "57.png");
            this.imageListpic7.Images.SetKeyName(60, "57.png");
            // 
            // pictureBoxAnimation6
            // 
            this.pictureBoxAnimation6.Location = new System.Drawing.Point(933, 12);
            this.pictureBoxAnimation6.Name = "pictureBoxAnimation6";
            this.pictureBoxAnimation6.Size = new System.Drawing.Size(205, 200);
            this.pictureBoxAnimation6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAnimation6.TabIndex = 23;
            this.pictureBoxAnimation6.TabStop = false;
            // 
            // pictureBoxAnimation4
            // 
            this.pictureBoxAnimation4.Location = new System.Drawing.Point(244, 521);
            this.pictureBoxAnimation4.Name = "pictureBoxAnimation4";
            this.pictureBoxAnimation4.Size = new System.Drawing.Size(222, 200);
            this.pictureBoxAnimation4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAnimation4.TabIndex = 24;
            this.pictureBoxAnimation4.TabStop = false;
            // 
            // pictureBoxYoung
            // 
            this.pictureBoxYoung.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxYoung.Name = "pictureBoxYoung";
            this.pictureBoxYoung.Size = new System.Drawing.Size(293, 403);
            this.pictureBoxYoung.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxYoung.TabIndex = 25;
            this.pictureBoxYoung.TabStop = false;
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNext.BackgroundImage")));
            this.buttonNext.Image = ((System.Drawing.Image)(resources.GetObject("buttonNext.Image")));
            this.buttonNext.Location = new System.Drawing.Point(976, 309);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(145, 135);
            this.buttonNext.TabIndex = 26;
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // timerShowpic
            // 
            this.timerShowpic.Interval = 1000;
            // 
            // pictureBoxAnimation2
            // 
            this.pictureBoxAnimation2.Location = new System.Drawing.Point(933, 267);
            this.pictureBoxAnimation2.Name = "pictureBoxAnimation2";
            this.pictureBoxAnimation2.Size = new System.Drawing.Size(216, 188);
            this.pictureBoxAnimation2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAnimation2.TabIndex = 28;
            this.pictureBoxAnimation2.TabStop = false;
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.Location = new System.Drawing.Point(437, 0);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(479, 714);
            this.pictureBoxResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxResult.TabIndex = 29;
            this.pictureBoxResult.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.pictureBoxResult);
            this.Controls.Add(this.pictureBoxAnimation2);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.pictureBoxYoung);
            this.Controls.Add(this.pictureBoxAnimation4);
            this.Controls.Add(this.pictureBoxAnimation6);
            this.Controls.Add(this.pictureBoxAnimation7);
            this.Controls.Add(this.pictureBoxAnimation5);
            this.Controls.Add(this.pictureBoxAnimation3);
            this.Controls.Add(this.pictureBoxAnimation1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listViewResult);
            this.Controls.Add(this.listBoxMessage);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "104年中興資管之\"遊戲王\"是你~";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnimation1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnimation3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnimation5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnimation7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnimation6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnimation4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYoung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnimation2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMessage;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ListView listViewResult;
        private System.Windows.Forms.ColumnHeader columnNumber;
        private System.Windows.Forms.ColumnHeader columnYoung;
        private System.Windows.Forms.ColumnHeader columnOld;
        private System.Windows.Forms.ColumnHeader columnFamily;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox pictureBoxAnimation1;
        private System.Windows.Forms.ImageList imageListpic1;
        private System.Windows.Forms.Timer timerpic1;
        private System.Windows.Forms.Timer timerpic2;
        private System.Windows.Forms.ImageList imageListpic2;
        private System.Windows.Forms.Timer timerpic3;
        private System.Windows.Forms.ImageList imageListpic3;
        private System.Windows.Forms.PictureBox pictureBoxAnimation3;
        private System.Windows.Forms.Timer timerpic4;
        private System.Windows.Forms.ImageList imageListpic4;
        private System.Windows.Forms.Timer timerpic5;
        private System.Windows.Forms.ImageList imageListpic5;
        private System.Windows.Forms.PictureBox pictureBoxAnimation5;
        private System.Windows.Forms.ImageList imageListpic6;
        private System.Windows.Forms.Timer timerpic6;
        private System.Windows.Forms.PictureBox pictureBoxAnimation7;
        private System.Windows.Forms.Timer timerpic7;
        private System.Windows.Forms.ImageList imageListpic7;
        private System.Windows.Forms.PictureBox pictureBoxAnimation6;
        private System.Windows.Forms.PictureBox pictureBoxAnimation4;
        private System.Windows.Forms.PictureBox pictureBoxYoung;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Timer timerShowpic;
        private System.Windows.Forms.PictureBox pictureBoxAnimation2;
        private System.Windows.Forms.PictureBox pictureBoxResult;
    }
}

