using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11
{

    internal class OtusDictionary 
    {
        public int Key { get; set; }
        public string? Value { get; set; }


        string[] array = new string[32];
        public void Add(int key, string value)
        {
            int keyContainer = key;
            while (true)
            {
                if (value != null)
                {
                    key = Math.Abs(key % array.Length);
                    if (array[key] == null)
                    {
                       array[key] = value;
                    }
                    else
                    {
                        string[] arrayContainer = array;
                        Array.Resize(ref array, arrayContainer.Length * 2);
                        for (int i = 0; i < arrayContainer.Length; i++)
                        {
                            key = i;
                            key = Math.Abs(key % array.Length);
                            array[keyContainer] = value;
                        }
                        break;
                    }
                }
                else
                {
                    break;
                }
                break;
            }
        }

        public string Get(int key)
        {
                return array[key];
        }

    }
}
