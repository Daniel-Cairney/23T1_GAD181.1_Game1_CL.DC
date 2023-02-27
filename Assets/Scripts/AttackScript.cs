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

        [SerializeField] private Animator animator;

        [SerializeField] private Transform attackPoint;
        [SerializeField] private float attackRange = 1f;
        [SerializeField] private LayerMask playerLayers;
        [SerializeField] private int attackDamage = 40;



        private void Update()
        { //calls the methods below 
            if (gameObject.CompareTag("PlayerOne") && Input.GetKeyDown(KeyCode.RightControl))
            {
                UpAttack();
            }

            if(gameObject.CompareTag("PlayerOne") && Input.GetKeyDown(KeyCode.UpArrow))
            {
                MidAttack();
            }

            if(gameObject.CompareTag("PlayerOne") && Input.GetKeyDown(KeyCode.DownArrow))
            {
                DownAttack();
            }

            if (gameObject.CompareTag("PlayerTwo") && Input.GetKeyDown(KeyCode.Space))
            {
                UpAttackTwo();
            }

            if (gameObject.CompareTag("PlayerTwo") && Input.GetKeyDown(KeyCode.W))
            {
                MidAttackTwo();
            }

            if (gameObject.CompareTag("PlayerTwo") && Input.GetKeyDown(KeyCode.S))
            {
                DownAttackTwo();
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



