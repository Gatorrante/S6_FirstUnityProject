using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPersonaje : MonoBehaviour
{
    public float velocidadMovimiento;

    public Transform detectorSuelo;
    bool tocandoSuelo;
    public float fuerzaSalto;
    public LayerMask suelo;
    public float rangoSuelo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float controlHorizontal=Input.GetAxis("Horizontal");
        GetComponent<Rigidbody2D>().velocity=new Vector3(
            controlHorizontal*velocidadMovimiento,GetComponent<Rigidbody2D>().velocity.y);


        tocandoSuelo=Physics2D.OverlapCircle(detectorSuelo.position, rangoSuelo, suelo);
        if(tocandoSuelo) {
            GetComponent<Rigidbody2D>().velocity=new Vector2(0,0);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, fuerzaSalto));


        }
    }
}
