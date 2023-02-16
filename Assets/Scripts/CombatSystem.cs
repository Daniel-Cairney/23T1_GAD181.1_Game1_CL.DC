using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace DanCon
{

    public class CombatSystem : MonoBehaviour
    {

        private string[] Choices;

        private float timeBtwAtk;
        public float startTimeBtwAtk;
        

        [SerializeField] private Animation highAttack;
        [SerializeField] private Animation lowAttack;
        [SerializeField] private Animation midAttack;


        private void Awake()
        {
            highAttack = GetComponent<Animation>();
            lowAttack = GetComponent<Animation>();
            midAttack = GetComponent<Animation>();
        }

        void Update()
        {
            if (gameObject.CompareTag("PlayerOne"))

            {
                if (timeBtwAtk <= 0)
                {

                    if (Input.GetKeyDown(KeyCode.A))
                    {   // animation plays when A is pressed - but won't play again
                        highAttack.Play("High Attack");
                    }

                    else if (Input.GetKeyDown(KeyCode.S))
                    {
                        lowAttack.Play("Low Attack");
                    }

                    else if (Input.GetKeyDown(KeyCode.D))
                    {
                        midAttack.Play("Mid Attack");
                    }

                    //timeBtwAtk = startTimeBtwAtk;

                }

                else
                {
                    timeBtwAtk -= Time.deltaTime;
                }
            }

            if (gameObject.CompareTag("PlayerTwo"))

            {
                if (timeBtwAtk <= 0)
                {

                    if (Input.GetKeyDown(KeyCode.LeftArrow))
                    {   // animation plays when A is pressed - but won't play again
                        highAttack.Play("High Attack");
                    }

                    else if (Input.GetKeyDown(KeyCode.DownArrow))
                    {
                        lowAttack.Play("Low Attack");
                    }

                    else if (Input.GetKeyDown(KeyCode.RightArrow))
                    {
                        midAttack.Play("Mid Attack");
                    }

                    //timeBtwAtk = startTimeBtwAtk;

                }

                else
                {
                    timeBtwAtk -= Time.deltaTime;
                }
            }

        }
    }
}
