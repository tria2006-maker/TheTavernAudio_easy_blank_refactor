using FMODUnity;
using UnityEngine;

public class InteractSample : MonoBehaviour, IInteractable
{
    [Header("Sound")]
    [SerializeField] private EventReference interactSound;
    [Header("Attach")]
    [SerializeField] private bool attachToTransform = true; 
   
    public void Interact()
    {
        PlaySound();
    }

    private void PlaySound()
    {
        if (attachToTransform)
        {
            RuntimeManager.PlayOneShotAttached(interactSound, gameObject);
        }
        else
        {
            RuntimeManager.PlayOneShot(interactSound);
        }

    }
}
