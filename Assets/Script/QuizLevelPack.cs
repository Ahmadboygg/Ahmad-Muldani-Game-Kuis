using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Create Quiz Level Pack", fileName = "New Quiz Level Pack")]
public class QuizLevelPack : ScriptableObject
{
    [SerializeField] private Quiz[] _quiz = new Quiz[0];
    public int muchLevel => _quiz.Length;

    public Quiz GetQuizLevel(int index)
    {
        return _quiz[index];
    }
}
