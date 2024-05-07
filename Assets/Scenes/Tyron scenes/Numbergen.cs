using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Alteruna;
using JetBrains.Annotations;
using Unity.VisualScripting;
public class RoleGiver: AttributesSync,IInteractable
{
    public GameObject hunterCanvas;
    public GameObject preyCanvas;

    public GameObject[] players;

    public GameObject GiveObject()
    {
        return gameObject;
    }

    public void InitInteract(string interactor)
    {
        BroadcastRemoteMethod("Interact", interactor);

    }

    [SynchronizableMethod] 
    public void Interact(string interactor)
    {

       
            
        if (players.Length > 0)
        {
            int hunterIndex = Random.Range(0, players.Length);

            for (int i = 0; i < players.Length; i++)
            {
                Alteruna.Avatar avatar = players[i].GetComponent<Alteruna.Avatar>();

                if (i == hunterIndex)
                {
                    players[i].layer = LayerMask.NameToLayer("Hunter");

                    if (avatar.IsMe)
                        return;
                    hunterCanvas.SetActive(true);

                    

                }
                else
                {

                    players[i].layer = LayerMask.NameToLayer("Prey");

                    if (avatar.IsMe)
                        return;
                    preyCanvas.SetActive(true);
                }
            }
        }
        gameObject.SetActive(false);

    }

    public void Tag(GameObject tagger, GameObject tagged) 
    {
        tagged.transform.position = new Vector3(63.7f, 10.58f, -17.28f);

    }

    void Start()
    {

    }

    void Update()
    {

    }
}
