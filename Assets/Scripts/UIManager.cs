using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Slider sinSlider;
    public Slider blessSlider;
    
    public PlayerStats playerStats;

    public int maxSin = 3;
    public int minSin = 0;
    public int currentSin;

    public int maxBless = 3;
    public int minBless = 0;
    public int currentBless;

    private void Start()
    {
        playerStats = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();

        sinSlider.maxValue = maxSin;
        sinSlider.minValue = minSin;

        blessSlider.maxValue = maxBless;
        blessSlider.minValue = minBless;    

    }


    private void Update()
    {
        sinSlider.value = currentSin;
        currentSin = playerStats.sinAmmount;

        blessSlider.value = currentBless;
        currentBless = playerStats.blessAmmount;
    }
}
