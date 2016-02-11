using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

// namespace methods_Practice
//{
//   class Program
// {

////NUMBERCHECK TAKE2 - revised w/ help from Imari/////////////////////////////////////////////////////////////////////////////////////
//static void Main(string[] args)
//{
//    Console.WriteLine("enter a number");
//    string input = Console.ReadLine();
//    string x = NumberCheck(input);
//    Console.WriteLine("valid entry");
//}

//static string NumberCheck(string input)
//{
//    int menuItem;
//    do
//    {
//        bool numVer = int.TryParse(input, out menuItem);
//        if ((menuItem != 0))
//        {
//            return input;
//        }
//        else if (menuItem == 0)
//        {
//            Console.WriteLine("That is not a valid entry, pleae enter a number");
//            input = Console.ReadLine();
//        }
//    }
//    while (menuItem == 0);
//    return input;
//}

////ValidName//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//static void Main(string[] args)
//{
//    Console.WriteLine("what is your first name");
//    string firstName = Console.ReadLine();
//    Console.WriteLine("what is your last name");
//    string lastName = Console.ReadLine();


//    if (((ValidName(firstName)) && (ValidName(lastName))) == true)

//        Console.WriteLine(firstName + " " + lastName);
//    else
//        Console.WriteLine("Invalid user entry, try again");

//}

//static bool ValidName(string input)
//{
//    string pattern = @"^[a-zA-Z]{1,25}$";
//    return System.Text.RegularExpressions.Regex.IsMatch(input, pattern);

//}



//    // CIRCLEAREA Method /////////////////////////////////////////////////////////////////////////
//static void Main(string[] args)
//{

//    Console.WriteLine("Enter a radius to determine area of a circle");
//    string areaAsString = Console.ReadLine();
//    double area = Convert.ToDouble(areaAsString);
//    double result = CircleArea(area);
//    Console.WriteLine(result);
//}

//static double CircleArea(double input)
//{
//    double radius = Math.PI * input * input;
//    return radius;
//}


//        //sample
//        static void Main(string[] args)
//        {
//          //string str =  Console.Readline();
//            int num = Add(2, 3);
//            Console.WriteLine(num);
//}
//        static int Add(int x, int y)
//        {
//            int z = x + y;
//            return z;
//        }

//    //  NAMEAGESTATE Method /////////////////////////////////////////////////////////////
//static void Main()
//{

//    NAMEAGESTATE();

//}
//static void NAMEAGESTATE()
//{
//    Console.WriteLine("What is your Name?");
//    string name = Console.ReadLine();
//    Console.WriteLine("What is your Address?");
//    string address = Console.ReadLine();
//    Console.WriteLine("What is your age?");
//    int Age = int.Parse(Console.ReadLine());

//    Console.WriteLine("Hello " + name + ", you are " + Age + " years old and live at " + address + ".");

//}
//    /////BUILDHOUSE Method /////////////////////////////////////////////////////////////
//static void Main()
//{

//    Console.Write("select the size of your badly constructed house between 2 and 40");
//    int length = int.Parse(Console.ReadLine());
//    int triangleSide = length;
//    int j;
//    int triangleBase = length;


//    for (triangleSide = 0; triangleSide < triangleBase; triangleSide++)
//    {

//        for (j = triangleBase - triangleSide; j > 0; j--)
//            Console.Write(" ");

//        for (j = 0; j <= 2 * triangleSide; j++)
//        {
//            if (j < 2 * triangleSide && j > 0 && triangleSide != (triangleBase - 1))
//                Console.Write(" ");
//            else
//                Console.Write("*");
//        }
//        Console.WriteLine();
//    }
//    //square
//    for (int i = 0; i < length; i++)
//        {
//            if (i == (length - 1) || i == 0)
//                Console.WriteLine(BuildHouse("* ", length));
//            else
//                Console.WriteLine("* " + BuildHouse("  ", (length - 2)) + "* ");
//        }

//        Console.WriteLine();

//}

//static String BuildHouse(String text, int count)
//{
//    String tmp = "";

//    for (int i = 0; i < count; i++)
//        tmp += text;

//    return tmp;
//}





//        //LOSTMYTEETH///////////////////////////////////////////////////
//    static void Main(string[] args)
//    {

//        Console.WriteLine("Choose A year to find out how many teeth you will have");

//        int x = LostMyTeeth();
//        Console.WriteLine("you will have " + x + " teeth.");
//    }

//    static int LostMyTeeth()
//    {
//        int year2 = int.Parse(Console.ReadLine());
//        int year1 = 2016;

