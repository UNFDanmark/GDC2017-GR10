using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    public float turnSpeed = 90;
    public float moveSpeed = 10;
    public Rigidbody myRigid;

	// Use this for initialization
	void Start ()
    {
        Rigidbody myRigid = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(0, turnSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0);
    }

    void FixedUpdate()
    {
        Move(moveSpeed * Input.GetAxis("Vertical"));
    }

    public void Move(float speed)
    {
        myRigid.velocity = transform.forward * speed + Vector3.up * myRigid.velocity.y;
    }


}
