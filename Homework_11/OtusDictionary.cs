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
        string[] array = new string[32];
        public void Add(int key, string value)
        {
            int keyContainer = key;

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
                        key = Math.Abs(i % array.Length);
                        
                        array[key] = array[i];
                    }
                    keyContainer = Math.Abs(keyContainer % array.Length);
                    array[keyContainer] = value;
                }
            }
            else
            {
                throw new Exception("Ошибка!");
            }
        }

        public string Get(int key)
        {
            if (array[key] != null)
                return array[key];
            else
                throw new Exception();
        }

    }
}
