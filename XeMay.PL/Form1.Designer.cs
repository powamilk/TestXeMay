namespace XeMay.PL
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
            this.dgv_xemay = new System.Windows.Forms.DataGridView();
            this.lb_ten = new System.Windows.Forms.Label();
            this.lb_xoa = new System.Windows.Forms.Label();
            this.lb_sua = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_xemay)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_xemay
            // 
            this.dgv_xemay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_xemay.Location = new System.Drawing.Point(12, 288);
            this.dgv_xemay.Name = "dgv_xemay";
            this.dgv_xemay.Size = new System.Drawing.Size(1146, 300);
            this.dgv_xemay.TabIndex = 0;
            // 
            // lb_ten
            // 
            this.lb_ten.AutoSize = true;
            this.lb_ten.Location = new System.Drawing.Point(48, 87);
            this.lb_ten.Name = "lb_ten";
            this.lb_ten.Size = new System.Drawing.Size(26, 13);
            this.lb_ten.TabIndex = 1;
            this.lb_ten.Text = "Tên";
            // 
            // lb_xoa
            // 
            this.lb_xoa.AutoSize = true;
            this.lb_xoa.Location = new System.Drawing.Point(48, 197);
            this.lb_xoa.Name = "lb_xoa";
            this.lb_xoa.Size = new System.Drawing.Size(33, 13);
            this.lb_xoa.TabIndex = 2;
            this.lb_xoa.Text = "Hãng";
            // 
            // lb_sua
            // 
            this.lb_sua.AutoSize = true;
            this.lb_sua.Location = new System.Drawing.Point(48, 143);
            this.lb_sua.Name = "lb_sua";
            this.lb_sua.Size = new System.Drawing.Size(23, 13);
            this.lb_sua.TabIndex = 3;
            this.lb_sua.Text = "Giá";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(368, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(89, 143);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(368, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(89, 194);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(368, 20);
            this.textBox3.TabIndex = 6;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(779, 67);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(184, 52);
            this.btn_them.TabIndex = 7;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(779, 143);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(184, 52);
            this.btn_sua.TabIndex = 8;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(779, 210);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(184, 52);
            this.btn_xoa.TabIndex = 9;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 600);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_sua);
            this.Controls.Add(this.lb_xoa);
            this.Controls.Add(this.lb_ten);
            this.Controls.Add(this.dgv_xemay);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_xemay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_xemay;
        private System.Windows.Forms.Label lb_ten;
        private System.Windows.Forms.Label lb_xoa;
        private System.Windows.Forms.Label lb_sua;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
    }
}

