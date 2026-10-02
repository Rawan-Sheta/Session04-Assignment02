namespace Session04_Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
                // Assignment02
                #region Q01
                //Console.Write("Enter a number: ");
                //int number = int.Parse(Console.ReadLine());
                //if (number % 3 == 0 && number % 4 == 0)
                //    Console.WriteLine("Yes");
                //else
                //    Console.WriteLine("No");
                #endregion

                #region Q02
                /* 2- Write a program that allows the user to insert an integer then print
                    negative if it is negative number otherwise print positive.
                   Example (1) Input: -5  Output: negative
                  Example (2) Input: 10  Output: positive */

                //int number = int.Parse(Console.ReadLine());
                //if (number < 0)
                //    Console.WriteLine("negative");
                //else
                //    Console.WriteLine("positive");
                #endregion

                #region Q03
                /* 3 - Write a program that takes 3 integers from the user then prints the
                    max element and the min element.
                    Example (1) Input: 7,8,5   Output: max element = 8, min element = 5
                    Example (2) Input: 3 6 9   Output: Max element = 9, Min element = 3 */
                //int a = int.Parse(Console.ReadLine());
                //int b = int.Parse(Console.ReadLine());
                //int c = int.Parse(Console.ReadLine());

                //int max = a;
                //if (b > max)
                //    max = b;
                //if (c > max)
                //    max = c;

                //int min = a;
                //if (b < min)
                //    min = b;
                //if (c < min)
                //    min = c;

                //Console.WriteLine($"max element = {max}");
                //Console.WriteLine($"min element = {min}");

                #endregion

                #region Q04
                // 4- Write a program that allows the user to insert an integer number then check If a number is even or odd.
                //int number = int.Parse(Console.ReadLine());

                //if (number % 2 == 0)
                //    Console.WriteLine("Number isEven");
                //else
                //    Console.WriteLine("Number is Odd");
                #endregion

                #region Q05
                /* 5- Write a program that takes character from the user then if it is a
                    vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
                    Example (1) Input: O  Output: vowel
                    Example (2) Input: b  Output: Consonant*/

                //Console.Write("Enter a character: ");
                //string input = Console.ReadLine() ?? "";

                //if (input.Length == 0)
                //{
                //    Console.WriteLine("You did not enter anything.");
                //    return;
                //}

                //char c = char.ToLower(input[0]); 

                //if (!char.IsLetter(c))
                //    Console.WriteLine("This is not a letter.");
                //else if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                //    Console.WriteLine("vowel");
                //else
                //    Console.WriteLine("consonant");
                #endregion

                #region Q06
                /* 6- Write a program that allows the user to insert an integer then print
                    all numbers between 1 to that number.
                    Example: Input: 5  Output: 1, 2, 3, 4, 5 */

                //Console.Write("Enter the end number: ");
                // int n = int.Parse(Console.ReadLine());

                // for (int i = 1; i <= n; i++)
                // {
                //     Console.Write(i);
                //     if (i < n) Console.Write(", ");
                // }
                // Console.WriteLine();
                #endregion

                #region Q07
                /* 7- Write a program that allows the user to insert an integer then
                    print a multiplication table up to 12.
                    Example: Input: 5  Output: 5 10 15 20 25 30 35 40 45 50 55 60 */

                //Console.Write("Enter an integer: ");
                // int number = int.Parse(Console.ReadLine());
                // for (int i = 1; i <= 12; i++)
                // {
                //     Console.Write(number * i + " ");
                // }
                // Console.WriteLine();
                #endregion

                #region Q08

                /* 8- Write a program that allows to user to insert number then print all
                    even numbers between 1 to this number
                    Example: Input: 15  Output: 2 4 6 8 10 12 14 */


                //Console.Write("Enter an integer: ");
                //int number = int.Parse(Console.ReadLine());
                //for (int i = 2; i <= number; i += 2) // start at 2 and jump by 2
                //{
                //    Console.Write(i + " ");
                //}
                //Console.WriteLine();
                #endregion

                #region Q09
                /*
                  b9- Write a program that takes two integers then prints the power.
                   Example: Input: 4 3  Output: 64
                   Hint: how to calculate 4^3 = 4 * 4 * 4 = 64 */

                //Console.Write("Enter the base: ");
                //int baseNumber = int.Parse(Console.ReadLine());
                //Console.Write("Enter the exponent: ");
                //int  exponent = int.Parse(Console.ReadLine());

                //    if (exponent < 0)
                //    {
                //        Console.WriteLine("This program supports exponents of 0 or more only.");
                //        return;
                //    }

                //    long result = 1; 
                //    for (int i = 1; i <= exponent; i++)
                //    {
                //        result *= baseNumber;
                //    }

                //    Console.WriteLine($"{baseNumber}^{exponent} = {result}");

                #endregion

                #region Q10
                /*
                    10- Write a program to enter marks of five subjects and calculate total,
                      average and percentage.
                      Example: Input: Enter Marks of five subjects: 95 76 58 90 89
                      Output: Total marks = 408, Average Marks = 81, Percentage = 81
                  */
                //        double total = 0;

                //        for (int i = 1; i <= 5; i++)
                //       {
                //    Console.Write($"Enter mark of subject {i}: ");
                //    total = double.Parse(Console.ReadLine());
                //    total += total;
                //}
                //        double average = total / 5;
                //        double percentage = (total / 500) * 100; 

                //        Console.WriteLine($"Total marks = {total}");
                //        Console.WriteLine($"Average Marks = {average:F2}");
                //        Console.WriteLine($"Percentage = {percentage:F2}%");
                #endregion

                #region Q11
                /* 11- Write a program to input the month number and print the number of days in that month.
                    Example: Input: Month Number: 1  Output: Days in Month: 31 */

                //Console.Write("Month Number: ");
                //int month = int.Parse(Console.ReadLine());
                //int days;
                //    switch (month)
                //    {
                //        case 1:
                //        case 3:
                //        case 5:
                //        case 7:
                //        case 8:
                //        case 10:
                //        case 12:
                //            days = 31;
                //            break;
                //        case 4:
                //        case 6:
                //        case 9:
                //        case 11:
                //            days = 30;
                //            break;
                //        case 2:
                //            days = 28; 
                //            break;
                //        default:
                //            Console.WriteLine("Invalid month number (1-12).");
                //            return;
                //    }

                //    Console.WriteLine($"Days in Month {month}: {days}");
                #endregion

                #region Q12

                // 12- Write a program to create a Simple Calculator

                //    Console.Write("Enter first number: ");
                //double x = double.Parse(Console.ReadLine());
                //Console.Write("Enter operator (+  -  *  /): ");
                //    string op = Console.ReadLine();
                //Console.Write("Enter second number: ");
                //double y = double.Parse(Console.ReadLine());

                //    switch (op)
                //    {
                //        case "+":
                //            Console.WriteLine($"{x} + {y} = {x + y}");
                //            break;
                //        case "-":
                //            Console.WriteLine($"{x} - {y} = {x - y}");
                //            break;
                //        case "*":
                //            Console.WriteLine($"{x} * {y} = {x * y}");
                //            break;
                //        case "/":
                //            if (y == 0)
                //                Console.WriteLine("Error: cannot divide by zero.");
                //            else
                //                Console.WriteLine($"{x} / {y} = {x / y}");
                //            break;
                //        default:
                //            Console.WriteLine("Invalid operator.");
                //            break;
                //    }

                #endregion

                #region Q13
                // 13- Write a program to allow the user to enter a string and print then REVERSE of it.

                //Console.Write("Enter a string: ");
                //string text = Console.ReadLine();

                //string reversed = "";
                //for (int i = text.Length - 1; i >= 0; i--)
                //{
                //    reversed += text[i];
                //}

                //Console.WriteLine("Reversed: " + reversed);

                #endregion

                #region Q14
                // 14- Write a program to allow the user to enter int and print the REVERSED of it.
                //Console.Write("Enter an integer: ");
                //int number = int.Parse(Console.ReadLine());
                //bool isNegative = number < 0;
                //long temp = Math.Abs((long)number); // long so int.MinValue does not overflow
                //long reversed = 0;

                //while (temp > 0)
                //{
                //    long lastDigit = temp % 10;          // take the last digit
                //    reversed = reversed * 10 + lastDigit; // append it to the result
                //    temp /= 10;                          // drop the last digit
                //}

                //if (isNegative) reversed = -reversed;

                //Console.WriteLine("Reversed: " + reversed);
                #endregion

                #region Q15
                /* 15- Write a program in C# Sharp to find prime numbers within a range of numbers.
                     Test Data:
                     Input starting number of range: 1
                     Input ending number of range : 50
                     Expected Output:
                      The prime number between 1 and 50 are :
                     2 3 5 7 11 13 17 19 23 29 31 37 41 43 47*/

                //    Console.Write("Input starting number of range: ");
                //    int start = int.Parse(Console.ReadLine());
                //    Console.Write("Input ending number of range : ");
                //    int end = int.Parse(Console.ReadLine());

                //    Console.WriteLine($"The prime number between {start} and {end} are :");
                //    for (int n = start; n <= end; n++)
                //    {
                //        if (IsPrime(n))
                //            Console.Write(n + " ");
                //    }
                //    Console.WriteLine();
                //}

                //// Returns true if n is prime.
                //static bool IsPrime(int n)
                //{
                //    if (n < 2) return false; 

                //    // It is enough to test divisors up to the square root of n
                //    for (int i = 2; i <= Math.Sqrt(n); i++)
                //    {
                //        if (n % i == 0) return false; // found a divisor -> not prime
                //    }
                //    return true;

                #endregion

                #region Q16
                /* 16- Write a program in C# Sharp to convert a decimal number into binary without using an array.
                     Test Data:
                     Enter a number to convert : 25
                     Expected Output:
                     The Binary of 25 is 11001.*/
                //Console.Write("Enter a number to convert : ");
                //int number = int.Parse(Console.ReadLine());
                // if (number < 0)
                // {
                //     Console.WriteLine("Please enter a non-negative number.");
                //     return;
                // }

                // int original = number;
                // string binary = "";

                // if (number == 0) binary = "0";

                // while (number > 0)
                // {
                //     binary = (number % 2) + binary; // put the new bit at the FRONT
                //     number /= 2;
                // }

                // Console.WriteLine($"The Binary of {original} is {binary}.");

                #endregion

                #region Q17
                /* 17- Create a program that asks the user to input three points (x1, y1),
                     (x2, y2), and (x3, y3), and determines whether these points lie on a
                    single straight line.*/

                //Console.Write("X1: ");
                //int x1 = int.Parse(Console.ReadLine());
                //Console.Write("Y1: ");
                //int y1 = int.Parse(Console.ReadLine());
                //Console.Write("X2: ");
                //int x2 = int.Parse(Console.ReadLine());
                //Console.Write("Y2: ");
                //int y2 = int.Parse(Console.ReadLine());
                //Console.Write("X3: ");
                //int x3 = int.Parse(Console.ReadLine());
                //Console.Write("Y3: ");
                //int y3 = int.Parse(Console.ReadLine());

                //    // slope(P1,P2) == slope(P1,P3), cross-multiplied to avoid dividing by zero
                //    int left = (y2 - y1) * (x3 - x1);
                //    int right = (y3 - y1) * (x2 - x1);

                //    if (left == right)
                //        Console.WriteLine("The three points lie on a single straight line.");
                //    else
                //        Console.WriteLine("The three points do NOT lie on a single straight line.");
                #endregion

                #region Q18
                /* 18- Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency
                     level is determined as follows:
                     - If the worker completes the job within 2 to 3 hours, they are
                       considered highly efficient.
                     - If the worker takes 3 to 4 hours, they are instructed to increase
                       their speed.
                     - If the worker takes 4 to 5 hours, they are provided with training
                       to enhance their speed.
                     - If the worker takes more than 5 hours, they are required to leave
                       the company.
                     To calculate the efficiency of a worker, the time taken for the task
                     is obtained via user input from the keyboard. */

                //Console.Write("Enter the time taken (in hours): ");
                //double hours = double.Parse(Console.ReadLine());

                //if (hours <= 0)
                //    Console.WriteLine("Invalid time.");
                //else if (hours <= 3)
                //    Console.WriteLine("Highly efficient.");
                //else if (hours <= 4)
                //    Console.WriteLine("You must increase your speed.");
                //else if (hours <= 5)
                //    Console.WriteLine("You will be provided with training to enhance your speed.");
                //else
                //    Console.WriteLine("You are required to leave the company.");
                #endregion

                #region Q19

                /* 19- Write a program that prints an identity matrix using for loop, in
                     other words takes a value n from the user and shows the identity
                    table of size n * n. */

                //Console.Write("Enter n: ");
                //int n = int.Parse(Console.ReadLine());

                //   for (int row = 0; row < n; row++)
                //   {
                //       for (int col = 0; col < n; col++)
                //       {
                //           Console.Write(row == col ? "1 " : "0 "); // 1 only on the diagonal
                //       }
                //       Console.WriteLine(); // new line after each row 
                //   }
                #endregion

                /*===============================================================================================
                 Arrays
                =================================================================================================*/
                #region Q20
                // 20- Write a program in C# Sharp to find the sum of all elements of the array.
                //Console.Write("Enter the size of the array: ");
                //int size =int.Parse(Console.ReadLine());
                //int[] arr = new int[size];

                //for (int i = 0; i < size; i++)
                //{
                //    Console.Write($"Enter element {i + 1}: ");
                //    arr[i] = int.Parse(Console.ReadLine());
                //}

                //long sum = 0;
                //for (int i = 0; i < arr.Length; i++)
                //{
                //    sum += arr[i];
                //    }

                //    Console.WriteLine($"Sum of all elements = {sum}");
                #endregion

                #region Q21
                // 21- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
                //               Console.Write("Enter the size of each array: ");
                //               int size = int.Parse(Console.ReadLine());
                //                int[] a = new int[size];
                //                int[] b = new int[size];

                //                Console.Write("Enter elements of the first array (sorted ascending): ");
                //                for (int i = 0; i < size; i++)
                //                {
                //                    a[i] = int.Parse(Console.ReadLine());
                //                }

                //                Console.Write("Enter elements of the second array (sorted ascending): ");
                //                for (int j = 0; j < size; j++)
                //                {
                //                    b[j] = int.Parse(Console.ReadLine());
                //                }

                //                int[] merged = new int[size * 2];
                //                int x = 0, y = 0, z = 0; // x walks a, y walks b, z fills merged

                //// take the smaller front element each time
                //while (x < size && y < size)
                //{
                //    if (a[x] <= b[y])
                //    {
                //        merged[z] = a[x];
                //        x++;
                //    }
                //    else
                //    {
                //        merged[z] = b[y];
                //        y++;
                //    }
                //    z++;

                //    // one of the arrays still has leftovers: copy them as they are
                //    while (x < size) { merged[z] = a[x]; x++; z++; }
                //    while (y < size) { merged[z] = b[y]; y++; z++; }

                //    Console.WriteLine("Merged array: " + string.Join(" ", merged));
                //}
                #endregion

                #region Q22
                // 22- Write a program in C# Sharp to count the frequency of each element of an array.
                //Console.Write("Enter the size of the array:");
                //                    int size = int.Parse(Console.ReadLine());
                //                    int[] arr = new int [size];
                //                    Console.Write("Enter elements of the array: ");
                //                    for (int i = 0; i < size; i++)
                //                 {
                //                     arr[i] = int.Parse(Console.ReadLine());
                //                }
                //                    bool[] counted = new bool[size]; // remembers elements we already counted

                //for (int j = 0; j < size; j++)
                //{
                //    if (counted[j]) continue; // skip, already reported

                //    int count = 1;
                //    for (int k = j + 1; k < size; k++)
                //    {
                //        if (arr[j] == arr[k])
                //        {
                //            count++;
                //            counted[j] = true;
                //        }
                //    }
                //    Console.WriteLine($"{arr[j]} appears {count} time(s)");
                //}
                #endregion

                #region Q23
                // 23- Write a program in C# Sharp to find maximum and minimum element in an array
                //Console.Write("Enter the size of the array: "); 
                // int size = int.Parse(Console.ReadLine());  
                // int[] arr = new int[size];
                //Console.Write("Enter elements of the array: ");
                //          for (int i = 0; i < size; i++)
                //       {
                //           arr[i] = int.Parse(Console.ReadLine());
                //       }
                //                int max = arr[0];
                //                int min = arr[0];

                //                for (int j = 1; j < arr.Length; j++) // start from 1, arr[0] is already taken
                //                {
                //                    if (arr[j] > max) 
                //                    max = arr[j];
                //                    if (arr[j] < min) 
                //                    min = arr[j];
                //                }

                //                Console.WriteLine($"Maximum element = {max}");
                //                Console.WriteLine($"Minimum element = {min}");
                #endregion

                #region Q24
                // 24- Write a program in C# Sharp to find the second largest element in an array.

                //Console.Write("Enter the size of the array: ");
                //int size = int.Parse(Console.ReadLine());
                //int[] arr = new int[size];
                //Console.Write("Enter elements of the array: ");
                //for (int i = 0; i < size; i++)
                //{
                //    arr[i] = int.Parse(Console.ReadLine());
                //}

                //                        int largest = arr[0];
                //                        for (int j = 1; j < arr.Length; j++)
                //                        {
                //                            if (arr[j] > largest) 
                //                            largest = arr[j];
                //                        }

                //                        bool found = false;
                //                        int second = 0;
                //                        for (int k = 0; k < arr.Length; k++)
                //                        {
                //                            if (arr[k] != largest && (!found || arr[k] > second))
                //                            {
                //                                second = arr[k];
                //                                found = true;
                //                            }
                //                        }

                //                        if (found)
                //                            Console.WriteLine($"Second largest element = {second}");
                //                        else
                //                            Console.WriteLine("There is no second largest element (all elements are equal).");
                #endregion

                #region Q25

                /* 25- Consider an Array of Integer values with size N, having values as
                    in this Example
                     7 0 0 0 5 6 7 5 0 7 5 3
                     write a program find the longest distance between Two equal cells.
                     The distance is measured by the number Of cells 
                    - for example, the
                     distance between the first and the fourth cell is 2 (cell 2 and
                     cell 3).
                     In the example above, the longest distance is between the first 7
                    and the 10th 7, with a distance of 8 cells, i.e. the number of cells
                     between the 1st and the 10th 7s.
                     Note:
                     - Array values will be taken from the user
                     - If you have input like 1111111 then the distance is the number of
                      cells between the first and the last cell.*/

                //Console.Write("Enter the size of the array: ");
                //int size = int.Parse(Console.ReadLine());
                //int[] arr = new int[size];
                //Console.Write("Enter elements of the array: ");
                //for (int i = 0; i < size; i++)
                //{
                //    arr[i] = int.Parse(Console.ReadLine());
                //}
                //int maxDistance = -1; // -1 means "no equal pair found yet"

                //                            for (int j = 0; j < size; j++)
                //                            {
                //                                for (int k = j + 1; k < size; k++)
                //                                {
                //                                    if (arr[j] == arr[k])
                //                                    {
                //                                        int distance = k - j - 1; // cells strictly BETWEEN j and k
                //                                        if (distance > maxDistance) maxDistance = distance;
                //                                    }
                //                                }
                //                            }

                //                            if (maxDistance == -1)
                //                                Console.WriteLine("There are no two equal cells in the array.");
                //                            else
                //                                Console.WriteLine($"The longest distance = {maxDistance}");
                #endregion

                #region Q26
                /* 26- Given a list of space separated words, reverse the order of the words.
                    Input: this is a test   Output: test a is this
                    Input: all your base    Output: base your all
                     Input: Word             Output: Word
                     Note: Check the Split Function (Member in String Class)
                     Output will be a Single Console.WriteLine Statement */

                //Console.Write("Enter words separated by spaces: ");
                //string[] words = (Console.ReadLine() ?? "").Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                //Array.Reverse(words); // reverses the array in place
                //Console.WriteLine(string.Join(" ", words)); // the single output statement

                #endregion

                #region Q27
                // Multiple Dimensional Arrays  
                //#region Q27
                ///*
                //         27- Write a program to create two multidimensional arrays of same size.
                //        Accept value from user and store them in first array. Now copy all
                //    the elements of first array on second array and print second array.
                //*/
                //static int ReadInt(string message)
                //{
                //    int value;
                //    Console.Write(message);
                //    while (!int.TryParse(Console.ReadLine(), out value))
                //    {
                //        Console.Write("Invalid input. " + message);
                //    }
                //    return value;
                //}
                //Console.Write("Enter number of rows: ");
                //int rows = int.Parse(Console.ReadLine());
                //Console.Write("Enter number of columns: ");
                //int cols = int.Parse(Console.ReadLine());

                //int[,] first = new int[rows, cols];
                //int[,] second = new int[rows, cols]; // same size

                //// fill the first array from the user

                //for (int r = 0; r < rows; r++)
                //{
                //    for (int c = 0; c < cols; c++)
                //    {
                //        first[r, c] = ReadInt($"first[{r},{c}] = ");
                //    }
                //}

                //// copy element by element
                //for (int r = 0; r < rows; r++)
                //{
                //    for (int c = 0; c < cols; c++)
                //    {
                //        second[r, c] = first[r, c];
                //    }
                //}

                //// print the second array
                //Console.WriteLine("Second array:");
                //for (int r = 0; r < rows; r++)
                //{
                //    for (int c = 0; c < cols; c++)
                //    {
                //        Console.Write(second[r, c] + "\t");
                //    }
                //    Console.WriteLine();
                //}
                #endregion
                // one dimentional array
                #region Q28
                // 28- Write a Program to Print One Dimensional Array in Reverse Order
                //Console.Write("Enter the size of the array: ");
                //int size = int.Parse(Console.ReadLine());
                //int[] arr = new int[size];

                //Console.WriteLine("Enter the elements of the array:");
                //for (int i = 0; i < size; i++)
                //{
                //    arr[i] = int.Parse(Console.ReadLine());
                //}

                //Console.WriteLine("Array in reverse order:");
                //for (int i = arr.Length - 1; i >= 0; i--)
                //{
                //    Console.Write(arr[i] + " ");
                //}
                //Console.WriteLine();
                #endregion

            }
        }
    }
