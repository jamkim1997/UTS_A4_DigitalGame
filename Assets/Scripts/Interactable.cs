using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    private bool isInRange;
    public UnityEvent interactAction;
    public Transform text;
    [SerializeField] bool save;

    void Update()
    {
        if(isInRange)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                interactAction.Invoke();
                if (text && !save)
                {
                    Destroy(text.gameObject);
                }

                if(!save)
                {
                    Destroy(this);
                }
               
            }
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            if (text)
            {
                text.gameObject.SetActive(true);
            }
            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            isInRange = false;
            if (text)
            {
                text.gameObject.SetActive(false);
            }
            
        }
    }
}
