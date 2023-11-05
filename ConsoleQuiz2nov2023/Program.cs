namespace ConsoleQuiz2nov2023
{
    class ProgramQuiz2nov2023
    {
        const string quote = "\"";

        static void Main(string[] args)
        {
            Console.SetWindowSize(180, 30);

            int score = 0;
            int minimumScore = 0;
            int maximumScore = 0;

            Vraag1(ref score, ref minimumScore, ref maximumScore);
            Vraag2(ref score, ref minimumScore, ref maximumScore);
            Vraag3(ref score, ref minimumScore, ref maximumScore);
            Vraag4(ref score, ref minimumScore, ref maximumScore);
            Vraag5(ref score, ref minimumScore, ref maximumScore);
            Vraag6(ref score, ref minimumScore, ref maximumScore);
            Vraag7(ref score, ref minimumScore, ref maximumScore);
            Vraag8(ref score, ref minimumScore, ref maximumScore);
            Vraag9(ref score, ref minimumScore, ref maximumScore);
            Vraag10(ref score, ref minimumScore, ref maximumScore);
            Vraag11(ref score, ref minimumScore, ref maximumScore);
            Vraag12(ref score, ref minimumScore, ref maximumScore);
            Vraag13(ref score, ref minimumScore, ref maximumScore);
            Vraag14(ref score, ref minimumScore, ref maximumScore);
            Vraag15(ref score, ref minimumScore, ref maximumScore);
            Vraag16(ref score, ref minimumScore, ref maximumScore);
            Vraag17(ref score, ref minimumScore, ref maximumScore);
            Vraag18(ref score, ref minimumScore, ref maximumScore);
            Vraag19(ref score, ref minimumScore, ref maximumScore);
            Vraag20(ref score, ref minimumScore, ref maximumScore);
            Vraag21(ref score, ref minimumScore, ref maximumScore);
            //Vraag22(ref score, ref minimumScore, ref maximumScore);
            Vraag23(ref score, ref minimumScore, ref maximumScore);
            Vraag24(ref score, ref minimumScore, ref maximumScore);
            Vraag25(ref score, ref minimumScore, ref maximumScore);
            Vraag26(ref score, ref minimumScore, ref maximumScore);
            Vraag27(ref score, ref minimumScore, ref maximumScore);
            Vraag28(ref score, ref minimumScore, ref maximumScore);
            Vraag29(ref score, ref minimumScore, ref maximumScore);
            Vraag30(ref score, ref minimumScore, ref maximumScore);
            Vraag31(ref score, ref minimumScore, ref maximumScore);
            Vraag32(ref score, ref minimumScore, ref maximumScore);
            Vraag33(ref score, ref minimumScore, ref maximumScore);
            Vraag34(ref score, ref minimumScore, ref maximumScore);
            Vraag35(ref score, ref minimumScore, ref maximumScore);
            Vraag36(ref score, ref minimumScore, ref maximumScore);
            Vraag37(ref score, ref minimumScore, ref maximumScore);
            Vraag38(ref score, ref minimumScore, ref maximumScore);
            Vraag39(ref score, ref minimumScore, ref maximumScore);
            Vraag40(ref score, ref minimumScore, ref maximumScore);
            Vraag41(ref score, ref minimumScore, ref maximumScore);
            Vraag42(ref score, ref minimumScore, ref maximumScore);
            Vraag43(ref score, ref minimumScore, ref maximumScore);

            Console.WriteLine(Environment.NewLine + $"Score: {score} op {maximumScore}");

            Console.WriteLine(Environment.NewLine + "Kris Borremans");
            Console.ReadLine();
        }


        static void Vraag1(ref int score, ref int minimumScore, ref int maximumScore)
        {

            Console.WriteLine("Vraag 1:");
            // https://www.sanfoundry.com/csharp-mcqs-switch-statements/
            Console.WriteLine("Wat is de output van volgende C# code:");

            string opgave1 = @"
      static void Main(string[] args)
      {
          int movie = 1;

          switch (movie << 2 + movie)
          {
          default: 
              Console.WriteLine(" + quote + "3 Idiots" + quote + @");
              break;
          case 4: 
              Console.WriteLine(" + quote + "Ghazini" + quote + @");
              break;
          case 5: 
              Console.WriteLine(" + quote + "Krishh" + quote + @");
              break;
          case 8: 
              Console.WriteLine(" + quote + "Race" + quote + @");
              break;
          }
      }";

            Console.WriteLine(opgave1);
            Console.WriteLine(Environment.NewLine + @"a) 3 Idiots
b) Ghazini
c) Race
d) Krishh");

            Console.WriteLine("Uw antwoord: ");
            string antwoord1 = Console.ReadLine();
            switch (antwoord1.ToLower())
            {
                case "a":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "b":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "c":
                    Console.WriteLine("Correct!");
                    score += 2;
                    break;
                case "d":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                default:
                    Console.WriteLine("Dit antwoord behoort niet tot de mogelijkheden.");
                    score += -1;
                    break;
            }

            minimumScore--;
            maximumScore = maximumScore + 2;

            Console.WriteLine(Environment.NewLine + "Press the enter key voor volgende vraag.");
            string temp = Console.ReadLine();
            Console.Clear();

        }

        static void Vraag2(ref int score, ref int minimumScore, ref int maximumScore)
        {
            Console.WriteLine("Vraag 2:");
            // https://www.sanfoundry.com/csharp-multiple-choice-questions-answers/
            Console.WriteLine("Wat is de output van volgende C# code:");

            string opgave2 = @"
     static void Main(string[] args)
     {
         byte varA = 10;
         byte varB = 20;
         long result = varA & varB;

         Console.WriteLine(" + quote + @"{0} AND {1} Result: {2}" + quote + @", varA, varB, result);

         varA = 10;
         varB = 10;
         result = varA & varB;

         Console.WriteLine(" + quote + @"{0} AND {1} Result: {2}" + quote + @", varA, varB, result);
     }
            ";

            Console.WriteLine(opgave2);
            Console.WriteLine(Environment.NewLine + @"a) 0, 20
b) 10, 10
c) 0, 10
d) 0, 0");

            Console.WriteLine("Uw antwoord: ");
            string antwoord2 = Console.ReadLine();
            switch (antwoord2.ToLower())
            {
                case "a":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "b":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "c":
                    Console.WriteLine("Correct!");
                    score += 2;
                    break;
                case "d":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                default:
                    Console.WriteLine("Dit antwoord behoort niet tot de mogelijkheden.");
                    score += -1;
                    break;
            }

            minimumScore--;
            maximumScore = maximumScore + 2;

            Console.WriteLine(Environment.NewLine + "Press the enter key voor volgende vraag.");
            string temp = Console.ReadLine();
            Console.Clear();
        }

        static void Vraag3(ref int score, ref int minimumScore, ref int maximumScore)
        {

            Console.WriteLine("Vraag 3:");
            // https://www.sanfoundry.com/csharp-mcqs-fundamental-delegates/
            Console.WriteLine("To implement delegates, the necessary condition is?");

            Console.WriteLine(Environment.NewLine + @"a) class declaration
b) inheritance
c) runtime polymorphism
d) exceptions");

            Console.WriteLine("Uw antwoord: ");
            string antwoord3 = Console.ReadLine();
            switch (antwoord3.ToLower())
            {
                case "a":
                    Console.WriteLine("Correct!");
                    score += 2;
                    break;
                case "b":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "c":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "d":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                default:
                    Console.WriteLine("Dit antwoord behoort niet tot de mogelijkheden.");
                    score += -1;
                    break;
            }

            minimumScore--;
            maximumScore = maximumScore + 2;

            Console.WriteLine(Environment.NewLine + "Press the enter key voor volgende vraag.");
            string temp = Console.ReadLine();
            Console.Clear();

        }


        static void Vraag4(ref int score, ref int minimumScore, ref int maximumScore)
        {
            Console.WriteLine("Vraag 4:");
            // https://www.sanfoundry.com/csharp-mcqs-integer-data-types/
            string opgave = @"How many Bytes are stored by ‘Long’ Data type in C# .net?
a) 8
b) 4
c) 2
d) 1";

            Console.WriteLine(opgave);

            Console.WriteLine("Uw antwoord: ");
            string antwoord4 = Console.ReadLine();
            switch (antwoord4.ToLower())
            {
                case "a":
                    Console.WriteLine("Correct");
                    score += 2;
                    break;
                case "b":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "c":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "d":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                default:
                    Console.WriteLine("Dit antwoord behoort niet tot de mogelijkheden.");
                    score += -1;
                    break;
            }

            Console.WriteLine("‘Long’ is the data type keyword used for storing data of unlimited length so by definition its size is always maximum i.e 8.");

            minimumScore--;
            maximumScore = maximumScore + 2;

            Console.WriteLine(Environment.NewLine + "Press the enter key voor volgende vraag.");
            string temp = Console.ReadLine();
            Console.Clear();
        }




        static void Vraag5(ref int score, ref int minimumScore, ref int maximumScore)
        {
            Console.WriteLine("Vraag 5:");

            string opgave = @"2. Choose “.NET class” name from which data type “UInt” is derived?
a) System.Int16
b) System.UInt32
c) System.UInt64
d) System.UInt16";

            Console.WriteLine(opgave);

            Console.WriteLine("Uw antwoord: ");
            string antwoord5 = Console.ReadLine();
            switch (antwoord5.ToLower())
            {
                case "a":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "b":
                    Console.WriteLine("Correct!");
                    score += 2;
                    break;
                case "c":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "d":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                default:
                    Console.WriteLine("Dit antwoord behoort niet tot de mogelijkheden.");
                    score += -1;
                    break;
            }

            Console.WriteLine(@"By Definition class assigned to
i) System.Int16 = short.
ii) System.UInt32 = UInt.
iii) System.UInt64 = ULong.
iv) System.UInt16 = UShort.");

            minimumScore--;
            maximumScore = maximumScore + 2;

            Console.WriteLine(Environment.NewLine + "Press the enter key voor volgende vraag.");
            string temp = Console.ReadLine();
            Console.Clear();
        }


        static void Vraag6(ref int score, ref int minimumScore, ref int maximumScore)
        {
            Console.WriteLine("Vraag 6:");

            string opgave = @"Which data type should be more preferred for storing a simple number like 35 to improve execution speed of a program?
a) sbyte
b) short
c) int
d) long";

            Console.WriteLine(opgave);

            Console.WriteLine("Uw antwoord: ");
            string antwoord6 = Console.ReadLine();
            switch (antwoord6.ToLower())
            {
                case "a":
                    Console.WriteLine("Correct!");
                    score += 2;
                    break;
                case "b":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "c":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "d":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                default:
                    Console.WriteLine("Dit antwoord behoort niet tot de mogelijkheden.");
                    score += -1;
                    break;
            }

            Console.WriteLine("Wider data type like int, long takes more time for manipulation of a program.");

            minimumScore--;
            maximumScore = maximumScore + 2;

            Console.WriteLine(Environment.NewLine + "Press the enter key voor volgende vraag.");
            string temp = Console.ReadLine();
            Console.Clear();
        }




        static void Vraag7(ref int score, ref int minimumScore, ref int maximumScore)
        {
            Console.WriteLine("Vraag 7:");

            string opgave = @"Which Conversion function of ‘Convert.TOInt32()’ and ‘Int32.Parse()’ is efficient?
i) Int32.Parse() is only used for strings and throws argument exception for null string
ii) Convert.Int32() used for data types and returns directly '0' for null string

