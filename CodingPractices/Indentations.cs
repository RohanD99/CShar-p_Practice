using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingStandards
{
    internal class Indentations
    {
        public class Example                                    //tabs are used for indentation
        {
            private string name;
            private int age;

            #region Public Methods                            //#region directive is used to group related pieces of code together.

            public void SayHello(string name)
            {                                                  //Curly braces are placed in the same level as the code outside the braces.
                name = name;

                Console.WriteLine("Hello, " + name + "!");

                if (IsMorning())
                {
                    Console.WriteLine("Good morning!");
                }
                else
                {
                    Console.WriteLine("Good day!");
                }
            }

            #endregion

            #region Private Methods                           

            private bool IsMorning()                     //Private member variables, properties, and methods are placed at the top
            {
                var currentTime = DateTime.Now;
                return currentTime.Hour < 12;
            }

            #endregion

            #region Properties

            public int Age                                  //Public members are placed at the bottom.
            {
                get { return age; }
                set { age = value; }
            }

            #endregion
        }
    }
}
