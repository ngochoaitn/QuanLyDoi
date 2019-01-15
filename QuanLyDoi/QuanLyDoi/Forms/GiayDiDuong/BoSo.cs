using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace QuanLyDoi.Forms.GiayDiDuong
{
    public class BoSo
    {
        List<int> _maxVal, _res;
        public List<List<int>> DanhSachKetQua { get; set; }
        public Func<List<int>, bool> Validate { get; set; }

        public BoSo(List<int> lst_max_val, Func<List<int>, bool> validate = null)
        {
            _maxVal = lst_max_val;
            _res = new List<int>(_maxVal);
            DanhSachKetQua = new List<List<int>>();
            this.Validate = validate;
            this.TienHanhTao();
        }

        public BoSo(NhomNgay nhom_ngay, Func<List<int>, bool> validate = null)
        {
            _maxVal = new List<int>();
            foreach (var nn in nhom_ngay.DanhSachKetQua)
                _maxVal.Add(nn.Count);
            _res = new List<int>(_maxVal);
            DanhSachKetQua = new List<List<int>>();
            this.Validate = validate;
            this.TienHanhTao();
        }

        public List<List<int>> TienHanhTao()
        {
            this.DanhSachKetQua = new List<List<int>>();
            this.Tao(0, 0);
            return this.DanhSachKetQua;
        }
        
        private void Tao(int vi_tri, int gia_tri_hien_tai)
        {
            if(vi_tri < _maxVal.Count)
            {
                for(int i = 0; i <= _maxVal[vi_tri]; i++)
                {
                    _res[vi_tri] = i;
                    this.Tao(vi_tri+1, gia_tri_hien_tai);
                }
            }
            else
            {
                if (Validate?.Invoke(_res) ?? true)
                {
                    //Tạo đủ 4 số
                    Debug.WriteLine($"{this.DanhSachKetQua.Count+1}: {string.Join(" ", _res)}");
                    this.DanhSachKetQua.Add(_res.ToList());//Phải ToList để clone không thì khi _res thay đổi các giá trị cũng sẽ thay đổi theo
                }
            }
        }

        public List<int> this[int index] => DanhSachKetQua[index];
    }
}