a) ii
b) Both i, ii
c) i
d) None of the mentioned";

            Console.WriteLine(opgave);

            Console.WriteLine("Uw antwoord: ");
            string antwoord7 = Console.ReadLine();
            switch (antwoord7.ToLower())
            {
                case "a":
                    Console.WriteLine("Correct!");
                    score += 2;
                    break;
                case "b":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "c":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "d":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                default:
                    Console.WriteLine("Dit antwoord behoort niet tot de mogelijkheden.");
                    score += -1;
                    break;
            }

            Console.WriteLine(@"Answer: a
Explanation: Convenient for every data type so mostly preferred.");

            minimumScore--;
            maximumScore = maximumScore + 2;

            Console.WriteLine(Environment.NewLine + "Press the enter key voor volgende vraag.");
            string temp = Console.ReadLine();
            Console.Clear();
        }


        static void Vraag8(ref int score, ref int minimumScore, ref int maximumScore)
        {
            Console.WriteLine("Vraag 8:");
            // https://www.sanfoundry.com/csharp-mcqs-integer-data-types/
            string opgave = @"Correct way to assign values to variable ‘c’ when int a=12, float b=3.5, int c;
a) c = a + b;
b) c = a + int(float(b));
c) c = a + Convert.ToInt32(b);
d) c = int(a + b);";

            Console.WriteLine(opgave);

            Console.WriteLine("Uw antwoord: ");
            string antwoord3 = Console.ReadLine();
            switch (antwoord3.ToLower())
            {
                case "a":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "b":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "c":
                    Console.WriteLine("Correct!");
                    score += 2;
                    break;
                case "d":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                default:
                    Console.WriteLine("Dit antwoord behoort niet tot de mogelijkheden.");
                    score += -1;
                    break;
            }

            minimumScore--;
            maximumScore = maximumScore + 2;

            Console.WriteLine(Environment.NewLine + "Press the enter key voor volgende vraag.");
            string temp = Console.ReadLine();
            Console.Clear();
        }


        static void Vraag9(ref int score, ref int minimumScore, ref int maximumScore)
        {
            Console.WriteLine("Vraag 9:");

            string opgave = @"What will be Correct Set of C# Code for given data ‘a’ and ‘b’ to print output for ‘c’ as 74?
a)     int a = 12;
       float b = 6.2f;
       int c;
       c = a / b + a * b;
       Console.WriteLine(c);

b)     int a = 12;
       float b = 6.2f;
       int c;
       c = a / Convert.ToInt32(b) + a * b;
       Console.WriteLine(c);

c)     int a = 12;
       float b = 6.2f;
       int c;
       c = a / Convert.ToInt32(b) + a * Convert.ToInt32(b);
       Console.WriteLine(c);

d)      int a = 12;
        float b = 6.2f;
        int c;
        c = Convert.ToInt32(a / b + a * b);
        Console.WriteLine(c);";

            Console.WriteLine(opgave);

            Console.WriteLine("Uw antwoord: ");
            string antwoord3 = Console.ReadLine();
            switch (antwoord3.ToLower())
            {
                case "a":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "b":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "c":
                    Console.WriteLine("Correct!");
                    score += 2;
                    break;
                case "d":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                default:
                    Console.WriteLine("Dit antwoord behoort niet tot de mogelijkheden.");
                    score += -1;
                    break;
            }

            Console.WriteLine(@"Answer: c
Explanation: Usage of typecasting operation. Separately check each expression taking typecast operations in concern.");

            minimumScore--;
            maximumScore = maximumScore + 2;

            Console.WriteLine(Environment.NewLine + "Press the enter key voor volgende vraag.");
            string temp = Console.ReadLine();
            Console.Clear();
        }


        static void Vraag10(ref int score, ref int minimumScore, ref int maximumScore)
        {
            Console.WriteLine("Vraag 10:");

            string opgave = @"Does the output remain same or different for both cases?
i)
      char l ='k';
      float b = 19.0f;
      int c;
      c = (l / Convert.ToInt32(b));
      Console.WriteLine(c);

