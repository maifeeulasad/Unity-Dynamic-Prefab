using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MaterialController : MonoBehaviour
{
    public Material[] materials = new Material[2];

    void Awake()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        if (sceneName.Equals("RedScene"))
        {
            GetComponent<MeshRenderer>().material = materials[0];
        }
        else if (sceneName.Equals("GreenScene"))
        {
            GetComponent<MeshRenderer>().material = materials[1];
        }
    }
    
}
