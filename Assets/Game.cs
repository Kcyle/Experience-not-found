using UnityEngine;
using UnityEngine.UI;

// The only script in the game. Every window, button and email is wired up in the scene with UI events.
public class Game : MonoBehaviour
{
    public Slider yours, wanted; // your experience vs. what employers want
    public Text[] numbers;       // every number that goes up when you get rejected
    public GameObject crash;     // EXPERIENCE NOT FOUND

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
