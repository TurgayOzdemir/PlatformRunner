using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    Rigidbody rb;
    private void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 forward = transform.forward * speed * Time.deltaTime;
        rb.MovePosition(rb.position + forward);
    }
}
