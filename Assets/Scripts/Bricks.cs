using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip breakSound;

    private void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
    }

    private void OnMouseDown() {
        Debug.Log("kubus berhasil dihancurkan!");
        audioSource.PlayOneShot(breakSound);
        Destroy(this.gameObject);
    }
}
