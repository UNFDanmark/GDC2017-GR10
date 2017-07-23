using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    public float turnSpeed = 30;
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
        Move();
	}

    public void Move ()
    {
        transform.Translate(0, 0, moveSpeed * Time.deltaTime * Input.GetAxis("Vertical"));
    }

    public void Turn ()
    {
        transform.rotation(0, 0, 0);
    }
}
