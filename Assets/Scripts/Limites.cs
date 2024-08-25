using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limites : MonoBehaviour
{
    public GameObject Borde1;
    public GameObject Borde2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x>Borde1.transform.position.x) { //Si la posición en X de mi personaje es mayor que el Borde1

        this.transform.position = new Vector3(Borde2.transform.position.x,
        this.transform.position.y, this.transform.position.z);
//Mueva a la posicion del Borde2
    }
        if(this.transform.position.x<Borde2.transform.position.x)//Si la posiciónen X de mi personaje es menor que el Borde2
{
            this.transform.position = new Vector3(Borde1.transform.position.x,
            this.transform.position.y, this.transform.position.z);
}
 
    }
}