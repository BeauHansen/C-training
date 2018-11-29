using System;

namespace csharpbasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // local variables and types
            int x = 0;
            double y = 4.58; // (allows decimal - 64 bit float)
            decimal z = 5.001m; // even more precision - for financial etc... remember to suffix wiht 'm'

            string s = "string";
            bool b = true; // can take 'true' or 'false'
            b = false;

            // base class of *everything* - object
            object o = true;

            // var (compiler type inference)

            var xyz = "Hello";
            var b1 = true;
           // xyz = false; // error! no dymanic typing

            // use var when the field type is clear to the person reading the code
            // don;t use it when it obscures useful context.

            // control structures
            // loops
            for (var i = 0; i < 10; i++) 
            {
                Console.WriteLine(i);
            }

            while (false)
            {
                // while loop
            }

            do
            {
                // while loop
            } while (false);

            if (true)
            {
                // if
            }
            else if (false)
            {
                // else if
            }
            else
            {
                // else
            }

            // List is a class defined in another namespace
            //threfore it needs a"using statement" at the top of the file
            // (like an import in other language)
            System.Collections.Generic.List<string> list = new List<string>();
            list.Add("string example");

            // snippet: foreach
            foreach (var item in list)
            {
                // snippet: cw
                Console.WriteLine(item;);
            }

            // object-oriented
            //      have objects which assaciate data and related behavior
            //      to represent "entites/nouns"
            //      create those objects from templates called 'classes'
            //      which define a contract for hose objects at runtime.

            // part of the .NET ecosystem/platform

            // strongly typed (more precise, statically typed)
            // statically typed means, variables are locked
            //      to a certain type at compile time and cannot change.

            // unified type system
            //      "primitives" (types with valuesemantices instead of reference semantics)
            //      *also* inherit from object.

            // garbage-collection language
            // "managed language" (memory is managed for you)
            // the runtime is responsible for freeing unused objects from memory
            // Saves developer time, fewer bugs, some performance penalty.

            // functions are not quite first-class but in practice
            //      more-or-less.
            // c sharp is somewhat functional, especially inpractice with
            //      LINQ (one of the best parts or C#)
            //      (Language-Integrated Query Language)

            // asynchronous programming support with TPL (Task PRocessing Library)
            // exception handling

        }
    }
}
