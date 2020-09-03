using System;
// Nhập Ho Tên và sau đó xuất lời chào
namespace Loi_Chao_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var Ho_Ten="";
            Console.WriteLine("Hello World!");
            Console.Title = "Xin Chào";
            Ho_Ten= Console.ReadLine();
            var Loi_Chao = "Xin Chào " + Ho_Ten + "\n"
                + "Đây là chương trình C# đầu tiên của tui";
            
            Console.Write(Loi_Chao);
           
            Console.ReadLine(); // để màn hình không tắt đi khi hoàn tất những dòng code trên đó
           
        }
    }
}
