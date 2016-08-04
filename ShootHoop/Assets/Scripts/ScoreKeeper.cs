using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {

    public int score = 0;
	// Use this for initialization
	void Start ()
    {
        DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}


    public void IncrementTheScore(int amount)
    {
        score += amount;
        PlaySound();
    }

    void PlaySound()
    {
        AudioSource source = GetComponent<AudioSource>();
        source.Play();
    }
}
