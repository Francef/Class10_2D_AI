using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.AI;


public class Enemy_NM : MonoBehaviour
{    
    //[SerializeField] private NavMeshAgent agent;    // for moving on the NavMesh
    //[SerializeField] private Transform target;      // the target to follow

    //private float distanceToTarget = float.MaxValue;    // distance to target - default to far away
    //private float chaseRange = 10f;                     // when target is closer than this, chase!

    //private enum EnemyState { IDLE, CHASE };
    //private EnemyState state;

    //void Update()
    //{
    //    agent.SetDestination(target.transform.position);  // follow the target
    //}


    //private void SetState(EnemyState newState) {
    //    state = newState;
    //}

    //void Start() {
    //    SetState(EnemyState.IDLE);      // start off in the IDLE state
    //}  

    //void Update()  {
    //    // what happens here depends on the state we're currently in!
    //    switch (state) {
    //        case EnemyState.IDLE:   Update_Idle();  break;
    //        case EnemyState.CHASE:  Update_Chase(); break;
    //        default: Debug.Log("Invalid state!");   break;
    //    }
    //}

    //void Update_Idle() {
    //    agent.isStopped = true;                             // stop the agent (following)
    //}

    //void Update_Chase() {
    //    agent.isStopped = false;                            // start the agent (following)
    //    agent.SetDestination(target.transform.position);    // follow the target
    //}

    //private void OnDrawGizmos() {
    //    Gizmos.color = Color.blue;
    //    Gizmos.DrawWireSphere(transform.position, chaseRange);  // draw a circle to show chase range
    //}
}
