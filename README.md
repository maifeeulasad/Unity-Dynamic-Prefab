# Unity-Dynamic-Prefab
Unity Dynamic Prefab-Based on level


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

<hr>
<br>


![Green Scene](https://raw.githubusercontent.com/maifeeulasad/Unity-Dynamic-Prefab/master/greenScene.png)




![Red scene](https://raw.githubusercontent.com/maifeeulasad/Unity-Dynamic-Prefab/master/redScene.png)
