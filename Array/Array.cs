using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures.Array
{
    public class Array :ICloneable , IEnumerable
    {
        private Object[] InnerArray { get; set; }
        public int Length => InnerArray.Length;

        public Array(int defaultSize = 16)
        {
            InnerArray = new Object[defaultSize]; //fixed size 

        }
        public Array(params Object[] sourceArray) :this(sourceArray.Length)
        {
           System.Array.Copy(sourceArray, 0, InnerArray, 0, sourceArray.Length);
        }

        public Object GetValue(int index)
        {
            if (!(index>=0 && index<InnerArray.Length))
                throw new ArgumentOutOfRangeException();
            return InnerArray[index];
        } 
        public void SetValue(Object value, int index)
        {
            if (!(index >= 0 && index < InnerArray.Length))
                throw new ArgumentOutOfRangeException();
            if (value == null)
                throw new ArgumentNullException();

            InnerArray[index] = value;
        }

        public object Clone()
        {
            return MemberwiseClone();

        }

        public IEnumerator GetEnumerator()
        {
            return InnerArray.GetEnumerator();
        }
    }
}
