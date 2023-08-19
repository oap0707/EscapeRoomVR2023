using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchMaterialAction : MonoBehaviour
{

    public GameObject object1;
    public GameObject object2;
    public GameObject object3;
    public GameObject object4;
    public GameObject object5;
    public GameObject object6;

    public Material triggerMaterial1;
    public Material triggerMaterial2;
    public Material triggerMaterial3;
    public Material triggerMaterial4;
    public Material triggerMaterial5;
    public Material triggerMaterial6;


    private bool objectsMatch;

    public GameObject objectToShow;
    public GameObject objectToShow2;

    public AudioSource audioSource;

    bool hasPassed = false;

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        objectsMatch = CheckObjectsMatch();

        if (objectsMatch && !hasPassed)
        {
            // Trigger action
            hasPassed = true;
            objectToShow.SetActive(false);
            objectToShow2.SetActive(false);
            audioSource.Play();
        }

        if (objectsMatch)
        {
            objectToShow.SetActive(false);
            objectToShow2.SetActive(false);

        }
    }

    private bool CheckObjectsMatch()
    {

        bool object1Matches = object1.GetComponent<Renderer>().material.mainTexture == triggerMaterial1.mainTexture;
        bool object2Matches = object2.GetComponent<Renderer>().material.mainTexture == triggerMaterial2.mainTexture;
        bool object3Matches = object3.GetComponent<Renderer>().material.mainTexture == triggerMaterial3.mainTexture;
        bool object4Matches = object4.GetComponent<Renderer>().material.mainTexture == triggerMaterial4.mainTexture;
        bool object5Matches = object5.GetComponent<Renderer>().material.mainTexture == triggerMaterial5.mainTexture;
        bool object6Matches = object6.GetComponent<Renderer>().material.mainTexture == triggerMaterial6.mainTexture;

        return object1Matches && object2Matches && object3Matches && object4Matches && object5Matches && object6Matches;
    }

}
