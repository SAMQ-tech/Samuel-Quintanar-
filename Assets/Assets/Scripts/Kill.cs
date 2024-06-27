using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour
{
    [SerializeField] private GameObject _panel;


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Kill")
        {
            _panel.SetActive(true);

        }
    }


}
