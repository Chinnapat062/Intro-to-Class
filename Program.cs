using System;
using System.Collections.Generic;

namespace Intro_to_class
{
    /*/class Program      // Refector //
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FeetToInches(30));
            Console.WriteLine(FeetToInches(100));
        }

        static int FeetToInches(int feet)
        {
            int inches = feet * 12;

            return inches;
        }
    }/*/



    /*/ class Program        // แปลง ToUpper // 
     {
         static void Main(string[] args)
         {
             string message = "chinnapat";
             string upperMessage = message.ToUpper();

             Console.WriteLine(upperMessage);
         }
     }/*/


    /*/class Program         //แปลง int Tostring  //
    {
        static void Main(string[] args)
        {
            string message = "Hello world";
            int year = 2021;

            message = message + year.ToString();

            Console.WriteLine(message);
        }
    }/*/


    /*/class Program   //FeetToInchesConverter//
    {
        static void Main(string[] args)
        {
            UnitConverter feetToInchesConverter = new UnitConverter(12);
            UnitConverter milesToFeetConverter = new UnitConverter(5280);

            Console.WriteLine(feetToInchesConverter.Convert(30));
            Console.WriteLine(feetToInchesConverter.Convert(100));
            Console.WriteLine(feetToInchesConverter.Convert(milesToFeetConverter.Convert(1)));
        }
    }

    class UnitConverter
    {
        int ratio;

        public UnitConverter(int unitRatio)
        { // Constructor
            ratio = unitRatio;
        }

        public int Convert(int unit)
        { // Method
            return unit * ratio;
        }
    }/*/

    /*/class Program  //สร้าง class// 
    {
        static void Main(string[] args)
        {
            Panda namePanda1 = new Panda("Panda ja");
            Panda namePanda2 = new Panda("Pan Dah");

            Console.WriteLine(namePanda1.name);
            Console.WriteLine(namePanda2.name);

            Console.WriteLine(Panda.population);
        }
    }

    class Panda
    {
        public string name;
        public static int population;

        public Panda(string nameValue)
        {
            name = nameValue;
            population = population + 1;
        }
    }/*/


    /*/class Program    //private and public //
    {
        static void Main(string[] args)
        {
            Panda namePanda1 = new Panda("Panda ja");
            Panda namePanda2 = new Panda("Pan Dah");

            Console.WriteLine(namePanda1.name);
            Console.WriteLine(namePanda2.name);

            Console.WriteLine(namePanda1.population); // Error
        }
    }

    class Panda
    {
        public string name;
        private int population;

        public Panda(string nameValue)
        {
            name = nameValue;
            population = population + 1;
        }
    }/*/


    /*/class Swordsman  //Class การสร้าง Class//
    {
        public int HP;
        public int EXP;
        public int Atk;
        public int level;
        public string status;

        public Swordsman()
        {
            HP = 5000;
            EXP = 0;
            Atk = 20;
            level = 1;
            status = "Alive";
        }

        public void Walk() 
        {
            Console.WriteLine("Walk");
        }
        public void Sit() 
        {
            Console.WriteLine("Sit");
        }
        public void Attack() 
        {
            Console.WriteLine("Attack");
        }
        public void Dead() 
        {
            Console.WriteLine("Dead");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Swordsman swordsman = new Swordsman();

            Console.WriteLine(swordsman.HP);
            Console.WriteLine(swordsman.EXP);
            Console.WriteLine(swordsman.Atk);
            Console.WriteLine(swordsman.level);
            Console.WriteLine(swordsman.status);
            
            swordsman.Walk();
            swordsman.Dead();

        }
    }*/


    /*class Animal //การสร้าง class//
    {
        public string name;
        public string birthdate;
        public string gender;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal mypet = new Animal();

            mypet.name = "Rafael";
            mypet.birthdate = "31 may 1991";
            mypet.gender = "male";

            Console.WriteLine(mypet.name);
        }
    }*/


    /*/class Student //การสร้าง class//
    {
        public string name;
        public string surname;
        public string grade;

        public Student(string valueName, string valueSurname, string valueGrade)
        {
            name = valueName;
            surname = valueSurname;
            grade = valueGrade;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Student chinnapat = new Student("Chinnapat", "Aksornsom", "A");


            Console.WriteLine(chinnapat.name);
            Console.WriteLine(chinnapat.surname);
            changeGrade(chinnapat);

            Console.WriteLine(chinnapat.grade);
        }

        public static void changeGrade(Student chinnapat)
        {
            chinnapat.grade = "A++";
        }
    }/*/


