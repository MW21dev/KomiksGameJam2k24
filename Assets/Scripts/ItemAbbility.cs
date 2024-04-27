using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAbbility : MonoBehaviour
{
    public PlayerStats playerStats;

    private void Start()
    {
        playerStats = GetComponent<PlayerStats>();
    }
    public void UseItem(string itemName)
    {
        switch (itemName)
        {
            case "Stick":
                playerStats.blessAmmount += 1;
                playerStats.pickedItem = null;
                break;

        }
    }
}
