using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10f;
    private float turnSpeed=25.0f;
    private float horizonInput;
    private float forwardInput;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizonInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward*Time.deltaTime*speed*forwardInput); // dikey olarak arabayý ileri hareket ettirir
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed*horizonInput); // yaaaataay olarakk arabayý sað sol hareket ettirir.

                                          
    }
}
