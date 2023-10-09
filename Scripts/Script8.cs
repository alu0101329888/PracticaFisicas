using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script8 : MonoBehaviour
{
    [Range(0f, 10f)]
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float velocity = Time.deltaTime * speed;
        GetComponent<Rigidbody>().transform.Rotate(0, Input.GetAxis("Horizontal") * speed, 0);
        GetComponent<Rigidbody>().transform.Translate(GetComponent<Rigidbody>().transform.forward.normalized * velocity, Space.World);
    }
}
