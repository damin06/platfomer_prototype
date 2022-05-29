using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playershot : MonoBehaviour
{
    public Animator animator;
    public GameObject bullet;
    public Transform pos;
    public float currentime;
   public float BulletDistance;
   public PlayerController playerController;
   public float stoprun;
   public float stopjump;
    void Start()
    {
        playerController =GetComponent<PlayerController>();
            animator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
     
    if(currentime<=0)
    { 
     if(Input.GetButtonDown("Fire1"))
        {
           
            playerController.speed=0;
            playerController.jump_speed=0;
            animator.SetTrigger("shot");
            Instantiate(bullet,pos.position,transform.rotation);  
              currentime=BulletDistance; 
                      playerController.speed=5;
            playerController.jump_speed=5;
        }
    }
     currentime -=Time.deltaTime;   
    }
}
