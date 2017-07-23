using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour{

    public GameObject PlayerParent;
    public GameObject KnottenBoksPrefab;
    public GameObject Knotten;
    public float turnSpeed = 90;
    public float moveSpeed = 10;
    public Rigidbody myRigid;
    private bool MyParent = false;

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

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Knotten"))
        {
            Destroy(Knotten);
            GameObject KnottenBoks = Instantiate(KnottenBoksPrefab);
            MyParent = true;
        }
       
    }
    public void SetParent(GameObject PlayerParent)
    {
        if(MyParent = true)
        {
            //Makes the GameObject "newParent" the parent of the GameObject "player".
            KnottenBoksPrefab.transform.parent = PlayerParent.transform;


        }
        
    }


}
