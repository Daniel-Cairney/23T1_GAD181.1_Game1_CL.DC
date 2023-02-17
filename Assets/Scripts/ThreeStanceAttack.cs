using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace DanCon
{
    public class ThreeStanceAttack : MonoBehaviour
    {
        [SerializeField] private Text attackResult;

        [SerializeField] private string playerOne;
        [SerializeField] private string playerTwo;

        [SerializeField] private string[] attackChoices;


        public void PlayerOneAttack()
        {
            switch (playerOne)
            {

                case "UpAttack":

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
        }

        public void PlayerTwoAttack()
        {
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
