using UnityEngine;
using UnityEngine.UI;

public class FPSDisplay : MonoBehaviour
{
    public Text fpsTxt;

    private float pollingTime = 1f;
    private float time;
    private int framCount;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        framCount++;

        if (time >= pollingTime)
        {
            int frameRate = Mathf.RoundToInt(framCount/time);
            fpsTxt.text = frameRate.ToString();

            time -= pollingTime;
            framCount = 0;
        }
    }
}
