using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public CanvasGroup dialogueScreen;

    public GameObject player;

    public GameObject[] NPCItems;
    public GameObject[] NPCS;

    public GameObject cathedraPosition;
    public GameObject flowerGuyPosition;
    public GameObject altarCultistPosition;

    public GameObject spawnPoint1;
    public GameObject spawnPoint2;
    public GameObject spawnPoint3;
    public GameObject spawnPoint4;
    public GameObject spawnPoint5;
    public GameObject spawnPoint6;

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

    private void Start()
    {
        SpawnEvents();
    }

    private void Update()
    {
        

        if(PlayerStats.Instance.blessAmmount >= 6)
        {
            winScreen.SetActive(true);
            Invoke("EndGame", 20f);
        }

        if (PlayerStats.Instance.sinAmmount >= 6)
        {
            PlayerMovement.Instance.playerRigidbody.velocity = Vector2.zero;
            PlayerStats.Instance.canMove = false;
            Invoke("Restart", 1f);
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

    public void SpawnEvents()
    {
        int x = Random.Range(0, NPCItems.Length - 1);
        Instantiate(NPCItems[x], spawnPoint1.transform.position, Quaternion.identity);
        int y = Random.Range(0, NPCItems.Length - 1);
        Instantiate(NPCItems[y], spawnPoint2.transform.position, Quaternion.identity);
        int z = Random.Range(0, NPCItems.Length - 1);
        Instantiate(NPCItems[z], spawnPoint3.transform.position, Quaternion.identity);
        int a = Random.Range(0, NPCItems.Length - 1);
        Instantiate(NPCItems[a], spawnPoint4.transform.position, Quaternion.identity);
        int b = Random.Range(0, NPCItems.Length - 1);
        Instantiate(NPCItems[b], spawnPoint5.transform.position, Quaternion.identity);
        int c = Random.Range(0, NPCItems.Length - 1);
        Instantiate(NPCItems[c], spawnPoint6.transform.position, Quaternion.identity);



    }

    public void EndGame()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
}
