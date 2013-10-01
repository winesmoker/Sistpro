using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
         static void Main(string[]args)
        {
            int[]a={5,6,3,5,7};
            int n=5;
            int k;
            int i=0;
            for(i=0;i<n;i++)
                for(int j=i+1;j<n;j++)
                    if(a[i]>a[j])
                    {
                        k=a[j];
                        a[j]=a[i];
                        a[i]=k;
                    }

            for(i=0;i<n;i++)
            {
                Console.WriteLine(a[i]);
            }

        }
    }
}

