using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public interface IFloat
{
    void Use(float f);
}

public class ListenResource : MonoBehaviour
{
    public string resourceName = "Gold";
    private IFloat[] users;
    private void Start()
    {
        Resources.Find(resourceName).ChangeEvent += UseValue;
        users = GetComponentsInChildren<IFloat>();
    }
    private void UseValue(float value)
    {
        foreach (var users in users)
            users.Use(value);
    }
}
