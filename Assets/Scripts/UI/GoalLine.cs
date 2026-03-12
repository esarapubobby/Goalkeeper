using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalLine : MonoBehaviour
{
  [SerializeField] private UIManager uiManager;

  void OnTriggerEnter(Collider other)
  {
    if (other.tag == "Ball")
    {
      uiManager.Losegoal();
    }
  }
}
