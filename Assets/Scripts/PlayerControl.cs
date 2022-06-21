using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private float horizontalSpeed=2.5f;
    [SerializeField] private float verticalSpeed = 1.5f;
    Rigidbody rb;

    private PlayerInput _playerInput;
    private InputAction _moveAction;

    private void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();
        _moveAction = _playerInput.actions["Move"];


        rb = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector2 input = _moveAction.ReadValue<Vector2>();
        rb.MovePosition(transform.position + new Vector3(input.x * Time.deltaTime * horizontalSpeed, 0, 0));

        Vector3 forward = transform.forward * verticalSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + forward);
    }
}
