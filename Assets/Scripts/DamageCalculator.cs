using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

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
                SceneManager.LoadScene("GameOverScreen");

            }

            if (playerOneMaxLife <= 0)
            {
                playerOne.SetActive(false);
                SceneManager.LoadScene("GameOverScreen");

            }

        }

        public void HurtPlayerTwo(int damage)
        {
            // deducts the damage amount from the player
            // this amount is set in the inspector
            playerTwoMaxLife -= damage;


            // this handles the health bar on screen
            // it checks to see the length of the array, and counts each one in order - if the number of health is less than the number of the total array
            // it will remove on of the images
            // the images needed to be arranged backwards in the inspector

            for (int i = 0; i < pTwoSword.Length; i++)
            {
                if(playerTwoMaxLife > i)
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

                if (playerOneMaxLife > i)
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
