using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroSelection : MonoBehaviour
{

    GameObject[] Heroes;
    int HeroIndex;


    // Start is called before the first frame update
    void Start()
    {
        InstantiateHero();
    }


    public void InstantiateHero()
    {
        Instantiate(Heroes[HeroIndex], transform.position, transform.rotation, transform);
    }    
    // Update is called once per frame
    void Update()
    {
        
    }
}
