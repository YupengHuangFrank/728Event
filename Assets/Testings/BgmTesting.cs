using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BgmTesting : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TextMeshProUGUI testText;
    [SerializeField] BgmManager BgmManager;

    void Start()
    {
        UpdateText();
    }

    void Update(){
        UpdateText();
    }

    public void Select(int idx){
        BgmManager.SelectBgm(idx);
        UpdateText();
    }

    void UpdateText(){
        testText.text = $"Selected Bgm: {string.Join(',', BgmManager.IsSelected)} \nCurrent Bgm: {BgmManager.CurrentBgmIdx}\nIsMuted: {BgmManager.IsMuted}";
    }

    public void Stop(){
        BgmManager.ChangeMute();
    }
}
