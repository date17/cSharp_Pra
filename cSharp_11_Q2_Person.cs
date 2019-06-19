using System;
namespace cSharp_11_Q2
{
    enum Gender
    {
        Mile,
        Female
    }
    class Person
    {
    
        // 名
        public string FirstName { get; set; }
        // 姓
        public string LastName { get; set; }
        // 性別
        public Gender Gen { get; private set; }
        // フルネーム
        public string FullName
        {
             get { return LastName + FirstName; }
        }

        // コンストラクター（引数：名、姓、性別）
        public Person(string firstName, string lastName, Gender gender)
        {

            FirstName = firstName;
            LastName = lastName;
            Gen = gender;
        
        }

        // 性別を出力
        public string ManOrWoman (Gender gender)
        {
            string sex = "";
            if(gender == Gender.Mile)
            {
                sex = "男性";
                
            }
            if(gender == Gender.Female)
            {
                sex = "女性";
                
            }
            return sex;
        }
    }
}
