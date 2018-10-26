using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace OOP_lab_4
{
    class NotNumberException : Exception
    {
        public NotNumberException(string msg) : base(msg)
        {

        }
    }

    interface IInterface<T>
    {
        void Push(T value);
        T GetElement(int position);
        void Delete(int position);
    }

    public class MyType
    {
        dynamic X;

        public dynamic x
        {
            get { return X; }
            set
            {
                var test = value;
                if (test is string || test is char)
                {
                    throw new NotNumberException("Введите число а не символы");
                }
                else
                {
                    X = value;
                }
            }
        }


    }

    class Gen<T,G>
    {
        G ob;
        T odb;

        public Gen(G o)
        {
            ob = o;
        }

        public T GetOb()
        {
            return odb;
        }

    }
}
