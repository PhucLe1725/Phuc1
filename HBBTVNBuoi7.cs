using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHBAcademy
{
    public class HBBTVNBuoi7
    {
        public void HBBTVNBuoi7_2()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Phúc Lê Xuân");
            Console.WriteLine(sb);
            sb.Clear();
            string var0 = "Lê Xuân Phúc";
            int var1 = 18;
            double var2 = 3.83;
            string var3 = "HUSTer";
            object[] var4 = { 18, 3.83, "Thanh Hóa" };
            sb.AppendFormat("+) {0}, {1}, {2}, {3}", var0, var1, var2, var3);
            Console.WriteLine(sb);
            sb.Clear();
            sb.AppendFormat("+) {0}, {1}, {2}", var4);
            Console.WriteLine(sb);
            sb.Clear();
            sb.AppendFormat("Tên tôi là {0} và tôi {1} tuổi", "Lê Phúc", 18);
            sb.Insert(14, "Xuân ");
            Console.WriteLine(sb);
            sb.Remove(2, 3);
            Console.WriteLine(sb);
            sb.Clear();
            sb.Append("Anh ấy đang ngồi trên ghế dựa ban công");
            sb.Replace('a', 'e');
            Console.WriteLine(sb);
        }
    }
}
