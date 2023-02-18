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
        
       
        public void Play(string playerTwo)
        {

            string playerOne = attackChoices[3];

            switch (playerTwo)
            {

                case "High":

                    switch (playerOne)
                    {
                        case "High":
                            attackResult.text = "Parry";
                            Debug.Log("Check");
                            break;

                        case "Mid":
                            GetComponent<DamageCalculator>().HurtPlayerTwo();
                            Debug.Log("Check");
                            break;

                        case "Low":
                            GetComponent<DamageCalculator>().HurtPlayerOne();
                            Debug.Log("Check");
                            break;
                    }

                    break;

                case "Mid":

                    switch (playerOne)
                    {
                        case "High":
                            GetComponent<DamageCalculator>().HurtPlayerTwo();
                            Debug.Log("Check");
                            break;

                        case "Mid":
                            attackResult.text = "Parry";
                            Debug.Log("Check");
                            break;

                        case "Low":
                            GetComponent<DamageCalculator>().HurtPlayerOne();
                            Debug.Log("Check");
                            break;
                    }
                    break;

                case "Low":

                    switch (playerOne)
                    {
                        case "Up":
                            GetComponent<DamageCalculator>().HurtPlayerOne();
                            Debug.Log("Check");

                            break;

                        case "Mid":
                            GetComponent<DamageCalculator>().HurtPlayerTwo();
                            Debug.Log("Check");

                            break;

                        case "Low":
                            attackResult.text = "Parry";
                            Debug.Log("Check");
                            break;
                    }
                    break;

            }

        }

    }
}



