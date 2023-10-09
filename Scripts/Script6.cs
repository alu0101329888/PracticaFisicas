using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script6 : MonoBehaviour
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
        Vector3 direction = sphere.transform.position - transform.position;
        direction = direction.normalized;
        float velocity = Time.deltaTime * speed;
        GetComponent<Rigidbody>().transform.Translate(direction * velocity, Space.World);
    }
}
