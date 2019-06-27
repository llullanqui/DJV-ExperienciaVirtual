using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCaja : MonoBehaviour
{
    public BoxCollider2D collider;
    public Rigidbody2D rb;
    public float torqueSpeed;
    public float movementSpeed;
    public bool isSobreSuelo;
    public float gravityStrength;
    // Start is called before the first frame update
    private float velocidadTorque;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        collider = GetComponent<BoxCollider2D>();
        isSobreSuelo = true;
        velocidadTorque = 65;
    }

    void Update() {
        Vector2 gravityObject = new Vector2(0, gravityStrength);
        Physics.gravity = gravityObject;

        if (Input.GetKey(KeyCode.RightArrow)){
            if(isSobreSuelo) torqueSpeed = -velocidadTorque;
            movementSpeed = (float)2;
        } else if (Input.GetKey(KeyCode.LeftArrow)) {
            if(isSobreSuelo) torqueSpeed = velocidadTorque;
            movementSpeed = (float)-2;
        } else {
            torqueSpeed = 0;
            movementSpeed = 0;
        }

        if (Input.GetKey(KeyCode.UpArrow) && isSobreSuelo) {
            saltar();
        }
    }

    void FixedUpdate()
    {
        rb.AddTorque (torqueSpeed, ForceMode2D.Force);
        rb.AddForce (new Vector2(movementSpeed,0),ForceMode2D.Impulse);
    }

    void saltar() {
        rb.AddForce(new Vector2(0,50), ForceMode2D.Impulse);
        isSobreSuelo = false;
    }

    void OnCollisionEnter2D(Collision2D col) {
        if(col.gameObject.tag == "Suelo") {
            isSobreSuelo = true;
        }
    }
}
