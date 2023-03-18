using System;
using UnityEngine;

namespace Game
{
    public class Tower : MonoBehaviour
    {
        [SerializeField] private TowerRangeTrigger _range;
        [SerializeField] private int _damage = 54;
        [SerializeField] private float _attackRate = 0.6f;

        private float _coolDown;
        private float _timeLeft;


        private void Awake()
        {
            _coolDown = 1f / _attackRate;
            ResetCountDown();
        }

        private void Update()
        {
            _timeLeft -= Time.deltaTime;

            if (_timeLeft <= 0 && TryShoot())
            {
                ResetCountDown();
            }
        }


        private void ResetCountDown()
        {
            _timeLeft = _coolDown;
        }

        private bool TryShoot()
        {
            if (_range.EnemiesInRange.Count == 0)
                return false;

            Shoot();
            return true;
        }

        private void Shoot()
        {
            var collection = _range.EnemiesInRange;

            //v3 (10, 9, 8) => v2(10, 9)
            //v2(10, 9) => v3(10, 9, 0)

            Vector2 ourPosition = transform.position;

            float distanceToClosestEnemy = float.PositiveInfinity;
            Enemy closestEnemy = null;

            foreach (var enemy in collection)
            {
                var distance = Vector2.Distance(ourPosition, enemy.transform.position);

                if (distance < distanceToClosestEnemy)
                {
                    distanceToClosestEnemy = distance;
                    closestEnemy = enemy;
                }
            }

            if (closestEnemy == null)
                throw new Exception("No enemies in range");

            closestEnemy.CurrentHealth -= _damage;

            if (closestEnemy.CurrentHealth <= 0)
            {
                //_range.EnemiesInRange.Remove(closestEnemy);

                closestEnemy.CurrentHealth = 0;
                Destroy(closestEnemy.gameObject);
                UnityEngine.Debug.Log("enemy destroyed!");
            }
        }
    }
}
