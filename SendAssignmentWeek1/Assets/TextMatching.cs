using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextMatching : MonoBehaviour
{
    public string[] Names;
    public Text find;
    public Text textA ;

    public void GIText()
    {
        for (int games = 0; games <= 4; games++)
        {
            if (find.text == Names[games])
            {
                textA.text = "<color=red>" + find.text + "</color>" + " is found";
                return;
            }
            else if (find.text != Names[0] && games == 4)
            {
                textA.text = "<color=red>" + find.text + "</color>" + " is not found";
                return;
            }
        }
    }
}