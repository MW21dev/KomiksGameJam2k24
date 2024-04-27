using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int sinAmmount;
    

    public GameObject pickedItem;

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
