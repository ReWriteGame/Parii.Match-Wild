using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameRules : MonoBehaviour
{
   public ScoreCounter score;
   public ScoreCounter life;

   public UnityEvent winGameEvent;
   public UnityEvent loseGameEvent;


   public Vector2Int border;
   public int minScore = 0;

   public void ScoreAdd()
   {
      score.add(Random.Range(border.x,border.y));
   }
   
   public void CheckGame()
   {
      if (score.Score >= minScore)
         winGameEvent?.Invoke();
      else loseGameEvent?.Invoke();
   }

}
