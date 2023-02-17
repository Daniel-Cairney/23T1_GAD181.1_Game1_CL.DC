using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace DanCon
{

    public class DamageCalculator : MonoBehaviour
    {

        [SerializeField] private TMP_Text result;
        public string choices;
       

        void Play(string playerOneChoice)
        {
            string playerTwoChoice = choices;

            switch (playerTwoChoice)
            {
                case "High Attack":

                    switch (playerOneChoice)
                    {

                        case "High Attack":
                            result.text = "Parry";
                            break;
                        case "Mid attack":
                            result.text = "You Were Hit";
                            break;
                        case "Low Attack":
                            result.text = "You Dealt Damage";
                            break;
                    }
                    break;

                case "Mid Attack":

                    switch (playerOneChoice)
                    {

                        case "High Attack":
                            result.text = "You Dealt Damage";
                            break;
                        case "Mid attack":
                            result.text = "Parry";
                            break;
                        case "Low Attack":
                            result.text = "You Were Hit";
                            break;
                    }
                    break;

                case "Low Attack":

                    switch (playerOneChoice)
                    {

                        case "High Attack":
                            result.text = "You Were Hit";
                            break;
                        case "Mid attack":
                            result.text = "You Dealt Damage";
                            break;
                        case "Low Attack":
                            result.text = "Parry";
                            break;
                    }
                    break;
            }


        }
    }
}
