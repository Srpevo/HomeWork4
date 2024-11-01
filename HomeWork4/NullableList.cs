using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;

namespace Nullable.Collections
{
    internal class NullableList
    {
        List<string?> list;
        
        public NullableList()
        {
            list = new List<string?>(new string?[10]);
        }
        public NullableList(int Size)
        {
            list = new List<string?>(new string?[Size]);
        }

        public NullableList FillList()
        {
            for (int i = 0; i < list.Count; i++)
            {
                string? input = Console.ReadLine();
                if (input.ToLower() == "Null".ToLower())
                {
                    list[i] = null;
                }
                else
                {
                    list[i] = input;
                }
            }

            return this;
        }
        public NullableList AutoFill()
        {
            Random rnd = new Random();

            for (int i = 0; i < list.Count;i++)
            {
                if (rnd.Next(0, 2) == 0)
                {
                    list[i] = null;
                }
                else
                {
                    list[i] = rnd.Next().ToString();
                }
            }
            return this;
        }
        public List<string> GetList()
        {
            return list;
        }
        public void PrintList()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item ?? "Empty");
            }
        }
    }

    /// <summary>
    /// Nullable Array \/ \/ \/ \/
    /// </summary>

    internal class NullableArray
    {
        private int?[] Arr;

        public NullableArray()
        {
            Arr = new int?[20];
        }

        public NullableArray(int Size)
        {
            Arr = new int?[Size];
        }

        public NullableArray FillArray()
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                int Value = 0;
                string Input = Console.ReadLine();

                if (Input.ToLower() == "Exit".ToLower()) { break; }
                if (Input.ToLower() == "Print".ToLower())
                {
                    PrintArray();
                    break;
                }
                if (!Int32.TryParse(Input,out Value))
                {
                    Arr[i] = null;
                }
                else
                {
                    Arr[i] = Value;
                }
            }
            return this;
        }
        public int?[] GetArray()
        {
            return Arr;
        }
        public void PrintArray()
        {
            foreach (var item in Arr)
            {
                Console.WriteLine(item ?? 0);
            }
        }
    }

}
