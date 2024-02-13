using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    Rigidbody rigidbody;
    float horizontal, vertical;
    // Start is called before the first frame update
    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update(){
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        rigidbody.velocity = new Vector3(horizontal* speed* Time.fixedDeltaTime, rigidbody.velocity.y, vertical * speed * Time.fixedDeltaTime);
    }
}
