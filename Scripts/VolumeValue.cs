using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class VolumeValue : MonoBehaviour
{
    public GameObject BGMusic;  //Ваш объект с фоновой музыкой
    private AudioSource audioSrc;
    public static float musicVolume; 
    public Slider VolValue; //Слайдер если нужна регулировка
    public GameObject[] objs1;
    
    void Awake() {
        objs1 = GameObject.FindGameObjectsWithTag("Sound"); //не забываем задать тег Sound для префаба с музыкой
        if (objs1.Length == 0)
            {
                BGMusic = Instantiate(BGMusic); //создаем объект из префаба
                BGMusic.name = "BGMusic";  //необязательно, просто внешний вид улучшает:)
                DontDestroyOnLoad(BGMusic.gameObject); //Ответ на Ваш вопрос
            } else {
                BGMusic = GameObject.Find("BGMusic"); //обращаемся к объекту, если он уже существует.
            }
        if (!PlayerPrefs.HasKey("MusicVol")) {
            musicVolume = 0.5f;  //тут громкость по умолчанию
        } else {
            musicVolume = PlayerPrefs.GetFloat("MusicVol"); //сохраненная громкость
            VolValue.value = PlayerPrefs.GetFloat("MusicVol"); //меняем значение слайдера на сохраненную громкость
        }
    }
    void Start()
    {
        audioSrc = BGMusic.GetComponent<AudioSource>();
    }
 
    
    void Update()
    {
        audioSrc.volume = musicVolume;  //устанавливаем громкость при изменении слайдера
    }
 
    public void SetVolume(float vol)
    {
        musicVolume = vol;
        PlayerPrefs.SetFloat("MusicVol", vol); //сохраняем громкость
    }
}