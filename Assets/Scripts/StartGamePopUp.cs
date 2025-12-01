using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class StartGamePopUp : MonoBehaviour
{
    public GameObject StartUp;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 1;
        StartUp.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.E))
       {
           HidePopUp();
       }
    }

    public void HidePopUp()
    {
        StartUp.SetActive(false);
        Time.timeScale = 1;
    }
}
