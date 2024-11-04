using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryExample : MonoBehaviour
{
    Dictionary<string, bool> GameEvents = new Dictionary<string, bool>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.V))
            DoAction();
    }

    private void DoAction()
    { }

    public void NotifyActionHappened(string IDToTOggle )
    {
        GameEvents["IsTorchedPickedUp"] = true;
    }

    public bool GetStateForGameEVent(string IDToGet)
    {
        return GameEvents[IDToGet];
    }
}
