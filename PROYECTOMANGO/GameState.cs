using System;
using System.Timers;

namespace PROYECTOMANGO
{
    public sealed class GameState
    {
        private static readonly Lazy<GameState> lazy = new Lazy<GameState>(() => new GameState());
        public static GameState Instance => lazy.Value;

        private readonly Timer timer;
        private int tick;

        private readonly object sync = new object();

        // Estado público (lectura)
        public int Vida { get; private set; } = 100;
        public int Comida { get; private set; } = 100;
        public int Energia { get; private set; } = 100; // agua
        public int Experiencia { get; private set; } = 0;
        public int Nivel { get; private set; } = 0;

        // Intervalos (ticks de 1s)
        private readonly int vidaDecayInterval = 5;
        private readonly int comidaDecayInterval = 4;
        private readonly int energiaDecayInterval = 3;

        public event EventHandler StateChanged;

        private GameState()
        {
            timer = new Timer(1000);
            timer.Elapsed += Timer_Elapsed;
            timer.AutoReset = true;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            lock (sync)
            {
                tick++;

                if (tick % vidaDecayInterval == 0)
                {
                    Vida = Math.Max(0, Vida - 1);
                }
                if (tick % comidaDecayInterval == 0)
                {
                    Comida = Math.Max(0, Comida - 1);
                }
                if (tick % energiaDecayInterval == 0)
                {
                    Energia = Math.Max(0, Energia - 1);
                }
                // opcional: agregar pérdida de vida si comida/agua == 0
                if (Comida == 0 || Energia == 0)
                {
                    Vida = Math.Max(0, Vida - 1);
                }
            }

            StateChanged?.Invoke(this, EventArgs.Empty);
        }

        // Métodos para modificar estado (aseguran límites y notifican)
        public void AddComida(int amount)
        {
            lock (sync)
            {
                Comida = Math.Min(100, Comida + amount);
            }
            StateChanged?.Invoke(this, EventArgs.Empty);
        }

        public void AddEnergia(int amount)
        {
            lock (sync)
            {
                Energia = Math.Min(100, Energia + amount);
            }
            StateChanged?.Invoke(this, EventArgs.Empty);
        }

        public void AddVida(int amount)
        {
            lock (sync)
            {
                Vida = Math.Min(100, Vida + amount);
            }
            StateChanged?.Invoke(this, EventArgs.Empty);
        }

        public void AddExperiencia(int amount)
        {
            lock (sync)
            {
                Experiencia += amount;
                if (Experiencia >= 100)
                {
                    Experiencia = 0;
                    Nivel++;
                }
            }
            StateChanged?.Invoke(this, EventArgs.Empty);
        }

        // Para detener el temporizador si lo necesitas
        public void Stop()
        {
            timer.Stop();
        }

        public void Start()
        {
            timer.Start();
        }
    }
}