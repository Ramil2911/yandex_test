using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BoxBehaviour : MonoBehaviour
{
    [SerializeField] private float timeToMove; // время в покое
    [SerializeField] private float timeToWait; // время ожидания
    void Start()
    {
        StartCoroutine(Move(Convert.ToBoolean(Random.Range(0,1)) ? 1 : -1,Random.Range(timeToMove-1, timeToMove+1),
            Random.Range(timeToWait-1,timeToWait+1))); //отсюда они до своего уничтожения двигаются
    }

    IEnumerator Move(float speed, float timeToMove, float timeToWait)
    {
        yield return new WaitForSeconds(timeToWait);
        float elapsedTime = 0;
        
        while (elapsedTime < timeToMove)
        {
            transform.position += Vector3.up * (Time.deltaTime * speed);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        StartCoroutine(Move(-speed, timeToMove, timeToWait));
    }
}
