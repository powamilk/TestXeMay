using System.Diagnostics;
using XeMays.BUS.ViewModel;
using XeMays.BUS.Implement;
using XeMays.BUS.Interface;
using XeMays.DAL.Entities;
using XeMays.Present.Extensions;

namespace XeMays.Present
{
    public partial class Form1 : Form
    {
        List<XeMayVM> _xeMays;
        IXeMayService _xeMayService;
        private int _maXeMayChon;
        public Form1()
        {
            InitializeComponent();
            _xeMayService = new XeMayService();
            _xeMays = new List<XeMayVM>();
            LoadFormData();
            LoadGridData();
        }

        private void LoadFormData()
        {
            dgv_xemay.Columns.Clear();
            dgv_xemay.Columns.Add("clm1", "STT");
            dgv_xemay.Columns.Add("clm2", "Ma");
            dgv_xemay.Columns.Add("clm3", "Ten");
            dgv_xemay.Columns.Add("clm4", "Gia");
            dgv_xemay.Columns.Add("clm5", "Hang");
        }

        private void LoadGridData()
        {
            dgv_xemay.Rows.Clear();
            var xeMays = _xeMayService.GetList();

            Debug.WriteLine($"Số lượng xe máy: {xeMays.Count}");

            foreach (var xeMay in xeMays)
            {
                dgv_xemay.Rows.Add(
                    (xeMays.IndexOf(xeMay) + 1),
                    xeMay.Id,
                    xeMay.TenXe,
                    xeMay.Gia,
                    xeMay.IdHang
                );
            }
        }

        private int TaoIdXeMay()
        {
            var xeMays = _xeMayService.GetList();
            int maxId = xeMays.Count > 0 ? xeMays.Max(xe => xe.Id) : 0;
            return maxId + 1;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (MessageBoxExtension.Confirm("thêm"))
            {
                bool isGiaValid = double.TryParse(txt_gia.Text, out double gia);
                bool isIdHangValid = int.TryParse(txt_hang.Text, out int idHang);
                if (string.IsNullOrEmpty(txt_ten.Text) || !isGiaValid || gia <= 0 || !isIdHangValid)
                {
                    MessageBoxExtension.Notification("THÊM", "Tên không được để trống và giá cũng như mã hãng phải là số dương hợp lệ.");
                    return;
                }

                var xeMayCreate = new XeMayCreateVM
                {
                    Id = TaoIdXeMay(),
                    TenXe = txt_ten.Text,
                    IdHang = idHang,
                    Gia = gia
                };
                var result = _xeMayService.Create(xeMayCreate);

                MessageBoxExtension.Notification("THÊM", result);
                LoadGridData();
            }

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (dgv_xemay.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm từ danh sách để chỉnh sửa.", "CHỈNH SỬA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int selectedId = Convert.ToInt32(dgv_xemay.SelectedRows[0].Cells["clm2"].Value);
            bool isGiaValid = double.TryParse(txt_gia.Text, out double gia);
            bool isIdHangValid = int.TryParse(txt_hang.Text, out int idHang);

            if (!isGiaValid || gia <= 0 || !isIdHangValid || idHang <= 0)
            {
                MessageBox.Show("Giá và mã hãng phải là số dương hợp lệ.", "CHỈNH SỬA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var xeMayUpdateVM = new XeMayUpdateVM
            {
                Id = selectedId,
                TenXe = txt_ten.Text,
                IdHang = idHang,
                Gia = gia
            };
            var result = _xeMayService.Update(xeMayUpdateVM);
            string msg = result ? "Chỉnh sửa thành công" : "Chỉnh sửa thất bại";
            MessageBox.Show(msg, "CHỈNH SỬA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadGridData();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dgv_xemay.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm từ danh sách để xóa.", "XÓA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int selectedId = Convert.ToInt32(dgv_xemay.SelectedRows[0].Cells["clm2"].Value);

            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                var result = _xeMayService.Delete(selectedId);
                string msg = result ? "Xóa thành công" : "Xóa thất bại";
                MessageBox.Show(msg, "XÓA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGridData();
            }
        }

        private void dgv_xemay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;

            if (index < 0 || index >= _xeMays.Count)
            {
                _maXeMayChon = 0;
                return;
            }
            var xeMayChon = _xeMays.ElementAt(index);

            _maXeMayChon = xeMayChon.Id;
            txt_ten.Text = xeMayChon.TenXe;
            txt_hang.Text = xeMayChon.IdHang.ToString();
            txt_gia.Text = xeMayChon.Gia.ToString();
        }
    }
}
