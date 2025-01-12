
using System;
using OOP_HomeWork_1;

namespace OOP_HomeWork_1
{

    public class XucXac
    {
     
        private int soMat;

      
        public XucXac(int soMat)
        {
            soMat = this.soMat;
        }


        public int DoXucXac()
        {
            Random random = new Random();
            return random.Next(1, soMat + 1);
        }
    }
}
