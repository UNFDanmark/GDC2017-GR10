using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour{

    public GameObject KnottenBoks;
    public GameObject BigBoks;
    public GameObject PlayerParent;
    public GameObject KnottenBoksPrefab;
    public GameObject BigBoksPrefab;
    public GameObject Billy;
    public GameObject Billy1;
    public GameObject Knotten;
    public GameObject Knotten1;
    public float turnSpeed = 90;
    public float moveSpeed = 10;
    public Rigidbody myRigid;
    public float timeOfLastPickUp = 0;
    public float reloadTime = 0.5f;
    public float MedBoksPosition = 3f;
    public float BigBoksPosition = 1f;


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
            Vector3 BoksFromPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z + MedBoksPosition);
            Vector3 Rotation = transform.rotation.eulerAngles;
            Quaternion newRotation = Quaternion.Euler(-90, Rotation.y, 90);
            KnottenBoks = Instantiate(KnottenBoksPrefab ,BoksFromPosition, newRotation) as GameObject;
            KnottenBoks.transform.parent = PlayerParent.transform;
        }
        if (collision.gameObject.CompareTag("Knotten1"))
        {
            Destroy(Knotten1);
            Vector3 BoksFromPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z + MedBoksPosition);
            Vector3 Rotation = transform.rotation.eulerAngles;
            Quaternion newRotation = Quaternion.Euler(-90, Rotation.y, 90);
            KnottenBoks = Instantiate(KnottenBoksPrefab, BoksFromPosition, newRotation) as GameObject;
            KnottenBoks.transform.parent = PlayerParent.transform;
        }
        if (collision.gameObject.CompareTag("KnottenBoks") && (Time.time - timeOfLastPickUp) >= reloadTime)
        {
            KnottenBoks.transform.parent = PlayerParent.transform;
            Destroy(KnottenBoks.GetComponent<Rigidbody>());
        }


        if (collision.gameObject.CompareTag("Billy"))
        {
            Destroy(Billy);
            Vector3 BoksFromPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z + BigBoksPosition);
            Vector3 Rotation = transform.rotation.eulerAngles;
            Quaternion newRotation = Quaternion.Euler( 0, Rotation.y, 90);
            BigBoks = Instantiate(BigBoksPrefab, BoksFromPosition, newRotation) as GameObject;
            BigBoks.transform.parent = PlayerParent.transform;
        }
        if (collision.gameObject.CompareTag("Billy1"))
        {
            Destroy(Billy);
            Vector3 BoksFromPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z + BigBoksPosition);
            Vector3 Rotation = transform.rotation.eulerAngles;
            Quaternion newRotation = Quaternion.Euler(0, Rotation.y, 90);
            BigBoks = Instantiate(BigBoksPrefab, BoksFromPosition, newRotation) as GameObject;
            BigBoks.transform.parent = PlayerParent.transform;
        }


    }
    public void DetachFromParent()
    {
        KnottenBoks.transform.parent = null;
        BigBoks.transform.parent = null;
        timeOfLastPickUp = Time.time;
        KnottenBoks.AddComponent<Rigidbody>();
        BigBoks.AddComponent<Rigidbody>();

    }

   



}
