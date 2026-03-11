using System;

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

        }
    }
}
