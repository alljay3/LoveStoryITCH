using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartWindow : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 0;
    }

    public void StartGame()
    {
        Time.timeScale = 1;
        GameObject.FindGameObjectWithTag("UISound").GetComponent<AudioSource>().Play();
        gameObject.SetActive(false);
    }
}
