# Movimentos — IA e Animator

Projeto Unity com patrulha entre pontos, percepção do jogador, perseguição e animação de ataque.

## Abrir e testar

1. Clone ou baixe este repositório.
2. Adicione a pasta no Unity Hub e abra com **Unity 6000.3.3f1**.
3. Abra `Assets/Scenes/SampleScene.unity` e pressione Play.

O inimigo caminha entre os pontos configurados, espera 2 segundos em Idle e segue a patrulha. Ao detectar o jogador dentro do campo de visão e sem obstáculo, persegue e executa a animação de ataque a até 6 metros. Volta a perseguir quando o alvo se afasta.

## Configuração

- O objeto `enemy` contém Animator, NavMeshAgent e os componentes da IA.
- `Enemy Movement > Patrol Points` define a sequência de patrulha.
- `Enemy Brain` permite ajustar velocidades, tempo de espera e alcance de ataque.
- `Enemy Sensor` configura alcance, ângulo e obstáculos da visão.
- Controller: `Assets/Animations/enemy.controller`.

As animações utilizam o esqueleto Mixamo. O ataque é visual; não há sistema de projéteis, vida ou dano integrado ao jogador.

Os pacotes são restaurados pelo Unity. Cache, logs e arquivos temporários não fazem parte do repositório.
