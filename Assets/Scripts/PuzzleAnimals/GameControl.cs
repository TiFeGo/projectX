using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{

    
    [SerializeField]
    private GameObject pannel;
    // Start is called before the first frame update
    void Start()
    {
        pannel.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {      
        if (Elephant.locked && Zebra.locked && Lion.locked)
        {
            pannel.SetActive(true);
            
        }
        
            
    }

   
}
