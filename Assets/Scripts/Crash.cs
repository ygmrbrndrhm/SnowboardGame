using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crash : MonoBehaviour
{
    [SerializeField] float loadDelay = 0.5f;
    [SerializeField] ParticleSystem crasheffect;
    [SerializeField] AudioClip Crashsfx;
    bool SoundOn=false;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag =="Ground")
        {
            FindObjectOfType<PlayerController>().DestroyMove();
            crasheffect.Play();
            if (SoundOn == false)
            {
                GetComponent<AudioSource>().PlayOneShot(Crashsfx);
                SoundOn = true;
            }
            Invoke("ReloadScene", loadDelay);
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
