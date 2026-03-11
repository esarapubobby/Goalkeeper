using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsManager : MonoBehaviour
{
    [SerializeField]AudioSource audioSource;
    public void setVolume (float  value)
    {
        Debug.Log("Volume changed to: " + value);
        audioSource.volume=value;
    }
}
