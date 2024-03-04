using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    private Rigidbody RB;
    public GameObject bus_body_art;

    public Transform Wheel1;
    public Transform Wheel2;
    public Transform Wheel3;
    public Transform Wheel4;

    public Transform Right;
    public Transform Left;
    public Transform Straight;

    
    
    void Start()
    {
        RB = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w")) {
            RB.velocity += transform.forward * 150 * Time.deltaTime;

            Wheel1.Rotate(-500, 0, 0 * Time.deltaTime);
            Wheel2.Rotate(-500, 0, 0 * Time.deltaTime);
            Wheel3.Rotate(500, 0,0 * Time.deltaTime);
            Wheel4.Rotate(500, 0,0 * Time.deltaTime);

        }

        if (Input.GetKey("s")) {
            RB.velocity -= transform.forward * 80 * Time.deltaTime;

            Wheel1.Rotate(500,0, 0* Time.deltaTime);
            Wheel2.Rotate(500,0, 0* Time.deltaTime);
            Wheel3.Rotate(-500, 0, 0 * Time.deltaTime);
            Wheel4.Rotate(-500, 0,  0* Time.deltaTime);

        }

        if (Input.GetKey("a") && Input.GetKey("w")) {
            transform.Rotate(0, -30 * Time.deltaTime, 0);
            bus_body_art.transform.rotation = Quaternion.Lerp(bus_body_art.transform.rotation, Left.rotation, 4 * Time.deltaTime);
            RB.velocity += bus_body_art.transform.forward * 120 * Time.deltaTime;
            RB.velocity -= transform.forward * 110 * Time.deltaTime;
        }


        if (Input.GetKey("d") && Input.GetKey("w")) {
            transform.Rotate(0, 30 * Time.deltaTime, 0);
            bus_body_art.transform.rotation = Quaternion.Lerp(bus_body_art.transform.rotation, Right.rotation, 4 * Time.deltaTime);
            RB.velocity += bus_body_art.transform.forward * 120 * Time.deltaTime;
            RB.velocity -= transform.forward * 110 * Time.deltaTime;
        }

        if (Input.GetKey("s") && Input.GetKey("d")) {
            transform.Rotate(0, -30 * Time.deltaTime, 0);
            bus_body_art.transform.rotation = Quaternion.Lerp(bus_body_art.transform.rotation, Left.rotation, 4 * Time.deltaTime);
            RB.velocity -= bus_body_art.transform.forward * 80 * Time.deltaTime; 
        }

        if (Input.GetKey("s") && Input.GetKey("a")) {
            transform.Rotate(0, 30 * Time.deltaTime, 0);
            bus_body_art.transform.rotation = Quaternion.Lerp(bus_body_art.transform.rotation, Right.rotation, 4 * Time.deltaTime);
            RB.velocity -= bus_body_art.transform.forward * 80 * Time.deltaTime; 
        }


        if (!Input.GetKey("d") && !Input.GetKey("a")) {
            bus_body_art.transform.rotation = Quaternion.Lerp(bus_body_art.transform.rotation, Straight.rotation, 4 * Time.deltaTime);

        }


    }
}
