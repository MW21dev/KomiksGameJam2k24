using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_BottleOfWine : NPCScript
{
    public string itemName;
    public override void Interact()
    {
        SpriteRenderer spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        SpriteRenderer pickedItemSprite = GameObject.Find("PickedItem").GetComponent<SpriteRenderer>();
        PlayerStats playerStats = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();

        playerStats.pickedItem = gameObject;

        pickedItemSprite.sprite = spriteRenderer.sprite;

        Debug.Log($"{name} is picked");
        gameObject.SetActive(false);
    }
}
