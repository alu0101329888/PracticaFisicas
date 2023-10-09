using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script5Cube : MonoBehaviour
{
    [Range(0f, 10f)]
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
        {
            float velocity = Time.deltaTime * speed;
            GetComponent<Rigidbody>().transform.Translate(new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0) * velocity, Space.World);
        }
    }
}
