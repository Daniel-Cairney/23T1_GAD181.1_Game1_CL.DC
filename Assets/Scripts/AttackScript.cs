using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace DanCon
{

    public class AttackScript : MonoBehaviour
    {

        [SerializeField] private Animator samuraiAnim;

        [SerializeField] private Transform attackPoint;
        [SerializeField] private float attackRange = 0.5f;
        [SerializeField] private LayerMask playerLayers;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.RightControl))
            {
                UpAttack();
            }


            void UpAttack()

            {
                samuraiAnim.SetTrigger("UpAttack");

                Collider2D[] hitPlayer = Physics2D.OverlapCircleAll(attackPoint.position, attackRange);

                foreach (Collider2D player in hitPlayer)
                {
                    Debug.Log("HitHim");
                }
            }

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                MidAttack();
            }


            void MidAttack()

            {
                samuraiAnim.SetTrigger("MidAttack");

                Collider2D[] hitPlayer = Physics2D.OverlapCircleAll(attackPoint.position, attackRange);

                foreach (Collider2D player in hitPlayer)
                {
                    Debug.Log("HitHim");
                }
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                DownAttack();
            }


            void DownAttack()

            {
                samuraiAnim.SetTrigger("DownAttack");

                Collider2D[] hitPlayer = Physics2D.OverlapCircleAll(attackPoint.position, attackRange);

                foreach (Collider2D player in hitPlayer)
                {
                    Debug.Log("HitHim");
                }
            }

        }

        public void OnDrawGizmosSelected()
        {
            if (attackPoint == null)
                return;

            Gizmos.DrawWireSphere(attackPoint.position, attackRange);
        }
    }

}



