using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  [SerializeField] float speed = 12f;
  [SerializeField] float laneDistance = 4f;
  [SerializeField] UIManager uiManager;
  [SerializeField] Audiomanager audioManager;
  int currentLane = 0;
  int totalLanes = 5;
  float targetX = 0f;
  Rigidbody Rb;
  private Animator animator;

  void Start()
  {
    Rb = GetComponent<Rigidbody>();
    Rb.freezeRotation = true;
    currentLane = totalLanes / 2;
    animator = GetComponent<Animator>();
  }

  void Update()
  {
    if (Input.GetKeyDown(KeyCode.A)||Input.GetKeyDown(KeyCode.LeftArrow))
    {
      currentLane++;
      animator.SetTrigger("Move");
    }
    else if (Input.GetKeyDown(KeyCode.D)||Input.GetKeyDown(KeyCode.RightArrow))
    {
      currentLane--;
      animator.SetTrigger("Move");
    }
    currentLane = Mathf.Clamp(currentLane, 0, totalLanes - 1);
    targetX = (currentLane - (totalLanes / 2)) * laneDistance;
  }
  void FixedUpdate()
  {
    Vector3 targetPosition = new Vector3(targetX, Rb.position.y, Rb.position.z);
    Rb.MovePosition(Vector3.MoveTowards(Rb.position, targetPosition, speed * Time.fixedDeltaTime));
  }
  void OnCollisionEnter(Collision collision)
  {
    if (collision.gameObject.tag == "Ball")
    {
      uiManager.ScoreIncrease();
      audioManager.PlaySave();
    }
  }
}
