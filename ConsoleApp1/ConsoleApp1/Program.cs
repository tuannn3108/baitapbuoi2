using System.Collections.Generic;
using System;

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();
        while (true)
        {
            Console.WriteLine("\nMENU:");
            Console.WriteLine("1. Them hoc sinh vao danh sach");
            Console.WriteLine("2. In danh sach toan bo hoc sinh");
            Console.WriteLine("3. Tim hoc sinh co diem trung binh tu 5.0 den 7.0");
            Console.WriteLine("4. Tim hoc sinh co ten bat dau bang chu 'A'");
            Console.WriteLine("5. Tinh tong diem trung binh cua tat ca hoc sinh");
            Console.WriteLine("6. Tim hoc sinh co diem trung binh cao nhat");
            Console.WriteLine("7. Sap xep danh sach hoc sinh theo diem trung binh tang dan va in ra danh sach sau khi sap xep");
            Console.WriteLine("0. Thoat");
            Console.Write("Chon: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Student student = new Student();
                    student.Input();
                    students.Add(student);
                    break;
                case 2:
                    Console.WriteLine("\nDanh sach toan bo hoc sinh:");
                    students.ForEach(s => s.Show());
                    break;
                case 3:
                    Console.WriteLine("\nHoc sinh co diem trung binh tu 5.0 den 7.0:");
                    var scoreRange = students.Where(s => s.AverageScore >= 5.0f && s.AverageScore <= 7.0f).ToList();
                    scoreRange.ForEach(s => s.Show());
                    break;
                case 4:
                    Console.WriteLine("\nHoc sinh co ten bat dau bang chu 'A':");
                    var startsWithA = students.Where(s => s.FullName.StartsWith("A")).ToList();
                    startsWithA.ForEach(s => s.Show());
                    break;
                case 5:
                    var totalScore = students.Sum(s => s.AverageScore);
                    Console.WriteLine($"\nTong diem trung binh cua tat ca hoc sinh: {totalScore}");
                    break;
                case 6:
                    var highestScore = students.OrderByDescending(s => s.AverageScore).First();
                    Console.WriteLine("\nHoc sinh co diem trung binh cao nhat:");
                    highestScore.Show();
                    break;
                case 7:
                    Console.WriteLine("\nDanh sach hoc sinh theo diem trung binh tang dan:");
                    var sortedByScore = students.OrderBy(s => s.AverageScore).ToList();
                    sortedByScore.ForEach(s => s.Show());
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Lua chon khong hop le. Vui long chon lai.");
                    break;
            }
        }
    }
}
