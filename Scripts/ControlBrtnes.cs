using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
public class ControlBrtnes : MonoBehaviour
{
    public ARCameraManager arcamman;
    public Text valuetext;
    Light our_light;
    public void OnSliderChanged(float value)
    {
        setGlobalLightEstimation(value);
        valuetext.text = value.ToString();
    }
    void setGlobalLightEstimation(float lightValue)
    {
        Shader.SetGlobalFloat("_GlobalLightEstimation",lightValue);
    }
}
