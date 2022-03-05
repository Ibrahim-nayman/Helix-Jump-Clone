using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
   private Rigidbody _rigidbodyBall;
   public float Speed;

   private void Start()
   {
      _rigidbodyBall = GetComponent<Rigidbody>();
   }


   private void Update()
   {
      if (Input.GetMouseButtonDown(0))
      {
         _rigidbodyBall.AddForce(new Vector3(0,Speed,0), ForceMode.Impulse);
      }
   }
}
