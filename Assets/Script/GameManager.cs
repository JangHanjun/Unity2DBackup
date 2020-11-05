﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int stageIndex;

    private static GameManager _instance;
    public static GameManager Instance {
        get {
            if (_instance == null) {
                _instance = FindObjectOfType<GameManager>();
            }
            return _instance;
        }
    }

    // GameOver
    public void GameOver() {
        Debug.Log("Game Over...");
        // SceneManager.LoadScene("GameOver"); 아직 게임오버 씬은 없다
    }

    //Stage
    public void nextStage(){
        stageIndex++;
    }
}
