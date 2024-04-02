using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DisableHandsOnModel : MonoBehaviour
{
    public GameObject leftHandModel;
    public GameObject rightHandModel;
    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.selectEntered.AddListener(HideGrabbingHnad);
        grabInteractable.selectExited.AddListener(ShowGrabbingHand);
    }
    
    public void HideGrabbingHnad(SelectEnterEventArgs args)
    {
        if(args.interactorObject.transform.tag == "Left Hand")
        {
            leftHandModel.SetActive(false);
        }
        if (args.interactorObject.transform.tag == "Right Hand")
        {
            rightHandModel.SetActive(false);
        }
    }
    public void ShowGrabbingHand(SelectExitEventArgs args)
    {
        if (args.interactorObject.transform.tag == "Left Hand")
        {
            leftHandModel.SetActive(true);
        }
        if (args.interactorObject.transform.tag == "Right Hand")
        {
            rightHandModel.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
