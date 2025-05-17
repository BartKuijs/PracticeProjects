
// \n is an enter
Console.WriteLine(@"This happens with a \n in a line.");
Console.WriteLine("This happens with a \n in a line.");
Console.WriteLine("----------------------------------- \n");

// \t is a tab
Console.WriteLine(@"This happens with a \t in a line.");
Console.WriteLine("This happens with a \t in a line.");
Console.WriteLine("----------------------------------- \n");

// \' is a single quote '
Console.WriteLine(@"This happens with a \' in a line.");
Console.WriteLine("This happens with a \' in a line.");
Console.WriteLine("----------------------------------- \n");

// \" needed for string literals so it will write the "
Console.WriteLine(@"This happens with a (\double quote) in a line.");
Console.WriteLine("This happens with a \" in a line.");
Console.WriteLine("----------------------------------- \n");

// \\ writes a \
Console.WriteLine(@"This happens with a \\ in a line.");
Console.WriteLine("This happens with a \\ in a line.");
Console.WriteLine("----------------------------------- \n");

// \0 is the unicode 0 or null character and will not have any information.
Console.WriteLine(@"This happens with a (\0 / Null character) in a line.");
Console.WriteLine("This happens with a \0 in a line.");
Console.WriteLine("----------------------------------- \n");

// \b is a backspace
Console.WriteLine(@"This happens with a \b\b\b\b in a line.");
Console.WriteLine("This happens with a \b\b\b\b in a line.");
Console.WriteLine("----------------------------------- \n");

// \f is a form feed. ???
Console.WriteLine(@"This happens with a \f in a line.");
Console.WriteLine("This happens with a \f in a line.");
Console.WriteLine("----------------------------------- \n");

// \r returns the characters after \r to the beginning of the string
Console.WriteLine(@"This happens with a \r in a line.");
Console.WriteLine("This happens with a \r in a line.");
Console.WriteLine("----------------------------------- \n");

// \v is a vertical tab
Console.WriteLine(@"This happens with a \v in a line.");
Console.WriteLine("This happens with a \v in a line.");
Console.WriteLine("----------------------------------- \n");

// \uxxxx where xxxx is a unicode character.
Console.WriteLine(@"This happens with a \u1234 in a line. (1234 is unicode)");
Console.WriteLine("This happens with a \u1234 in a line.");


