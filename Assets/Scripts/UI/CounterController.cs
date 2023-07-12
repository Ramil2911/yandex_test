using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterController : MonoBehaviour
{
    [SerializeField] private Text _text;
    
    private int _count;

    private void Start()
    {
        if (_text == null) _text = GetComponent<Text>();
    }

    public void Increment()
    {
        _count++;
        _text.text = _count.ToString();
    }
}
