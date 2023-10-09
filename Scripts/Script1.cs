using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1 : MonoBehaviour
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
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            print("LeftArrow: " + new Vector3(speed * Input.GetAxis("Horizontal"), speed * Input.GetAxis("Vertical"), 0));
        } else if (Input.GetKey(KeyCode.RightArrow))
        {
            print("RightArrow: " + new Vector3(speed * Input.GetAxis("Horizontal"), speed * Input.GetAxis("Vertical"), 0));
        } else if (Input.GetKey(KeyCode.UpArrow)) 
        {
            print("UpArrow: " + new Vector3(speed * Input.GetAxis("Horizontal"), speed * Input.GetAxis("Vertical"), 0));
        } else if (Input.GetKey(KeyCode.DownArrow))
        {
            print("DownArrow: " + new Vector3(speed * Input.GetAxis("Horizontal"), speed * Input.GetAxis("Vertical"), 0));
        }
    }
}
