using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleGame : MonoBehaviour
{
    public GameObject[] puzzleHolderHead; // sphere 1
    public GameObject[] puzzleHolderArm; // cylinder 3 
    public GameObject[] puzzleHolderArm2; // cylinder 3
    public GameObject[] puzzleHolderBody; // square 2
    public GameObject[] puzzleHolderLeg; // cylinder 3 
    public GameObject[] puzzleHolderLeg2; // cylinder 3

    public AudioSource audioSource;

    public GameObject objectToShow;
    public GameObject objectToShow2;

    bool hasPassed = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (puzzleHolderHead[0].activeSelf && puzzleHolderArm[2].activeSelf && puzzleHolderArm2[2].activeSelf && puzzleHolderBody[1].activeSelf && puzzleHolderLeg[2].activeSelf && puzzleHolderLeg2[2].activeSelf && !hasPassed)
        {
            // Trigger action
            objectToShow.SetActive(false);
            objectToShow2.SetActive(false);
            hasPassed = true;
            audioSource.Play();
        }

        if(puzzleHolderHead[0].activeSelf && puzzleHolderArm[2].activeSelf && puzzleHolderArm2[2].activeSelf && puzzleHolderBody[1].activeSelf && puzzleHolderLeg[2].activeSelf && puzzleHolderLeg2[2].activeSelf)
        {
            // Trigger action
            objectToShow.SetActive(false);
            objectToShow2.SetActive(false);

        }


    }
}
