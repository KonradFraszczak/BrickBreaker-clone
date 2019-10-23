using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public int score;
	public int lives;
	public Text LivesText;
	public Text ScoreText;
	public Text highScoreText;
	public bool gameOver;
	public GameObject gameOverPanel;
	public int numberOfBricks;

	
    void Start()
    {
     LivesText.text = "Lives: " + lives;
	 ScoreText.text = "Score: " + score;
	 numberOfBricks = GameObject.FindGameObjectsWithTag("Brick").Length;
    }


    void Update()
    {
        
    }
	
	public void UpdateLives(int changeInLives)
	{
		lives += changeInLives;
		if (lives <= 0)
		{
			lives = 0;
			GameOver ();
		}
		LivesText.text = "Lives: " + lives;
	}
	
	public void UpdateScore(int changePoints)
	{
		score += changePoints;
		
		ScoreText.text = "Score: " + score;
	}
	
	public void UpdateBricks()
	{
		numberOfBricks--;
		if (numberOfBricks <= 0)
		{
			GameOver();
		}
	}
	
	void GameOver()
	{
		gameOver = true;
		gameOverPanel.SetActive (true);
		int highScore = PlayerPrefs.GetInt ("HIGHSCORE");
		if (score > highScore)
		{
			PlayerPrefs.SetInt ("HIGHSCORE", score);
			
			highScoreText.text = "New High Score! " + score;
		}
		else
		{
			highScoreText.text = "High Score " + highScore;
		}
	}
	
	public void PlayAgain()
	{
		SceneManager.LoadScene("SampleScene");
	}
	
	public void Quit()
	{
		SceneManager.LoadScene("Menu Scene");
		Debug.Log ("Menu Scene");
	}
}
