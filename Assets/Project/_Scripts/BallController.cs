using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
   public Rigidbody BallRigidbody;
   public float JumpPower;

   private void Start()
   {
      
   }
   private void Update()
   {
   }

   private void OnCollisionEnter(Collision other)
   {
      BallRigidbody.AddForce(Vector3.up * JumpPower);
   }

   private void OnTriggerEnter(Collider other)
   {
      if (other.CompareTag("Win"))
      {
         StartCoroutine(LoadSceneDelay());
      }
   }

   private IEnumerator LoadSceneDelay()
   {
      yield return new WaitForSeconds(2f);
      SceneManager.LoadScene("SampleScene");
   }
}
