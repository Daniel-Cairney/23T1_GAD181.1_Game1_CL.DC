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

        public Image fight;

        private float timeBtwAtk;
        public float startTimeBtwAtk;
        public Sprite SamuraiPlaceholder_0, SamuraiPlaceholder_1, SamuraiPlaceholder_2, SamuraiPlaceholder_3;


        void Update()
        {
            if (gameObject.CompareTag("PlayerOne"))

            {
                if (timeBtwAtk <= 0)
                {

                    if (Input.GetKeyDown(KeyCode.A))
                    {   // animation plays when A is pressed - but won't play again
                        fight.sprite = SamuraiPlaceholder_3;
                    }

                    else if (Input.GetKeyDown(KeyCode.S))
                    {
                        fight.sprite = SamuraiPlaceholder_2;
                    }

                    else if (Input.GetKeyDown(KeyCode.D))
                    {
                        fight.sprite = SamuraiPlaceholder_1;
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
