using UnityEngine;
using FMODUnity;
using System.Runtime.InteropServices;


public class FirePlaceInteract : MonoBehaviour, IInteractable
{
    [Header("Fire")] 
    [SerializeField] GameObject fire;

    [Header("Sound")]
    [SerializeField] private EventReference frireplaceStart;
    [SerializeField] private EventReference frireplaceStop;
    
    [Header("Stan")]
    [SerializeField] private bool isActive = true;

    public void Interact()
    {
        isActive = !isActive;

        if (fire != null)
        {
            fire.SetActive(isActive);
            PlayInteractSound();
        }
    }

    private void PlayInteractSound()
    {
        if (isActive)
        {
            RuntimeManager.PlayOneShot(frireplaceStart);
        }
        else
        {
            RuntimeManager.PlayOneShot(frireplaceStop);
        }
    }
}
