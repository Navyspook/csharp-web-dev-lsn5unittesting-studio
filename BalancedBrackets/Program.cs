using System;

namespace BalancedBracketsNS
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(BalancedBrackets.HasBalancedBrackets("[test][test]"));


            //int brackets = 0;

            //char[] charArr = str.ToCharArray();

            //for (int i = 0; i < charArr.Length; i++)
            //{
            //    if (charArr[i] == ']')
            //    {
            //        brackets--;
            //        break;
            //    }

            //    else if (charArr[i] == '[')
            //    {
            //        brackets++;
            //        for (int j = i + 1; j < charArr.Length; j++)
            //        {
            //            if (charArr[j] == '[')
            //            {
            //                brackets++;
            //            }
            //            //else if (charArr[j] == ']')
            //            //{
            //            //    brackets++;
            //            //}
            //        }
            //    }
            //}
            //return brackets == 0;

        }
    }
}
