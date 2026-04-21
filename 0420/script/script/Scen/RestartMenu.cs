using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartMenu : MonoBehaviour
{
    [SerializeField] GameObject _canvas;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
            Load();
    }

    public void Load()
    {
        Time.timeScale = 1;
        _canvas.SetActive(false);

        SceneManager.LoadScene("Stage" + NextBu.currentStage);


    }
}

