using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHBAcademy
{
    public class BTVN_buoi_9
    {
        public void BTVN9_1()
        {
            Random rnd = new Random();
            int ThoiGian = 0;
            int TauDen = 0;
            int TauTra = 0;
            int TauDoi = 0;
            int ThoiGianTauDen = rnd.Next(5,10);
            int ThoiGianTraHang = rnd.Next(3, 7);
            int ThoiGianTauTraHangTiepTheo = ThoiGianTraHang;
            int t;
            Console.Write("Nhập thời gian muốn xem trình giả lập: ");
            t = int.Parse(Console.ReadLine());

            while (ThoiGian  <= t) // Giới hạn thời gian là thời gian nhập vào, có thể dùng true nếu muốn lặp vô tận
            {
                if (ThoiGian == ThoiGianTauDen) // Nếu thời gian hiện tại bằng thời gian đến của tàu tiếp theo
                {
                    TauDen++; // Tăng số tàu cập bến lên 1
                    TauDoi++; // Tăng số tàu đang đợi lên 1
                    Console.WriteLine("Có tàu mới");
                    Thread.Sleep(500);
                    ThoiGianTauDen += rnd.Next(5, 10); // Cộng thêm khoảng thời gian ngẫu nhiên từ 5 đến 10 giây cho thời gian đến của tàu tiếp theo
                }

                if (TauDoi > 0) // Nếu có ít nhất một tàu đang đợi
                {
                    ThoiGianTauTraHangTiepTheo--; // Giảm thời gian còn lại để tàu tiếp theo trả hàng đi 1 giây
                    if (ThoiGianTauTraHangTiepTheo == 0) // Nếu thời gian còn lại để tàu tiếp theo trả hàng bằng 0
                    {
                        TauTra++; // Tăng số tàu đã trả hàng lên 1
                        TauDoi--; // Giảm số tàu đang đợi đi 1
                        Console.WriteLine("Có tàu trả hàng xong");
                        Thread.Sleep(500);
                        ThoiGianTraHang = rnd.Next(3, 7); // Random thời gian trả hàng của tàu tiếp theo
                        ThoiGianTauTraHangTiepTheo = ThoiGianTraHang; // Đặt lại thời gian còn lại để tàu tiếp theo trả hàng bằng thời gian chuyển hàng
                    }
                }
                Console.Clear();
                Console.WriteLine("Thời gian: {0}s", ThoiGian);
                Console.WriteLine("Tổng số tàu cập bến: " + TauDen);
                Console.WriteLine("Tổng số tàu đã trả hàng: " + TauTra);
                Console.WriteLine("Số tàu đang đợi trả hàng: " + TauDoi);
                Thread.Sleep(1000);
                ThoiGian++;
            }
        }
    }
}
