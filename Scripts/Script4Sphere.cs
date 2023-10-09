using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script4Sphere : MonoBehaviour
{
    [Range(0f, 2f)]
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody>().transform.Translate(new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0) * speed);
        }
    }
}
