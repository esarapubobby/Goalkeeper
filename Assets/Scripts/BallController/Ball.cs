// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Ball : MonoBehaviour
// {
//   public float speed = 8f;
//   public float goal = -20f;
//   public float start = -2f;
//   float[] lanes = { -2f, -1f, 0f, 1f, 2f };
//   Vector3 startposition;
//   Vector3 target;
//   void Start()
//   {

//     startposition = new Vector3(0, transform.position.y, start);
//     transform.position = startposition;
//     Sendball();
//   }
//   void Update()
//   {
//     transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
//   }
//   void Sendball()
//   {
//     float randomX = lanes[Random.Range(0, lanes.Length)];
//     target = new Vector3(randomX, startposition.y + 1f, goal);
//   }
//     void OnCollisionEnter(Collision other)
//     {
//       StartCoroutine(Reset());
//         // if (other.gameObject.tag == "Goal")
//         // {


//         // }
//         // if (other.gameObject.tag == "Player")
//         // {
//         //   StartCoroutine(Reset());
//         // }
//     }
//     IEnumerator Reset()
//     {
//       enabled=false;
//       yield return new WaitForSeconds(1f);
//       transform.position = startposition;
//       Sendball();
//       enabled =true;

//     }
// }
