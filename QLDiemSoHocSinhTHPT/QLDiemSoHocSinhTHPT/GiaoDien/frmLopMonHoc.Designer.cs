namespace QLDiemSoHocSinhTHPT.GiaoDien
{
    partial class frmLopMonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLopMonHoc));
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbNamHoc = new System.Windows.Forms.ComboBox();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.cmbKhoiLop = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbLop = new System.Windows.Forms.Label();
            this.lbNamHoc = new System.Windows.Forms.Label();
            this.lbKhoiLop = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvDMMonHoc = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.botBoQua = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btRemoveAll = new System.Windows.Forms.Button();
            this.btRemoveSelected = new System.Windows.Forms.Button();
            this.btAddSelected = new System.Windows.Forms.Button();
            this.btAddAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvDSMonHocDuocChon = new System.Windows.Forms.ListView();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel4.Controls.Add(this.cmbNamHoc);
            this.panel4.Controls.Add(this.cmbLop);
            this.panel4.Controls.Add(this.cmbKhoiLop);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.lbLop);
            this.panel4.Controls.Add(this.lbNamHoc);
            this.panel4.Controls.Add(this.lbKhoiLop);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(944, 84);
            this.panel4.TabIndex = 0;
            // 
            // cmbNamHoc
            // 
            this.cmbNamHoc.FormattingEnabled = true;
            this.cmbNamHoc.Location = new System.Drawing.Point(75, 28);
            this.cmbNamHoc.Name = "cmbNamHoc";
            this.cmbNamHoc.Size = new System.Drawing.Size(121, 21);
            this.cmbNamHoc.TabIndex = 1;
            this.cmbNamHoc.SelectedIndexChanged += new System.EventHandler(this.cmbNamHoc_SelectedIndexChanged);
            // 
            // cmbLop
            // 
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(458, 28);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(121, 21);
            this.cmbLop.TabIndex = 3;
            this.cmbLop.SelectedIndexChanged += new System.EventHandler(this.cmbLop_SelectedIndexChanged);
            // 
            // cmbKhoiLop
            // 
            this.cmbKhoiLop.FormattingEnabled = true;
            this.cmbKhoiLop.Location = new System.Drawing.Point(273, 28);
            this.cmbKhoiLop.Name = "cmbKhoiLop";
            this.cmbKhoiLop.Size = new System.Drawing.Size(121, 21);
            this.cmbKhoiLop.TabIndex = 2;
            this.cmbKhoiLop.SelectedIndexChanged += new System.EventHandler(this.cmbKhoiLop_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-166, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "label1";
            // 
            // lbLop
            // 
            this.lbLop.AutoSize = true;
            this.lbLop.Location = new System.Drawing.Point(424, 31);
            this.lbLop.Name = "lbLop";
            this.lbLop.Size = new System.Drawing.Size(28, 13);
            this.lbLop.TabIndex = 0;
            this.lbLop.Text = "Lớp:";
            // 
            // lbNamHoc
            // 
            this.lbNamHoc.AutoSize = true;
            this.lbNamHoc.Location = new System.Drawing.Point(16, 31);
            this.lbNamHoc.Name = "lbNamHoc";
            this.lbNamHoc.Size = new System.Drawing.Size(53, 13);
            this.lbNamHoc.TabIndex = 0;
            this.lbNamHoc.Text = "Năm học:";
            // 
            // lbKhoiLop
            // 
            this.lbKhoiLop.AutoSize = true;
            this.lbKhoiLop.Location = new System.Drawing.Point(219, 31);
            this.lbKhoiLop.Name = "lbKhoiLop";
            this.lbKhoiLop.Size = new System.Drawing.Size(48, 13);
            this.lbKhoiLop.TabIndex = 0;
            this.lbKhoiLop.Text = "Khối lớp:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 423);
            this.panel1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(944, 423);
            this.splitContainer1.SplitterDistance = 496;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvDMMonHoc);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 423);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh mục môn học";
            // 
            // lvDMMonHoc
            // 
            this.lvDMMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDMMonHoc.FullRowSelect = true;
            this.lvDMMonHoc.Location = new System.Drawing.Point(3, 16);
            this.lvDMMonHoc.Name = "lvDMMonHoc";
            this.lvDMMonHoc.Size = new System.Drawing.Size(436, 404);
            this.lvDMMonHoc.TabIndex = 1;
            this.lvDMMonHoc.UseCompatibleStateImageBehavior = false;
            this.lvDMMonHoc.View = System.Windows.Forms.View.List;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.botBoQua);
            this.panel2.Controls.Add(this.btThoat);
            this.panel2.Controls.Add(this.btLuu);
            this.panel2.Controls.Add(this.btRemoveAll);
            this.panel2.Controls.Add(this.btRemoveSelected);
            this.panel2.Controls.Add(this.btAddSelected);
            this.panel2.Controls.Add(this.btAddAll);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(442, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(54, 423);
            this.panel2.TabIndex = 0;
            // 
            // botBoQua
            // 
            this.botBoQua.Image = ((System.Drawing.Image)(resources.GetObject("botBoQua.Image")));
            this.botBoQua.Location = new System.Drawing.Point(3, 240);
            this.botBoQua.Name = "botBoQua";
            this.botBoQua.Size = new System.Drawing.Size(47, 35);
            this.botBoQua.TabIndex = 9;
            this.botBoQua.UseVisualStyleBackColor = true;
            this.botBoQua.Click += new System.EventHandler(this.botBoQua_Click);
            // 
            // btThoat
            // 
            this.btThoat.Image = ((System.Drawing.Image)(resources.GetObject("btThoat.Image")));
            this.btThoat.Location = new System.Drawing.Point(3, 281);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(47, 35);
            this.btThoat.TabIndex = 10;
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btLuu
            // 
            this.btLuu.Image = ((System.Drawing.Image)(resources.GetObject("btLuu.Image")));
            this.btLuu.Location = new System.Drawing.Point(3, 199);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(47, 35);
            this.btLuu.TabIndex = 8;
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btRemoveAll
            // 
            this.btRemoveAll.Location = new System.Drawing.Point(3, 158);
            this.btRemoveAll.Name = "btRemoveAll";
            this.btRemoveAll.Size = new System.Drawing.Size(47, 35);
            this.btRemoveAll.TabIndex = 7;
            this.btRemoveAll.Text = "<<";
            this.btRemoveAll.UseVisualStyleBackColor = true;
            this.btRemoveAll.Click += new System.EventHandler(this.btRemoveAll_Click);
            // 
            // btRemoveSelected
            // 
            this.btRemoveSelected.Location = new System.Drawing.Point(3, 117);
            this.btRemoveSelected.Name = "btRemoveSelected";
            this.btRemoveSelected.Size = new System.Drawing.Size(47, 35);
            this.btRemoveSelected.TabIndex = 6;
            this.btRemoveSelected.Text = "<";
            this.btRemoveSelected.UseVisualStyleBackColor = true;
            this.btRemoveSelected.Click += new System.EventHandler(this.btRemoveSelected_Click);
            // 
            // btAddSelected
            // 
            this.btAddSelected.Location = new System.Drawing.Point(3, 76);
            this.btAddSelected.Name = "btAddSelected";
            this.btAddSelected.Size = new System.Drawing.Size(47, 35);
            this.btAddSelected.TabIndex = 5;
            this.btAddSelected.Text = ">";
            this.btAddSelected.UseVisualStyleBackColor = true;
            this.btAddSelected.Click += new System.EventHandler(this.btAddSelected_Click);
            // 
            // btAddAll
            // 
            this.btAddAll.Location = new System.Drawing.Point(3, 35);
            this.btAddAll.Name = "btAddAll";
            this.btAddAll.Size = new System.Drawing.Size(47, 35);
            this.btAddAll.TabIndex = 4;
            this.btAddAll.Text = ">>";
            this.btAddAll.UseVisualStyleBackColor = true;
            this.btAddAll.Click += new System.EventHandler(this.btAddAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvDSMonHocDuocChon);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 423);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách môn học được chọn";
            // 
            // lvDSMonHocDuocChon
            // 
            this.lvDSMonHocDuocChon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDSMonHocDuocChon.Location = new System.Drawing.Point(3, 16);
            this.lvDSMonHocDuocChon.Name = "lvDSMonHocDuocChon";
            this.lvDSMonHocDuocChon.Size = new System.Drawing.Size(441, 404);
            this.lvDSMonHocDuocChon.TabIndex = 0;
            this.lvDSMonHocDuocChon.UseCompatibleStateImageBehavior = false;
            this.lvDSMonHocDuocChon.View = System.Windows.Forms.View.List;
            // 
            // frmLopMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 507);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLopMonHoc";
            this.Text = "Lop - Mon hoc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLopMonHoc_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbNamHoc;
        private System.Windows.Forms.ComboBox cmbKhoiLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbNamHoc;
        private System.Windows.Forms.Label lbKhoiLop;
        private System.Windows.Forms.ComboBox cmbLop;
        private System.Windows.Forms.Label lbLop;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btRemoveAll;
        private System.Windows.Forms.Button btRemoveSelected;
        private System.Windows.Forms.Button btAddSelected;
        private System.Windows.Forms.Button btAddAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvDMMonHoc;
        private System.Windows.Forms.ListView lvDSMonHocDuocChon;
        private System.Windows.Forms.Button botBoQua;
    }
}