using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    [Header("Component")]
    public TextMeshProUGUI timerText;

    [Header("Timer Settings")]
    public float currentTime;
    public bool countDown;

    [Header("Limit Settings")]
    public bool hasLimit;
    public float timerLimit;

    [SerializeField] private UnityEvent onDone;
    [SerializeField] private GameObject gameover;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;
        if (currentTime < 0)
        {
            currentTime = timerLimit;
            SetTimerText();
            timerText.color = Color.red;
            enabled = false;
            onDone.Invoke();
            gameover.SetActive(true);
            // public string nextLevel = "gameover";
            // SceneManager.LoadScene(nextLevel);
        }
        SetTimerText();
    }

    private void SetTimerText()
    {
        if (currentTime > 0)
        {
            timerText.text = currentTime.ToString("F0");
        }
    }
}
