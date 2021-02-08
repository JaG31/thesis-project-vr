
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Valve.VR.Extras;
public class VRUIInput : MonoBehaviour
{
    public SteamVR_LaserPointer laserPointer;

    private void OnEnable()
    {
        laserPointer.PointerIn += HandlePointerIn;
        laserPointer.PointerOut += HandlePointerOut;
        laserPointer.PointerClick += HandleTriggerClicked;
    }

    private void HandleTriggerClicked(object sender, PointerEventArgs e)
    {
        Debug.Log(e.target.name);
        if (EventSystem.current.currentSelectedGameObject != null)
        {
            ExecuteEvents.Execute(EventSystem.current.currentSelectedGameObject, new PointerEventData(EventSystem.current), ExecuteEvents.submitHandler);
        }
    }


    //ADD ALL OF THE TYPES OF OBJECTS USED TO HERE
    private void HandlePointerIn(object sender, PointerEventArgs e)
    {
        var button = e.target.GetComponent<Button>();
        if (button != null)
        {
            button.Select();
            Debug.Log("HandlePointerIn", e.target.gameObject);
        }

        var toggle = e.target.GetComponent<Toggle>();
        if (toggle != null) {
            toggle.Select();
        }

        var dropdown = e.target.GetComponent<Dropdown>();
        if (dropdown != null) {
            dropdown.Select();
        }


    }

    private void HandlePointerOut(object sender, PointerEventArgs e)
    {
        
        var button = e.target.GetComponent<Button>();
        if (button != null)
        {
            EventSystem.current.SetSelectedGameObject(null);
            Debug.Log("HandlePointerOut", e.target.gameObject);
        }

        var toggle = e.target.GetComponent<Toggle>();
        if (toggle != null) {
            EventSystem.current.SetSelectedGameObject(null);
        }

        var dropdown = e.target.GetComponent<Dropdown>();
        if (dropdown != null) {
            EventSystem.current.SetSelectedGameObject(null);
        }
    }
}