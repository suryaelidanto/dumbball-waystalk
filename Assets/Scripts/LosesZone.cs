using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LosesZone : MonoBehaviour
{
    public GameObject losePanel;
    private AudioSource audioSource;
    public AudioClip loseSound;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            Debug.Log("Menyentuh finish");
            losePanel.SetActive(true);
            audioSource = FindObjectOfType<AudioSource>();
            audioSource.PlayOneShot(loseSound);
        }
    }
}
