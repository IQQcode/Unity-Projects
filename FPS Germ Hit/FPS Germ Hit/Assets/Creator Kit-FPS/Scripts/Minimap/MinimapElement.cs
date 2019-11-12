using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

/// 这个脚本附加到任何需要在小地图中渲染的渲染器对象上
public class MinimapElement : MonoBehaviour
{
    public static List<Renderer> Renderers => s_Renderers;
    
    static List<Renderer> s_Renderers = new List<Renderer>();

    Renderer m_Renderer;
     
    void OnEnable()
    {
        m_Renderer = GetComponent<Renderer>();
        
        if(m_Renderer != null)
            s_Renderers.Add(m_Renderer);
    }

    void OnDisable()
    {
        if (m_Renderer)
            s_Renderers.Remove(m_Renderer);
    }
}
