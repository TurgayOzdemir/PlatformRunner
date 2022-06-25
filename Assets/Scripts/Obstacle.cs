using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("AI"))
        {
            other.gameObject.transform.position = new Vector3(0, 0, 0);

        }
    }

}
