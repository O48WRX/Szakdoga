using StateLibrary.ActorState.PlayerState;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleDmgPickup : MonoBehaviour
{
    public playerAttack playerAttack;

    // Start is called before the first frame update
    void Start()
    {
        // Getting subject script
        playerAttack = GameObject.FindObjectOfType(typeof(playerAttack)) as playerAttack;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        // Observer calls setState function.
        if (collision.gameObject.tag == "Player")
        {
            playerAttack.setState(new PlayerDoubledDMG());
            Destroy(GameObject.Find("DoubleDmgPickup"));
            Destroy(this);
        }
    }
}
