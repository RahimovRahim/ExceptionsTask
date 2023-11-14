﻿using System.Runtime.Serialization;

[Serializable]
internal class IncorrectPasswordException : Exception
{
    public IncorrectPasswordException()
    {
    }

    public IncorrectPasswordException(string? message) : base(message)
    {
    }

    public IncorrectPasswordException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected IncorrectPasswordException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}