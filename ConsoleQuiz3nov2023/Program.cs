namespace ConsoleQuiz3nov2023
{
    class Program11Jul2020
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hier testen we de Quiz vragen:");

            #region Vraag 1
            {
                Console.WriteLine("Vraag 1");
                int movie = 1;

                switch (movie << 2 + movie)
                {
                    default:
                        Console.WriteLine("3 Idiots");
                        break;
                    case 4:
                        Console.WriteLine("Ghazini");
                        break;
                    case 5:
                        Console.WriteLine("Krishh");
                        break;
                    case 8:
                        Console.WriteLine("Race");
                        break;
                }
            }
            #endregion


            #region Vraag 2
            {
                Console.WriteLine("Vraag 2");
                byte varA = 10;
                byte varB = 20;
                long result = varA & varB;

                Console.WriteLine("{0} AND {1} Result: {2} ", varA, varB, result);

                varA = 10;
                varB = 10;
                result = varA & varB;

                Console.WriteLine("{0} AND {1} Result: {2} ", varA, varB, result);
            }
            #endregion


            #region Vraag 8
            {
                Console.WriteLine("Vraag 8");
                int a = 12;
                float b = (float)3.5; // Zonder cast geeft dit een fout, want 3.5 is een double.
                int c;

                //c = a + b; // Dit is verkeerd.
                //Console.WriteLine(float(b)); // Dit is verkeerd.
                Console.WriteLine((float)(b));
                c = a + (int)((float)(b)); // Dit werkt wel. Haakjes rond float en int.
                                           //c = a + int(float(b)); // Dit is verkeerd.
                c = a + Convert.ToInt32(b); // convert was met een kleine c geschreven.
                                            //c = int(a + b); // Dit werkt niet.
                c = (int)(a + b); // Met haakjes rond de int werkt het wel.
            }
            #endregion


            #region Vraag 9
            {
                Console.WriteLine("Vraag 9");

                #region 9 a
                {
                    //int a = 12;
                    //float b = 6.2f;
                    //int c;
                    //c = a / b + a * b; // cannot implicitly convert float to int
                    //Console.WriteLine(c);
                }
                #endregion

                #region 9 b
                {
                    //int a = 12;
                    //float b = 6.2f;
                    //int c;
                    //c = a / Convert.ToInt32(b) + a * b; // cannot implicitly convert float to int
                    //Console.WriteLine(c);
                }
                #endregion

                #region 9 c
                {
                    Console.WriteLine("Antwoord 9 c");
                    int a = 12;
                    float b = 6.2f;
                    int c;
                    c = a / Convert.ToInt32(b) + a * Convert.ToInt32(b);
                    Console.WriteLine(c); // 74
                }
                #endregion

                #region 9 d
                {
                    Console.WriteLine("Antwoord 9 d");
                    int a = 12;
                    float b = 6.2f;
                    int c;
                    c = Convert.ToInt32(a / b + a * b);
                    Console.WriteLine(c); // 76
                }
                #endregion
            }
            #endregion


            #region Vraag 10
            {
                Console.WriteLine("Vraag 10");

                #region 10 a
                {
                    Console.WriteLine("Antwoord 10 a");
                    char l = 'k';
                    float b = 19.0f;
                    int c;
                    c = (l / Convert.ToInt32(b));
                    Console.WriteLine(c); // 5
                }
                #endregion

                #region 10 b
                {
                    Console.WriteLine("Antwoord 10 b");
                    char l = 'k';
                    float b = 19.0f;
                    int c;
                    c = Convert.ToInt32(l / b);
                    Console.WriteLine(c); // 6
                }
                #endregion

            }
            #endregion


            #region Vraag 12
            {
                Console.WriteLine("Vraag 12");

                float a = 10.553f;
                long b = 12L;
                int c;
                c = Convert.ToInt32(a + b);
                Console.WriteLine(c); // 23
            }
            #endregion


            #region Vraag 14
            {
                Console.WriteLine("Vraag 14");

                #region 14 a
                {
                    //float a = (double)12.502f; // cannot implicitly convert type double to float
                    //float b = 12.80f;
                    //float c;
                    //c = (float)a + b;
                    //Console.WriteLine(c);
                    //Console.ReadLine();
                }
                #endregion
                #region 14 b
                {
                    //float a = 12.502D; // literal of type double cannot be implicitly converted to float
                    //float b = 12.80f;
                    //float c;
                    //c = a + b;
                    //Console.WriteLine(c);
                    //Console.ReadLine();
                }
                #endregion
                #region 14 c
                {
                    double a = 12.502;
                    float b = 12.802f;
                    float c;
                    c = (float)a + b;
                    Console.WriteLine(c);
                    // 25,304 // Dus nee er komt niet 25.302 uit, zoals gevraagd in vraag 14.
                    //Console.ReadLine();
                }
                #endregion
                #region 14 d
                {
                    //double a = (float)12.502f;
                    //float b = 12.80f;
                    //float c;
                    //c = a + b; // cannot implicitly convert type double to float
                    //Console.WriteLine(c);
                    //Console.ReadLine();
                }
                #endregion
            }
            #endregion


            #region Vraag 16
            {
                //Console.WriteLine("Vraag 16");
                //float a = 0;
                //while (true)
                //{
                //    a++;
                //    if (a > 16777216)
                //        break;
                //}
            }
            #endregion


            #region Vraag 17
            {
                Console.WriteLine("Vraag 17");
                int x = 1;
                float y = 2.4f;
                short z = 1;
                Console.WriteLine((float)x + y * z - (x += (short)y)); // 0,4000001
                //Console.ReadLine();

            }
            #endregion


            #region Vraag 19
            {
                Console.WriteLine("Vraag 19");
                double ZERO = 0;
                Console.WriteLine("RESULT OF DIVISION BY ZERO IS :{0}", (0 / ZERO)); // RESULT OF DIVISION BY ZERO IS :NaN (Niet-een-getal)
                //Console.ReadLine();
            }
            #endregion


            #region Vraag 22
            {
                Console.WriteLine("Vraag 22");
                char c = 'g';
                string s = c.ToString();
                string s1 = "I am a human being" + c;
                Console.WriteLine(s1); // I am a human beingg
                //Console.ReadLine();
            }
            #endregion


            #region Vraag 23
            {
                Console.WriteLine("Vraag 23");
                var days = "MTWTFSS";
                //var daysArray = days.ToCharArray().Cast<string>().ToArray();
                // Cast kent VS niet. 
                // Met LINQ bestaat Cast wel.
                // Exception: Unable to cast char to string.

                //var daysArray = new List<String>(); 
                // compileert. Maar daysArray heeft geen Length. 
                // optie a

                //var daysArray = days.Select(c => dayMapping[c]).ToArray(); 
                // string does not contain a definition for Select 
                // optie b
                // Met LINQ bestaat Select wel, maar dayMapping niet.

                var daysArray = days.ToCharArray().Select(c => c.ToString()).ToArray();
                // char[] does not contain a definition for Select 
                // optie c
                // levert als output: Monday, Tuesday, Wednesday, Tuesday, Friday, Saturday, and Saturday

                //var daysArray = days.Select<String>();
                // string does not contain a definition for Select 
                // optie d
                // Met LINQ is er nog steeds geen functie Select<string> op string.


                for (var i = 0; i < daysArray.Length; i++)
                {
                    switch (daysArray[i])
                    {
                        case "M":
                            daysArray[i] = "Monday";
                            break;
                        case "T":
                            daysArray[i] = "Tuesday";
                            break;
                        case "W":
                            daysArray[i] = "Wednesday";
                            break;
                        case "R":
                            daysArray[i] = "Thursday";
                            break;
                        case "F":
                            daysArray[i] = "Friday";
                            break;
                        case "S":
                            daysArray[i] = "Saturday";
                            break;
                        case "U":
                            daysArray[i] = "Sunday";
                            break;
                    }
                }

                daysArray[daysArray.Length - 1] = "and " + daysArray[daysArray.Length - 1];

                Console.WriteLine(string.Join(", ", daysArray));

            }
            #endregion


            #region Vraag 24
            {
                Console.WriteLine("Vraag 24");

                var dayCode = "MTWFS";

                var daysArray = new List<string>();

                var list = new Dictionary<string, string>
        { {"M", "Monday"}, {"T", "Tuesday"}, {"W", "Wednesday"},
          {"R", "Thursday"}, {"F", "Friday"}, {"S", "Saturday"},
          {"U", "Sunday"}
        };

                for (int i = 0, max = dayCode.Length; i < max; i++)
                {
                    var tmp = dayCode[i].ToString();

                    if (list.ContainsKey(tmp))
                    {
                        daysArray.Add(list[tmp]);
                    }
                }

                Console.WriteLine(string.Join("\n ", daysArray));
                /*Monday
                 Tuesday
                 Wednesday
                 Friday
                 Saturday*/
            }
            #endregion


            #region Vraag 27
            {
                Console.WriteLine("Vraag 27");
                string s1 = "Delhi";
                string s2;
                //s2 = s1.Insert(6, "Jaipur"); // Exception: Specified argument was out of the range of valid values.
                s2 = s1.Insert(5, "Jaipur");

                Console.WriteLine(s2);
                // De bedoelde output is DelhiJaipur
            }
            #endregion


            #region Vraag 29
            {
                Console.WriteLine("Vraag 29");
                string s1 = " I AM BEST ";
                string s2;
                s2 = s1.Substring(5, 4);
                Console.WriteLine(s2); // BES
                // De bedoelde output is BEST
                string s3 = "I AM BEST";
                string s4;
                s4 = s3.Substring(5, 4);
                Console.WriteLine(s4); // BEST
            }
            #endregion


            #region Vraag 39
            {
                Console.WriteLine("Vraag 39");
                int i = 123;
                object o = i;
                i = 456;
                System.Console.WriteLine("The value-type value = {0}", i);
                System.Console.WriteLine("The object-type value = {0}", o);
                // The value-type value = 456
                // The object-type value = 123
            }
            #endregion


            #region Vraag 40
            {
                Console.WriteLine("Vraag 40");
                int i = 546;
                object o = i;
                int n = (int)o;
                o = 70;
                System.Console.WriteLine("The value-type value = {0}", n);
                System.Console.WriteLine("The object-type value = {0}", o);
                // The value-type value = 546
                // The object-type value = 70
            }
            #endregion


            Console.ReadLine();
        }

    }
}
