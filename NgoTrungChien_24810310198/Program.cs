using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập số thứ nhất a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Nhập số thứ hai b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Nhập phép toán (+, -, *, /, %): ");
        char op = char.Parse(Console.ReadLine());

        string ketQua = Tinh(a, b, op);
        Console.WriteLine(ketQua);
    }

    static string Tinh(double a, double b, char op)
    {
        return op switch
        {
            '+' => (a + b).ToString("F2"),
            '-' => (a - b).ToString("F2"),
            '*' => (a * b).ToString("F2"),
            '/' when b == 0 => "Lỗi: Không thể chia cho 0!",
            '/' => (a / b).ToString("F2"),
            '%' when b == 0 => "Lỗi: Không thể chia cho 0!",
            '%' => (a % b).ToString("F2"),
            _ => "Lỗi: Phép toán không hợp lệ!"
        };
    }
}