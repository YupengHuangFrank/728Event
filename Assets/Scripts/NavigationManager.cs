using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationManager : MonoBehaviour
{
    [SerializeField] GameObject Main;
    [SerializeField] GameObject Bgms;
    [SerializeField] GameObject Questions;
    
    // Start is called before the first frame update
    void Start()
    {
        ToMain();
    }

    public void Clear(){
        Main.SetActive(false);
        Bgms.SetActive(false); 
        Questions.SetActive(false);
    }

    public void ToMain(){
        Clear();
        Debug.Log("To Main Page");
        Main.SetActive(true);
    }

    public void ToQuestions(){
        Clear();
        Debug.Log("To Questions Page");
        Questions.SetActive(true);
    }

    public void ToBgm(){
        Clear();
        Debug.Log("To Bgms Page");
        Bgms.SetActive(true);
    }
}
