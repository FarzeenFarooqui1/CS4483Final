using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Dan.Main;
using UnityEngine.Rendering.VirtualTexturing;

public class Leaderboard : MonoBehaviour
{
    [SerializeField]
    private List<TextMeshProUGUI> names;
    [SerializeField]
    private List<TextMeshProUGUI> scores;

    public GameObject gameOverScreen;

    private string publicLeaderboardKey = "0a5a55b03e0dc9c0aa000bf41d0bc811acdbb2ba4238a7a0acf480694ffb8826";

    private void Start()
    {
        GetLeaderboard();
    }

    private void Update()
    {
        if (gameOverScreen.activeSelf) {
            GetLeaderboard();
        }
    }

    public void GetLeaderboard()
    {
        LeaderboardCreator.GetLeaderboard(publicLeaderboardKey, ((msg) =>
        {
            int loopLength = (msg.Length < names.Count) ? msg.Length : names.Count;
            for (int i = 0; i < loopLength; ++i)
            {
                names[i].text = msg[i].Username;
                scores[i].text = msg[i].Score.ToString();
            }
        }));
    }

    public void SetLeaderboardEntry(string username, int score)
    {
        LeaderboardCreator.UploadNewEntry(publicLeaderboardKey, username, score, ((msg) =>
        {
            username.Substring(0, 4);
            GetLeaderboard();
        }));
    }
}
