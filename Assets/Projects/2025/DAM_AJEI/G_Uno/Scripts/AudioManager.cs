using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace EntilandVR.DosCinco.DAM_AJEI.G_Uno
{

    public class AudioManager : MonoBehaviour
    {
        [Header("----- Audio Source -----")]
        [SerializeField] public AudioSource musicSource;
        [SerializeField] public AudioSource SFXSource;

        [Header("----- Audio Songs -----")]
        public AudioClip trackClip;
        public AudioClip IntroClip;
        public AudioClip InicialLevel;
        public AudioClip LaberintoClip;

        [Header("----- Audio Effects -----")]
        public AudioClip woof;
        public AudioClip Invisibilidad;
        public AudioClip Nose;
        public AudioClip Sniff;
        public AudioClip ElfSound;
        public AudioClip ElfSoundSawYou;
        public AudioClip dogsad;
        public AudioClip Puzzle;
        public static AudioManager Instance { get; private set; }


        private void Awake()
        {

            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }

            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        public void Start()
        {
            musicSource.clip = trackClip;
            musicSource.volume = 0.2f;
            musicSource.Play();
        }

        public void PlaySFX(AudioClip clip, float volumen = 1.0f)
        {
            SFXSource.volume = volumen;
            SFXSource.PlayOneShot(clip);
        }
    }
}
