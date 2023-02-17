using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class P2Attack : MonoBehaviour
{
    [SerializeField] private TMP_Text attackResult;

    [SerializeField] private string playerOne;
    [SerializeField] private string playerTwo;

    [SerializeField] private string[] attackChoices;


    public void Play(string playerTwo)
    {
        string playerOne = attackChoices[2];

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
