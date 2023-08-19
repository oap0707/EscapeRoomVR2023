using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsOn : MonoBehaviour
{
    public GameObject object1;
    public GameObject object2;
    public GameObject object3;
    public GameObject object4;
    public GameObject object5;
    public GameObject object6;

    private bool object1Active = false;
    private bool object2Active = false;
    private bool object3Active = false;
    private bool object4Active = false;
    private bool object5Active = false;
    private bool object6Active = false;

    public GameObject objectToShow;
    public GameObject objectToShow2;

    public AudioSource audioSource;

    bool hasPassed = false;

    private void Update()
    {
        // Check if all objects are active
        if (object1.activeSelf && object2.activeSelf && object3.activeSelf && object4.activeSelf && object5.activeSelf && object6.activeSelf && !hasPassed)
        {
            // Set the corresponding boolean variables to true
            object1Active = true;
            object2Active = true;
            object3Active = true;
            object4Active = true;
            object5Active = true;
            object6Active = true;

            // Trigger the desired action
            Debug.Log("All objects are active!");
            hasPassed = true;
            objectToShow.SetActive(false);
            objectToShow2.SetActive(false);
            audioSource.Play();
        }

        // Check if all objects are active
        if (object1.activeSelf && object2.activeSelf && object3.activeSelf && object4.activeSelf && object5.activeSelf && object6.activeSelf)
        {
            // Set the corresponding boolean variables to true
            object1Active = true;
            object2Active = true;
            object3Active = true;
            object4Active = true;
            object5Active = true;
            object6Active = true;

            // Trigger the desired action
            objectToShow.SetActive(false);
            objectToShow2.SetActive(false);
        }

    }

}
