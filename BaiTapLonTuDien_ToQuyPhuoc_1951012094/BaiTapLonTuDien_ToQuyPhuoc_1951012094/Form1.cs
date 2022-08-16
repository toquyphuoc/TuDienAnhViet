using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;

namespace BaiTapLonTuDien_ToQuyPhuoc_1951012094
{
    public partial class Form1 : Form
    {
        DataTable dta = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            List<Tu> ltu = new List<Tu>();

            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                   
                    
                        if (txtTuMuonTim.Text == row.Cells[1].Value.ToString()|| txtTuMuonTim.Text == row.Cells[2].Value.ToString())
                        {
                            Tu tu = new Tu();
                            {
                                tu.TuTiengAnh = row.Cells[1].Value.ToString();
                                tu.TuTiengViet = row.Cells[2].Value.ToString();
                                tu.VaiTro = row.Cells[3].Value.ToString();

                            }
                            ltu.Add(tu);
                            break;

                        }
                }
                   
                
            }catch(NullReferenceException)
            {
                MessageBox.Show("Từ này không có trong dữ liệu");
            }
            dataGridView1.DataSource = ltu;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            bfTrackRed.Value = 150;
            bFTrackYellow.Value = 216;
            bfTrackGreen.Value = 186;
            this.BackColor = Color.FromArgb(bfTrackRed.Value, bFTrackYellow.Value, bfTrackGreen.Value);
            
        }
        DataTableCollection tableCollection;
        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx", ValidateNames = true })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    using(var stream=File.Open(dialog.FileName,FileMode.Open,FileAccess.Read))
                    {
                        using(IExcelDataReader reader=ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = result.Tables;
                            cbSheet.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                cbSheet.Items.Add(table.TableName);
                        }    
                    }    
                }
            }
        }
        
        private void cbSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cbSheet.SelectedItem.ToString()];
            dataGridView1.DataSource = dt;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cbSheet.SelectedItem.ToString()];
            Tu tu = new Tu();
            tu.TuTiengAnh = txtTiengAnh.Text;
            tu.TuTiengViet = txtTiengViet.Text;
            tu.VaiTro = txtVaiTro.Text;
            dt.Rows.Add("", tu.TuTiengAnh, tu.TuTiengViet, tu.VaiTro);
            
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }
        }
       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTiengAnh.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTiengViet.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtVaiTro.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;


            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Sheet1";


            for (int i = 1; i < dataGridView1.Columns.Count+1; i++)
            {
                worksheet.Cells[1, i ] = dataGridView1.Columns[i-1].HeaderText;
            }
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }                            
        }
   
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(bfTrackRed.Value, bFTrackYellow.Value, bfTrackGreen.Value);
            lbRed.Text = bfTrackRed.Value.ToString();
            lbYellow.Text = bFTrackYellow.Value.ToString();
            lbGreen.Text = bfTrackGreen.Value.ToString();
            lbRGB.Text = "rgb(" + bfTrackRed.Value.ToString() + "," + bFTrackYellow.Value.ToString() + "," + bfTrackGreen.Value.ToString() + ")";
        }

        private void btE_Click(object sender, EventArgs e)
        {
            label1.Text = "English - Vietnamese Translation App";
            label2.Text = "Please input a English word or a Vietnamese word";
            label3.Text = "English";
            label4.Text = "Vietnamese";
            label5.Text = "Role in word family";
            label6.Text = "Update in Datagridview";
            label7.Text = "Yellow";
            label8.Text = "Red";
            label9.Text = "Green";
            label10.Text = "Custom color for the app background";
            btTimKiem.Text = "Search";
            btThem.Text = "Insert";
            btXoa.Text = "Delete";
            btLuu.Text = "Save";
            btThoat.Text = "Exit";
        }

        private void btV_Click(object sender, EventArgs e)
        {
            label1.Text = "Ứng dụng từ điển Anh - Việt";
            label2.Text = "Nhập từ tiếng Anh hoặc tiếng Việt bạn muốn tìm kiếm";
            label3.Text = "Tiếng Anh";
            label4.Text = "Tiếng Việt";
            label5.Text = "Vai trò";
            label6.Text = "Nếu cần chỉnh sửa thi chỉnh sửa trực tiếp trên datagridview";
            label7.Text = "Vàng";
            label8.Text = "Đỏ";
            label9.Text = "Xanh lá";
            label10.Text = "Chỉnh màu nền cho trang tại đây";
            btTimKiem.Text = "Tìm kiếm";
            btThem.Text = "Thêm";
            btXoa.Text = "Xóa";
            btLuu.Text = "Lưu";
            btThoat.Text = "Thoát";
        }
    }
}
