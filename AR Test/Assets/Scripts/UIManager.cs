using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public Slider m_Red;
    public Slider m_Green;
    public Slider m_Blue;

    public Material m_ShaderMat;

    private void Update()
    {
        UpdateShaderColor();
    }


    void UpdateShaderColor()
    {
        Color c = new Color(m_Red.value, m_Green.value, m_Blue.value);
        m_ShaderMat.SetColor("Base_Color", c);
    }
}
