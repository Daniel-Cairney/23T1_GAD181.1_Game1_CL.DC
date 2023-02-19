using DanCon;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class NewAttackScript : MonoBehaviour
{
    public Text parryResult;

    [SerializeField] private GameObject playerOne;
    [SerializeField] private GameObject playerTwo;


    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            if(Input.GetKey(KeyCode.LeftArrow))
            {
                parryResult.text = "Parry";
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                GetComponent<DamageCalculator>().HurtPlayerTwo();
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                GetComponent<DamageCalculator>().HurtPlayerOne();
            }
        }

        if (Input.GetKey(KeyCode.S))
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                GetComponent<DamageCalculator>().HurtPlayerOne();
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                parryResult.text = "Parry";
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                GetComponent<DamageCalculator>().HurtPlayerTwo();
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                GetComponent<DamageCalculator>().HurtPlayerTwo();
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                GetComponent<DamageCalculator>().HurtPlayerOne();
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                parryResult.text = "Parry";
            }
        }


    }
}
