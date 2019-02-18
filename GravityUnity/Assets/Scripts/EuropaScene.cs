using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EuropaScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene("Europa");
        Physics.gravity = new Vector3(0.0f, -1.315f, 0.0f);
    }

}
