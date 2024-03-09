using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject menu;
    bool numPressed = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            numPressed = !numPressed;
            if (numPressed)
            {
                Pause();
            }

            if (!numPressed) 
            { 
                Unpause();
            }
        }
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        menu.SetActive(true);
    }

    public void Unpause()
    {
        Time.timeScale = 1f;
        menu.SetActive(false);
    }

    public void quit()
    {
        EditorApplication.ExecuteMenuItem("Edit/Play");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
