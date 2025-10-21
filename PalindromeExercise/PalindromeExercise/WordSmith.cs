using System;
namespace PalindromeExercise;

public class WordSmith
{
    public static bool IsAPalindrome(string word)
    {
        //reverse the word racecar length --> 7 ----> 6
        var reversed = "";
            
        for (int i = word.Length - 1; i >= 0; i--)
        {
            reversed += word[i];
        }
            //compare original with the reversed
        if (reversed == word)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}