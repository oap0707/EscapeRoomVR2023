using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{

    //public AudioSource audioSource;
    public string FigureBox;

    public GameObject objectToShow;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(FigureBox))
        {
            // Perform the desired action when the cube object is placed on top of the box object.
            Debug.Log("Figure object placed on top of the box object.");
            objectToShow.SetActive(true);
            //audioSource.Play();
        }
    }
}

