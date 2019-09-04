using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ModuloKart.CustomVehiclePhysics;

public class ui_controller : MonoBehaviour
{
    GameObject[] ui_item;
    int item_selected;
   
    bool has_door_1 = true;
    bool has_door_2 = true;
    bool has_tire_1 = true;
    bool has_tire_2 = true;
    bool has_tire_3 = true;
    bool has_tire_4 = true;
    bool has_hood = true;
    public int playerNum;
    public GameObject vechicle;


    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.tag == "Player1")
            playerNum = 1;
        else if (gameObject.tag == "Player2")
            playerNum = 2;
        else if (gameObject.tag == "Player3")
            playerNum = 3;
        else if (gameObject.tag == "Player4")
            playerNum = 4;

        item_selected = 0;
        ui_item = new GameObject[7];
        int i = 0;

        while (i < 7)
        {
            ui_item[i] = gameObject.transform.GetChild(i).gameObject;
            if (ui_item[i] == null)
                throw new System.Exception("ui_item " + i + " not set");
            i++;
        }

       


        


    }

    // Update is called once per frame
    void Update()
    {
        if(vechicle.GetComponent<VehicleBehavior>().JoyStick == 1 ) {

            if (Input.GetKeyDown(KeyCode.Joystick1Button5))
            {
                // Debug.Log("before" + item_selected);
                ui_item[item_selected].transform.localScale -= new Vector3(0.5f, 0.5f);


                item_selected += 1;
                if (item_selected >= 7)
                    item_selected = 0;

                ui_item[item_selected].transform.localScale += new Vector3(0.5f, 0.5f);


                //Debug.Log("after" + item_selected);

            }
            else if (Input.GetKeyDown(KeyCode.Joystick1Button4))
            {
                ui_item[item_selected].transform.localScale -= new Vector3(0.5f, 0.5f);


                item_selected -= 1;
                if (item_selected < 0)
                    item_selected = 6;

                ui_item[item_selected].transform.localScale += new Vector3(0.5f, 0.5f);


            }

            if (Input.GetKeyDown(KeyCode.Joystick1Button2))
            {

               
                if (ui_item[item_selected].gameObject.tag == "Tire")
                {
                    if (item_selected == 0)
                    {
                        if (has_tire_1)
                        {
                            Debug.Log("used front left tire");
                            has_tire_1 = false;
                        }
                        else
                            Debug.Log("tire already used");
                    }

                    if (item_selected == 2)
                    {
                        if (has_tire_2)
                        {
                            Debug.Log("used front right tire");
                            has_tire_2 = false;
                        }
                        else
                            Debug.Log("tire already used");
                    }

                    if (item_selected == 5)
                    {
                        if (has_tire_3)
                        {
                            Debug.Log("used back left tire");
                            has_tire_3 = false;
                        }
                        else
                            Debug.Log("tire already used");
                    }

                    if (item_selected == 6)
                    {
                        if (has_tire_4)
                        {
                            Debug.Log("used back right tire");
                            has_tire_4 = false;
                        }
                        else
                            Debug.Log("tire already used");
                    }


                }
                else if (ui_item[item_selected].gameObject.tag == "Door")
                {

                    if (item_selected == 3)
                    {
                        if (has_door_1)
                        {
                            Debug.Log("used left door");
                            has_door_1 = false;
                        }
                        else
                            Debug.Log("door already used");
                    }

                    if (item_selected == 4)
                    {
                        if (has_door_2)
                        {
                            Debug.Log("used right door");
                            has_door_2 = false;
                        }
                        else
                            Debug.Log("door already used");
                    }
                }
                else if (ui_item[item_selected].gameObject.tag == "Hood")
                {
                    if (has_hood)
                    {
                        Debug.Log("used hood");
                        has_hood = false;
                        //call hood item function use here
                    }
                    else if (!has_hood)
                    {
                        Debug.Log("No hood left fool");
                        //play sound? or other notification
                    }
                }
            }

        }



        if (vechicle.GetComponent<VehicleBehavior>().JoyStick == 2) {
            if (Input.GetKeyDown(KeyCode.Joystick2Button5))
            {
                // Debug.Log("before" + item_selected);
                ui_item[item_selected].transform.localScale -= new Vector3(0.5f, 0.5f);


                item_selected += 1;
                if (item_selected >= 7)
                    item_selected = 0;

                ui_item[item_selected].transform.localScale += new Vector3(0.5f, 0.5f);


                //Debug.Log("after" + item_selected);

            }
            else if (Input.GetKeyDown(KeyCode.Joystick2Button4))
            {
                ui_item[item_selected].transform.localScale -= new Vector3(0.5f, 0.5f);


                item_selected -= 1;
                if (item_selected < 0)
                    item_selected = 6;

                ui_item[item_selected].transform.localScale += new Vector3(0.5f, 0.5f);


            }

            if (Input.GetKeyDown(KeyCode.Joystick2Button2))
            {
                Debug.Log("I am player" + playerNum);

                if (ui_item[item_selected].gameObject.tag == "Tire")
                {
                    if (item_selected == 0)
                    {
                        if (has_tire_1)
                        {
                            Debug.Log("used front left tire");
                            has_tire_1 = false;
                        }
                        else
                            Debug.Log("tire already used");
                    }

                    if (item_selected == 2)
                    {
                        if (has_tire_2)
                        {
                            Debug.Log("used front right tire");
                            has_tire_2 = false;
                        }
                        else
                            Debug.Log("tire already used");
                    }

                    if (item_selected == 5)
                    {
                        if (has_tire_3)
                        {
                            Debug.Log("used back left tire");
                            has_tire_3 = false;
                        }
                        else
                            Debug.Log("tire already used");
                    }

                    if (item_selected == 6)
                    {
                        if (has_tire_4)
                        {
                            Debug.Log("used back right tire");
                            has_tire_4 = false;
                        }
                        else
                            Debug.Log("tire already used");
                    }


                }
                else if (ui_item[item_selected].gameObject.tag == "Door")
                {

                    if (item_selected == 3)
                    {
                        if (has_door_1)
                        {
                            Debug.Log("used left door");
                            has_door_1 = false;
                        }
                        else
                            Debug.Log("door already used");
                    }

                    if (item_selected == 4)
                    {
                        if (has_door_2)
                        {
                            Debug.Log("used right door");
                            has_door_2 = false;
                        }
                        else
                            Debug.Log("door already used");
                    }
                }
                else if (ui_item[item_selected].gameObject.tag == "Hood")
                {
                    if (has_hood)
                    {
                        Debug.Log("used hood");
                        has_hood = false;
                        //call hood item function use here
                    }
                    else if (!has_hood)
                    {
                        Debug.Log("No hood left fool");
                        //play sound? or other notification
                    }
                }
            }

        }

        if (vechicle.GetComponent<VehicleBehavior>().JoyStick == 3)
        {
            if (Input.GetKeyDown(KeyCode.Joystick3Button5))
            {
                // Debug.Log("before" + item_selected);
                ui_item[item_selected].transform.localScale -= new Vector3(0.5f, 0.5f);


                item_selected += 1;
                if (item_selected >= 7)
                    item_selected = 0;

                ui_item[item_selected].transform.localScale += new Vector3(0.5f, 0.5f);


                //Debug.Log("after" + item_selected);

            }
            else if (Input.GetKeyDown(KeyCode.Joystick3Button4))
            {
                Debug.Log("I am player" + playerNum);

                ui_item[item_selected].transform.localScale -= new Vector3(0.5f, 0.5f);


                item_selected -= 1;
                if (item_selected < 0)
                    item_selected = 6;

                ui_item[item_selected].transform.localScale += new Vector3(0.5f, 0.5f);


            }

            if (Input.GetKeyDown(KeyCode.Joystick3Button2))
            {
                if (ui_item[item_selected].gameObject.tag == "Tire")
                {
                    if (item_selected == 0)
                    {
                        if (has_tire_1)
                        {
                            Debug.Log("used front left tire");
                            has_tire_1 = false;
                        }
                        else
                            Debug.Log("tire already used");
                    }

                    if (item_selected == 2)
                    {
                        if (has_tire_2)
                        {
                            Debug.Log("used front right tire");
                            has_tire_2 = false;
                        }
                        else
                            Debug.Log("tire already used");
                    }

                    if (item_selected == 5)
                    {
                        if (has_tire_3)
                        {
                            Debug.Log("used back left tire");
                            has_tire_3 = false;
                        }
                        else
                            Debug.Log("tire already used");
                    }

                    if (item_selected == 6)
                    {
                        if (has_tire_4)
                        {
                            Debug.Log("used back right tire");
                            has_tire_4 = false;
                        }
                        else
                            Debug.Log("tire already used");
                    }


                }
                else if (ui_item[item_selected].gameObject.tag == "Door")
                {

                    if (item_selected == 3)
                    {
                        if (has_door_1)
                        {
                            Debug.Log("used left door");
                            has_door_1 = false;
                        }
                        else
                            Debug.Log("door already used");
                    }

                    if (item_selected == 4)
                    {
                        if (has_door_2)
                        {
                            Debug.Log("used right door");
                            has_door_2 = false;
                        }
                        else
                            Debug.Log("door already used");
                    }
                }
                else if (ui_item[item_selected].gameObject.tag == "Hood")
                {
                    if (has_hood)
                    {
                        Debug.Log("used hood");
                        has_hood = false;
                        //call hood item function use here
                    }
                    else if (!has_hood)
                    {
                        Debug.Log("No hood left fool");
                        //play sound? or other notification
                    }
                }
            }

        }

        if (vechicle.GetComponent<VehicleBehavior>().JoyStick == 4)
        {
            if (Input.GetKeyDown(KeyCode.Joystick4Button5))
            {
                // Debug.Log("before" + item_selected);
                ui_item[item_selected].transform.localScale -= new Vector3(0.5f, 0.5f);


                item_selected += 1;
                if (item_selected >= 7)
                    item_selected = 0;

                ui_item[item_selected].transform.localScale += new Vector3(0.5f, 0.5f);


                //Debug.Log("after" + item_selected);

            }
            else if (Input.GetKeyDown(KeyCode.Joystick4Button4))
            {
                Debug.Log("I am player" + playerNum);

                ui_item[item_selected].transform.localScale -= new Vector3(0.5f, 0.5f);


                item_selected -= 1;
                if (item_selected < 0)
                    item_selected = 6;

                ui_item[item_selected].transform.localScale += new Vector3(0.5f, 0.5f);


            }

            if (Input.GetKeyDown(KeyCode.Joystick4Button2))
            {
                if (ui_item[item_selected].gameObject.tag == "Tire")
                {
                    if (item_selected == 0)
                    {
                        if (has_tire_1)
                        {
                            Debug.Log("used front left tire");
                            has_tire_1 = false;
                        }
                        else
                            Debug.Log("tire already used");
                    }

                    if (item_selected == 2)
                    {
                        if (has_tire_2)
                        {
                            Debug.Log("used front right tire");
                            has_tire_2 = false;
                        }
                        else
                            Debug.Log("tire already used");
                    }

                    if (item_selected == 5)
                    {
                        if (has_tire_3)
                        {
                            Debug.Log("used back left tire");
                            has_tire_3 = false;
                        }
                        else
                            Debug.Log("tire already used");
                    }

                    if (item_selected == 6)
                    {
                        if (has_tire_4)
                        {
                            Debug.Log("used back right tire");
                            has_tire_4 = false;
                        }
                        else
                            Debug.Log("tire already used");
                    }


                }
                else if (ui_item[item_selected].gameObject.tag == "Door")
                {

                    if (item_selected == 3)
                    {
                        if (has_door_1)
                        {
                            Debug.Log("used left door");
                            has_door_1 = false;
                        }
                        else
                            Debug.Log("door already used");
                    }

                    if (item_selected == 4)
                    {
                        if (has_door_2)
                        {
                            Debug.Log("used right door");
                            has_door_2 = false;
                        }
                        else
                            Debug.Log("door already used");
                    }
                }
                else if (ui_item[item_selected].gameObject.tag == "Hood")
                {
                    if (has_hood)
                    {
                        Debug.Log("used hood");
                        has_hood = false;
                        //call hood item function use here
                    }
                    else if (!has_hood)
                    {
                        Debug.Log("No hood left fool");
                        //play sound? or other notification
                    }
                }
            }

        }

    }
}
