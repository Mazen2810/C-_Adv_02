using System.Collections;
namespace Demo
{
    internal class Program
    {
        public static int InsertFromUser(string message)
        {
            bool flag;
            int number;
            do
            {
                Console.WriteLine(message);
                flag = int.TryParse(Console.ReadLine(), out number);
            } while (!flag || number < 0 );

            return number;
        }
        static void Main(string[] args)
        {
            #region Q2: Given a number N and an array of N numbers. Determine if it's palindrome or not.

           /// ArrayList Numbers = new ArrayList();
           /// Numbers.Capacity = InsertFromUser("Enter Size of array");
           /// for(int i = 0; i < Numbers.Capacity; i++)
           /// {
           ///     Numbers.Add(InsertFromUser($"Enter Index {i}"));
           /// }
           /// int count = 0;
           ///for(int i = 0;i < Numbers.Count / 2; i++)
           /// {
           ///     if (Numbers[i].Equals(Numbers[Numbers.Count - 1 - i]))
           ///         count++;
           ///    
           ///    
           /// }
           ///if(count == Numbers.Count / 2)
           ///     Console.WriteLine("YES");
           ///else
           ///     Console.WriteLine("NO");
            #endregion
        }
    }
}
