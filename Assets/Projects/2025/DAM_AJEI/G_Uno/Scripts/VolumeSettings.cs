using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

namespace EntilandVR.DosCinco.DAM_AJEI.G_Uno
{

    public class VolumeData
    {
        public float musicVolume;
        public float SFXVolume;
    }
    public class VolumeSettings : MonoBehaviour
    {
        [SerializeField] private AudioMixer mymixer;
        [SerializeField] private Slider musicSlider;
        [SerializeField] private Slider SFXSlider;
        private string filePath;
        private void Start()
        {

            filePath = Path.Combine(Application.persistentDataPath, "volumeSettings.json");
            if (File.Exists(filePath))
            {
                LoadVolume();
            }
            else
            {
                SetMusicVolume();
                SetSFXVolume();
            }

        }
        public void SetMusicVolume()
        {
            float volume = musicSlider.value;
            mymixer.SetFloat("MusicVolume", Mathf.Log10(volume) * 20);
            SaveVolume();
        }

        public void SetSFXVolume()
        {
            float volume = SFXSlider.value;
            mymixer.SetFloat("SFXVolume", Mathf.Log10(volume) * 20);
            SaveVolume();
        }
        private void SaveVolume()
        {
            VolumeData data = new VolumeData
            {
                musicVolume = musicSlider.value,
                SFXVolume = SFXSlider.value
            };

            string json = JsonUtility.ToJson(data, true);
            File.WriteAllText(filePath, json);
        }
        private void LoadVolume()
        {
            string json = File.ReadAllText(filePath);
            VolumeData data = JsonUtility.FromJson<VolumeData>(json);

            musicSlider.value = data.musicVolume;
            SFXSlider.value = data.SFXVolume;

            SetMusicVolume();
            SetSFXVolume();
        }
        public void ResetVolume()
        {
            musicSlider.value = 1;
            SFXSlider.value = 1;
            SetMusicVolume();
            SetSFXVolume();
        }

    }

}