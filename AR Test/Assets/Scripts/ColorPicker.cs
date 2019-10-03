using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ColorPicker : MonoBehaviour
{
    public Material m_TigerMat;

    private Slider m_ColorSlider;

    private void Awake()
    {
        m_ColorSlider = GetComponent<Slider>();
    }

    public void ChangeColor()
    {
        float hue = m_ColorSlider.value;
        m_TigerMat.SetFloat("Hue", hue);
    }
}
