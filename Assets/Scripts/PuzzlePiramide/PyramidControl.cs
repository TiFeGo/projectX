using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PyramidControl : MonoBehaviour
{
    public static int slotsOccupied;

    [SerializeField]
    private Transform[] rings;

    [SerializeField]
    private GameObject winSign;

    [SerializeField]
    private GameObject wrongSign;

    void Start()
    {
        Drag.PuzzleDone += CheckResults;
        slotsOccupied = 0;
        winSign.SetActive(false);
        wrongSign.SetActive(false);
    }

    

    public void CheckResults()
    {
        if (rings[0].position.y == -3.77f &&
            rings[1].position.y == -2.67f &&
            rings[2].position.y == -1.63f &&
            rings[3].position.y == -0.58f)
        {
            winSign.SetActive(true);
            Invoke("ReloadGame", 2f);
        }
        else
        {
            wrongSign.SetActive(true);
            Invoke("ReloadGame", 1f);
        }
    }

    private void ReloadGame()
    {
        Drag.PuzzleDone -= CheckResults;
        SceneManager.LoadScene("PuzzlePiramide");   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
