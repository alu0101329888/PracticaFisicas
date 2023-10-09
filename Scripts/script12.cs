using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script12 : MonoBehaviour
{
    public float speed;
    GameObject sphere;
    // Start is called before the first frame update
    void Start()
    {
        sphere = GameObject.FindGameObjectWithTag("Sphere");
    }

    // Update is called once per frame
    void Update()
    {
        float velocity = Time.deltaTime * speed;
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W)) {
            GetComponent<Rigidbody>().AddForce(new Vector3(Input.GetAxis("Vertical"), 0, Input.GetAxis("Horizontal")) * velocity, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.Z)) {
            GetComponent<Rigidbody>().transform.LookAt(sphere.GetComponent<Transform>());
            GetComponent<Rigidbody>().transform.Translate(GetComponent<Rigidbody>().transform.forward.normalized * velocity, Space.World);
        }
    }

    private void OnCollisionEnter(Collision collision) {
        GetComponent<Rigidbody>().drag *= 2;
    }
}
