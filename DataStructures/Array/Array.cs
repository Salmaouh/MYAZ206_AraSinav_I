using System;
using System.Collections;

namespace DataStructures.Array
{
    public class Array : IEnumerable, ICloneable, IDisposable
    {
        protected virtual Object[] InnerArray { get; set; }

        public int Length { get; set; }

        public Array(int defaultSize)
        {
            InnerArray = new Object[defaultSize];
        }

        public Array(params object[] sourceArray)
        {
            InnerArray = new Object[sourceArray.Length];
            System.Array.Copy(sourceArray, InnerArray, sourceArray.Length);
        }

        public static Array CreateInstance(int length) => new Array(length);

        public void SetValue(Object value, int index)

        {
            if (!(index >= 0 && index < InnerArray.Length))
            {
                throw new ArgumentOutOfRangeException("index");
            }
            InnerArray[index] = value;
            return;
        }

        public Object GetValue(int index)
        {
            if (!(index >= 0 && index < InnerArray.Length))
            {
                throw new ArgumentOutOfRangeException("index");
            }
            return InnerArray[index];
        }

        public IEnumerator GetEnumerator()
        {
            // return InnerArray.Take(Length).GetEnumerator();
            return new ArrayEnumerator(InnerArray);
            // return new ReverseEnumerator(InnerList);
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public int IndexOf(Object value)
        {
            for (int i = 0; i < InnerArray.Length; i++)
            {
                if (GetValue(i) == (value))
                    return i;
            }
            return -1;
        }
    }


}