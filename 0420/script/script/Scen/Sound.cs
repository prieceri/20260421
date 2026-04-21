using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SetVolume : MonoBehaviour
{
    [SerializeField] AudioMixer _bgm;

    public void BGSoundVoume(float val)
    {
        _bgm.SetFloat("BB", Mathf.Log10(val) * 20);
    }

}
