using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemThanhToanHoaDonDienThoai
{
    public partial class frmDanhMucSP : System.Windows.Forms.Form
    {
        public frmDanhMucSP()
        {
            InitializeComponent();
            LoadDataGridView();
            DataDienThoai();
            DataThanhPho();
            dtpNgaySinh.ValueChanged += new EventHandler(dtpNgaySinh_ValueChanged);
        }

        private Dictionary<string, List<string>> ThanhPho;
        private void DataThanhPho()
        {
            ThanhPho = new Dictionary<string, List<string>>

            {
                {
                    "Thành phố Hồ Chí Minh", new List <string>
                    {

                    }
                },
                {
                    "Thành phố Hà Nội", new List <string>
                    {
                        "Quận Ba Đình", "Quận Hoàn Kiếm", "Quận Tây Hồ", "Quận Long Biên", "Quận Cầu Giấy", "Quận Đống Đa", "Quận Hai Bà Trưng",
                        "Quận Hoàng Mai", "Quận Thanh Xuân", "Quận Nam Từ Liêm", "Quận Bắc Từ Liêm", "Quận Hà Đông", "Thị xã Sơn Tây", "Huyện Ba Vì",
                        "Huyện Chương Mỹ", "Huyện Phúc Thọ", "Huyện Đan Phượng", "Huyện Đông Anh", "Huyện Gia Lâm", "Huyện Hoài Đức", "Huyện Mê Linh",
                        "Huyện Mỹ Đức", "Huyện Phú Xuyên", "Huyện Quốc Oai", "Huyện Sóc Sơn", "Huyện Thạch Thất", "Huyện Thanh Oai", "Huyện Thường Tín",
                        "Huyện Ứng Hòa", "Huyện Thanh Trì"
                    }
                },
                {
                    "Tỉnh Hà Giang", new List <string>
                    {
                        "Thành phố Hà Giang", "Huyện Mèo Vạc", "Huyện Yên Minh", "Huyện Quản Bạ", "Huyện Hoàng Su Phì", "Huyện Đồng Văn",
                        "Huyện Bắc Mê", "Huyện Bắc Quang", "Huyện Quang Bình", "Huyện Xín Mần", "Huyện Vị Xuyên"
                    }
                },
                {
                    "Tỉnh Cao Bằng", new List <string>
                    {
                        "Thành phố Cao Bằng", "Huyện Bảo Lạc", "Huyện Bảo Lâm", "Huyện Hạ Lang", "Huyện Hà Quảng",
                        "Huyện Hòa An", "Huyện Nguyên Bình", "Huyện Quảng Hòa", "Huyện Thạch An", "Huyện Trùng Khánh"
                    }
                },
                {
                    "Tỉnh Bắc Kạn", new List <string>
                    {
                        "Thành phố Bắc Kạn", "Huyện Ba Bể", "Huyện Bạch Thông", "Huyện Chợ Đồn",
                        "Huyện Chợ Mới", "Huyện Na Rì", "Huyện Ngân Sơn", "Huyện Pác Nặm"
                    }
                },
                {
                    "Tỉnh Tuyên Quang", new List <string>
                    {
                        "Thành phố Tuyên Quang", "Huyện Lâm Bình", "Huyện Na Hang", "Huyện Chiêm Hóa",
                        "Huyện Hàm Yên", "Huyện Yên Sơn", "Huyện Sơn Dương"
                    }
                },
                {
                    "Tỉnh Lào Cai", new List <string>
                    {
                        "Thành phố Lào Cai", "Huyện Bát Xát", "Huyện Mường Khương", "Huyện Si Ma Cai",
                        "Huyện Bắc Hà", "Huyện Bảo Thắng", "Huyện Bảo Yên", "Thị xã Sa Pa", "Huyện Văn Bàn"
                    }
                },
                {
                    "Tỉnh Điện Biên", new List <string>
                    {
                        "Thành phố Điện Biên Phủ", "Thị xã Mường Lay", "Huyện Điện Biên", "Huyện Điện Biên Đông", "Huyện Mường Ảng",
                        "Huyện Mường Chà","Huyện Mường Nhé","Huyện Nậm Pồ", "Huyện Tủa Chùa", "Huyện Tuần Giáo"
                    }
                },
                {
                    "Tỉnh Lai Châu", new List <string>
                    {
                        "Thành phố Lai Châu", "Huyện Mường Tè", "Huyện Phong Thổ", "Huyện Sìn Hồ",
                        "Huyện Tam Đường", "Huyện Than Uyên", "Huyện Tân Uyên", "Huyện Nậm Nhùn"
                    }
                },
                {
                    "Tỉnh Sơn La", new List <string>
                    {
                        "Thành phố Sơn La", "Huyện Bắc Yên", "Huyện Mai Sơn", "Huyện Mộc Châu", "Huyện Mường La","Huyện Phù Yên",
                        "Huyện Quỳnh Nhai", "Huyện Sông Mã", "Huyện Sốp Cộp", "Huyện Thuận Châu", "Huyện Vân Hồ", "Huyện Yên Châu"
                    }
                },
                {
                    "Tỉnh Yên Bái", new List <string>
                    {
                        "Thành phố Yên Bái", "Thị xã Nghĩa Lộ", "Huyện Yên Bình", "Huyện Lục Yên", "Huyện Văn Chấn",
                        "Huyện Văn Yên", "Huyện Trấn Yên", "Huyện Trạm Tấu", "Huyện Mù Cang Chải"
                    }
                },
                {
                    "Tỉnh Hòa Bình", new List <string>
                    {
                        "Thành phố Hòa Bình", "Huyện Cao Phong", "Huyện Đà Bắc", "Huyện Kim Bôi", "Huyện Lạc Sơn", "Huyện Lạc Thủy",
                        "Huyện Lương Sơn", "Huyện Mai Châu", "Huyện Tân Lạc", "Huyện Yên Thủy", "Huyện Kỳ Sơn"
                    }
                },
                {
                    "Tỉnh Thái Nguyên", new List <string>
                    {
                        "Thành phố Sông Công", "Thành phố Thái Nguyên", "Thành phố Phổ Yên", "Huyện Đại Từ",
                        "Huyện Định Hóa","Huyện Đồng Hỷ", "Huyện Phú Bình", "Huyện Phú Lương", "Huyện Võ Nhai"
                    }
                },
                {
                    "Tỉnh Lạng Sơn", new List <string>
                    {
                        "Thành phố Lạng Sơn", "Huyện Bắc Sơn", "Huyện Bình Gia", "Huyện Cao Lộc", "Huyện Chi Lăng", "Huyện Đình Lập",
                        "Huyện Hữu Lũng", "Huyện Lộc Bình", "Huyện Tràng Định", "Huyện Văn Lãng", "Huyện Văn Quan"
                    }
                },
                {
                    "Tỉnh Quảng Ninh", new List <string>
                    {
                        "Thành phố Cẩm Phả", "Thành phố Hạ Long", "Thành phố Móng Cái", "Thành phố Uông Bí", "Thị xã Đông Triều", "Thị xã Quảng Yên",
                        "Huyện Ba Chẽ", "Huyện Bình Liêu", "Huyện Cô Tô", "Huyện Đầm Hà", "Huyện Hải Hà", "Huyện Tiên Yên", "Huyện Vân Đồn"
                    }
                },
                {
                    "Tỉnh Bắc Giang", new List <string>
                    {
                        "Thành phố Bắc Giang", "Huyện Hiệp Hoà", "Huyện Lạng Giang", "Huyện Lục Nam", "Huyện Lục Ngạn",
                        "Huyện Sơn Động","Huyện Tân Yên", "Huyện Việt Yên", "Huyện Yên Dũng", "Huyện Yên Thế"
                    }
                },
                {
                    "Tỉnh Phú Thọ", new List <string>
                    {

                    }
                },
                {
                    "Tỉnh Vĩnh Phúc", new List <string>
                    {

                    }
                },
                {
                    "Tỉnh Bắc Ninh", new List <string>
                    {

                    }
                },
                {
                    "Tỉnh Hải Dương", new List <string>
                    {

                    }
                },
                {
                    "Thành phố Hải Phòng", new List <string>
                    {

                    }
                },
                {
                    "Tỉnh Hưng Yên", new List <string>
                    {

                    }
                },
                {
                    "Tỉnh Thái Bình", new List <string>
                    {

                    }
                },
                {
                    "Tỉnh Hà Nam", new List <string>
                    {

                    }
                },
                {
                    "Tỉnh Nam Định", new List <string>
                    {

                    }
                },
                {
                    "Tỉnh Ninh Bình", new List <string>
                    {

                    }
                },
                {
                    "Tỉnh Thanh Hóa", new List <string>
                    {

                    }
                },
                {
                    "Tỉnh Nghệ An", new List <string>
                    {

                    }
                },
                {
                    "Tỉnh Hà Tĩnh", new List <string>
                    {

                    }
                },
                {
                    "Tỉnh Quảng Bình", new List <string>
                    {

                    }
                },
                {
                    "Tỉnh Quảng Trị", new List <string>
                    {

                    }
                },
                {
                    "Tỉnh Thừa Thiên Huế", new List <string>
                    {

                    }
                },
                {
                    "Thành phố Đà Nẵng", new List <string>
                    {

                    }
                },
                {
                    "Tỉnh Quảng Nam", new List <string>
                    {

                    }
                },
                {
                    "Tỉnh Quảng Ngãi", new List <string>
                    {

                    }
                },
                {
                    "Tỉnh Bình Định", new List <string>
                    {

                    }
                },
                {
                    "Tỉnh Phú Yên", new List <string>
                    {

                    }
                },
                {
                    "Tỉnh Khánh Hòa", new List <string>
                    {

                    }
                },
                {
                    "Tỉnh Ninh Thuận", new List <string>
                    {

                    }
                },
                {
                    "Tỉnh Bình Thuận", new List <string>
                    {

                    }
                },
                {
                    "Tỉnh Kon Tum", new List <string>
                    {

                    }
                },
                {
                    "Tỉnh Gia Lai", new List <string>
                    {

                    }
                },
                {
                    "Tỉnh Đắk Lắk", new List <string>
                    {

                    }
                },
                {
                    "Tỉnh Đắk Nông", new List <string>
                    {

                    }
                },
                {
                    "Tỉnh Lâm Đồng", new List <string>
                    {

                    }
                },
                {
                    "Tỉnh Bình Phước", new List <string>
                    {

                    }
                },
                {
                    "Tỉnh Tây Ninh", new List <string>
                    {

                    }
                },
                {
                    "Tỉnh Bình Dương", new List <string>
                    {

                    }
                },
                {
                    "Tỉnh Đồng Nai", new List <string>
                    {

                    }
                },
                {
                    "Tỉnh Bà Rịa - Vũng Tàu", new List <string>
                    {

                    }
                },
                {
                    "Tỉnh Long An", new List <string>
                    {

                    }
                },
                {
                    "Tỉnh Tiền Giang", new List <string>
                    {

                    }
                },
                {
                    "Tỉnh Bến Tre", new List <string>
                    {

                    }
                },
                {
                    "Tỉnh Trà Vinh", new List <string>
                    {

                    }
                },
                {
                    "Tỉnh Vĩnh Long", new List <string>
                    {

                    }
                },
                {
                    "Tỉnh Đồng Tháp", new List <string>
                    {

                    }
                },
                {
                    "Tỉnh An Giang", new List <string>
                    {

                    }
                },
                {
                    "Tỉnh Kiên Giang", new List <string>
                    {

                    }
                },
                {
                    "Thành phố Cần Thơ", new List <string>
                    {

                    }
                },
                {
                    "Tỉnh Hậu Giang", new List <string>
                    {

                    }
                },
                {
                    "Tỉnh Sóc Trăng", new List <string>
                    {

                    }
                },
                {
                    "Tỉnh Bạc Liêu", new List <string>
                    {

                    }
                },
                {
                    "Tỉnh Cà Mau", new List <string>
                    {

                    }
                },
            };
            cboTP.Items.AddRange(ThanhPho.Keys.ToArray());
        }

        //Thêm danh sách điện thoại
        private Dictionary<string, List<string>> DienThoai;
        private void DataDienThoai()
        {
            DienThoai = new Dictionary<string, List<string>>
            {
                {
                    "iPhone", new List<string>
                    {
                        "iPhone 13 Pro",
                        "iPhone 13",
                        "iPhone SE (2022)",
                        "iPhone SE (2020)",
                        "iPhone 12",
                        "iPhone 11",
                        "iPhone XR",
                    }
                },
                {
                    "Samsung", new List<string>
                    {
                        "Samsung Galaxy S22 Ultra",
                        "Samsung Galaxy S22+",
                        "Samsung Galaxy S22",
                        "Samsung Galaxy Z Fold 3",
                        "Samsung Galaxy Z Flip 3",
                        "Samsung Galaxy Note 20 Ultra",
                        "Samsung Galaxy Note 10+",
                         "Samsung Galaxy A53",
                    }
                },
                {
                    "Oppo", new List<string>()
                    {
                        "Oppo Find X5 Pro",
                        "Oppo Find X3 Pro",
                        "Oppo Reno 6 Pro+",
                        "Oppo Reno 6 Pro",
                        "Oppo A95 5G",
                        "Oppo A74",
                        "Oppo A54",
                    }
                }
            };
            cboDongSP.Items.AddRange(DienThoai.Keys.ToArray());
        }

        private void cboDongSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboTenSP.Items.Clear();
            if (cboDongSP.SelectedItem != null)
            {
                string selectedProgram = cboDongSP.SelectedItem.ToString();
                if (DienThoai.ContainsKey(selectedProgram))
                {
                    cboTenSP.Items.AddRange(DienThoai[selectedProgram].ToArray());
                }
            }
        }

        //Hiển thị giá và mã SP
        private void cboTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tensp = cboTenSP.Text;
            string masp = txtMaSP.Text;
            long giasp = 0;

            if (long.TryParse(txtGiaSP.Text, out giasp))
            {
                switch (tensp)
                {
                    case "iPhone 13 Pro":
                        giasp = 27990000;
                        masp = "IP13PR";
                        break;
                    case "iPhone 13 Pro Max":
                        giasp = 29990000;
                        masp = "IP13PRM";
                        break;
                    case "iPhone 13":
                        giasp = 22990000;
                        masp = "IP13";
                        break;
                    case "iPhone SE (2022)":
                        giasp = 14990000;
                        masp = "IPSE2022";
                        break;
                    case "iPhone SE (2020)":
                        giasp = 10990000;
                        masp = "IPSE2020";
                        break;
                    case "iPhone 12":
                        giasp = 18990000;
                        masp = "IP12";
                        break;
                    case "iPhone 11":
                        giasp = 15990000;
                        masp = "IP11";
                        break;
                    case "iPhone XR":
                        giasp = 12990000;
                        masp = "IPXR";
                        break;
                    case "Samsung Galaxy S22 Ultra":
                        giasp = 26990000;
                        masp = "SAS22U";
                        break;
                    case "Samsung Galaxy S22+":
                        giasp = 21990000;
                        masp = "SAS22P";
                        break;
                    case "Samsung Galaxy S22":
                        giasp = 18990000;
                        masp = "SAS22";
                        break;
                    case "Samsung Galaxy Z Fold 3":
                        giasp = 40990000;
                        masp = "SAZFO3";
                        break;
                    case "Samsung Galaxy Z Flip 3":
                        giasp = 2299000;
                        masp = "SAZF3";
                        break;
                    case "Samsung Galaxy Note 20 Ultra":
                        giasp = 22990000;
                        masp = "SAN20U";
                        break;
                    case "Samsung Galaxy Note 10+":
                        giasp = 20990000;
                        masp = "SAN10P";
                        break;
                    case "Samsung Galaxy A53":
                        giasp = 8990000;
                        masp = "SAA53";
                        break;
                    case "Oppo Find X5 Pro":
                        giasp = 21990000;
                        masp = "OPFX5PR";
                        break;
                    case "Oppo Find X3 Pro":
                        giasp = 19990000;
                        masp = "OPFX3PR";
                        break;
                    case "Oppo Reno 6 Pro+":
                        giasp = 16990000;
                        masp = "OPR6PRP";
                        break;
                    case "Oppo Reno 6 Pro":
                        giasp = 1299000;
                        masp = "OPR6PR";
                        break;
                    case "Oppo A95 5G":
                        giasp = 9990000;
                        masp = "OPA955G";
                        break;
                    case "Oppo A74":
                        giasp = 7490000;
                        masp = "OPA74";
                        break;
                    case "Oppo A54":
                        giasp = 5990000;
                        masp = "OPA54";
                        break;
                    default:
                        break;
                }
            }
            txtGiaSP.Text = giasp.ToString();
            txtMaSP.Text = masp.ToString();
        }

        private void frmDanhMucSP_Load(object sender, EventArgs e)
        {
            cboDongSP.SelectedIndexChanged += cboDongSP_SelectedIndexChanged;
            cboTenSP.SelectedIndexChanged += cboTenSP_SelectedIndexChanged;
        }

        public DataTable datatable = new DataTable();
        public void LoadDataGridView()
        {
            datatable = new DataTable();
            datatable.Columns.Add("STT", typeof(int));
            datatable.Columns["STT"].AutoIncrement = true;
            datatable.Columns["STT"].AutoIncrementSeed = 1;
            datatable.Columns["STT"].AutoIncrementStep = 1;
            datatable.Columns.Add("MÃ SẢN PHẨM");
            datatable.Columns.Add("TÊN SẢN PHẨM");
            datatable.Columns.Add("SỐ LƯỢNG");
            datatable.Columns.Add("ĐƠN GIÁ");
            datatable.Columns.Add("KHUYẾN MÃI", typeof(string));
            datatable.Columns.Add("THÀNH TIỀN", typeof(long));
            dgvDanhMucSP.DataSource = datatable;
            dgvDanhMucSP.Columns[0].Width = 50;
            dgvDanhMucSP.Columns[1].Width = 130;
            dgvDanhMucSP.Columns[2].Width = 180;
            dgvDanhMucSP.Columns[3].Width = 100;
            dgvDanhMucSP.Columns[5].Width = 170;
            dgvDanhMucSP.Columns[6].Width = 150;

            dgvDanhMucSP.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 11, FontStyle.Bold);
            dgvDanhMucSP.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDanhMucSP.Columns["STT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDanhMucSP.Columns["SỐ LƯỢNG"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDanhMucSP.DefaultCellStyle.Font = new Font("Times New Roman", 11);
        }

        private bool btnTienVATClicked = false;
        private bool btnThemSPCliked = false;
        //Thêm sản phẩm vào bảng
        private void btnThemSP_Click(object sender, EventArgs e)
        {
            btnThemSPCliked = true;
            if (btnTienVATClicked)
            {
                MessageBox.Show("Vui lòng reset trước khi thêm sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                //Kiểm tra chọn ComboBox DongSP
                if (string.IsNullOrWhiteSpace(cboDongSP.Text))
                {
                    MessageBox.Show("Vui lòng chọn dòng sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //Kiểm tra chọn ComboBox TenSP
                if (string.IsNullOrWhiteSpace(cboTenSP.Text))
                {
                    MessageBox.Show("Vui lòng chọn tên sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //Kiểm tra nhập số lượng
                if (string.IsNullOrWhiteSpace(txtSoLuong.Text))
                {
                    MessageBox.Show("Vui lòng nhập số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtSoLuong.Text, out int SoLuong) || SoLuong <= 0)
                {
                    MessageBox.Show("Số lượng không hợp lệ! Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Kiểm tra mã sản phẩm đã tồn tại trong DataTable chưa
                string maSP = txtMaSP.Text;
                bool SPtrung = false;
                foreach (DataRow row in datatable.Rows)
                {
                    if (row["MÃ SẢN PHẨM"].ToString() == maSP)
                    {
                        // Cộng dồn số lượng
                        int SLcu = Convert.ToInt32(row["SỐ LƯỢNG"]);
                        row["SỐ LƯỢNG"] = SLcu + SoLuong;

                        // Cập nhật lại thành tiền
                        long DonGia = Convert.ToInt64(row["ĐƠN GIÁ"]);
                        long ThanhTien = DonGia * (SLcu + SoLuong);
                        long KhuyenMai = 0;

                        // Áp dụng khuyến mãi nếu cần
                        if (chkHSSV.Checked)
                        {
                            KhuyenMai = (long)(ThanhTien * 0.05);
                            ThanhTien = ThanhTien - KhuyenMai;
                        }
                        row["KHUYẾN MÃI"] = KhuyenMai.ToString();
                        row["THÀNH TIỀN"] = ThanhTien.ToString();
                        SPtrung = true;
                        break;
                    }
                }

                // Nếu SP chưa tồn tại, thêm mới vào DataTable
                if (!SPtrung)
                {
                    long DonGia = long.Parse(txtGiaSP.Text);
                    long ThanhTien = DonGia * SoLuong;
                    long KhuyenMai = 0;

                    // Áp dụng khuyến mãi nếu cần
                    if (chkHSSV.Checked)
                    {
                        KhuyenMai = (long)(ThanhTien * 0.05);
                        ThanhTien = ThanhTien - KhuyenMai;
                    }

                    datatable.Rows.Add(null, txtMaSP.Text, cboTenSP.Text, txtSoLuong.Text, txtGiaSP.Text, KhuyenMai.ToString(),
                        ThanhTien.ToString());
                }
                dgvDanhMucSP.DataSource = datatable;
            }
        }

        //Tính tổng tiền có VAT
        private void btnTienVAT_Click(object sender, EventArgs e)
        {
            if (btnTienVATClicked)
            {
                MessageBox.Show("Bạn đã tính tổng tiền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (datatable == null || datatable.Rows.Count == 0)
            {
                MessageBox.Show("Bạn chưa thêm sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Kiểm tra hình thức nhận hàng
            if (string.IsNullOrWhiteSpace(cboHinhThucNhanHang.Text))
            {
                MessageBox.Show("Vui lòng chọn hình thức nhận hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            btnThemSPCliked = true;
            const double VAT = 1.1;
            int CPVC = 0;
            if (cboHinhThucNhanHang.SelectedItem.ToString() == "Giao tận nhà")
            {
                CPVC = 30000;
            }

            //Tổng thành tiền (chưa VAT)
            long TongThanhTien = 0;
            foreach (DataRow row in datatable.Rows)
            {
                if (long.TryParse(row["THÀNH TIỀN"].ToString(), out long ThanhTien))
                {
                    TongThanhTien += ThanhTien;
                }
            }

            //Tiền có VAT
            long TienVAT = (long)(TongThanhTien * VAT);
            long TongTien = TienVAT + CPVC;
            decimal Diem = (long)(TongTien * 0.001);

            //Thêm hàng "Tổng thành tiền"
            DataRow TotalRow = datatable.NewRow();
            TotalRow["STT"] = DBNull.Value;
            TotalRow["KHUYẾN MÃI"] = "TỔNG THÀNH TIỀN";
            TotalRow["THÀNH TIỀN"] = TongThanhTien;
            datatable.Rows.Add(TotalRow);

            //Thêm hàng "VAT 10%"
            DataRow vatRow = datatable.NewRow();
            vatRow["STT"] = DBNull.Value;
            vatRow["KHUYẾN MÃI"] = "VAT (%)";
            vatRow["THÀNH TIỀN"] = 10;
            datatable.Rows.Add(vatRow);

            //Thêm hàng CPVC
            DataRow CPVCRow = datatable.NewRow();
            CPVCRow["STT"] = DBNull.Value;
            CPVCRow["KHUYẾN MÃI"] = "CHI PHÍ VẬN CHUYỂN";
            CPVCRow["THÀNH TIỀN"] = CPVC;
            datatable.Rows.Add(CPVCRow);

            //Thêm hàng mới chứa tổng tiền có VAT
            DataRow TongTienRow = datatable.NewRow();
            TongTienRow["STT"] = DBNull.Value;
            TongTienRow["KHUYẾN MÃI"] = "TỔNG TIỀN";
            TongTienRow["THÀNH TIỀN"] = TongTien;
            datatable.Rows.Add(TongTienRow);

            //Thêm hàng tích điểm
            DataRow pointRow = datatable.NewRow();
            pointRow["STT"] = DBNull.Value;
            pointRow["KHUYẾN MÃI"] = "SỐ ĐIỂM TÍCH ĐƯỢC";
            pointRow["THÀNH TIỀN"] = Diem;
            datatable.Rows.Add(pointRow);

            btnTienVATClicked = true;
        }

        private void btnXuatHoaDon_Click(object sender, System.EventArgs e)
        {
            while (true)
            {
                // Kiểm tra thông tin khách hàng
                if (string.IsNullOrWhiteSpace(txtHoTenKH.Text) ||
                    string.IsNullOrWhiteSpace(txtSĐT.Text) ||
                    string.IsNullOrWhiteSpace(txtDiaChi.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //Kiểm tra ngày sinh
                if (!DateTimePickerChanged)
                {
                    MessageBox.Show("Vui lòng chọn ngày sinh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (dtpNgaySinh.Value == dtpNgaySinh.MinDate || dtpNgaySinh.Value.Date == DateTime.Now.Date)
                {
                    MessageBox.Show("Vui lòng chọn ngày hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Kiểm tra sđt
                string PhoneNumber = txtSĐT.Text;
                bool isPhoneNumberValid = PhoneNumber.All(char.IsDigit) && PhoneNumber.Length == 10;
                if (!isPhoneNumberValid)
                {
                    MessageBox.Show("Số điện thoại không hợp lệ! Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }             
                // Kiểm tra phương thức thanh toán
                if (!rdoChuyenKhoan.Checked && !rdoTienMat.Checked)
                {
                    MessageBox.Show("Vui lòng chọn phương thức thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!btnTienVATClicked)
                {
                    MessageBox.Show("Vui lòng tính tổng tiền trước khi xuất hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult confirmResult = MessageBox.Show("Bạn có chắc chắn điền đúng thông tin chưa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.No)
                {
                    break;
                }
                string ThanhToan = rdoChuyenKhoan.Checked ? rdoChuyenKhoan.Text : rdoTienMat.Text;
                frmHoaDon frm = new frmHoaDon(datatable)
                {
                    frm1 = this,
                    HoTenKH = txtHoTenKH.Text,
                    SDT = txtSĐT.Text,
                    DiaChi = txtDiaChi.Text,
                    ThanhPho = cboTP.Text,
                    NhanHang = cboHinhThucNhanHang.Text,
                    ThanhToan = ThanhToan,
                    Ngay = dtpNgaySinh.Text,
                    HSSV = chkHSSV.Checked
                };
                frm.Show();
                break;
            }
        }

        private bool resetting = false;
        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn reset lại thông tin?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                resetting = true;
                if (dgvDanhMucSP.DataSource != null)
                {
                    ((DataTable)dgvDanhMucSP.DataSource).Clear();
                    LoadDataGridView();
                }
                txtHoTenKH.Text = "";
                txtSĐT.Text = "";
                txtDiaChi.Text = "";
                cboHinhThucNhanHang.SelectedIndex = -1;
                cboDongSP.SelectedIndex = -1;
                cboTenSP.SelectedIndex = -1;
                cboTP.SelectedIndex = -1;
                txtMaSP.Text = "";
                txtGiaSP.Text = "";
                txtSoLuong.Text = "";
                rdoTienMat.Checked = false;
                rdoChuyenKhoan.Checked = false;
                dtpNgaySinh.Value = new DateTime(1990, 1, 1);
                chkHSSV.Enabled = false;
                chkHSSV.Checked = false;
                resetting = false;
            }
            btnTienVATClicked = false;
            btnThemSPCliked = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) Close();
            else if (result == DialogResult.No) MessageBox.Show("Mời bạn tiếp tục đặt hàng!", "Thông báo", MessageBoxButtons.OK);
        }

        private bool DateTimePickerChanged = false;
        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            DateTimePickerChanged = true;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            //Kiểm tra năm sinh
            int yearOfBirth = dtpNgaySinh.Value.Year;
            if (yearOfBirth >= 2002 && yearOfBirth <= 2018)
            {
                chkHSSV.Enabled = true;
            }
            else
            {
                chkHSSV.Enabled = false;
                chkHSSV.Checked = false;
            }
        }

        private void chkHSSV_CheckedChanged(object sender, EventArgs e)
        {
            if (resetting)
            {
                return;
            }

            if (btnThemSPCliked)
            {
                MessageBox.Show("Vui lòng reset trước khi thay đổi khuyến mãi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                chkHSSV.CheckedChanged -= chkHSSV_CheckedChanged;
                chkHSSV.Checked = !chkHSSV.Checked;
                chkHSSV.CheckedChanged += chkHSSV_CheckedChanged;
            }
        }

        private void lblDanhMucSP_Click(object sender, EventArgs e)
        {

        }

        private void lblTenCTy_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
