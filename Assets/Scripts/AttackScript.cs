using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;
using System.Runtime.CompilerServices;

namespace DanCon
{
    public class AttackScript : MonoBehaviour
    {
        public float coolDown = 1f;
        private float lastAttack = -1f;
        private bool isBlocked = false;

        [SerializeField] private Animator animator;

        [SerializeField] private Transform attackPoint;
        [SerializeField] private float attackRange = 1f;
        [SerializeField] private LayerMask playerLayers;
        [SerializeField] private int attackDamage = 40;

        private void Update()
        { //calls the methods below 

            if (gameObject.CompareTag("PlayerOne") && Input.GetKeyDown(KeyCode.Keypad0))
            {
                if (Time.time > lastAttack + coolDown)
                {
                    UpAttack();
                    lastAttack = Time.time;
                }
            }

            if (gameObject.CompareTag("PlayerTwo") && Input.GetKeyDown(KeyCode.Space))
            { 
                if (Time.time > lastAttack + coolDown)
                {
                    UpAttackTwo();
                    lastAttack = Time.time;
                }
            }

            // when the player pushes the Period (or Greater Key) they block
            if(gameObject.CompareTag("PlayerOne") && Input.GetKey(KeyCode.Period))
            {
                isBlocked = true;
                Debug.Log("Blocked Cuz");
            }

            if(gameObject.CompareTag("PlayerTwo") && Input.GetKey(KeyCode.G))
            { // changes the playerlayer to isblocked in the inspector 
                gameObject.layer = LayerMask.NameToLayer("IsBlocked");
            }

        }

        public void UpAttack()
        {
            // plays the animation set to the button input
            animator.SetTrigger("Up Attack");

            // checks if the players attack position has hit a Player on a particular Layer

            Collider2D[]hitPlayers = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, playerLayers);
            foreach (Collider2D player in hitPlayers)
            {
                    player.GetComponent<DamageCalculator>().HurtPlayerTwo(attackDamage);

            }
        }

        public void UpAttackTwo()
        {
            // plays the animation set to the button input
            animator.SetTrigger("Up Attack");

            // checks if the players attack position has hit a Player on a particular Layer

            Collider2D[] hitPlayers = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, playerLayers);
            foreach (Collider2D player in hitPlayers)
            {
                if (isBlocked == true)
                {
                    return;
                }
                else
                {
                    player.GetComponent<DamageCalculator>().HurtPlayerOne(attackDamage);
                }
            }

        }


        public void OnDrawGizmosSelected()
        { // used to visualise the attack point in the editor - otherwise you can't see it
            // the circle is just infront of the character 

            if (attackPoint == null)
                return;

            Gizmos.DrawWireSphere(attackPoint.position, attackRange);
        }
    }
}



