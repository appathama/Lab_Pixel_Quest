using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class script : MonoBehaviour
{
    public string startscene;

    public void LoadLevel()
    {
        SceneManager.LoadScene(startscene);
    }


}
