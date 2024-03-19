using System;
using System.Text;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TMP_Text))]
public class UITimer : MonoBehaviour
{
    [SerializeField] private TMP_Text timeText;
    private StringBuilder sbTime;

    private void OnEnable()
    {
        GameManager.TimeLeftChanged += OnTimeLeftChanged;
        if (timeText == null)
            Debug.LogError("'timeText' no ha sido reflejado en el inspector");
        sbTime = new StringBuilder();
    }
    private void OnDisable()
    {
        GameManager.ScoreChanged -= OnTimeLeftChanged;
    }

    private void OnTimeLeftChanged(object sender, int timeLeft)
    {
        sbTime.Clear();
        //Esto no mostrará números negativos, pero nunca tendremos que mostrarlos de todos modos.
        sbTime.Append(TimeSpan.FromSeconds(timeLeft).ToString(@"m\:ss"));
        timeText.text = sbTime.ToString();
    }
}
