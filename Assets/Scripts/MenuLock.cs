using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(PlayerMovement))]
public class MenuLock : MonoBehaviour //переключает компоненты для начала игры
{
    [SerializeField] private Text menuText;
    public void Action()
    {
        GetComponent<PlayerMovement>().enabled = true;
        menuText.enabled = false;
    }
}
