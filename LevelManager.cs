using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour 
{

	public bool winByCoins;
	public bool playerChanceTracker;

	void Update()
	{
		if (winByCoins == true) 
		{

			WinByCoinsDetector ();
		}

		if (playerChanceTracker == true) 
		{
			LostAllChancesDetector ();

		}
			
	
	}

	public void LoseChanceAndReset()
	{
		Application.LoadLevel (Application.loadedLevel);
	}

	public void NextLevelToLoad()
	{
		Application.LoadLevel (Application.loadedLevel +1);
	}

	public void LoseGame()
	{
		Application.LoadLevel("Lose");


	}

	public void PlayGame()
	{

		GameManager.score = 0;
		GameManager.playerChances = 3;
		GameManager.totalCoinCount = 0;
		Application.LoadLevel("Game");

	}

	public void WinScreen()
	{
		Application.LoadLevel("Win");
	}

	public void QuitRequest()
	{
		Application.Quit ();
	}

	void WinByCoinsDetector()

	{
		if (GameManager.totalCoinCount == 0) 
		{
			NextLevelToLoad();
		}
	}

	void LostAllChancesDetector()
	{
		if (GameManager.playerChances == 0) 
		{
			LoseGame();
		}
	}


}
