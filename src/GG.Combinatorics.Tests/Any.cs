﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GG.Combinatorics.Tests
{
    public static class Any
    {
        public static int Int()
        {
            var r = new Random();
            return r.Next(int.MinValue, int.MaxValue);
        }

        public static int IntLessThan(int maxValue)
        {
            var r = new Random();
            return r.Next(int.MinValue, maxValue);
        }

        public static IList<int> IntIList(string comaSeparatedString)
        {
            return GenericIList<int>(comaSeparatedString, int.Parse);
        }

        public static IList<char> CharIList(string comaSeparatedString)
        {
            return GenericIList<char>(comaSeparatedString, s => s[0]);
        }

        private static IList<T> GenericIList<T>(string comaSeparatedString, Func<string, T> parsingFunction)
        {
            string[] parts = comaSeparatedString.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            var list = parts.Select(s => parsingFunction(s));
            var r = new Random();
            if (r.Next(2) == 0)
            {
                return list.ToList();
            }

            return list.ToArray();
        }
    }
}
