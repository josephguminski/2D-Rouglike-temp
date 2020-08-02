using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroStats : MonoBehaviour
{
    public int healthPoints;
    public int attackPower;
    public int armor;
    public GameObject Archer;
    public GameObject Knight;
    public GameObject Mage;

    public void Start()
    {
        Archer = GameObject.FindGameObjectWithTag("Player");
        Knight = GameObject.FindGameObjectWithTag("Knight");
        Mage = GameObject.FindGameObjectWithTag("Mage");
    }
        


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            healthPoints -= 1;
        }    
    }
}
