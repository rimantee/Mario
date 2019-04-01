using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class InvisibleBlock : MonoBehaviour
{
	public SpriteRenderer rend;

	void Start()
	{
		rend = GetComponent<SpriteRenderer>();
		rend.enabled = false;
	}

	void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "Player")
		{
			rend.enabled = true;
		}
	}

}
