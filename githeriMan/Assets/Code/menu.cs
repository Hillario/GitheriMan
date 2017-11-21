using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour {


    private AudioSource myaudio;

	// Use this for initialization
	void Start () {
        myaudio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void play()
    {
        myaudio.Play();
        StartCoroutine("loadidle");
    }

    public void about()
    {
        myaudio.Play();
        StartCoroutine("loadabout");
    }

    public void close()
    {
        myaudio.Play();
        StartCoroutine("loadquit");
    }

    public IEnumerator loadidle() {

        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("idleplay");
    }

    public IEnumerator loadabout()
    {

        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("about");
    }

    public IEnumerator loadquit()
    {

        yield return new WaitForSeconds(1);
        Application.Quit();
    }
}
