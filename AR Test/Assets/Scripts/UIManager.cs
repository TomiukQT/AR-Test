using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public Slider m_ColorSlider;
    public Slider m_SpeedSlider;

    public Material m_ShaderMat;

    


    public void ChangeColor()
    {
        float hue = m_ColorSlider.value;
        m_ShaderMat.SetFloat("Hue", hue);
    }

    public void ChangeSpeed()
    {
        float speed = m_SpeedSlider.value;
        m_ShaderMat.SetFloat("Anim_Speed", speed);
    }
}
