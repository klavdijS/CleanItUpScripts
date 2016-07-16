using UnityEngine;
using System.Collections;

public class BossShooting : MonoBehaviour {

    public Rigidbody player;
    public Rigidbody projectile;
    
    void Update()
    {
      //naštimi timer TIME + Time.DeltaTime();
        {
            
            transform.LookAt(player.position);
            Fire();
           
        }
    }
    void Fire() {
        Rigidbody clone;
        clone = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
        clone.velocity = transform.TransformDirection(Vector3.forward * 10);
        projectile.AddForce(transform.forward * 20);
    }
}
