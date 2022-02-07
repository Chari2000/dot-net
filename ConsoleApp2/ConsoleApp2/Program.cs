using System;

namespace ConsoleApp2
{
    internal class Generics
    {

        public class sample<T>
        {
            private T data;
            public T value
            {
                get
                {
                    return this.data;
                }
                set
                {
                    this.data = value;
                }

            }

        }
        static void Main(string[] args)
        {

            sample<string> name = new sample<string>();
            name.value = "Chari";

            sample<float> version = new sample<float>();
            version.value = 33.0F;
            
            Console.WriteLine(name.value);
            
            Console.WriteLine(version.value);
        }
    }
}
