using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Bob : NPCScript
{
    public override void Interact()
    {
        PlayerStats playerStats = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();
        playerStats.sinAmmount += 1;
        
        Debug.Log("DUPA");
        
    }

    
}
