using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class playerMove : MonoBehaviour {

      public Rigidbody2D rb;
      public float moveSpeed = 5f;
      public Vector2 movement;

      // Auto-load the RigidBody component into the variable:
      void Start(){
            rb = GetComponent<Rigidbody2D> ();
      }

      // Listen for player input to move the object:
      void FixedUpdate(){
            movement.x = Input.GetAxisRaw ("Horizontal");
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
            movement.y = Input.GetAxisRaw ("Vertical");
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
      }
      

}