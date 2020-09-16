using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClientEvan : MonoBehaviour
{
    public Dropdown StyleDropdown;
    public Dropdown RowDropdown;
    public Dropdown HeightDropdown;

    public GameObject PlayerPosition;
    public GameObject Ace;
    public bool Height;
    public bool Row;
    public bool Style;

    public string TextContainer;
    public Vector3 Center = new Vector3(150, 0, 0);

    private static IPosition GetPosition(PositionRequirements requirements)
    {
        PositionFactory factory = new PositionFactory(requirements);
        return factory.Create();
    }

    public void InputGather()
    {
        if (StyleDropdown.value == 1)
        {
            Style = true; //Offensive
        }
        else
        {
            Style = false; //Defensive
        }

        if (RowDropdown.value == 1)
        {
            Row = true; //Front
        }
        else
        {
            Row = false; //Back
        }

        if (HeightDropdown.value == 1)
        {
            Height = true; //Tall
        }
        else
        {
            Height = false; //Short
        }

            PositionRequirements requirements = new PositionRequirements();
            requirements.Height = Height;
            requirements.Row = Row;
            requirements.Style = Style;

            IPosition p = GetPosition(requirements);
            //PlayerPosition = p.ToString();

            TextContainer = p.ToString();
            TextContainer += "_3D";
            Instantiate(Resources.Load(TextContainer), Center, Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
    }
}
