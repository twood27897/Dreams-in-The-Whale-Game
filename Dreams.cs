using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dreams : MonoBehaviour
{
    [Header("Dreams")]
    [SerializeField] private List<Dream> dreams = new List<Dream>();

    private List<Dream> EvaluateDreams()
    {
        List<Dream> validDreams = new List<Dream>();
        foreach (Dream dream in dreams)
        {
            bool conditionsMet = true;
            foreach (DreamCondition condition in dream.conditions)
            {
                if (!condition.Evaluate())
                {
                    conditionsMet = false;
                }
            }

            if (conditionsMet)
            {
                validDreams.Add(dream);
            }
        }
        
        return validDreams;
    }

    public void Dream()
    {
        List<Dream> validDreams = EvaluateDreams();

        int dreamsCount = validDreams.Count;
        if (dreamsCount > 0)
        {
            int randomDreamIndex = Random.Range(0, dreamsCount);

            Dream randomDream = validDreams[randomDreamIndex];

            dreams.Remove(randomDream);

            SceneManager.LoadScene(randomDream.sceneName);
        }
    }
}
