using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using JetBrains.Annotations;
using UnityEngine;

public class Targets : MonoBehaviour
{
    [SerializeField] GameObject target;
    public AudioSource sonido;
    public AudioClip clip;
    
    
        // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Colision con target " + target.name  );
        sonido.PlayOneShot(clip);   
       
    }   
}
