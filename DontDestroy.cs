using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    public static DontDestroy dd;

    public int playerHealth = 20;
    public GameObject inven;
    
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if(dd == null)
        {
            dd = this;
        }
        else if(dd != this)
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if(playerHealth>20)
        {
            playerHealth = 20;
        }
    }
}