ii)
       char l ='k';
       float b = 19.0f;
       int c;
       c = Convert.ToInt32(l / b);
       Console.WriteLine(c);

a) Yes
b) No";

            Console.WriteLine(opgave);

            Console.WriteLine("Uw antwoord: ");
            string antwoord3 = Console.ReadLine();
            switch (antwoord3.ToLower())
            {
                case "a":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "b":
                    Console.WriteLine("Correct!");
                    score += 2;
                    break;
                default:
                    Console.WriteLine("Dit antwoord behoort niet tot de mogelijkheden.");
                    score += -1;
                    break;
            }


            minimumScore--;
            maximumScore += 2;

            Console.WriteLine(Environment.NewLine + "Press the enter key voor volgende vraag.");
            string temp = Console.ReadLine();
            Console.Clear();
        }


        static void Vraag11(ref int score, ref int minimumScore, ref int maximumScore)
        {
            Console.WriteLine("Vraag 11:");
            // https://www.sanfoundry.com/csharp-mcqs-integer-data-types/
            string opgave = @"What will be the output of the following C# code?

     static void Main(string[] args)
     {
         float a = 10.553f;
         long b = 12L;
         int  c;
         c = Convert.ToInt32(a + b);
         Console.WriteLine(c);
     }

a) 23.453
b) 22
c) 23
d) 22.453";

            Console.WriteLine(opgave);

            Console.WriteLine("Uw antwoord: ");
            string antwoord3 = Console.ReadLine();
            switch (antwoord3.ToLower())
            {
                case "a":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "b":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "c":
                    Console.WriteLine("Correct!");
                    score += 2;
                    break;
                case "d":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                default:
                    Console.WriteLine("Dit antwoord behoort niet tot de mogelijkheden.");
                    score += -1;
                    break;
            }

            Console.WriteLine(@"Answer: c
Explanation: The two data type ‘float’ and ‘long’ after arithmetic operation completely converted to nearest whole number 23.");

            minimumScore--;
            maximumScore += 2;

            Console.WriteLine(Environment.NewLine + "Press the enter key voor volgende vraag.");
            string temp = Console.ReadLine();
            Console.Clear();
        }




        static void Vraag12(ref int score, ref int minimumScore, ref int maximumScore)
        {
            Console.WriteLine("Vraag 12:");
            // https://www.sanfoundry.com/csharp-mcqs-floating-decimal-data-types/
            string opgave = @"Number of digits upto which precision value of float data type is valid?
a) Upto 6 digit
b) Upto 8 digit
c) Upto 9 digit
d) Upto 7 digit";

            Console.WriteLine(opgave);

            Console.WriteLine("Uw antwoord: ");
            string antwoord12 = Console.ReadLine();
            switch (antwoord12.ToLower())
            {
                case "a":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "b":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "c":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "d":
                    Console.WriteLine("Correct!");
                    score += 2;
                    break;
                default:
                    Console.WriteLine("Dit antwoord behoort niet tot de mogelijkheden.");
                    score += -1;
                    break;
            }

            minimumScore--;
            maximumScore += 2;

            Console.WriteLine(Environment.NewLine + "Press the enter key voor volgende vraag.");
            string temp = Console.ReadLine();
            Console.Clear();
        }


        static void Vraag13(ref int score, ref int minimumScore, ref int maximumScore)
        {
            Console.WriteLine("Vraag 13:");

            string opgave = @"Valid Size of float data type is?
a) 10 Bytes
b) 6 Bytes
c) 4 Bytes
d) 8 Bytes";

            Console.WriteLine(opgave);

            Console.WriteLine("Uw antwoord: ");
            string antwoord13 = Console.ReadLine();
            switch (antwoord13.ToLower())
            {
                case "a":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "b":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "c":
                    Console.WriteLine("Correct!");
                    score += 2;
                    break;
                case "d":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                default:
                    Console.WriteLine("Dit antwoord behoort niet tot de mogelijkheden.");
                    score += -1;
                    break;
            }


            minimumScore--;
            maximumScore += 2;

            Console.WriteLine(Environment.NewLine + "Press the enter key voor volgende vraag.");
            string temp = Console.ReadLine();
            Console.Clear();
        }


        static void Vraag14(ref int score, ref int minimumScore, ref int maximumScore)
        {
            Console.WriteLine("Vraag 14:");

            string opgave = @"What will be the correct set of C# code to display the value of given variable ‘c’ as ‘25.302’.
a)     float a = (double) 12.502f;
       float b = 12.80f;
       float c;
       c = (float) a + b;
       Console.WriteLine(c);
       Console.ReadLine();

b)     float a = 12.502D;
       float b = 12.80f;
       float c;
       c = a + b;
       Console.WriteLine(c);
       Console.ReadLine();

c)     double a = 12.502;
       float b = 12.802f;
       float c;
       c = (float)a + b;
       Console.WriteLine(c);
       Console.ReadLine();