    /*/ class TShirt              //เฉลยการบ้าน เสื้อ  Class + List //
     {
         public string size;
         public string color;
         public float price;
         public string image;

         public TShirt(string valueSize, string valueColor, float valuePrice, string valueImage)
         {
             size = valueSize;
             color = valueColor;
             price = valuePrice;
             image = valueImage;
         }
     }

     class Address
     {
         public string street;
         public string city;
         public string zipCode;

         public Address(string valueStreet, string valueCity, string valueZipCode)
         {
             street = valueStreet;
             city = valueCity;
             zipCode = valueZipCode;
         }
     }

     class User
     {
         public string name;
         public Address address;
         public string email;
         public ShoppingCart shoppingCart;

         public User(string valueName, string valueEmail, Address valueAddress, ShoppingCart valueShoppingCart)
         {
             name = valueName;
             email = valueEmail;
             address = valueAddress;
             shoppingCart = valueShoppingCart;
         }
     }

     class ShoppingCart
     {
         List<TShirt> listTShirt;

         public ShoppingCart()
         {
             listTShirt = new List<TShirt>();
         }

         public void AddTShirtToShoppingCart(TShirt tshirt)
         {
             listTShirt.Add(tshirt);
         }

         public float TotalCost()
         {
             float summary = 0.0f;

             foreach (TShirt shirt in listTShirt)
             {
                 summary = summary + shirt.price;
             }

             return summary;
         }
     }


     class Program
     {
         static void Main(string[] args)
         {
             ShoppingCart shoppingCart = new ShoppingCart();
             foreach (TShirt shirt in ListTShirt())
             {
                 shoppingCart.AddTShirtToShoppingCart(shirt);
             }
             User jame = JameInformation(
             Address(),
             shoppingCart
             );
             Console.WriteLine("Total cost: {0}", jame.shoppingCart.TotalCost());
         }
         static List<TShirt> ListTShirt()
         {
             List<TShirt> listTShirt = new List<TShirt>();
             listTShirt.Add(new TShirt("L", "Red", 500.0f, "RedImage.png"));
             listTShirt.Add(new TShirt("M", "Black", 750.0f, "BlackImage.png"));
             listTShirt.Add(new TShirt("S", "Blue", 625.0f, "BlueImage.png"));
             return listTShirt;
         }
         static Address Address()
         {
             return new Address("131/75 !ทธมณฑล", "นครปฐม", "10180");
         }
         static User JameInformation(Address address, ShoppingCart shoppingCart)
         {
             return new User(
             "Jame Watson",
             "jame@gmail.com",
             address,
             shoppingCart
             );
         }
     }/*/

    /*/class Program              //Value Type  ไม่ได้โอนค่า // 
    {
        public struct Point { public int x; public int y; }
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.x = 7;

            Point p2 = p1; 

            Console.WriteLine(p1.x);
            Console.WriteLine(p2.x);

            p1.x = 9;

            Console.WriteLine(p1.x);
            Console.WriteLine(p2.x);
        }
    }/*/

    /*/class Program            // Reference Type  โอนค่า //
    {
        public class Point { public int x; public int y; }
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.x = 7;

            Point p2 = p1;

            Console.WriteLine(p1.x);
            Console.WriteLine(p2.x);

            p1.x = 9;

            Console.WriteLine(p1.x);
            Console.WriteLine(p2.x);
        }
    }/*/


    /*/class Program    // Method //
    {
        static void Main(string[] args)
        {
            ReadCelsiusThenPrintFahrenheitFromCelsiusConversion();
        }

        static void ReadCelsiusThenPrintFahrenheitFromCelsiusConversion()
        {
            float celsius = ReadCelsius();

            PrintFahrenheitFromCelsiusConversion(celsius);
        }

        static float FahrenheitFromCelsius(float celsius)
        {
            return (9.0f * celsius / 5.0f) + 32.0f;
        }

        static void PrintFahrenheitFromCelsiusConversion(float celsius)
        {
            float fahrenheit = FahrenheitFromCelsius(celsius);

            Console.WriteLine("celsius: {0} => fahrenheit: {1}", celsius, fahrenheit);
        }

        static float ReadCelsius()
        {
            Console.Write("Input Celsius: ");

            float celsius = float.Parse(Console.ReadLine());

            return celsius;
        }

    }/*/


