using UnityEngine;
using System.Collections;


public class Player : MonoBehaviour{

    public float offsetForward;
    public float offsetUp;
    public float bigOffsetForward;
    public float bigOffsetUp;
    public float smallOffsetForward;
    public float smallOffsetUp;
    public GameObject BigBoks;
    public GameObject MediumBoks;
    public GameObject SmallBoks;
    public GameObject PlayerParent;
    public GameObject KnottenBoksPrefab;
    public GameObject LerhamnBoksPrefab;
    public GameObject BillyBoksPrefab;
    public GameObject MartinBoksPrefab;
    public GameObject HemnesBoksPrefab;
    public GameObject KivikBoksPrefab;
    public GameObject MockelbyBoksPrefab;
    public GameObject AvsiktligBoksPrefab;
    public GameObject MickeBoksPrefab;
    public GameObject NorrarydBoksPrefab;
    public GameObject HemnesSengBoksPrefab;
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
    public bool HemnesUp = false;
    public bool KivikUp = false;
    public bool MockelbyUp = false;
    public bool AvsiktligUp = false;
    public bool MickeUp = false;
    public bool NorrarydUp = false;
    public bool HemnesSengUp = false;
    private GUIStyle guiSize = new GUIStyle();
    public Animator myAnimator;
    public float crossfadeTime = 0.2f;
    public float kickForceFor = 5;
    public float kickForceUp = 5;


    // Use this for initialization
    void Start ()
    {
        myRigid = GetComponent<Rigidbody>();


    }
	
