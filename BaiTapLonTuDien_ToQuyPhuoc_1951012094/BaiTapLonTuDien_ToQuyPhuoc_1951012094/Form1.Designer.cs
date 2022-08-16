
namespace BaiTapLonTuDien_ToQuyPhuoc_1951012094
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTuMuonTim = new System.Windows.Forms.TextBox();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.cbSheet = new System.Windows.Forms.ComboBox();
            this.txtTiengAnh = new System.Windows.Forms.TextBox();
            this.txtTiengViet = new System.Windows.Forms.TextBox();
            this.txtVaiTro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.bfTrackGreen = new Bunifu.Framework.UI.BunifuTrackbar();
            this.bFTrackYellow = new Bunifu.Framework.UI.BunifuTrackbar();
            this.bfTrackRed = new Bunifu.Framework.UI.BunifuTrackbar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbRed = new System.Windows.Forms.Label();
            this.lbYellow = new System.Windows.Forms.Label();
            this.lbGreen = new System.Windows.Forms.Label();
            this.lbRGB = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.btE = new System.Windows.Forms.Button();
            this.btV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ứng dụng tra từ điển Anh-Việt ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(172, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(445, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập từ tiếng Anh hoặc tiếng Việt mà bạn muốn tìm";
            // 
            // txtTuMuonTim
            // 
            this.txtTuMuonTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuMuonTim.Location = new System.Drawing.Point(176, 86);
            this.txtTuMuonTim.Name = "txtTuMuonTim";
            this.txtTuMuonTim.Size = new System.Drawing.Size(439, 29);
            this.txtTuMuonTim.TabIndex = 2;
            // 
            // btTimKiem
            // 
            this.btTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKiem.ForeColor = System.Drawing.Color.Red;
            this.btTimKiem.Location = new System.Drawing.Point(341, 121);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(106, 46);
            this.btTimKiem.TabIndex = 3;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 191);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(457, 265);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbSheet
            // 
            this.cbSheet.FormattingEnabled = true;
            this.cbSheet.Location = new System.Drawing.Point(53, 55);
            this.cbSheet.Name = "cbSheet";
            this.cbSheet.Size = new System.Drawing.Size(78, 21);
            this.cbSheet.TabIndex = 6;
            this.cbSheet.SelectedIndexChanged += new System.EventHandler(this.cbSheet_SelectedIndexChanged);
            // 
            // txtTiengAnh
            // 
            this.txtTiengAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiengAnh.Location = new System.Drawing.Point(475, 204);
            this.txtTiengAnh.Name = "txtTiengAnh";
            this.txtTiengAnh.Size = new System.Drawing.Size(159, 26);
            this.txtTiengAnh.TabIndex = 7;
            // 
            // txtTiengViet
            // 
            this.txtTiengViet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiengViet.Location = new System.Drawing.Point(475, 256);
            this.txtTiengViet.Name = "txtTiengViet";
            this.txtTiengViet.Size = new System.Drawing.Size(159, 26);
            this.txtTiengViet.TabIndex = 7;
            // 
            // txtVaiTro
            // 
            this.txtVaiTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVaiTro.Location = new System.Drawing.Point(475, 308);
            this.txtVaiTro.Name = "txtVaiTro";
            this.txtVaiTro.Size = new System.Drawing.Size(159, 26);
            this.txtVaiTro.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(474, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tiếng Anh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(475, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tiếng Việt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(475, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Vai trò";
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.Red;
            this.btThem.Location = new System.Drawing.Point(650, 181);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(96, 49);
            this.btThem.TabIndex = 9;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.ForeColor = System.Drawing.Color.Red;
            this.btThoat.Location = new System.Drawing.Point(650, 346);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(96, 49);
            this.btThoat.TabIndex = 9;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.Red;
            this.btXoa.Location = new System.Drawing.Point(650, 236);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(96, 49);
            this.btXoa.TabIndex = 9;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btLuu
            // 
            this.btLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu.ForeColor = System.Drawing.Color.Red;
            this.btLuu.Location = new System.Drawing.Point(650, 291);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(96, 49);
            this.btLuu.TabIndex = 9;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(4, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(401, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "*Nếu cần chỉnh sửa thì chỉnh sửa trực tiếp trên DataGridView";
            // 
            // bfTrackGreen
            // 
            this.bfTrackGreen.BackColor = System.Drawing.Color.Transparent;
            this.bfTrackGreen.BackgroudColor = System.Drawing.Color.DarkGray;
            this.bfTrackGreen.BorderRadius = 0;
            this.bfTrackGreen.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bfTrackGreen.Location = new System.Drawing.Point(140, 574);
            this.bfTrackGreen.MaximumValue = 255;
            this.bfTrackGreen.Name = "bfTrackGreen";
            this.bfTrackGreen.Size = new System.Drawing.Size(415, 28);
            this.bfTrackGreen.SliderRadius = 0;
            this.bfTrackGreen.TabIndex = 11;
            this.bfTrackGreen.Value = 0;
            // 
            // bFTrackYellow
            // 
            this.bFTrackYellow.BackColor = System.Drawing.Color.Transparent;
            this.bFTrackYellow.BackgroudColor = System.Drawing.Color.DarkGray;
            this.bFTrackYellow.BorderRadius = 0;
            this.bFTrackYellow.IndicatorColor = System.Drawing.Color.Yellow;
            this.bFTrackYellow.Location = new System.Drawing.Point(140, 540);
            this.bFTrackYellow.MaximumValue = 255;
            this.bFTrackYellow.Name = "bFTrackYellow";
            this.bFTrackYellow.Size = new System.Drawing.Size(415, 28);
            this.bFTrackYellow.SliderRadius = 0;
            this.bFTrackYellow.TabIndex = 11;
            this.bFTrackYellow.Value = 0;
            // 
            // bfTrackRed
            // 
            this.bfTrackRed.BackColor = System.Drawing.Color.Transparent;
            this.bfTrackRed.BackgroudColor = System.Drawing.Color.DarkGray;
            this.bfTrackRed.BorderRadius = 0;
            this.bfTrackRed.IndicatorColor = System.Drawing.Color.Red;
            this.bfTrackRed.Location = new System.Drawing.Point(140, 506);
            this.bfTrackRed.MaximumValue = 255;
            this.bfTrackRed.Name = "bfTrackRed";
            this.bfTrackRed.Size = new System.Drawing.Size(415, 28);
            this.bfTrackRed.SliderRadius = 0;
            this.bfTrackRed.TabIndex = 11;
            this.bfTrackRed.Value = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(87, 540);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Vàng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(104, 506);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Đỏ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(71, 574);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Xanh lá";
            // 
            // lbRed
            // 
            this.lbRed.BackColor = System.Drawing.Color.White;
            this.lbRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRed.Location = new System.Drawing.Point(561, 498);
            this.lbRed.Name = "lbRed";
            this.lbRed.Size = new System.Drawing.Size(54, 28);
            this.lbRed.TabIndex = 12;
            // 
            // lbYellow
            // 
            this.lbYellow.BackColor = System.Drawing.Color.White;
            this.lbYellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYellow.Location = new System.Drawing.Point(561, 540);
            this.lbYellow.Name = "lbYellow";
            this.lbYellow.Size = new System.Drawing.Size(54, 28);
            this.lbYellow.TabIndex = 12;
            // 
            // lbGreen
            // 
            this.lbGreen.BackColor = System.Drawing.Color.White;
            this.lbGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGreen.Location = new System.Drawing.Point(561, 577);
            this.lbGreen.Name = "lbGreen";
            this.lbGreen.Size = new System.Drawing.Size(54, 28);
            this.lbGreen.TabIndex = 12;
            // 
            // lbRGB
            // 
            this.lbRGB.AutoSize = true;
            this.lbRGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRGB.Location = new System.Drawing.Point(621, 540);
            this.lbRGB.Name = "lbRGB";
            this.lbRGB.Size = new System.Drawing.Size(45, 20);
            this.lbRGB.TabIndex = 12;
            this.lbRGB.Text = "RGB";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(12, 473);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(237, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Chỉnh màu nền cho trang tại đây";
            // 
            // btE
            // 
            this.btE.Location = new System.Drawing.Point(650, 53);
            this.btE.Name = "btE";
            this.btE.Size = new System.Drawing.Size(47, 23);
            this.btE.TabIndex = 14;
            this.btE.Text = "E";
            this.btE.UseVisualStyleBackColor = true;
            this.btE.Click += new System.EventHandler(this.btE_Click);
            // 
            // btV
            // 
            this.btV.Location = new System.Drawing.Point(703, 53);
            this.btV.Name = "btV";
            this.btV.Size = new System.Drawing.Size(47, 23);
            this.btV.TabIndex = 15;
            this.btV.Text = "V";
            this.btV.UseVisualStyleBackColor = true;
            this.btV.Click += new System.EventHandler(this.btV_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 614);
            this.Controls.Add(this.btV);
            this.Controls.Add(this.btE);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbGreen);
            this.Controls.Add(this.lbYellow);
            this.Controls.Add(this.lbRed);
            this.Controls.Add(this.lbRGB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bfTrackRed);
            this.Controls.Add(this.bFTrackYellow);
            this.Controls.Add(this.bfTrackGreen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVaiTro);
            this.Controls.Add(this.txtTiengViet);
            this.Controls.Add(this.txtTiengAnh);
            this.Controls.Add(this.cbSheet);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.txtTuMuonTim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTuMuonTim;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbSheet;
        private System.Windows.Forms.TextBox txtTiengAnh;
        private System.Windows.Forms.TextBox txtTiengViet;
        private System.Windows.Forms.TextBox txtVaiTro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuTrackbar bfTrackGreen;
        private Bunifu.Framework.UI.BunifuTrackbar bFTrackYellow;
        private Bunifu.Framework.UI.BunifuTrackbar bfTrackRed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbRed;
        private System.Windows.Forms.Label lbYellow;
        private System.Windows.Forms.Label lbGreen;
        private System.Windows.Forms.Label lbRGB;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btE;
        private System.Windows.Forms.Button btV;
    }
}

