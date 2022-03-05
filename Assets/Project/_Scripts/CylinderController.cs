
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderController : MonoBehaviour
{
   public float RotateSpeed;

   private float _rotationX;

   private void Update()
   {
      _rotationX = Input.GetAxis("Mouse X");

      if (Input.GetMouseButton(0))
      {
         transform.Rotate(0f, _rotationX * RotateSpeed * Time.deltaTime,0f);
      }
      
      
   }
}
