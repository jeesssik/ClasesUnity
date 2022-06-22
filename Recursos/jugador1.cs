using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jugador1 : MonoBehaviour
{
    public float velocidadMovimiento=10f;
    Vector3 input;
    Rigidbody rb;
    Vector3 posInicial;
    public GameObject prefabParticulas;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        posInicial=transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        input=new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        //Debug.Log(input);
        rb.AddForce(input * velocidadMovimiento);
        if(transform.position.y<-5){
            ReAparecer();
        }
    }

    void ReAparecer(){
        transform.position = posInicial;
        //Instantiate(prefabParticulas,transform.position,transform.rotation);
    }

    void OnTriggerEnter(Collider col){
        if(col.gameObject.tag=="meta"){
            //Niveles.CambiarNiveles();}
            Debug.Log("TOCOO");

        }
         if(col.gameObject.tag=="obstaculo"){
             Debug.Log("Chocaste la meta");
             ReAparecer();
        }
    }
}
