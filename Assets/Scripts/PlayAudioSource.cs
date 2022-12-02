using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioSource : MonoBehaviour
{
    [SerializeField] protected AudioSource audioS;

    protected virtual void PlayAudioS()
    {
        audioS.Play();
    }
}