d)     double a = (float) 12.502f;
       float  b = 12.80f;
       float  c;
       c = a + b;
       Console.WriteLine(c);
       Console.ReadLine();";

            Console.WriteLine(opgave);

            Console.WriteLine("Uw antwoord: ");
            string antwoord3 = Console.ReadLine();
            switch (antwoord3.ToLower())
            {
                case "a":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "b":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "c":
                    Console.WriteLine("Correct!");
                    score += 2;
                    break;
                case "d":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                default:
                    Console.WriteLine("Dit antwoord behoort niet tot de mogelijkheden.");
                    score += -1;
                    break;
            }


            minimumScore--;
            maximumScore += 2;

            Console.WriteLine(Environment.NewLine + "Press the enter key voor volgende vraag.");
            string temp = Console.ReadLine();
            Console.Clear();
        }


        static void Vraag15(ref int score, ref int minimumScore, ref int maximumScore)
        {
            Console.WriteLine("Vraag 15:");
            // https://www.sanfoundry.com/csharp-mcqs-floating-decimal-data-types/
            string opgave = @"Minimum and Maximum range of values supported by ‘float’ data type are?
a) 1.5 * 10^-40 to 3.4 * 10^38
b) 1.5 * 10^-45 to 3.4 * 10^30
c) 1.5 * 10^-45 to 3.4 * 10^38
d) 1.5 * 10^-45 to 3.4 * 10^37";

            Console.WriteLine(opgave);

            Console.WriteLine("Uw antwoord: ");
            string antwoord3 = Console.ReadLine();
            switch (antwoord3.ToLower())
            {
                case "a":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "b":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "c":
                    Console.WriteLine("Correct!");
                    score += 2;
                    break;
                case "d":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                default:
                    Console.WriteLine("Dit antwoord behoort niet tot de mogelijkheden.");
                    score += -1;
                    break;
            }


            minimumScore--;
            maximumScore += 2;

            Console.WriteLine(Environment.NewLine + "Press the enter key voor volgende vraag.");
            string temp = Console.ReadLine();
            Console.Clear();
        }


        static void Vraag16(ref int score, ref int minimumScore, ref int maximumScore)
        {
            Console.WriteLine("Vraag 16:");
            // https://www.sanfoundry.com/csharp-mcqs-floating-decimal-data-types/
            string opgave = @"Why does a float variable stop incrementing at number ‘16777216’ in the following C# code?

     float a = 0 ;
     while (true)
     {
         a++;
         if (a > 16777216)
         break;
     }

a) Sign and Exponent for ‘16777217’ is same as for ‘16777216’
b) Mantissa is different for ‘16777216’ and ‘16777217’
c) Sign and Exponent for ‘16777217’ is different from ‘16777216’
d) None of the mentioned";

            Console.WriteLine(opgave);

            Console.WriteLine("Uw antwoord: ");
            string antwoord16 = Console.ReadLine();
            switch (antwoord16.ToLower())
            {
                case "a":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "b":
                    Console.WriteLine("Correct!");
                    score += 2;
                    break;
                case "c":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "d":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                default:
                    Console.WriteLine("Dit antwoord behoort niet tot de mogelijkheden.");
                    score += -1;
                    break;
            }

            Console.WriteLine(@"Answer: b
Explanation: 16777216 is exactly 2^24, and would be represented as 32-bit float like so:
sign = 0 (positive number)
exponent = 24 (stored as 24 + 127 = 151 = 10010111)
mantissa = . 0
As 32 bits floating-point representation: 0 10010111 00000000000000000000000
Therefore: Value = (+ 1) * 2 ^ 24 * (1. 0 + . 0) = 2 ^ 24 = 16777216
Now let’s look at the number 16777217, or exactly 2^24 + 1:
sign and exponent are the same.
Mantissa should have to be exactly 2^(-24) so that (+ 1) * 2 ^ 24 * (1. 0 + 2 ^-24) = 2 ^ 24 + 1 = 16777217 and here lies the actual problem. 
The mantissa cannot have the value 2^(-24) because it only has 23 bits, so the number 16777217 just cannot be represented with the accuracy of 32-bit floating points numbers.");

            minimumScore--;
            maximumScore += 2;

            Console.WriteLine(Environment.NewLine + "Press the enter key voor volgende vraag.");
            string temp = Console.ReadLine();
            Console.Clear();
        }


        static void Vraag17(ref int score, ref int minimumScore, ref int maximumScore)
        {
            Console.WriteLine("Vraag 17:");

            string opgave = @"What will be the output of the following C# code?

    static void Main(string[] args)
    {
        int x = 1;
        float y = 2.4f;
        short z = 1;
        Console. WriteLine((float) x + y * z - (x += (short) y) );
        Console. ReadLine();
    }

a) 0.4000004
b) 0.4000023
c) 0.0400021
d) 0.4000001";

            Console.WriteLine(opgave);

            Console.WriteLine("Uw antwoord: ");
            string antwoord3 = Console.ReadLine();
            switch (antwoord3.ToLower())
            {
                case "a":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "b":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "c":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "d":
                    Console.WriteLine("Correct!");
                    score += 2;
                    break;
                default:
                    Console.WriteLine("Dit antwoord behoort niet tot de mogelijkheden.");
                    score += -1;
                    break;
            }

            Console.WriteLine("Answer: d");

            minimumScore--;
            maximumScore += 2;

            Console.WriteLine(Environment.NewLine + "Press the enter key voor volgende vraag.");
            string temp = Console.ReadLine();
            Console.Clear();
        }


        static void Vraag18(ref int score, ref int minimumScore, ref int maximumScore)
        {
            Console.WriteLine("Vraag 18:");

            string opgave = @"A float occupies 4 bytes. If the hexadecimal equivalent of these 4 bytes are A, B, C and D, then when this float is stored in memory in which of the following order do these bytes gets stored?
a) ABCD
b) DCBA
c) 0 * ABCD
d) Depends on big endian or little endian architecture";

            Console.WriteLine(opgave);

            Console.WriteLine("Uw antwoord: ");
            string antwoord3 = Console.ReadLine();
            switch (antwoord3.ToLower())
            {
                case "a":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "b":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "c":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "d":
                    Console.WriteLine("Correct!");
                    score += 2;
                    break;
                default:
                    Console.WriteLine("Dit antwoord behoort niet tot de mogelijkheden.");
                    score += -1;
                    break;
            }

            Console.WriteLine(@"Answer: d
Explanation: “Little Endian” means that the lower - order byte of the number is stored in memory at the lowest address, and the high order byte at the highest address.For example, a 4 byte Integer
ABCD will be arranged in memory as follows:
Base Address + 0 Byte 0.
Base Address + 1 Byte 1.
Base Address + 2 Byte 2.
Base Address + 3 Byte 3.
Intel processors(those used in PC’s) use “Little Endian” byte order.
“Big Endian” means that the high - order byte of the number is stored in memory at the lowest address, and the low - order byte at the highest address.The same 4 byte integer would be stored as:
Base Address + 0 Byte 3.
Base Address + 1 Byte 2.
Base Address + 2 Byte 1.
Base Address + 3 Byte 0.");

            minimumScore--;
            maximumScore += 2;

            Console.WriteLine(Environment.NewLine + "Press the enter key voor volgende vraag.");
            string temp = Console.ReadLine();
            Console.Clear();
        }


        static void Vraag19(ref int score, ref int minimumScore, ref int maximumScore)
        {
            Console.WriteLine("Vraag 19:");

            string opgave = @"The Default value of Boolean Data Type is?
a) 0
b) True
c) False
d) 1";

            Console.WriteLine(opgave);

            Console.WriteLine("Uw antwoord: ");
            string antwoord3 = Console.ReadLine();
            switch (antwoord3.ToLower())
            {
                case "a":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "b":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "c":
                    Console.WriteLine("Correct!");
                    score += 2;
                    break;
                case "d":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                default:
                    Console.WriteLine("Dit antwoord behoort niet tot de mogelijkheden.");
                    score += -1;
                    break;
            }


            minimumScore--;
            maximumScore += 2;

            Console.WriteLine(Environment.NewLine + "Press the enter key voor volgende vraag.");
            string temp = Console.ReadLine();
            Console.Clear();
        }


        static void Vraag20(ref int score, ref int minimumScore, ref int maximumScore)
        {
            Console.WriteLine("Vraag 20:");

            string opgave = @"What will be the output of the following C# code?
     public static void Main(string[] args)
     {
         double ZERO = 0;
         Console.WriteLine(" +
         quote + "RESULT OF DIVISION BY ZERO IS :{ 0}" + quote + ",  (0 / ZERO)); " + quote + @"
         Console.ReadLine();
        }";

            Console.WriteLine(opgave);
            Console.WriteLine(@"a) 1
b) exception argument is thrown
c) NaN
d) 0");

            Console.WriteLine("Uw antwoord: ");
            string antwoord3 = Console.ReadLine();
            switch (antwoord3.ToLower())
            {
                case "a":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "b":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "c":
                    Console.WriteLine("Correct!");
                    score += 2;
                    break;
                case "d":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                default:
                    Console.WriteLine("Dit antwoord behoort niet tot de mogelijkheden.");
                    score += -1;
                    break;
            }

            minimumScore--;
            maximumScore += 2;

            Console.WriteLine(Environment.NewLine + "Press the enter key voor volgende vraag.");
            string temp = Console.ReadLine();
            Console.Clear();
        }


        static void Vraag21(ref int score, ref int minimumScore, ref int maximumScore)
        {
            Console.WriteLine("Vraag 21:");
            // https://www.sanfoundry.com/csharp-mcqs-char-types-string-literals/
            string opgave = @"What is the Size of ‘Char’ datatype?
a) 8 bit
b) 12 bit
c) 16 bit
d) 20 bit";

            Console.WriteLine(opgave);

            Console.WriteLine("Uw antwoord: ");
            string antwoord3 = Console.ReadLine();
            switch (antwoord3.ToLower())
            {
                case "a":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "b":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "c":
                    Console.WriteLine("Correct!");
                    score += 2;
                    break;
                case "d":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                default:
                    Console.WriteLine("Dit antwoord behoort niet tot de mogelijkheden.");
                    score += -1;
                    break;
            }

            Console.WriteLine("Size of ‘Char’ datatype is 16 bit.");

            minimumScore--;
            maximumScore += 2;

            Console.WriteLine(Environment.NewLine + "Press the enter key voor volgende vraag.");
            string temp = Console.ReadLine();
            Console.Clear();
        }


        /// <summary>
        /// Dit is onduidelijk.
        /// </summary>
        /// <param name="score"></param>
        /// <param name="minimumScore"></param>
        /// <param name="maximumScore"></param>
        static void Vraag22(ref int score, ref int minimumScore, ref int maximumScore)
        {
            Console.WriteLine("Vraag 22:");
            // https://www.sanfoundry.com/csharp-mcqs-char-types-string-literals/
            string opgave = @"What will be the output of the following C# code?
             static void Main(string[] args)
             {
                 char c = 'g';
                 string s = c.ToString();
                 string s1 = " + quote + "I am a human being" + quote + @" + c;
                 Console.WriteLine(s1);
                    Console.ReadLine();
                }";

            Console.WriteLine(opgave);
            Console.WriteLine(@"a) I am a human bein c
        b) I am a human being
        c) I am a human being c
        d) I am a human bein");

            Console.WriteLine("Uw antwoord: ");
            string antwoord3 = Console.ReadLine();
            switch (antwoord3.ToLower())
            {
                case "a":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "b":
                    Console.WriteLine("Correct!");
                    score += 2;
                    break;
                case "c":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "d":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                default:
                    Console.WriteLine("Dit antwoord behoort niet tot de mogelijkheden.");
                    score += -1;
                    break;
            }

            Console.WriteLine(@"Answer: b
        Explanation: ‘g’is stored in character variable ‘c’ which later on is converted to string using method Convert.Tostring() and hence appended at last of the string in s1.
        Output: I am a human being.");

            minimumScore--;
            maximumScore += 2;

            Console.WriteLine(Environment.NewLine + "Press the enter key voor volgende vraag.");
            string temp = Console.ReadLine();
            Console.Clear();
        }


        static void Vraag23(ref int score, ref int minimumScore, ref int maximumScore)
        {
            Console.WriteLine("Vraag 23:");
            // https://www.sanfoundry.com/csharp-mcqs-char-types-string-literals/
            string opgave = @"Given is the code of days(example:" + quote + "MTWTFSS" + quote + ") which I need to split and hence create a list of days of week in strings (example: " + quote + "Monday" + quote + ", " + quote + "Tuesday" + quote + ", " + quote + "Wednesday" + quote + ", " + quote + "Thursday" + quote + ", " + quote + "Friday" + quote + ", " + quote + "Saturday" + quote + ", " + quote + "Sunday" + quote + @"). 
A set of code is given for this purpose but there is the error occurring in that set of code related to the conversion of char to strings. 
Hence, Select a C# code to solve the given error.";

            Console.WriteLine(opgave);

            Console.WriteLine(@"static void Main(string[] args)
    {

        var days = " + quote + @"MTWTFSS" + quote + @";
        var daysArray = days.ToCharArray().Cast<string>().ToArray();

            for (var i = 0; i < daysArray.Length; i++)
            {
                switch (daysArray[i])
                {
                    case " + quote + @"M" + quote + @":
                        daysArray[i] = " + quote + @"Monday" + quote + @";
                        break;
                    case " + quote + @"T" + quote + @":
                        daysArray[i] = " + quote + @"Tuesday" + quote + @";
                        break;
                    case " + quote + @"W" + quote + @":
                        daysArray[i] = " + quote + @"Wednesday" + quote + @";
                        break;
                    case " + quote + @"R" + quote + @":
                        daysArray[i] = " + quote + @"Thursday" + quote + @";
                        break;
                    case " + quote + @"F" + quote + @":
                        daysArray[i] = " + quote + @"Friday" + quote + @";
                        break;
                    case " + quote + @"S" + quote + @":
                        daysArray[i] = " + quote + @"Saturday" + quote + @";
                        break;
                    case " + quote + @"U" + quote + @":
                        daysArray[i] = " + quote + @"Sunday" + quote + @";
                        break;
                }
            }

            daysArray[daysArray.Length - 1] = " + quote + @"and " + quote + @" + daysArray[daysArray.Length - 1];
            Console.WriteLine(string.Join(" + quote + @", " + quote + @", daysArray));
        }");

            Console.WriteLine(@"a) var daysArray = new List<String>();
b) var daysArray = days.Select(c =>dayMapping[c]).ToArray();
c) var daysArray = days.ToCharArray().Select(c =>c.Tostring()).ToArray();
d) var daysArray = days.Select<String>();");


            Console.WriteLine("Uw antwoord: ");
            string antwoord3 = Console.ReadLine();
            switch (antwoord3.ToLower())
            {
                case "a":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "b":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "c":
                    Console.WriteLine("Correct!");
                    score += 2;
                    break;
                case "d":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                default:
                    Console.WriteLine("Dit antwoord behoort niet tot de mogelijkheden.");
                    score += -1;
                    break;
            }

            Console.WriteLine(@"Answer: c
Explanation: The problem arises due to cast conversion from “char” to “string” as one is not inherited from others. So, quick way of conversion is just using Char.ToString().");

            minimumScore--;
            maximumScore += 2;

            Console.WriteLine(Environment.NewLine + "Press the enter key voor volgende vraag.");
            string temp = Console.ReadLine();
            Console.Clear();
        }


        static void Vraag24(ref int score, ref int minimumScore, ref int maximumScore)
        {
            Console.WriteLine("Vraag 24:");

            string opgave = @"What will be the output of the following C# code?";

            Console.WriteLine(opgave);

            // Kris: Waarschijnlijk een haakje te veel.

            Console.WriteLine(@"    static void Main(string[] args)
    {
        { 
            var dayCode = " + quote + @"MTWFS" + quote + @";
            var daysArray = new List<string>();
            var list = new Dictionary<string, string>
            { {" + quote + @"M" + quote + @", " + quote + @"Monday" + quote + @"}, {" + quote + @"T" + quote + @", " + quote + @"Tuesday" + quote + @"}, {" + quote + @"W" + quote + @", " + quote + @"Wednesday" + quote + @"},
              {" + quote + @"R" + quote + @", " + quote + @"Thursday" + quote + @"}, {" + quote + @"F" + quote + @", " + quote + @"Friday" + quote + @"}, {" + quote + @"S" + quote + @", " + quote + @"Saturday" + quote + @"},
              {" + quote + @"U" + quote + @", " + quote + @"Sunday" + quote + @"}
            };

            for (int i = 0, max = dayCode.Length; i < max; i++)
            {
                var tmp = dayCode[i].ToString();

                if (list.ContainsKey(tmp))
                {
                    daysArray.Add(list[tmp]);
                }
            }

            Console.WriteLine(string.Join(" + quote + @"\n " + quote + @", daysArray));
        }");

            Console.WriteLine(@"a) Monday, Tuesday, Wednesday, Friday, Saturday, Sunday
b)

Monday
Tuesday
Wednesday
Friday
Sunday

c)

Monday
Tuesday
Wednesday
Friday
Saturday

d) Monday, Tuesday, Wednesday, Friday, Saturday");

            Console.WriteLine("Uw antwoord: ");
            string antwoord3 = Console.ReadLine();
            switch (antwoord3.ToLower())
            {
                case "a":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "b":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "c":
                    Console.WriteLine("Correct!");
                    score += 2;
                    break;
                case "d":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                default:
                    Console.WriteLine("Dit antwoord behoort niet tot de mogelijkheden.");
                    score += -1;
                    break;
            }

            minimumScore--;
            maximumScore += 2;

            Console.WriteLine(Environment.NewLine + "Press the enter key voor volgende vraag.");
            string temp = Console.ReadLine();
            Console.Clear();
        }


        static void Vraag25(ref int score, ref int minimumScore, ref int maximumScore)
        {
            Console.WriteLine("Vraag 25:");

            string opgave = @"Select the correct differences between char and varchar data types?
i. varchar is non unicode and char is unicode character data type
ii. char is ‘n’ bytes whereas varchar is actual length in bytes of data entered in terms of storage size
iii. varchar is variable in length and char is the fixed length string
iv. For varchar, if a string is less than the maximum length then it is stored in verbatim without any extra characters while for char if a string is less than the set length it is padded with extra characters to equalize its length to given length
a) i, iii, iv
b) ii, iii, iv
c) i, ii, iv
d) iii, iv";

            Console.WriteLine(opgave);

            Console.WriteLine("Uw antwoord: ");
            string antwoord3 = Console.ReadLine();
            switch (antwoord3.ToLower())
            {
                case "a":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "b":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "c":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "d":
                    Console.WriteLine("Correct!");
                    score += 2;
                    break;
                default:
                    Console.WriteLine("Dit antwoord behoort niet tot de mogelijkheden.");
                    score += -1;
                    break;
            }


            minimumScore--;
            maximumScore += 2;

            Console.WriteLine(Environment.NewLine + "Press the enter key voor volgende vraag.");
            string temp = Console.ReadLine();
            Console.Clear();
        }


        static void Vraag26(ref int score, ref int minimumScore, ref int maximumScore)
        {
            Console.WriteLine("Vraag 26:");
            // https://www.sanfoundry.com/csharp-mcqs-char-types-string-literals/
            string opgave = @"Which is the String method used to compare two strings with each other?
a) Compare To()
b) Compare()
c) Copy()
d) ConCat()";

            Console.WriteLine(opgave);

            Console.WriteLine("Uw antwoord: ");
            string antwoord3 = Console.ReadLine();
            switch (antwoord3.ToLower())
            {
                case "a":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "b":
                    Console.WriteLine("Correct!");
                    score += 2;
                    break;
                case "c":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "d":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                default:
                    Console.WriteLine("Dit antwoord behoort niet tot de mogelijkheden.");
                    score += -1;
                    break;
            }
            Console.WriteLine(@"Answer: b
Explanation: Compare() used to compare two strings by taking the length of strings in considerations.");

            minimumScore--;
            maximumScore += 2;

            Console.WriteLine(Environment.NewLine + "Press the enter key voor volgende vraag.");
            string temp = Console.ReadLine();
            Console.Clear();
        }


        static void Vraag27(ref int score, ref int minimumScore, ref int maximumScore)
        {
            Console.WriteLine("Vraag 27:");

            string opgave = @"What will be the output of the following C# code?

    static void Main(string[] args)
    {
        string s1 = " + quote + @"Delhi" + quote + @";
        string s2;
            s2 = s1.Insert(6, " + quote + @"Jaipur" + quote + @");
            Console.WriteLine(s2);
        }";

            Console.WriteLine(opgave);
            Console.WriteLine(@"a) DelhJaipuri
b) Delhi Jaipur
c) Delhi
d) DelhiJaipur");

            Console.WriteLine("Uw antwoord: ");
            string antwoord3 = Console.ReadLine();
            switch (antwoord3.ToLower())
            {
                case "a":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "b":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "c":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "d":
                    Console.WriteLine("Correct!");
                    score += 2;
                    break;
                default:
                    Console.WriteLine("Dit antwoord behoort niet tot de mogelijkheden.");
                    score += -1;
                    break;
            }

            Console.WriteLine(@"Answer: d
Explanation: Insert method() of string class used to join two strings s1 and s2.
Output :

DelhiJaipur");

            minimumScore--;
            maximumScore += 2;

            Console.WriteLine(Environment.NewLine + "Press the enter key voor volgende vraag.");
            string temp = Console.ReadLine();
            Console.Clear();
        }


        static void Vraag28(ref int score, ref int minimumScore, ref int maximumScore)
        {
            Console.WriteLine("Vraag 28:");

            string opgave = @" For two strings s1 and s2 to be equal, which is the correct way to find if the contents of two strings are equal?
a) if(s1 = s2)
b)

