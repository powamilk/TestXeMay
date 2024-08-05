namespace XeMays.Present
{
    partial class Form1
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
            dgv_xemay = new DataGridView();
            btn_them = new Button();
            btn_sua = new Button();
            btn_xoa = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_ten = new TextBox();
            txt_hang = new TextBox();
            txt_gia = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_xemay).BeginInit();
            SuspendLayout();
            // 
            // dgv_xemay
            // 
            dgv_xemay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_xemay.Location = new Point(26, 280);
            dgv_xemay.Name = "dgv_xemay";
            dgv_xemay.Size = new Size(1029, 267);
            dgv_xemay.TabIndex = 0;
            dgv_xemay.CellClick += dgv_xemay_CellClick;
            // 
            // btn_them
            // 
            btn_them.Location = new Point(653, 25);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(205, 64);
            btn_them.TabIndex = 1;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(653, 104);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(205, 64);
            btn_sua.TabIndex = 2;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(653, 183);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(205, 64);
            btn_xoa.TabIndex = 3;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 90);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 4;
            label1.Text = "Tên";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 172);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 5;
            label2.Text = "Hãng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 132);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 6;
            label3.Text = "Giá";
            // 
            // txt_ten
            // 
            txt_ten.Location = new Point(139, 87);
            txt_ten.Name = "txt_ten";
            txt_ten.Size = new Size(252, 23);
            txt_ten.TabIndex = 7;
            // 
            // txt_hang
            // 
            txt_hang.Location = new Point(139, 172);
            txt_hang.Name = "txt_hang";
            txt_hang.Size = new Size(252, 23);
            txt_hang.TabIndex = 8;
            // 
            // txt_gia
            // 
            txt_gia.Location = new Point(139, 129);
            txt_gia.Name = "txt_gia";
            txt_gia.Size = new Size(252, 23);
            txt_gia.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 559);
            Controls.Add(txt_gia);
            Controls.Add(txt_hang);
            Controls.Add(txt_ten);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_xoa);
            Controls.Add(btn_sua);
            Controls.Add(btn_them);
            Controls.Add(dgv_xemay);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_xemay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_xemay;
        private Button btn_them;
        private Button btn_sua;
        private Button btn_xoa;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_ten;
        private TextBox txt_hang;
        private TextBox txt_gia;
    }
}
