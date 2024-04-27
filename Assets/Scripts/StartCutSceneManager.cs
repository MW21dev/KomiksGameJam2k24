using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class StartCutSceneManager : MonoBehaviour
{
    public Sprite[] cutSceneSprites;

    public Image currentSprite;

    public int stage = 0;

    private void Awake()
    {
        currentSprite.sprite = cutSceneSprites[0];
        stage = Mathf.Clamp(stage, 0, 8);

    }

    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(stage < 8)
            {
                ++stage;
                currentSprite.sprite = cutSceneSprites[stage];
            }
            else
            {
                stage = 8;
                SceneManager.LoadScene("Game", LoadSceneMode.Single);
            }
        }
        
       
        
        
    }
}
