using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer meshren;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        meshren.enabled = false;
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
          if (Time.time > 5){
            meshren.enabled = true;
            rb.useGravity = true;
        }
    }
}
