using Leopotam.Ecs;
using UnityEngine;

namespace Tetris
{
    /*
     * TODO 
     * 1. ����˫�ˣ�������world������һ��world������ʲô�ô���
     * 2. ����˫����һ��world����ô��������board֮������룬λ�ã��ȵȲ���
     * 3. ��Ե�1��2���㣬�ƹ㵽����˹����99��
     * 
     * 
     */
    internal sealed class TetrisStartup : MonoBehaviour
    {
        public GameplayAssets gameplayAssets;
        public BatchRenderer batchRenderer;
        private EcsWorld m_World;
        private EcsSystems m_Systems;

        private void Start()
        {
            m_World = new EcsWorld();

            var gameCtx = new GameContext(m_World);
            gameCtx.batchRenderer = batchRenderer;

            m_Systems = new EcsSystems(m_World);

#if UNITY_EDITOR
            Leopotam.Ecs.UnityIntegration.EcsWorldObserver.Create(m_World);
            Leopotam.Ecs.UnityIntegration.EcsSystemsObserver.Create(m_Systems);
#endif
            m_Systems
                .Add(new DelaySystem())

                // logic
                .Add(new GameTimeSystem())
                .Add(new BoardCreateSystem())
                .Add(new PieceBagInitSystem())
                .Add(new GameInputSystem())
                .Add(new GameStartSystem())
                .Add(new PieceRotateSystem())
                .Add(new PieceMoveSystem())
                .Add(new PieceHoldSystem())
                .Add(new PieceResetDelaySystem())
                .Add(new AddToGridSystem())
                .Add(new LineClearSystem())
                .Add(new PieceNextSystem())
                .Add(new PieceSpawnSystem())
                .Add(new GameEndSystem())

                // view
                .Add(new PieceGhostSystem())
                .Add(new TileRendererSystem())
                .Add(new AudioSystem())
                .Add(new EffectSystem())

                  .OneFrame<GameStartRequest>()
                  //.OneFrame<GameEndComponent>()
                  //.OneFrame<AddToGridComponent>()
                  .OneFrame<PieceNextRequest>()
                  .OneFrame<PieceSpawnRequest>()
                  .OneFrame<LineClearRequest>()
                  .OneFrame<PieceRotationRequest>()
                  .OneFrame<PieceMoveRequest>()
                  .OneFrame<PieceDropRequest>()
                  .OneFrame<PieceHoldRequest>()
                  .OneFrame<PieceRotationSuccess>()
                  .OneFrame<PieceMoveSuccess>()
                  .OneFrame<PieceGhostUpdateRequest>()
                  .OneFrame<SEAudioEvent>()
                  .OneFrame<BGMAudioEvent>()
                  .OneFrame<EffectEvent>()

                 .Inject(gameplayAssets)
                 .Inject(gameCtx)
                 .ProcessInjects()
                .Init();
        }

        private void Update()
        {
            m_Systems?.Run();
        }

        private void OnDestroy()
        {
            if (m_Systems != null)
            {
                m_Systems.Destroy();
                m_Systems = null;
                m_World.Destroy();
                m_World = null;
            }
        }
    }
}