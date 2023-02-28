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

        [SerializeField] private int playerTwoMaxLife = 100;
        [SerializeField] private int playerOneMaxLife = 100;

        [SerializeField] private GameObject[] pOneSword;
        [SerializeField] private GameObject[] pTwoSword;


        // these must be public so they can be referenced in the attack script
  
        public void HurtPlayerTwo(int damage)
        {
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

            if(playerTwoMaxLife <= 0)
            {
                playerTwo.SetActive(false);
                
            }
        }
 
        public void HurtPlayerOne(int damage)
        {
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

            if (playerOneMaxLife <= 0)
            {
                playerOne.SetActive(false); 
            }
        }

    }
}
