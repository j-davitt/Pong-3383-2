using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int scoreP1, scoreP2;
    public ScoreText scoreTextLeft, scoreTextRight;

    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
    public void OnScoreZoneReached(int id)
    {
        if(id == 1)
            scoreP1++;
        else if(id ==2)
            scoreP2++;

        UpdateScores();
    }

    private void UpdateScores()
    {
        scoreTextLeft.SetScore(scoreP1);
        scoreTextRight.SetScore(scoreP2);
    }
}
