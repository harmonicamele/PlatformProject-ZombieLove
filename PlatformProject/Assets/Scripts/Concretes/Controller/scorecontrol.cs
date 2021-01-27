using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorecontrol : MonoBehaviour
{
    [SerializeField] AudioClip scoreSound;

    public static event System.Action<AudioClip> scorePlay;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            scoretext.scoreValue += 10;
            scorePlay.Invoke(scoreSound);
            Destroy(this.gameObject);
        }

    }

}
