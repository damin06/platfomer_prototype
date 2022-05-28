using System.Collections;

using UnityEngine;

public class Bullet : MonoBehaviour
{
   public float speed=5;
   public float distance;
   Vector3 vec = Vector3.right;
   public LayerMask islayer;
    void Start()
    {
    Invoke("Destroybullet",2);    
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D ray= Physics2D.Raycast(transform.position,transform.right,distance,islayer);
        if(ray.collider != null)
        {
            if(ray.collider.tag =="Ground")
            {
            Destroybullet();
            }
            
        }
        if(transform.rotation.y==0)
        {
      transform.position+=vec*speed*Time.deltaTime;
        }
        else
        {
transform.position+=vec*-1*speed*Time.deltaTime;
        }
    }
    void Destroybullet()
    {
        Destroy(gameObject);
    }
}
