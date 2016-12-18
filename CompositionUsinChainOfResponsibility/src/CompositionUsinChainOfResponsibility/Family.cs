namespace CompositionUsinChainOfResponsibility
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Common;

    public class Family
    {
        private readonly IEnumerable<FamilyMember> members;

        public Family(IEnumerable<FamilyMember> members)
        {
            this.members = new List<FamilyMember>(members);
        }

        public void WinterBegins()
        {
            Console.WriteLine("Winter just came...");
            foreach (FamilyMember member in this.members)
            {
                IHairy hairy = member.As<IHairy>();
                if (null != hairy)
                {
                    hairy.GrowHair();
                }

                IBearded bearded = member.As<IBearded>();
                if (null != bearded)
                {
                    bearded.GrowBeard();
                }
            }

            Console.WriteLine(new string('-', 20));
        }

        public void SummerComes()
        {
            Console.WriteLine("Summer just came...");
            foreach (FamilyMember member in this.members)
            {
                IEmotional emotional = member.As<IEmotional>();
                if (null != emotional)
                {
                    emotional.BeHappy();
                }
            }

            Console.WriteLine(new string('-', 20));
        }
    }
}
