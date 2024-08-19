using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerChecker : MonoBehaviour
{
    int index;
    private void Start()
    {
        index = 0;
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("SomeOne Has Entered.");
        index++;
        Debug.Log($"index : {index}");
    }

    private void OnTriggerExit(Collider other)
    {
        
        
            index--;
            if(index <= 0) Debug.Log("EveryOne Has gone!");
            Debug.Log($"index : {index}");
            
        
    
        
    }
  
}
