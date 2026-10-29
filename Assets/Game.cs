using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public Slider yours, wanted; 
    public Text[] numbers;       
    public GameObject crash;   

    public void Reject()
    {
        foreach (Text t in numbers) t.text = int.Parse(t.text) + 1 + "";
        wanted.value++;
        crash.SetActive(wanted.value == wanted.maxValue);
    }

    void Update() => yours.value = Mathf.Lerp(yours.value, 0, Time.deltaTime * 3); // nice try

    public void Restart() => UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    public void Quit() => Application.Quit();
}
