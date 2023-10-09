using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script7 : MonoBehaviour
{
    GameObject sphere;
    [Range(0f, 10f)]
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        sphere = GameObject.FindGameObjectWithTag("Sphere");
    }

    // Update is called once per frame
    void Update()
    {
        float velocity = Time.deltaTime * speed;
        GetComponent<Rigidbody>().transform.LookAt(sphere.GetComponent<Transform>());
        GetComponent<Rigidbody>().transform.Translate(GetComponent<Rigidbody>().transform.forward.normalized * velocity, Space.World);
    }
}
