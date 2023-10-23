using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{

    private AudioSource finishSoundEffect;
    private bool isLevelComplete = false;
    private void Start()
    {
        finishSoundEffect = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D (Collider2D collision) {
        if (collision.gameObject.name == "Player" && !isLevelComplete) {
            finishSoundEffect.Play();
            isLevelComplete = true;
            Invoke("CompleteLevel", 2f);
        }
    }

    private void CompleteLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
