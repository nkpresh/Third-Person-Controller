using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{

    private void Start()
    {
        Destroy(gameObject, 10);
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(transform.GetComponent<Rigidbody>());

        if (other.tag == "Dragon")
        {
            transform.parent = other.transform;
            other.GetComponent<Dragon>().TakeDamage(20);
        }
    }
}
