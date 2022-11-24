using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{


    private AudioSource audioSource;
    public AudioClip clickSound;
    public AudioClip startSound;

    private void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
        audioSource.PlayOneShot(startSound);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        audioSource.PlayOneShot(clickSound);
    }

    public void TryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        audioSource.PlayOneShot(clickSound);
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
        audioSource.PlayOneShot(clickSound);
    }
}
