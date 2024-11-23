using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubecode : MonoBehaviour
{
  

    
    public float rotationSpeed = 50f;    
    public float moveSpeed = 5f;         
    public float moveDistance = 3f;      

    private Vector3 startPosition;

    void Start()
    {
       
        startPosition = transform.position;
    }

    void Update()
    {
        
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
        float movement = Mathf.Sin(Time.time * moveSpeed) * moveDistance;
        transform.position = new Vector3(startPosition.x, startPosition.y, startPosition.z + movement);
    }
}
