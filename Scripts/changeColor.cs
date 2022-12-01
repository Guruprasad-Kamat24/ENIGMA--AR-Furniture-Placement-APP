using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class changeColor : MonoBehaviour
{
    // Start is called before the first frame update
    //public TextMeshProUGUI ouput;
    public Color[] colors;
    public Renderer[] mats;
    public void pulpy_orange()
    {
            for(int i=0;i<mats.Length;i++)
        {
            mats[i].material.color = colors[0];
        }
    }
    public void sky_blue()
    {
            for(int i=0;i<mats.Length;i++)
        {
            mats[i].material.color = colors[1];
        }
    }
    public void mint_green()
    {
            for(int i=0;i<mats.Length;i++)
        {
            mats[i].material.color = colors[2];
        }
    }
    public void baby_pink()
    {
            for(int i=0;i<mats.Length;i++)
        {
            mats[i].material.color = colors[3];
        }
    }
    public void clean_white()
    {
            for(int i=0;i<mats.Length;i++)
        {
            mats[i].material.color = colors[4];
        }
    }
}
