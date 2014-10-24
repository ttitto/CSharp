namespace Infestation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MyHoldingPen : HoldingPen
    {
        protected override void ExecuteAddSupplementCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "AggressionCatalyst":
                    var aggCatalyst = new AggressionCatalyst();
                    this.GetUnit(commandWords[2]).AddSupplement(aggCatalyst);
                    break;
                case "PowerCatalyst":
                    var powerCatalyst = new PowerCatalyst();
                    this.GetUnit(commandWords[2]).AddSupplement(powerCatalyst);
                    break;
                case "HealthCatalyst":
                    var healthCatalyst = new HealthCatalyst();
                    this.GetUnit(commandWords[2]).AddSupplement(healthCatalyst);
                    break;
                case "Weapon":
                    var weapon = new Weapon();
                    this.GetUnit(commandWords[2]).AddSupplement(weapon);
                    break;
                //case "InfestationSpores":
                //    var infSpores = new InfestationSpores();
                //    this.GetUnit(commandWords[2]).AddSupplement(infSpores);
                //    break;
                default:
                    break;
            }
        }

        protected override void ExecuteInsertUnitCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "Tank":
                    var tank = new Tank(commandWords[2]);
                    this.InsertUnit(tank);
                    break;
                case "Marine":
                    var marine = new Marine(commandWords[2]);
                    this.InsertUnit(marine);
                    break;
                case "Parasite":
                    var parasite = new Parasite(commandWords[2]);
                    this.InsertUnit(parasite);
                    break;
                case "Queen":
                    var queen = new Queen(commandWords[2]);
                    this.InsertUnit(queen);
                    break;
                default:
                    break;
            }

            base.ExecuteInsertUnitCommand(commandWords);
        }

        protected override void ProcessSingleInteraction(Interaction interaction)
        {
            switch (interaction.InteractionType)
            {
                case InteractionType.Infest:
                    Unit targetUnit = this.GetUnit(interaction.TargetUnit);
                    targetUnit.AddSupplement(new InfestationSpores());
                    break;
                default:
                    break;
            }

            base.ProcessSingleInteraction(interaction);
        }
    }
}