//        int teeth = year2 - year1;
//        {
//            if ((teeth >= 0) && (teeth <= 5))
//                teeth = 32;
//        }
//        {
//            if ((teeth >= 6) && (teeth <= 15))
//                teeth = 30;
//        }
//        {
//            if ((teeth >= 16) && (teeth <= 30))
//                teeth = 25;
//        }
//        {
//            if ((teeth >= 31) && (teeth <= 45))
//                teeth = 20;
//        }
//        {
//            if ((teeth >= 46) && (teeth <= 60))
//                teeth = 15;
//        }
//        {
//            if ((teeth >= 61) && (teeth <= 75))
//                teeth = 10;
//        }
//        {
//            if ((teeth >= 76) && (teeth <= 90))
//                teeth = 2;
//        }

//        return teeth;

//}



//        //sample practice
//        static void Main(string[] args)
//        {
//          //string str =  Console.Readline();
//            int num = Add(2, 3);
//            Console.WriteLine(num);
//}
//        static int Add(int x, int y)
//        {
//            int z = x + y;
//            return z;
//        }


//NUMBERCHECK Method/////////////////////////////////////////////////////////////////////////////
// static void Main(string[] args)
// {

//     int x = NumberCheck();
//     Console.WriteLine(x);
//}

// static int NumberCheck()
// {
//     int menuItem;
//    do
//     {
//         Console.WriteLine("enter a number");
//         string menuAsString = Console.ReadLine();
//         bool numVer = int.TryParse(menuAsString, out menuItem);
//         if ((menuItem != 0))
//         {
//             break;
//         }
//         if (menuItem == 0)
//         {
//             Console.WriteLine("That is not a valid entry, please enter a number");
//         }

//     }
//     while (menuItem == 0);
//     return menuItem;
// }

//SOBRIETYTEST Method ////////////////////////////////////////////////////////////////////////
//static void Main(string[] args)
//{
//    SobrietyTest();
//}


//static void SobrietyTest()
//{
//    for (char c = 'z'; c >= 'a'; c--)

//        Console.WriteLine(c);
//}


//ALPHASPLITTER Method///////////////////////////////////////////////////////////////////
//static void Main(string[] args)
//{
//    Console.WriteLine("Enter a sentence to count words");
//    AlphaSplitter();

//}

//static void AlphaSplitter(params string [] words)
//{
//    string sampleText = Console.ReadLine();
//    int countWords = sampleText.Split().Length;
//    string[] sampleTextString = sampleText.Split(' ');
//    {
//        Array.Sort(sampleTextString);
//        foreach (string word in sampleTextString)
//            Console.WriteLine(word);
//    }

//}

////TOP STUDENT Method/////////////////////////////////////////////////////////////////////////////////////
//static void Main(string[] args)
//{
//    string topStudent;
//    int topAverage;
//    Console.WriteLine("Enter Student1 grade 1");
//    int s1G1 = int.Parse(Console.ReadLine());

//    Console.WriteLine("Enter Student1 Grade 2 ");
//    int s1G2 = int.Parse(Console.ReadLine());

//    Console.WriteLine("Enter Student1 Grade 3");
//    int s1G3 = int.Parse(Console.ReadLine());

//    Console.WriteLine("Enter Student2 grade 1");
//    int s2G1 = int.Parse(Console.ReadLine());

//    Console.WriteLine("Enter Student2 Grade 2 ");
//    int s2G2 = int.Parse(Console.ReadLine());

//    Console.WriteLine("Enter Student2 Grade 3");
//    int s2G3 = int.Parse(Console.ReadLine());

//    int[] student1 = { s1G1, s1G2, s1G3 };
//    int[] student2 = { s2G1, s2G2, s2G3 };

//    int student1Average = Average(student1);
//    int student2Average = Average(student2);
//    {
//        if (student1Average > student2Average)
//        {
//            topAverage = student1Average;
//            topStudent = "Student 1";
//        }
//        else
//        {
//            topAverage = student2Average;
//            topStudent = "Student 2";
//        }

//    }


//    Console.WriteLine("The Top Student is " + topStudent + " with an average of " + topAverage);
//}

//static int Average(params int [] grades)
//{

//    int sum = 0;
//    for (int i = 0; i < grades.Length; i++) 
//    {
//        sum += grades[i];

//    }
//    int average = sum / grades.Length;
//    return average;

//}



////FAMILYGUY Method//////////////////////////////////////////////////////////////
//static void Main(string[] args)
//{
//    string[] familyGuyCharachters = { "peter", "louis", "stewie", "brian" };
//    string[] printFamilyguy = FamilyGuy(familyGuyCharachters);

