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
        int playerTwoCurrentLife;

        private void Start()
        {
            playerTwoCurrentLife = playerTwoMaxLife;
        }

        public void Update()
        {
   
            if (playerTwoCurrentLife <= 0)
            {
                playerTwo.SetActive(false);
            }

        }
        // these must be public so they can be referenced in the attack script
        // 


        public void HurtPlayerTwo(int damage)
        {
            playerTwoMaxLife -= damage;
        
            if(playerTwoCurrentLife <= 0)
            {
                Die();
            }
        
        }

        public void Die()
        {
            Debug.Log("Player two has died");
        }
    }
}
