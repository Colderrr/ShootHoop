using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeRemainingDisplay : MonoBehaviour
{
    Text text;
    LevelManager levelManager;
    // Use this for initialization
    void Start () {
        levelManager = FindObjectOfType<LevelManager>();
        text = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        text.text = "Time: " + levelManager.timeTillNextLevel;
    }
}
