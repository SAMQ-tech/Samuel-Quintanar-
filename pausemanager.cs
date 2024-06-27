using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausemanager : MonoBehaviour
{
    [SerializeField] private GameObject pause;
    private bool clickedOnce = false;
    void Update()
    {
        if(Input.GetButtonDown("Pause"))
        {
            if (!clickedOnce)
            {
                pause.SetActive(true);
                Time.timeScale = 0f;
                clickedOnce = true;
            }
            else
            {
                pause.SetActive(false);
                Time.timeScale = 1f;
                clickedOnce = false;
}

}
            }
}
