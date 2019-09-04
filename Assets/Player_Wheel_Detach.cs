using ModuloKart.CustomVehiclePhysics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Wheel_Detach : MonoBehaviour
{
    public Transform spawnpoint;// setPoint;
    public GameObject prefab1;
    public Camera cam_p1;
    VehicleBehavior vehicleBehavior;
    public int speed,count=0;
    public GameObject wheel_destroy;

    // Start is called before the first frame update

    void Start()
    {
        //prefab1.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("B_P1") && count==0)
        {
            count++;
            GameObject Wheel = Instantiate(prefab1) as GameObject;
            Wheel.transform.position = spawnpoint.transform.position;
            Rigidbody rb = Wheel.GetComponent<Rigidbody>();
            rb.velocity = cam_p1.transform.forward * -speed;
          
            wheel_destroy.SetActive(false);
            
            //Destroy(prefab1);
            ///Destroy(wheel_destroy);
        }
        //prefab1.SetActive(false);
    }
}
