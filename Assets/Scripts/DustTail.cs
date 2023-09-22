using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTail : MonoBehaviour
{
    [SerializeField] ParticleSystem boardeffect;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "mountain")
        {
            boardeffect.Play();
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name=="mountain")
        {
            boardeffect.Stop();
        }
    }
}
