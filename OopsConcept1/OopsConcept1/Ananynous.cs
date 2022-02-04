using System;

namespace OopsConcept1
{

    //anonymous types
    class Anonymous
    {
        static public void sampleMethod(dynamic val)
        {
            Console.WriteLine(val.s_id);
            Console.WriteLine(val.S_name);
            Console.WriteLine(val.langauge);
            Console.WriteLine(val.nested_ob.email);
        }
        public static void Main6()
        {

            var anony_Object = new
            {
                s_id = 123,
                S_name = "chari",
                langauge = "English",
                nested_ob = new { email = "Sample@yahoo.com" }
            };
            sampleMethod(anony_Object);
        }
    }
}