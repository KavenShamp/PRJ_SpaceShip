using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mover_player : MonoBehaviour
{
    private float vel;
    public GameObject misile;
    private Vector3 pos_misile;
    public BoxCollider coll_ship;
    public Slider life;
    // Start is called before the first frame update
    void Start()
    {
        vel = 30f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Input.GetAxis("Vertical")*Time.deltaTime*vel*2, 0,   Input.GetAxis("Horizontal")* Time.deltaTime*vel);

        if (Input.GetMouseButtonDown(0))
        {
            Disparo();
        }
    }

    void Disparo()
    {
        pos_misile =new Vector3( transform.position.x+coll_ship.size.z,transform.position.y,transform.position.z);//calcular posisiotn con starSparrow_core
        
        Instantiate(misile, pos_misile,transform.rotation);
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("bala"))
        {
            
            life.value -= col.GetComponent<stats_bala>().Damage;
            
        }
    }
}
