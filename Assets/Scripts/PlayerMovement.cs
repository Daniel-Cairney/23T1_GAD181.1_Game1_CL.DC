using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace DanCon
{


    public class PlayerMovement : MonoBehaviour
    {

        [SerializeField] private KeyCode left;
        [SerializeField] private KeyCode right;
        [SerializeField] private KeyCode jump;

        [SerializeField] private float jumpHeight;
        [SerializeField] private float movementSpeed;

        public Transform groundCheckPoint;
        public float groundCheckRadius;
        public LayerMask groundLayer;

        private bool isGrounded;

        [SerializeField] private Rigidbody2D samuraiRB;
        
        [SerializeField] private Animator samuraiAnim;

        private void Start()
        {
            samuraiRB = GetComponent<Rigidbody2D>();
            samuraiAnim = GetComponent<Animator>();

        }

 

        private void Update()
        {

            isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, groundLayer);


           if(Input.GetKey(left))
            {
                samuraiRB.velocity = new Vector2(-movementSpeed, samuraiRB.velocity.y);
            }

           else if(Input.GetKey(right))
            {
                samuraiRB.velocity = new Vector2(movementSpeed, samuraiRB.velocity.y);
            }

           else
            {
                samuraiRB.velocity = new Vector2(0, samuraiRB.velocity.y);
            }

            if (Input.GetKeyDown(jump) && isGrounded)
            {
                samuraiRB.velocity = new Vector2(samuraiRB.velocity.x, jumpHeight);
            }


            if (samuraiRB.velocity.x < 0)
            {
                transform.localScale = new Vector3(-7, 7, 7);
            }

            else if(samuraiRB.velocity.x >0)
            {
                transform.localScale = new Vector3(7, 7, 7);

            }

            samuraiAnim.SetFloat("Speed", Mathf.Abs(samuraiRB.velocity.x)); 

        }


    }
}