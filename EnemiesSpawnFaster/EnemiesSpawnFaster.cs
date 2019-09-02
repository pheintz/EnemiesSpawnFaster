using BepInEx;

namespace EnemiesSpawnFaster
{
    [BepInDependency("com.bepis.r2api")]
    [BepInPlugin("com.lloyd.EnemiesSpawnFaster", "Enemies Spawn Faster", "1.0.0")]
    public class EnemiesSpawnFaster : BaseUnityPlugin
    {
        public void Awake()
        {
            On.RoR2.CombatDirector.Simulate += (orig, self, deltaTime) =>
            {
                self.maxSeriesSpawnInterval = new float();
                self.maxSeriesSpawnInterval = 0.5f;
                self.maxSeriesSpawnInterval = new float();
                self.maxSeriesSpawnInterval = 2f;
                orig(self, deltaTime);
            };
        }
    }
}
