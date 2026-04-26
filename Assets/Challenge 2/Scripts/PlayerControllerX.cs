using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    int c = 100;
    // Update is called once per frame
    void Update()
    {
        
        // On spacebar press, send dog
        if(c >= 100)
        {
           if (Input.GetKeyDown(KeyCode.Space))
           {
               Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
               c=0;
           }
        }
        c++;
    }
}
