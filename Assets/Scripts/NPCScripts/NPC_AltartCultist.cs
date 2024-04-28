using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;



public class NPC_AltarCultist : NPCScript, ITalkable
{
    private CanvasGroup dialogueScreen;
    private TMP_Text dialogueText;

    [TextArea]
    public string text;

    [SerializeField]
    private int dialogueStage;

    private void Awake()
    {
        dialogueScreen = GameObject.Find("DialogueScreen").GetComponent<CanvasGroup>();
        dialogueText = dialogueScreen.transform.Find("DialogueText").GetComponent<TMP_Text>();
        dialogueStage = 1;
    }

    public override void Interact()
    {
        if (dialogueStage == 1)
        {
            dialogueText.SetText(text);
            dialogueScreen.alpha = 1;

            dialogueStage -= 1;

        }
        else if (dialogueStage == 0)
        {

            Action();
            dialogueStage -= 1;
        }
    }

    public void Talk()
    {

    }

    public void Action()
    {
        int x = Random.Range(0, 1);
        dialogueScreen.alpha = 0;
        if (x == 0)
        {
            PlayerStats.Instance.blessAmmount += 2;

        }
        else
        {
            PlayerStats.Instance.sinAmmount += 6;

        }

    }
}
