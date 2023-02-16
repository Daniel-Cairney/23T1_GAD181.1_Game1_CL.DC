using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace DanCon
{

    public class CombatSystem : MonoBehaviour
    {

        private string[] Choices;

        private float timeBtwAtk;
        [SerializeField] private float startTimeBtwAtk;

        private Animator highAttack;
        private Animator lowAttack;
        private Animator midAttack;


        private void Awake()
        {
            highAttack = GetComponent<Animator>();
            lowAttack = GetComponent<Animator>();
            midAttack = GetComponent<Animator>();
        }

        void Update()
        {
            if (gameObject.CompareTag("PlayerOne"))

            {
                if (timeBtwAtk <= 0)
                {

                    if (Input.GetKeyDown(KeyCode.A))
                    {   // animation plays when A is pressed - but won't play again
                        highAttack.SetBool("High Attack", Input.GetKeyDown(KeyCode.A) == true );
                        
                        /*switch (Choices)
                        {
                            case "High_Attack":

                                switch (playerTwoChoice)
                                {

                                case :
                                    // code block
                                    break;
                                case :
                                    // code block
                                    break;
                                default:
                                    // code block
                                    break;
                        }*/
                    }

                    else if (Input.GetKeyDown(KeyCode.S))
                    {
                        lowAttack.Play("Low Attack");

                        /* switch (Choices)
                        {
                            // I want to code the attack response into the attack
                            // robotOne's characterStance is High Attack && robotTwo is lowAttack then maxHP --
                            // 
                            case :
                                // code block
                                break;
                            case :
                                // code block
                                break;
                            default:
                                // code block
                                break;
                        }*/
                    }

                    else if (Input.GetKeyDown(KeyCode.D))
                    {
                        midAttack.Play("Mid Attack");
                        /* switch (Choices)
                        {
                            // I want to code the attack response into the attack
                            // robotOne's characterStance is High Attack && robotTwo is lowAttack then maxHP --
                            // 
                            case :
                                // code block
                                break;
                            case :
                                // code block
                                break;
                            default:
                                // code block
                                break;
                        }*/

                    }

                    timeBtwAtk = startTimeBtwAtk;

                }

                

                else
                {
                    timeBtwAtk -= Time.deltaTime;
                }
            }

        }
    }
}