int c;
c = s1.CompareTo(s2);

c) if (s1 is s2)
d) if(strcmp(s1, s2))";

            Console.WriteLine(opgave);

            Console.WriteLine("Uw antwoord: ");
            string antwoord3 = Console.ReadLine();
            switch (antwoord3.ToLower())
            {
                case "a":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "b":
                    Console.WriteLine("Correct!");
                    score += 2;
                    break;
                case "c":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "d":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                default:
                    Console.WriteLine("Dit antwoord behoort niet tot de mogelijkheden.");
                    score += -1;
                    break;
            }


            minimumScore--;
            maximumScore += 2;

            Console.WriteLine(Environment.NewLine + "Press the enter key voor volgende vraag.");
            string temp = Console.ReadLine();
            Console.Clear();
        }


        static void Vraag29(ref int score, ref int minimumScore, ref int maximumScore)
        {
            Console.WriteLine("Vraag 29:");
            // https://www.sanfoundry.com/csharp-mcqs-char-types-string-literals/
            string opgave = @"What will be the output of the following C# code?

       string s1 = " + quote + @" I AM BEST " + quote + @";
       string s2;
            s2 = s1.Substring(5, 4);
            Console.WriteLine(s2);

            a) AM BEST
b) I AM BES
c) BEST
d) I AM";

            Console.WriteLine(opgave);

            Console.WriteLine("Uw antwoord: ");
            string antwoord3 = Console.ReadLine();
            switch (antwoord3.ToLower())
            {
                case "a":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "b":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "c":
                    Console.WriteLine("Correct!");
                    score += 2;
                    break;
                case "d":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                default:
                    Console.WriteLine("Dit antwoord behoort niet tot de mogelijkheden.");
                    score += -1;
                    break;
            }

            Console.WriteLine(@"Answer: c
Explanation: Substring() of string class used to extract substrings from given string. In the given substring condition, it extracts a substring beginning at 5th position and ending at 4th position.
Output:
 BEST");

            minimumScore--;
            maximumScore += 2;

            Console.WriteLine(Environment.NewLine + "Press the enter key voor volgende vraag.");
            string temp = Console.ReadLine();
            Console.Clear();
        }


        static void Vraag30(ref int score, ref int minimumScore, ref int maximumScore)
        {
            Console.WriteLine("Vraag 30:");

            string opgave = @"Correct statement about strings are?
a) a string is created on the stack
b) a string is primitive in nature
c) a string created on heap
d) created of string on a stack or on a heap depends on the length of the string";

            Console.WriteLine(opgave);

            Console.WriteLine("Uw antwoord: ");
            string antwoord30 = Console.ReadLine();
            switch (antwoord30.ToLower())
            {
                case "a":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "b":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "c":
                    Console.WriteLine("Correct!");
                    score += 2;
                    break;
                case "d":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                default:
                    Console.WriteLine("Dit antwoord behoort niet tot de mogelijkheden.");
                    score += -1;
                    break;
            }

            Console.WriteLine("Correct answer: c");

            minimumScore--;
            maximumScore += 2;

            Console.WriteLine(Environment.NewLine + "Press the enter key voor volgende vraag.");
            string temp = Console.ReadLine();
            Console.Clear();
        }


        static void Vraag31(ref int score, ref int minimumScore, ref int maximumScore)
        {
            Console.WriteLine("Vraag 31:");

            string opgave = @" Verbatim string literal is better used for?
a) Convenience and better readability of strings when string text consist of backlash characters
b) Used to initialize multi-line strings
c) To embed a quotation mark by using double quotation marks inside a verbatim string
d) All of the mentioned";

            Console.WriteLine(opgave);

            Console.WriteLine("Uw antwoord: ");
            string antwoord3 = Console.ReadLine();
            switch (antwoord3.ToLower())
            {
                case "a":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "b":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "c":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "d":
                    Console.WriteLine("Correct!");
                    score += 2;
                    break;
                default:
                    Console.WriteLine("Dit antwoord behoort niet tot de mogelijkheden.");
                    score += -1;
                    break;
            }

            minimumScore--;
            maximumScore += 2;

            Console.WriteLine(Environment.NewLine + "Press the enter key voor volgende vraag.");
            string temp = Console.ReadLine();
            Console.Clear();
        }


        static void Vraag32(ref int score, ref int minimumScore, ref int maximumScore)
        {
            Console.WriteLine("Vraag 32:");

            string opgave = @" Why strings are of reference type in C#.NET?
a) To create string on stack
b) To reduce the size of string
c) To overcome problem of stackoverflow
d) None of the mentioned";

            Console.WriteLine(opgave);

            Console.WriteLine("Uw antwoord: ");
            string antwoord3 = Console.ReadLine();
            switch (antwoord3.ToLower())
            {
                case "a":
                    Console.WriteLine("Correct!");
                    score += -1;
                    break;
                case "b":
                    Console.WriteLine("Correct!");
                    score += 2;
                    break;
                case "c":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "d":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                default:
                    Console.WriteLine("Dit antwoord behoort niet tot de mogelijkheden.");
                    score += -1;
                    break;
            }

            Console.WriteLine(@"Correct answer: b
Explanation: The problem of stack overflow very likely to occur since transport protocol used on web these days are ‘HTTP’ and data standard as ‘XML’. 
Hence, both make use of strings extensively which will result in stack overflow problem. 
So, to avoid this situation it is good idea to make strings a reference type and hence create it on heap.");

            minimumScore--;
            maximumScore += 2;

            Console.WriteLine(Environment.NewLine + "Press the enter key voor volgende vraag.");
            string temp = Console.ReadLine();
            Console.Clear();
        }



        static void Vraag33(ref int score, ref int minimumScore, ref int maximumScore)
        {
            Console.WriteLine("Vraag 33:");

            string opgave = @"Storage location used by computer memory to store data for usage by an application is?
a) Pointers
b) Constants
c) Variable
d) None of the mentioned";

            Console.WriteLine(opgave);

            Console.WriteLine("Uw antwoord: ");
            string antwoord3 = Console.ReadLine();
            switch (antwoord3.ToLower())
            {
                case "a":
                    Console.WriteLine("FOUT !");
                    score += 2;
                    break;
                case "b":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "c":
                    Console.WriteLine("Correct!");
                    score += 2;
                    break;
                case "d":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                default:
                    Console.WriteLine("Dit antwoord behoort niet tot de mogelijkheden.");
                    score += -1;
                    break;
            }

            Console.WriteLine(@"Correct answer: c
Explanation: ‘Variables’ are essential locations in memory of computer that are reserved for storing data used by an application. 
Each variable is given a name by programmer and hence assigned a value. 
The name assigned to variable then used in C# code to access value assigned to variable.");

            minimumScore--;
            maximumScore += 2;

            Console.WriteLine(Environment.NewLine + "Press the enter key voor volgende vraag.");
            string temp = Console.ReadLine();
            Console.Clear();
        }


        static void Vraag34(ref int score, ref int minimumScore, ref int maximumScore)
        {
            Console.WriteLine("Vraag 34:");

            string opgave = @"DIFFERENCE BETWEEN KEYWORDS ‘VAR’ AND ‘DYNAMIC’?
a) ‘Var’ is introduced in C# (3.0) and ‘Dynamic’ is introduced in C# (4.0)
b) ‘Var’ is a type of variable where declaration is done at compile time by compiler while ‘Dynamic’ declaration is achieved at runtime by compiler
c) For ‘Var’ Error is caught at compile time and for ‘Dynamic’ Error is caught at runtime
d) All of the mentioned";

            Console.WriteLine(opgave);

            Console.WriteLine("Uw antwoord: ");
            string antwoord3 = Console.ReadLine();
            switch (antwoord3.ToLower())
            {
                case "a":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "b":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "c":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "d":
                    Console.WriteLine("Correct!");
                    score += 2;
                    break;
                default:
                    Console.WriteLine("Dit antwoord behoort niet tot de mogelijkheden.");
                    score += -1;
                    break;
            }

            minimumScore--;
            maximumScore += 2;

            Console.WriteLine(Environment.NewLine + "Press the enter key voor volgende vraag.");
            string temp = Console.ReadLine();
            Console.Clear();
        }


        static void Vraag35(ref int score, ref int minimumScore, ref int maximumScore)
        {
            Console.WriteLine("Vraag 35:");

            string opgave = @"Scope of variable is related to definition of variable as:
i. Region of code within which variable value is valid and hence can be accessed.
ii. No, relation with region where variable is declared its value is valid in entire scope.
a) i
b) ii
c) i, ii
d) None of the mentioned";

            Console.WriteLine(opgave);

            Console.WriteLine("Uw antwoord: ");
            string antwoord3 = Console.ReadLine();
            switch (antwoord3.ToLower())
            {
                case "a":
                    Console.WriteLine("Correct!");
                    score += 2;
                    break;
                case "b":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "c":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "d":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                default:
                    Console.WriteLine("Dit antwoord behoort niet tot de mogelijkheden.");
                    score += -1;
                    break;
            }

            Console.WriteLine(@"Correct answer: a
Explanation: Scope of variable is the area or region within which variable is declared and hence initialized values of different kind. 
Based, on which operations of different kinds are carried out on that variable declared within that scope. 
Its value is preserved until and unless scope of that block ({ }) is not expired because as soon as scope gets over. 
Hence, variable value gets expired. 
Hence, it’s inaccessible after it.");

            minimumScore--;
            maximumScore += 2;

            Console.WriteLine(Environment.NewLine + "Press the enter key voor volgende vraag.");
            string temp = Console.ReadLine();
            Console.Clear();
        }


        static void Vraag36(ref int score, ref int minimumScore, ref int maximumScore)
        {
            Console.WriteLine("Vraag 36:");

            string opgave = @"Syntax for declaration and initialization of data variable is?
a) <data type><var_name> = <Value>;
b) <data type><var_name>;
c) <var_name><data type>;
d) <var_name> = <value>;";

            Console.WriteLine(opgave);

            Console.WriteLine("Uw antwoord: ");
            string antwoord3 = Console.ReadLine();
            switch (antwoord3.ToLower())
            {
                case "a":
                    Console.WriteLine("Correct!");
                    score += 2;
                    break;
                case "b":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "c":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "d":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                default:
                    Console.WriteLine("Dit antwoord behoort niet tot de mogelijkheden.");
                    score += -1;
                    break;
            }

            minimumScore--;
            maximumScore += 2;

            Console.WriteLine(Environment.NewLine + "Press the enter key voor volgende vraag.");
            string temp = Console.ReadLine();
            Console.Clear();
        }


        static void Vraag37(ref int score, ref int minimumScore, ref int maximumScore)
        {
            Console.WriteLine("Vraag 37:");

            string opgave = @"Choose effective differences between ‘Boxing’ and ‘Unboxing’.
a) ‘Boxing’ is the process of converting a value type to the reference type and ‘Unboxing’ is the process of converting reference to value type
b) ‘Boxing’ is the process of converting a reference type to value type and ‘Unboxing’ is the process of converting value type to reference type
c) In ‘Boxing’ we need explicit conversion and in ‘Unboxing’ we need implicit conversion
d) Both ‘Boxing’ and ‘Unboxing’ we need implicit conversion";

            Console.WriteLine(opgave);

            Console.WriteLine("Uw antwoord: ");
            string antwoord3 = Console.ReadLine();
            switch (antwoord3.ToLower())
            {
                case "a":
                    Console.WriteLine("Correct!");
                    score += 2;
                    break;
                case "b":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "c":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "d":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                default:
                    Console.WriteLine("Dit antwoord behoort niet tot de mogelijkheden.");
                    score += -1;
                    break;
            }

            minimumScore--;
            maximumScore += 2;

            Console.WriteLine(Environment.NewLine + "Press the enter key voor volgende vraag.");
            string temp = Console.ReadLine();
            Console.Clear();
        }


        static void Vraag38(ref int score, ref int minimumScore, ref int maximumScore)
        {
            Console.WriteLine("Vraag 38:");

            string opgave = @"Select differences between reference type and value type:
i. Memory allocated to ‘Value type’ is from heap and reference type is from ‘System. ValueType’
ii. Memory allocated to ‘Value type’ is from ‘System. ValueType’ and reference type is from ‘Heap’
iii. Structures, enumerated types derived from ‘System. ValueType’ are created on stack, hence known as ValueType and all ‘classes’ are reference type because values are stored on heap
a) i, iii
b) ii, iii
c) i, ii, iii
d) i";

            Console.WriteLine(opgave);

            Console.WriteLine("Uw antwoord: ");
            string antwoord3 = Console.ReadLine();
            switch (antwoord3.ToLower())
            {
                case "a":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "b":
                    Console.WriteLine("Correct!");
                    score += 2;
                    break;
                case "c":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "d":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                default:
                    Console.WriteLine("Dit antwoord behoort niet tot de mogelijkheden.");
                    score += -1;
                    break;
            }

            minimumScore--;
            maximumScore += 2;

            Console.WriteLine(Environment.NewLine + "Press the enter key voor volgende vraag.");
            string temp = Console.ReadLine();
            Console.Clear();
        }


        static void Vraag39(ref int score, ref int minimumScore, ref int maximumScore)
        {
            Console.WriteLine("Vraag 39:");

            string opgave = @"What will be the output of the following C# code?

        public static void Main(string[] args)
        {
            int i = 123;
            object o = i;
            i = 456;
            System. Console. WriteLine(" + quote + @"The value-type value = {0}" + quote + @", i);
            System.Console.WriteLine(" + quote + @"The object-type value = {0}" + quote + @", o);
            Console.ReadLine();
        }

        a) 123, 123
