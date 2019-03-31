using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    public Text timeText;
    public Text coinsText;
    public GameObject canvas;

    public AudioClip theme;
    public AudioClip starman;
    public GameObject flower;
    public GameObject mushroom;
    public PlayerController player;

    AudioSource source;
	ScoreManager scoreManager;

    void Awake()
    {
        source = GetComponent<AudioSource>();
		scoreManager = FindObjectOfType<ScoreManager>();
    }

    private void Update()
    {
        timeText.text = Mathf.Round(scoreManager.GetCurrentTime()).ToString();
    }

    IEnumerator ReloadScene()
    {
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene(0);
    }

    
    public void LoadEndScene()
    {
        SceneManager.LoadScene(1) ;
    }

	public void RestartGame()
	{
		GetComponent<AudioSource>().Stop();
		StartCoroutine("ReloadScene");
	}

    public void PlayTheme()
    {
        source.clip = theme;
        source.Play();
    }

    public void PlayStarman()
    {
        source.clip = starman;
        source.Play();
    }


    
}
