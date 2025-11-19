using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helices : MonoBehaviour
{   [SerializeField] private GameObject helixPrefab;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        helixPrefab.transform.Rotate(0, 0, 50 * Time.deltaTime);
    }
}