b) 456, 123
c) 456, 456
d) 123, 456";

            Console.WriteLine(opgave);

            Console.WriteLine("Uw antwoord: ");
            string antwoord3 = Console.ReadLine();
            switch (antwoord3.ToLower())
            {
                case "a":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "b":
                    Console.WriteLine("Correct!");
                    score += 2;
                    break;
                case "c":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "d":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                default:
                    Console.WriteLine("Dit antwoord behoort niet tot de mogelijkheden.");
                    score += -1;
                    break;
            }

            Console.WriteLine(@"Correct answer: b
Explanation: The concept of boxing is implemented here. 
The variable ‘i’ of ‘int’ type is boxed using variable ‘o’ of object type and hence value is stored inside it and is initialized to the object variable ‘o’. 
Next, variable ‘i’ is again initialized with some value overriding it’s previous stored value.
Output:
            456, 123");

            minimumScore--;
            maximumScore += 2;

            Console.WriteLine(Environment.NewLine + "Press the enter key voor volgende vraag.");
            string temp = Console.ReadLine();
            Console.Clear();
        }


        static void Vraag40(ref int score, ref int minimumScore, ref int maximumScore)
        {
            Console.WriteLine("Vraag 40:");

            string opgave = @"What will be the output of the following C# code?

      public static void Main(string[] args)
      {
          int i = 546;
          object o = i;
          int n =(int) o;
          o = 70;
          System. Console. WriteLine(" + quote + @"The value-type value = {0}" + quote + @", n);
          System.Console.WriteLine(" + quote + @"The object-type value = {0}" + quote + @", o);
            Console.ReadLine();
        }

        a) 546, 0
