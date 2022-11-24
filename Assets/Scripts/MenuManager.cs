using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject gameLevelPanel;
    public GameObject creditsPanel;
    private AudioSource audioSource;
    public AudioClip clickSound;

    private void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
    }

    public void OpenGameLevel()
    {
        gameLevelPanel.SetActive(true);
        audioSource.PlayOneShot(clickSound);
    }

    public void CloseGameLevel()
    {
        gameLevelPanel.SetActive(false);
        audioSource.PlayOneShot(clickSound);
    }

    public void OpenCredits()
    {
        creditsPanel.SetActive(true);
        audioSource.PlayOneShot(clickSound);
    }

    public void CloseCredits ()
    {
        creditsPanel.SetActive(false);
        audioSource.PlayOneShot(clickSound);
    }

    public void GoToLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        audioSource.PlayOneShot(clickSound);
    }

    public void GoToLink(string link)
    {
        Application.OpenURL(link);
    }
}
