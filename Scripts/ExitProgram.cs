using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitProgram : MonoBehaviour
{

    public void EndProgram()
    {
        Application.Quit();
        Debug.Log("Program Ended");
    }
}
