using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField] float delayTime = 1f;

    void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Finish");
            GetComponent<MeshRenderer>().material.color = Color.green;
            Invoke("LoadNextLevel", delayTime);
        }
    }

    void LoadNextLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        if (currentSceneIndex == SceneManager.sceneCountInBuildSettings - 1)
            SceneManager.LoadScene(0);
        else
            SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
