# CSharp_Practice
Access Modifiers - 

public:
Scope: Accessible from anywhere, both within and outside the defining assembly.
Key Points:
The most permissive access modifier.
Allows access to the type or member from any other code that can access the defining assembly.
Public members can be accessed by other assemblies or classes.


private:
Scope: Accessible only within the containing type.
Key Points:
Provides the most restricted access.
Members marked as private are accessible only from within the same class or struct.
private members are not accessible from derived types or other classes.

protected:
Scope: Accessible within the containing type and its derived types.
Key Points:
protected members are accessible from within the same class, derived classes, or classes within the same assembly.
They are not accessible from unrelated classes or instances.

internal:
Scope: Accessible within the same assembly.
Key Points:
Members with internal access modifier can be accessed by any code in the same assembly, regardless of the class.
Not accessible from outside the assembly, even from derived types.

protected internal:
Scope: Accessible within the same assembly or from derived types.
Key Points:
Combines the accessibility of both protected and internal.
Members with protected internal access modifier can be accessed from derived types, classes within the same assembly, and the same class.

Specifiers     Same Assembly      Other Assembly
              Derived   Other      Derived   Other
Public          Yes      Yes         Yes      Yes
Private         No        No          No      No
Protected       Yes       No         Yes      NO
Internal        Yes      Yes         No       No
Protected.Int    Yes      Yes        Yes      No
Private.Protect  Yes      No         No       No
