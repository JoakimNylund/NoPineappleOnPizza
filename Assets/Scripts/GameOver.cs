using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    //GameOver handles the enabling and disabling of the Game over panel.
    public GameObject gameOverPanel;
        // Update is called once per frame
        void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") == null)
        {
           gameOverPanel.SetActive(true);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void ChangeToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + -1);

    }
}