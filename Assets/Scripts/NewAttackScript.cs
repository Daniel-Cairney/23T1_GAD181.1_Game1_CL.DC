using DanCon;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace DanCon
{

    public class NewAttackScript : MonoBehaviour
    {
        public Text parryResult;

        [SerializeField] private GameObject playerOne;
        [SerializeField] private GameObject playerTwo;


        void Update()
        {
            if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
            {
                if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.UpArrow))
                {
                    parryResult.text = "Parry";
                }
                else if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.UpArrow))
                {
                    GetComponent<DamageCalculator>().HurtPlayerTwo();
                }
                else if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.UpArrow))
                {
                    GetComponent<DamageCalculator>().HurtPlayerOne();
                }
            }

            if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.W))
            {
                if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.UpArrow))
                {
                    GetComponent<DamageCalculator>().HurtPlayerOne();
                }
                else if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.UpArrow))
                {
                    parryResult.text = "Parry";
                }
                else if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.UpArrow))
                {
                    GetComponent<DamageCalculator>().HurtPlayerTwo();
                }
            }

            if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W))
            {
                if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.UpArrow))
                {
                    GetComponent<DamageCalculator>().HurtPlayerTwo();
                }
                else if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.UpArrow))
                {
                    GetComponent<DamageCalculator>().HurtPlayerOne();
                }
                else if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.UpArrow))
                {
                    parryResult.text = "Parry";
                }
            }


        }
    }
}
