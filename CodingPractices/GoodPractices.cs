using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingStandards
{
            
        public class GoodPractices
        {
            private const int MaxLinesOfCode = 25;                                            // use const instead of hardcoding nums
            private const string DefaultMessage = "Failed to update database.";               // keep var private and expose public methods

            private string _name;                                                            //use only one var declaration per line
            private int _age;

            public void SavePhoneNumber(string phoneNumber)                 //a method should do only one job
            {
                 // logic
            }

            public void SaveAddress(string address)
            {
            // logic
            }

        public void SendEmail(string address, string email)
            {
                // logic
            }

            public bool SayHello(string name)                              //method name should tell what it does
            {
                _name = name;
                Console.WriteLine("Hello, " + _name + "!");

                if (IsRegisteredMember())
                {
                // logic
            }
            else if (IsGuestMember())
                {
                // logic
            }
            else
                {
                    // Unexpected user type. Throw an exception
                    throw new Exception("Unexpected value " + _name + ".");            //handle error by throwing exception
                }

                return true;
            }

            private bool IsRegisteredMember()
            {
                return _age > 18;
            }

            private bool IsGuestMember()
            {
                return _age <= 18;
            }
        

            public string ComposeMessage(string[] lines)
            {
                StringBuilder message = new StringBuilder();         //If your loop has several iterations, then it is a good idea to use StringBuilder class instead of String object.

            for (int i = 0; i < lines.Length; i++)
                {
                    message.Append(lines[i]);
                }

                return message.ToString();
            }

            public void LogError(Exception ex)
            {
            // logic
             }

        public void OpenConnection()
            {
                try
                {
                    // Open the database connection.
                }
                catch (Exception ex)
                {
                    // Handle the exception.
                }
                finally
                {
                    // Close the connection in the finally block.
                }
            }

            public void ProcessData()
            {
                string data = GetData();

                if (!string.IsNullOrEmpty(data))
                {
                    // Process the data.
                }
            }

            private string GetData()
            {
                // Retrieve the data.
                return string.Empty;
            }

            private enum MailType                                                //use enum for constant values in group
            {
                Html,
                PlainText,
                Attachment
            }
        }
    }

