using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OJH : MonoBehaviour
{
    private string _name;
    private int _age;

    void Start()
    {
        _name = "������";
        _age = 25;
        Debug.Log($"Hi IM {_name}");
        Debug.Log($"HI Im{_age}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
