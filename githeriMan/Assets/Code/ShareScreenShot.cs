using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class ShareScreenShot : MonoBehaviour {

    private bool isProcessing = false;

    private string shareText = "I travelled this far for my githeri points, BEAT THAT!?\n";
    private string gameLink = "Download the game on play store at " + "\nhttps://play.google.com/store/apps/details?id=com.codorps.mygitheriman";
    private string subject = "GitheriMan";

    public float bdistance;

    void Start()
    {
        bdistance = PlayerPrefs.GetFloat("ultimatedistance");
    }
    public void shareScreenShot() {
        StartCoroutine("capture");    
    }


    public IEnumerator capture()
    {
        yield return new WaitForSeconds(1);     
        shareText = "I travelled "+bdistance+"m for my githeri points, BEAT THAT!?\n";
        if (!isProcessing)
        {
            StartCoroutine("captureScreenShot");
        }   
    }

    public IEnumerator captureScreenShot() {
        isProcessing = true;
        //read the scren buffer after rendering is complete
        yield return new WaitForEndOfFrame();

        // Create a texture the size of the screen, RGB24 format
        int width = Screen.width;
        int height = Screen.height;

        Texture2D screenTexture = new Texture2D(width, height, TextureFormat.RGBA32, false);

        //Read screen contents into texture
        screenTexture.ReadPixels(new Rect(0, 0, width, height), 0, 0);
        screenTexture.Apply();

        //Encode texture into PNG
        byte[] mybytes = screenTexture.EncodeToPNG();
        Object.Destroy(screenTexture);

        string destination = Path.Combine(Application.persistentDataPath, System.DateTime.Now.ToString("yyyy-MM-dd-HHmmss") + ".png");
        File.WriteAllBytes(destination, mybytes);

        if (!Application.isEditor)
        {
            AndroidJavaClass intentClass = new AndroidJavaClass("android.content.Intent");
            AndroidJavaObject intentObject = new AndroidJavaObject("android.content.Intent");
            intentObject.Call<AndroidJavaObject>("setAction", intentClass.GetStatic<string>("ACTION_SEND"));
            AndroidJavaClass uriClass = new AndroidJavaClass("android.net.Uri");
            AndroidJavaObject uriObject = uriClass.CallStatic<AndroidJavaObject>("parse", "file://" + destination);
            intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_STREAM"), uriObject);
            intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_TEXT"), shareText + gameLink);
            intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_SUBJECT"), subject);
            intentObject.Call<AndroidJavaObject>("setType", "image/jpeg");
            AndroidJavaClass unity = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            AndroidJavaObject currentActivity = unity.GetStatic<AndroidJavaObject>("currentActivity");

            currentActivity.Call("startActivity", intentObject);

        }

        isProcessing = false;   
    
    
    }
}
