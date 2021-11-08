using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
   Rigidbody2D Rb;
   public float jumpForce;

   float score;

   void Start()
   {
        Rb = GetComponent<Rigidbody2D>();
   }

   void Update()
   {
       if(Input.GetMouseButtonDown(0))
       {
           Rb.velocity = Vector2.up * jumpForce;
       }
   }
}

