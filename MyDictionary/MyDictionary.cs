using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<K, V>
    {
        K[] _keys;
        V[] _value;
        public MyDictionary()
        {
            _keys = new K[0];
            _value = new V[0];

        }

        public void Add(K key, V value)
        {
            K[] tempKey = _keys;
            V[] tempValue = _value;

            _keys = new K[tempKey.Length + 1];
            _value = new V[tempValue.Length + 1];


            for (int i = 0; i < tempKey.Length; i++)
            {
                _keys[i] = tempKey[i];
                

            }
            for (int i = 0; i < tempValue.Length; i++)
            {
                
                _value[i] = tempValue[i];

            }
            _keys[_keys.Length - 1] = key;
            _value[_value.Length - 1] = value; // 

        }

 
    }
}