	// Update is called once per frame
	void Update ()
    {
        Timer = Timer - Time.deltaTime;
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
            if (collision.gameObject.CompareTag("Knotten"))
            {
                Destroy(collision.gameObject);
                Vector3 BoksFromPosition = transform.position + (transform.forward * offsetForward + transform.up * offsetUp);
                Vector3 Rotation = transform.rotation.eulerAngles;
                Quaternion newRotation = Quaternion.Euler(-90, Rotation.y, 90);
                MediumBoks = Instantiate(KnottenBoksPrefab, BoksFromPosition, newRotation) as GameObject;
                MediumBoks.transform.parent = PlayerParent.transform;
                myAnimator.SetBool("HoldingBoks", true);
                KnottenUp = true;
                HoldingBoks = true;
            }
            if (collision.gameObject.CompareTag("KnottenBoks") && (Time.time - timeOfLastPickUp) >= reloadTime)
            {
                Destroy(collision.gameObject);
                Vector3 BoksFromPosition = transform.position + (transform.forward * offsetForward + transform.up * offsetUp);
                Vector3 Rotation = transform.rotation.eulerAngles;
                Quaternion newRotation = Quaternion.Euler(-90, Rotation.y, 90);
                MediumBoks = Instantiate(KnottenBoksPrefab, BoksFromPosition, newRotation) as GameObject;
                MediumBoks.transform.parent = PlayerParent.transform;
                Destroy(MediumBoks.GetComponent<Rigidbody>());
                myAnimator.SetBool("HoldingBoks", true);
                KnottenUp = true;
                HoldingBoks = true;
            }


            if (collision.gameObject.CompareTag("Martin"))
            {
                Destroy(collision.gameObject);
                Vector3 BoksFromPosition = transform.position + (transform.forward * offsetForward + transform.up * offsetUp);
                Vector3 Rotation = transform.rotation.eulerAngles;
                Quaternion newRotation = Quaternion.Euler(-90, Rotation.y, 90);
                MediumBoks = Instantiate(MartinBoksPrefab, BoksFromPosition, newRotation) as GameObject;
                MediumBoks.transform.parent = PlayerParent.transform;
                myAnimator.SetBool("HoldingBoks", true);
                HoldingBoks = true;
                MartinUp = true;
            }
            if (collision.gameObject.CompareTag("MartinBoks") && (Time.time - timeOfLastPickUp) >= reloadTime)
            {
                Destroy(collision.gameObject);
                Vector3 BoksFromPosition = transform.position + (transform.forward * offsetForward + transform.up * offsetUp);
                Vector3 Rotation = transform.rotation.eulerAngles;
                Quaternion newRotation = Quaternion.Euler(-90, Rotation.y, 90);
                MediumBoks = Instantiate(MartinBoksPrefab, BoksFromPosition, newRotation) as GameObject;
                MediumBoks.transform.parent = PlayerParent.transform;
                Destroy(MediumBoks.GetComponent<Rigidbody>());
                myAnimator.SetBool("HoldingBoks", true);
                KnottenUp = true;
                HoldingBoks = true;
            }


            if (collision.gameObject.CompareTag("Billy"))
            {
                Destroy(collision.gameObject);
                Vector3 BoksFromPosition = transform.position + (transform.forward * bigOffsetForward + transform.up * bigOffsetUp);
                Vector3 Rotation = transform.rotation.eulerAngles;
                Quaternion newRotation = Quaternion.Euler(0, Rotation.y, 90);
                BigBoks = Instantiate(BillyBoksPrefab, BoksFromPosition, newRotation) as GameObject;
                BigBoks.transform.parent = PlayerParent.transform;
                myAnimator.SetBool("HoldingBoks", true);
                BillyUp = true;
                HoldingBoks = true;
            }
            if (collision.gameObject.CompareTag("BillyBoks") && (Time.time - timeOfLastPickUp) >= reloadTime)
            {
                Destroy(collision.gameObject);
                Vector3 BoksFromPosition = transform.position + (transform.forward * bigOffsetForward + transform.up * bigOffsetUp);
                Vector3 Rotation = transform.rotation.eulerAngles;
                Quaternion newRotation = Quaternion.Euler(0, Rotation.y, 90);
                BigBoks = Instantiate(BillyBoksPrefab, BoksFromPosition, newRotation) as GameObject;
                BigBoks.transform.parent = PlayerParent.transform;
                Destroy(BigBoks.GetComponent<Rigidbody>());
                myAnimator.SetBool("HoldingBoks", true);
                BillyUp = true;
                HoldingBoks = true;
            }


            if (collision.gameObject.CompareTag("Lerhamn"))
            {
                Destroy(collision.gameObject);
                Vector3 BoksFromPosition = transform.position + (transform.forward * bigOffsetForward + transform.up * bigOffsetUp);
                Vector3 Rotation = transform.rotation.eulerAngles;
                Quaternion newRotation = Quaternion.Euler(0, Rotation.y, 90);
                BigBoks = Instantiate(LerhamnBoksPrefab, BoksFromPosition, newRotation) as GameObject;
                BigBoks.transform.parent = PlayerParent.transform;
                myAnimator.SetBool("HoldingBoks", true);
                LerhamnUp = true;
                HoldingBoks = true;
            }
            if (collision.gameObject.CompareTag("LerhamnBoks") && (Time.time - timeOfLastPickUp) >= reloadTime)
            {
                Destroy(collision.gameObject);
                Vector3 BoksFromPosition = transform.position + (transform.forward * bigOffsetForward + transform.up * bigOffsetUp);
                Vector3 Rotation = transform.rotation.eulerAngles;
                Quaternion newRotation = Quaternion.Euler(0, Rotation.y, 90);
                BigBoks = Instantiate(LerhamnBoksPrefab, BoksFromPosition, newRotation) as GameObject;
                BigBoks.transform.parent = PlayerParent.transform;
                Destroy(BigBoks.GetComponent<Rigidbody>());
                myAnimator.SetBool("HoldingBoks", true);
                LerhamnUp = true;
                HoldingBoks = true;
            }


            if (collision.gameObject.CompareTag("Hemnes"))
            {
                Destroy(collision.gameObject);
                Vector3 BoksFromPosition = transform.position + (transform.forward * offsetForward + transform.up * offsetUp);
                Vector3 Rotation = transform.rotation.eulerAngles;
                Quaternion newRotation = Quaternion.Euler(-90, Rotation.y, 90);
                MediumBoks = Instantiate(HemnesBoksPrefab, BoksFromPosition, newRotation) as GameObject;
                MediumBoks.transform.parent = PlayerParent.transform;
                myAnimator.SetBool("HoldingBoks", true);
                HemnesUp = true;
                HoldingBoks = true;
            }
            if (collision.gameObject.CompareTag("HemnesBoks") && (Time.time - timeOfLastPickUp) >= reloadTime)
            {
                Destroy(collision.gameObject);
                Vector3 BoksFromPosition = transform.position + (transform.forward * offsetForward + transform.up * offsetUp);
                Vector3 Rotation = transform.rotation.eulerAngles;
                Quaternion newRotation = Quaternion.Euler(-90, Rotation.y, 90);
                MediumBoks = Instantiate(HemnesBoksPrefab, BoksFromPosition, newRotation) as GameObject;
                MediumBoks.transform.parent = PlayerParent.transform;
                Destroy(MediumBoks.GetComponent<Rigidbody>());
                myAnimator.SetBool("HoldingBoks", true);
                HemnesUp = true;
                HoldingBoks = true;
            }


            if (collision.gameObject.CompareTag("Kivik"))
            {
                Destroy(collision.gameObject);
                Vector3 BoksFromPosition = transform.position + (transform.forward * bigOffsetForward + transform.up * bigOffsetUp);
                Vector3 Rotation = transform.rotation.eulerAngles;
                Quaternion newRotation = Quaternion.Euler(0, Rotation.y, 90);
                BigBoks = Instantiate(KivikBoksPrefab, BoksFromPosition, newRotation) as GameObject;
                BigBoks.transform.parent = PlayerParent.transform;
                myAnimator.SetBool("HoldingBoks", true);
                KivikUp = true;
                HoldingBoks = true;
            }
            if (collision.gameObject.CompareTag("KivikBoks") && (Time.time - timeOfLastPickUp) >= reloadTime)
            {
                Destroy(collision.gameObject);
                Vector3 BoksFromPosition = transform.position + (transform.forward * bigOffsetForward + transform.up * bigOffsetUp);
                Vector3 Rotation = transform.rotation.eulerAngles;
                Quaternion newRotation = Quaternion.Euler(0, Rotation.y, 90);
                BigBoks = Instantiate(KivikBoksPrefab, BoksFromPosition, newRotation) as GameObject;
                BigBoks.transform.parent = PlayerParent.transform;
                Destroy(BigBoks.GetComponent<Rigidbody>());
                myAnimator.SetBool("HoldingBoks", true);
                KivikUp = true;
                HoldingBoks = true;
            }


            if (collision.gameObject.CompareTag("Mockelby"))
            {
                Destroy(collision.gameObject);
                Vector3 BoksFromPosition = transform.position + (transform.forward * bigOffsetForward + transform.up * bigOffsetUp);
                Vector3 Rotation = transform.rotation.eulerAngles;
                Quaternion newRotation = Quaternion.Euler(0, Rotation.y, 90);
                BigBoks = Instantiate(MockelbyBoksPrefab, BoksFromPosition, newRotation) as GameObject;
                BigBoks.transform.parent = PlayerParent.transform;
                myAnimator.SetBool("HoldingBoks", true);
                MockelbyUp = true;
                HoldingBoks = true;
            }
            if (collision.gameObject.CompareTag("MockelbyBoks") && (Time.time - timeOfLastPickUp) >= reloadTime)
            {
                Destroy(collision.gameObject);
                Vector3 BoksFromPosition = transform.position + (transform.forward * bigOffsetForward + transform.up * bigOffsetUp);
                Vector3 Rotation = transform.rotation.eulerAngles;
                Quaternion newRotation = Quaternion.Euler(0, Rotation.y, 90);
                BigBoks = Instantiate(MockelbyBoksPrefab, BoksFromPosition, newRotation) as GameObject;
                BigBoks.transform.parent = PlayerParent.transform;
                Destroy(BigBoks.GetComponent<Rigidbody>());
                myAnimator.SetBool("HoldingBoks", true);
                MockelbyUp = true;
                HoldingBoks = true;
            }


            if (collision.gameObject.CompareTag("Avsiktlig"))
            {
                Destroy(collision.gameObject);
                Vector3 BoksFromPosition = transform.position + (transform.forward * smallOffsetForward + transform.up * smallOffsetUp);
                Vector3 Rotation = transform.rotation.eulerAngles;
                Quaternion newRotation = Quaternion.Euler(90, Rotation.y, 90);
                SmallBoks = Instantiate(AvsiktligBoksPrefab, BoksFromPosition, newRotation) as GameObject;
                SmallBoks.transform.parent = PlayerParent.transform;
                myAnimator.SetBool("HoldingBoks", true);
                AvsiktligUp = true;
                HoldingBoks = true;
            }
            if (collision.gameObject.CompareTag("AvsiktligBoks") && (Time.time - timeOfLastPickUp) >= reloadTime)
            {
                Destroy(collision.gameObject);
                Vector3 BoksFromPosition = transform.position + (transform.forward * smallOffsetForward + transform.up * smallOffsetUp);
                Vector3 Rotation = transform.rotation.eulerAngles;
                Quaternion newRotation = Quaternion.Euler(90, Rotation.y, 90);
                SmallBoks = Instantiate(AvsiktligBoksPrefab, BoksFromPosition, newRotation) as GameObject;
                SmallBoks.transform.parent = PlayerParent.transform;
                Destroy(SmallBoks.GetComponent<Rigidbody>());
                myAnimator.SetBool("HoldingBoks", true);
                AvsiktligUp = true;
                HoldingBoks = true;
            }

            if (collision.gameObject.CompareTag("Micke"))
            {
                Destroy(collision.gameObject);
                Vector3 BoksFromPosition = transform.position + (transform.forward * bigOffsetForward + transform.up * bigOffsetUp);
                Vector3 Rotation = transform.rotation.eulerAngles;
                Quaternion newRotation = Quaternion.Euler(0, Rotation.y, 90);
                BigBoks = Instantiate(MickeBoksPrefab, BoksFromPosition, newRotation) as GameObject;
                BigBoks.transform.parent = PlayerParent.transform;
                myAnimator.SetBool("HoldingBoks", true);
                MickeUp = true;
                HoldingBoks = true;
            }
            if (collision.gameObject.CompareTag("MickeBoks") && (Time.time - timeOfLastPickUp) >= reloadTime)
            {
                Destroy(collision.gameObject);
                Vector3 BoksFromPosition = transform.position + (transform.forward * bigOffsetForward + transform.up * bigOffsetUp);
                Vector3 Rotation = transform.rotation.eulerAngles;
                Quaternion newRotation = Quaternion.Euler(0, Rotation.y, 90);
                BigBoks = Instantiate(MickeBoksPrefab, BoksFromPosition, newRotation) as GameObject;
                BigBoks.transform.parent = PlayerParent.transform;
                Destroy(BigBoks.GetComponent<Rigidbody>());
                myAnimator.SetBool("HoldingBoks", true);
                MickeUp = true;
                HoldingBoks = true;
            }


            if (collision.gameObject.CompareTag("Norraryd"))
            {
                Destroy(collision.gameObject);
                Vector3 BoksFromPosition = transform.position + (transform.forward * offsetForward + transform.up * offsetUp);
                Vector3 Rotation = transform.rotation.eulerAngles;
                Quaternion newRotation = Quaternion.Euler(-90, Rotation.y, 90);
                MediumBoks = Instantiate(NorrarydBoksPrefab, BoksFromPosition, newRotation) as GameObject;
                MediumBoks.transform.parent = PlayerParent.transform;
                myAnimator.SetBool("HoldingBoks", true);
                NorrarydUp = true;
                HoldingBoks = true;
            }
            if (collision.gameObject.CompareTag("NorrarydBoks") && (Time.time - timeOfLastPickUp) >= reloadTime)
            {
                Destroy(collision.gameObject);
                Vector3 BoksFromPosition = transform.position + (transform.forward * offsetForward + transform.up * offsetUp);
                Vector3 Rotation = transform.rotation.eulerAngles;
                Quaternion newRotation = Quaternion.Euler(-90, Rotation.y, 90);
                MediumBoks = Instantiate(NorrarydBoksPrefab, BoksFromPosition, newRotation) as GameObject;
                MediumBoks.transform.parent = PlayerParent.transform;
                Destroy(MediumBoks.GetComponent<Rigidbody>());
                myAnimator.SetBool("HoldingBoks", true);
                NorrarydUp = true;
                HoldingBoks = true;
            }


            if (collision.gameObject.CompareTag("HemnesSeng"))
            {
                Destroy(collision.gameObject);
                Vector3 BoksFromPosition = transform.position + (transform.forward * bigOffsetForward + transform.up * bigOffsetUp);
                Vector3 Rotation = transform.rotation.eulerAngles;
                Quaternion newRotation = Quaternion.Euler(0, Rotation.y, 90);
                BigBoks = Instantiate(HemnesSengBoksPrefab, BoksFromPosition, newRotation) as GameObject;
                BigBoks.transform.parent = PlayerParent.transform;
                myAnimator.SetBool("HoldingBoks", true);
                HemnesUp = true;
                HoldingBoks = true;
            }
            if (collision.gameObject.CompareTag("HemnesSengBoks") && (Time.time - timeOfLastPickUp) >= reloadTime)
            {
                Destroy(collision.gameObject);
                Vector3 BoksFromPosition = transform.position + (transform.forward * bigOffsetForward + transform.up * bigOffsetUp);
                Vector3 Rotation = transform.rotation.eulerAngles;
                Quaternion newRotation = Quaternion.Euler(0, Rotation.y, 90);
                BigBoks = Instantiate(MickeBoksPrefab, BoksFromPosition, newRotation) as GameObject;
                BigBoks.transform.parent = PlayerParent.transform;
                Destroy(BigBoks.GetComponent<Rigidbody>());
                myAnimator.SetBool("HoldingBoks", true);
                HemnesSengUp = true;
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
            GUI.Label(new Rect(75, 110, 200, 100), "Box content: Martin", guiSize);
        }
        if (BillyUp == true)
        {
            GUI.Label(new Rect(75, 110, 200, 100), "Box content: Billy", guiSize);
        }
        if (LerhamnUp == true)
        {
            GUI.Label(new Rect(75, 110, 200, 100), "Box content: Lerhamn", guiSize);
        }
        if (HemnesUp == true)
        {
            GUI.Label(new Rect(75, 110, 200, 100), "Box content: Hemnes", guiSize);
        }
        if (KivikUp == true)
        {
            GUI.Label(new Rect(75, 110, 200, 100), "Box content: Kivik", guiSize);
        }
        if (MockelbyUp == true)
        {
            GUI.Label(new Rect(75, 110, 200, 100), "Box content: Mockelby", guiSize);
        }
        if (AvsiktligUp == true)
        {
            GUI.Label(new Rect(75, 110, 200, 100), "Box content: Avsiktlig", guiSize);
        }
        if (MickeUp == true)
        {
            GUI.Label(new Rect(75, 110, 200, 100), "Box content: Micke", guiSize);
        }
        if (NorrarydUp == true)
        {
            GUI.Label(new Rect(75, 110, 200, 100), "Box content: Norraryd", guiSize);
        }
        if (HemnesSengUp == true)
        {
            GUI.Label(new Rect(75, 110, 200, 100), "Box content: HemnesSeng", guiSize);
        }

        if (KnottenUp == false && MartinUp == false && BillyUp == false && LerhamnUp == false && HemnesUp == false && KivikUp == false && MockelbyUp == false && AvsiktligUp == false && MickeUp == false && NorrarydUp == false && HemnesSengUp == false)
        {
            GUI.Label(new Rect(75, 110, 200, 100), "Box content: Pick up an object", guiSize);
        }

    }
    public void DetachBox()
    {
        BigBoks.transform.parent = null;
        MediumBoks.transform.parent = null;
        SmallBoks.transform.parent = null;
        timeOfLastPickUp = Time.time;
        BigBoks.AddComponent<Rigidbody>();
        MediumBoks.AddComponent<Rigidbody>();
        SmallBoks.AddComponent<Rigidbody>();
        myAnimator.SetBool("HoldingBoks", false);
        HoldingBoks = false;
        KnottenUp = false;
        MartinUp = false;
        BillyUp = false;
        LerhamnUp = false;
        HemnesUp = false;
        KivikUp = false;
        MockelbyUp = false;
        AvsiktligUp = false;
        MickeUp = false;
        NorrarydUp = false;
        HemnesSengUp = false;

    }
    public void Kick()
    {
        myAnimator.CrossFade("Kick", crossfadeTime);
        var kickableMask = 1 << LayerMask.NameToLayer("Kickable");
        Collider[] ObjectsToKick = Physics.OverlapBox(transform.position + new Vector3(0, 3.5f, 3.5f), new Vector3(2, 3, 4), transform.rotation, kickableMask);

        foreach(Collider ObjectToKick in ObjectsToKick) {
            ObjectToKick.GetComponent<Rigidbody>().AddForce(transform.forward * kickForceFor + transform.up * kickForceUp, ForceMode.Impulse);
        }
    }





}
