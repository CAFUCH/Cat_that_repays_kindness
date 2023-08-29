using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum SOUND_TYPE {

    BGM = 0,
    SFX,
    MaxCount
}
public class SoundManager : MonoBehaviour
{
    // 사운드를 출력할 Sources
    [SerializeField] AudioSource[] _audio = new AudioSource[(int)SOUND_TYPE.MaxCount]; 
    Dictionary<string, AudioClip> _clips = new Dictionary<string, AudioClip>();

    void Play(string _name, SOUND_TYPE _type) {

        if (_clips[_name])
            return;

        AudioClip _clip = _clips[_name];

        // BGM - 재생중인 클립이 있다면 삭제한 후 새로운 클립으로 재생
        if (_type == SOUND_TYPE.BGM) {

            if (_audio[(int)_type].isPlaying)
                _audio[(int)_type].Stop();

            _audio[(int)_type].clip = _clip;
            _audio[(int)_type].Play();
        }
        // SFX - 재생중인 클립이 있다면 새로운 AudioSource를 생성한 후 재생...
        else if (_type == SOUND_TYPE.SFX) {

            if (_audio[(int)_type].isPlaying)
                AddSFX();
        }

    }

    void AddSFX() {


    }

    void Clear() {


    }
}
