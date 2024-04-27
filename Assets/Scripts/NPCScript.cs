using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class NPCScript : MonoBehaviour, IInteractable
{
    private Transform playerTransform;
    public float interactDisntance;

    private void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.E) && isWithinInteractDistance())
        {
            Interact();
        }
    }

    public bool isWithinInteractDistance()
    {
        if (Vector2.Distance(playerTransform.position, transform.position) < interactDisntance)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public abstract void Interact();
    
}

