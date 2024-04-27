using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject player;

    public GameObject[] NPCItems;
    public GameObject[] NPCS;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }

        SpawnPlayer(player);
    }

    public void SpawnPlayer(GameObject player)
    {
        Instantiate(player, new Vector3(-5, 5, 0), Quaternion.identity);
    }


}
