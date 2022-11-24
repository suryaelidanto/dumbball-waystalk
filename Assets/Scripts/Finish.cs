using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameObject winPanel;
    private AudioSource audioSource;
    public AudioClip winSound;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            Debug.Log("Menyentuh finish");
            winPanel.SetActive(true);
            audioSource = FindObjectOfType<AudioSource>();
            audioSource.PlayOneShot(winSound);
        }
    }
}
