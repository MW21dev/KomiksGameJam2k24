using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject player;

    public GameObject[] NPCItems;
    public GameObject[] NPCS;

    

    public GameObject winScreen;
    public GameObject loseScreen;
    

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }

        SpawnPlayer(player);

        

    }

    private void Update()
    {
        if(PlayerStats.Instance.sinAmmount >= 6)
        {
            Invoke("Restart", 0.3f);
        }

        if(PlayerStats.Instance.blessAmmount >= 6)
        {
            winScreen.SetActive(true);
        }

    }

    public void SpawnPlayer(GameObject player)
    {
        Instantiate(player, new Vector3(-5, 5, 0), Quaternion.identity);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }

}
