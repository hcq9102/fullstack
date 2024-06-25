### Assignment1 _ part 1
01 Introduction to C# and Data Types

Understanding Data Types

Test your Knowledge

1. What type would you choose for the following “numbers”?
   
          ANS: 
          1)	A person’s telephone number
          string
          2)	A person’s height
          float or double
          3)	A person’s age
          int
          4)	A person’s gender (Male, Female, Prefer Not To Answer)
          enum:
          public enum Gender{Male, Female, Prefer Not To Answer}
          5)	A person’s salary
          decimal
          6)	A book’s ISBN
          string
          7)	A book’s price
          decimal
          8)	A book’s shipping weight
          float or double
          9)	A country’s population
          long
          10)	The number of stars in the universe
          ulong, eg. 90000000000UL
          11)	The number of employees in each of the small or medium businesses in the
          United Kingdom (up to about 50,000 employees per business)
           int
3. What are the difference between value type and reference type variables? What is
boxing and unboxing?

        ANS: 
        value type vs. reference type variables：
        1)	Value type will directly hold the value while reference type will hold the memory address or reference for the value. 
        2)	Value types are stored in stack memory and reference types are stored in heap memory. 
        3)	Value type will not be collected by garbage collector but reference type will be collected by garbage collector. 
        4)	The value type can be created by struct or enum while reference type can be created by class, interface, delegate or array.
        5)	Value type can not accept any null values while reference types can accept null values.

        boxing and unboxing:
     
              Boxing is conversion of value type to reference type and unboxing is conversion of reference type to value type.

3. What is meant by the terms managed resource and unmanaged resource in .NET?
   
        ANS: 
        Managed resources are those that the .NET garbage collector automatically handles. They are those that are pure .NET code and managed by the runtime and are under its direct control.
        Unmanaged resources are not managed by the .NET garbage collector. These include resources like file handles, database connections, network sockets, graphics handles, or any other resource that the operating system provides. 


5. Whats the purpose of Garbage Collector in .NET?
   
        ANS: 
        In the common language runtime (CLR), the garbage collector (GC) serves as an automatic memory manager.
        The garbage collector manages the allocation and release of memory for an application.

### Assignment1 _ part 2

Controlling Flow and Converting Types

Test your Knowledge

1. What happens when you divide an int variable by 0?
   
        It will throw error message: “Division by constant zero”.
  
2. What happens when you divide a double variable by 0?
   
        It will return either positive or negative infinity, depending on the sign of the dividend.

3. What happens when you overflow an int variable, that is, set it to a value beyond its range?
   
        Overflowing an int variable in C# will result in the value wrapping around to the opposite end of the range.
        For example, if I add a small integer(1) to int.MaxValue, it will overflow and output int.MinValue.
4. What is the difference between x = y++; and x = ++y;?
   
        x = y++; is a post-increment operation, meaning the value of y is assigned to x first, and then y is incremented.
        x = ++y; is a pre-increment operation, meaning y is incremented first, and then its value is assigned to x.

5. What is the difference between break, continue, and return when used inside a loop statement?

        For C#, break is used to exit the loop immediately, continue skips the rest of the loop's code block and moves to the next iteration, while return exits the entire method, not just the loop.

6. What are the three parts of a for statement and which of them are required?

        The three parts of a for statement are initialization, condition, and iteration. Note, the condition part is required.
   
7. What is the difference between the = and == operators?
    
        The = operator is the assignment operator, used to assign a value to a variable.
        The == operator is the equality operator, used to check if two expressions’ equality.
    
8. Does the following statement compile? for ( ; true; ) ;
    
        Yes, the statement for ( ; true; ) ; will compile. It is an infinite loop because of true clause.
        And there is no condition to get out of the loop.

9. What does the underscore _ represent in a switch expression?
    
        the underscore represents a discard, meaning it matches any value and does nothing.
        It is useful when we want to ignore the value of a particular case.

10. What interface must an object implement to be enumerated over by using the foreach statement?
    
        The IEnumerable interface permits enumeration by using a foreach loop.
        This means that an object must implement the IEnumerable interface or one of its derived interfaces (IEnumerable<T>, IQueryable<T>, ....) to be enumerated over using the foreach statement in C#.


