    class Weapon
    {
        private int _damage;
        private int _bullets;

        public int Bullets => _bullets;

        public void Fire(Player player)
        {
            player.TakeDamage(_damage);
            _bullets -= 1;
        }
    }

    class Player
    {
        private int _health;
        private bool _IsAlive;

        public bool IsAlive => _IsAlive;

        public void TakeDamage(int damage)
        {
            if (_IsAlive)
            {
                _health -= damage;

                if (_health <= 0)
                {
                    Die();
                }
            }
        }

        private void Die()
        {
            _IsAlive = false;
        }
    }

    class Bot
    {
        private Weapon _weapon;

        private void OnSeePlayer(Player player)
        {
            if (player.IsAlive && _weapon.Bullets > 0)
            {
                _weapon.Fire(player);
            }  
        }
    }