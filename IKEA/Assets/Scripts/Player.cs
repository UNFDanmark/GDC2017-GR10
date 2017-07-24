﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour{

    public GameObject KnottenBoks;
    public GameObject PlayerParent;
    public GameObject KnottenBoksPrefab;
    public GameObject Knotten;
    public GameObject Knotten1;
    public float turnSpeed = 90;
    public float moveSpeed = 10;
    public Rigidbody myRigid;
    public float timeOfLastPickUp = 0;
    public float reloadTime = 0.5f;


    // Use this for initialization
    void Start ()
    {
        myRigid = GetComponent<Rigidbody>();
   
    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(0, turnSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0);
        if (Input.GetKeyDown("space"))
        {
            DetachFromParent();
        }
    }

    void FixedUpdate()
    {
        Move(moveSpeed * Input.GetAxis("Vertical"));
    }

    public void Move(float speed)
    {
        
        myRigid.velocity = transform.forward * speed + Vector3.up * myRigid.velocity.y;
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Knotten"))
        {
            Destroy(Knotten);
            KnottenBoks = Instantiate(KnottenBoksPrefab);
            KnottenBoks.transform.parent = PlayerParent.transform;
        }
        if (collision.gameObject.CompareTag("Knotten1"))
        {
            Destroy(Knotten1);
            KnottenBoks = Instantiate(KnottenBoksPrefab);
            KnottenBoks.transform.parent = PlayerParent.transform;
        }
        if (collision.gameObject.CompareTag("KnottenBoks") && (Time.time - timeOfLastPickUp) >= reloadTime)
        {
            KnottenBoks.transform.parent = PlayerParent.transform;
            Destroy(KnottenBoks.GetComponent<Rigidbody>());

        }


    }
    public void DetachFromParent()
    {
        KnottenBoks.transform.parent = null;
        timeOfLastPickUp = Time.time;
        KnottenBoks.AddComponent<Rigidbody>();

    }



}
