using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DataHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject furniture;
    private static DataHandler instance;
    public static DataHandler Instance
    { 
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<DataHandler>();
            }
            return instance;
        }
    }
}
