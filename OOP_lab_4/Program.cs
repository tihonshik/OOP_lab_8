using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab_4
{

    public class Listt<T> : IInterface<T> where T : struct 
    {
        public List<T> data = new List<T>();

        public void Push(T obj)
        {
            data.Add(obj);
        }

        public void Delete(int position)
        {
            data.RemoveAt(position);
        }

        public T GetElement(int position)
        {
            return data.ElementAt(position);
        }

        public static Listt<T> operator +(Listt<T> obj, int i)
        {
            MyType temp = new MyType();
            temp.x = i;
            obj.Push(temp.x);
            return obj;
        }

        public static Listt<T> operator --(Listt<T> obj)
        {
            obj.data.RemoveAt(obj.data.Count-1);
            return obj; 
        }


        public static bool operator !=(Listt<T> obj, Listt<T> obj1)
        {
            return ! obj.Equals(obj1);
        }


        public static bool operator ==(Listt<T> obj, Listt<T> obj1)
        {
            return obj.Equals(obj1);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public class Owner
        {
            int id;
            string name;

            public Owner(int id, string name)
            {
                this.id = id;
                this.name = name;
            }

            public void Out()
            {
                Console.WriteLine($"{this.name} {this.id}");
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Listt<T> a = obj as Listt<T>;
            if (a as Listt<T> == null)
            {
                return false;
            }
            return a.data == data;
        }

        public class Date
        {
            int day;
            int month;

            public Date(int day, int month)
            {
                this.day = day;
                this.month = month;
            }

            public void Out()
            {
                Console.WriteLine($"{this.day} {this.month}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Listt<int> Q = new Listt<int>();
                Listt<int> W = new Listt<int>();
                for (int i = 0; i < 5; i++) 
                {
                    MyType temp = new MyType();
                    temp.x = i;
                    Q.data.Add(temp.x);
                    W.Push(temp.x);
                }

                Q--; //--
                Q = Q + 20; //+

                Console.WriteLine(Q != W); // operator !=


                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"{Q.GetElement(i)} ");
                }

                Listt<int>.Owner A = new Listt<int>.Owner(18, "\nFilipp");
                A.Out();
                Listt<int>.Date B = new Listt<int>.Date(8, 2);
                B.Out();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Hello world");
            }

        }
    }
}
