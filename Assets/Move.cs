using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Vector3 direction = Vector3.forward;
    public float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.rotation*(direction.normalized * speed * Time.deltaTime);
    }
}
