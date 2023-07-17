using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingStandards
{
    internal class ExceptionHandling
    {
        public void ReadFromFile(string fileName)
        {
            try
            {
                // Read from file.
            }
            catch (FileIOException ex)
            {
                // Log error.
                // Re-throw exception depending on your case.
                throw;
            }
        }

        public void HandleException()
        {
            try
            {
                                                             // Code that may throw an exception.
            }
            catch (SpecificException ex)
            {
                                                              // Handle the specific exception.
            }
            catch (Exception ex)
            {
                                                              // Log the error with all possible details.
                LogException(ex);
                throw;
            }
        }

        public void LogException(Exception ex)
        {
                                                             // Log the exception with details such as time, method, and class name.
        }

        public void PerformTask()
        {
            try
            {
                                                              // Code that may throw an exception.
            }
            catch (Exception)
            {
                                                              // Let the exception propagate and crash the application.
                throw;
            }
        }

        public void RethrowException()
        {
            try
            {
                
            }
            catch (Exception ex)
            {
             
                throw;                                          //handle the error by explicitly throwing exception
            }
        }

        public void InsertRecord()
        {
            if (RecordExists())
            {
                // Record already exists.
                return;
            }

            try
            {
                // Insert the record.
            }
            catch (Exception ex)
            {
                // Handle the exception.
            }
        }

        public bool RecordExists()
        {
            // Check if the record already exists.
            return false;
        }

        public void PerformMultipleTasks()
        {
            try
            {
                // Task 1
            }
            catch (Exception ex)
            {
                // Log the error and provide specific error message.
                LogException(ex);
                Console.WriteLine("Error occurred while performing Task 1.");
            }

            try
            {
                // Task 2
            }
            catch (Exception ex)
            {
                // Log the error and provide specific error message.
                LogException(ex);
                Console.WriteLine("Error occurred while performing Task 2.");                   //give meaningfull error messages
            }

            // ...
        }

        public class FileIOException : Exception                                           //custom exceptions are created for app-specific exceptions      
        {
            public FileIOException(string message) : base(message)
            {
            }
        }

        public class SpecificException : Exception
        {
            public SpecificException(string message) : base(message)
            {
            }
        }
    }
}
}
