using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace DanCon

{


    public class CombatSystem : MonoBehaviour
    {

        private string[] Choices;



        [SerializeField] private Animation highAttack;
        [SerializeField] private Animation lowAttack;
        [SerializeField] private Animation midAttack;

        void Update()
        {
            if (gameObject.activeSelf)

            {
                if (Input.GetKeyDown(KeyCode.A))
                {
                    highAttack.Play("High Attack");

                    switch (Choices)
                    {
                        case "High_Attack":
                        
                            switch (otherPlayerChoice)
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
                    }
                    }
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
            }

        }
    }
}