using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavarroSaraCUADERNO : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

/* Script GetComponent:
public class ScriptExample : MonoBehaviour
{
    void Start()
    {
        // Disable the spring on the HingeJoint component.
        HingeJoint hinge = GetComponent<HingeJoint>();
        hinge.useSpring = false;
    }
}
Script ToString:
//This script changes Text to the name of the GameObject with the script attached
//Attach this script to a GameObject
//Attach a Text GameObject in the Inspector (Create>UI>Text)

using UnityEngine;
using UnityEngine.UI;

public class Example : MonoBehaviour
{
    public Text m_Text;

    private void Start()
    {
        //Check that the Text is attached in the Inspector
        if (m_Text != null)
            //Change the Text to show the GameObject's name
            m_Text.text = "GameObject Name : " + gameObject.ToString();
    }
}
*/