using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SphereManager : MonoBehaviour 
{

	public Material[] material;
	Renderer rend;

	string playerThatDied;



	void Start () 
	{
		rend = GetComponent<Renderer> ();
		rend.enabled = true;
		rend.sharedMaterial = material [0];

	}
	

	void OnCollisionEnter (Collision col) 
	{
		if (col.gameObject.tag == "Player")
		{
			if (rend.sharedMaterial == material [1]) 
			{
				if (col.gameObject.name == "Player1")
				{
					MidtermGameManager.instance.Health -= MidtermGameManager.instance.damageAmt;

				}
				else if(col.gameObject.name == "Player2")
				{
						rend.sharedMaterial = material [0];
					
				}


			}

				else if (rend.sharedMaterial == material [0]) 
			{
				if(col.gameObject.name == "Player2")
				{
					MidtermGameManager.instance.Health -= MidtermGameManager.instance.damageAmt;
				}

				else if (col.gameObject.name == "Player1")
				{
						rend.sharedMaterial = material [1];
				}
				
			}

			else if (rend.sharedMaterial == material [2])
			{
				if (col.gameObject.name == "Player1"){
					playerThatDied = "Player1";
				}

				if (col.gameObject.name == "Player2"){
					playerThatDied = "Player2";
				}

				Destroy (col.gameObject);

				Invoke ("RespawnPlayer", 2);
//				SceneManager.LoadScene ("aa5270_CodeLab1_Midterm1");
//				MidtermGameManager.instance.ReloadScene();
			}
		
		
			}

		else
		{
			rend.sharedMaterial = material [Random.Range(0,3)];
		
		
		}



			
		
	}

	public void RespawnPlayer(){
		if (playerThatDied == "Player1"){
			GameObject player1 = Instantiate (Resources.Load ("Prefab/Player1")) as GameObject;
		}

		if (playerThatDied == "Player2"){
			GameObject player1 = Instantiate (Resources.Load ("Prefab/Player2")) as GameObject;
		}

		
	}
}
