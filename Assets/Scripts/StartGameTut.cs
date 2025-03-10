using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameTut : MonoBehaviour
{
    private MissionUI missionUI;
    private AudioSource[] audioSources;

    private void Awake()
    {
        missionUI = FindObjectOfType<MissionUI>();
        audioSources = FindObjectsOfType<AudioSource>();
    }

    void Start()
    {
        List<string> missionList = new List<string> { "- Open the safe", "- Extract safely" };
        foreach (AudioSource audioSource in audioSources)
        {
            audioSource.volume *= ((float)GameManager.GetSound() / 10);
        }
        missionUI.SetMission(missionList);
    }
}
