using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour {

    public GameManager gameManager;

    void OnCollisionEnter2D(Collision2D coll)
    {
        gameManager.ShowGameOverUI();
        Time.timeScale = 0;   
    }
}
