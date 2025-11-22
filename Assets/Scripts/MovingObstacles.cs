using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacles : MonoBehaviour
{
 
    [SerializeField] Transform obstacleTransform;

    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
  
        if (Input.GetKey(KeyCode.A))
            obstacleTransform.Translate(Vector3.left * speed * Time.deltaTime);   
        
        if (Input.GetKey(KeyCode.S))
            obstacleTransform.Translate(Vector3.right * speed * Time.deltaTime);
        
         if (Input.GetKey(KeyCode.Space))
            speed = 8f;
        else 
            speed = 3f; 
    }
}
