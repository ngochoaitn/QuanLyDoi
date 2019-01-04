using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace QuanLyDoi.Lib
{
    public class TaoBoSo
    {
        List<int> _maxVal, _res;
        List<List<int>> DanhSachKetQua { get; set; }
        public TaoBoSo(List<int> lst_max_val)
        {
            _maxVal = lst_max_val;
            _res = new List<int>(_maxVal);
            DanhSachKetQua = new List<List<int>>();
        }

        public void TienHanhTao(Func<List<int>, bool> validate=null)
        {
            Tao(0, 0, validate);
        }
        
        private void Tao(int vi_tri, int gia_tri_hien_tai, Func<List<int>, bool> validate = null)
        {
            if(vi_tri < _maxVal.Count)
            {
                for(int i = 0; i <= _maxVal[vi_tri]; i++)
                {
                    _res[vi_tri] = i;
                    Tao(vi_tri+1, gia_tri_hien_tai, validate);
                }
            }
            else
            {
                if (validate?.Invoke(_res) ?? true)
                {
                    //Tạo đủ 4 số
                    Debug.WriteLine(string.Join(" ", _res));
                    DanhSachKetQua.Add(_res);
                }
            }
        }
    }
}
