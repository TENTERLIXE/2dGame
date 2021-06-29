using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Resources : MonoBehaviour
{
    public static Resources Find(string name)
    {
        foreach (var resource in FindObjectsOfType<Resources>())
        {
            if (resource.m_ResourceName == name)
                return resource;
        }
        Debug.LogError($"Не удалось найти ресурс{name}");
        return null;
    }
    [SerializeField] private string m_ResourceName = "Gold";
    [SerializeField] private float m_Value = 0;
    [SerializeField] private float m_MaxValue = 9999;
    public float GetMaxValue() => m_MaxValue;
    public UnityEvent OnZero, OnMax;
    public event Action<float> ChangeEvent;
    public void Change(float change)
    {
        m_Value = Mathf.Clamp(m_Value + change, 0, m_MaxValue);
        ChangeEvent?.Invoke(m_Value);
        if (m_Value == 0)
        {
        }
        else if (m_Value == m_MaxValue)
        {
            OnMax.Invoke();
        }
    }
}