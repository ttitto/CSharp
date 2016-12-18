﻿using System;

namespace CompositionUsinChainOfResponsibility
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FamilyMember dad = new FamilyMember(new object[] { new Bearded("Dad"), new Emotional("Dad", "hoho") });
            FamilyMember mom = new FamilyMember(new object[] { new Hairy("Mom"), new Emotional("Mom", "hihi") });
            FamilyMember boy = new FamilyMember(new object[] { new Emotional("Boy", "haha") });
            FamilyMember dog = new FamilyMember(new object[] { new Emotional("Dog", "tail waiving") });

            Family family = new Family(new FamilyMember[] { dad, mom, boy, dog });

            family.WinterBegins();
            family.SummerComes();
            Console.ReadLine();
        }
    }
}
