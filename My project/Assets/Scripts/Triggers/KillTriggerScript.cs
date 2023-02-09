using StateLibrary.ActorState.PlayerState;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillTriggerScript : MonoBehaviour
{
    private PlayerMovementBehaviour playerMovement;
    private playerAttack playerAttack;

    // Start is called before the first frame update
    void Start()
    {
        playerAttack = GameObject.FindObjectOfType(typeof(playerAttack)) as playerAttack;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (playerAttack.IsPlayerDead()) return;

        if (collision.gameObject.tag == "Player")
        {
            playerAttack.TakeDamage(500);
            Destroy(this);
        }
    }
}
