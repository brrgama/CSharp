using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralLibrary
{
    namespace Fields_Properties
    {
        public class Test
        {
            public int field_1;
            public string field_2;
            private int field_4;

            public int Property_1 { get; set; }
            public string Property_2 { get; set; }
            public int Property_3 { get; }
            public int Property_4
            {
                get
                {
                    return field_4;
                }
                set
                {
                    if(value <= 2022)
                    {
                        field_4 = value;
                    }
                    else
                    {
                        throw new Exception("Invalid Value.");
                    }
                }
            }

            public Test(int value)
            {
                Property_3 = value;
            }

            //Static method.
            public static void PrintFields()
            {
                try
                {
                    Test t = new Test(5);
                    t.field_1 = 2021;
                    t.field_2 = "New message";

                    t.Property_1 = 2022;
                    t.Property_2 = "Another Message";
                    t.Property_4 = 2025;

                    Console.WriteLine($"First field = {t.field_1} Second Field = {t.field_2}\n");
                    Console.WriteLine($"First Propertie = {t.Property_1} Second Propertie = {t.Property_2} Third Propertie = {t.Property_3}");
                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
                
            }
        }

        class FieldsAndProperties
        {
        }
    }
    
}
