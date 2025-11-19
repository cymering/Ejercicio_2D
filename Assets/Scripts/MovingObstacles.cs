using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacles : MonoBehaviour
{
    [SerializeField] float obstacleSpeed = 0.5f;
    [SerializeField] Transform obstacleTransform;

    int veces = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (veces < 150)
        {
            obstacleTransform.Translate(Vector3.left * obstacleSpeed * Time.deltaTime);
            veces++;
        }
        else if (veces >= 150 && veces < 300)
        {
            obstacleTransform.Translate(Vector3.right * obstacleSpeed * Time.deltaTime);
            veces++;
        }
        else
        {
            veces = 0;
        }

    }
}
