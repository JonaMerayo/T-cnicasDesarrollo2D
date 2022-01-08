using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	//public GameObject[] spawnList;
	public Vector2 spawnRangeY;
	public GameObject positionReference;
	public int spawnsPerWave=1;
	public float startWait=1;
	public float spawnWait=1;
	public float waveWait=1;
	public Text scoreText;
	public Text restartText;
	public Text gameOverText; 
	public bool waitForPlayerStart;

	private PlayerController2D playerCon;
	private int score;
	private bool gameOver;
	private bool restart;
	private bool gamePaused = false;

	
	void Start()
	{
		score = 0;
		UpdateScore();

        gameOver = false;
        if (gameOverText != null)
		{
			gameOverText.text = "";
		}

        restart = false;
		if (restartText != null)
		{
			restartText.text = "";
		}

		if (waitForPlayerStart)
		{
			//playerHasMoved = false;

			// We recover player delegated events script
			playerCon = GameObject.FindWithTag("Player").GetComponent<PlayerController2D>();
			playerCon.OnFirstPlayerMove += startToInanciate;
		}
        else
        {
			startToInanciate();
        }

    }
   
    void Update()
	{
		if (Input.GetKeyDown(KeyCode.P))
		{
			if (!restart)
            {
				if (!gamePaused)
				{
					PauseGame();
				}
				else
				{
					ResumeGame();
				}
			}
			
		}

		if (restart)
		{
			if (Input.GetKeyDown(KeyCode.R))
			{
                SceneManager.LoadScene("MainScene");
			}
		}

		if (gameOver)
		{
			restart = true;
			if (restartText != null)
			{
				restartText.text = "Press 'R' to Restart";
			}
		}

	}
	
	private void startToInanciate()
	{
		StartCoroutine(SpawnWaves());
	}

	IEnumerator SpawnWaves()
	{
		yield return new WaitForSeconds(startWait);

		while (true)
		{
			for (int i = 0; i < spawnsPerWave; i++)
			{
				//GameObject spawn = spawnList[Random.Range(0, spawnList.Length)];

				Vector3 spawnPosition = new Vector3(positionReference.transform.position.x, Random.Range(spawnRangeY.x, spawnRangeY.y), 0);

				PoolManager.Instance.GetNext().transform.position = spawnPosition;
				//Quaternion spawnRotation = Quaternion.identity;

				//Instantiate(spawn, spawnPosition, spawnRotation);

				yield return new WaitForSeconds(spawnWait);
			}

			yield return new WaitForSeconds(waveWait);

			if (gameOver)
			{
				//restart = true;
				//restartText.text = "Press 'R' to Restart";
				break;
			}
		}
	}
	
	void UpdateScore()
	{
		if (scoreText != null)
        {
			scoreText.text = "Score: " + score.ToString();
		}		
	}

	public void AddScore(int newScoreValue)
	{
		score += newScoreValue;
		UpdateScore();
	}

	public void GameOver()
	{
		gameOver = true;
		if (gameOverText != null)
		{
			gameOverText.text = "GAME OVER";
		}
	}

	void PauseGame()
	{
		Time.timeScale = 0;
		gamePaused = true;
	}

	void ResumeGame()
	{
		gamePaused = false;
		Time.timeScale = 1;
	}

	void QuitGame()
    {
		Application.Quit();
    }
}
