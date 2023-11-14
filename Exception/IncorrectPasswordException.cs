using System;
namespace userclass.Exceptions;

public class IncorectPasswordException : Exception
{
    public IncorectPasswordException(string message):base(message)
    {

    }
}



