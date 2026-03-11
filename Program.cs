using System;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;

namespace G_NET_27_OOP_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            // Abstraction is the process of exposing only what the user needs and hiding how it is implemented.
            // Focus on what the object does not how it does it .

            //Abstraction: Focus What an object does & Hide Implementation , Encapsulation : Focus on How Can Protected data.
            //
            // Abstraction
            // Coffee Machine 
            // — What you can do (don't care how it works internally)
            // Press the coffee button
            // Choose the size (small, medium, large)
            // Add sugar
            // Collect your coffee

            // What you don't care about
            // How the water heating system works
            // How the beans are ground
            // How the pressure pump operates

            //Encapsulation 
            // Water level and beans are private

            #endregion

            #region Q2
            //                                Abstract Class    VS     Interface 
            // Multiple inheritance needed        (✔)                  (❌)
            // Loose coupling / extensibility     (✔)                  (❌)
            // Shared implementation required     (❌)                  (✔)
            // Represents an "is-a" hierarchy     (❌)                  (✔)
            // Has constructors / fields          (❌)                  (✔)

            //When use Abstraction 
            // Behavior may change
            // Multiple implementations
            // Loose coupling needed
            // Testability

            // When to use interface
            // You need multiple inheritance.
            // You want to define a pure contract with no shared state.
            // Unrelated classes need to share behaviour.

            #endregion

            #region Q3
            //  (a)   No, because an object cannot be created from an abstract class.
            //  (b)
            // PowerConsumption() => type of Abstract method , you must make Override to it impelr=ementation, because
            //  it has return type and access modifier (public).
            // Status() => type of dynamic Polyemorphism . you can make Override or ont as you like .
            // Label() => is a concrete method , when you inherits the class ,the child can't modify it.

            // (c)  Toaster toasr = new Toaster("Mvg")
            // toasr.Status(); ====>  Standby 
            // Because that object cannot perform An Override in the inherits method, and inherits the impelementation in the Parent.

            #endregion

            #region Q4
            //(A) =>
            // A partial class allows you to split a single class definition across multiple files,
            // And the Compiler merge them.
            // Why to used 
            //  Organize large classes=>Split properties, methods, events into separate files.
            // Allow multiple developers work on the same class .
            // Tools auto-generate one file, you customize in another

            // (B) =>
            //  A partial method is declared in one part of a partial class and optionally implemented in another part.
            // Yes, the code will still compile. Because OnCalculated() is a partial method — if the implementation is deleted,
            // the compiler automatically removes the call to it with no errors.

            // (C) => 
            // An extension method lets you add new methods to an existing type without modifying its source code.
            // The class must be static
            // The method must be static
            // The first parameter must use the this keyword followed by the type you're extending.


            //(D)=>

            // Calculator calc = new Calculator();
            //double result = calc.Add(19.5, 0.5);
            //Console.WriteLine(result.ToCurrency()); ===>
            //the output ...>
            // Log : Result = 20 
            // $20.00


            #endregion
        }
    }
}
