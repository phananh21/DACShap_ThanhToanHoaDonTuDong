using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PhanMemThanhToanHoaDonDienThoai
{
    public partial class frmHoaDon : System.Windows.Forms.Form
    {
        public frmDanhMucSP frm1;
        public string HoTenKH { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string ThanhPho { get; set; }
        public string NhanHang { get; set; }
        public string ThanhToan { get; set; }
        public string Ngay { get; set; }
        public bool HSSV { get; set; }

        public DataTable datatable;
        public frmHoaDon(DataTable dt)
        {
            InitializeComponent();
            this.datatable = dt;
            LoadData(dt);
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            txtHTHoTenKH.Text = HoTenKH;
            txtHTSDT.Text = SDT;
            txtHTDiaChi.Text = DiaChi + ", " + ThanhPho;
            txtNhanHang.Text = NhanHang;
            txtThanhToan.Text = ThanhToan;
            txtMaHD.Text = "VNPUNI-" + DateTime.Now.ToString("yyyyMMddHHmmss");
            if (HSSV)
            {
                txtMaHD.Text += "HSSV";
            }
            txtNgay.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            txtNgaySinh.Text = Ngay;
        }

        public void LoadData(DataTable dt)
        {
            dgvHoaDon.DataSource = datatable;
            dgvHoaDon.Columns[0].Width = 50;
            dgvHoaDon.Columns[1].Width = 150;
            dgvHoaDon.Columns[2].Width = 180;
            dgvHoaDon.Columns[3].Width = 120;
            dgvHoaDon.Columns[5].Width = 160;
            dgvHoaDon.Columns[6].Width = 150;

            dgvHoaDon.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 11, FontStyle.Bold);
            dgvHoaDon.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHoaDon.Columns["STT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHoaDon.Columns["SỐ LƯỢNG"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHoaDon.DefaultCellStyle.Font = new Font("Times New Roman", 11);
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn quay lại đặt hàng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) Close();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn kết thúc thanh toán?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    Application.OpenForms[i].Close();
                }
                Application.Exit();
            }
        }

        private void lblTenCTy_Click(object sender, EventArgs e)
        {

        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
