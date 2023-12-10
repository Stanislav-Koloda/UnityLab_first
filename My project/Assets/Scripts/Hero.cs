using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Hero : MonoBehaviour
{

    [SerializeField] private float speed;
    private Rigidbody rb;
    private float horizontal;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");

    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(horizontal, 0f) * speed;
    }
}
