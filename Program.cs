using System;
using System.Linq;

namespace Baitap;
class Program
{
    static void Main()
    {
        Bai1_TaoMangVaTinhTong();
        //Bai2_DemSoLuongKyTu();
        //Bai3_TimPhanTuLonNhat();
        //Bai4_DaoNguocChuoi();
        //Bai5_KiemTraMangDoiXung();
        //Bai6_DemSoLanXuatHienKyTu();

    }
    // Bài 1: Tạo mảng số nguyên và tính tổng
    static void Bai1_TaoMangVaTinhTong()
    {
        Console.Write("Nhap so luong phan tu cua mang: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        int sum = array.Sum();
        Console.WriteLine($"Tong cac phan tu trong mang la: {sum}");
    }
    // Bài 2: Đếm số lượng ký tự trong chuỗi (không tính khoảng trắng và dấu câu)
    static void Bai2_DemSoLuongKyTu()
    {
        Console.Write("Nhap mot chuoi: ");
        string input = Console.ReadLine();

        int charCount = input.Count(c => !char.IsWhiteSpace(c) && !char.IsPunctuation(c));

        Console.WriteLine($"So luong ky tu trong chuoi (khong tinh khoang trang và dau cau) la: {charCount}");
    }

    // Bài 3: Tìm phần tử lớn nhất trong mảng
    static void Bai3_TimPhanTuLonNhat()
    {
        Console.Write("Nhap so luong phan tu cua mang: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        int max = array.Max();
        Console.WriteLine($"Phan tu lon nhat trong mang la: {max}");
    }

    // Bài 4: Đảo ngược chuỗi
    static void Bai4_DaoNguocChuoi()
    {
        Console.Write("Nhap mot chuoi: ");
        string input = Console.ReadLine();

        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);

        string reversedString = new string(charArray);

        Console.WriteLine($"Chuoi đao nguoc la: {reversedString}");
    }

    // Bài 5: Kiểm tra mảng đối xứng (Palindrome)
    static void Bai5_KiemTraMangDoiXung()
    {
        Console.Write("Nhap so luong phan tu cua mang: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        bool isPalindrome = true;
        for (int i = 0; i < n / 2; i++)
        {
            if (array[i] != array[n - 1 - i])
            {
                isPalindrome = false;
                break;
            }
        }

        if (isPalindrome)
            Console.WriteLine("Mang la mang đoi xung.");
        else
            Console.WriteLine("Mang khong phai la mang đoi xung.");
    }

    // Bài 6: Đếm số lần xuất hiện của một ký tự trong chuỗi
    static void Bai6_DemSoLanXuatHienKyTu()
    {
        Console.Write("Nhap mot chuoi: ");
        string input = Console.ReadLine();

        Console.Write("Nhap ky tu can đem: ");
        char character = char.Parse(Console.ReadLine());

        int count = input.Count(c => c == character);

        Console.WriteLine($"So lan xuat hien cua ky tu '{character}' trong chuoi la: {count}");
    }
}