using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Crear_ball : MonoBehaviour
{
    [SerializeField] public GameObject ball; 
    
    [Serialize] public Vector3 mousePosition;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Left Click");
            mousePosition = Input.mousePosition;
            Instantiate(ball, mousePosition, UnityEngine.Quaternion.identity);
        }
    }

   
}
