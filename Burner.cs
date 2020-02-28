using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burner : MonoBehaviour
{
    public StateManagement stateManagement;
    public void Start()
    {
        stateManagement.GetComponent<StateManagement>().WinLoad();
        stateManagement.GetComponent<StateManagement>().LostLoad();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Momo")
        {
            stateManagement.WinLoad();
        }
        else if (collision.gameObject.name == "Gaga")
        {
            stateManagement.LostLoad();
        }
        else if (collision.gameObject.name == "Bibi")
        {
            stateManagement.LostLoad();
        }
    }
}
