using System;

namespace BalancedBracketsNS
{
    public class BalancedBrackets
    {
        /**
         * The function BalancedBrackets should return true if and only if
         * the input string has a set of "balanced" brackets.
         *
         * That is, whether it consists entirely of pairs of opening/closing
         * brackets (in that order), none of which mis-nest. We consider a bracket
         * to be square-brackets: [ or ].
         *
         * The string may contain non-bracket characters as well.
         *
         * These strings have balanced brackets:
         *  "[LaunchCode]", "Launch[Code]", "[]LaunchCode", "", "[]"
         *
         * While these do not:
         *   "[LaunchCode", "Launch]Code[", "[", "]["
         *
         * parameter str - to be validated
         * returns true if balanced, false otherwise
        */




        public string StrNum { get; set; }


        public static bool HasBalancedBrackets(String str)
        {
            int brackets = 0;

            char[] charArr = str.ToCharArray();

            for (int i = 0; i < charArr.Length; i++)
            {
                if (charArr[i] == ']')
                {
                    brackets--;
                }
                else
                {
                    if (charArr[i] == '[')
                    {
                        brackets++;

                        for (int j = i + 1; j < charArr.Length; j++)
                        {
                            if (charArr[j] == '[')
                            {
                                brackets++;
                                break;
                            }
                            else if (charArr[j] == ']')
                            {
                                brackets--;
                                break;
                            }

                            //else if (charArr[j] == ']')
                            //{
                            //    brackets++;
                            //}
                        }
                    }
                }
                break;

               
            }
            return brackets == 0;

        }
        //foreach (char ch in str.ToCharArray())
        //{
        //    if (ch == '[')
        //    {
        //        brackets++;
        //    }
        //    else if (ch == ']')
        //    {
        //        brackets--;
        //    }
        //}
        //return brackets == 0;





        public BalancedBrackets(string strNum)
        {
            StrNum = strNum;
        }
    }


}