    /*/class Program      //วิเคราะห์ ค่า Max //
    {
        static void Main(string[] args)
        {
            int result = Max8(1, 1, 3, 5, -20, 5, 7, 9);

            Console.WriteLine(result);
        }

        static int Max8(int number1, int number2, int number3, int number4, int number5, int number6, int number7, int number8)
        {
            int resultGroup1 = Max4(number1, number2, number3, number4);
            int resultGroup2 = Max4(number5, number6, number7, number8);

            return Max2(resultGroup1, resultGroup2);
        }

        static int Max4(int number1, int number2, int number3, int number4)
        {
            int resultGroup1 = Max2(number1, number2);
            int resultGroup2 = Max2(number3, number4);

            return Max2(resultGroup1, resultGroup2);
        }

        static int Max2(int number1, int number2)
        {
            return number1 > number2 ? number1 : number2;
        }
    }/*/

    /*/class Program //Overloading การใช้ metod ชื่อเดิมมากกว่า 1 ตัว //
    {
        static void Main(string[] args)
        {
            int result1 = add(5, 5);
            int result2 = add(5, 5, 6);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }

        static int add(int number1, int number2)
        {
            return number1 + number2;
        }

        static int add(int number1, int number2, int number3)
        {
            return number1 + number2 + number3;
        }

    }/*/

    /*/class Program //Overloading + Class //
    {
        static void Main(string[] args)
        {
            Wine wine1 = new Wine(1500);

            Console.WriteLine(wine1.price);
            Console.WriteLine(wine1.year);

            Wine wine2 = new Wine(1500, 10);
            Console.WriteLine(wine2.price);
            Console.WriteLine(wine2.year);
        }
    }

    class Wine
    {
        public int price;
        public int year;

        public Wine(int valuePrice)
        {
            price = valuePrice;
        }

        public Wine(int valuePrice, int valueYear)
        {
            price = valuePrice;
            year = valueYear;
        }

    }/*/

    /*/class Program // การใช้ this //
    {
        static void Main

        (string[] args)

        {
            Test test = new Test

            ("Chinnapat");

            Console

            .WriteLine

            (test.Name);

        }
    }

    class Test
    {
        public string Name
        ;

        public Test(string name)
        {
            this.Name = name
            ;

        }
    }/*/


    /*/class Program  //การใช้ set get //
    {
        static void Main(string[] args)
        {
            Stock msft = new Stock();
            msft.CurrentPrice = 50;
            msft.CurrentPrice += 23;

            Console.WriteLine(msft.CurrentPrice);
        }
    }

    class Stock
    {
        float currentPrice;

        public float CurrentPrice
        {
            get { return currentPrice; }
            set { currentPrice = value; }
        }
    }/*/

    /*/ class Program //การใช้  get // 
     {
         static void Main(string[] args)
         {
             Stock msft = new Stock();

             Console.WriteLine(msft.CurrentPrice);
         }
     }

     class Stock
     {
         float currentPrice = 2000;

         public float CurrentPrice
         {
             get { return currentPrice - 500; }
         }
     }/*/


    /*/class Program//Class สืบทอด + this //
    {
        static void Main(string[] args)
        {
            Student Jeen = new Student("Chinnapat", "Aksornsom");

            Console.WriteLine(Jeen.FirstName);
          
        }

    }

    class Student : Person   
    {
        public string Grade;

        public Student(string firstName, string lastName) : base(firstName, lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
           
        }

        public void recordGrade(string grade)
        {
            this.Grade = grade;
            
        }
    }

    class Person
    {
        public string FirstName;
        public string LastName;

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }/*/



    /*/class Car   //Class สืบทอด + Method + private//
    {
        private int totalDistance = 0;

        public void Drive(int distance)
        {
            this.totalDistance = this.totalDistance + distance;
        }

        public int GetTotalDistance()
        {
            return this.totalDistance;
        }
    }


    class Truck : Car
    {
        private string luggage;

        public void LoadLuggage(string luggage)
        {
            this.luggage = luggage;
        }

        public string GetLuggage()
        {
            return this.luggage;
        }
    }

    class Pickup : Car { }

    class Program
    {
        static void Main(string[] args)
        {
            PrintTruckInformation();
            PrintPickupInformation();
        }

        static void PrintTruckInformation()
        {
            Truck truck = new Truck();
            truck.LoadLuggage("คอมพิวเตอร์");
            truck.Drive(80);
            truck.Drive(40);

            Console.WriteLine("Car Type: Truck");
            Console.WriteLine("Total Distance: {0}", truck.GetTotalDistance());
            Console.WriteLine("Luggage: {0}", truck.GetLuggage());
        }

        static void PrintPickupInformation()
        {
            Pickup pickup = new Pickup();
            pickup.Drive(120);
            pickup.Drive(70);

            Console.WriteLine("Car Type: Pickup");
            Console.WriteLine("Total Distance: {0}", pickup.GetTotalDistance());
        }
    }/*/

