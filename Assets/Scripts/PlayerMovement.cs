using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace DanCon
{


    public class PlayerMovement : MonoBehaviour
    {

        [SerializeField] private float movementSpeed = 5f;
        
        [SerializeField] private Rigidbody2D samuraiRB;
        
        [SerializeField] private Animator samuraiAnim;
        
        private Vector2 movement;

        private void Update()
        {
            movement.x = Input.GetAxisRaw("Horizontal");

            samuraiAnim.SetFloat("Horizontal", movement.x);
            samuraiAnim.SetFloat("Speed", movement.sqrMagnitude);
        }

        private void FixedUpdate()
        {
            samuraiRB.MovePosition(samuraiRB.position + movement * movementSpeed * Time.deltaTime);
        }


    }
}