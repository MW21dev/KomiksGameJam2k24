using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapTileScript : MonoBehaviour
{
    public GameObject[] mapTiles;

    public Sprite[] map1Sprites;
    public Sprite[] map2Sprites;
    public Sprite[] map3Sprites;

    public SpriteRenderer spriteRenderer;
    public Camera mainCamera;

    public int mapTileId;
    public float cameraSpeed = 5f;
    private bool isCameraMoving = false;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        mainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        RandomizeMapTile();
        
        //SetMapSprites(mapTileId);


    }

    private void Update()
    {
        
        // ruch kamery z przesunieciem
        if (isCameraMoving)
        {
            mainCamera.transform.position = Vector3.MoveTowards(mainCamera.transform.position, new Vector3(transform.position.x, transform.position.y, mainCamera.transform.position.z), cameraSpeed * Time.deltaTime);
        }

        if (mainCamera.transform.position.x == transform.position.x && mainCamera.transform.position.y == transform.position.y)
        {
            isCameraMoving = false;
        }
    }
    

    public void RandomizeMapTile()
    {
        Random.Range(0, mapTiles.Length);
    }

    public void MoveCamera()
    {
       isCameraMoving = true;
    }

    private void SetMapSprites(int mapTileId)
    {
        
        spriteRenderer.sprite = map1Sprites[mapTileId];
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            //Tutaj alternatywa na skok kamery a nie ruch
            //mainCamera.transform.position = new Vector3(transform.position.x, transform.position.y, -10f);

           MoveCamera();
            
        }
    }
}
