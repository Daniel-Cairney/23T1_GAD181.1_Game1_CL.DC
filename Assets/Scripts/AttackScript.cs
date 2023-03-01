using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;

namespace DanCon
{
    public class AttackScript : MonoBehaviour
    {
        public float coolDown = 1f;
        private float lastAttack = -1f;

        [SerializeField] private Animator animator;

        [SerializeField] private Transform attackPoint;
        [SerializeField] private float attackRange = 1f;
        [SerializeField] private LayerMask playerLayers;
        [SerializeField] private int attackDamage = 40;

        private bool isBlocked;

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

            if (gameObject.CompareTag("PlayerOne") && Input.GetKeyDown(KeyCode.UpArrow))
            {
                if (Time.time > lastAttack + coolDown)
                {
                    MidAttack();
                    lastAttack = Time.time;

                }
            }

                if (gameObject.CompareTag("PlayerOne") && Input.GetKeyDown(KeyCode.DownArrow))
                {
                    if (Time.time > lastAttack + coolDown)
                    {
                        DownAttack();
                    lastAttack = Time.time;

                }
            }

            if (gameObject.CompareTag("PlayerTwo") && Input.GetKeyDown(KeyCode.Space))
            { 
                if (Time.time > lastAttack + coolDown)
                {
                    UpAttackTwo();
                    lastAttack = Time.time;
                    lastAttack = Time.time;

                }
            }

                    if (gameObject.CompareTag("PlayerTwo") && Input.GetKeyDown(KeyCode.W))
                    {
                        if (Time.time > lastAttack + coolDown)
                        {
                            MidAttackTwo();
                    lastAttack = Time.time;

                }
            }

                        if (gameObject.CompareTag("PlayerTwo") && Input.GetKeyDown(KeyCode.S))
                        {
                            if (Time.time > lastAttack + coolDown)
                            {
                                DownAttackTwo();
                    lastAttack = Time.time;

                }
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

        public void MidAttack()
        {
            animator.SetTrigger("Mid Attack");

            Collider2D[] hitPlayers = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, playerLayers);
            foreach (Collider2D player in hitPlayers)
            {
                player.GetComponent<DamageCalculator>().HurtPlayerTwo(attackDamage);
            }
        }

        public void DownAttack()
        {
            animator.SetTrigger("Down Attack");

            Collider2D[] hitPlayers = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, playerLayers);
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
                player.GetComponent<DamageCalculator>().HurtPlayerOne(attackDamage);
            }

        }

        public void MidAttackTwo()
        {
            animator.SetTrigger("Mid Attack");

            Collider2D[] hitPlayers = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, playerLayers);
            foreach (Collider2D player in hitPlayers)
            {
                player.GetComponent<DamageCalculator>().HurtPlayerOne(attackDamage);
            }
        }

        public void DownAttackTwo()
        {
            animator.SetTrigger("Down Attack");

            Collider2D[] hitPlayers = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, playerLayers);
            foreach (Collider2D player in hitPlayers)
            {
                player.GetComponent<DamageCalculator>().HurtPlayerOne(attackDamage);
            }
        }
        private void OnDrawGizmosSelected()
        { // used to visualise the attack point in the editor - otherwise you can't see it

            if (attackPoint == null)
                return;

            Gizmos.DrawWireSphere(attackPoint.position, attackRange);
        }
    }
}



