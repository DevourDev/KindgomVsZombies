using System.Collections.Generic;
using UnityEngine;

namespace Game
{

    public class TowerRangeTrigger : MonoBehaviour
    {
        [SerializeField] private LayerMask _layers;

        [SerializeField] private List<Enemy> _enemiesInRange = new();


        public List<Enemy> EnemiesInRange => _enemiesInRange;


        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.TryGetComponent<Enemy>(out Enemy enemy))
            {
                _enemiesInRange.Add(enemy);
                Debug.Log($"enemy {enemy.name} added");
            }
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.TryGetComponent<Enemy>(out Enemy enemy))
            {
                _enemiesInRange.Remove(enemy);
                Debug.Log($"enemy {enemy.name} removed");
            }
        }
    }
}
