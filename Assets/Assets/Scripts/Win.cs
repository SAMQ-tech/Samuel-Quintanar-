using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    [SerializeField] private GameObject _panel;


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "win")
        {
            _panel.SetActive(true);

        }
    }


}

