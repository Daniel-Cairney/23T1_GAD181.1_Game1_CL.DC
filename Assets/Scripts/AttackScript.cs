using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace DanCon
{
    public class AttackScript : MonoBehaviour
    {
        [SerializeField] private Text attackResult;

        [SerializeField] private string playerOne;
        [SerializeField] private string playerTwo;

        [SerializeField] private string[] attackChoices;


        public void Play(string playerOne)
        {
            string playerTwo = attackChoices[2];

            switch (playerOne)
            {

                case "UpAttack":

                    switch (playerTwo)
                    {
                        case "UpAttack":
                            attackResult.text = "Parry";
                            break;

                        case "MidAttack":
                            GetComponent<DamageCalculator>().HurtPlayerTwo();
                            break;

                        case "LowAttack":
                            GetComponent<DamageCalculator>().HurtPlayerOne();
                            break;
                    }

                    break;

                case "MidAttack":

                    switch (playerTwo)
                    {
                        case "UpAttack":
                            GetComponent<DamageCalculator>().HurtPlayerTwo();
                            break;

                        case "MidAttack":
                            attackResult.text = "Parry";
                            break;

                        case "LowAttack":
                            GetComponent<DamageCalculator>().HurtPlayerOne();
                            break;
                    }
                    break;

                case "LowAttack":

                    switch (playerTwo)
                    {
                        case "UpAttack":
                            GetComponent<DamageCalculator>().HurtPlayerOne();

                            break;

                        case "MidAttack":
                            GetComponent<DamageCalculator>().HurtPlayerTwo();

                            break;

                        case "LowAttack":
                            attackResult.text = "Parry";
                            break;
                    }
                    break;

            }

        }

    }
}



