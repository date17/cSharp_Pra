using System;

// 確認・応用問題（クラス/オブジェクト指向プログラミングの基礎）
// Q2
namespace cSharp_7_Q2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var employee1 = new Employee()
            {
                Id = 1,
                FamilyName = "南舘",
                GivenName = "拓弥",
                EmailAddress = "date17@ezweb.ne.jp"
            };

            var employee2 = new Employee()
            {
                Id = 2,
                FamilyName = "田中",
                GivenName = "太郎",
                EmailAddress = "toro@icloud.com"
            };

            var fullName1 = employee1.GetFullName(employee1.FamilyName, employee1.GivenName);
            var fullName2 = employee2.GetFullName(employee2.FamilyName, employee2.GivenName);
            Console.WriteLine($"従業員No.{employee1.Id}  {fullName1}");
            Console.WriteLine($"従業員No.{employee2.Id}  {fullName2}");
        }
    }
    class Employee
    {
        public int Id { get; set; }
        public string FamilyName { get; set; }
        public string GivenName { get; set; }
        public string EmailAddress { get; set; }

        public string GetFullName(string fName, string gName)
        {
            var fullName = $"{fName} {gName}";
            return fullName;
        }
    }
}
