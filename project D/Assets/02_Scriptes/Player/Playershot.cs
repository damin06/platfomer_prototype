using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playershot : MonoBehaviour
{
    public GameObject bullet;
    public Transform pos;
    public float currentime;
   public float BulletDistance;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    if(currentime<=0)
    { 
     if(Input.GetButtonDown("Fire1"))
        {
            Instantiate(bullet,pos.position,transform.rotation);  
              currentime=BulletDistance; 
        }
    }
     currentime -=Time.deltaTime;   
    }
}
