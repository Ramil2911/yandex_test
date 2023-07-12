using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextTrigger : MonoBehaviour
{
    [SerializeField] private TileGenerator _tileGenerator;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            _tileGenerator.Next();
        }
    }
}
