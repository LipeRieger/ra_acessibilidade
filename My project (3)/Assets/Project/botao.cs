using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class VRButtonInteraction : MonoBehaviour
{
    public void ChangeColor()
    {
        GetComponent<Renderer>().material.color = Color.green;
    }
}