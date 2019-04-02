using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CastleScript : MonoBehaviour
{

	public Canvas EndTrigger;

	void Start()
	{
		EndTrigger = GetComponent<Canvas>();
		EndTrigger.enabled = false;

	}

	 void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "Player")
		{
			EndTrigger.enabled = true;
		}
	}

}
