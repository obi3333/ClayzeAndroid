using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour
{
    public Button _Button;
    public string sceneName;

    void Start()
    {
        if (_Button != null)
        {
            _Button.onClick.AddListener(_LoadScene);
        }
        else
        {
            Debug.LogError("Button not assigned in the inspector");
        }
    }
    void _LoadScene()
    {

        if (!string.IsNullOrEmpty(sceneName))
        {
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            Debug.LogError("Scene name not assigned or empty");
        }
    }
}
