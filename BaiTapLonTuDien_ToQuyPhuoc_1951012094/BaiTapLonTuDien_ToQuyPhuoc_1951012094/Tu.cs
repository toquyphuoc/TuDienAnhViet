using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLonTuDien_ToQuyPhuoc_1951012094
{
    class Tu
    {
        private string tuTiengAnh,tuTiengViet,vaiTro;
        public Tu()
        {
            tuTiengAnh = "";
            tuTiengViet = "";
            vaiTro = "";
        }
        public Tu(string tu_TiengAnh, string tu_TiengViet, string vai_Tro)
        {
            tuTiengAnh = tu_TiengAnh;
            tuTiengViet = tu_TiengViet;
            vaiTro = vai_Tro;
        }
        public string TuTiengAnh
        {
            get { return tuTiengAnh; }
            set { tuTiengAnh = value; }
        }
        public string TuTiengViet
        {
            get { return tuTiengViet; }
            set { tuTiengViet = value; }
        }
        public string VaiTro
        {
            get { return vaiTro; }
            set { vaiTro = value; }
        }
    }
    
}
