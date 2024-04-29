using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats Instance;
    
    public int sinAmmount;
    public int blessAmmount;

    public bool canMove;

    public GameObject pickedItem;
    public NPC_BottleOfWine itemScript;
    public string pickedItemName;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        
    }

    private void Start()
    {
        canMove = true;
    }

    private void Update()
    {
        if(pickedItem != null)
        {
            itemScript = pickedItem.GetComponent<NPC_BottleOfWine>();
            pickedItemName = itemScript.itemName;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {

            if (isItemPicked())
            {
                Instantiate(pickedItem, transform.position, Quaternion.identity);
                pickedItem = null;
            }
        }

        if(sinAmmount < 0)
        {
            sinAmmount = 0;
        }

        if(blessAmmount < 0)
        {
            blessAmmount = 0;
        }
    }

    public bool isItemPicked()
    {
        if(pickedItem != null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
