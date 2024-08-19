using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swap : MonoBehaviour
{
    public int a;
    public int b;
    void Start()
    {
        a = 5;
        b = 6;
        Debug.Log($"Before swapping : a = {a} and b = {b}.");
        SwapFunction( a, b );
    }
    void SwapFunction(int a, int b)
    {
        a = a * b;
        b = a / b;
        a = a / b;
        Debug.Log($"After swapping : a = {a} and b = {b}.");
    }


}
