namespace LinqToObject
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.luuSP = new System.Windows.Forms.Button();
			this.ngayHetHan = new System.Windows.Forms.DateTimePicker();
			this.xuatXu = new System.Windows.Forms.TextBox();
			this.tenSP = new System.Windows.Forms.TextBox();
			this.maSP = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.filteredProduct = new System.Windows.Forms.DataGridView();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.allProduct = new System.Windows.Forms.DataGridView();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.deleteByXuatXu = new System.Windows.Forms.TextBox();
			this.button10 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.sl = new System.Windows.Forms.NumericUpDown();
			this.donGia = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.gtria = new System.Windows.Forms.NumericUpDown();
			this.gtrib = new System.Windows.Forms.NumericUpDown();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.filteredProduct)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.allProduct)).BeginInit();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.donGia)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gtria)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gtrib)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.donGia);
			this.groupBox1.Controls.Add(this.sl);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.luuSP);
			this.groupBox1.Controls.Add(this.ngayHetHan);
			this.groupBox1.Controls.Add(this.xuatXu);
			this.groupBox1.Controls.Add(this.tenSP);
			this.groupBox1.Controls.Add(this.maSP);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(269, 253);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Nhập Thông Tin Sản Phẩm";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(135, 224);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 13;
			this.button2.Text = "Xóa SP";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// luuSP
			// 
			this.luuSP.Location = new System.Drawing.Point(41, 224);
			this.luuSP.Name = "luuSP";
			this.luuSP.Size = new System.Drawing.Size(75, 23);
			this.luuSP.TabIndex = 12;
			this.luuSP.Text = "Lưu SP";
			this.luuSP.UseVisualStyleBackColor = true;
			this.luuSP.Click += new System.EventHandler(this.luuSP_Click);
			// 
			// ngayHetHan
			// 
			this.ngayHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.ngayHetHan.Location = new System.Drawing.Point(123, 193);
			this.ngayHetHan.Name = "ngayHetHan";
			this.ngayHetHan.Size = new System.Drawing.Size(116, 22);
			this.ngayHetHan.TabIndex = 11;
			// 
			// xuatXu
			// 
			this.xuatXu.Location = new System.Drawing.Point(123, 157);
			this.xuatXu.Name = "xuatXu";
			this.xuatXu.Size = new System.Drawing.Size(116, 22);
			this.xuatXu.TabIndex = 10;
			// 
			// tenSP
			// 
			this.tenSP.Location = new System.Drawing.Point(123, 66);
			this.tenSP.Name = "tenSP";
			this.tenSP.Size = new System.Drawing.Size(116, 22);
			this.tenSP.TabIndex = 7;
			// 
			// maSP
			// 
			this.maSP.Location = new System.Drawing.Point(123, 36);
			this.maSP.Name = "maSP";
			this.maSP.Size = new System.Drawing.Size(116, 22);
			this.maSP.TabIndex = 6;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(24, 193);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(92, 16);
			this.label6.TabIndex = 5;
			this.label6.Text = "Ngày Hết Hạn";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(24, 157);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(51, 16);
			this.label5.TabIndex = 4;
			this.label5.Text = "Xuất Xứ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(24, 128);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "Đơn Giá";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã SP ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(24, 97);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Số Lượng ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(24, 69);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Tên SP ";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.gtrib);
			this.groupBox2.Controls.Add(this.gtria);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.filteredProduct);
			this.groupBox2.Controls.Add(this.button6);
			this.groupBox2.Controls.Add(this.button5);
			this.groupBox2.Controls.Add(this.button4);
			this.groupBox2.Controls.Add(this.button3);
			this.groupBox2.Location = new System.Drawing.Point(257, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(531, 253);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Chọn Chức Năng Tìm Kiếm";
			// 
			// filteredProduct
			// 
			this.filteredProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.filteredProduct.Location = new System.Drawing.Point(7, 87);
			this.filteredProduct.Name = "filteredProduct";
			this.filteredProduct.RowHeadersWidth = 51;
			this.filteredProduct.RowTemplate.Height = 24;
			this.filteredProduct.Size = new System.Drawing.Size(518, 160);
			this.filteredProduct.TabIndex = 6;
			// 
			// button6
			// 
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.Location = new System.Drawing.Point(308, 22);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(120, 50);
			this.button6.TabIndex = 3;
			this.button6.Text = "Xuất Các SP Có ĐG Từ a..b";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(200, 22);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(102, 50);
			this.button5.TabIndex = 2;
			this.button5.Text = "Xuất Toàn Bộ SP Quá Hạn ";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(104, 21);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(90, 50);
			this.button4.TabIndex = 1;
			this.button4.Text = "Một SP Từ Nhật Bản";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(0, 22);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(98, 50);
			this.button3.TabIndex = 0;
			this.button3.Text = "Một SP Có ĐG Cao Nhất ";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.allProduct);
			this.groupBox3.Location = new System.Drawing.Point(13, 271);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(474, 192);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Danh Sách Các Sản Phẩm Sau Khi Nhập";
			// 
			// allProduct
			// 
			this.allProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.allProduct.Location = new System.Drawing.Point(6, 16);
			this.allProduct.Name = "allProduct";
			this.allProduct.RowHeadersWidth = 51;
			this.allProduct.RowTemplate.Height = 24;
			this.allProduct.Size = new System.Drawing.Size(462, 170);
			this.allProduct.TabIndex = 0;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.deleteByXuatXu);
			this.groupBox4.Controls.Add(this.button10);
			this.groupBox4.Controls.Add(this.button9);
			this.groupBox4.Controls.Add(this.button8);
			this.groupBox4.Controls.Add(this.button7);
			this.groupBox4.Location = new System.Drawing.Point(493, 271);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(295, 192);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Chọn Thao Tác";
			// 
			// deleteByXuatXu
			// 
			this.deleteByXuatXu.Location = new System.Drawing.Point(138, 34);
			this.deleteByXuatXu.Name = "deleteByXuatXu";
			this.deleteByXuatXu.Size = new System.Drawing.Size(130, 22);
			this.deleteByXuatXu.TabIndex = 4;
			// 
			// button10
			// 
			this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button10.Location = new System.Drawing.Point(151, 134);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(117, 46);
			this.button10.TabIndex = 3;
			this.button10.Text = "Xóa Toàn Bộ Các SP Quá Hạn";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.button10_Click);
			// 
			// button9
			// 
			this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button9.Location = new System.Drawing.Point(18, 134);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(127, 46);
			this.button9.TabIndex = 2;
			this.button9.Text = "Xóa Toàn Bộ SP Trong Kho";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(12, 82);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(277, 46);
			this.button8.TabIndex = 1;
			this.button8.Text = "Kiểm Tra Kho Có SP Quá Hạn Hay Không";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(27, 21);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(105, 48);
			this.button7.TabIndex = 0;
			this.button7.Text = "Xóa SP Theo Xuất Xứ Bất Kỳ";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// sl
			// 
			this.sl.Location = new System.Drawing.Point(123, 97);
			this.sl.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
			this.sl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.sl.Name = "sl";
			this.sl.Size = new System.Drawing.Size(116, 22);
			this.sl.TabIndex = 14;
			this.sl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// donGia
			// 
			this.donGia.Location = new System.Drawing.Point(123, 128);
			this.donGia.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
			this.donGia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.donGia.Name = "donGia";
			this.donGia.Size = new System.Drawing.Size(116, 22);
			this.donGia.TabIndex = 15;
			this.donGia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(510, 23);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(15, 16);
			this.label7.TabIndex = 7;
			this.label7.Text = "a";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(510, 52);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(15, 16);
			this.label8.TabIndex = 8;
			this.label8.Text = "b";
			// 
			// gtria
			// 
			this.gtria.Location = new System.Drawing.Point(434, 21);
			this.gtria.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
			this.gtria.Name = "gtria";
			this.gtria.Size = new System.Drawing.Size(70, 22);
			this.gtria.TabIndex = 9;
			// 
			// gtrib
			// 
			this.gtrib.Location = new System.Drawing.Point(434, 50);
			this.gtrib.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
			this.gtrib.Name = "gtrib";
			this.gtrib.Size = new System.Drawing.Size(70, 22);
			this.gtrib.TabIndex = 10;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 475);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Linq To Object";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.filteredProduct)).EndInit();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.allProduct)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.sl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.donGia)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gtria)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gtrib)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button luuSP;
		private System.Windows.Forms.DateTimePicker ngayHetHan;
		private System.Windows.Forms.TextBox xuatXu;
		private System.Windows.Forms.TextBox tenSP;
		private System.Windows.Forms.TextBox maSP;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.DataGridView filteredProduct;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DataGridView allProduct;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox deleteByXuatXu;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.NumericUpDown donGia;
		private System.Windows.Forms.NumericUpDown sl;
		private System.Windows.Forms.NumericUpDown gtrib;
		private System.Windows.Forms.NumericUpDown gtria;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
	}
}

