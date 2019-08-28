using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using ModuloKart.Controls;
public class PauseManager : MonoBehaviour
{
    GameObject[] pauseObjects;

    // Use this for initialization
    void Start()
    {
        Time.timeScale = 1;
        pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
        HidePaused();
    }

    // Update is called once per frame
    void Update()
    {

        //uses the p button to pause and unpause the game
        if (Input.GetButtonDown("X_ANYPLAYER"))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                ShowPaused();
            }
            else if (Time.timeScale == 0)
            {
                Debug.Log("high");
                Time.timeScale = 1;
                HidePaused();
            }
        }
    }


    //Reloads the Level

    //controls the pausing of the scene
    public void PauseControl()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            ShowPaused();
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            HidePaused();
        }
    }

    //shows objects with ShowOnPause tag
    public void ShowPaused()
    {
        foreach (GameObject g in pauseObjects)
        {
            g.SetActive(true);
        }
    }

    //hides objects with ShowOnPause tag
    public void HidePaused()
    {
        foreach (GameObject g in pauseObjects)
        {
            g.SetActive(false);
        }
    }
}
