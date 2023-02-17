using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace DanCon
{
    public class AttackScript : MonoBehaviour
    {
        [SerializeField] private TMP_Text attackResult;

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
                            attackResult.text
                            break;

                        case "MidAttack":

                            break;

                        case "LowAttack":

                            break;
                    }

                    break;

                case "MidAttack":

                    switch (playerTwo)
                    {
                        case "UpAttack":

                            break;

                        case "MidAttack":

                            break;

                        case "LowAttack":

                            break;
                    }
                    break;

                case "LowAttack":

                    switch (playerTwo)
                    {
                        case "UpAttack":

                            break;

                        case "MidAttack":

                            break;

                        case "LowAttack":

                            break;
                    }
                    break;

            }
            switch (playerTwo)
            {

                case "UpAttack":

                    switch (playerOne)
                    {
                        case "UpAttack":

                            break;

                        case "MidAttack":

                            break;

                        case "LowAttack":

                            break;
                    }

                    break;

                case "MidAttack":

                    switch (playerOne)
                    {
                        case "UpAttack":

                            break;

                        case "MidAttack":

                            break;

                        case "LowAttack":

                            break;
                    }
                    break;

                case "LowAttack":

                    switch (playerOne)
                    {
                        case "UpAttack":

                            break;

                        case "MidAttack":

                            break;

                        case "LowAttack":

                            break;
                    }
                    break;

            }
         }

    }
}



