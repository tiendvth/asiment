using System;
using System.Collections.Generic;
using QuanLyDuongPho.entity;
using QuanLyDuongPho.Model;

namespace QuanLyDuongPho.controller
{
    public class DuongPhoController
    {
        private DuongPhoModel _duongPhoModel = new DuongPhoModel();
        public bool TaomoiDuongPho()
        {
            DuongPho duongPho = new DuongPho();
            Console.WriteLine("Vui lòng nhập mã: ");
            duongPho.Ma = Console.ReadLine();
            Console.WriteLine("Nhập tên đường: ");
            duongPho.Ten = Console.ReadLine();
            Console.WriteLine("Nhập mô tả: ");
            duongPho.MoTa = Console.ReadLine();
            Console.WriteLine("Nhập ngày sử dụng: ");
            duongPho.NgaySuDung = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Nhập lịch sử: ");
            duongPho.Lichsu = Console.ReadLine();
            Console.WriteLine("Nhập tên quận: ");
            duongPho.TenQuan = Console.ReadLine();
            Console.WriteLine("Nhập trạng thái: ");
            duongPho.TrangThai = Convert.ToInt32(Console.ReadLine());
            return _duongPhoModel.Save(duongPho);
        }

        public void HienThiDanhSachDuongPho()
        {
            Console.WriteLine("Danh sách đường phố vừa nhập là: ");
            List<DuongPho> listDuongPho = _duongPhoModel.FindAll();
            for (var i = 0; i < listDuongPho.Count; i++)
            {
                var dp1 = listDuongPho[i];
                Console.WriteLine($"Mã: {dp1.Ma}, Tên: {dp1.Ten}, Mô tả: {dp1.MoTa}, Ngày sử dụng: {dp1.NgaySuDung}, Lịch sử: {dp1.Lichsu}, Tên quận: {dp1.TenQuan}, Trạng thái: {dp1.TrangThai}");
            }
        }

        public void SuaThongTinduongpho()
        {
            Console.WriteLine("nhap ma đường phố can sua:");
            string id = Console.ReadLine();
            DuongPho duongpho2 = _duongPhoModel.FindById(id);
            if (duongpho2 != null)
            {
                Console.WriteLine("Nhap tên Đường: ");
                var tenduongpho = Console.ReadLine();
                duongpho2.Ten = tenduongpho;
                Console.WriteLine("Nhập mô tả đường: ");
                var motaduongpho = Console.ReadLine();
                duongpho2.MoTa = motaduongpho;
                Console.WriteLine("Nhập ngày sử dụng đường: ");
                var tuoiSinhVien = int.Parse(Console.ReadLine());
                duongpho2.NgaySuDung = new DateTime();
                Console.WriteLine("Nhập lịch sử đường: ");
                var lichsuduongpho = Console.ReadLine();
                duongpho2.Lichsu = lichsuduongpho;
                Console.WriteLine("Nhập tên quận");
                var tenquandp = Console.ReadLine();
                duongpho2.TenQuan = tenquandp;
                Console.WriteLine("Nhập trạng thái đường phố:");
                var trangthaiduongpho = Convert.ToInt32(Console.ReadLine());
                duongpho2.TrangThai = trangthaiduongpho;
                _duongPhoModel.Update(id, duongpho2);
            }

            Console.WriteLine("ko tim thay ma sinh vien can tim");
        }

        public void XoaThongTinDuongPho()
        {
            Console.WriteLine(" vui long nhập đường phố cần xóa");
            string id = Console.ReadLine();
            DuongPho delete = _duongPhoModel.FindById(id);
            if (delete != null)
            {
                Console.WriteLine("ban co chac muon xoa yes/no");
                string luachon = Console.ReadLine();
                if (luachon.ToLower().Equals("y"))
                {
                    _duongPhoModel.Delete(id);
                    Console.WriteLine("xoa thanh cong");
                }
                else
                {
                    Console.WriteLine("xoa that bai");
                }
            }
            else
            {
                Console.WriteLine(" ko tim thay id can xoa");
            }
        }
    }
}