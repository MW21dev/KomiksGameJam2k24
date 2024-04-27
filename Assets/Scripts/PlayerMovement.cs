using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D playerRigidbody;
    public SpriteRenderer pickedItemSprite;

    private PlayerStats playerStats;
    private ItemAbbility itemAbbility;

    public float playerMoveSpeed;

    Vector2 move = Vector2.zero;
    
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
        playerStats = GetComponent<PlayerStats>();
        itemAbbility = GetComponent<ItemAbbility>();
    }

    
    void Update()
    {
        move.x = Input.GetAxis("Horizontal");
        move.y = Input.GetAxis("Vertical");

        if (playerStats.isItemPicked())
        {
            pickedItemSprite.enabled = true;
        }
        else
        {
            pickedItemSprite.enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(playerStats.isItemPicked())
            {
                itemAbbility.UseItem(playerStats.pickedItem.name);
            }
            
        }

    }

    private void FixedUpdate()
    {
        playerRigidbody.velocity = new Vector2(move.x * playerMoveSpeed * Time.fixedDeltaTime, move.y * playerMoveSpeed * Time.fixedDeltaTime);
        playerRigidbody.velocity.Normalize();
    }
}
