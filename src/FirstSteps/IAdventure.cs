using FirstSteps.RPG.Heroes;

namespace FirstSteps
{
    public interface IAdventure
    {
        string Command { get; }
        public void Enter(Hero hero);
    }
}