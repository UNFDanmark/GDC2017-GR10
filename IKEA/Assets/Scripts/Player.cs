using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour{

    public float offset;
    public float bigOffset;
    public GameObject KnottenBoks;
    public GameObject BigBoks;
    public GameObject MediumBoks;
    public GameObject PlayerParent;
    public GameObject KnottenBoksPrefab;
    public GameObject BigBoksPrefab;
    public GameObject MedBoksPrefab;
    public GameObject Billy;
    public GameObject Billy1;
    public GameObject Knotten;
    public GameObject Knotten1;
    public GameObject Martin;
    public GameObject Martin1;
    public GameObject Lerhamn;
    public float turnSpeed = 90;
    public float moveSpeed = 10;
    public Rigidbody myRigid;
    public float timeOfLastPickUp = 0;
    public float reloadTime = 0.5f;
 

    public bool HoldingBoks = false;


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
        if (HoldingBoks == false) 
        {
            if (collision.gameObject.CompareTag("Knotten"))
            {
                Destroy(Knotten);
                Vector3 BoksFromPosition = transform.position + (transform.forward * offset);
                Vector3 Rotation = transform.rotation.eulerAngles;
                Quaternion newRotation = Quaternion.Euler(-90, Rotation.y, 90);
                KnottenBoks = Instantiate(KnottenBoksPrefab, BoksFromPosition, newRotation) as GameObject;
                KnottenBoks.transform.parent = PlayerParent.transform;
                HoldingBoks = true;
            }
            if (collision.gameObject.CompareTag("Knotten1"))
            {
                Destroy(Knotten1);
                Vector3 BoksFromPosition = transform.position + (transform.forward * offset);
                Vector3 Rotation = transform.rotation.eulerAngles;
                Quaternion newRotation = Quaternion.Euler(-90, Rotation.y, 90);
                KnottenBoks = Instantiate(KnottenBoksPrefab, BoksFromPosition, newRotation) as GameObject;
                KnottenBoks.transform.parent = PlayerParent.transform;
                HoldingBoks = true;
            }
            if (collision.gameObject.CompareTag("KnottenBoks") && (Time.time - timeOfLastPickUp) >= reloadTime)
            {
                Destroy(collision.gameObject);
                Vector3 BoksFromPosition = transform.position + (transform.forward * offset);
                Vector3 Rotation = transform.rotation.eulerAngles;
                Quaternion newRotation = Quaternion.Euler(-90, Rotation.y, 90);
                KnottenBoks = Instantiate(KnottenBoksPrefab, BoksFromPosition, newRotation) as GameObject;
                KnottenBoks.transform.parent = PlayerParent.transform;
                Destroy(KnottenBoks.GetComponent<Rigidbody>());
                HoldingBoks = true;
            }


            if (collision.gameObject.CompareTag("Martin"))
            {
                Destroy(Martin);
                Vector3 BoksFromPosition = transform.position + (transform.forward * offset);
                Vector3 Rotation = transform.rotation.eulerAngles;
                Quaternion newRotation = Quaternion.Euler(-90, Rotation.y, 90);
                MediumBoks = Instantiate(MedBoksPrefab, BoksFromPosition, newRotation) as GameObject;
                MediumBoks.transform.parent = PlayerParent.transform;
                HoldingBoks = true;
            }
            if (collision.gameObject.CompareTag("Martin1"))
            {
                Destroy(Martin1);
                Vector3 BoksFromPosition = transform.position + (transform.forward * offset);
                Vector3 Rotation = transform.rotation.eulerAngles;
                Quaternion newRotation = Quaternion.Euler(-90, Rotation.y, 90);
                MediumBoks = Instantiate(MedBoksPrefab, BoksFromPosition, newRotation) as GameObject;
                MediumBoks.transform.parent = PlayerParent.transform;
                HoldingBoks = true;
            }
            if (collision.gameObject.CompareTag("MedBoks") && (Time.time - timeOfLastPickUp) >= reloadTime)
            {
                Destroy(collision.gameObject);
                Vector3 BoksFromPosition = transform.position + (transform.forward * offset);
                Vector3 Rotation = transform.rotation.eulerAngles;
                Quaternion newRotation = Quaternion.Euler(-90, Rotation.y, 90);
                KnottenBoks = Instantiate(KnottenBoksPrefab, BoksFromPosition, newRotation) as GameObject;
                KnottenBoks.transform.parent = PlayerParent.transform;
                MediumBoks.transform.parent = PlayerParent.transform;
                Destroy(MediumBoks.GetComponent<Rigidbody>());
                HoldingBoks = true;
            }


            if (collision.gameObject.CompareTag("Billy"))
            {
                Destroy(Billy);
                Vector3 BoksFromPosition = transform.position + (transform.forward * bigOffset);
                Vector3 Rotation = transform.rotation.eulerAngles;
                Quaternion newRotation = Quaternion.Euler(0, Rotation.y, 90);
                BigBoks = Instantiate(BigBoksPrefab, BoksFromPosition, newRotation) as GameObject;
                BigBoks.transform.parent = PlayerParent.transform;
                HoldingBoks = true;
            }
            if (collision.gameObject.CompareTag("Billy1"))
            {
                Destroy(Billy1);
                Vector3 BoksFromPosition = transform.position + (transform.forward * bigOffset);
                Vector3 Rotation = transform.rotation.eulerAngles;
                Quaternion newRotation = Quaternion.Euler(0, Rotation.y, 90);
                BigBoks = Instantiate(BigBoksPrefab, BoksFromPosition, newRotation) as GameObject;
                BigBoks.transform.parent = PlayerParent.transform;
                HoldingBoks = true;
            }
            if (collision.gameObject.CompareTag("BigBoks") && (Time.time - timeOfLastPickUp) >= reloadTime)
            {
                Destroy(collision.gameObject);
                Vector3 BoksFromPosition = transform.position + (transform.forward * bigOffset);
                Vector3 Rotation = transform.rotation.eulerAngles;
                Quaternion newRotation = Quaternion.Euler(0, Rotation.y, 90);
                BigBoks = Instantiate(BigBoksPrefab, BoksFromPosition, newRotation) as GameObject;
                BigBoks.transform.parent = PlayerParent.transform;
                Destroy(BigBoks.GetComponent<Rigidbody>());
                HoldingBoks = true;
            }
            if (collision.gameObject.CompareTag("Lerhamn"))
            {
                Destroy(Lerhamn);
                Vector3 BoksFromPosition = transform.position + (transform.forward * bigOffset);
                Vector3 Rotation = transform.rotation.eulerAngles;
                Quaternion newRotation = Quaternion.Euler(0, Rotation.y, 90);
                BigBoks = Instantiate(BigBoksPrefab, BoksFromPosition, newRotation) as GameObject;
                BigBoks.transform.parent = PlayerParent.transform;
                HoldingBoks = true;
            }


        }
        


    }
    public void DetachFromParent()
    {
        KnottenBoks.transform.parent = null;
        BigBoks.transform.parent = null;
        MediumBoks.transform.parent = null;
        timeOfLastPickUp = Time.time;
        KnottenBoks.AddComponent<Rigidbody>();
        BigBoks.AddComponent<Rigidbody>();
        MediumBoks.AddComponent<Rigidbody>();
        HoldingBoks = false;

    }

   



}
