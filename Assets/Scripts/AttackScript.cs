using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace DanCon
{
    public class AttackScript : MonoBehaviour
    {
        public Text attackResult;

        public GameObject playerOne;
        public GameObject playerTwo;

        public KeyCode[] attackChoices;


        public void Play(KeyCode playerTwo)
        {

            KeyCode playerOne = attackChoices[6];

            switch (playerTwo)
            {

                case KeyCode.LeftArrow:

                    switch (playerOne)
                    {
                        case KeyCode.A:
                            attackResult.text = "Parry";
                            Debug.Log("Check");
                            break;

                        case KeyCode.S:
                            GetComponent<DamageCalculator>().HurtPlayerTwo();
                            Debug.Log("Check");
                            break;

                        case KeyCode.D:
                            GetComponent<DamageCalculator>().HurtPlayerOne();
                            Debug.Log("Check");
                            break;
                    }

                    break;

                case KeyCode.DownArrow:

                    switch (playerOne)
                    {
                        case KeyCode.A:
                            GetComponent<DamageCalculator>().HurtPlayerTwo();
                            Debug.Log("Check");
                            break;

                        case KeyCode.S:
                            attackResult.text = "Parry";
                            Debug.Log("Check");
                            break;

                        case KeyCode.D:
                            GetComponent<DamageCalculator>().HurtPlayerOne();
                            Debug.Log("Check");
                            break;
                    }
                    break;

                case KeyCode.RightArrow:

                    switch (playerOne)
                    {
                        case KeyCode.A:
                            GetComponent<DamageCalculator>().HurtPlayerOne();
                            Debug.Log("Check");

                            break;

                        case KeyCode.S:
                            GetComponent<DamageCalculator>().HurtPlayerTwo();
                            Debug.Log("Check");

                            break;

                        case KeyCode.D:
                            attackResult.text = "Parry";
                            Debug.Log("Check");
                            break;
                    }
                    break;

            }

        }

    }
}



