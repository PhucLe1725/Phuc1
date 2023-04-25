using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHBAcademy
{
    public class BTVN_buoi_6
    {
        public void BTVN6_1()
        {
            double[,,] BangDiem = new double[3, 3, 3];
            Random rnd = new Random(); 
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        BangDiem[i, j, k] = rnd.Next(0, 10);
                    }
                }
            }
            // i: Nghia, Hiep, Hung
            // j: Toan, Ly, Hoa
            // k: Thuc hanh, Giua ki, cuoi ki
            double DiemTrungBinh=0;
            for (int i = 0; i < 3; i++) 
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine("Diem cua ban Nghia ");
                        break;
                    case 1:
                        Console.WriteLine("Diem cua ban Hiep ");
                        break;
                    case 2:
                        Console.WriteLine("Diem cua ban Hung ");
                        break;
                }
                for (int j = 0; j < 3; j++) 
                {
                    switch (j)
                    {
                        case 0:
                            Console.Write("Mon Toan la: ");
                            break;
                        case 1:
                            Console.Write("Mon Ly la: ");
                            break;
                        case 2:
                            Console.Write("Mon Hoa la: ");
                            break;
                    }                        
                    DiemTrungBinh = (BangDiem[i, j, 0] + 2 * BangDiem[i, j, 1] + 3 * BangDiem[i, j, 2]) / 6;
                    DiemTrungBinh = Math.Round(DiemTrungBinh, 1);
                    Console.WriteLine(DiemTrungBinh);
                    if (DiemTrungBinh >= 4)
                    {
                        Console.WriteLine("Ket qua: Do");
                    }
                    else
                    {
                        Console.WriteLine("Ket qua: Truot");
                    }
                }
            }

        }
        public void BTVN6_2()
        {
            int a,b;
            Console.Write("Nhập số hàng của mảng răng cưa: ");
            a = int.Parse(Console.ReadLine());
            int[][] MangRangCua = new int[a][];
            for (int i = 0;i < a; i++)
            {
                Console.Write("Nhập số phần tử của hàng {0}: ", i + 1);
                b = int.Parse(Console.ReadLine());
                MangRangCua[i] = new int[b];
                for (int j = 0;j < b; j++)
                {
                    Console.Write("Nhập phần tử thứ {0} của hàng {1}: ", j + 1, i + 1); 
                    MangRangCua[i][j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\nMảng răng cưa:");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < MangRangCua[i].Length; j++)
                {
                    Console.Write("{0,-10}", MangRangCua[i][j]);
                }
                Console.WriteLine();
            }
        }
        public void BTVN6_3() 
        {
            int n;
            Random rnd = new Random();
            Console.Write("Nhập kích thước n của ma trận vuông n x n: ");
            n = int.Parse(Console.ReadLine());
            int[,] MaTran = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    MaTran[i, j] = rnd.Next(0, 9);
                }
            }
            Console.WriteLine("Ma trận gốc (Dùng hàm random): ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,-3}", MaTran[i, j]);
                }
                Console.Write('\n');
            }
            int sumcheochinh = 0;
            for (int i = 0; i < n; i++)
            {
                sumcheochinh = sumcheochinh + MaTran[i, i];
            }
            Console.WriteLine("Tổng các phần tử đường chéo chính là: " + sumcheochinh);
            int sumcheophu = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j == n-1)
                    {
                        sumcheophu = sumcheophu + MaTran[i, j];
                    }
                }
            }
            Console.WriteLine("Tổng các phần tử đường chéo phụ là: " + sumcheophu);
            int sumtrencheochinh = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i < j)
                    {
                        sumtrencheochinh = sumtrencheochinh + MaTran[i, j];
                    }
                }
            }
            Console.WriteLine("Tổng các phần tử nằm phía trên đường chéo chính là: " + sumtrencheochinh);
            int sumduoicheochinh = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i > j)
                    {
                        sumduoicheochinh = sumduoicheochinh + MaTran[i, j];
                    }
                }
            }
            Console.WriteLine("Tổng các phần tử nằm phía dưới đường chéo chính là: " + sumduoicheochinh);
        }
        public void BTVN6_4()
        {
            int n, m;
            Random rnd = new Random();
            Console.WriteLine("Chương trình thực hiện trên ma trận n * m:");
            Console.Write("Nhập vào n: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Nhập vào m: ");
            m = int.Parse(Console.ReadLine());
            int[,] MaTran = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    MaTran[i, j] = rnd.Next(0, 9);
                }
            }
            Console.WriteLine("Ma trận gốc (Dùng hàm random): ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,-3}", MaTran[i, j]);
                }
                Console.Write('\n');
            }
            // Chuyển ma trận về dãy để sắp xếp
            int[] PhanTu = MaTran.Cast<int>().ToArray();
            Array.Sort(PhanTu);

            // Điền ma trận với dãy đã được sắp xếp
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    MaTran[i, j] = PhanTu[i * m + j];
                }
            }

            // In ma trận sau khi sắp xếp
            Console.WriteLine("Ma trận sau khi sắp xếp: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,-3}", MaTran[i, j]);
                }
                Console.Write('\n');
            }
        }

    }    
}
