using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalindromeSorter : MonoBehaviour
{
    string resultedPalindrome;
    string expectedPalindrome = "RGYYGR";
    int i, j;
    
    private void Start()
    {
        resultedPalindrome = "";
    }

    private void OnTriggerEnter(Collider other)
    {
        string color = other.GetComponent<ColoredCube>().colorValue();
        Debug.Log($"colour {color}");
        
        resultedPalindrome += color;

        Debug.Log($"{resultedPalindrome}");
        if (PalindromeChecker(resultedPalindrome)) Debug.Log("Palindrome");
        //else Debug.Log("Not Palindrome");

    }
    bool PalindromeChecker(string resultedPalindrome)
    {
        var isPalindrome = true;
        i = 0;
        j = resultedPalindrome.Length - 1;
        while (i <= j)
        {
            
            if (resultedPalindrome[i] != resultedPalindrome[j])
            {
               isPalindrome = false;
                return isPalindrome;
            }
            i++;
            j--;
        }
        return isPalindrome;
    }
}
