using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepBehaviour : MonoBehaviour
{
  public enum Status { Idling, Fleeing }
  public Status status;
  public float perceptionRadius = 10f;
  public GameObject player;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    if (Vector3.Distance(transform.position, player.transform.position) <= perceptionRadius)
    {
      status = Status.Fleeing;
    }
    else
    {
      status = Status.Idling;
    }
  }

  void OnDrawGizmos()
  {
    if (status == Status.Fleeing)
    {
      Gizmos.color = Color.red;
    }
    else if (status == Status.Idling)
    {
      Gizmos.color = Color.white;
    }

    Gizmos.DrawWireSphere(transform.position, perceptionRadius);
  }
}
