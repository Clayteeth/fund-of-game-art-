using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCollectible : MonoBehaviour
{
    [Header("References")]
    // The version of the item to show on display when collected
    public GameObject displayVersion;

    [Header("Properties")]
    public float interactDistance = 3f;

    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (player == null) return;

        float distance = Vector3.Distance(player.position, transform.position);

        if (distance <= interactDistance && Input.GetKeyDown(KeyCode.E))
        {
            Collect();
        }
    }

    void Collect()
    {
        // Hide collectible in the world
        gameObject.SetActive(false);

        // Show the display version
        if (displayVersion != null)
        {
            displayVersion.SetActive(true);
        }
    }
}