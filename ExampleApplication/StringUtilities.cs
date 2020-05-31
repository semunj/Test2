using System;
using System.Net.Http.Headers;

namespace ExampleApplication
{
    public class StringUtilities
    {
        public string CombineArrayStringWithDelimiter(string[] stringArray, string delimiter)
        {
            string str = default(string);
            foreach(string item in stringArray)
            {
                if (item != stringArray[stringArray.Length - 1])
                    str += item + delimiter;
                else
                    str += item;
            }
            return str;
        }

        public string ReplaceSpacesInStringByHyphens(string aString)
        {
            string[] stringArray = aString.Split(null);
            return CombineArrayStringWithDelimiter(stringArray, "-");
        }
    }
}
