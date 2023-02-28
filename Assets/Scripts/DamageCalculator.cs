using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace DanCon
{

    public class DamageCalculator : MonoBehaviour
    {

        public GameObject playerOne;
        public GameObject playerTwo;

        public int playerTwoMaxLife = 100;
        public int playerOneMaxLife = 100;

        [SerializeField] private GameObject[] pOneSword;
        [SerializeField] private GameObject[] pTwoSword;


        // these must be public so they can be referenced in the attack script

        private void Update()
            // when the players health reaches 0 - the gameobject is turned off
        {
            if (playerTwoMaxLife <= 0)
            {
                playerTwo.SetActive(false);

            }

            if (playerOneMaxLife <= 0)
            {
                playerOne.SetActive(false);
            }

        }

        public void HurtPlayerTwo(int damage)
        {
            // deducts the damage amount from the player
            // this amount is set in the inspector
            playerTwoMaxLife -= damage;

            for (int i = 0; i < pTwoSword.Length; i++)
            {
                if(playerTwoMaxLife > 1)
                {
                    pTwoSword[i].SetActive(true);
                }
                else
                {
                    pTwoSword[i].SetActive(false);
                }
            }


        }
        
        public void HurtPlayerOne(int damage)
        {
            // same as above but for the other player
            playerOneMaxLife -= damage;

            for (int i = 0; i < pOneSword.Length; i++)

                if (playerOneMaxLife > 1)
                {
                    pOneSword[i].SetActive(true);
                }
                else
                {
                    pOneSword[i].SetActive(false);
                }


        }

    }
}
