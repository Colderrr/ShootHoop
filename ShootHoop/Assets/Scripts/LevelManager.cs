using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelManager : MonoBehaviour {

    public float timeTillNextLevel = 0.0f;
	// Use this for initialization
	void Start ()
    {
    }

    // Update is called once per frame
    void Update () {
       
        if (timeTillNextLevel > 0)
        {
            timeTillNextLevel -= Time.deltaTime;

            if (timeTillNextLevel < 0)
            {
                LoadNextScene();
            }
        }
    }

    public void LoadNextScene()
    {
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentIndex + 1 > 2)
            currentIndex = -1;
        SceneManager.LoadScene(currentIndex + 1);
    }

    void LoadPreviousScene()
    {
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentIndex - 1);
    }
}
