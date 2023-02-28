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



        // these must be public so they can be referenced in the attack script
  
        public void HurtPlayerTwo(int damage)
        {
            playerTwoMaxLife -= damage;
            if(playerTwoMaxLife <= 0)
            {
                playerTwo.SetActive(false);
                
            }
        }
 
        public void HurtPlayerOne(int damage)
        {
            playerOneMaxLife -= damage;
            if (playerOneMaxLife <= 0)
            {
                playerOne.SetActive(false); ;
            }
        }

    }
}
