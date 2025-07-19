using System;

namespace menu_number
{
    internal class Program
    {
        public static void ShowMenu()
        {
            Console.WriteLine("----------------- menu -------------------");
            Console.WriteLine("P - Print numbers");
            Console.WriteLine("A - Add a number");
            Console.WriteLine("M - Display mean of the numbers");
            Console.WriteLine("S - Display the smallest number");
            Console.WriteLine("L - Display the largest number");
            Console.WriteLine("C - Clear list");
            Console.WriteLine("Q - Quit");
        }

        public static string PrintNumbers(List<int> nums)
        {
            if (nums.Count == 0)
                return "No numbers in list";

            string result = "";
            for (int i = 0; i < nums.Count; i++)
            {
                result = ($"nums:[ {nums[i]} ]");
                result += nums[i];
            }
            return result;

        }

        public static string AddNumber(List<int> nums)
        {
            Console.Write("Please add a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            nums.Add(number);
            return $"{number} added";
        }

        public static string DisplayMean(List<int> nums)
        {
            if (nums.Count == 0)
                return "The list is empty";
            else
            {
                double sum = 0;
                for (int i = 0; i < nums.Count; i++)
                {
                    sum += nums[i];
                }

                double avg = sum / nums.Count;
                return $"Average: {avg}";
            }
        }

        public static string DisplaySmallest(List<int> nums)
        {
            if (nums.Count == 0)
                return "The list is empty";
            else
            {
                int smallestNumber = nums[0];
                for (int i = 1; i < nums.Count; i++)
                {
                    if (nums[i] < smallestNumber)
                        smallestNumber = nums[i];
                }
                return $"The smallest number : {smallestNumber}";
            }
        }

        public static string DisplayLargest(List<int> nums)
        {
            if (nums.Count == 0)
                return "The list is empty";
            else
            {

                int largestNumber = nums[0];
                for (int i = 1; i < nums.Count; i++)
                {
                    if (nums[i] > largestNumber)
                        largestNumber = nums[i];
                }
                return $"The largest number : {largestNumber}";
            }
        }

        public static string ClearList(List<int> nums)
        {
            if (nums.Count == 0)
                return "The list is  empty";
            else
            {
                nums.Clear();
                return "The numbers clear";
            }
        }

        public static string Quit()
        {
            return "Goodbye!";
        }

        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            string choice;

            do
            {
                ShowMenu();
                Console.Write("Enter your choice: ");
                choice = Console.ReadLine().ToUpper();

                switch (choice)
                {
                    case "A":
                        Console.WriteLine(AddNumber(nums));
                        break;
                    case "P":
                        Console.WriteLine(PrintNumbers(nums));
                        break;
                    case "M":
                        Console.WriteLine(DisplayMean(nums));
                        break;
                    case "S":
                        Console.WriteLine(DisplaySmallest(nums));
                        break;
                    case "L":
                        Console.WriteLine(DisplayLargest(nums));
                        break;
                    case "C":
                        Console.WriteLine(ClearList(nums));
                        break;
                    case "Q":
                        Console.WriteLine(Quit());
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }


            } while (choice != "Q");
        }
    }
}
