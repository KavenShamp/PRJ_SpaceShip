using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class misile : MonoBehaviour
{
    private float vel;
    public Vector3 dist;
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        vel = 90F;
      
    }

    // Update is called once per frame
    void Update()

    {

        dist = dist.normalized;
        this.transform.Translate(0, dist.y*Time.deltaTime, vel * Time.deltaTime);
        if (this.transform.position.x > 191)
        {
           Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.tag=="Turret"){
            GetComponent<MeshRenderer>().enabled = false;
            vel = 0;
            Destroy(col.gameObject);    
            explosion.SetActive(true);
            explosion.GetComponent<ParticleSystem>().Play();
     
            Invoke("destruir", 2f);
            
        }
        
    }

    private void destruir()
    {
        Destroy (gameObject);
    }
    
  
}
