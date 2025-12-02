using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public ShelfItem[] slots;   // Drag your slots here
    public GameObject winUI;    // Assign your win screen

    bool inRange = false;


    void Start()
    {
        winUI.SetActive(false);
    }

    void Update()
    {
        if (inRange && Input.GetKeyDown(KeyCode.E))
        {
            if (AllItemsCollected())
            {
                WinGame();
            }
            // If NOT all collected, pressing E does nothing
        }
    }

    bool AllItemsCollected()
    {
        foreach (ShelfItem s in slots)
        {
            if (!s.isFilled)
                return false;
        }
        return true;
    }

    void WinGame()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        Time.timeScale = 0; // freeze game
        winUI.SetActive(true);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            inRange = true;
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            inRange = false;
    }
}
