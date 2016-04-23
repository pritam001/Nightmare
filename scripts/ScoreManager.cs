using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public static int score;
	private int last_score;

    Text text;
	Animator anim;

    void Awake ()
    {
		anim = GetComponent<Animator>();
        text = GetComponent <Text> ();
        score = 0;
		last_score = score;
    }


    void Update ()
    {
		if (last_score != score)
		{
			Debug.Log(score);
			anim.SetTrigger("ScoreChanged");
			last_score = score;
        }
		text.text = "" + score;
    }
}
