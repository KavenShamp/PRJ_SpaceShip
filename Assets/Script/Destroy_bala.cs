using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_bala : MonoBehaviour
{
 
    void Update()
    {
        if (this.transform.position.x <45)
        {
            Destroy(gameObject);
        }
        if (this.transform.position.x >200)
        {
            Destroy(gameObject);
        }
        if (this.transform.position.z < 60)
        {
            Destroy(gameObject);
        }
        if (this.transform.position.z > 172)
        {
            Destroy(gameObject);
        }
       
        
    }
}
