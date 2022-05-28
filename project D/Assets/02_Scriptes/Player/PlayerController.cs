using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigidbody;
    [SerializeField] private float jump_speed=5;
    [SerializeField] private float speed=3;
    [SerializeField] Transform pos;
    [SerializeField] LayerMask isLayer;
    [SerializeField] float circlesize;
    bool isGround;
   
   
    void Start()
    {
        rigidbody=GetComponent<Rigidbody2D>();
    }

 
    private void FixedUpdate()
    {
        float hor =Input.GetAxis("Horizontal");
    rigidbody.velocity= new Vector2(hor*speed,rigidbody.velocity.y);
    if(hor>0){
        transform.eulerAngles= new Vector3(0,0,0);
    }
    else if(hor<0){
         transform.eulerAngles= new Vector3(0,180,0);
    }
    }
    private void Update()
    {
       
        isGround=Physics2D.OverlapCircle(pos.position,circlesize,isLayer);
        
          
        {
    if(isGround==true && Input.GetKeyDown(KeyCode.Space))
    {
        rigidbody.velocity=Vector2.up*jump_speed;
       
    }

     }
   
    }
}
