using System;


namespace Homework_11
{
    internal class OtusDictionary
    {
        string[] array = new string[32];
        int[] keyIndex = new int[32];

        public void Add(int key, string value)
        {
            if (value is null)
                throw new ArgumentNullException("Значение не может быть null!");

            int arrayIndexKey = Array.IndexOf(keyIndex, key);
            if (arrayIndexKey == key)
            {
                throw new Exception("Значение передаваемого ключа повторяется!");
            }

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
                array[keyIndexContainer[key]] = value;
            }
        }

        public string Get(int key)
        {
            int arrayIndex = Array.IndexOf(keyIndex, key);
            if (array[arrayIndex] != null)
                return array[arrayIndex];
            throw new KeyNotFoundException("Ключ не найден!");
        }
    }
}
