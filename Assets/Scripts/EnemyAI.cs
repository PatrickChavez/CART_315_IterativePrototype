using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    // Code by THSS Tech
    private NavMeshAgent Mob;

    public GameObject Player;

    public float MobDistanceRun = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        Mob = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float distance = Vector3.Distance(transform.position, Player.transform.position);

        // Run towards player

        if (distance < MobDistanceRun)
        {
            Vector3 dirToPlayer = transform.position - Player.transform.position;

            Vector3 newPos = transform.position - dirToPlayer;

            Mob.SetDestination(newPos);
        }
    }
}
