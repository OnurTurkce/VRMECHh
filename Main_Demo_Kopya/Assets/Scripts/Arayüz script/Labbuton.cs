using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Labbuton : MonoBehaviour
{
    public void Lab(string Lab)
    {
        SceneManager.LoadScene(Lab);
    }
 
}
