using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//RESOLVED: Known Bug Issue, player spins to face target when left-clicking, even though there is NRE
//Once player right-clicks the stop face their target and are "stuck" in one position
//I think some to do with focus functions or items

//Known Bug Issue: Players can not interact with Monsters, but Monsters can interact with players
//Meaning that monsters are invincible and players are being chased by killer, invincible monsters

[RequireComponent(typeof(NavMeshAgent))]
public class KeeperMotor : MonoBehaviour
{
    NavMeshAgent agent;
    Transform target;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (target != null)
        {
            agent.SetDestination(target.position);
            FaceTarget();
        }
    }
    // Update is called once per frame
    public void MoveToPoint(Vector3 point)
    {
        agent.SetDestination(point);
        //FaceTarget(); ---this was the movement bug
    }

    public void FollowTarget(TriggerSystem newTarget)
    {
        agent.stoppingDistance = newTarget.radius * .8f;
        agent.updateRotation = false;
        target = newTarget.triggerTransform;
    }

    public void StopFollowTarget()
    {
        agent.stoppingDistance = 0f;
        agent.updateRotation = true;
        target = null;
    }

    void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0f, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
        
    }
}
