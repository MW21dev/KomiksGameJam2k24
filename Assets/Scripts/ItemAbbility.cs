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
            case "Prayer":
                playerStats.blessAmmount += 1;
                playerStats.pickedItem = null;
                break;
            case "Rosary":
                playerStats.blessAmmount += 1;
                playerStats.sinAmmount -= 1;
                playerStats.pickedItem = null;


                break;
            case "Bottle of Wine":
                int x = Random.Range(0, 10);
                if(x < 5)
                {
                    playerStats.blessAmmount += 1;
                    playerStats.pickedItem = null;

                }
                else
                {
                    playerStats.sinAmmount += 1;
                    playerStats.pickedItem = null;

                }
                break;
            case "Coin":
                //int n = Random.Range(0, GameManager.Instance.NPCItems.Length - 1);
                if(Vector2.Distance(transform.position, GameManager.Instance.cathedraPosition.transform.position) < 1)
                {
                    playerStats.blessAmmount += 1;
                    playerStats.pickedItem = null;

                }
                else
                {
                    playerStats.sinAmmount += 1;
                    playerStats.pickedItem = null;

                }
                //Instantiate(GameManager.Instance.NPCItems[n], transform.position, Quaternion.identity);
                break;
            case "Meat":
                playerStats.blessAmmount += 1;
                Instantiate(GameManager.Instance.NPCItems[0], transform.position, Quaternion.identity);
                playerStats.pickedItem = null;

                break;
            case "Corrupted Meat":
                playerStats.sinAmmount += 3;
                playerStats.pickedItem = null;

                break;
            case "Pandora's Box":
                int n = Random.Range(0, GameManager.Instance.NPCItems.Length - 1);
                int u = 2;
                if (u > 0)
                {
                    Instantiate(GameManager.Instance.NPCItems[n], transform.position, Quaternion.identity);
                    playerStats.sinAmmount += 2;
                    u -= 1;

                }
                else
                {
                    playerStats.pickedItem = null;
                }

                break;
            case "Flower":
                if (Vector2.Distance(transform.position, GameManager.Instance.flowerGuyPosition.transform.position) < 1)
                {
                    playerStats.blessAmmount += 2;
                    playerStats.sinAmmount += 2;
                    playerStats.pickedItem = null;

                }
                break;






        }
    }
}