    /*/  class BankAccount  //Class สืบทอด + this + method //
      {
          protected double money;
          public string OwnerName;
          public string AccountNumber;

          public BankAccount(double money, string ownerName, string accountNumber)
          {
              this.money = money;
              this.OwnerName = ownerName;
              this.AccountNumber = accountNumber;
          }

          public double GetMoney()
          {
              return this.money;
          }

          public void Deposit(double amount)
          {
              if (amount > 0)
              {
                  this.money += amount;
              }
          }
      }

      class CurrentAccount : BankAccount
      {
          public CurrentAccount(double money, string ownerName, string accountNumber)
          : base(money, ownerName, accountNumber)
          {
              this.money = money;
              this.OwnerName = ownerName;
              this.AccountNumber = accountNumber;
          }

          public void Withdrawal(double amount)
          {
              if (amount > 0 && money >= amount)
              {
                  money -= amount;
              }
              else
              {
                  Console.WriteLine("Not Enough money");
              }
          }
      }

      class CashFlowAccount : BankAccount
      {

          public CashFlowAccount(double money, string ownerName, string accountNumber)
          : base(money, ownerName, accountNumber)
          {
              this.money = money;
              this.OwnerName = ownerName;
              this.AccountNumber = accountNumber;
          }
      }

      class Program
      {
          static void Main(string[] args)
          {
              CurrentAccount currentAccount = new CurrentAccount(5000,

              "นายโจนาธาน //"

              , "1-252-147-5680");

              currentAccount.Deposit(10);
              currentAccount.Deposit(50);
              currentAccount.Deposit(500);
              currentAccount.Withdrawal(150);
              Console.WriteLine("Remain: {0}", currentAccount.GetMoney());

              CashFlowAccount cashflowAccount = new CashFlowAccount(5000,

              "นายโจนาธาน //"

              , "1-552-147-5680");

              cashflowAccount.Deposit(1000);
              cashflowAccount.Deposit(1000);
              cashflowAccount.Deposit(1000);
              cashflowAccount.Deposit(1000);
              cashflowAccount.Deposit(1000);
              Console.WriteLine("Total Money: {0}", cashflowAccount.GetMoney());

          }

      }/*/


    /*/class Asset              //ทดสอบว่าเป็น Asset ใน class สืบทอด//
    {
        public string Name;
        public Asset(string name)
        {
            this.Name = name;
        }
    }

    class Stock :Asset
    {
        public int SharedOwned;

        public Stock(string name, int sharedOwned):base(name)
        {
            this.Name = name;
            this.SharedOwned = sharedOwned;
        }
    }

    class House : Asset
    {
        public int Mortgage;

        public House(string name, int mortgage):base(name)
        {
            this.Name = name;
            this.Mortgage = mortgage;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ShowStockInformation();
            ShowHouseInformation();
        }

        static void ShowStockInformation()
        {
            Stock mediaStock = new Stock("Media", 1000);
            Console.WriteLine("Stock name: {0}", mediaStock.Name);
            Console.WriteLine("SharesOwned: {0}", mediaStock.SharedOwned);

            Display(mediaStock);
        }

        static void ShowHouseInformation()
        {
            House house = new House("บ้านปันสุข", 2000000);
            Console.WriteLine("Home name: {0}", house.Name);
            Console.WriteLine("Mortgage: {0}", house.Mortgage);

            Display(house);
        }

        static void Display(Asset asset)
        {
            Console.WriteLine(asset.Name);
        }

    }/*/


    /*/class Program   //upcasting
    {
        static void Main(string[] args)   
        {

            Stock msft = new Stock("Nhong", 50);
            Asset a = msft;

            Console.WriteLine(a == msft);
        }

    }/*/

