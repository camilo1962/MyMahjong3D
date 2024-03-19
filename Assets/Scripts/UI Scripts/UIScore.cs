using System.Text;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TMP_Text))]
public class UIScore : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private string Mensaje;
    private StringBuilder sbScore;

    private void OnEnable()
    {
        GameManager.ScoreChanged += OnScoreChanged;
        if (scoreText == null)
            Debug.LogError("'puntos de Texto' no se configuró en el inspector");
        sbScore = new StringBuilder();
    }
    private void OnDisable()
    {
        GameManager.ScoreChanged -= OnScoreChanged;
    }

    private void OnScoreChanged(object sender, int score)
    {
        sbScore.Clear();
        sbScore.Append(Mensaje).Append(score);
        scoreText.text = sbScore.ToString();
    }
}
