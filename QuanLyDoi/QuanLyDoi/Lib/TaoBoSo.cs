using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoi.Lib
{
    public class TaoBoSo
    {
        List<int> _maxVal, _res;
        public TaoBoSo(List<int> lst_max_val)
        {
            _maxVal = lst_max_val;
            _res = new List<int>(_maxVal);
        }

        public void TienHanhTao()
        {
            Tao(0, 0);
        }

        private void Tao(int vi_tri, int gia_tri_hien_tai)
        {
            if(vi_tri < _maxVal.Count)
            {
                for(int i = 0; i < _maxVal[vi_tri]; i++)
                {
                    _res[vi_tri] = i;
                    Tao(vi_tri+1, gia_tri_hien_tai);
                }
            }
            else
            {
                //Tạo đủ 4 số
                Debug.WriteLine(string.Join(" ", _res));
            }
            if(vi_tri < _maxVal.Count && gia_tri_hien_tai < _maxVal[vi_tri])
            {
                Tao(vi_tri, gia_tri_hien_tai+1);
            }
        }
    }
}
