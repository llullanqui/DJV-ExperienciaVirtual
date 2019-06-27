using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCaja : MonoBehaviour
{

    public Rigidbody2D rb;
    public float torqueSpeed;
    public float movementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() {
        if (Input.GetKey(KeyCode.RightArrow)){
            torqueSpeed = -15;
            movementSpeed = (float)0.3;
        } else if (Input.GetKey(KeyCode.LeftArrow)) {
            torqueSpeed = 15;
            movementSpeed = (float)-0.3;
        } else {
            torqueSpeed = 0;
            movementSpeed = 0;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            rb.AddForce(new Vector2(0,10), ForceMode2D.Impulse);
        }
    }

    void FixedUpdate()
    {
        rb.AddTorque (torqueSpeed, ForceMode2D.Force);
        rb.AddForce (new Vector2(movementSpeed,0),ForceMode2D.Impulse);
    }

}
