using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public SpriteRenderer gameOverScreen;
    public Text gameOverText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ShowGameOverUI()
    {
        gameOverScreen.enabled = true;
        gameOverText.enabled = true;
    }
}
