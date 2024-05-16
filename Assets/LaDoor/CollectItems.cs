﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CollectItems : MonoBehaviour
{
    [SerializeField] public Animator Dooranim;
    public GameObject Diamonds;
    private static int diamondsCollected = 0;
    private int requiredDiamonds = 1;
    private bool isCollected = false;
    public Text diamondCountText;
    private Renderer _renderer;
    private Collider _collider;

    void Start()
    {
        _renderer = GetComponent<Renderer>();
        _collider = GetComponent<Collider>();
        if (Diamonds != null)
        {
            Diamonds.SetActive(true);  // Ensure the diamond is visible and interactable at the start
        }
        UpdateDiamondText();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && !isCollected)// && Input.GetKey(KeyCode.E) && )
        {
            CollectDiamond();
        }
    }
    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        diamondsCollected = 0;  // Reset the diamonds count when the scene is loaded
        UpdateDiamondText();  // Update the diamond text to reflect the reset count
    }

    private void CollectDiamond()
    {
        //if (_renderer != null)
        //{
        //    _renderer.enabled = false;  // Make the object invisible
        //}
        //if (_collider != null)
        //{
        //    _collider.enabled = false;  // Disable the collider
        //}
        if (!isCollected)
        {

            Destroy(gameObject);
            isCollected = true;  // Mark the diamond as collected
            diamondsCollected++;
            UpdateDiamondText();
            CheckDiamondsCollected();
        }
    }
    private void CheckDiamondsCollected()
    {
        if (diamondsCollected >= requiredDiamonds)
        {
            DoorController doorController = Dooranim.GetComponent<DoorController>();
            if (doorController != null)
            {
                doorController.OpenDoor();  
            }
        }
    }
    void UpdateDiamondText()
    {
        if (diamondCountText != null)
        {
            diamondCountText.text = "Diamonds: " + diamondsCollected; 
        }
    }
}


    
