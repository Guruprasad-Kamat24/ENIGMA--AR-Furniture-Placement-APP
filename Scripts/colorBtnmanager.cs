using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colorBtnmanager : MonoBehaviour
{
    // Start is called before the first frame update
    private Button btn;
    public Color colors;
    public Renderer[] mats;
    void Start()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(SelectObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void SelectObject()
    {
        for(int i=0;i<mats.Length;i++)
        {
            mats[i].material.color = colors;
        }
    }
}
