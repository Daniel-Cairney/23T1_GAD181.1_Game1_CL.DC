using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using Unity.VisualScripting;

public class EventManager : MonoBehaviour
{

    [Header("KeyInput")]

    [SerializeField] private KeyCode keyCode1;
    [SerializeField] private KeyCode keyCode2;
    [SerializeField] private KeyCode keyCode3;
    [SerializeField] private KeyCode keyCode4;
    [SerializeField] private KeyCode keyCode5;
    [SerializeField] private KeyCode keyCode6;

    [Header("ButtonList")]
    [SerializeField] private Button button1;
    [SerializeField] private Button button2;
    [SerializeField] private Button button3;
    [SerializeField] private Button button4;
    [SerializeField] private Button button5;
    [SerializeField] private Button button6;



    // Start is called before the first frame update
    void Start()
    {
        button1.onClick.AddListener(TaskOnClick1);
        button2.onClick.AddListener(TaskOnClick2);
        button3.onClick.AddListener(TaskOnClick3);
        button4.onClick.AddListener(TaskOnClick4);
        button5.onClick.AddListener(TaskOnClick5);
        button6.onClick.AddListener(TaskOnClick6);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyCode1))
        {
            button1.onClick.Invoke();
        }

        if(Input.GetKeyDown(keyCode2))
        {
            button2.onClick.Invoke();
        }   

        if( Input.GetKeyDown(keyCode3))
        {
            button3.onClick.Invoke();
        }

        if (Input.GetKeyDown(keyCode4))
        {
            button4.onClick.Invoke();
        }

        if (Input.GetKeyDown(keyCode5))
        {
            button5.onClick.Invoke();
        }

        if (Input.GetKeyDown(keyCode6))
        {
            button6.onClick.Invoke();
        }

    }

    void TaskOnClick1()
    {
        
    }
    void TaskOnClick2()
    {
        Debug.Log("You have clicked the button 2");
    }
    void TaskOnClick3()
    {
        Debug.Log("You have clicked the button 3");
    }
    void TaskOnClick4()
    {
        Debug.Log("You have clicked the button 4");
    }
    void TaskOnClick5()
    {
        Debug.Log("You have clicked the button 5");
    }
    void TaskOnClick6()
    {
        Debug.Log("You have clicked the button 6");
    }
}

