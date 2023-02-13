using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    
    Button btnStart,btnLevels,btnQuit;

    void Start()
    {
        btnStart = GameObject.Find("StartButton").GetComponent<Button>();
        btnLevels = GameObject.Find("LevelButton").GetComponent<Button>();
        btnQuit = GameObject.Find("QuitButton").GetComponent<Button>();   
        
        btnStart.onClick.AddListener(StartGame);
        btnStart.onClick.AddListener(SelectLevelsScene);
        btnStart.onClick.AddListener(QuitGame);     
    }   

    private void StartGame()
    {
        
    }
    
    private void SelectLevelsScene()
    {
        
    }

    private void QuitGame()
    {
        
    }

    void OnDisable() 
    {
        btnLevels.onClick.RemoveAllListeners();
    }
}
