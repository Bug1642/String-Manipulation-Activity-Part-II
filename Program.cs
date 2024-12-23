using System;
namespace LengthExercise {
    public class Strings {
        public bool doesLengthMatch(string source, int count) {
           bool lengthMatches = source.Length == count;
            return lengthMatches;
        }
    }
    class Program{
        static void Main( string [] args ){
            Strings match = new Strings();
            Console.WriteLine(match.doesLengthMatch("a",1));
            Console.WriteLine(match.doesLengthMatch("abc",1));
        }
    }
}