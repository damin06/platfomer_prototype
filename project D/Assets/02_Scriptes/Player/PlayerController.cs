using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigidbody;
    public float jump_speed=5;
    public float speed=3;
    [SerializeField] Transform pos;
    [SerializeField] LayerMask isLayer;
    [SerializeField] float circlesize;
    bool isGround;
   
   public Animator animator;
    void Start()
    {
        animator=GetComponent<Animator>();
        rigidbody=GetComponent<Rigidbody2D>();
    }

 
    private void FixedUpdate()
    {
        float hor =Input.GetAxis("Horizontal");
    rigidbody.velocity= new Vector2(hor*speed,rigidbody.velocity.y);
    if(hor>0){
        transform.eulerAngles= new Vector3(0,0,0);
         animator.SetBool("run",true);  
    }
    else if(hor<0){
         transform.eulerAngles= new Vector3(0,180,0);
         animator.SetBool("run",true);  
    }
    else
    {
        animator.SetBool("run",false);
    }
    }
    private void Update()
    {
       RaycastHit2D ray= Physics2D.Raycast(transform.position,transform.right,isLayer);
        if(ray.collider != null)
        {
            
           
            if(ray.collider.CompareTag("enemy")){
                Destroy(gameObject);
            }
            
            
        }
        isGround=Physics2D.OverlapCircle(pos.position,circlesize,isLayer);
        
          
        {
    if(isGround==true && Input.GetKeyDown(KeyCode.Space))
    {
        rigidbody.velocity=Vector2.up*jump_speed;
       
    }

     }
    }
    public void OntriggerEnter2D(Collider2D collision){
        Destroy(collision.gameObject);
    }
    public void OntriggerEnter2D(Collision collision){
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
