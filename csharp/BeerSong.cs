using System;
using System.Collections.Generic;

namespace BeerSong
{
    public static class BeerSong
    {
        public static string Recite(int startBottles, int takeDown)
        {
            var allVerses = new List<string>();
            var bottleCount = startBottles;
            for (int verseCount = takeDown; verseCount > 0; verseCount--)
            {
                var newlineChar = "\n";

                if (bottleCount >= 0)
                {
                    allVerses.Add(FirstVerse(bottleCount));
                    allVerses.Add(newlineChar);
                    allVerses.Add(LastVerse(bottleCount));
                    bottleCount--;
                    if (verseCount > 1)
                    {
                        allVerses.Add(newlineChar);
                        allVerses.Add(newlineChar);
                    }
                    else if (verseCount == 0)
                    {
                        allVerses.Add(newlineChar);
                    }
                }
            }
            return String.Join("", allVerses.ToArray());
        }

        private static string FirstVerse(int bottleCount)
        {
            return bottleCount switch
            {
                0 => "No more bottles of beer on the wall, no more bottles of beer.",
                1 => $"{bottleCount} bottle of beer on the wall, {bottleCount} bottle of beer.",
                _ => $"{bottleCount} bottles of beer on the wall, {bottleCount} bottles of beer."
            };
        }

        private static string LastVerse(int bottleCount)
        {
            return bottleCount switch
            {
                0 => "Go to the store and buy some more, 99 bottles of beer on the wall.",
                1 => "Take it down and pass it around, no more bottles of beer on the wall.",
                2 => $"Take one down and pass it around, {bottleCount - 1} bottle of beer on the wall.",
                _ => $"Take one down and pass it around, {bottleCount - 1} bottles of beer on the wall.",
            };
        }
    }
}