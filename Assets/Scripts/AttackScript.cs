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

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.RightControl))
            {
                UpAttack();
            }

            if(Input.GetKeyDown(KeyCode.UpArrow))
            {
                MidAttack();
            }

            if(Input.GetKeyDown(KeyCode.DownArrow))
            {
                DownAttack();
            }
        }

        public void UpAttack()
        {
            animator.SetTrigger("Up Attack");
        }

        public void MidAttack()
        {
            animator.SetTrigger("Mid Attack");
        }

        public void DownAttack()
        {
            animator.SetTrigger("Down Attack");
        }
    }
}



