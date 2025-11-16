using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_actions : MonoBehaviour
{
    [SerializeField] Transform transformDelObjeto;

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
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = Camera.main.WorldToScreenPoint(transformDelObjeto.position).z;
            transformDelObjeto.position = Camera.main.ScreenToWorldPoint(mousePos);
        }
    }
}
