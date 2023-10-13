using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NivelController
{
    private static NivelController _instance;
    public int NivelActual { get; private set; }

    private NivelController() { }

    public static NivelController Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new NivelController();
            }
            return _instance;
        }
    }
}
