using AccessModifiers2;

namespace AccessModifiers1
{
    internal class Program
    {      
        public class MyClass
        {
            public int publicField = 10;
            private string privateField = "Hello";
            protected bool protectedField = true;
            internal double internalField = 3.14;
            protected internal char protectedInternalField = 'A';
            public enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

            public void PublicMethod()
            {
                Console.WriteLine("This is a public method.");
            }

            private void PrivateMethod()
            {
                Console.WriteLine("This is a private method.");
            }

            protected void ProtectedMethod()
            {
                Console.WriteLine("This is a protected method.");

            }

            internal void InternalMethod()
            {
                Console.WriteLine("This is an internal method.");
            }

            protected internal void ProtectedInternalMethod()
            {
                Console.WriteLine("This is a protected internal method.");
            }

            private protected void PrivateProtectedMethod() 
            {
                Console.WriteLine("This is a private protected method.");
            }
        }

        public class AnotherClass : MyClass
        {
            public void AccessProtectedFields()
            {
                Console.WriteLine(protectedField);              // Accessible from derived class
                Console.WriteLine(protectedInternalField);      // Accessible from derived class
                Console.WriteLine(InternalMethod);
                Console.WriteLine(ProtectedMethod);
              

            }

            public void AccessProtectedMethods()
            {
                ProtectedMethod();                              // Accessible from derived class
                ProtectedInternalMethod();                      // Accessible from derived class

            }
        }
    }
}

namespace AccessModifiers2
{
    public class MyClass2
    {
        protected internal int n;
        MyClass2 c = new MyClass2();
        public void AccessProtectedFields()
        {
             private protected int t;
    }    
        public class MyClass3 : MyClass2
        {
            MyClass2 x = new MyClass2();
            
            MyClass3 y = new MyClass3();
            
            private void Aceess()
            {
              private int a;
            } 
        }
}

namespace AccessModifiers3
{
    public class MyClass4: MyClass2
    {
        MyClass4 z = new MyClass4();
        MyClass2 m = new MyClass2();
        MyClass3 m2 = new MyClass3();
        
        public void Axxess()
        {
            m2.AccessProtectedFields;
            m2.n;          
        }
    }
}