using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Magic8Ball : MonoBehaviour
{
    public TextMeshProUGUI answerText;
    public TextMeshProUGUI TutorialText;
    private string[] Answers =
        {
        // numbers represent the 20 sides of the hidden d20 floating in the magic blue liquid
            "It is certain (20)",
            "It is decidedly so (17)",
            "Without a doubt (19)",
            "Yes - definitely (18)",
            "You may rely on it (16)",
            "As I see it, yes (15)",
            "Most Likely (14)",
            "Outlook good (13)",
            "Yes (12)",
            "Signs point to yes (11)",
            "Reply hazy, try again (10)",
            "Ask again later (9)",
            "Better not tell you now (8)",
            "Can not predict now (7)",
            "Concentrate and ask again (6)",
            "Don't count on it (5)",
            "My reply is no (3)",
            "My sources say no (2)",
            "Outlook not so good (1)",
            "Very doubtful (4)",
        };
    //^angry french man
    //they were out of his croissants at la patissarie

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            int index = Random.Range(0, Answers.Length);
            TutorialText.enabled = false;
            answerText.text = Answers[index];
        }
    }
}
