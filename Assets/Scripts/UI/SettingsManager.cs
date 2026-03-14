using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{
  [SerializeField] AudioSource audioSource;
  public Toggle musicToggle;
  public Slider volumeSlider;
  [SerializeField] GameObject musicPanel;
  [SerializeField] GameObject instructionsPanel;

  void Start()
  {
    volumeSlider.value = 1;
  }
  void Update()
  {

    setVolume();

    if (musicToggle.isOn)
    {
      audioSource.mute = false;
    }
    else
    {
      audioSource.mute = true;
    }
  }

  void OnEnable()
  {
    ShowAudio();
  }

  public void setVolume()
  {
    float volumeValue = volumeSlider.value;
    audioSource.volume = volumeValue;
  }

  public void ShowAudio()
  {
    musicPanel.SetActive(true);
    instructionsPanel.SetActive(false);
  }

  public void ShowHelp()
  {
    musicPanel.SetActive(false);
    instructionsPanel.SetActive(true);
  }
}
