using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnContact : MonoBehaviour
{
	//public GameObject myExplosion;
	//public GameObject otherExplosion;
	public int scoreValue;

	private GameManager gameManager;

	void Start()
	{
		GameObject gameManagerObject = GameObject.FindWithTag("GameManager");

		if (gameManagerObject != null)
		{
			gameManager = gameManagerObject.GetComponent<GameManager>();
		}

		else
		{
			Debug.Log("Cannot find 'S_GameManager' script");
		}
	}
    
    void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Enemy"))
		{
			// Ignore other enemies
			return;
		}

        else
        {
            //         if (myExplosion != null)
            //         {
            //             Instantiate(myExplosion, transform.position, transform.rotation);
            //         }

            if (other.CompareTag("Player"))
            {
                //Instantiate(otherExplosion, other.transform.position, other.transform.rotation);

            //    gameManager.GameOver();
            //}
            //else
            //{
                gameManager.AddScore(scoreValue); // Only add to the score when not hitting the Player!
            }
			//Debug.Log("calling destroy");
			//Destroy(other.gameObject); // Bolt or Player
			//Destroy(gameObject); // Myself
			PoolManager.Instance.ReturnToPool(gameObject);
		}
		
	}

}
