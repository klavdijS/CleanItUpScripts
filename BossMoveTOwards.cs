using UnityEngine;
using System.Collections;

public class BossMoveTOwards : MonoBehaviour {
    public Transform target;
    public float speed;
    // Use this for initialization
    void Start () {
        transform.position = new Vector3(0,3,0);
	}
	
	// Update is called once per frame
    void Update()
    {
       
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);

    }
}