//}

//static string [] FamilyGuy(params string [] printlist)
//{
//    foreach (string word in printlist)
//       Console.WriteLine(word);
//    return printlist;
//}





//PRINTARRAY Method/////////////////////////////////////////////////////////////////
//static void Main(string[] args)
//{
//    string [] arrayToPrint = { "one", "five", "seven", "nine" };
//   string [] newArrayToPrint = PrintArray(arrayToPrint);
//}

//static string[] PrintArray(params string [] printlist)
//{
//    foreach (string word in printlist)
//    {
//        Console.WriteLine(word);
//    }
//    return printlist;
//}   


// PROPERNAME////////////////////////////////////////////////////////////////////
//static void Main(string[] args)
//{
//    Console.WriteLine("What is your name?");
//    string name = Console.ReadLine();
//    string newName = UserName(name);
//    Console.WriteLine("Hello " + newName + ", welcome to the console.");



//}

//static string UserName(string nameTest)
//{

//    string nameTitle = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nameTest);
//    return nameTitle;

//}

//USERNAME//////////////////////////////////////////////////////////////////////////
//static void Main(string[] args)
//{
//    userName();
//}
//    static void userName()
//{
//    Console.WriteLine("What is your name?");
//    string name = Console.ReadLine();
//    string nameTitle = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name);
//    Console.WriteLine(nameTitle);
//    Console.WriteLine("What is your phone nbr?");
//    string phoneNbr = Console.ReadLine();
//}




//{
//    Console.WriteLine("enter the first number");
//    double nbr1 = Convert.ToDouble(Console.ReadLine());

//    Console.WriteLine("enter a second nbr");
//    double nbr2 = Convert.ToDouble(Console.ReadLine());

//    Console.WriteLine("what operation would you like to perform");
//    char operation = Convert.ToChar(Console.ReadLine());

//    switch (operation)

//    {
//        case '+':

//            {

//                Console.WriteLine(Add(nbr1, nbr2));
//                break;
//            }
//        case '-':
//            {
//                Console.WriteLine(substract(nbr1, nbr2));
//                break;
//            }
//        case '*':
//            {
//                Console.WriteLine(Mult(nbr1, nbr2));
//                break;
//            }
//        case '/':
//            {
//                Console.WriteLine(Div(nbr1, nbr2));
//                    break;
//            }
//    }



//}

//static double Add(double nbr1, double nbr2)
//{
//    double addSum = nbr1 + nbr2;
//    return addSum;

//}

//static double substract(double nbr1, double nbr2)
//{
//    double subSum = nbr1 - nbr2;
//    return subSum;
//}

//static double Mult(double nbr1, double nbr2)
//{
//    double multSum = nbr1 * nbr2;
//    return multSum;

//}

//static double Div(double nbr1, double nbr2)
//{
//    double divSum = nbr1 / nbr2;
//    return divSum;

//}


//COUNTDOWNTIMER///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//    static void Main(string[] args)
//    {
//        Console.WriteLine("enter the days");
//        int days = int.Parse(Console.ReadLine());
//        Console.WriteLine("enter the hours");
//        int hours = int.Parse(Console.ReadLine());
//        Console.WriteLine("enter the minutes");
//        int minutes = int.Parse(Console.ReadLine());
//        Console.WriteLine("enter the seconds");
//        int seconds = int.Parse(Console.ReadLine());

//        int daysAsSeconds = (days * 86400);
//        int hoursAsSeconds = (hours * 3600);
//        int minutesAsSeconds = (minutes * 60);
//        int totalTimeSeconds = (daysAsSeconds + hoursAsSeconds + minutesAsSeconds + seconds);




//        for (int i = totalTimeSeconds; i >= 0; i--)
//        {
//            if (i != 0)
//                CountDown(i);
//            else
//                Console.WriteLine("Time's Up");

//            Thread.Sleep(1000);
//            Console.Clear();

//        }
//    }
//        static void CountDown(int i)
//            {

//            int daysClock = (i / 86400);
//            int hoursClock = ((i % 86400) / 3600);
//            int minutesClock = (((i % 86400) % 3600) / 60);
//            int secondsClock = ((((i % 86400) % 3600) % 60) % 60);
//            Console.WriteLine("Days: " + daysClock);
//            Console.WriteLine("Hours: " + hoursClock);
//            Console.WriteLine("Minutes: " + minutesClock);
//            Console.WriteLine("Seconds: " + secondsClock);
//        }

//    }

//}






