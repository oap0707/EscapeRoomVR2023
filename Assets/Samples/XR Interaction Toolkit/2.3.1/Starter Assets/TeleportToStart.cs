using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TeleportToStart : MonoBehaviour
{
    public TeleportationAnchor startAnchor;

    public void TeleportPlayerToStart()
    {
        // Teleport the player to the start anchor
        transform.position = startAnchor.transform.position;
    }
}
