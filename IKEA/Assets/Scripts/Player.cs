using UnityEngine;
using System.Collections;


public class Player : MonoBehaviour{

    public float offset;
    public float bigOffset;
    public GameObject BigBoks;
    public GameObject MediumBoks;
    public GameObject PlayerParent;
    public GameObject KnottenBoksPrefab;
    public GameObject LerhamnBoksPrefab;
    public GameObject BillyBoksPrefab;
    public GameObject MartinBoksPrefab;
    public float turnSpeed = 90;
    public float moveSpeed = 10;
    public Rigidbody myRigid;
    public float timeOfLastPickUp = 0;
    public float reloadTime = 0.5f;
    public float Timer = 10;
    public bool HoldingBoks = false;
    public bool KnottenUp = false;
    public bool MartinUp = false;
    public bool BillyUp = false;
    public bool LerhamnUp = false;
    private GUIStyle guiSize = new GUIStyle();
    public Animator myAnimator;
    public float crossfadeTime = 0.2f;
    public float kickForce = 5;


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
            DetachBox();
        }
        
        if(Timer <= 0) 
        {
            Application.LoadLevel("Fail1");
        }

        if(Input.GetKeyDown("z")) 
        {
            Kick();
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
            print("O");
            if (collision.gameObject.CompareTag("Knotten"))
            {
                Destroy(collision.gameObject);
                Vector3 BoksFromPosition = transform.position + (transform.forward * offset);
                Vector3 Rotation = transform.rotation.eulerAngles;
                Quaternion newRotation = Quaternion.Euler(-90, Rotation.y, 90);
                MediumBoks = Instantiate(KnottenBoksPrefab, BoksFromPosition, newRotation) as GameObject;
                MediumBoks.transform.parent = PlayerParent.transform;
                KnottenUp = true;
                HoldingBoks = true;
            }
            
            if (collision.gameObject.CompareTag("KnottenBoks") && (Time.time - timeOfLastPickUp) >= reloadTime)
            {
                Destroy(collision.gameObject);
                Vector3 BoksFromPosition = transform.position + (transform.forward * offset);
                Vector3 Rotation = transform.rotation.eulerAngles;
                Quaternion newRotation = Quaternion.Euler(-90, Rotation.y, 90);
                MediumBoks = Instantiate(KnottenBoksPrefab, BoksFromPosition, newRotation) as GameObject;
                MediumBoks.transform.parent = PlayerParent.transform;
                Destroy(MediumBoks.GetComponent<Rigidbody>());
                KnottenUp = true;
                HoldingBoks = true;
            }


            if (collision.gameObject.CompareTag("Martin"))
            {
                Destroy(collision.gameObject);
                Vector3 BoksFromPosition = transform.position + (transform.forward * offset);
                Vector3 Rotation = transform.rotation.eulerAngles;
                Quaternion newRotation = Quaternion.Euler(-90, Rotation.y, 90);
                MediumBoks = Instantiate(MartinBoksPrefab, BoksFromPosition, newRotation) as GameObject;
                MediumBoks.transform.parent = PlayerParent.transform;
                HoldingBoks = true;
                MartinUp = true;
            }
           


            if (collision.gameObject.CompareTag("Billy"))
            {
                Destroy(collision.gameObject);
                Vector3 BoksFromPosition = transform.position + (transform.forward * bigOffset);
                Vector3 Rotation = transform.rotation.eulerAngles;
                Quaternion newRotation = Quaternion.Euler(0, Rotation.y, 90);
                BigBoks = Instantiate(BillyBoksPrefab, BoksFromPosition, newRotation) as GameObject;
                BigBoks.transform.parent = PlayerParent.transform;
                BillyUp = true;
                HoldingBoks = true;

            }
            if (collision.gameObject.CompareTag("BillyBoks") && (Time.time - timeOfLastPickUp) >= reloadTime)
            {
                Destroy(collision.gameObject);
                Vector3 BoksFromPosition = transform.position + (transform.forward * bigOffset);
                Vector3 Rotation = transform.rotation.eulerAngles;
                Quaternion newRotation = Quaternion.Euler(0, Rotation.y, 90);
                BigBoks = Instantiate(BillyBoksPrefab, BoksFromPosition, newRotation) as GameObject;
                BigBoks.transform.parent = PlayerParent.transform;
                Destroy(BigBoks.GetComponent<Rigidbody>());
                BillyUp = true;
                HoldingBoks = true;
            }

            if (collision.gameObject.CompareTag("Lerhamn"))
            {
                Destroy(collision.gameObject);
                Vector3 BoksFromPosition = transform.position + (transform.forward * bigOffset);
                Vector3 Rotation = transform.rotation.eulerAngles;
                Quaternion newRotation = Quaternion.Euler(0, Rotation.y, 90);
                BigBoks = Instantiate(LerhamnBoksPrefab, BoksFromPosition, newRotation) as GameObject;
                BigBoks.transform.parent = PlayerParent.transform;
                LerhamnUp = true;
                HoldingBoks = true;
            }
            if (collision.gameObject.CompareTag("LerhamnBoks") && (Time.time - timeOfLastPickUp) >= reloadTime)
            {
                Destroy(collision.gameObject);
                Vector3 BoksFromPosition = transform.position + (transform.forward * bigOffset);
                Vector3 Rotation = transform.rotation.eulerAngles;
                Quaternion newRotation = Quaternion.Euler(0, Rotation.y, 90);
                BigBoks = Instantiate(LerhamnBoksPrefab, BoksFromPosition, newRotation) as GameObject;
                BigBoks.transform.parent = PlayerParent.transform;
                Destroy(BigBoks.GetComponent<Rigidbody>());
                LerhamnUp = true;
                HoldingBoks = true;
            }
        }

    }

    void OnGUI() 
    {
        GUI.contentColor = Color.black;
        guiSize.fontSize = 20;
        GUI.Label(new Rect(75, 70, 200, 100), "Time left: " + (int)Timer, guiSize);
        GUI.Label(new Rect(75, 135, 200, 100), "Wanted object:", guiSize);
        if(KnottenUp == true) 
        {
            GUI.Label(new Rect(75, 110, 200 , 100),  "Box content: Knotten", guiSize);
        }
        if (MartinUp == true)
        {
            GUI.Label(new Rect(75, 110, 200, 100), "Boxs content: Martin", guiSize);
        }
        if (BillyUp == true)
        {
            GUI.Label(new Rect(75, 110, 200, 100), "Boxs content: Billy", guiSize);
        }
        if (LerhamnUp == true)
        {
            GUI.Label(new Rect(75, 110, 200, 100), "Boxs content: Lerhamn", guiSize);
        }
        if (KnottenUp == false && MartinUp == false && BillyUp == false && LerhamnUp == false)
        {
            GUI.Label(new Rect(75, 110, 200, 100), "Boxs content: Pick up a object", guiSize);
        }

    }
    public void DetachBox()
    {
        BigBoks.transform.parent = null;
        MediumBoks.transform.parent = null;
        timeOfLastPickUp = Time.time;
        BigBoks.AddComponent<Rigidbody>();
        MediumBoks.AddComponent<Rigidbody>();
        HoldingBoks = false;
        KnottenUp = false;
        MartinUp = false;
        BillyUp = false;
        LerhamnUp = false;

    }
    public void Kick()
    {
        var kickableMask = 1 << LayerMask.NameToLayer("Kickable");
        Collider[] ObjectsToKick = Physics.OverlapBox(transform.position + new Vector3(0, 2.44f, 1.77f), new Vector3(2, 2, 2), transform.rotation, kickableMask);

        foreach(Collider ObjectToKick in ObjectsToKick) {
            ObjectToKick.GetComponent<Rigidbody>().AddForce(transform.forward + transform.up * kickForce, ForceMode.Impulse);
        }
    }





}
