using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChange : MonoBehaviour 
{

	public Material[] material;
	Renderer rend;



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
			if (rend.sharedMaterial == material [1]) {
				if (col.gameObject.name == "Player1"){
					MidtermGameManager.instance.Health -= MidtermGameManager.instance.damageAmt;

				}
				else if(col.gameObject.name == "Player2"){
						rend.sharedMaterial = material [0];
					
				}


			}

			else if (rend.sharedMaterial == material [0]) {
				if(col.gameObject.name == "Player2"){
					MidtermGameManager.instance.Health -= MidtermGameManager.instance.damageAmt;
				}

				else if (col.gameObject.name == "Player1"){
						rend.sharedMaterial = material [1];
				}
				
			}

			else if (rend.sharedMaterial == material [2]){
				Destroy (col.gameObject);
			}

		}
		else
		{
			rend.sharedMaterial = material [Random.Range(0,3)];	
		}

		
	}
}
