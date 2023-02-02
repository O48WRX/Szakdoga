using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGoalScript : MonoBehaviour
{
    private Transform playerTransform;

    public Transform TeleportLocation;

    private void Start()
    {
        playerTransform = GameObject.Find("Player").transform;
        TeleportLocation = GameObject.Find("Spawn").transform;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerTransform.position = TeleportLocation.position;
        }
    }
}
