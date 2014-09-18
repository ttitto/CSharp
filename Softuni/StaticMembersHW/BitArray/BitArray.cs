using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BitArray
{
   public class BitArray
    {
       private bool[] arr;
       private int size;

       public BitArray(int size){
           this.Size = size;
           this.Arr = new bool[size];
       }

       public bool[] Arr
       {
           get { return this.arr; }
           set {
               if (null == value) throw new ArgumentNullException();
               this.arr = value; }
       }
       public int Size
       {
           get { return this.size; }
           set
           {
               if (value < 0) throw new ArgumentException("Invalid value for the array size");
               this.size= value;
           }
       }

       public bool this[int index]
       {
           get {
               if (index < 0 || index > 100000) throw new ArgumentException("The given index is outside the allowed range [0 - 100000]");
               return this.Arr[index]; }
           set {
               if (index < 0 || index> 100000) throw new ArgumentException("The given index is outside the allowed range [0 - 100000]");
               if (value != false && value != true) throw new ArgumentException("The given value is not a valid bit value");
               this.Arr[index] = value;
           }
       }
       /// <summary>
       /// Place ones at the positions passed as arguments
       /// </summary>
       /// <param name="positions"></param>
       public void SetBits(params int[] positions)
       {
           for (int i = 0; i < positions.Length; i++)
           {
               this[positions[i]] = true;
           }
       }

       public override string ToString()
       {
           return ArrayToBigNumber().ToString();
       }

       private BigInteger ArrayToBigNumber()
       {
           BigInteger num = BigInteger.Zero;
           BigInteger exp2 = BigInteger.One;
           for (int pos = 0; pos < this.Size; pos++)
           {
               exp2 *= 2;
               if (this[pos])
               {
                   num += exp2/2;
               }
           }

           return num;
       }
      
    }
}
