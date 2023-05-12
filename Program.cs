using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //WriteLine
            Console.WriteLine("Welcome to Basic FirstName = {0} LastName = {1} , Age = {2}","Natchanon","Saowaros",21);
            Console.WriteLine("{0} + {1} = {2}",5,10,15);
        
            //ตัวแปร
            int x = 10, y = 20,z;
            z = x + y;
            Console.WriteLine(z);

            //Float
            float a = 10.20f;
            float b = 10f;
            Console.WriteLine(a);
            Console.WriteLine(b);

            //double
            double number1;
            number1 = x+y;
            Console.WriteLine(number1);

            //boolean
            bool status = true;

            //char & string
            char al = 'A';
            string name = "Natchanon";
            Console.WriteLine(al);
            Console.WriteLine(name);

            //const   const=ค่าคงที่ แก้ไขไม่ได้
            const int number = 500;
            //number = 1000;

            //ใช้ {} เพื่อกำหนดลำดับการแสดงผล เริ่มต้นที่ 0
            Console.WriteLine("Hello = {1}", "Natchanon", "Non");
            //Print Write=แสดงเฉยๆ WriteLine=แสดงแล้วขึ้นบรรทัดใหม่

            int number3 = 12000;
            Console.WriteLine("Format String");
            Console.WriteLine("Number = {0}", number3);
            Console.WriteLine("Number = {0:E}", number3);
            Console.WriteLine("Number = {0:F}", number3);
            Console.WriteLine("Number = {0:G}", number3);
            Console.WriteLine("Number = {0:N}", number3);
            Console.WriteLine("Number = {0:P}", number3);
            Console.WriteLine("Number = {0:X}", number3);

            //Read&Readline
            Console.WriteLine("input output");
            Console.Write("Input = ");
            //int result = Console.Read(); //ascii code
            string result = Console.ReadLine();
            Console.WriteLine("Output = {0}", result);
            Console.ReadKey();

            //ตัวดำเนินการทางคณิต
            Console.WriteLine("math");
            int d = 10;
            double e = 100.2;
            int g = 5;
            int h = 20;
            int i = 2;
            double f = e * d / g + h - i;
            Console.WriteLine("Result = {0}", f);
            Console.ReadKey();

            //ฟังก์ชั่นคณิตศาสตร์
            Console.WriteLine("math function");
            float number4 = 15.49f;
            float result2 = Math.Abs(number4);
            Console.WriteLine("Abs = {0}", Math.Abs(number4));
            Console.WriteLine("Ceiling = {0}", Math.Ceiling(number4));
            Console.WriteLine("Floor = {0}", Math.Floor(number4));
            Console.WriteLine("Round = {0}", Math.Round(number4));
            Console.WriteLine("Power = {0}", Math.Pow(5, 2));
            Console.WriteLine("Square Root = {0}", Math.Sqrt(9));
            Console.WriteLine("PI = {0}", Math.PI);
            Console.WriteLine("E = {0}", Math.E);

            //เปรียบเทียบ
            /*bool result3 = number5 == number6;
            Console.WriteLine(result3); */
            Console.WriteLine(">/<");
            int number5 = 13, number6 = 14;
            Console.WriteLine(number5 == number6); //แสดง False
            Console.WriteLine(number5 != number6); //แสดง True
            Console.WriteLine(number5 > number6); //แสดง False
            Console.WriteLine(number5 < number6); //แสดง True
            Console.ReadLine();

            //prefix&postfix
            Console.WriteLine("Prefix&Postfix");
            int j = 5, k = 10;

            // ++
            Console.WriteLine("j = {0}", j); //5
            Console.WriteLine("Prefix = {0}", ++j); //6
            Console.WriteLine("last j = {0}", j); //6
            j = 5;
            Console.WriteLine("j = {0}", j); //5
            Console.WriteLine("Postfix = {0}", j++); //5
            Console.WriteLine("last j = {0}", j); //6
            Console.ReadKey();

            //Compund Assignment
            Console.WriteLine("compound");
            int l = 10, m = 20;
            l += m; //l = l+m
            Console.WriteLine(l);
            Console.ReadKey();

            //ลำดัยสำคัญ
            Console.WriteLine("math priority");
            float result5 = 5 * 2 - 40 / 5; //ได้ 2 เพราะ คูณ-หาร มาก่อน บวก-ลบ
            Console.WriteLine("Result = {0}", result5);
            Console.ReadKey();

            //type casting
            Console.WriteLine("convert");
            //รับค่า
            String myString = "120";
            //แปลงข้อมูลตัวเลข
            byte myByte = (byte)Convert.ToSByte(myString);
            short myShort = (short)Convert.ToInt16(myString);
            int myInt = (int)Convert.ToInt32(myString);
            long myLong = (long)Convert.ToInt64(myString);

            //ทศนิยม
            float myFloat = Convert.ToSingle(myString);
            double myDouble = Convert.ToDouble(myString);
            //แปลงเลขเป็นข้อมูล
            string result3 = Convert.ToString(myDouble);
            //แสดงผล
            Console.WriteLine("string = {0}", myString + 100);
            Console.WriteLine("byte = {0}", myByte);
            Console.WriteLine("short = {0}", myShort + 100);
            Console.WriteLine("int = {0}", myInt + 1000);
            Console.WriteLine("long = {0}", myLong);
            Console.WriteLine("float = {0}", myFloat + 50);
            Console.WriteLine("double = {0}", myDouble);
            Console.WriteLine("double to string = {0}", result3 + 100);

            //Parse
            //input
            string MyString = "200.00";
            //process
            int MyInt;
            bool success = int.TryParse(MyString, out MyInt);
            //long mylong = long.Parse(MyString);
            //float myfloat = float.Parse(MyString);
            //double myDouble = double.Parse(myString);

            //output
            Console.WriteLine("success = {0}", success);
            Console.WriteLine("int = {0}", MyInt);

            //Console.WriteLine("long = {0}", myLong);
            //Console.WriteLine("float = {0}", myFloat);
            //Console.WriteLine("double = {0}", myDouble);

            //Narrowing Casting
            float n = 1000.15f;
            double o = n;
            Console.WriteLine(y);

            //BMI
            double weight, height;
            //input
            Console.Write("Input Height (m):");
            double.TryParse(Console.ReadLine(), out height);

            Console.Write("Input Weight (m):");
            double.TryParse(Console.ReadLine(), out weight);

            //Process
            //bmi = weight/height^2
            double bmi = weight / Math.Pow(height, 2);
            //output
            Console.WriteLine("BMI = {0}", bmi);

            //If Statement
            int score = 40;

            if (score>=80)
            {
                //command
                Console.WriteLine("Grade A");

            }
            Console.WriteLine("End Program");

            //If else
            //Even Number => คู่
            //Odd Number => คี่

            int Number;
            Console.Write("Input Number = ");
            int.TryParse(Console.ReadLine(), out Number);
            if (Number % 2 == 0)
            {
                //หารลง => เป็นเลขคู่
                Console.WriteLine("{0} = Even Number", Number);

            }
            else
            {
                //หารไม่ลงตัว => เป็นเลขคี่
                Console.WriteLine("{0} = Odd Number", Number);
            }
            Console.WriteLine("End Program");

            //If แบบหลายเงื่อนไข
            //Input
            int Score;
            Console.Write("Input Score :");
            int.TryParse(Console.ReadLine(), out Score);

            //Process
            if (Score>=80)
            {
                Console.WriteLine("Grade A");
            }else if (Score>=70)
            {
                Console.WriteLine("Grade B");
            }else if (Score >= 60)
            {
                Console.WriteLine("Grade C");
            }else if (Score >= 50)
            {
                Console.WriteLine("Grade D");
            }else if (Score >= 40)
            {
                Console.WriteLine("Grade F");
            }

            string gender = "Female";
            int Height = 160;

            //AND
            if (gender == "male" && Height>=160)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Not Pass");
            }

            string Gender = "Female";
            int Heights = 160;

            //OR
            if (gender == "male" || Heights >= 160)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Not Pass");
            }

            int age = 18;

            // 18 =>teen
            // 17 =>teen
            if (!(age>=18))//true => false
            {
                Console.WriteLine("I'm Teen");
            }
            else
            {
                Console.WriteLine("I'm Children");
            }

            //คำนวณเกรดแบบง่ายๆ
            int score;
            string grade;
            Console.Write("Input Score :");
            int.TryParse(Console.ReadLine(), out score);

            if (score>=80 && score<=100)
            {
                grade = "A";
            }
            else if (score >= 70 && score <= 79)
            {
                grade = "B";
            }
            else if (score >= 60 && score <= 69)
            {
                grade = "C";
            }
            else if (score >= 50 && score <= 59)
            {
                grade = "D";
            }
            else if (score<50)
            {
                grade = "F";
            }
            else
            {
                grade = "No Data";
            }
            Console.WriteLine("score = {0} , grade = {1}", score, grade);

            //Ternary Opepator
            int score = 40;
            string result;
            result = (score >= 50) ? "Pass" : "Not Pass";

            Console.WriteLine("Status = {0}", result);

            //if ซ้อน If
            int money = 30000;

            if (money>=15000)
            {
                Console.WriteLine("Sale!!");
                if (money>=15000)
                {
                    Console.WriteLine("Sale = 10%");
                }else if (money>=20000)
                {
                    Console.WriteLine("Sale = 20%");
                }else if (money>=30000)
                {
                    Console.WriteLine("Sale = 30%");
                }
            }
            else
            {
                Console.WriteLine("Not Sale");
            }

            //Switch Case
            int number9,number2, choice;
            Console.WriteLine("Input Number1 = ");
            int.TryParse(Console.ReadLine(), out number9);
            Console.WriteLine("Input Number2 = ");
            int.TryParse(Console.ReadLine(), out number2);
            Console.WriteLine("Input Choice(1(+),2(-)) = ");
            int.TryParse(Console.ReadLine(), out choice);

            switch (choice)
            {
                case 1:
                    result = number9 + number2;
                    Console.WriteLine(result);
                    break;
                case 2:
                    result = number9 - number2;
                    Console.WriteLine(result);
                    break;
                default: Console.WriteLine("Error");
                    break;
            }

            //While Loop
            int count = 1;
            int number8;
            Console.WriteLine("Input Number :");
            int.TryParse(Console.ReadLine(), out number8);
            while (count<=1)
            {
                //command ที่ต้องการทำซ้ำ
                Console.WriteLine("{0} x {1} = {2}", number8,count,number8 * count);
                count++;
            }

            //ForLoop
            int number7;
            Console.Write("Input Product :");
            int.TryParse(Console.ReadLine(),out number7);
            for (int count=1;count<= number7; count++)
            {
                //command ที่ต้องการทำซ้ำ
                //Console.WriteLine("{0} x {1} = {2}", number7, count, number * count);
                Console.WriteLine("Produnt {0}", count);
            }

            //Do..While Loop
            int count = 10;
            do
            {
                Console.WriteLine("Hello World = {0}", count);
                count++;
            }while (count<=3);
            Console.WriteLine("End Program");

            //Break & Continue
            int number11;
            Console.Write("Input Number :");
            int.TryParse(Console.ReadLine(), out number11);
            for (int count=1;count<=12;count++)
            {
                if (count==5)
                {
                    break;
                }
                //command ที่ต้องการทำซ้ำ
                Console.WriteLine("{0} x {1} = {2}", number11,count, number11 * count);
            }
            Console.WriteLine("End Program");

            int number11;
            Console.Write("Input Number :");
            int.TryParse(Console.ReadLine(), out number11);
            for (int count = 1; count <= 12; count++)
            {
                if (count == 5)
                {
                    continue;
                }
                //command ที่ต้องการทำซ้ำ
                Console.WriteLine("{0} x {1} = {2}", number11, count, number11 * count);
            }
            Console.WriteLine("End Program");

            //หาผลรวมค่าเฉลี่ย
            int sum = 0, avg = 0;
            int count = 0;
            while (true)
            {
                int number;
                Console.Write("Input Number = ");
                int.TryParse(Console.ReadLine(), out number);
                if (number < 0) break;
                count++;
                sum += number;
            }
            Console.WriteLine("Summation = {0}", sum);
            avg = sum / count;
            Console.WriteLine("Average = {0}", avg);

            //หาเลขต่ำสุด - สูงสุด
            int minNumber = int.MaxValue, maxNumber = 0;
            while (true)
            {
                int Number1;
                Console.Write("Input Number = ");
                int.TryParse(Console.ReadLine(), out Number1);
                if (Number1 < 0) break;
                if (Number1 > maxNumber)
                {
                    maxNumber = Number1;
                }
                if (Number1 < minNumber)
                {
                    minNumber = Number1;
                }
            }
            Console.WriteLine("Max = {0}", maxNumber);
            Console.WriteLine("Min = {0}", minNumber);

            //Program ATM
            int Money;
            do
            {
                Console.Write("Input Money = ");
                int.TryParse(Console.ReadLine(), out Money);
            } while (Money % 100 != 0);//เช็คจำนวนเงินว่าเป็นกลักหน่วยหรือหลัก
            Console.WriteLine("Money = {0}", Money);//1800
            Console.WriteLine("1000 Baht= {0}", Money / 1000);//1
            Money %= 1000;//1800/1000 =>800
            Console.WriteLine("500 Baht = {0}", Money / 500);//1
            Money %= 500;//800/500 =>300
            Console.WriteLine(("100 Baht = {0}", Money / 500);//3
            Console.ReadKey();
        }
    }
}
