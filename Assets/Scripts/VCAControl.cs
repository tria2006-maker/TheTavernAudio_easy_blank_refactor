using UnityEngine;
using UnityEngine.UI; 
public class VCAControl : MonoBehaviour
{

    private FMOD.Studio.VCA vca;
    private Slider slider;

    [Header(" Ustawienia FMOD ")]
    // vca:/Music
    [SerializeField] private string vcaPath;
    // MusicVolume 
    [SerializeField] private string saveKey;

    [Header("Volume")]
    [SerializeField] private float vcaVolume;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        slider = GetComponent<Slider>();
        vca = FMODUnity.RuntimeManager.GetVCA("vca:/Music");

        float savedVolume = PlayerPrefs.GetFloat(saveKey, 1);

        vca.getVolume(out vcaVolume);
        slider.value = savedVolume;
    }

    public void SetVolume(float volume)
    {
        vca.setVolume(volume);

         PlayerPrefs.SetFloat(saveKey, volume);
    }
}
