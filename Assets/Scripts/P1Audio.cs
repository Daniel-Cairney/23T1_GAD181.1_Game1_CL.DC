using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace DanCon
{


    public class P1Audio : MonoBehaviour
    {
        public AudioSource attack2;
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Comma))
            {
                attack2.Play();
            }

        }
    }

}
