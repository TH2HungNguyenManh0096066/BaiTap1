using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Phep toan
            double KetQua = 0;
            bool checkNumber = false;
            Console.WriteLine("Nhap so thu nhat");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Lua chon phep tinh(+, -, *, /): ");
            char PhepTinh = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Nhap so thu hai");
            double b = Convert.ToDouble(Console.ReadLine());
            if (PhepTinh == '/')
            {
                while (!checkNumber)
                {
                    if (b != 0)
                    {
                        checkNumber = true;
                    }
                    else
                    {
                        Console.WriteLine("Hay nhap so thu hai khac 0 ");
                        break;
                    }
                }
            }
            switch (PhepTinh)
            {
                case '+':
                    KetQua = a + b;
                    break;
                case '-':
                    KetQua = a - b;
                    break;
                case '*':
                    KetQua = a * b;
                    break;
                case '/':
                    KetQua = a / b;
                    break;
                default:
                    Console.WriteLine("Phép tính không hợp lệ");
                    Console.WriteLine("Lựa chọn phép tính");
                    PhepTinh = Convert.ToChar(Console.ReadLine());
                    break;
            }
            if (KetQua == 0)
            {
                Console.WriteLine("Ket qua la vo cung");
            }
            else {
                Console.WriteLine($"Kết quả của phép toán {a} {PhepTinh} {b} = " + KetQua);
                }
            Console.ReadLine();


            //TamGiac
            Console.Write("Chieu dai canh a ");
            double canh1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("CHieu dai canh b ");
            double canh2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("CHieu dai canh c ");
            double canh3 = Convert.ToDouble(Console.ReadLine());
            double ChuVi = 0;
            double DienTich = 0;
            
            if(canh1 + canh2 >canh3 && canh1+ canh3 > canh2 && canh2+ canh3 > canh1)
            {
                ChuVi = canh1 + canh2 + canh3;
                double s = ChuVi / 2;
                DienTich = Math.Sqrt(s * (s - canh1) * (s - canh2) * (s - canh3));
            }
            else
            {
                Console.Write("ba canh a, b c khong hop ly ");
            }
            Console.WriteLine("Chu vi cua tam giac la " + ChuVi);
            Console.WriteLine("Dien tich cua tam giac la " + DienTich);
            Console.ReadLine();
        }

    }
}
