using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCaja : MonoBehaviour
{

    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Mover();
    }

    void FixedUpdate()
    {
        
    }

    void Mover()
    {
        rb.MovePosition(transform.position + transform.forward * Time.deltaTime);
    }
}
