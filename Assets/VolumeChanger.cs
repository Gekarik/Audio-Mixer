using UnityEngine;
using UnityEngine.Audio;

public class VolumeChanger : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _mixer;
    [SerializeField] private _volumeNames _volumeName;

    private float _lowerBound = -80;
    private float _higherBound = 0;
    private bool _isMusicOn = true;

    private enum _volumeNames { MasterVolume, EffectsVolume, BackgroundVolume };

    public void ChangeVolume(float volume)
    {
        _mixer.audioMixer.SetFloat(_volumeName.ToString(), Mathf.Lerp(_lowerBound, _higherBound, volume));
    }

    public void ToggleMusic()
    {
        if (_isMusicOn)
        {
            _isMusicOn = false;
            _mixer.audioMixer.SetFloat(_volumeNames.MasterVolume.ToString(), _lowerBound);
        }
        else
        {
            _isMusicOn = true;
            _mixer.audioMixer.SetFloat(_volumeNames.MasterVolume.ToString(), _higherBound);
        }
    }
}