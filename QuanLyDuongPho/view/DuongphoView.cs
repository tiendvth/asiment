using System;
using QuanLyDuongPho.controller;

namespace QuanLyDuongPho.view
{
    public class DuongphoView
    {
        DuongPhoController duongPhoController = new DuongPhoController();

            public void ShowMenu()
            {
            while (true)
            {
                
                Console.WriteLine("---------------------------------------SinhVienManager----------------------------------");
                Console.WriteLine("| 1.Thêm mới đường phố                                                                 |");
                Console.WriteLine("| 2.Hiển thị danh sach Đường Phố                                                       |");
                Console.WriteLine("| 3.Sửa thông tin Đường phố                                                           |");        
                Console.WriteLine("| 4.Xóa thông tin đường phố                                                                     |");
                Console.WriteLine("| 5.Đóng chuong trinh                                                                   |");
                Console.WriteLine("-----------------------------------------------------------------------------------------");
                Console.WriteLine("Vui long chon tu (1->5): ");
                int luachon = int.Parse(Console.ReadLine());
                switch (luachon)
                {
                    case 1:
                        Console.WriteLine("da chon 1");
                        duongPhoController.TaomoiDuongPho();
                        break;
                    case 2:
                        Console.WriteLine("da chon 2");
                        duongPhoController.HienThiDanhSachDuongPho();
                        break;
                    case 3:
                        Console.WriteLine("da chon 3");
                        duongPhoController.SuaThongTinduongpho();
                        break;
                    case 4:
                        Console.WriteLine("da chon 4");
                        duongPhoController.XoaThongTinDuongPho();
                        break;
                    default:
                        Console.WriteLine("Lựa chọn sai, vui lòng nhập lại lựa chọn từ 1->5");
                        break;
                }

                Console.ReadLine();
                if (luachon==5)
                {
                    Console.WriteLine("byby");
                    break;
                }
            }
        }
    }
}