    /*/ class Program   //downcasting 
     {
         static void Main(string[] args)

         {

             Stock msft = new Stock ("Nhong", 50);

             Asset a = msft;

             Stock s = (Stock)a;

             Console .WriteLine( s.SharesOwned);

             Console .WriteLine(s ==a);

             Console .WriteLine( s == msft);

         }

     }/*/

    /*/ class Program //as downcasting //
     {
         static void Main (string[] args )

         {

             House h = new House("Nhong", 5000);

             Asset a = h;

            House s = a as House;

             Console.WriteLine(s.Mortgage);

         }

     }/*/

    /*/class Program    // is //
    {
        static void Main(string[] args)
        {

            House h = new House("Nhong", 5000);
            Asset a = h;
            House s = a as House;
            Console.WriteLine(s.Mortgage);

            if (a is Stock)
            {
                Console.WriteLine("A is Stock");
            }
        }

    }/*/






    /*/class Person
    {
        protected string name;
        protected string address;
        protected string citizenID;

        public Person(string name, string address, string citizenID)
        {
            this.name = name;
            this.address = address;
            this.citizenID = citizenID;
        }

        public string GetName()
        {
            return this.name;
        }

    }

    class PersonList
    {
        private List<Person> personList;

        public PersonList()
        {
            this.personList = new List<Person>();
        }

        public void AddNewPerson(Person person)
        {
            this.personList.Add(person);
        }

        public void FetchPersonsList()
        {
            Console.WriteLine("List Persons");
            Console.WriteLine("---------------------");
            foreach (Person person in this.personList)
            {
                if (person is Student)
                {
                    Console.WriteLine("Name: {0} \nType: Student \n", person.GetName());
                }
                else if (person is Teacher)
                {
                    Console.WriteLine("Name: {0} \nType: Teacher \n", person.GetName());
                }
            }
        }

    }

    class Student : Person
    {
        private string studentID;

        public Student(string name, string address, string citizenID, string studentID)
        : base(name, address, citizenID)
        {
            this.studentID = studentID;
        }
    }

    class Teacher : Person
    {
        private string employeeID;

        public Teacher(string name, string address, string citizenID, string employeeID)
        : base(name, address, citizenID)
        {
            this.employeeID = employeeID;
        }

    }
    enum Menu
    {
        RegisterNewStudent = 1,
        RegisterNewTeacher,
        GetListPersons
    }
    class Program
    {
        static PersonList personList;

        static void Main(string[] args)
        {
            PreparePersonListWhenProgramIsLoad();
            PrintMenuScreen();
        }

        static void PreparePersonListWhenProgramIsLoad()
        {
            Program.personList = new PersonList();
        }

        static void PrintMenuScreen()
        {
            Console.Clear();
            PrintHeader();
            PrintListMenu();
            InputMenuFromKeyboard();
        }

        static void PrintHeader()
        {
            Console.WriteLine("Welcome to registration new user school application.");
            Console.WriteLine("----------------------------------------------------");
        }

        static void PrintListMenu()
        {
            Console.WriteLine("1. Register new student.");
            Console.WriteLine("2. Register new Teacher.");
            Console.WriteLine("3. Get List Persons.");
        }

        static void InputMenuFromKeyboard()
        {
            Console.Write("Please Select Menu: ");
            Menu menu = (Menu)(int.Parse(Console.ReadLine()));

            PresentMenu(menu);
        }

        static void PresentMenu(Menu menu)
        {
            if (menu == Menu.RegisterNewStudent)
            {
                ShowInputRegisterNewStudentScreen();
            }
            else if (menu == Menu.RegisterNewTeacher)
            {
                ShowInputRegisterNewTeacherScreen();
            }
            else if (menu == Menu.GetListPersons)
            {
                ShowGetListPersonScreen();
            }
            else
            {
                ShowMessageInputMenuIsInCorrect();
            }
        }

        static void ShowInputRegisterNewStudentScreen()
        {
            Console.Clear();
            PrintHeaderRegisterStudent();

            int totalStudent = TotalNewStudents();
            InputNewStudentFromKeyboard(totalStudent);
        }

        static void ShowInputRegisterNewTeacherScreen()
        {
            Console.Clear();
            PrintHeaderRegisterTeacher();

            int totalTeacher = TotalNewTeacher();
            InputNewTeacherFromKeyboard(totalTeacher);
        }

        static void ShowGetListPersonScreen()
        {
            Console.Clear();
            Program.personList.FetchPersonsList();
            InputExitFromKeyboard();
        }

        static void InputExitFromKeyboard()
        {
            string text = "";
            while (text != "exit")
            {
                Console.WriteLine("Input: ");
                text = Console.ReadLine();
            }

            Console.Clear();
            PrintMenuScreen();
        }

        static void InputNewTeacherFromKeyboard(int totalTeacher)
        {
            for (int i = 0; i < totalTeacher; i++)
            {
                Console.Clear();
                PrintHeaderRegisterTeacher();

                Teacher teacher = CreateNewTeacher();
                Program.personList.AddNewPerson(teacher);
            }

            Console.Clear();
            PrintMenuScreen();
        }

        static void InputNewStudentFromKeyboard(int totalStudent)
        {
            for (int i = 0; i < totalStudent; i++)
            {
                Console.Clear();
                PrintHeaderRegisterStudent();

                Student student = CreateNewStudent();
                Program.personList.AddNewPerson(student);
            }

            Console.Clear();
            PrintMenuScreen();
        }

        static Student CreateNewStudent()
        {
            return new Student(InputName(),
             InputAddress(),
             InputCitizenID(),
             InputStudentID());
        }

        static Teacher CreateNewTeacher()
        {
            return new Teacher(InputName(),
            InputAddress(),
            InputCitizenID(),
            InputEmployeeID());
        }

        static string InputName()
        {
            Console.Write("Name: ");

            return Console.ReadLine();
        }

        static string InputStudentID()
        {
            Console.Write("Student ID: ");

            return Console.ReadLine();
        }

        static string InputAddress()
        {
            Console.Write("Address: ");

            return Console.ReadLine();
        }

        static string InputCitizenID()
        {
            Console.Write("Citizen ID: ");

            return Console.ReadLine();
        }

        static string InputEmployeeID()
        {
            Console.Write("Employee ID: ");

            return Console.ReadLine();
        }

        static int TotalNewStudents()
        {
            Console.Write("Input Total new Student: ");

            return int.Parse(Console.ReadLine());
        }

        static int TotalNewTeacher()
        {
            Console.Write("Input Total new Teacher: ");

            return int.Parse(Console.ReadLine());
        }

        static void PrintHeaderRegisterStudent()
        {
            Console.WriteLine("Register new student.");
            Console.WriteLine("---------------------");
        }

        static void PrintHeaderRegisterTeacher()
        {
            Console.WriteLine("Register new teacher.");
            Console.WriteLine("---------------------");
        }

        static void ShowMessageInputMenuIsInCorrect()
        {
            Console.Clear();
            Console.WriteLine("Menu Incorrect Please try again.");
            InputMenuFromKeyboard();
        }
    }/*/



