using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgmManager : MonoBehaviour
{

    public AudioSource[] AvailableBgms;
    public bool[] IsSelected;
    public int CurrentBgmIdx = 0;
    public bool CanChangeBgm = false;
    public bool IsMuted = false;
    
    private void Awake(){
        Debug.Log("Initialize BgmManager");
        Initialize();
    }

    private void Update(){
        if (IsMuted && AvailableBgms[CurrentBgmIdx].isPlaying){
            AvailableBgms[CurrentBgmIdx].Stop();
            return;
        }
        if (AvailableBgms[CurrentBgmIdx].isPlaying){
            return;
        } 
        PlayNext();
    }

    private void PlayNext(){
        // change to next selected bgm
        int i = CurrentBgmIdx + 1;
        while (i != CurrentBgmIdx){
            if (i == AvailableBgms.Length){
                i = 0;
            } else if (IsSelected[i]){
                CurrentBgmIdx = i;
                break;
            } else {
                i = i + 1;
            }
        }
        Debug.Log($"Play: {CurrentBgmIdx}");
        AvailableBgms[CurrentBgmIdx].Play();
    }

    public void Initialize() {
        IsSelected = new bool[AvailableBgms.Length];
        // the first bgm is default
        IsSelected[0] = true;
        Debug.Log($"Selected Status: {IsSelected[0]}, {IsSelected[1]}");
        PlayNext();
    }

    public void SelectBgm(int idx){
        IsSelected[idx] = !IsSelected[idx];
        Debug.Log($"Select: {idx}");
    }

    public void ChangeMute(){
        IsMuted = !IsMuted;
    }
}
