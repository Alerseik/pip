using System;

namespace Работа_со_строками
{
    public struct Person
    {
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public Person(string name)
        {
            _name = name;
        }

        public override string ToString()
        {
            return _name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {


            //CompareOrdinal()
            string r1 = "GFG";
            string r2 = "GFG";
            string r3 = "привет";
            string r4 = "шарп";


            Console.WriteLine(string.CompareOrdinal(r1, r2));
            Console.WriteLine(string.CompareOrdinal(r1, r3));
            Console.WriteLine(string.CompareOrdinal(r3, r4));


            //Equals

            Person p1 = new Person("привет");
            Person p2 = new Person("ноу");
            Person p3 = new Person("привет");

            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine(p1.Equals(p3));

            //Compare
            string s1 = "это строка!!!";
            string s2 = "это текст!, а это строка!";
     
            if (String.Compare(s1, 0, s2, 13, 10, true) == 0)
                Console.WriteLine("При этом в них есть одинаковый текст"); 
            Console.WriteLine(String.Concat("\n" + "1, 2 ", "3, 4"));


            //Indexof
            if (s2.IndexOf("это ") != -1)
                Console.WriteLine("Слово \"это\" найдено в строке, оно " +
                 "находится на: {0} позиции", s2.IndexOf("это"));
                
            //Contains
            string s3 = "Кое-кто по имени Серёга обгоняет всех на физре";
            string s4 = "Серёга";
            bool b = s3.Contains(s4);
            Console.WriteLine("'{0}' находится в строке '{1}': {2}",
                            s4, s3, b);
            if (b)
            {
                int index = s3.IndexOf(s4);
                if (index >= 0)
                    Console.WriteLine("'{0} Данное слово встречается на позиций {1}",
                                  s4, index + 1);
            }
            Console.ReadLine();
        }
       


    }
}
