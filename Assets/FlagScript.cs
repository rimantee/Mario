using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;

public class FlagScript : MonoBehaviour
{
    public PlayableDirector finish;

    public bool enter = true;
    public bool stay = true;
    public bool exit = true;
    public float moveSpeed;

    void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (enter)
        {
            Debug.Log("entered");
            finish.Play();
        }
    }
}
