using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audiomanager : MonoBehaviour
{
  public AudioSource audioSource;

  public AudioClip kickSound;
  public AudioClip saveSound;
  public AudioClip goalSound;
  public AudioClip gameOverSound;

  public void PlayKick()
  {
    // audioSource.PlayOneShot(kickSound);
    if (audioSource.isPlaying)
    {
      audioSource.Stop();
    }
    audioSource.clip = kickSound;
    audioSource.Play();
  }

  public void PlaySave()
  {
    // audioSource.PlayOneShot(saveSound);

    if (audioSource.isPlaying)
    {
      audioSource.Stop();
    }
    audioSource.clip = saveSound;
    audioSource.Play();
  }

  public void PlayGoal()
  {
    // audioSource.PlayOneShot(goalSound);

    if (audioSource.isPlaying)
    {
      audioSource.Stop();
    }
    audioSource.clip = goalSound;
    audioSource.Play();
  }

  public void PlayGameOver()
  {
    // audioSource.PlayOneShot(gameOverSound);

    if (audioSource.isPlaying)
    {
      audioSource.Stop();
    }
    audioSource.clip = gameOverSound;
    audioSource.Play();
  }
}