    /*/class Program  //virtual function  + Asset //  //Virtual Function คือ Function ที่สามารถ Overriden เพื่อแก้ไขการทํางานบางส่วน โดย Subclass ได้”//
    {
        static void Main(string[] args)
        {
            House mansion = new House("Kittinun", 2000000);
            Asset asset = mansion;

            Console.WriteLine(mansion.Liability());
            Console.WriteLine(asset.Liability());
        }
    }

    class Asset
    {
        public string Name;
        public virtual int Liability()
        {
            return 0;
        }
    }

    class Stock : Asset
    {
        public int SharesOwned;
    }

    class House : Asset
    {
        public int Mortgage;

        public House(string name, int mortgage)
        {
            this.Name = name;
            this.Mortgage = mortgage;
        }

        public override int Liability()
        {
            return this.Mortgage;
        }
    }/*/

    /*/class Employee //การใช้ Virtual และ Overiden เพื่อแก้ไข + Class + this + private //
    {

        public string Name;
        protected int basePay;

        public Employee(string name, int basePay)
        {
            this.Name = name;
            this.basePay = basePay;
        }

        public virtual int CalculatePay()
        {
            return basePay;
        }
    }

    class SalesEmployee : Employee
    {
        private int salesBonus;

        public SalesEmployee(string name, int basePay, int salesBonus)
        : base(name, basePay)
        {
            this.salesBonus = salesBonus;
        }

        public override int CalculatePay()
        {
            return basePay + salesBonus;
        }

    }

    class ProgrammerEmployee : Employee
    {

        public ProgrammerEmployee(string name, int basePay) : base(name, basePay) { }

    }

    class Program
    {
        static void Main(string[] args)
        {
            SalesEmployee sale = new SalesEmployee("นาย เจมส์ ทองดี", 20000, 5000);

            ProgrammerEmployee programmer = new ProgrammerEmployee("นาย เน รักดี", 50000);

            Console.WriteLine("Employee: {0} Earned: {1}", sale.Name, sale.CalculatePay());
            Console.WriteLine("Employee: {0} Earned: {1}", programmer.Name, programmer.CalculatePay());
        }
    }/*/


