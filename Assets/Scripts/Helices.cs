using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Helices : MonoBehaviour
{   [SerializeField] private GameObject helixPrefab;
    public AudioSource sonido;
    public AudioClip clip;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        helixPrefab.transform.Rotate(0, 0, 50 * Time.deltaTime);
       
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Colision con helices");
        sonido.PlayOneShot(clip);   
       
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, 1f);  
    }
}
