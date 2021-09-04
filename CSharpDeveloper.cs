using System;
namespace OOP
{
    //Inheritance - inherit class's characteristic to its child
    public class CSharpDeveloper : Developer
    {
        public CSharpDeveloper(string firstname, string lastname) : base(firstname, lastname)
        {
        }

        public override void Code()
        {
            Console.WriteLine("I am {0} {1}, A C# Developer", this._firstname, this._lastname);
        }
    }
}