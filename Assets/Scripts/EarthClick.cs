using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EarthClick : EventTrigger {
    public override void OnSelect(BaseEventData data)
    {
        print("Onselect method called");
    }
}
