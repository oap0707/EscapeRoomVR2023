using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PuzzleManager : MonoBehaviour
{
    [SerializeField] private GameObject[] objectsToSwitch;

    private XRGrabInteractable[] interactables;

    private int currentIndex = 0;

    void Start()
    {
        if (objectsToSwitch == null || objectsToSwitch.Length == 0)
        {
            Debug.LogError("Objects to switch array is not assigned or empty");
            return;
        }

        interactables = new XRGrabInteractable[objectsToSwitch.Length];

        for (int i = 0; i < objectsToSwitch.Length; i++)
        {
            interactables[i] = objectsToSwitch[i].GetComponent<XRGrabInteractable>();

            if (interactables[i] == null)
            {
                Debug.LogError("Object " + objectsToSwitch[i].name + " does not have an XRGrabInteractable component");
                continue;
            }

            interactables[i].onSelectEntered.AddListener(OnObjectSelected);
            //interactables[i].onActivate.AddListener(OnObjectSelected);

            if (i != currentIndex)
            {
                objectsToSwitch[i].SetActive(false);
            }
        }
    }

    void OnObjectSelected(XRBaseInteractor interactor)
    {
        if (objectsToSwitch == null || objectsToSwitch.Length == 0)
        {
            Debug.LogError("Objects to switch array is not assigned or empty");
            return;
        }

        if (interactables == null || interactables.Length == 0)
        {
            Debug.LogError("Interactables array is null or empty");
            return;
        }

        // Deactivate the current object
        objectsToSwitch[currentIndex].SetActive(false);

        // Increment the index and wrap around if necessary
        currentIndex = (currentIndex + 1) % objectsToSwitch.Length;

        // Activate the new object
        objectsToSwitch[currentIndex].SetActive(true);
    }
}



