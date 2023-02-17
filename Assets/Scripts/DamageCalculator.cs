using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace DanCon
{

    public class DamageCalculator : MonoBehaviour
    {

        [SerializeField] private GameObject playerOne;
        [SerializeField] private GameObject playerTwo;

        [SerializeField] private int playerOneLife;
        [SerializeField] private int playerTwoLife;

        public void Update()
        {
            if (playerOneLife <= 0)
            {
                playerOne.SetActive(false);
            }

            if (playerTwoLife <= 0)
            {
                playerTwo.SetActive(false);
            }

        }
        // these must be public so they can be referenced in the attack script
        // 
        public void HurtPlayerOne()
        {
            playerOneLife--;
        }

        public void HurtPlayerTwo()
        { 
            playerTwoLife--;
        }

    }
}
