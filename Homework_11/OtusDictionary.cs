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
        int[] keyIndex = new int[32];

        public void Add(int key, string value)
        {
            if (value != null)
            {
                int keyValue = Math.Abs(key % array.Length);
                if (array[keyValue] == null)
                {
                    array[keyValue] = value;
                    keyIndex[keyValue] = key;
                }
                else
                {
                    string[] arrayContainer = array;
                    Array.Resize(ref array, arrayContainer.Length * 2);

                    int[] keyIndexContainer = keyIndex;
                    Array.Resize(ref keyIndex, keyIndexContainer.Length * 2);

                    for (int i = 0; i < arrayContainer.Length; i++)
                    {
                        key = Math.Abs(i % array.Length); 
                        array[key] = array[i];
                        keyIndex[key] = keyIndex[i];
                    }
                    keyIndexContainer[key] = Math.Abs(keyIndexContainer[key] % array.Length);
                    //keyContainer = Math.Abs(keyContainer % array.Length);
                    array[keyIndexContainer[key]] = value;
                }
            }
            else
            {
                throw new ArgumentNullException("Значение не может быть null!");
            }
        }

        public string Get(int key)
        {
            int keyValue = Math.Abs(key % array.Length);
            if (array[keyValue] != null)
                return array[keyValue];
            else
                throw new KeyNotFoundException("Ключ не найден!");
        }

    }
}
