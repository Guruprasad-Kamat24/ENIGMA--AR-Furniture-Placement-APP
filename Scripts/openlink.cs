using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openlink : MonoBehaviour
{
    
    // Start is called before the first frame update
    public void openurl(string link)
    {
        Application.OpenURL(link);
    }
}
