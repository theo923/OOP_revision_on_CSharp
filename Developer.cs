using System;
public abstract class Developer
{
    //Encapsulation - show info that user needs, otherwise hide it
    protected string _firstname;
    protected string _lastname;

    protected string Fullname
    {
        get
        {
            return String.Format("{0} {1}", this._firstname, this._lastname);
        }
    }

    public Developer(string firstname, string lastname)
    {
        this._firstname = firstname;
        this._lastname = lastname;
    }

    // Polymorphism - allow child to perform function differently (with different no. of parameters)
    public virtual void Code()
    {
        Console.WriteLine("I'm {0} {1}, A Developer", this._firstname, this._lastname);
    }

}