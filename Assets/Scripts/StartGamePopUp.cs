using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class StartGamePopUp : MonoBehaviour
{
    public GameObject StartUp;

    public GameObject Objective;

    public GameObject blackScreenImage;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 1;
        StartUp.SetActive(true);
        Objective.SetActive(false);

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
        Objective.SetActive(true);
    }
}
