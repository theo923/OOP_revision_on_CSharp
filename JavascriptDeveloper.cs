using System;
namespace OOP
{
    //Inheritance - inherit class's characteristic to its child
    public class JavascriptDeveloper : Developer
    {
        public JavascriptDeveloper(string firstname, string lastname) : base(firstname, lastname)
        {
        }

        public override void Code()
        {
            Console.WriteLine("I am {0} {1}, A JavaScript Developer", this._firstname, this._lastname);
        }

    }
}