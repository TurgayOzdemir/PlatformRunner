using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] GameObject player;
    Vector3 offset;

    private void Awake()
    {
        offset = transform.position - player.transform.position;
    }

    private void Update()
    {
        Vector3 targetPos = player.transform.position + offset;
        targetPos.x = 0;
        transform.position = targetPos;
    }
}
