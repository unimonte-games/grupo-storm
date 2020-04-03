using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
   public Transform spawnnPoint;
   public GameObject obsPrefab;
   public float maxTime;
   public float minTime;
   private float time;
   private float spawnTime;

   void Start ()
   {
       time = minTime;
   }

   void FixedUpdate ()
   {
       SetRandomTime ();
       time += Time.deltaTime;

       if (time >= spawnTime)
       {
           SpawnObject();
           SetRandomTime();
       }
   }

   void SpawnObject ()
   {
       time = minTime;
       StartCoroutine(Example());
       Instantiate (obsPrefab, spawnnPoint.position, spawnnPoint.rotation);
   }

   void SetRandomTime ()
   {
       spawnTime = Random.Range (minTime, maxTime);
   }

   IEnumerator Example ()
   {
       yield return new WaitForSeconds (200f);
   }
}
