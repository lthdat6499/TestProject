namespace PaintDemo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.btn_DungChamDaGiac = new System.Windows.Forms.Button();
            this.gbx_TinhChinh = new System.Windows.Forms.GroupBox();
            this.btn_DiChuyen = new System.Windows.Forms.Button();
            this.btn_ClearObject = new System.Windows.Forms.Button();
            this.btn_XoaObject = new System.Windows.Forms.Button();
            this.lbx_Object = new System.Windows.Forms.ListBox();
            this.gbx_TuyChinh = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_KieuVe = new System.Windows.Forms.ComboBox();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.tbr_DoDayBut = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.rbt_CheDo = new System.Windows.Forms.RadioButton();
            this.gbx_ChonMau = new System.Windows.Forms.GroupBox();
            this.btn_Mau = new System.Windows.Forms.Button();
            this.btn_TuyChinhMau = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbx_KieuVe = new System.Windows.Forms.GroupBox();
            this.rbt_HinhTron = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.rbt_DuongCong = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rbt_DuongThang = new System.Windows.Forms.RadioButton();
            this.pnl_Board = new System.Windows.Forms.Panel();
            this.cdl_ChooseColor = new System.Windows.Forms.ColorDialog();
            this.tbr_Scale = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_Menu.SuspendLayout();
            this.gbx_TinhChinh.SuspendLayout();
            this.gbx_TuyChinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbr_DoDayBut)).BeginInit();
            this.gbx_ChonMau.SuspendLayout();
            this.gbx_KieuVe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbr_Scale)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.Controls.Add(this.btn_DungChamDaGiac);
            this.pnl_Menu.Controls.Add(this.gbx_TinhChinh);
            this.pnl_Menu.Controls.Add(this.gbx_TuyChinh);
            this.pnl_Menu.Controls.Add(this.gbx_ChonMau);
            this.pnl_Menu.Controls.Add(this.gbx_KieuVe);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(1280, 133);
            this.pnl_Menu.TabIndex = 0;
            // 
            // btn_DungChamDaGiac
            // 
            this.btn_DungChamDaGiac.Location = new System.Drawing.Point(1206, 33);
            this.btn_DungChamDaGiac.Name = "btn_DungChamDaGiac";
            this.btn_DungChamDaGiac.Size = new System.Drawing.Size(71, 83);
            this.btn_DungChamDaGiac.TabIndex = 7;
            this.btn_DungChamDaGiac.Text = "Dừng vẽ đa giác";
            this.btn_DungChamDaGiac.UseVisualStyleBackColor = true;
            this.btn_DungChamDaGiac.Visible = false;
            this.btn_DungChamDaGiac.Click += new System.EventHandler(this.btn_DungChamDaGiac_Click);
            // 
            // gbx_TinhChinh
            // 
            this.gbx_TinhChinh.Controls.Add(this.tbr_Scale);
            this.gbx_TinhChinh.Controls.Add(this.label3);
            this.gbx_TinhChinh.Controls.Add(this.btn_DiChuyen);
            this.gbx_TinhChinh.Controls.Add(this.btn_ClearObject);
            this.gbx_TinhChinh.Controls.Add(this.btn_XoaObject);
            this.gbx_TinhChinh.Controls.Add(this.lbx_Object);
            this.gbx_TinhChinh.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbx_TinhChinh.Location = new System.Drawing.Point(799, 0);
            this.gbx_TinhChinh.Name = "gbx_TinhChinh";
            this.gbx_TinhChinh.Size = new System.Drawing.Size(401, 133);
            this.gbx_TinhChinh.TabIndex = 3;
            this.gbx_TinhChinh.TabStop = false;
            this.gbx_TinhChinh.Text = "Tinh chỉnh phần tử";
            // 
            // btn_DiChuyen
            // 
            this.btn_DiChuyen.Location = new System.Drawing.Point(182, 22);
            this.btn_DiChuyen.Name = "btn_DiChuyen";
            this.btn_DiChuyen.Size = new System.Drawing.Size(104, 30);
            this.btn_DiChuyen.TabIndex = 4;
            this.btn_DiChuyen.Text = "Di chuyển";
            this.btn_DiChuyen.UseVisualStyleBackColor = true;
            this.btn_DiChuyen.Click += new System.EventHandler(this.btn_DiChuyen_Click);
            // 
            // btn_ClearObject
            // 
            this.btn_ClearObject.Location = new System.Drawing.Point(182, 93);
            this.btn_ClearObject.Name = "btn_ClearObject";
            this.btn_ClearObject.Size = new System.Drawing.Size(104, 30);
            this.btn_ClearObject.TabIndex = 3;
            this.btn_ClearObject.Text = "Clear";
            this.btn_ClearObject.UseVisualStyleBackColor = true;
            this.btn_ClearObject.Click += new System.EventHandler(this.btn_ClearObject_Click);
            // 
            // btn_XoaObject
            // 
            this.btn_XoaObject.Location = new System.Drawing.Point(182, 59);
            this.btn_XoaObject.Name = "btn_XoaObject";
            this.btn_XoaObject.Size = new System.Drawing.Size(104, 30);
            this.btn_XoaObject.TabIndex = 2;
            this.btn_XoaObject.Text = "Xóa";
            this.btn_XoaObject.UseVisualStyleBackColor = true;
            this.btn_XoaObject.Click += new System.EventHandler(this.btn_XoaObject_Click);
            // 
            // lbx_Object
            // 
            this.lbx_Object.FormattingEnabled = true;
            this.lbx_Object.ItemHeight = 16;
            this.lbx_Object.Location = new System.Drawing.Point(7, 22);
            this.lbx_Object.Name = "lbx_Object";
            this.lbx_Object.Size = new System.Drawing.Size(169, 100);
            this.lbx_Object.TabIndex = 0;
            // 
            // gbx_TuyChinh
            // 
            this.gbx_TuyChinh.Controls.Add(this.label2);
            this.gbx_TuyChinh.Controls.Add(this.cbx_KieuVe);
            this.gbx_TuyChinh.Controls.Add(this.radioButton9);
            this.gbx_TuyChinh.Controls.Add(this.tbr_DoDayBut);
            this.gbx_TuyChinh.Controls.Add(this.label1);
            this.gbx_TuyChinh.Controls.Add(this.rbt_CheDo);
            this.gbx_TuyChinh.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbx_TuyChinh.Location = new System.Drawing.Point(563, 0);
            this.gbx_TuyChinh.Name = "gbx_TuyChinh";
            this.gbx_TuyChinh.Size = new System.Drawing.Size(236, 133);
            this.gbx_TuyChinh.TabIndex = 2;
            this.gbx_TuyChinh.TabStop = false;
            this.gbx_TuyChinh.Text = "Tùy chỉnh bút và chế độ vẽ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kiểu bút";
            // 
            // cbx_KieuVe
            // 
            this.cbx_KieuVe.FormattingEnabled = true;
            this.cbx_KieuVe.Items.AddRange(new object[] {
            "Nét liền",
            "Nét đứt",
            "Nét chấm",
            "Nét đứt chấm",
            "Nét dứt chấm chấm"});
            this.cbx_KieuVe.Location = new System.Drawing.Point(91, 52);
            this.cbx_KieuVe.Name = "cbx_KieuVe";
            this.cbx_KieuVe.Size = new System.Drawing.Size(121, 24);
            this.cbx_KieuVe.TabIndex = 5;
            this.cbx_KieuVe.SelectedIndexChanged += new System.EventHandler(this.cbx_KieuVe_SelectedIndexChanged);
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(9, 105);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(117, 21);
            this.radioButton9.TabIndex = 4;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Chế độ tô đầy";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.rbt_CheDo_Click);
            // 
            // tbr_DoDayBut
            // 
            this.tbr_DoDayBut.Location = new System.Drawing.Point(89, 18);
            this.tbr_DoDayBut.Minimum = 1;
            this.tbr_DoDayBut.Name = "tbr_DoDayBut";
            this.tbr_DoDayBut.Size = new System.Drawing.Size(123, 56);
            this.tbr_DoDayBut.TabIndex = 2;
            this.tbr_DoDayBut.Value = 5;
            this.tbr_DoDayBut.Scroll += new System.EventHandler(this.tbr_DoDayBut_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Độ dày bút";
            // 
            // rbt_CheDo
            // 
            this.rbt_CheDo.AutoSize = true;
            this.rbt_CheDo.Checked = true;
            this.rbt_CheDo.Location = new System.Drawing.Point(9, 78);
            this.rbt_CheDo.Name = "rbt_CheDo";
            this.rbt_CheDo.Size = new System.Drawing.Size(153, 21);
            this.rbt_CheDo.TabIndex = 3;
            this.rbt_CheDo.TabStop = true;
            this.rbt_CheDo.Text = "Chế độ bình thường";
            this.rbt_CheDo.UseVisualStyleBackColor = true;
            this.rbt_CheDo.CheckedChanged += new System.EventHandler(this.rbt_CheDo_Click);
            // 
            // gbx_ChonMau
            // 
            this.gbx_ChonMau.Controls.Add(this.btn_Mau);
            this.gbx_ChonMau.Controls.Add(this.btn_TuyChinhMau);
            this.gbx_ChonMau.Controls.Add(this.button15);
            this.gbx_ChonMau.Controls.Add(this.button14);
            this.gbx_ChonMau.Controls.Add(this.button13);
            this.gbx_ChonMau.Controls.Add(this.button12);
            this.gbx_ChonMau.Controls.Add(this.button11);
            this.gbx_ChonMau.Controls.Add(this.button10);
            this.gbx_ChonMau.Controls.Add(this.button9);
            this.gbx_ChonMau.Controls.Add(this.button8);
            this.gbx_ChonMau.Controls.Add(this.button7);
            this.gbx_ChonMau.Controls.Add(this.button6);
            this.gbx_ChonMau.Controls.Add(this.button5);
            this.gbx_ChonMau.Controls.Add(this.button4);
            this.gbx_ChonMau.Controls.Add(this.button3);
            this.gbx_ChonMau.Controls.Add(this.button2);
            this.gbx_ChonMau.Controls.Add(this.button1);
            this.gbx_ChonMau.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbx_ChonMau.Location = new System.Drawing.Point(289, 0);
            this.gbx_ChonMau.Name = "gbx_ChonMau";
            this.gbx_ChonMau.Size = new System.Drawing.Size(274, 133);
            this.gbx_ChonMau.TabIndex = 1;
            this.gbx_ChonMau.TabStop = false;
            this.gbx_ChonMau.Text = "Chọn màu";
            // 
            // btn_Mau
            // 
            this.btn_Mau.BackColor = System.Drawing.Color.Black;
            this.btn_Mau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Mau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mau.Location = new System.Drawing.Point(240, 54);
            this.btn_Mau.Name = "btn_Mau";
            this.btn_Mau.Size = new System.Drawing.Size(30, 30);
            this.btn_Mau.TabIndex = 16;
            this.btn_Mau.UseVisualStyleBackColor = false;
            // 
            // btn_TuyChinhMau
            // 
            this.btn_TuyChinhMau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TuyChinhMau.Image = ((System.Drawing.Image)(resources.GetObject("btn_TuyChinhMau.Image")));
            this.btn_TuyChinhMau.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_TuyChinhMau.Location = new System.Drawing.Point(182, 30);
            this.btn_TuyChinhMau.Name = "btn_TuyChinhMau";
            this.btn_TuyChinhMau.Size = new System.Drawing.Size(52, 79);
            this.btn_TuyChinhMau.TabIndex = 15;
            this.btn_TuyChinhMau.Text = "Tùy chỉnh";
            this.btn_TuyChinhMau.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_TuyChinhMau.UseVisualStyleBackColor = true;
            this.btn_TuyChinhMau.Click += new System.EventHandler(this.btn_TuyChinhMau_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Gainsboro;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Location = new System.Drawing.Point(147, 94);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(30, 30);
            this.button15.TabIndex = 14;
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.btn_Mau_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.Highlight;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Location = new System.Drawing.Point(111, 94);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(30, 30);
            this.button14.TabIndex = 13;
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.btn_Mau_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Orange;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Location = new System.Drawing.Point(75, 94);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(30, 30);
            this.button13.TabIndex = 12;
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.btn_Mau_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Gold;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(39, 94);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(30, 30);
            this.button12.TabIndex = 11;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.btn_Mau_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.LimeGreen;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(3, 94);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(30, 30);
            this.button11.TabIndex = 10;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.btn_Mau_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(147, 58);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(30, 30);
            this.button10.TabIndex = 9;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.btn_Mau_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Purple;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(111, 58);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(30, 30);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.btn_Mau_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Blue;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(75, 58);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(30, 30);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.btn_Mau_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Turquoise;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(39, 58);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(30, 30);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.btn_Mau_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Green;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(3, 58);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(30, 30);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.btn_Mau_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Yellow;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(147, 20);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 30);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.btn_Mau_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(111, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 30);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btn_Mau_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkRed;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(75, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 30);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btn_Mau_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(39, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btn_Mau_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_Mau_Click);
            // 
            // gbx_KieuVe
            // 
            this.gbx_KieuVe.Controls.Add(this.rbt_HinhTron);
            this.gbx_KieuVe.Controls.Add(this.radioButton6);
            this.gbx_KieuVe.Controls.Add(this.radioButton5);
            this.gbx_KieuVe.Controls.Add(this.rbt_DuongCong);
            this.gbx_KieuVe.Controls.Add(this.radioButton3);
            this.gbx_KieuVe.Controls.Add(this.radioButton2);
            this.gbx_KieuVe.Controls.Add(this.rbt_DuongThang);
            this.gbx_KieuVe.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbx_KieuVe.Location = new System.Drawing.Point(0, 0);
            this.gbx_KieuVe.Name = "gbx_KieuVe";
            this.gbx_KieuVe.Size = new System.Drawing.Size(289, 133);
            this.gbx_KieuVe.TabIndex = 0;
            this.gbx_KieuVe.TabStop = false;
            this.gbx_KieuVe.Text = "Kiểu vẽ";
            // 
            // rbt_HinhTron
            // 
            this.rbt_HinhTron.AutoSize = true;
            this.rbt_HinhTron.Location = new System.Drawing.Point(6, 23);
            this.rbt_HinhTron.Name = "rbt_HinhTron";
            this.rbt_HinhTron.Size = new System.Drawing.Size(106, 21);
            this.rbt_HinhTron.TabIndex = 6;
            this.rbt_HinhTron.Text = "Vẽ hình tròn";
            this.rbt_HinhTron.UseVisualStyleBackColor = true;
            this.rbt_HinhTron.Click += new System.EventHandler(this.rbt_KieuVe_Click);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 103);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(120, 21);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.Text = "Vẽ hình vuông";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.Click += new System.EventHandler(this.rbt_KieuVe_Click);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(156, 25);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(96, 21);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.Text = "Vẽ đa giác";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.Click += new System.EventHandler(this.rbt_KieuVe_Click);
            // 
            // rbt_DuongCong
            // 
            this.rbt_DuongCong.AutoSize = true;
            this.rbt_DuongCong.Location = new System.Drawing.Point(156, 54);
            this.rbt_DuongCong.Name = "rbt_DuongCong";
            this.rbt_DuongCong.Size = new System.Drawing.Size(125, 21);
            this.rbt_DuongCong.TabIndex = 3;
            this.rbt_DuongCong.Text = "Vẽ đường cong";
            this.rbt_DuongCong.UseVisualStyleBackColor = true;
            this.rbt_DuongCong.Click += new System.EventHandler(this.rbt_KieuVe_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 75);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(140, 21);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Vẽ hình Chữ Nhật";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Click += new System.EventHandler(this.rbt_KieuVe_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 48);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(122, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Vẽ hình Ellipse";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.rbt_KieuVe_Click);
            // 
            // rbt_DuongThang
            // 
            this.rbt_DuongThang.AutoSize = true;
            this.rbt_DuongThang.Checked = true;
            this.rbt_DuongThang.Location = new System.Drawing.Point(156, 86);
            this.rbt_DuongThang.Name = "rbt_DuongThang";
            this.rbt_DuongThang.Size = new System.Drawing.Size(130, 21);
            this.rbt_DuongThang.TabIndex = 0;
            this.rbt_DuongThang.TabStop = true;
            this.rbt_DuongThang.Text = "Vẽ đường thẳng";
            this.rbt_DuongThang.UseVisualStyleBackColor = true;
            this.rbt_DuongThang.Click += new System.EventHandler(this.rbt_KieuVe_Click);
            // 
            // pnl_Board
            // 
            this.pnl_Board.AutoScroll = true;
            this.pnl_Board.AutoSize = true;
            this.pnl_Board.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_Board.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnl_Board.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Board.Location = new System.Drawing.Point(0, 133);
            this.pnl_Board.Name = "pnl_Board";
            this.pnl_Board.Size = new System.Drawing.Size(1280, 601);
            this.pnl_Board.TabIndex = 1;
            this.pnl_Board.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Board_Paint);
            this.pnl_Board.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Board_MouseDown);
            this.pnl_Board.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Board_MouseMove);
            this.pnl_Board.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Board_MouseUp);
            // 
            // tbr_Scale
            // 
            this.tbr_Scale.Location = new System.Drawing.Point(339, 12);
            this.tbr_Scale.Maximum = 20;
            this.tbr_Scale.Name = "tbr_Scale";
            this.tbr_Scale.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbr_Scale.Size = new System.Drawing.Size(56, 118);
            this.tbr_Scale.TabIndex = 7;
            this.tbr_Scale.Value = 10;
            this.tbr_Scale.Scroll += new System.EventHandler(this.tbr_Scale_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tỷ lệ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 734);
            this.Controls.Add(this.pnl_Board);
            this.Controls.Add(this.pnl_Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Paint";
            this.pnl_Menu.ResumeLayout(false);
            this.gbx_TinhChinh.ResumeLayout(false);
            this.gbx_TinhChinh.PerformLayout();
            this.gbx_TuyChinh.ResumeLayout(false);
            this.gbx_TuyChinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbr_DoDayBut)).EndInit();
            this.gbx_ChonMau.ResumeLayout(false);
            this.gbx_KieuVe.ResumeLayout(false);
            this.gbx_KieuVe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbr_Scale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Menu;
        private System.Windows.Forms.Panel pnl_Board;
        private System.Windows.Forms.GroupBox gbx_KieuVe;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rbt_DuongThang;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton rbt_DuongCong;
        private System.Windows.Forms.RadioButton rbt_HinhTron;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.ColorDialog cdl_ChooseColor;
        private System.Windows.Forms.GroupBox gbx_ChonMau;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_TuyChinhMau;
        private System.Windows.Forms.Button btn_Mau;
        private System.Windows.Forms.GroupBox gbx_TuyChinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tbr_DoDayBut;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton rbt_CheDo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_KieuVe;
        private System.Windows.Forms.ListBox lbx_Object;
        private System.Windows.Forms.Button btn_XoaObject;
        private System.Windows.Forms.Button btn_ClearObject;
        private System.Windows.Forms.Button btn_DungChamDaGiac;
        private System.Windows.Forms.GroupBox gbx_TinhChinh;
        private System.Windows.Forms.Button btn_DiChuyen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tbr_Scale;
    }
}

