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
   public GameObject points1;
   public float score1;
   public float score2;

   void Start ()
   {
       time = minTime;
   }

   void FixedUpdate ()
   {
       SetRandomTime ();
       time += Time.deltaTime;

       score1 = points1.GetComponent<Points>().Score;  

       if (time >= spawnTime)
       {
           SpawnObject();
           SetRandomTime();
       }
       
       if (score1 > score2)
       {
           maxTime -= 50;
           score2 += 1000;
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
