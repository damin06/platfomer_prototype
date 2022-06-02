using System.Collections;

using UnityEngine;

public class Bullet : MonoBehaviour
{
    enemy enemy;
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
            
           // Destroybullet();
            if(ray.collider.CompareTag("enemy"))
            {
                enemy.wrkxek();
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
    // void Ond(Collider other)
    // {
    // Destroy(other.gameObject);
    // }
}
