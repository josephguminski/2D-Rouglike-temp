using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class EnemyAI : MonoBehaviour
{
    private EnemyPathfindingMovement pathfindingMovement;
    private Vector3 startingPos;
    private Vector3 roamPos;

    private void Awake()
    {
        pathfindingMovement = GetComponent<EnemyPathfindingMovement>();
    }
    private void Start()
    {
        startingPos = transform.position;
        roamPos = GetRoamingPos();
    }

    private void Update()
    {
        
    }

    private Vector3 GetRoamingPos()
    {
        return startingPos + UtilsClass.GetRandomDir() * Random.Range(10f, 70f);
    }
}