b) 546, 546
c) 546, 70
d) 70, 546";

            Console.WriteLine(opgave);

            Console.WriteLine("Uw antwoord: ");
            string antwoord3 = Console.ReadLine();
            switch (antwoord3.ToLower())
            {
                case "a":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "b":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "c":
                    Console.WriteLine("Correct!");
                    score += 2;
                    break;
                case "d":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                default:
                    Console.WriteLine("Dit antwoord behoort niet tot de mogelijkheden.");
                    score += -1;
                    break;
            }

            Console.WriteLine(@"Correct answer: c
Explanation: The concept of ‘unboxing’ is implemented here. 
To ‘unbox’ an object back to value type, we have to do it explicitly as “int n = (int) o”.
Output:
546, 70");

            minimumScore--;
            maximumScore += 2;

            Console.WriteLine(Environment.NewLine + "Press the enter key voor volgende vraag.");
            string temp = Console.ReadLine();
            Console.Clear();
        }


        static void Vraag41(ref int score, ref int minimumScore, ref int maximumScore)
        {
            Console.WriteLine("Vraag 41:");

            string opgave = @"What is the need for ‘Conversion of data type’ in C#?
a) To store a value of one data type into a variable of another data type
b) To get desired data
c) To prevent situations of runtime error during change or conversion of data type
d) None of the mentioned";

            Console.WriteLine(opgave);

            Console.WriteLine("Uw antwoord: ");
            string antwoord3 = Console.ReadLine();
            switch (antwoord3.ToLower())
            {
                case "a":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "b":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "c":
                    Console.WriteLine("Correct!");
                    score += 2;
                    break;
                case "d":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                default:
                    Console.WriteLine("Dit antwoord behoort niet tot de mogelijkheden.");
                    score += -1;
                    break;
            }

            minimumScore--;
            maximumScore += 2;

            Console.WriteLine(Environment.NewLine + "Press the enter key voor volgende vraag.");
            string temp = Console.ReadLine();
            Console.Clear();
        }


        static void Vraag42(ref int score, ref int minimumScore, ref int maximumScore)
        {
            Console.WriteLine("Vraag 42:");
            // https://www.sanfoundry.com/csharp-questions-answers-mcqs/
            string opgave = @"Types of ‘Data Conversion’ in C#?
a) Implicit Conversion
b) Explicit Conversion
c) Implicit Conversion and Explicit Conversion
d) None of the mentioned";

            Console.WriteLine(opgave);

            Console.WriteLine("Uw antwoord: ");
            string antwoord3 = Console.ReadLine();
            switch (antwoord3.ToLower())
            {
                case "a":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "b":
                    Console.WriteLine("Correct!");
                    score += 2;
                    break;
                case "c":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "d":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                default:
                    Console.WriteLine("Dit antwoord behoort niet tot de mogelijkheden.");
                    score += -1;
                    break;
            }

            minimumScore--;
            maximumScore += 2;

            Console.WriteLine(Environment.NewLine + "Press the enter key voor volgende vraag.");
            string temp = Console.ReadLine();
            Console.Clear();
        }


        static void Vraag43(ref int score, ref int minimumScore, ref int maximumScore)
        {
            Console.WriteLine("Vraag 43:");
            // https://www.sanfoundry.com/csharp-questions-answers-mcqs/
            string opgave = @"‘Implicit Conversion’ follows the order of conversion as per compatibility of data type as:
a) float < char < int
b) char < int < float
c) int < char < float
d) float < int < char";

            Console.WriteLine(opgave);

            Console.WriteLine("Uw antwoord: ");
            string antwoord3 = Console.ReadLine();
            switch (antwoord3.ToLower())
            {
                case "a":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "b":
                    Console.WriteLine("Correct!");
                    score += 2;
                    break;
                case "c":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                case "d":
                    Console.WriteLine("FOUT !");
                    score += -1;
                    break;
                default:
                    Console.WriteLine("Dit antwoord behoort niet tot de mogelijkheden.");
                    score += -1;
                    break;
            }

            minimumScore--;
            maximumScore += 2;

            Console.WriteLine(Environment.NewLine + "Press the enter key voor volgende vraag.");
            string temp = Console.ReadLine();
            Console.Clear();
        }
    }
}
