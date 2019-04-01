using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;

public class FlagScript : MonoBehaviour
{
    public PlayableDirector finishDirector;
    public PlayableDirector fireworkDirector;
    public Animation firework;

    public bool isPlayEnabled = true;
    public float moveSpeed;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (isPlayEnabled)
        {
            isPlayEnabled = false;
       
            finishDirector.Play();
            fireworkDirector.Play();
        }
    }
    
    IEnumerator Example()
    {
        firework.Play();
        yield return new WaitForSeconds(2);
    }
}
