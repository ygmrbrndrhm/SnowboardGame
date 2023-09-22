using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField] float Delay=0.5f;
    [SerializeField] ParticleSystem finisheffect;
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            finisheffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", 2f);
        }
      
    }
   void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}

