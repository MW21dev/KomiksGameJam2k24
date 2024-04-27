using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats Instance;
    
    public int sinAmmount;
    public int blessAmmount;
    

    public GameObject pickedItem;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
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
