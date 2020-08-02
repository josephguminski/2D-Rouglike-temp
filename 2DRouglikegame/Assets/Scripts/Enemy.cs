using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;
    public float retreatDistance;
    public float attackRange;

    public Transform player;

    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (Vector2.Distance(transform.position, player.position) > stoppingDistance && 
            Vector2.Distance(transform.position, player.position) < attackRange)
        {
            Debug.Log("I come");
            transform.position = Vector2.MoveTowards(transform.position, player.position, 
                speed * Time.deltaTime);
        }

        else if (Vector2.Distance(transform.position, player.position) < stoppingDistance
            && Vector2.Distance(transform.position, player.position) > retreatDistance &&
            Vector2.Distance(transform.position, player.position) > attackRange)
        {
            Debug.Log("I stay");
            Debug.Log(player.position);
            transform.position = this.transform.position;
        }

        else if (Vector2.Distance(transform.position, player.position) < retreatDistance)
        {
            Debug.Log("I run");
            transform.position = Vector2.MoveTowards(transform.position, player.position, 
                -speed * Time.deltaTime);
        }
    }
}