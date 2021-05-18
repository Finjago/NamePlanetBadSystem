using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlanetNamer : MonoBehaviour
{
    public InputField IF;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void TextChanged()
    {

        string newText;

        if (PlayerPrefs.GetInt("CurrentPlanet") == 1 || PlayerPrefs.GetInt("CurrentPlanet") == 0)
        {
            newText = IF.text;

            PlayerPrefs.SetString("Planet1Name", newText);

            IF.text = PlayerPrefs.GetString("Planet1Name");
        }
        else if (PlayerPrefs.GetInt("CurrentPlanet") == 2)
        {
            newText = IF.text;

            PlayerPrefs.SetString("Planet2Name", newText);

            IF.text = PlayerPrefs.GetString("Planet2Name");
        }
        else if (PlayerPrefs.GetInt("CurrentPlanet") == 3)
        {
            newText = IF.text;

            PlayerPrefs.SetString("Planet3Name", newText);

            IF.text = PlayerPrefs.GetString("Planet3Name");
        }
        //etc
     
    }
}
