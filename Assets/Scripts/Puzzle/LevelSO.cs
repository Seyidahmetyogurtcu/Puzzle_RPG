using System.Collections.Generic;
using UnityEngine;
namespace Puzzle_RPG
{
    [CreateAssetMenu()]
    public class LevelSO : ScriptableObject
    {
        public enum GoalType
        {
            Score,
        }

        public List<GemSO> gemList;
        public int width;
        public int height;
        public List<LevelGridPosition> levelGridPositionList;
        public GoalType goalType;
        public int moveAmount;
        public int targetScore;

        [System.Serializable]
        public class LevelGridPosition
        {
            public GemSO gemSO;
            public int x;
            public int y;
        }
    }
}