    /*/ class Program  //Abstract class ต้อง subclass ถึงใช้ได้//
     {
         static void Main(string[] args)
         {
             Pig myPig = new Pig();
             myPig.AnimalSound();
             myPig.Sleep();
             myPig.AnimalColor();
             myPig.poppulation();
         }
     }

     abstract class Animal
     {
         public abstract void AnimalSound();
         public abstract void AnimalColor();
         public virtual void Sleep()
         {
             Console.WriteLine("Sleep");
         }
         public virtual void poppulation()
         {
             Console.WriteLine("30");
         }
     }

     class Pig : Animal
     {
         public override void AnimalSound()
         {
             Console.WriteLine("We We We");
         }

         public override void Sleep()
         {
             base.Sleep();
             Console.WriteLine("Fe Fe Fe Fe");
         }
         public override void AnimalColor()
         {
             Console.WriteLine("Pink");
         }

         public override void poppulation()
         {
             base.poppulation();
             Console.WriteLine("50");
         }
     }/*/


    /*/class Program //Interface สร้างเอาไว้เป็นข้อตกลงเอาไว้ใช้งาน //
    {
        static void Main(string[] args)
        {
            AudioPlayer player = new AudioPlayer();
            player.Play();
            player.Pause();
        }
    }

    interface IAudioPlayer
    {
        void Play();
        void Pause();
        void Stop();
    }

    class AudioPlayer : IAudioPlayer
    {
        public void Play()
        {
            Console.WriteLine("Play");
        }

        public void Pause()
        {
            Console.WriteLine("Pause");
        }

        public void Stop()
        {
            Console.WriteLine("Stop");
        }

    }/*/

    /*/class Program
    {
        static void Main

        (string[] args)
        {

            AudioPlayer player = new AudioPlayer();
            player.Play();
            player.MusicName();
            player.Pause();
        }
    }
    interface IAudioPlayer
    {
        void Play();
        void Pause();
        void Stop();
    }
    interface IMusic
    {
        void MusicName();
        void Melody();
    }
    class AudioPlayer : IAudioPlayer, IMusic
    {
        public void Play()
        {
            Console.WriteLine("Play");

        }
        public void Pause()
        {
            Console .WriteLine("Pause");

        }
        public void Stop()
        {
            Console.WriteLine("Stop");
        }
        public void MusicName()
        {
            Console.WriteLine("Dior");

        }
        public void Melody()
        {
            Console.WriteLine("A.....B.....C");

        }
    }/*/



    interface IAddress   // interface + get + list + class + this //

    {
        string StreetAddress { get; }
        int NumberOfTimes { get; }
    }

    class Address : IAddress
    {
        private string streetAddress;
        private int numberOfTimes;

        public Address(string streetAddress, int numberOfTimes)
        {
            this.streetAddress = streetAddress;
            this.numberOfTimes = numberOfTimes;
        }

        public string StreetAddress
        {
            get
            {
                return this.streetAddress;
            }
        }

        public int NumberOfTimes
        {
            get
            {
                return this.numberOfTimes;
            }
        }

        interface INavigation
        { 
            List<Address> GetAllContactAddress();

        }

        interface IEngine
        {
            public void Start();
            void Stop();
        }

        class Car : INavigation, IEngine
        {
            private List<Address> carryDestionations = new List<Address>
        {
            new Address("กรุงเทพ", 10),
            new Address("เชียงใหม่",5),
            new Address("นนทบุรี",8),
            new Address("ชลบุรี", 12),
            new Address("ตลาด", 18),
            new Address("ระยอง", 12)
        };

            public List<Address> GetAllContactAddress()
            {

                return this.carryDestionations;
            }

            public void Start()
            {
                Console.WriteLine("Start");
            }

            public void Stop()
            {
                Console.WriteLine("Stop");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Car jameCar = new Car();
                jameCar.Start();

                foreach (Address address in jameCar.GetAllContactAddress())
                {
                    Console.WriteLine("Province: {0}, Time: {1}", address.StreetAddress, address.NumberOfTimes);
                }

                jameCar.Stop();
            }
        }
    }
}




