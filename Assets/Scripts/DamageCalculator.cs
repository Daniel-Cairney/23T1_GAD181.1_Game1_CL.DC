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
        int playerTwoCurrentLife;
        int playerOneCurrentLife;

        private void Start()
        {
            playerTwoCurrentLife = playerTwoMaxLife;
            playerOneCurrentLife = playerOneMaxLife;
        }
        // these must be public so they can be referenced in the attack script
  
        public void HurtPlayerTwo(int damage)
        {
            playerTwoMaxLife -= damage;
            if(playerTwoCurrentLife <= 0)
            {
                DieTwo();
            }
        }
        public void DieTwo()
        {
            playerTwo.SetActive(false);
        }

        public void HurtPlayerOne(int damage)
        {
            playerTwoMaxLife -= damage;
            if (playerTwoCurrentLife <= 0)
            {
                Die();
            }
        }

        public void Die()
        {
            playerOne.SetActive(false);
        }
    }
}
