using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    Rigidbody ballRB;
    public float thrust = 200f;

    public Transform originalObject;
    public List<GameObject> Walls = new List<GameObject>();
    int index;

    void Start()
    {
        ballRB = GetComponent<Rigidbody>();
        originalObject = transform;
        index = 0;
    }

    void Update()
    {
        
       
    }

    void OnCollisionEnter(Collision collision)
    {
       
        transform.position = Vector3.Reflect(originalObject.transform.position, Vector3.right);
        ballRB.AddForce(-transform.position * thrust, ForceMode.Force);
    }
}
