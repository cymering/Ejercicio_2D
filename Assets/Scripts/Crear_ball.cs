using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;

public class Crear_ball : MonoBehaviour
{
    [SerializeField] public GameObject[] ball; 
     public AudioSource sonido; 
     public AudioClip clip;
    
    //public float x;


    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0; // IMPORTANTE! Asegurarse de que la posición z sea 0 para objetos 2D
            
            //x += 0.5f * Time.deltaTime;
            //Instantiate(ball[0],  new Vector3(x, 5, 0), Quaternion.identity);  
            //Instantiate(ball[0],  mousePosition, Quaternion.identity);  

            //Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            Instantiate(ball[0], mousePosition, Quaternion.identity);

            sonido.PlayOneShot(clip);   
        }
        
    }

    void OnCollisionEnter(Collision collision)
    {
        UnityEngine.Debug.Log("Colisión con la bola");
        //sonido.PlayOneShot(clip);
    }

}
