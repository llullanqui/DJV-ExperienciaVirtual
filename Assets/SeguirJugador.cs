using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirJugador : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (-13 <= (float)player.transform.position.x & (float)player.transform.position.x < 8) {
            transform.position = new Vector3(0,transform.position.y,transform.position.z);
        } else if (8 <= (float)player.transform.position.x & (float)player.transform.position.x < 28) {
            transform.position = new Vector3(20,transform.position.y,transform.position.z);
        } else if (28 <= (float)player.transform.position.x & (float)player.transform.position.x < 48) {
            transform.position = new Vector3(40,transform.position.y,transform.position.z);
        } else if (48 <= (float)player.transform.position.x & (float)player.transform.position.x < 68) {
            transform.position = new Vector3(60,transform.position.y,transform.position.z);
        } else if (68 <= (float)player.transform.position.x & (float)player.transform.position.x < 88) {
            transform.position = new Vector3(80,transform.position.y,transform.position.z);
        } else if (88 <= (float)player.transform.position.x & (float)player.transform.position.x < 108) {
            transform.position = new Vector3(100,transform.position.y,transform.position.z);
        } 
    }
}
