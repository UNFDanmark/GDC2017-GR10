using UnityEngine;
using System.Collections;

public class KnottenBoks : MonoBehaviour
{
    public Rigidbody RigidKnottenBoks;

    // Use this for initialization
    void Start()
    {
        RigidKnottenBoks = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            RigidKnottenBoks.constraints = RigidbodyConstraints.None;
        }
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            RigidKnottenBoks.constraints = RigidbodyConstraints.FreezeAll;



        }

    }
}