using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ObstaclesAnimation : MonoBehaviour
{
    //Half Donut
    [SerializeField] private GameObject halfDonutStick;
    [SerializeField] private Transform halfDonutForward;
    [SerializeField] private Transform halfDonutBackward;

    //Rotator
    [SerializeField] private GameObject rotator;



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

    IEnumerator HalfDonut()
    {
        while (true)
        {
            halfDonutStick.transform.DOMoveX(halfDonutForward.position.x, 0.5f);
            yield return new WaitForSeconds(1.3f);
            halfDonutStick.transform.DOMoveX(halfDonutBackward.position.x, 0.5f);
            yield return new WaitForSeconds(1.3f);
            yield return null;
        }
    }

    IEnumerator Rotator()
    {
        while (true)
        {
            rotator.transform.DORotate(new Vector3(0, -180, 0), 1f);
            yield return new WaitForSeconds(1);
            rotator.transform.DORotate(new Vector3(0, 0, 0), 1f);
            yield return new WaitForSeconds(1);
            yield return null;
        }
    }
    IEnumerator RotatingPlatform()
    {
        while (true)
        {
            transform.DORotate(new Vector3(0, 0, 180), 1f);
            yield return new WaitForSeconds(1);
            transform.DORotate(new Vector3(0, 0, 0), 1f);
            yield return new WaitForSeconds(1);
            yield return null;
        }
    }

    private void Start()
    {
        if (gameObject.CompareTag("HorizontalObstacle"))
        {
            StartCoroutine(HorizontalObstacle());
        }
        if (gameObject.CompareTag("HalfDonut"))
        {
            StartCoroutine(HalfDonut());
        }
        if (gameObject.CompareTag("Rotator"))
        {
            StartCoroutine(Rotator());
        }
        if (gameObject.CompareTag("RotatingPlatform"))
        {
            StartCoroutine(RotatingPlatform());
        }

    }

}
