using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoi.Database
{
    public partial class BAO_CAO_DINH_KY_NGAY_BAO_CAO
    {
        public DateTime NgayBaoCaoNamNay { get => new DateTime(DateTime.Now.Year, this.Thang, this.Ngay); }
    }
}
