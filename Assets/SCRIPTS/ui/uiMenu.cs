using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uiMenu : MonoBehaviour
{
    public void HomeA()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void BHOME()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void BSetting()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
    }
    public void BACKSettingsB()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
    }
    public void PretestA()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void PretestABACK()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
    public void PosttestA()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }
    public void PosttestABACK()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }
    public void PosttestB()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }
    public void PosttestBBACK()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }
    public void PlayEasy()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }
    public void PlayHard()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
    }
    public void Playback()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
    public void Playbackeasy()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }
    public void Playbackhard()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
    }
    public void Playeasylvl1back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
    public void Playeasylvl2back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }
    public void Playeasylvl3back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }
    public void Playeasylvl4back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
    }
    public void Playeasylvl5back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 6);
    }
    public void Playeasylvl6back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 7);
    }
    public void Playeasylvl7back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 8);
    }
    public void Playeasylvl8back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 9);
    }
    public void Playeasylvl9back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 10);
    }
    public void Playeasylvl10back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 11);
    }
    public void Playeasylvl1gtMainM()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 9);
    }
    public void Playeasylvl2gtMainM()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 10);
    }
    public void Playeasylvl3gtMainM()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 11);
    }
    public void Playeasylvl4gtMainM()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 12);
    }
    public void Playeasylvl5gtMainM()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 13);
    }
    public void Playeasylvl6gtMainM()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 14);
    }
    public void Playeasylvl7gtMainM()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 15);
    }
    public void Playeasylvl8gtMainM()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 16);
    }
    public void Playeasylvl9gtMainM()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 17);
    }
    public void Playeasylvl10gtMainM()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 18);
    }
    public void StoryM1MainM()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 18);
    }
    public void StoryModeDungeonArk()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 11);
    }

    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
