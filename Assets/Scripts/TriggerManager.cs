using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class TriggerManager : MonoBehaviour
{
    public UnityEvent EventTrigger;

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Portal ring is trigger by " + other.name);
        EventTrigger.Invoke();
    }
}
