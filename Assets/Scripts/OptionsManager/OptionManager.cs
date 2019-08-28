using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using ModuloKart.Controls;

namespace ModuloKart.OptionMenu {

    public enum numOptions
    {
        volume = 1,
        p1Pref = 2,
        p2Pref = 3,
        p3Pref = 4,
        p4Pref = 5,
        mainMenu = -1,

    }




public class OptionManager : MonoBehaviour
{

        OptionManager Instance;
        private GameObject bg_volume;
        private GameObject bg_p1Pref;
        private GameObject bg_p2Pref;
        private GameObject bg_p3Pref;
        private GameObject bg_p4Pref;
        private GameObject bg_mainMenu;

        public numOptions numOptions;
        public bool inGameScene;



        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(this.gameObject);
            }
            else
            {
                Instance = this;
                DontDestroyOnLoad(this.gameObject);
            }

            GetPlayerSelectionOptions();
            InitPlayerOptions();
        }
            // Update is called once per frame
            void Update()
    {
            NumOptionSelectionNext();
            NumOptionSelectionPrev();
            ConfirmOption();
        }
        bool isPressPrev;
        bool isPressPrevRelease;
        private void NumOptionSelectionPrev()
        {
            if (Input.GetAxis("LeftJoyStickY_ANYPLAYER") < 0)
            {
                isPressPrev = true;
            }
            if (isPressPrev)
            {
                if (Input.GetAxis("LeftJoyStickY_ANYPLAYER") == 0)
                {
                    isPressPrev = false;
                    isPressPrevRelease = true;
                }
            }
            if (isPressPrevRelease)
            {
                isPressPrevRelease = false;

                switch (numOptions)
                {
                    case numOptions.volume:
                        numOptions = numOptions.mainMenu;
                        bg_volume.SetActive(true);
                        bg_p1Pref.SetActive(true);
                        bg_p2Pref.SetActive(true);
                        bg_p3Pref.SetActive(true);
                        bg_p4Pref.SetActive(true);
                        bg_mainMenu.SetActive(false);
                        break;
                    case numOptions.p1Pref:
                        numOptions = numOptions.volume;
                        bg_volume.SetActive(false);
                        bg_p1Pref.SetActive(true);
                        bg_p2Pref.SetActive(true);
                        bg_p3Pref.SetActive(true);
                        bg_p4Pref.SetActive(true);
                        bg_mainMenu.SetActive(true);
                        break;
                    case numOptions.p2Pref:
                        numOptions = numOptions.p1Pref;
                        bg_volume.SetActive(true);
                        bg_p1Pref.SetActive(false);
                        bg_p2Pref.SetActive(true);
                        bg_p3Pref.SetActive(true);
                        bg_p4Pref.SetActive(true);
                        bg_mainMenu.SetActive(true);
                        break;
                    case numOptions.p3Pref:
                        numOptions = numOptions.p2Pref;
                        bg_volume.SetActive(true);
                        bg_p1Pref.SetActive(true);
                        bg_p2Pref.SetActive(false);
                        bg_p3Pref.SetActive(true);
                        bg_p4Pref.SetActive(true);
                        bg_mainMenu.SetActive(true);
                        break;
                    case numOptions.p4Pref:
                        numOptions = numOptions.p3Pref;
                        bg_volume.SetActive(true);
                        bg_p1Pref.SetActive(true);
                        bg_p2Pref.SetActive(true);
                        bg_p3Pref.SetActive(false);
                        bg_p4Pref.SetActive(true);
                        bg_mainMenu.SetActive(true);
                        break;
                    case numOptions.mainMenu:
                        numOptions = numOptions.p4Pref;
                        bg_volume.SetActive(true);
                        bg_p1Pref.SetActive(true);
                        bg_p2Pref.SetActive(true);
                        bg_p3Pref.SetActive(true);
                        bg_p4Pref.SetActive(false);
                        bg_mainMenu.SetActive(true);
                        break;
                    default:
                        Debug.Log("Unexpected Player Number Selection Option");
                        break;
                }
            }
        }
        bool isPressNext;
        bool isPressNextRelease;
        private void NumOptionSelectionNext()
        {
            if (Input.GetAxis("LeftJoyStickY_ANYPLAYER") > 0)
            {
                isPressNext = true;
            }
            if (isPressNext)
            {
                if (Input.GetAxis("LeftJoyStickY_ANYPLAYER") == 0)
                {
                    isPressNext = false;
                    isPressNextRelease = true;
                }
            }
            if (isPressNextRelease)
            {
                isPressNextRelease = false;

               switch (numOptions)
                {
                    case numOptions.volume:
                        numOptions = numOptions.p1Pref;
                        bg_volume.SetActive(true);
                        bg_p1Pref.SetActive(false);
                        bg_p2Pref.SetActive(true);
                        bg_p3Pref.SetActive(true);
                        bg_p4Pref.SetActive(true);
                        bg_mainMenu.SetActive(true);
                        break;
                    case numOptions.p1Pref:
                        numOptions = numOptions.p2Pref;
                        bg_volume.SetActive(true);
                        bg_p1Pref.SetActive(true);
                        bg_p2Pref.SetActive(false);
                        bg_p3Pref.SetActive(true);
                        bg_p4Pref.SetActive(true);
                        bg_mainMenu.SetActive(true);
                        break;
                    case numOptions.p2Pref:
                        numOptions = numOptions.p3Pref;
                        bg_volume.SetActive(true);
                        bg_p1Pref.SetActive(true);
                        bg_p2Pref.SetActive(true);
                        bg_p3Pref.SetActive(false);
                        bg_p4Pref.SetActive(true);
                        bg_mainMenu.SetActive(true);
                        break;
                    case numOptions.p3Pref:
                        numOptions = numOptions.p4Pref;
                        bg_volume.SetActive(true);
                        bg_p1Pref.SetActive(true);
                        bg_p2Pref.SetActive(true);
                        bg_p3Pref.SetActive(true);
                        bg_p4Pref.SetActive(false);
                        bg_mainMenu.SetActive(true);
                        break;
                    case numOptions.p4Pref:
                        numOptions = numOptions.mainMenu;
                        bg_volume.SetActive(true);
                        bg_p1Pref.SetActive(true);
                        bg_p2Pref.SetActive(true);
                        bg_p3Pref.SetActive(true);
                        bg_p4Pref.SetActive(true);
                        bg_mainMenu.SetActive(false);
                        break;
                    case numOptions.mainMenu:
                        numOptions = numOptions.volume;
                        bg_volume.SetActive(false);
                        bg_p1Pref.SetActive(true);
                        bg_p2Pref.SetActive(true);
                        bg_p3Pref.SetActive(true);
                        bg_p4Pref.SetActive(true);
                        bg_mainMenu.SetActive(true);
                        break;
                    default:
                        Debug.Log("Unexpected Player Number Selection Option");
                        break;
                }
            }
        }





        private void InitPlayerOptions()
        {
            numOptions = numOptions.volume;
            bg_volume.SetActive(false);
            bg_p1Pref.SetActive(true);
            bg_p2Pref.SetActive(true);
            bg_p3Pref.SetActive(true);
            bg_p4Pref.SetActive(true);
            bg_mainMenu.SetActive(true);
        }


        private void ConfirmOption()
        {
            if (Input.GetButtonDown("A_ANYPLAYER"))
            {
                switch (numOptions)
                {
                    case numOptions.volume:
                        //modify Volume Slider Here
                        break;
                    case numOptions.p1Pref:
                        //modify P1 Preset Here
                        break;
                    case numOptions.p2Pref:
                        //modify P2 Preset Here
                        break;
                    case numOptions.p3Pref:
                        //modify P3 Preset Here
                        break;
                    case numOptions.p4Pref:
                        //modify P4 Preset Here
                        break;
                    case numOptions.mainMenu:
                        ButtonBehavior_ReturnToMain();
                        break;
                    default:
                        Debug.Log("Unexpected Player Number Selection Option");
                        break;
                }
            }
        }

        private void GetPlayerSelectionOptions()
        {
            OptionSelector[] temp = GameObject.FindObjectsOfType<OptionSelector>();

            foreach (OptionSelector t in temp)
            {
                if (t.numoptions.Equals(numOptions.volume))
                {
                    bg_volume = t.bg;
                }
                else if (t.numoptions.Equals(numOptions.p1Pref))
                {
                    bg_p1Pref = t.bg;
                }
                else if (t.numoptions.Equals(numOptions.p2Pref))
                {
                    bg_p2Pref = t.bg;
                }
                else if (t.numoptions.Equals(numOptions.p3Pref))
                {
                    bg_p3Pref = t.bg;
                }
                else if (t.numoptions.Equals(numOptions.p4Pref))
                {
                    bg_p4Pref = t.bg;
                }
                else if (t.numoptions.Equals(numOptions.mainMenu))
                {
                    bg_mainMenu = t.bg;
                }
            }
        }

        public void ButtonBehavior_ReturnToMain()
        {
            SceneManager.LoadScene(0);
        }
    }
}
