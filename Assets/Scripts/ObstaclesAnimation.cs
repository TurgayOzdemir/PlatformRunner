using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ObstaclesAnimation : MonoBehaviour
{
    IEnumerator HorizontalObstacle()
    {
        while (true)
        {
            transform.DORotate(new Vector3(0, 180, 0), 0.5f);
            yield return new WaitForSeconds(0.5f);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            yield return null;
        }
        
    }

    private void Start()
    {
        if (gameObject.CompareTag("HorizontalObstacle"))
        {
            StartCoroutine(HorizontalObstacle());
        }
    }

}
