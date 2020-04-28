using System;
using System.Reflection.Metadata.Ecma335;

namespace BeerSong
{
    public static class BeerSong
    {
        public static string Recite(int startBottles, int takeDown)
        {
            var verse = FirstVerse(startBottles) + LastVerse(startBottles);
            return verse;
        }

        private static string FirstVerse(int startBottles)
        {
            return $"{startBottles} bottles of beer on the wall, {startBottles} bottles of beer.\n";
        }

        private static string LastVerse(int startBottles)
        {
            return $"Take one down and pass it around, {startBottles - 1} bottles of beer on the wall.";
        }
    }
}