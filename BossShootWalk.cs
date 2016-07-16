
using UnityEngine;
using System.Collections;

public class BossShootWalk : MonoBehaviour
{
    public Transform Player;
    public float speed;
    public float MaxDist;
    float timestamp = 0f;
	GameObject clone;
    void Start()

    {
        transform.Translate(new Vector3(0,2,0) * Time.deltaTime, Space.World);
        transform.Rotate(-30,0,0);
    }

    void Update()
    {
        
        transform.LookAt(Player.position);

        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, Player.position, step);
		if (LifeCarrier.life <= 0) {
			this.enabled = false;
		}
   
        

    }
}