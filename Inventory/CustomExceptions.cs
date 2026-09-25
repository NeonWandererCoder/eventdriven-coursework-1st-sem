using System;

// custom exception for an invalid product name (fails the letters-only check)
public class StringFormatException : Exception
{
    public StringFormatException(string message) : base(message) { }
}

// custom exception for an invalid quantity (fails the numbers-only check)
public class NumberFormatException : Exception
{
    public NumberFormatException(string message) : base(message) { }
}

// custom exception for an invalid selling price (fails the currency format check)
public class CurrencyFormatException : Exception
{
    public CurrencyFormatException(string message) : base(message) { }
}