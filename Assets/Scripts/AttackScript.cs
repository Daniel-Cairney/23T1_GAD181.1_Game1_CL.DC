using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;

namespace DanCon
{
    public class AttackScript : MonoBehaviour
    {
        public Text attackResult;

        public GameObject playerOne;
        public GameObject playerTwo;

        
        public string[] attackChoices ;
        public string[] playerChoices ;
       
        public void PlayTwo(string playerTwo)
        {
            
            string playerOne = attackChoices[0];
            

            switch (playerTwo)
            {

                case "HighTwo":
                    
                    switch (playerOne)
                    {
                        case "High":
                            
                            Debug.Log("You also pressed high");
                            break;

                        case "Mid":
                            Debug.Log("Check");
                            break;

                        case "Low":
                            Debug.Log("Check");
                            break;
                    }
                    Debug.Log("You pressed HIGHTWO");
                    break;

                case "MidTwo":

                    switch (playerOne)
                    {
                        case "High":
                            Debug.Log("Check");
                            break;

                        case "Mid":
                            Debug.Log("Check");
                            break;

                        case "Low":
                            Debug.Log("Check");
                            break;
                    }
                    break;

                case "LowTwo":

                    switch (playerOne)
                    {
                        case "Up":
                            Debug.Log("Check");

                            break;

                        case "Mid":
                            Debug.Log("Check");

                            break;

                        case "Low":
                            Debug.Log("Check");
                            break;
                    }
                    break;

            }

        }

        public void PlayOne(string playerOne)
        {

            string playerTwo = playerChoices[0];


            switch (playerOne)
            {


                case "High":

                    switch (playerTwo)
                    {
                        case "HighTwo":

                            Debug.Log("You also pressed high");
                            break;

                        case "MidTwo":
                            Debug.Log("Check");
                            break;

                        case "LowTwo":
                            Debug.Log("Check");
                            break;
                    }
                    Debug.Log("friends");
                    break;

                case "Mid":

                    switch (playerTwo)
                    {
                        case "HighTwo":
                            Debug.Log("Check");
                            break;

                        case "MidTwo":
                            Debug.Log("Check");
                            break;

                        case "LowTwo":
                            Debug.Log("Check");
                            break;
                    }
                    break;

                case "Low":

                    switch (playerTwo)
                    {
                        case "UpTwo":
                            Debug.Log("Check");

                            break;

                        case "MidTwo":
                            Debug.Log("Check");

                            break;

                        case "LowTwo":
                            Debug.Log("Check");
                            break;
                    }
                    break;

            }

        }
    }
}



