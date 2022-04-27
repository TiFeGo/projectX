using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    [SerializeField]
    private GameObject panel;
    public void ChangeScene(string sceneName)
    {
        
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        
    }

    public void Exit()
    {
        Application.Quit();
    }

    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
