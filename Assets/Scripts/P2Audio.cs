using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace DanCon
{


    public class P2Audio : MonoBehaviour
    {
        public AudioSource attack2;
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                attack2.Play();
            }

        }

    }

}
